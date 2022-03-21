using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_Application
{
    public partial class frm_01_CoursesEdit : DevExpress.XtraEditors.XtraForm
    {
        string CourseID;

        public frm_01_CoursesEdit(string courseid)
        {
            CourseID = courseid;
            InitializeComponent();
        }

        private void frm_01_EditClass_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                cbb_ClassList.DataSource = db.tb_ClassRooms.ToList();
                cbb_ClassList.DisplayMember = "col_RoomID";
            }
            if (CourseID == "")
            {
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
                txt_TeacherID.Text = User.Teacher.col_TeacherID.ToString();
                txt_TeacherID.Enabled = false;
            }
            else
            {
                int coursesid = Convert.ToInt32(CourseID);
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    var Course = db.tb_Courses.Find(coursesid);
                    txt_CourseID.Text = Course.col_CoursesID.ToString();
                    txt_CourseName.Text = Course.col_CoursesName;
                    txt_DayoWeek.Text = Course.col_DayoWeek;
                    txt_TeacherID.Text = Course.col_TeacherID.ToString();
                    cbb_Semester.Text = Course.col_Semester;
                    txt_Status.Text = Course.col_Status;
                    date_Start.Text = Course.col_DateStr.Value.ToShortDateString();
                    date_End.Text = Course.col_DateEnd.Value.ToShortDateString();
                    cbb_ClassList.Text = Course.col_RoomID;
                }
                btn_Add.Enabled = false;
                txt_TeacherID.Enabled = false;
                cbb_Semester.Enabled = false;
                txt_CourseName.Enabled = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_CourseName.Text == "" || cbb_Semester.Text == "")
            {
                XtraMessageBox.Show("Thông tin học phần không được để trống.", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tb_Courses Course;
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    db.tb_Courses.Add(new tb_Courses()
                    {
                        col_CoursesName = txt_CourseName.Text,
                        col_DateEnd = DateTime.Parse(date_End.Text),
                        col_DateStr = DateTime.Parse(date_Start.Text),
                        col_DayoWeek = txt_DayoWeek.Text,
                        col_Semester = cbb_Semester.Text,
                        col_Status = txt_Status.Text,
                        col_TeacherID = txt_TeacherID.Text,
                        col_RoomID = cbb_ClassList.Text
                    });
                    db.SaveChanges();
                    Course = db.tb_Courses.Where(p =>p.col_CoursesName == txt_CourseName.Text && p.col_TeacherID == txt_TeacherID.Text).FirstOrDefault();
                    alert_Message.Show(this, "Thành công", "Tạo học phần mới thành công.");
                }
                txt_CourseID.Text = Course.col_CoursesID.ToString();
                txt_CourseName.Enabled = false;
                cbb_Semester.Enabled = false;
                btn_Add.Enabled = false;
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Xác nhận thay đổi thông tin của lớp học phần", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        var tb = db.tb_Courses.Find(Convert.ToInt32(txt_CourseID.Text));
                        tb.col_CoursesName = txt_CourseName.Text;
                        tb.col_DateEnd = DateTime.Parse(date_End.Text);
                        tb.col_DateStr = DateTime.Parse(date_Start.Text);
                        tb.col_DayoWeek = txt_DayoWeek.Text;
                        tb.col_Semester = cbb_Semester.Text;
                        tb.col_Status = txt_Status.Text;
                        tb.col_TeacherID = txt_TeacherID.Text;
                        tb.col_RoomID = cbb_ClassList.Text;
                        db.Entry(tb).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        alert_Message.Show(this, "Thành công.", "Thay đổi thông tin học phần thành công.");
                    }
                }
                catch
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi không mong muốn.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Không được phép xóa.", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void date_Start_TextChanged(object sender, EventArgs e)
        {
            txt_DayoWeek.Text = DateTime.Parse(date_Start.Text).DayOfWeek.ToString();
        }
    }
}
