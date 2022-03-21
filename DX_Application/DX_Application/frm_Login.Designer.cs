namespace DX_Application
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_UserID = new DevExpress.XtraEditors.TextEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.check_Pass = new DevExpress.XtraEditors.CheckButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Accept = new DevExpress.XtraEditors.SimpleButton();
            this.alert_Info = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.btn_RegisterUser = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(46, 210);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(172, 44);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Đăng Nhập";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_UserID);
            this.panelControl1.Controls.Add(this.txt_Password);
            this.panelControl1.Controls.Add(this.btn_RegisterUser);
            this.panelControl1.Controls.Add(this.check_Pass);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_Exit);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_Accept);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(257, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(343, 285);
            this.panelControl1.TabIndex = 21;
            // 
            // txt_UserID
            // 
            this.txt_UserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserID.EditValue = "Nhập Tài khoản";
            this.txt_UserID.Location = new System.Drawing.Point(45, 42);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.Properties.Appearance.Options.UseFont = true;
            this.txt_UserID.Size = new System.Drawing.Size(272, 26);
            this.txt_UserID.TabIndex = 23;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.EditValue = "Nhập Password";
            this.txt_Password.Location = new System.Drawing.Point(45, 89);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Properties.Appearance.Options.UseFont = true;
            this.txt_Password.Size = new System.Drawing.Size(232, 26);
            this.txt_Password.TabIndex = 24;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // check_Pass
            // 
            this.check_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_Pass.ImageOptions.SvgImage = global::DX_Application.Properties.Resources.security_visibility1;
            this.check_Pass.Location = new System.Drawing.Point(280, 84);
            this.check_Pass.Name = "check_Pass";
            this.check_Pass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.check_Pass.Size = new System.Drawing.Size(37, 37);
            this.check_Pass.TabIndex = 25;
            this.check_Pass.CheckedChanged += new System.EventHandler(this.check_Pass_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageOptions.Image = global::DX_Application.Properties.Resources.encryptdocument_16x16;
            this.labelControl1.Location = new System.Drawing.Point(23, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 22);
            this.labelControl1.TabIndex = 28;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Exit.ImageOptions.SvgImage")));
            this.btn_Exit.Location = new System.Drawing.Point(196, 169);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(121, 44);
            this.btn_Exit.TabIndex = 27;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageOptions.Image = global::DX_Application.Properties.Resources.editcontact_16x16;
            this.labelControl2.Location = new System.Drawing.Point(23, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 22);
            this.labelControl2.TabIndex = 29;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Accept.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept.Appearance.Options.UseFont = true;
            this.btn_Accept.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Accept.ImageOptions.SvgImage")));
            this.btn_Accept.Location = new System.Drawing.Point(23, 169);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(121, 44);
            this.btn_Accept.TabIndex = 26;
            this.btn_Accept.Text = "Đồng Ý";
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // alert_Info
            // 
            this.alert_Info.AutoFormDelay = 2500;
            this.alert_Info.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            // 
            // btn_RegisterUser
            // 
            this.btn_RegisterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RegisterUser.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegisterUser.Appearance.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_RegisterUser.Appearance.Options.UseFont = true;
            this.btn_RegisterUser.Appearance.Options.UseForeColor = true;
            this.btn_RegisterUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegisterUser.ImageOptions.Image")));
            this.btn_RegisterUser.Location = new System.Drawing.Point(225, 247);
            this.btn_RegisterUser.Name = "btn_RegisterUser";
            this.btn_RegisterUser.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_RegisterUser.Size = new System.Drawing.Size(105, 25);
            this.btn_RegisterUser.TabIndex = 30;
            this.btn_RegisterUser.Text = "Đăng kí mới";
            this.btn_RegisterUser.Click += new System.EventHandler(this.btn_RegisterUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DX_Application.Properties.Resources.logo_ctut;
            this.pictureBox1.Location = new System.Drawing.Point(42, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 285);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống điểm danh sinh viên bằng gương mặt";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txt_UserID;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.SimpleButton btn_RegisterUser;
        private DevExpress.XtraEditors.CheckButton check_Pass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Accept;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Info;
    }
}