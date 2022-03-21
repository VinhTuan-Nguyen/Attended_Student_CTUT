using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DX_Application
{
    public class User
    {
        public static tb_Teachers Teacher = new tb_Teachers();
        public static tb_Accounts Account = new tb_Accounts();

        public static void SetUser(string teacherid)
        {
            try
            {
                using (db_AttendedEntities db = new db_AttendedEntities())
                {
                    Teacher = db.tb_Teachers.Find(teacherid);
                    Account = db.tb_Accounts.Find(teacherid);
                }
            }
            catch
            {
                XtraMessageBox.Show("Không thể kết nối CSDL.\nVui lòng tắt ứng dụng và thử lại.", "Lỗi !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdateUser(tb_Teachers teacher)
        {
            Teacher = teacher;
        }

        public static void UpdateAccount(tb_Accounts account)
        {
            Account = account;
        }
    }
}
