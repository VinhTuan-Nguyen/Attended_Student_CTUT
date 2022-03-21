using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DX_Application
{
    public partial class frm_01_TeachersMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public frm_01_TeachersMain()
        {
            InitializeComponent();
        }

        void OpenForm(Type typeForm)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == typeForm)
                {
                    f.Activate();
                    return;
                }
            }
            Form frm = (Form)Activator.CreateInstance(typeForm);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_LogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Xác Nhận Đăng Xuất ?", "Xác Nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                frm_Login f = new frm_Login();
                f.ShowDialog();
                this.Close();
            }
        }

        private void control_Attended_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_Attended));
        }

        private void control_AttenHistory_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_AttendedHistory));
        }

        private void control_AddClass_Click(object sender, EventArgs e)
        {
            frm_01_CoursesEdit f = new frm_01_CoursesEdit("");
            f.ShowDialog();
        }

        private void control_Class_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_Courses));
        }

        private void control_ClassRegister_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_CoursesRegister));
        }

        private void control_Info_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_TeachersInfo));
        }

        private void control_TransPass_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_TeachersTransPass));
        }

        private void control_Student_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(frm_01_Students));
        }

        private void control_AddStudent_Click(object sender, EventArgs e)
        {
            frm_01_StudentsEdit f = new frm_01_StudentsEdit("");
            f.ShowDialog();
        }

        private void control_ClassRooms_Click(object sender, EventArgs e)
        {
            frm_01_ClassRooms f = new frm_01_ClassRooms();
            f.ShowDialog();
        }

        private void control_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Xác Nhận Thoát Ứng Dụng.", "Xác Nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                frm_Login f = new frm_Login();
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
