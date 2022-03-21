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
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace DX_Application
{
    public partial class frm_01_RegisterCour : DevExpress.XtraEditors.XtraForm
    {
        string CoursesID;

        public frm_01_RegisterCour(string coursesid)
        {
            CoursesID = coursesid;
            InitializeComponent();
        }

        private void frm_01_RegisterCour_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CoursesID);
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_AllStudent.DataSource = db.tb_Students.ToList();
                grid_Student.DataSource = (from student in db.tb_Students
                                           join register in db.tb_RegisterCourses
                                           on student.col_StudentID equals register.col_StudentID
                                           where register.col_CoursesID == id
                                           select student).ToList();
                tb_Courses courses = db.tb_Courses.Find(Convert.ToInt32(CoursesID));
                txt_CoursesID.Text = courses.col_CoursesID.ToString();
                txt_CoursesName.Text = courses.col_CoursesName.ToString();
                txt_DateEnd.Text = courses.col_DateEnd.Value.ToShortDateString();
                txt_DateStr.Text = courses.col_DateStr.Value.ToShortDateString();
                txt_DayoWeek.Text = courses.col_DayoWeek;
                txt_RoomID.Text = courses.col_RoomID;
                txt_Semester.Text = courses.col_Semester;
                txt_Status.Text = courses.col_Status;
                txt_TeacherID.Text = courses.col_TeacherID;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_CoursesID.Text);
            GridView view = view_AllStudent;
            Int32[] rowselect = view_AllStudent.GetSelectedRows();
            List<tb_Students> list = Selected(rowselect, view);
            if(list == null || list.Count == 0)
            {
                XtraMessageBox.Show("Không có sinh viên nào được chọn.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Xác nhận thêm các sinh viên đã chọn vào lớp học phần này", "Xác nhận.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    foreach (tb_Students student in list)
                    {
                        using (db_AttendedEntities db = new db_AttendedEntities())
                        {
                            tb_RegisterCourses register = db.tb_RegisterCourses.Where(p
                                => p.col_CoursesID == id &&
                                p.col_StudentID == student.col_StudentID).FirstOrDefault();
                            if (register != null)
                            {
                                XtraMessageBox.Show($"Sinh viên \"{student.col_FName}\" đã tồn tại trong lớp.", "Cảnh báo.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                db.tb_RegisterCourses.Add(new tb_RegisterCourses
                                {
                                    col_CoursesID = Convert.ToInt32(txt_CoursesID.Text),
                                    col_StudentID = student.col_StudentID,
                                    col_Status = "Đăng kí theo lớp"
                                });
                                alert_Message.Show(this, "Thành công.", $"Thêm sinh viên \"{student.col_FName}\" thành công.");
                            }
                            db.SaveChanges();
                        }
                    }
                }
            }
            frm_01_RegisterCour_Load(sender, e);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_CoursesID.Text);
            GridView view = view_Student;
            Int32[] rowselect = view_Student.GetSelectedRows();
            List<tb_Students> list = Selected(rowselect, view);
            if (list == null || list.Count == 0)
            {
                XtraMessageBox.Show("Không có sinh viên nào được chọn.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialog = XtraMessageBox.Show("Xác nhận xóa các sinh viên đã chọn khỏi lớp học phần này", "Xác nhận.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    foreach (tb_Students student in list)
                    {
                        using (db_AttendedEntities db = new db_AttendedEntities())
                        {
                            tb_RegisterCourses register = db.tb_RegisterCourses.Where(p
                                => p.col_CoursesID == id &&
                                p.col_StudentID == student.col_StudentID).FirstOrDefault();
                            if (register == null)
                            {
                                XtraMessageBox.Show($"Sinh viên \"{student.col_FName}\" không tồn tại trong lớp.", "Cảnh báo.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                db.Entry(register).State = EntityState.Deleted;
                                db.SaveChanges();
                                alert_Message.Show(this, "Thành công.", $"Xóa sinh viên \"{student.col_FName}\" thành công.");
                            }
                            db.SaveChanges();
                        }
                    }
                }
            }
            frm_01_RegisterCour_Load(sender, e);
        }

        private List<tb_Students> Selected(Int32[] rowselect, GridView gridview)
        {
            List<tb_Students> list = new List<tb_Students>();
            foreach (int item in rowselect)
            {
                list.Add(new tb_Students()
                {
                    col_StudentID = gridview.GetRowCellValue(item, "col_StudentID").ToString(),
                    col_FName = gridview.GetRowCellValue(item, "col_FName").ToString()
                });
            }
            return list;
        }
    }
}