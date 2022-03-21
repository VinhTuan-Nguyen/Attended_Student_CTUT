using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DX_Application
{
    public partial class frm_01_Courses : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_Courses()
        {
            InitializeComponent();
        }

        private void frm_01_Courses_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_Courses.DataSource = db.tb_Courses.Where(p => p.col_TeacherID == User.Teacher.col_TeacherID).ToList();
            }
        }

        private void view_Courses_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int id = (int)view_Courses.GetRowCellValue(e.RowHandle, "col_CoursesID");
                frm_01_CoursesEdit f = new frm_01_CoursesEdit(id.ToString());
                f.ShowDialog();
                frm_01_Courses_Load(sender, e);
            }
        }

        private void view_Courses_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                int coursesid = (int)view_Courses.GetRowCellValue(e.FocusedRowHandle, "col_CoursesID");
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    var list = from std in db.tb_Students
                                join cls in db.tb_RegisterCourses
                                on std.col_StudentID equals cls.col_StudentID
                                where cls.col_CoursesID == coursesid
                                select std;
                    grid_Students.DataSource = list.ToList();
                }
            }
        }
    }
}
