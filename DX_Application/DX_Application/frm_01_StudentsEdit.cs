using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace DX_Application
{
    public partial class frm_01_StudentsEdit : DevExpress.XtraEditors.XtraForm
    {
        string Student;

        public frm_01_StudentsEdit(string sv)
        {
            if (sv == "")
            {
                InitializeComponent();
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
            }
            else
            {
                InitializeComponent();
                Student = sv;
                btn_Add.Enabled = false;
                txt_StudentID.Enabled = false;
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    var std = db.tb_Students.Where(p => p.col_StudentID == sv).FirstOrDefault();
                    txt_StudentID.Text = (string)std.col_StudentID;
                    txt_FName.Text = std.col_FName;
                    txt_Email.Text = std.col_Email;
                    Date_Birthday.Text = std.col_DayoBirth.ToShortDateString();
                    txt_Major.Text = std.col_Major;
                    txt_Phone.Text = std.col_Phone;
                    bool sex = std.col_Sex.Value ? rdo_Male.Checked = true : rdo_Female.Checked = true;
                    if (std.col_Avatar != null)
                    {
                        MemoryStream stream = new MemoryStream(std.col_Avatar);
                        Image img = Image.FromStream(stream);
                        img_Avatar.Image = img;
                    }
                }
            }
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            Shared shared = new Shared();
            if (txt_StudentID.Text == "" || txt_FName.Text == "")
            {
                XtraMessageBox.Show("MSSV và tên không được để trống.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (shared.CheckStudent(txt_StudentID.Text))
            {
                XtraMessageBox.Show("MSSV là không được trùng nhau", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool sex = rdo_Male.Checked ? true : false;
                    MemoryStream stream = new MemoryStream();
                    img_Avatar.Image.Save(stream, ImageFormat.Png);
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        db.tb_Students.Add(new tb_Students
                        {
                            col_StudentID = txt_StudentID.Text,
                            col_FName = txt_FName.Text,
                            col_DayoBirth = DateTime.Parse(Date_Birthday.Text),
                            col_Major = txt_Major.Text,
                            col_Email = txt_Email.Text,
                            col_Phone = txt_Phone.Text,
                            col_Sex = sex,
                            col_Avatar = stream.ToArray()
                        });
                        db.SaveChanges();
                    }
                    alert_Message.Show(this, "Thành công", "Thêm sinh viên thành công.");
                }
                catch
                {
                    XtraMessageBox.Show("Avatar bị rỗng", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Xác nhận thay đổi thông tin.", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        bool sex = rdo_Male.Checked ? true : false;
                        MemoryStream stream = new MemoryStream();
                        img_Avatar.Image.Save(stream, ImageFormat.Png);
                        var tb = db.tb_Students.Find(txt_StudentID.Text);
                        tb.col_StudentID = txt_StudentID.Text;
                        tb.col_FName = txt_FName.Text;
                        tb.col_Email = txt_Email.Text;
                        tb.col_DayoBirth = DateTime.Parse(Date_Birthday.Text);
                        tb.col_Major = txt_Major.Text;
                        tb.col_Phone = txt_Phone.Text;
                        tb.col_Sex = rdo_Male.Checked ? true : false;
                        tb.col_Avatar = stream.ToArray();
                        db.Entry(tb).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    alert_Message.Show(this, "Thành công", "Cập nhật thông tin thành công.");
                }
                catch
                {
                    XtraMessageBox.Show("Avatar bị rỗng", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Không được phép xóa.", "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
