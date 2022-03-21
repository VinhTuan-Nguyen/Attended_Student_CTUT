using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_Application
{
    public partial class frm_RegisterUser : DevExpress.XtraEditors.XtraForm
    {
        public frm_RegisterUser()
        {
            InitializeComponent();
        }

        private void check_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (!check_Pass.Checked)
            {
                txt_Password.Properties.PasswordChar = '\0';
                txt_RePassword.Properties.PasswordChar = '\0';
            }
            else
            {
                txt_Password.Properties.PasswordChar = '*';
                txt_RePassword.Properties.PasswordChar = '*';
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            txt_Password.Properties.PasswordChar = '*';
            txt_RePassword.Properties.PasswordChar = '*';
            check_Pass.Checked = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            Shared shared = new Shared();
            if (txt_UserID.Text == "" || txt_FullName.Text == "")
            {
                alert_Info.Show(this, "Thông Báo", "(*) Là những trường không được rỗng.");
            }
            else if (!shared.CheckRegex(txt_Password.Text) && !shared.CheckRegex(txt_RePassword.Text))
            {
                alert_Info.Show(this, "Thông Báo", "Mật khẩu không được sử dụng kí tự đặc biệt\n" +
                    "chỉ bao gồm các kí tự: [a-z, A-Z, 0-9].");
            }
            else if (!shared.Pass_Macth(txt_Password.Text, txt_RePassword.Text))
            {
                alert_Info.Show(this, "Thông Báo", "Mật khẩu không trùng nhau.");
            }
            else
            {
                if (shared.CheckUser(txt_UserID.Text))
                {
                    alert_Info.Show(this, "Thông Báo", "Tài khoản này đã tồn tại.");
                }
                else
                {
                    string pass = shared.Encode(txt_Password.Text);
                    bool sex = rdo_Male.Checked ? true : false;
                    MemoryStream stream = new MemoryStream();
                    img_Avatar.Image.Save(stream, ImageFormat.Png);
                    using (db_AttendedEntities db = new db_AttendedEntities())
                    {
                        db.tb_Accounts.Add(new tb_Accounts()
                        {
                            col_UserID = txt_UserID.Text,
                            col_Password = pass,
                            col_Role = "user"
                        });
                        db.tb_Teachers.Add(new tb_Teachers()
                        {
                            col_Avatar = stream.ToArray(),
                            col_Department = txt_Department.Text,
                            col_Email = txt_Email.Text,
                            col_FName = txt_FullName.Text,
                            col_Phone = txt_Phone.Text,
                            col_Sex = sex,
                            col_TeacherID = txt_UserID.Text
                        });
                        db.SaveChanges();
                    }
                    alert_Info.Show(this, "Thông Báo", "Tạo tài khoản thành công.");
                }
            }
        }
    }
}
