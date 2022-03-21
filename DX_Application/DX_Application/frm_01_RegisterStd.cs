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
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace DX_Application
{
    public partial class frm_01_RegisterStd : DevExpress.XtraEditors.XtraForm
    {
        private string MSSV;

        public frm_01_RegisterStd(string mssv)
        {
            MSSV = mssv;
            InitializeComponent();
        }

        private void frm_01_RegisterStd_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                var result = db.tb_Students.Find(MSSV);
                txt_StudentID.Text = result.col_StudentID;
                txt_FName.Text = result.col_FName;
                txt_Major.Text = result.col_Major;
                txt_Phone.Text = result.col_Phone;
                txt_Email.Text = result.col_Email;
                date_Birthday.Text = result.col_DayoBirth.ToShortDateString();
                bool sex = result.col_Sex.Value ? rdo_Male.Checked = true : rdo_Female.Checked = true;
                MemoryStream stream = new MemoryStream(result.col_Avatar);
                if (stream == null)
                {
                    return;
                }
                img_Avatar.Image = Image.FromStream(stream);

                grid_Registered.DataSource = (from courses in db.tb_Courses
                                              join register in db.tb_RegisterCourses
                                              on courses.col_CoursesID equals register.col_CoursesID
                                              where register.col_StudentID == txt_StudentID.Text
                                              select courses).ToList();

                grid_Register.DataSource = db.tb_Courses.Where(p => p.col_TeacherID == User.Teacher.col_TeacherID).ToList();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            GridView view = view_Register;
            Int32[] rowselect = view_Register.GetSelectedRows();
            List<tb_Courses> courses = Selected(rowselect, view);
            if (courses == null || courses.Count == 0)
            {
                XtraMessageBox.Show("Không có học phần nào được chọn", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (tb_Courses item in courses)
                {
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        tb_RegisterCourses result = db.tb_RegisterCourses.Where(
                            p => p.col_StudentID == txt_StudentID.Text &&
                            p.col_CoursesID == item.col_CoursesID).FirstOrDefault();
                        if (result != null)
                        {
                            XtraMessageBox.Show($"Học phần \"{item.col_CoursesName}\" đã đăng kí rồi.\nKhông được đăng kí thêm", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            db.tb_RegisterCourses.Add(new tb_RegisterCourses
                            {
                                col_CoursesID = item.col_CoursesID,
                                col_StudentID = txt_StudentID.Text,
                                col_Status = "Đăng kí cho sinh viên"
                            });
                            db.SaveChanges();
                            alert_Message.Show(this, "Thành công.", $"Đăng kí học phần \"{item.col_CoursesName}\" thành công.");
                        }
                    }
                }
            }
            frm_01_RegisterStd_Load(sender, e);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            GridView view = view_Registered;
            Int32[] rowselect = view_Registered.GetSelectedRows();
            List<tb_Courses> courses = Selected(rowselect, view);
            if (courses == null || courses.Count == 0)
            {
                XtraMessageBox.Show("Không có học phần nào được chọn", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Xác nhận hủy đăng kí các học phần của sinh viên này ?", "Xác nhận.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.OK)
                {
                    foreach (tb_Courses item in courses)
                    {
                        using (db_AttendedEntities db = new db_AttendedEntities())
                        {
                            if (item.col_TeacherID != User.Teacher.col_TeacherID)
                            {
                                XtraMessageBox.Show($"Không thể xóa sinh viên khỏi học phần \"{item.col_CoursesName}\".", "Cảnh báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                tb_RegisterCourses tb = db.tb_RegisterCourses.Where(p
                                    => p.col_StudentID == txt_StudentID.Text && p.col_CoursesID == item.col_CoursesID).FirstOrDefault();
                                db.Entry(tb).State = EntityState.Deleted;
                                db.SaveChanges();
                                alert_Message.Show(this, "Thành công.", $"Hủy học phần \"{item.col_CoursesName}\" thành công.");
                            }
                        }
                    }
                }
            }
            frm_01_RegisterStd_Load(sender, e);
        }

        private List<tb_Courses> Selected(Int32[] rowselect,GridView gridview)
        {
            List<tb_Courses> list = new List<tb_Courses>();
            foreach (int item in rowselect)
            {
                list.Add(new tb_Courses()
                {
                    col_CoursesID = Convert.ToInt32(gridview.GetRowCellValue(item, "col_CoursesID")),
                    col_CoursesName = gridview.GetRowCellValue(item, "col_CoursesName").ToString(),
                    col_DateEnd = DateTime.Parse(gridview.GetRowCellValue(item, "col_DateEnd").ToString()),
                    col_DateStr = DateTime.Parse(gridview.GetRowCellValue(item, "col_DateStr").ToString()),
                    col_DayoWeek = gridview.GetRowCellValue(item, "col_DayoWeek").ToString(),
                    col_RoomID = gridview.GetRowCellValue(item, "col_RoomID").ToString(),
                    col_Semester = gridview.GetRowCellValue(item, "col_Semester").ToString(),
                    col_Status = gridview.GetRowCellValue(item, "col_Status").ToString(),
                    col_TeacherID = gridview.GetRowCellValue(item, "col_TeacherID").ToString()
                });
            }
            return list;
        }
    }
}