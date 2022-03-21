namespace DX_Application
{
    partial class frm_GetFaceData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GetFaceData));
            this.cam_GetData = new DevExpress.XtraEditors.Camera.CameraControl();
            this.btn_Capture = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbb_Email = new System.Windows.Forms.ComboBox();
            this.btn_LockSum = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LockPhone = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LockEmail = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LockMajor = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Sum = new DevExpress.XtraEditors.TextEdit();
            this.btn_LockBirthday = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LockName = new DevExpress.XtraEditors.SimpleButton();
            this.btn_LockID = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.date_Birthday = new DevExpress.XtraEditors.DateEdit();
            this.rdo_Female = new System.Windows.Forms.RadioButton();
            this.rdo_Male = new System.Windows.Forms.RadioButton();
            this.txt_StudentID = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Major = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Major.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cam_GetData
            // 
            this.cam_GetData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam_GetData.Location = new System.Drawing.Point(4, 4);
            this.cam_GetData.Name = "cam_GetData";
            this.cam_GetData.Size = new System.Drawing.Size(480, 480);
            this.cam_GetData.TabIndex = 0;
            this.cam_GetData.Text = "cameraControl1";
            this.cam_GetData.VideoStretchMode = DevExpress.XtraEditors.Camera.VideoStretchMode.ZoomOutside;
            // 
            // btn_Capture
            // 
            this.btn_Capture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Capture.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capture.Appearance.Options.UseFont = true;
            this.btn_Capture.Location = new System.Drawing.Point(596, 409);
            this.btn_Capture.Name = "btn_Capture";
            this.btn_Capture.Size = new System.Drawing.Size(96, 43);
            this.btn_Capture.TabIndex = 10;
            this.btn_Capture.Text = "Chụp";
            this.btn_Capture.Click += new System.EventHandler(this.btn_Capture_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clear.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Appearance.Options.UseFont = true;
            this.btn_Clear.Location = new System.Drawing.Point(714, 409);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(96, 43);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Xóa text";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 33);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gán Nhãn Dữ LIệu:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.newcontact_32x32;
            this.groupControl1.Controls.Add(this.cbb_Email);
            this.groupControl1.Controls.Add(this.btn_LockSum);
            this.groupControl1.Controls.Add(this.btn_LockPhone);
            this.groupControl1.Controls.Add(this.btn_LockEmail);
            this.groupControl1.Controls.Add(this.btn_LockMajor);
            this.groupControl1.Controls.Add(this.txt_Sum);
            this.groupControl1.Controls.Add(this.btn_LockBirthday);
            this.groupControl1.Controls.Add(this.btn_LockName);
            this.groupControl1.Controls.Add(this.btn_LockID);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.date_Birthday);
            this.groupControl1.Controls.Add(this.rdo_Female);
            this.groupControl1.Controls.Add(this.rdo_Male);
            this.groupControl1.Controls.Add(this.txt_StudentID);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txt_FName);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txt_Major);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txt_Email);
            this.groupControl1.Controls.Add(this.txt_Phone);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(498, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(396, 275);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin cá nhân";
            // 
            // cbb_Email
            // 
            this.cbb_Email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Email.FormattingEnabled = true;
            this.cbb_Email.Items.AddRange(new object[] {
            "@gmail.com",
            "@ctuet.edu.vn",
            "@student.ctuet.edu.vn"});
            this.cbb_Email.Location = new System.Drawing.Point(207, 155);
            this.cbb_Email.Name = "cbb_Email";
            this.cbb_Email.Size = new System.Drawing.Size(117, 24);
            this.cbb_Email.TabIndex = 11;
            // 
            // btn_LockSum
            // 
            this.btn_LockSum.Location = new System.Drawing.Point(330, 237);
            this.btn_LockSum.Name = "btn_LockSum";
            this.btn_LockSum.Size = new System.Drawing.Size(53, 23);
            this.btn_LockSum.TabIndex = 10;
            this.btn_LockSum.Text = "Khóa";
            this.btn_LockSum.Click += new System.EventHandler(this.btn_LockSum_Click);
            // 
            // btn_LockPhone
            // 
            this.btn_LockPhone.Location = new System.Drawing.Point(330, 182);
            this.btn_LockPhone.Name = "btn_LockPhone";
            this.btn_LockPhone.Size = new System.Drawing.Size(53, 23);
            this.btn_LockPhone.TabIndex = 10;
            this.btn_LockPhone.Text = "Khóa";
            this.btn_LockPhone.Click += new System.EventHandler(this.btn_LockPhone_Click);
            // 
            // btn_LockEmail
            // 
            this.btn_LockEmail.Location = new System.Drawing.Point(330, 156);
            this.btn_LockEmail.Name = "btn_LockEmail";
            this.btn_LockEmail.Size = new System.Drawing.Size(53, 23);
            this.btn_LockEmail.TabIndex = 10;
            this.btn_LockEmail.Text = "Khóa";
            this.btn_LockEmail.Click += new System.EventHandler(this.btn_LockEmail_Click);
            // 
            // btn_LockMajor
            // 
            this.btn_LockMajor.Location = new System.Drawing.Point(330, 130);
            this.btn_LockMajor.Name = "btn_LockMajor";
            this.btn_LockMajor.Size = new System.Drawing.Size(53, 23);
            this.btn_LockMajor.TabIndex = 10;
            this.btn_LockMajor.Text = "Khóa";
            this.btn_LockMajor.Click += new System.EventHandler(this.btn_LockMajor_Click);
            // 
            // txt_Sum
            // 
            this.txt_Sum.Location = new System.Drawing.Point(116, 237);
            this.txt_Sum.Name = "txt_Sum";
            this.txt_Sum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sum.Properties.Appearance.Options.UseFont = true;
            this.txt_Sum.Properties.Mask.BeepOnError = true;
            this.txt_Sum.Properties.Mask.EditMask = "d";
            this.txt_Sum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Sum.Size = new System.Drawing.Size(208, 22);
            this.txt_Sum.TabIndex = 2;
            // 
            // btn_LockBirthday
            // 
            this.btn_LockBirthday.Location = new System.Drawing.Point(330, 104);
            this.btn_LockBirthday.Name = "btn_LockBirthday";
            this.btn_LockBirthday.Size = new System.Drawing.Size(53, 23);
            this.btn_LockBirthday.TabIndex = 10;
            this.btn_LockBirthday.Text = "Khóa";
            this.btn_LockBirthday.Click += new System.EventHandler(this.btn_LockBirthday_Click);
            // 
            // btn_LockName
            // 
            this.btn_LockName.Location = new System.Drawing.Point(330, 78);
            this.btn_LockName.Name = "btn_LockName";
            this.btn_LockName.Size = new System.Drawing.Size(53, 23);
            this.btn_LockName.TabIndex = 10;
            this.btn_LockName.Text = "Khóa";
            this.btn_LockName.Click += new System.EventHandler(this.btn_LockName_Click);
            // 
            // btn_LockID
            // 
            this.btn_LockID.Location = new System.Drawing.Point(330, 52);
            this.btn_LockID.Name = "btn_LockID";
            this.btn_LockID.Size = new System.Drawing.Size(53, 23);
            this.btn_LockID.TabIndex = 10;
            this.btn_LockID.Text = "Khóa";
            this.btn_LockID.Click += new System.EventHandler(this.btn_LockID_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "SL ảnh chụp:";
            // 
            // date_Birthday
            // 
            this.date_Birthday.EditValue = null;
            this.date_Birthday.Location = new System.Drawing.Point(116, 104);
            this.date_Birthday.Name = "date_Birthday";
            this.date_Birthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Birthday.Properties.Appearance.Options.UseFont = true;
            this.date_Birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_Birthday.Size = new System.Drawing.Size(208, 22);
            this.date_Birthday.TabIndex = 6;
            // 
            // rdo_Female
            // 
            this.rdo_Female.AutoSize = true;
            this.rdo_Female.Location = new System.Drawing.Point(247, 211);
            this.rdo_Female.Name = "rdo_Female";
            this.rdo_Female.Size = new System.Drawing.Size(39, 17);
            this.rdo_Female.TabIndex = 5;
            this.rdo_Female.Text = "Nữ";
            this.rdo_Female.UseVisualStyleBackColor = true;
            // 
            // rdo_Male
            // 
            this.rdo_Male.AutoSize = true;
            this.rdo_Male.Checked = true;
            this.rdo_Male.Location = new System.Drawing.Point(161, 211);
            this.rdo_Male.Name = "rdo_Male";
            this.rdo_Male.Size = new System.Drawing.Size(46, 17);
            this.rdo_Male.TabIndex = 5;
            this.rdo_Male.TabStop = true;
            this.rdo_Male.Text = "Nam";
            this.rdo_Male.UseVisualStyleBackColor = true;
            // 
            // txt_StudentID
            // 
            this.txt_StudentID.Location = new System.Drawing.Point(116, 52);
            this.txt_StudentID.Name = "txt_StudentID";
            this.txt_StudentID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentID.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentID.Properties.MaxLength = 10;
            this.txt_StudentID.Size = new System.Drawing.Size(208, 22);
            this.txt_StudentID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đầy đủ:";
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(116, 78);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.Properties.Appearance.Options.UseFont = true;
            this.txt_FName.Properties.MaxLength = 30;
            this.txt_FName.Size = new System.Drawing.Size(208, 22);
            this.txt_FName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyên ngành:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giới tính:";
            // 
            // txt_Major
            // 
            this.txt_Major.Location = new System.Drawing.Point(116, 130);
            this.txt_Major.Name = "txt_Major";
            this.txt_Major.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Major.Properties.Appearance.Options.UseFont = true;
            this.txt_Major.Size = new System.Drawing.Size(208, 22);
            this.txt_Major.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "MSSV:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(116, 156);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Properties.Appearance.Options.UseFont = true;
            this.txt_Email.Size = new System.Drawing.Size(85, 22);
            this.txt_Email.TabIndex = 2;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(116, 182);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Properties.Appearance.Options.UseFont = true;
            this.txt_Phone.Size = new System.Drawing.Size(208, 22);
            this.txt_Phone.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone:";
            // 
            // frm_GetFaceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 489);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Capture);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cam_GetData);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_GetFaceData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gán nhãn dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_Birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Major.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Camera.CameraControl cam_GetData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_LockPhone;
        private DevExpress.XtraEditors.SimpleButton btn_LockEmail;
        private DevExpress.XtraEditors.SimpleButton btn_LockMajor;
        private DevExpress.XtraEditors.SimpleButton btn_LockBirthday;
        private DevExpress.XtraEditors.SimpleButton btn_LockName;
        private DevExpress.XtraEditors.SimpleButton btn_LockID;
        private DevExpress.XtraEditors.DateEdit date_Birthday;
        private System.Windows.Forms.RadioButton rdo_Female;
        private System.Windows.Forms.RadioButton rdo_Male;
        private DevExpress.XtraEditors.TextEdit txt_StudentID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_FName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txt_Major;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_Phone;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_Capture;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.TextEdit txt_Sum;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btn_LockSum;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
        private System.Windows.Forms.ComboBox cbb_Email;
        private System.Windows.Forms.Label label8;
    }
}