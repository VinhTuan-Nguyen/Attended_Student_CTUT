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
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace DX_Application
{
    public partial class frm_01_Attended : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_Attended()
        {
            InitializeComponent();
        }
        
        private void frm_01_Attended_Load(object sender, EventArgs e)
        {
            txt_TeacherID.Text = User.Teacher.col_TeacherID;
            bool sex = User.Teacher.col_Sex.Value ? rdo_Male.Checked = true : rdo_Female.Checked = true;
            txt_Phone.Text = User.Teacher.col_Phone;
            txt_FullName.Text = User.Teacher.col_FName;
            txt_Email.Text = User.Teacher.col_Email;
            txt_Department.Text = User.Teacher.col_Department;
            MemoryStream memory = new MemoryStream(User.Teacher.col_Avatar);
            Image img = Image.FromStream(memory);
            if (img == null)
            {
                return;
            }
            img_Avatar.Image = img;
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_Class.DataSource = db.tb_Courses.Where(p => p.col_TeacherID == User.Teacher.col_TeacherID).ToList();
            }
        }

        private void view_Class_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txt_CoursesID.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_CoursesID").ToString();
                txt_CoursesName.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_CoursesName").ToString();
                txt_DayoWeek.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_DayoWeek").ToString();
                txt_Semester.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_Semester").ToString();
                txt_Status.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_Status").ToString();
                txt_TeacherID1.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_TeacherID").ToString();
                txt_RoomID.Text = view_Class.GetRowCellValue(e.FocusedRowHandle, "col_RoomID").ToString();
                date_Start.Text = DateTime.Parse(view_Class.GetRowCellValue(e.FocusedRowHandle, "col_DateStr").ToString()).ToShortDateString();
                date_End.Text = DateTime.Parse(view_Class.GetRowCellValue(e.FocusedRowHandle, "col_DateEnd").ToString()).ToShortDateString();
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    int id = int.Parse(txt_CoursesID.Text);
                    var tk = db.tb_Attended.Where(p => p.col_CoursesID == id).ToList();
                    lb_Differ.Text = tk.Where(p
                        => p.col_Note != "Có mặt"
                        && p.col_Note != "Vắng không phép"
                        && p.col_Note != "Vắng có phép").Count().ToString();
                    lb_Not.Text = tk.Where(p
                        => p.col_Note == "Vắng không phép").Count().ToString();
                    lb_NotYet.Text = tk.Where(p
                        => p.col_Note == "Vắng có phép").Count().ToString();
                    lb_Yes.Text = tk.Where(p
                        => p.col_Note == "Có mặt").Count().ToString();
                }
            }
        }

        private void btn_OpenAttended_Click(object sender, EventArgs e)
        {
            frm_SelectRoom f = new frm_SelectRoom(txt_CoursesID.Text);
            f.ShowDialog();
        }

        private void btn_ClassView_Click(object sender, EventArgs e)
        {
            int coursesid = Convert.ToInt32(txt_CoursesID.Text);
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_Student.DataSource = (from std in db.tb_Students
                                           join clsR in db.tb_RegisterCourses
                                           on std.col_StudentID equals clsR.col_StudentID
                                           where clsR.col_CoursesID == coursesid
                                           select std
                                           ).ToList();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            frm_01_Attended_Load(sender, e);
        }
    }
}