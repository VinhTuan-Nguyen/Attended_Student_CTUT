namespace DX_Application
{
    partial class frm_01_StudentsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_StudentsEdit));
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Date_Birthday = new DevExpress.XtraEditors.DateEdit();
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
            this.img_Avatar = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Date_Birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_Birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Major.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Avatar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Click chuột phải để load ảnh";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.Image = global::DX_Application.Properties.Resources.edit_32x32;
            this.btn_Update.Location = new System.Drawing.Point(178, 620);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Update.Size = new System.Drawing.Size(104, 46);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.Image = global::DX_Application.Properties.Resources.error_32x32;
            this.btn_Delete.Location = new System.Drawing.Point(321, 620);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Delete.Size = new System.Drawing.Size(104, 46);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = global::DX_Application.Properties.Resources.add_32x32;
            this.btn_Add.Location = new System.Drawing.Point(29, 620);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Add.Size = new System.Drawing.Size(104, 46);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.newcontact_32x32;
            this.groupControl1.Controls.Add(this.Date_Birthday);
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
            this.groupControl1.Location = new System.Drawing.Point(29, 294);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(396, 259);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin cá nhân";
            // 
            // Date_Birthday
            // 
            this.Date_Birthday.EditValue = null;
            this.Date_Birthday.Location = new System.Drawing.Point(116, 104);
            this.Date_Birthday.Name = "Date_Birthday";
            this.Date_Birthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Birthday.Properties.Appearance.Options.UseFont = true;
            this.Date_Birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date_Birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date_Birthday.Size = new System.Drawing.Size(267, 22);
            this.Date_Birthday.TabIndex = 6;
            // 
            // rdo_Female
            // 
            this.rdo_Female.AutoSize = true;
            this.rdo_Female.Location = new System.Drawing.Point(247, 211);
            this.rdo_Female.Name = "rdo_Female";
            this.rdo_Female.Size = new System.Drawing.Size(39, 17);
            this.rdo_Female.TabIndex = 5;
            this.rdo_Female.TabStop = true;
            this.rdo_Female.Text = "Nữ";
            this.rdo_Female.UseVisualStyleBackColor = true;
            // 
            // rdo_Male
            // 
            this.rdo_Male.AutoSize = true;
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
            this.txt_StudentID.Size = new System.Drawing.Size(137, 22);
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
            this.txt_FName.Size = new System.Drawing.Size(267, 22);
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
            this.txt_Major.Size = new System.Drawing.Size(267, 22);
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
            this.txt_Email.Size = new System.Drawing.Size(267, 22);
            this.txt_Email.TabIndex = 2;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(116, 182);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Properties.Appearance.Options.UseFont = true;
            this.txt_Phone.Size = new System.Drawing.Size(267, 22);
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
            // img_Avatar
            // 
            this.img_Avatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_Avatar.EditValue = global::DX_Application.Properties.Resources.logo_avatar;
            this.img_Avatar.Location = new System.Drawing.Point(140, 65);
            this.img_Avatar.Name = "img_Avatar";
            this.img_Avatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.img_Avatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.img_Avatar.Size = new System.Drawing.Size(175, 175);
            this.img_Avatar.TabIndex = 7;
            // 
            // frm_01_EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 750);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.img_Avatar);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_EditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Date_Birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date_Birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Major.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Avatar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
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
        private DevExpress.XtraEditors.PictureEdit img_Avatar;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private System.Windows.Forms.RadioButton rdo_Female;
        private System.Windows.Forms.RadioButton rdo_Male;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.DateEdit Date_Birthday;
    }
}