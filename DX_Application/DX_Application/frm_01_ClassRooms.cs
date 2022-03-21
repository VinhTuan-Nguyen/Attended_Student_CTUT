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
    public partial class frm_01_ClassRooms : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_ClassRooms()
        {
            InitializeComponent();
        }

        private void frm_01_ClassRooms_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                grid_ClassRooms.DataSource = db.tb_ClassRooms.ToList();
            }
        }

        private void view_ClassRooms_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_RoomID.Enabled = false;
            if (e.FocusedRowHandle >= 0)
            {
                txt_RoomID.Text = view_ClassRooms.GetRowCellValue(e.FocusedRowHandle, "col_RoomID").ToString();
                txt_RoomName.Text = view_ClassRooms.GetRowCellValue(e.FocusedRowHandle, "col_RoomName").ToString();
                txt_Capacity.Text = view_ClassRooms.GetRowCellValue(e.FocusedRowHandle, "col_Capacity").ToString();
                txt_TeacherID.Text = view_ClassRooms.GetRowCellValue(e.FocusedRowHandle, "col_CreateID").ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_TeacherID.Text = User.Teacher.col_TeacherID;
            if (txt_RoomID.Enabled)
            {
                if (txt_RoomID.Text == "")
                {
                    XtraMessageBox.Show("Mã phòng học không được rỗng.", "Cảnh Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        var result = db.tb_ClassRooms.Find(txt_RoomID.Text);
                        if (result != null)
                        {
                            XtraMessageBox.Show("Phòng học này đã được tạo.", "Cảnh Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            db.tb_ClassRooms.Add(new tb_ClassRooms
                            {
                                col_RoomID = txt_RoomID.Text,
                                col_RoomName = txt_RoomName.Text,
                                col_CreateID = txt_TeacherID.Text,
                                col_Capacity = Convert.ToInt32(txt_Capacity.Text)
                            });
                            db.SaveChanges();
                            alert_Message.Show(this, "Thành công.", "Tạo phòng học thành công.");
                            frm_01_ClassRooms_Load(sender, e);
                        }
                    }
                }
                txt_RoomID.Enabled = false;
            }
            else
            {
                txt_RoomID.Enabled = true;
                txt_RoomID.Text = "";
                txt_RoomName.Text = "";
                txt_Capacity.Text = "";
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_RoomID.Enabled)
            {
                XtraMessageBox.Show("Không thể cập nhật bằng cách này.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (User.Teacher.col_TeacherID != txt_TeacherID.Text)
            {
                XtraMessageBox.Show("Thông tin này của người khác tạo,\nkhông thể cập nhật.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Xác nhận cập nhật thông tin phòng học.", "Xác nhận.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        tb_ClassRooms classes = new tb_ClassRooms();
                        classes.col_RoomID = txt_RoomID.Text;
                        classes.col_RoomName = txt_RoomName.Text;
                        classes.col_Capacity = Convert.ToInt32(txt_Capacity.Text);
                        classes.col_CreateID = txt_TeacherID.Text;
                        db.Entry(classes).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    alert_Message.Show(this, "Thành công.", "Cập nhật thông tin phòng học thành công.");
                    frm_01_ClassRooms_Load(sender, e);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_RoomID.Enabled)
            {
                XtraMessageBox.Show("Không thể xóa bằng cách này.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (User.Teacher.col_TeacherID != txt_TeacherID.Text)
            {
                XtraMessageBox.Show("Thông tin này của người khác tạo,\nkhông thể xóa.", "Cảnh báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Xác nhận xóa phòng học.", "Xác nhận.",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        tb_ClassRooms classes = new tb_ClassRooms();
                        classes.col_RoomID = txt_RoomID.Text;
                        classes.col_RoomName = txt_RoomName.Text;
                        classes.col_Capacity = Convert.ToInt32(txt_Capacity.Text);
                        classes.col_CreateID = txt_TeacherID.Text;
                        db.Entry(classes).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    alert_Message.Show(this, "Thành công.", "Xóa phòng học thành công.");
                    frm_01_ClassRooms_Load(sender, e);
                }
            }
        }
    }
}