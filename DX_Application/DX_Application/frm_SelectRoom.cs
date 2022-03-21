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
using System.Threading;

namespace DX_Application
{
    public partial class frm_SelectRoom : XtraForm
    {
        int CourseID;
        List<tb_ClassRooms> list = new List<tb_ClassRooms>();
        public frm_SelectRoom(string courseid)
        {
            CourseID = int.Parse(courseid);
            InitializeComponent();
        }

        private void frm_SelectRoom_Load(object sender, EventArgs e)
        {
            using (db_AttendedEntities db = new db_AttendedEntities())
            {
                list = db.tb_ClassRooms.ToList();
            }
            cbb_ListRoom.DataSource = list;
            cbb_ListRoom.DisplayMember = "col_RoomName";
        }

        private void btn_Accepted_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Room = list.Where(p => p.col_RoomName == cbb_ListRoom.Text).FirstOrDefault();
            frm_01_OpenCamera f = new frm_01_OpenCamera(CourseID.ToString(), Room.col_RoomID.ToString());
            f.Show();
            f.BringToFront();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}