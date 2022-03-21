using DevExpress.XtraEditors;
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

namespace DX_Application
{
    public partial class frm_01_TeachersInfo : DevExpress.XtraEditors.XtraForm
    {

        public frm_01_TeachersInfo()
        {
            InitializeComponent();
        }

        private void frm_01_Info_Load(object sender, EventArgs e)
        {
            txt_TeacherID.Text = User.Teacher.col_TeacherID;
            txt_FullName.Text = User.Teacher.col_FName;
            txt_Department.Text = User.Teacher.col_Department;
            txt_Email.Text = User.Teacher.col_Email;
            txt_Phone.Text = User.Teacher.col_Phone;
            bool sex = User.Teacher.col_Sex.Value ? rdo_Male.Checked = true : rdo_Female.Checked = true;
            MemoryStream memory = new MemoryStream(User.Teacher.col_Avatar);
            Image img = Image.FromStream(memory);
            if (img == null)
            {
                return;
            }
            img_Avatar.Image = img;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_FullName.Text == "")
            {
                XtraMessageBox.Show("Họ tên không được để trống", "Cảnh Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Xác nhận cập nhật thông tin cá nhân", "Xác nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        bool sex = rdo_Male.Checked ? true : false;
                        MemoryStream stream = new MemoryStream();
                        img_Avatar.Image.Save(stream, ImageFormat.Png);
                        using (db_AttendedEntities db = new db_AttendedEntities())
                        {
                            tb_Teachers teacher = new tb_Teachers();
                            teacher.col_TeacherID = txt_TeacherID.Text;
                            teacher.col_FName = txt_FullName.Text;
                            teacher.col_Department = txt_Department.Text;
                            teacher.col_Email = txt_Email.Text;
                            teacher.col_Phone = txt_Phone.Text;
                            teacher.col_Sex = sex;
                            teacher.col_Avatar = stream.ToArray();
                            db.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            User.UpdateUser(teacher);
                            alert_Message.Show(this, "Thành công", "Cập nhật thông tin thành công.");
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Avatar bị rỗng", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
