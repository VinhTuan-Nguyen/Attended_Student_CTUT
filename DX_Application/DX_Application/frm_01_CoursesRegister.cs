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

namespace DX_Application
{
    public partial class frm_01_CoursesRegister : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_CoursesRegister()
        {
            InitializeComponent();
        }

        private void frm_01_CoursesRegister_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_Students1.DataSource = db.tb_Students.Select(p => p).ToList();
                grid_Courses1.DataSource = db.tb_Courses.Where(p => p.col_TeacherID == User.Teacher.col_TeacherID).ToList();
            }
        }

        private void view_Students1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                string sv = view_Students1.GetRowCellValue(e.FocusedRowHandle, "col_StudentID").ToString();
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    var std = from cls in db.tb_Courses
                              join clsR in db.tb_RegisterCourses
                              on cls.col_CoursesID equals clsR.col_CoursesID
                              where clsR.col_StudentID == sv
                              select cls;
                    grid_Courses2.DataSource = std.ToList();
                }
            }
        }

        private void view_Courses1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                int courses = (int)view_Courses1.GetRowCellValue(e.FocusedRowHandle, "col_CoursesID");
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    var list = from std in db.tb_Students
                               join cls in db.tb_RegisterCourses
                               on std.col_StudentID equals cls.col_StudentID
                               where cls.col_CoursesID == courses
                               select std;
                    grid_Students2.DataSource = list.ToList();
                }
            }
        }

        private void view_Students1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string mssv = view_Students1.GetRowCellValue(e.RowHandle, "col_StudentID").ToString();
                frm_01_RegisterStd f = new frm_01_RegisterStd(mssv);
                f.ShowDialog();
            }
            frm_01_CoursesRegister_Load(sender, e);
        }

        private void view_Courses1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string coursesid = view_Courses1.GetRowCellValue(e.RowHandle, "col_CoursesID").ToString();
                frm_01_RegisterCour f = new frm_01_RegisterCour(coursesid);
                f.ShowDialog();
                frm_01_CoursesRegister_Load(sender, e);
            }
        }
    }
}