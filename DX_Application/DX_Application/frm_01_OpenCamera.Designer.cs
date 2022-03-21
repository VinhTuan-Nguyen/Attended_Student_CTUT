namespace DX_Application
{
    partial class frm_01_OpenCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_OpenCamera));
            this.cam_Layout = new DevExpress.XtraEditors.Camera.CameraControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Attended = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Date = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Status = new DevExpress.XtraEditors.TextEdit();
            this.txt_DayoWeek = new DevExpress.XtraEditors.TextEdit();
            this.txt_RoomID = new DevExpress.XtraEditors.TextEdit();
            this.txt_Semester = new DevExpress.XtraEditors.TextEdit();
            this.txt_DateEnd = new DevExpress.XtraEditors.TextEdit();
            this.txt_CoursesName = new DevExpress.XtraEditors.TextEdit();
            this.txt_DateStr = new DevExpress.XtraEditors.TextEdit();
            this.txt_TeacherID = new DevExpress.XtraEditors.TextEdit();
            this.txt_CoursesID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Done = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Time = new DevExpress.XtraEditors.TextEdit();
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_Label = new System.Windows.Forms.Label();
            this.lb_Accuracy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_SumStudent = new System.Windows.Forms.Label();
            this.lb_CountStudent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DayoWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Semester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoursesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateStr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoursesID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cam_Layout
            // 
            this.cam_Layout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam_Layout.Location = new System.Drawing.Point(12, 12);
            this.cam_Layout.Name = "cam_Layout";
            this.cam_Layout.Size = new System.Drawing.Size(480, 480);
            this.cam_Layout.TabIndex = 0;
            this.cam_Layout.Text = "cameraControl1";
            this.cam_Layout.VideoStretchMode = DevExpress.XtraEditors.Camera.VideoStretchMode.ZoomOutside;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Attended
            // 
            this.btn_Attended.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Attended.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attended.Appearance.Options.UseFont = true;
            this.btn_Attended.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Attended.Location = new System.Drawing.Point(523, 562);
            this.btn_Attended.Name = "btn_Attended";
            this.btn_Attended.Size = new System.Drawing.Size(127, 43);
            this.btn_Attended.TabIndex = 2;
            this.btn_Attended.Text = "Điểm danh";
            this.btn_Attended.Click += new System.EventHandler(this.btn_Attended_Click);
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Date.Enabled = false;
            this.txt_Date.Location = new System.Drawing.Point(677, 46);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Date.Properties.Appearance.Options.UseFont = true;
            this.txt_Date.Size = new System.Drawing.Size(172, 22);
            this.txt_Date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã số sinh viên:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Độ Chính Xác:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(516, 393);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 16);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Ngày kết thúc:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(516, 436);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Thứ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(516, 479);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Trạng thái:";
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(516, 264);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(90, 16);
            this.labelControl9.TabIndex = 29;
            this.labelControl9.Text = "ID Phòng học:";
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(516, 135);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(88, 16);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Mã Học Phần:";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(516, 178);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(91, 16);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "Tên học phần:";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(516, 221);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(90, 16);
            this.labelControl12.TabIndex = 23;
            this.labelControl12.Text = "ID Giảng Viên:";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(516, 307);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(67, 16);
            this.labelControl13.TabIndex = 24;
            this.labelControl13.Text = "Niên khóa:";
            // 
            // txt_Status
            // 
            this.txt_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Status.Enabled = false;
            this.txt_Status.Location = new System.Drawing.Point(615, 476);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Properties.Appearance.Options.UseFont = true;
            this.txt_Status.Size = new System.Drawing.Size(234, 22);
            this.txt_Status.TabIndex = 20;
            // 
            // txt_DayoWeek
            // 
            this.txt_DayoWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DayoWeek.Enabled = false;
            this.txt_DayoWeek.Location = new System.Drawing.Point(615, 433);
            this.txt_DayoWeek.Name = "txt_DayoWeek";
            this.txt_DayoWeek.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DayoWeek.Properties.Appearance.Options.UseFont = true;
            this.txt_DayoWeek.Size = new System.Drawing.Size(234, 22);
            this.txt_DayoWeek.TabIndex = 18;
            // 
            // txt_RoomID
            // 
            this.txt_RoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RoomID.Enabled = false;
            this.txt_RoomID.Location = new System.Drawing.Point(615, 261);
            this.txt_RoomID.Name = "txt_RoomID";
            this.txt_RoomID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomID.Properties.Appearance.Options.UseFont = true;
            this.txt_RoomID.Size = new System.Drawing.Size(234, 22);
            this.txt_RoomID.TabIndex = 17;
            // 
            // txt_Semester
            // 
            this.txt_Semester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Semester.Enabled = false;
            this.txt_Semester.Location = new System.Drawing.Point(615, 304);
            this.txt_Semester.Name = "txt_Semester";
            this.txt_Semester.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Semester.Properties.Appearance.Options.UseFont = true;
            this.txt_Semester.Size = new System.Drawing.Size(234, 22);
            this.txt_Semester.TabIndex = 16;
            // 
            // txt_DateEnd
            // 
            this.txt_DateEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DateEnd.Enabled = false;
            this.txt_DateEnd.Location = new System.Drawing.Point(615, 390);
            this.txt_DateEnd.Name = "txt_DateEnd";
            this.txt_DateEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateEnd.Properties.Appearance.Options.UseFont = true;
            this.txt_DateEnd.Size = new System.Drawing.Size(234, 22);
            this.txt_DateEnd.TabIndex = 15;
            // 
            // txt_CoursesName
            // 
            this.txt_CoursesName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CoursesName.Enabled = false;
            this.txt_CoursesName.Location = new System.Drawing.Point(615, 175);
            this.txt_CoursesName.Name = "txt_CoursesName";
            this.txt_CoursesName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoursesName.Properties.Appearance.Options.UseFont = true;
            this.txt_CoursesName.Size = new System.Drawing.Size(234, 22);
            this.txt_CoursesName.TabIndex = 14;
            // 
            // txt_DateStr
            // 
            this.txt_DateStr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DateStr.Enabled = false;
            this.txt_DateStr.Location = new System.Drawing.Point(615, 347);
            this.txt_DateStr.Name = "txt_DateStr";
            this.txt_DateStr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateStr.Properties.Appearance.Options.UseFont = true;
            this.txt_DateStr.Size = new System.Drawing.Size(234, 22);
            this.txt_DateStr.TabIndex = 13;
            // 
            // txt_TeacherID
            // 
            this.txt_TeacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TeacherID.Enabled = false;
            this.txt_TeacherID.Location = new System.Drawing.Point(615, 218);
            this.txt_TeacherID.Name = "txt_TeacherID";
            this.txt_TeacherID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherID.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherID.Size = new System.Drawing.Size(234, 22);
            this.txt_TeacherID.TabIndex = 19;
            // 
            // txt_CoursesID
            // 
            this.txt_CoursesID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CoursesID.Enabled = false;
            this.txt_CoursesID.Location = new System.Drawing.Point(615, 132);
            this.txt_CoursesID.Name = "txt_CoursesID";
            this.txt_CoursesID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CoursesID.Properties.Appearance.Options.UseFont = true;
            this.txt_CoursesID.Size = new System.Drawing.Size(234, 22);
            this.txt_CoursesID.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(516, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(155, 16);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Thời gian mở điểm danh:";
            this.labelControl5.UseMnemonic = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(516, 92);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 16);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Giờ hiện tại:";
            // 
            // btn_Done
            // 
            this.btn_Done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Done.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Done.Appearance.Options.UseFont = true;
            this.btn_Done.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Done.Enabled = false;
            this.btn_Done.Location = new System.Drawing.Point(713, 562);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(127, 43);
            this.btn_Done.TabIndex = 2;
            this.btn_Done.Text = "Tổng kết";
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // txt_Time
            // 
            this.txt_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Time.Enabled = false;
            this.txt_Time.Location = new System.Drawing.Point(615, 89);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Time.Properties.Appearance.Options.UseFont = true;
            this.txt_Time.Size = new System.Drawing.Size(234, 22);
            this.txt_Time.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(516, 350);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 16);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Ngày bắt đầu:";
            // 
            // lb_Label
            // 
            this.lb_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Label.AutoSize = true;
            this.lb_Label.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Label.Location = new System.Drawing.Point(12, 530);
            this.lb_Label.Name = "lb_Label";
            this.lb_Label.Size = new System.Drawing.Size(179, 39);
            this.lb_Label.TabIndex = 4;
            this.lb_Label.Text = "?????????";
            // 
            // lb_Accuracy
            // 
            this.lb_Accuracy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Accuracy.AutoSize = true;
            this.lb_Accuracy.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Accuracy.Location = new System.Drawing.Point(12, 598);
            this.lb_Accuracy.Name = "lb_Accuracy";
            this.lb_Accuracy.Size = new System.Drawing.Size(179, 39);
            this.lb_Accuracy.TabIndex = 4;
            this.lb_Accuracy.Text = "?????????";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sĩ số lớp:";
            // 
            // lb_SumStudent
            // 
            this.lb_SumStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_SumStudent.AutoSize = true;
            this.lb_SumStudent.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SumStudent.Location = new System.Drawing.Point(280, 530);
            this.lb_SumStudent.Name = "lb_SumStudent";
            this.lb_SumStudent.Size = new System.Drawing.Size(77, 39);
            this.lb_SumStudent.TabIndex = 4;
            this.lb_SumStudent.Text = "000";
            // 
            // lb_CountStudent
            // 
            this.lb_CountStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_CountStudent.AutoSize = true;
            this.lb_CountStudent.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CountStudent.Location = new System.Drawing.Point(280, 598);
            this.lb_CountStudent.Name = "lb_CountStudent";
            this.lb_CountStudent.Size = new System.Drawing.Size(77, 39);
            this.lb_CountStudent.TabIndex = 4;
            this.lb_CountStudent.Text = "000";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 574);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Đã điểm danh:";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Location = new System.Drawing.Point(615, 517);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Properties.Appearance.Options.UseFont = true;
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(234, 22);
            this.txt_Password.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(516, 520);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 16);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "Password:";
            // 
            // frm_01_OpenCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 672);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_DayoWeek);
            this.Controls.Add(this.txt_RoomID);
            this.Controls.Add(this.txt_Semester);
            this.Controls.Add(this.txt_DateEnd);
            this.Controls.Add(this.txt_CoursesName);
            this.Controls.Add(this.txt_DateStr);
            this.Controls.Add(this.txt_TeacherID);
            this.Controls.Add(this.txt_CoursesID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_CountStudent);
            this.Controls.Add(this.lb_Accuracy);
            this.Controls.Add(this.lb_SumStudent);
            this.Controls.Add(this.lb_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_Attended);
            this.Controls.Add(this.cam_Layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_OpenCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.Load += new System.EventHandler(this.frm_01_OpenCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DayoWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Semester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoursesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateStr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CoursesID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Camera.CameraControl cam_Layout;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btn_Attended;
        private DevExpress.XtraEditors.TextEdit txt_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txt_Status;
        private DevExpress.XtraEditors.TextEdit txt_DayoWeek;
        private DevExpress.XtraEditors.TextEdit txt_RoomID;
        private DevExpress.XtraEditors.TextEdit txt_Semester;
        private DevExpress.XtraEditors.TextEdit txt_DateEnd;
        private DevExpress.XtraEditors.TextEdit txt_CoursesName;
        private DevExpress.XtraEditors.TextEdit txt_DateStr;
        private DevExpress.XtraEditors.TextEdit txt_TeacherID;
        private DevExpress.XtraEditors.TextEdit txt_CoursesID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btn_Done;
        private DevExpress.XtraEditors.TextEdit txt_Time;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label lb_Label;
        private System.Windows.Forms.Label lb_Accuracy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_SumStudent;
        private System.Windows.Forms.Label lb_CountStudent;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}