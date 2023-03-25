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
using System.Threading;
using System.IO;

namespace DX_Application
{
    public partial class frm_GetFaceData : DevExpress.XtraEditors.XtraForm
    {
        public frm_GetFaceData()
        {
            InitializeComponent();
        }

        private void btn_LockID_Click(object sender, EventArgs e)
        {
            if (txt_StudentID.Enabled) txt_StudentID.Enabled = false;
            else txt_StudentID.Enabled = true;
        }

        private void btn_LockName_Click(object sender, EventArgs e)
        {
            if (txt_FName.Enabled) txt_FName.Enabled = false;
            else txt_FName.Enabled = true;
        }

        private void btn_LockBirthday_Click(object sender, EventArgs e)
        {
            if (date_Birthday.Enabled) date_Birthday.Enabled = false;
            else date_Birthday.Enabled = true;
        }

        private void btn_LockMajor_Click(object sender, EventArgs e)
        {
            if (txt_Major.Enabled) txt_Major.Enabled = false;
            else txt_Major.Enabled = true;
        }

        private void btn_LockEmail_Click(object sender, EventArgs e)
        {
            if (txt_Email.Enabled) txt_Email.Enabled = false;
            else txt_Email.Enabled = true;
        }

        private void btn_LockPhone_Click(object sender, EventArgs e)
        {
            if (txt_Phone.Enabled) txt_Phone.Enabled = false;
            else txt_Phone.Enabled = true;
        }

        private void btn_LockSum_Click(object sender, EventArgs e)
        {
            if (txt_Sum.Enabled) txt_Sum.Enabled = false;
            else txt_Sum.Enabled = true;
        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            Shared shared = new Shared();
            string path = "D:\\Project\\App_FaceRecognition\\Data\\";
            if (txt_StudentID.Text == "" || txt_FName.Text == "" || date_Birthday.Text == "")
            {
                XtraMessageBox.Show($"MSSV, Họ tên và ngày sinh không được để trống.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (shared.CheckStudent(txt_StudentID.Text))
            {
                XtraMessageBox.Show("MSSV là không được trùng nhau", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Directory.Exists(path + txt_StudentID.Text))
            {
                XtraMessageBox.Show($"Đường dẫn \"{path + txt_StudentID.Text}\" đã tồn tại.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_Sum.Text != "")
                {
                    Directory.CreateDirectory(path + txt_StudentID.Text);
                    int sum = Convert.ToInt32(txt_Sum.Text);
                    Thread th = new Thread(() =>
                    {
                        Captureimg(path + txt_StudentID.Text, sum, sum);
                    });
                    th.IsBackground = false;
                    th.Start();
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        db.tb_Students.Add(new tb_Students
                        {
                            col_StudentID = txt_StudentID.Text,
                            col_FName = txt_FName.Text,
                            col_DayoBirth = DateTime.Parse(date_Birthday.Text),
                            col_Major = txt_Major.Text,
                            col_Email = txt_Email.Text + cbb_Email.Text,
                            col_Phone = txt_Phone.Text,
                            col_Sex = rdo_Male.Checked ? true : false,
                            col_Avatar = null
                        });
                        db.SaveChanges();
                        alert_Message.Show(this, "Thành công.", "Thêm sinh viên thành công.");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chư nhập số lượng ảnh cần chụp.", "Cảnh báo.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (txt_Email.Enabled) txt_Email.Text = "";
            if (txt_FName.Enabled) txt_FName.Text = "";
            if (txt_Major.Enabled) txt_Major.Text = "";
            if (txt_Phone.Enabled) txt_Phone.Text = "";
            if (txt_StudentID.Enabled) txt_StudentID.Text = "";
            if (txt_Sum.Enabled) txt_Sum.Text = "";
            if (date_Birthday.Enabled) date_Birthday.Text = "";
        }

        private void Captureimg(string path, int sum, int count)
        {
            if (count > 0)
            {
                Console.WriteLine($"Count Capture: {sum - (count - 1)}");
                int val = (sum - (count - 1));
                var img = cam_GetData.TakeSnapshot();
                MemoryStream stream = new MemoryStream();
                Image pic = (Image)img; //(new Bitmap(img, new Size(224, 244)))
                pic.Save($"{path}\\{val}.png");
                Thread.Sleep(150);
                Captureimg(path, sum, --count);
            }
            else Console.WriteLine($"Compeleted !!!");
        }
    }
}