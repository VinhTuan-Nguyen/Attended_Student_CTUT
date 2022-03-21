using DevExpress.XtraEditors;
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
    public partial class frm_01_TeachersTransPass : DevExpress.XtraEditors.XtraForm
    {
        public frm_01_TeachersTransPass()
        {
            InitializeComponent();
        }

        private void check_OldPass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_OldPass.Checked == true)
            {
                txt_OldPass.Properties.PasswordChar = '\0';
            } else txt_OldPass.Properties.PasswordChar = '*';
        }

        private void check_NewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_NewPass.Checked == true)
            {
                txt_NewPass.Properties.PasswordChar = '\0';
                txt_ReNewPass.Properties.PasswordChar = '\0';
            }
            else
            {
                txt_NewPass.Properties.PasswordChar = '*';
                txt_ReNewPass.Properties.PasswordChar = '*';
            }
        }

        private void txt_OldPass_TextChanged(object sender, EventArgs e)
        {
            txt_OldPass.Properties.PasswordChar = '*';
            check_OldPass.Checked = false;
        }

        private void txt_NewPass_TextChanged(object sender, EventArgs e)
        {
            txt_NewPass.Properties.PasswordChar = '*';
            txt_ReNewPass.Properties.PasswordChar = '*';
            check_NewPass.Checked = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Shared shared = new Shared();
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                var x = db.tb_Accounts.Find(User.Account.col_UserID);
                if (shared.Encode(txt_OldPass.Text) == x.col_Password)
                {
                    x.col_Password = shared.Encode(txt_NewPass.Text);
                    db.Entry(x).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    User.UpdateAccount(x);
                    alert_Message.Show(this, "Thành công", "Thay đổi mật khẩu thành công.");
                }
                else XtraMessageBox.Show("Sai mật khẩu", "Cảnh báo",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
