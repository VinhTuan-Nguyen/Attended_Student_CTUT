namespace DX_Application
{
    partial class frm_01_TeachersMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_TeachersMain));
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_AttenManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_Attended = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_AttenHistory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_ClassRegister = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_ClassManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_Class = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_AddClass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_StudentManagerment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_Student = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_AddStudent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_ClassRooms = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_Info = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_TransPass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.control_Logout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(238, 742);
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.accordionControlElement1.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionControlElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.control_AttenManagement,
            this.control_ClassManagement,
            this.control_StudentManagerment,
            this.control_ClassRooms});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = global::DX_Application.Properties.Resources.managerules_32x32;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Quản Lý";
            // 
            // control_AttenManagement
            // 
            this.control_AttenManagement.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_AttenManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_AttenManagement.Appearance.Hovered.Options.UseFont = true;
            this.control_AttenManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.control_AttenManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.control_Attended,
            this.control_AttenHistory,
            this.control_ClassRegister});
            this.control_AttenManagement.Expanded = true;
            this.control_AttenManagement.ImageOptions.Image = global::DX_Application.Properties.Resources.namemanager_16x16;
            this.control_AttenManagement.Name = "control_AttenManagement";
            this.control_AttenManagement.Text = "Quản Lý Điểm Danh";
            // 
            // control_Attended
            // 
            this.control_Attended.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_Attended.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_Attended.Appearance.Hovered.Options.UseFont = true;
            this.control_Attended.Appearance.Hovered.Options.UseForeColor = true;
            this.control_Attended.ImageOptions.Image = global::DX_Application.Properties.Resources.showtestreport_16x16;
            this.control_Attended.Name = "control_Attended";
            this.control_Attended.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_Attended.Text = "Điểm Danh";
            this.control_Attended.Click += new System.EventHandler(this.control_Attended_Click);
            // 
            // control_AttenHistory
            // 
            this.control_AttenHistory.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_AttenHistory.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_AttenHistory.Appearance.Hovered.Options.UseFont = true;
            this.control_AttenHistory.Appearance.Hovered.Options.UseForeColor = true;
            this.control_AttenHistory.ImageOptions.Image = global::DX_Application.Properties.Resources.historyitem_16x16;
            this.control_AttenHistory.Name = "control_AttenHistory";
            this.control_AttenHistory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_AttenHistory.Text = "Lịch Sử Điểm Danh";
            this.control_AttenHistory.Click += new System.EventHandler(this.control_AttenHistory_Click);
            // 
            // control_ClassRegister
            // 
            this.control_ClassRegister.ImageOptions.Image = global::DX_Application.Properties.Resources.bonote_16x16;
            this.control_ClassRegister.Name = "control_ClassRegister";
            this.control_ClassRegister.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_ClassRegister.Text = "Đăng Kí Học Phần";
            this.control_ClassRegister.Click += new System.EventHandler(this.control_ClassRegister_Click);
            // 
            // control_ClassManagement
            // 
            this.control_ClassManagement.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_ClassManagement.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_ClassManagement.Appearance.Hovered.Options.UseFont = true;
            this.control_ClassManagement.Appearance.Hovered.Options.UseForeColor = true;
            this.control_ClassManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.control_Class,
            this.control_AddClass});
            this.control_ClassManagement.Expanded = true;
            this.control_ClassManagement.ImageOptions.Image = global::DX_Application.Properties.Resources.cube_16x16;
            this.control_ClassManagement.Name = "control_ClassManagement";
            this.control_ClassManagement.Text = "Quản Lý Lớp Học";
            // 
            // control_Class
            // 
            this.control_Class.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_Class.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_Class.Appearance.Hovered.Options.UseFont = true;
            this.control_Class.Appearance.Hovered.Options.UseForeColor = true;
            this.control_Class.ImageOptions.Image = global::DX_Application.Properties.Resources.listnumbers_16x16;
            this.control_Class.Name = "control_Class";
            this.control_Class.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_Class.Text = "Danh Sách Lớp";
            this.control_Class.Click += new System.EventHandler(this.control_Class_Click);
            // 
            // control_AddClass
            // 
            this.control_AddClass.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_AddClass.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_AddClass.Appearance.Hovered.Options.UseFont = true;
            this.control_AddClass.Appearance.Hovered.Options.UseForeColor = true;
            this.control_AddClass.ImageOptions.Image = global::DX_Application.Properties.Resources.addchartpane_16x16;
            this.control_AddClass.Name = "control_AddClass";
            this.control_AddClass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_AddClass.Text = "Tạo Lớp Mới";
            this.control_AddClass.Click += new System.EventHandler(this.control_AddClass_Click);
            // 
            // control_StudentManagerment
            // 
            this.control_StudentManagerment.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_StudentManagerment.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_StudentManagerment.Appearance.Hovered.Options.UseFont = true;
            this.control_StudentManagerment.Appearance.Hovered.Options.UseForeColor = true;
            this.control_StudentManagerment.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.control_Student,
            this.control_AddStudent});
            this.control_StudentManagerment.Expanded = true;
            this.control_StudentManagerment.ImageOptions.Image = global::DX_Application.Properties.Resources.boposition_16x16;
            this.control_StudentManagerment.Name = "control_StudentManagerment";
            this.control_StudentManagerment.Text = "Sinh Viên";
            // 
            // control_Student
            // 
            this.control_Student.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_Student.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_Student.Appearance.Hovered.Options.UseFont = true;
            this.control_Student.Appearance.Hovered.Options.UseForeColor = true;
            this.control_Student.ImageOptions.Image = global::DX_Application.Properties.Resources.findbyid_16x16;
            this.control_Student.Name = "control_Student";
            this.control_Student.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_Student.Text = "Tra Cứu Sinh Viên";
            this.control_Student.Click += new System.EventHandler(this.control_Student_Click);
            // 
            // control_AddStudent
            // 
            this.control_AddStudent.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_AddStudent.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_AddStudent.Appearance.Hovered.Options.UseFont = true;
            this.control_AddStudent.Appearance.Hovered.Options.UseForeColor = true;
            this.control_AddStudent.ImageOptions.Image = global::DX_Application.Properties.Resources.newcontact_16x16;
            this.control_AddStudent.Name = "control_AddStudent";
            this.control_AddStudent.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_AddStudent.Text = "Thêm Sinh Viên";
            this.control_AddStudent.Click += new System.EventHandler(this.control_AddStudent_Click);
            // 
            // control_ClassRooms
            // 
            this.control_ClassRooms.ImageOptions.Image = global::DX_Application.Properties.Resources.home_32x32;
            this.control_ClassRooms.Name = "control_ClassRooms";
            this.control_ClassRooms.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_ClassRooms.Text = "Quản Lý Phòng Học";
            this.control_ClassRooms.Click += new System.EventHandler(this.control_ClassRooms_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement2.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.accordionControlElement2.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement2.Appearance.Hovered.Options.UseForeColor = true;
            this.accordionControlElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement2.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.control_Info,
            this.control_TransPass,
            this.control_Logout});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.Image = global::DX_Application.Properties.Resources.editrangepermission_32x32;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Cá Nhân";
            // 
            // control_Info
            // 
            this.control_Info.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_Info.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_Info.Appearance.Hovered.Options.UseFont = true;
            this.control_Info.Appearance.Hovered.Options.UseForeColor = true;
            this.control_Info.ImageOptions.Image = global::DX_Application.Properties.Resources.contact_16x16;
            this.control_Info.Name = "control_Info";
            this.control_Info.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_Info.Text = "Thông Tin Cá Nhân";
            this.control_Info.Click += new System.EventHandler(this.control_Info_Click);
            // 
            // control_TransPass
            // 
            this.control_TransPass.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_TransPass.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_TransPass.Appearance.Hovered.Options.UseFont = true;
            this.control_TransPass.Appearance.Hovered.Options.UseForeColor = true;
            this.control_TransPass.ImageOptions.Image = global::DX_Application.Properties.Resources.refresh_16x16;
            this.control_TransPass.Name = "control_TransPass";
            this.control_TransPass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_TransPass.Text = "Đổi Mật Khẩu";
            this.control_TransPass.Click += new System.EventHandler(this.control_TransPass_Click);
            // 
            // control_Logout
            // 
            this.control_Logout.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control_Logout.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.control_Logout.Appearance.Hovered.Options.UseFont = true;
            this.control_Logout.Appearance.Hovered.Options.UseForeColor = true;
            this.control_Logout.ImageOptions.Image = global::DX_Application.Properties.Resources.right_16x16;
            this.control_Logout.Name = "control_Logout";
            this.control_Logout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.control_Logout.Text = "Đăng Xuất";
            this.control_Logout.Click += new System.EventHandler(this.control_Logout_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1337, 27);
            this.fluentDesignFormControl1.TabIndex = 4;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frm_01_TeachersMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 769);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_TeachersMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng Viên - Quản lý";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_AttenManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_Attended;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_AttenHistory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_ClassManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_Class;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_AddClass;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_Info;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_TransPass;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_Logout;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_StudentManagerment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_Student;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_AddStudent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_ClassRegister;
        private DevExpress.XtraBars.Navigation.AccordionControlElement control_ClassRooms;
    }
}

