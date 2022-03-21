namespace DX_Application
{
    partial class frm_01_CoursesEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_CoursesEdit));
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.date_Start = new DevExpress.XtraEditors.DateEdit();
            this.date_End = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cbb_ClassList = new System.Windows.Forms.ComboBox();
            this.txt_DayoWeek = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Status = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbb_Semester = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_CourseName = new DevExpress.XtraEditors.TextEdit();
            this.txt_CourseID = new DevExpress.XtraEditors.TextEdit();
            this.txt_TeacherID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DayoWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Semester.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.date_time_32x32;
            this.groupControl2.Controls.Add(this.date_Start);
            this.groupControl2.Controls.Add(this.date_End);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(52, 320);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(447, 138);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Thời Gian Học";
            // 
            // date_Start
            // 
            this.date_Start.EditValue = null;
            this.date_Start.Location = new System.Drawing.Point(164, 55);
            this.date_Start.Name = "date_Start";
            this.date_Start.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Start.Properties.Appearance.Options.UseFont = true;
            this.date_Start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Start.Properties.Mask.BeepOnError = true;
            this.date_Start.Size = new System.Drawing.Size(221, 22);
            this.date_Start.TabIndex = 2;
            this.date_Start.TextChanged += new System.EventHandler(this.date_Start_TextChanged);
            // 
            // date_End
            // 
            this.date_End.EditValue = null;
            this.date_End.Location = new System.Drawing.Point(164, 96);
            this.date_End.Name = "date_End";
            this.date_End.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_End.Properties.Appearance.Options.UseFont = true;
            this.date_End.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_End.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_End.Properties.Mask.BeepOnError = true;
            this.date_End.Size = new System.Drawing.Size(221, 22);
            this.date_End.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(67, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày bắt đầu:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(63, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Ngày kết thúc:";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.scatter_32x32;
            this.groupControl3.Controls.Add(this.cbb_ClassList);
            this.groupControl3.Controls.Add(this.txt_DayoWeek);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txt_Status);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl3.Location = new System.Drawing.Point(52, 491);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(447, 167);
            this.groupControl3.TabIndex = 22;
            this.groupControl3.Text = "Khác";
            // 
            // cbb_ClassList
            // 
            this.cbb_ClassList.FormattingEnabled = true;
            this.cbb_ClassList.Location = new System.Drawing.Point(164, 135);
            this.cbb_ClassList.Name = "cbb_ClassList";
            this.cbb_ClassList.Size = new System.Drawing.Size(221, 21);
            this.cbb_ClassList.TabIndex = 2;
            // 
            // txt_DayoWeek
            // 
            this.txt_DayoWeek.Location = new System.Drawing.Point(164, 56);
            this.txt_DayoWeek.Name = "txt_DayoWeek";
            this.txt_DayoWeek.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DayoWeek.Properties.Appearance.Options.UseFont = true;
            this.txt_DayoWeek.Properties.MaxLength = 2;
            this.txt_DayoWeek.Properties.ReadOnly = true;
            this.txt_DayoWeek.Size = new System.Drawing.Size(221, 22);
            this.txt_DayoWeek.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(129, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Thứ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(87, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Trạng thái:";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(164, 94);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Status.Properties.Appearance.Options.UseFont = true;
            this.txt_Status.Properties.MaxLength = 30;
            this.txt_Status.Size = new System.Drawing.Size(221, 22);
            this.txt_Status.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(68, 135);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(90, 16);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "ID Phòng học:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.project_32x32;
            this.groupControl1.Controls.Add(this.cbb_Semester);
            this.groupControl1.Controls.Add(this.txt_CourseName);
            this.groupControl1.Controls.Add(this.txt_CourseID);
            this.groupControl1.Controls.Add(this.txt_TeacherID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(52, 76);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(447, 211);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Thông Tin Học Phần";
            // 
            // cbb_Semester
            // 
            this.cbb_Semester.Location = new System.Drawing.Point(164, 169);
            this.cbb_Semester.Name = "cbb_Semester";
            this.cbb_Semester.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Semester.Properties.Appearance.Options.UseFont = true;
            this.cbb_Semester.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_Semester.Properties.DropDownRows = 10;
            this.cbb_Semester.Properties.Items.AddRange(new object[] {
            "2018-2019_HK1",
            "2018-2019_HK2",
            "2019-2020_HK1",
            "2019-2020_HK2",
            "2020-2021_HK1",
            "2020-2021_HK2",
            "2021-2022_HK1",
            "2021-2022_HK2",
            "2022-2023_HK1",
            "2022-2023_HK2"});
            this.cbb_Semester.Size = new System.Drawing.Size(221, 22);
            this.cbb_Semester.TabIndex = 2;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Location = new System.Drawing.Point(164, 131);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseName.Properties.Appearance.Options.UseFont = true;
            this.txt_CourseName.Properties.MaxLength = 50;
            this.txt_CourseName.Size = new System.Drawing.Size(221, 22);
            this.txt_CourseName.TabIndex = 1;
            // 
            // txt_CourseID
            // 
            this.txt_CourseID.Enabled = false;
            this.txt_CourseID.Location = new System.Drawing.Point(164, 55);
            this.txt_CourseID.Name = "txt_CourseID";
            this.txt_CourseID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseID.Properties.Appearance.Options.UseFont = true;
            this.txt_CourseID.Size = new System.Drawing.Size(221, 22);
            this.txt_CourseID.TabIndex = 1;
            // 
            // txt_TeacherID
            // 
            this.txt_TeacherID.Location = new System.Drawing.Point(164, 93);
            this.txt_TeacherID.Name = "txt_TeacherID";
            this.txt_TeacherID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherID.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherID.Size = new System.Drawing.Size(221, 22);
            this.txt_TeacherID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Học Phần:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(63, 134);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(91, 16);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Tên học phần:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(68, 96);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "ID Giảng Viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(87, 172);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Niên khóa:";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.Image = global::DX_Application.Properties.Resources.edit_32x32;
            this.btn_Update.Location = new System.Drawing.Point(216, 664);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Update.Size = new System.Drawing.Size(104, 46);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.Image = global::DX_Application.Properties.Resources.error_32x32;
            this.btn_Delete.Location = new System.Drawing.Point(352, 664);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Delete.Size = new System.Drawing.Size(104, 46);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = global::DX_Application.Properties.Resources.add_32x32;
            this.btn_Add.Location = new System.Drawing.Point(83, 664);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Add.Size = new System.Drawing.Size(104, 46);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frm_01_CoursesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 772);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_CoursesEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học Phần";
            this.Load += new System.EventHandler(this.frm_01_EditClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_End.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DayoWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_Semester.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit date_Start;
        private DevExpress.XtraEditors.DateEdit date_End;
        private DevExpress.XtraEditors.TextEdit txt_CourseName;
        private DevExpress.XtraEditors.TextEdit txt_TeacherID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_Status;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_DayoWeek;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
        private DevExpress.XtraEditors.TextEdit txt_CourseID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_Semester;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox cbb_ClassList;
    }
}