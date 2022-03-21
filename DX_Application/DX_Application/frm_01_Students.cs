using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.Entity;

namespace DX_Application
{
    public partial class frm_01_Students : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_Students()
        {
            InitializeComponent();
        }

        private void frm_01_Students_Load(object sender, EventArgs e)
        {
            db_AttendedEntities db = new db_AttendedEntities();
            grid_Students.DataSource = db.tb_Students.ToList();
        }

        private void view_Students_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string sv = view_Students.GetRowCellValue(e.RowHandle, "col_StudentID").ToString();
                frm_01_StudentsEdit f = new frm_01_StudentsEdit(sv);
                f.ShowDialog();
                frm_01_Students_Load(sender, e);
            }
        }

        private void view_Students_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                string sv = view_Students.GetRowCellValue(e.FocusedRowHandle, "col_StudentID").ToString();
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    var std = from cls in db.tb_Courses
                                join clsR in db.tb_RegisterCourses
                                on cls.col_CoursesID equals clsR.col_CoursesID
                                where clsR.col_StudentID == sv
                                select cls;
                    grid_Courses.DataSource = std.ToList();
                }
            }
        }
    }
}
