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
using DevExpress.XtraEditors;

namespace DX_Application
{
    public partial class frm_01_AttendedHistory : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_AttendedHistory()
        {
            InitializeComponent();
        }

        private void frm_01_AttendedHistory_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_Attended.DataSource = db.tb_Attended.Select(p => p).ToList();
            }
        }

        private void view_Attended_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txt_AttendedID.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_Index_Attended").ToString();
                txt_CourseID.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_CoursesID").ToString();
                txt_DateAtd.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_DateAtd").ToString();
                txt_RoomID.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_RoomID").ToString();
                txt_StudentID.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_StudentID").ToString();
                txt_TeacherID.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_TeacherID").ToString();
                txt_TimeAtd.Text = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_TimeAtd").ToString();
                var note = view_Attended.GetRowCellValue(e.FocusedRowHandle, "col_Note").ToString();
                switch (note)
                {
                    case "Vắng không phép":
                        rdo_Not.Checked = true;
                        break;
                    case "Vắng có phép":
                        rdo_NotYet.Checked = true;
                        break;
                    case "Có mặt":
                        rdo_Yes.Checked = true;
                        break;
                    default:
                        txt_Note.Text = note;
                        rdo_Differ.Checked = true;
                        break;
                }
            }
        }

        private void rdo_Not_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Not.Checked)
            {
                txt_Note.Text = "Vắng không phép";
                txt_Note.Enabled = false;
            }
        }

        private void rdo_NotYet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_NotYet.Checked)
            {
                txt_Note.Text = "Vắng có phép";
                txt_Note.Enabled = false;
            }
        }

        private void rdo_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Yes.Checked)
            {
                txt_Note.Text = "Có mặt";
                txt_Note.Enabled = false;
            }
        }

        private void rdo_Differ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Differ.Checked)
            {
                txt_Note.Enabled = true;
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Xác nhận cập nhật buổi điểm danh.", "Xác nhận.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                tb_Attended tb = new tb_Attended()
                {
                    col_CoursesID = int.Parse(txt_CourseID.Text),
                    col_DateAtd = DateTime.Parse(txt_DateAtd.Text),
                    col_Index_Attended = int.Parse(txt_AttendedID.Text),
                    col_Note = txt_Note.Text,
                    col_RoomID = txt_RoomID.Text,
                    col_StudentID = txt_StudentID.Text,
                    col_TeacherID = txt_TeacherID.Text,
                    col_TimeAtd = TimeSpan.Parse(txt_TimeAtd.Text)
                };

                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    db.Entry(tb).State = EntityState.Modified;
                    db.SaveChanges();
                    alert_Message.Show(this, "Thành công", "Cập nhật thông tin thành công.");
                }
                frm_01_AttendedHistory_Load(sender, e);
            }
        }
    }
}
