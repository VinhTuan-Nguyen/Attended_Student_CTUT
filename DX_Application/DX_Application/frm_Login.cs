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
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {

        public frm_Login()
        {
            InitializeComponent();
        }

        private void check_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Pass.Checked == true)
            {
                txt_Password.Properties.PasswordChar = '\0';
            }
            else txt_Password.Properties.PasswordChar = '*';
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            txt_Password.Properties.PasswordChar = '*';
            check_Pass.Checked = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_RegisterUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_RegisterUser f = new frm_RegisterUser();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (txt_UserID.Text == "" || txt_Password.Text == "")
            {
                alert_Info.Show(this, "Thông Báo", "Tài khoản hoặc mật khẩu chưa điền.");
            }
            else
            {
                User.SetUser(txt_UserID.Text);
                Shared shared = new Shared();
                string pass = shared.Encode(txt_Password.Text);
                if (User.Account != null)
                {
                    if (User.Account.col_Password == pass)
                    {
                        switch (User.Account.col_Role)
                        {
                            case "admin":

                                break;
                            case "user":
                                User.SetUser(txt_UserID.Text);
                                this.Hide();
                                frm_01_TeachersMain f = new frm_01_TeachersMain();
                                f.ShowDialog();
                                this.Close();
                                break;
                        }
                    }
                    else alert_Info.Show(this, "Thông Báo", "Mật khẩu chưa đúng.");
                }
                else alert_Info.Show(this, "Thông Báo", "Tài khoản chưa chính xác.");
            }
        }

        private void btn_GetData_Click(object sender, EventArgs e)
        {
            frm_GetFaceData f = new frm_GetFaceData();
            f.ShowDialog();

        }
    }
}
