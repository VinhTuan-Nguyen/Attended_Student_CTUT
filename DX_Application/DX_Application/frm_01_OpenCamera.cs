using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using RestSharp;
using Newtonsoft.Json;
using System.Data.Entity;

namespace DX_Application
{
    public partial class frm_01_OpenCamera : XtraForm
    {
        int CoursesID;
        string RoomID;
        List<tb_Attended> List_Attended = new List<tb_Attended>();
        List<tb_RegisterCourses> List_Class = new List<tb_RegisterCourses>();
        Shared shared = new Shared();

        class Picture
        {
            public string data { get; set; }
        }

        class Result
        {
            public string label { get; set; }
            public float accuracy { get; set; }
        }

        public frm_01_OpenCamera(string coursesid, string roomid)
        {
            InitializeComponent();
            CoursesID = int.Parse(coursesid);
            RoomID = roomid;
        }

        private void frm_01_OpenCamera_Load(object sender, EventArgs e)
        {
            txt_Date.Text = DateTime.Now.ToString();
            txt_CoursesID.Text = CoursesID.ToString();
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                List_Class = db.tb_RegisterCourses.Where(p => p.col_CoursesID == CoursesID).ToList();
                var result = db.tb_Courses.Find(CoursesID);
                txt_CoursesName.Text = result.col_CoursesName;
                txt_DateEnd.Text = DateTime.Parse(result.col_DateEnd.ToString()).ToShortDateString();
                txt_DateStr.Text = DateTime.Parse(result.col_DateStr.ToString()).ToShortDateString();
                txt_DayoWeek.Text = result.col_DayoWeek;
                txt_RoomID.Text = RoomID;
                txt_Semester.Text = result.col_Semester;
                txt_Status.Text = result.col_Status;
                txt_TeacherID.Text = result.col_TeacherID;
                lb_SumStudent.Text = db.tb_RegisterCourses.Where(p => p.col_CoursesID == CoursesID).Count().ToString();
            }
        }

        private void btn_Attended_Click(object sender, EventArgs e)
        {
            if (lb_Label.Text == "??????????")
            {
                XtraMessageBox.Show("Không thể nhận diện được.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    DateTime day = DateTime.Parse(txt_Date.Text);
                    TimeSpan time = DateTime.Parse(txt_Time.Text).TimeOfDay;
                    var result = List_Class.Where(p
                        => p.col_StudentID == lb_Label.Text).FirstOrDefault();
                    if (result == null)
                    {
                        XtraMessageBox.Show($"MSSV \"{lb_Label.Text}\" không thuộc lớp này.", "Cảnh báo.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var check = List_Attended.Where<tb_Attended>(p
                            => p.col_StudentID == lb_Label.Text).FirstOrDefault();
                        if (check != null)
                        {
                            XtraMessageBox.Show($"MSSV \"{lb_Label.Text}\" đã điểm danh rồi.", "Cảnh báo.",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            tb_RegisterCourses tb = List_Class.Where(p
                                => p.col_StudentID == lb_Label.Text).FirstOrDefault();
                            List_Class.Remove(tb);
                            List_Attended.Add(new tb_Attended()
                            {
                                col_CoursesID = CoursesID,
                                col_DateAtd = day,
                                col_TimeAtd = time,
                                col_TeacherID = User.Teacher.col_TeacherID,
                                col_StudentID = lb_Label.Text,
                                col_RoomID = txt_RoomID.Text,
                                col_Note = "Có mặt"
                            });
                            alert_Message.Show(this,
                                "Thành công.",
                                $"MSSV \"{lb_Label.Text}\" đã điểm danh thành công lúc {txt_Time.Text}.");
                        }
                    }
                }
                lb_CountStudent.Text = List_Attended.Count().ToString();
            }
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            if (List_Attended.Count != 0)
            {
                DialogResult result = XtraMessageBox.Show("Xác nhận kết thúc buổi điểm danh.", "Xác nhận.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (List_Class.Count != 0)
                    {
                        DateTime day = DateTime.Parse(txt_Date.Text);
                        TimeSpan time = DateTime.Parse(txt_Time.Text).TimeOfDay;
                        foreach (tb_RegisterCourses item in List_Class)
                        {
                            List_Attended.Add(new tb_Attended()
                            {
                                col_CoursesID = CoursesID,
                                col_DateAtd = day,
                                col_TimeAtd = time,
                                col_TeacherID = User.Teacher.col_TeacherID,
                                col_StudentID = item.col_StudentID,
                                col_RoomID = txt_RoomID.Text,
                                col_Note = "Vắng không phép"
                            });
                        }
                    }
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        foreach (tb_Attended item in List_Attended)
                        {
                            db.Entry(item).State = EntityState.Added;
                            db.SaveChanges();
                        }
                        alert_Message.Show(this, "Thành công.", "Kết quả điểm danh đã được lưu.");
                    }
                    this.Hide();
                    timer1.Stop();
                    cam_Layout.Stop();
                    frm_01_Summary f = new frm_01_Summary(txt_RoomID.Text, txt_Date.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Chưa có sinh viên nào điểm danh.\n" +
                    "Đồng ý thoát điểm danh.", "Xác nhận.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    timer1.Stop();
                    cam_Layout.Stop();
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BringToFront();
            txt_Time.Text = DateTime.Now.ToString();
            try
            {
                var pix = cam_Layout.TakeSnapshot();
                MemoryStream stream = new MemoryStream();
                Image pic = (Image)pix;
                pic.Save(stream, ImageFormat.Jpeg);
                Picture img = new Picture()
                {
                    data = Convert.ToBase64String(stream.ToArray())
                };
                string json = JsonConvert.SerializeObject(img);
                var client = new WebClient();
                var d = client.UploadString("http://127.0.0.1:8080/predict", "POST", json);
                Result result = JsonConvert.DeserializeObject<Result>(d);
                if (result.accuracy >= 90)
                {
                    lb_Label.Text = result.label;
                    lb_Accuracy.Text = $"{result.accuracy}%";
                }
                else
                {
                    lb_Label.Text = "??????????";
                    lb_Accuracy.Text = "????????";
                }
            }
            catch
            {
                timer1.Stop();
                cam_Layout.Stop();
                XtraMessageBox.Show("Không thể kết nối với Server nhận diện gương mặt.\n" +
                    "Vui lòng tắt điểm danh và thử lại.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (shared.Encode(txt_Password.Text) == User.Account.col_Password)
            {
                btn_Done.Enabled = true;
            }
            else btn_Done.Enabled = false;
        }
    }
}