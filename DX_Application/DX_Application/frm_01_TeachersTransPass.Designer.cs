namespace DX_Application
{
    partial class frm_01_TeachersTransPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_TeachersTransPass));
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_OldPass = new DevExpress.XtraEditors.TextEdit();
            this.txt_NewPass = new DevExpress.XtraEditors.TextEdit();
            this.txt_ReNewPass = new DevExpress.XtraEditors.TextEdit();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.check_OldPass = new DevExpress.XtraEditors.CheckButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.check_NewPass = new DevExpress.XtraEditors.CheckButton();
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_OldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ReNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(72, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(211, 44);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Đổi Mật Khẩu";
            // 
            // txt_OldPass
            // 
            this.txt_OldPass.Location = new System.Drawing.Point(11, 52);
            this.txt_OldPass.Name = "txt_OldPass";
            this.txt_OldPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OldPass.Properties.Appearance.Options.UseFont = true;
            this.txt_OldPass.Properties.PasswordChar = '*';
            this.txt_OldPass.Size = new System.Drawing.Size(238, 22);
            this.txt_OldPass.TabIndex = 22;
            this.txt_OldPass.TextChanged += new System.EventHandler(this.txt_OldPass_TextChanged);
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Location = new System.Drawing.Point(11, 68);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPass.Properties.Appearance.Options.UseFont = true;
            this.txt_NewPass.Properties.PasswordChar = '*';
            this.txt_NewPass.Size = new System.Drawing.Size(238, 22);
            this.txt_NewPass.TabIndex = 22;
            this.txt_NewPass.TextChanged += new System.EventHandler(this.txt_NewPass_TextChanged);
            // 
            // txt_ReNewPass
            // 
            this.txt_ReNewPass.Location = new System.Drawing.Point(11, 127);
            this.txt_ReNewPass.Name = "txt_ReNewPass";
            this.txt_ReNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReNewPass.Properties.Appearance.Options.UseFont = true;
            this.txt_ReNewPass.Size = new System.Drawing.Size(238, 22);
            this.txt_ReNewPass.TabIndex = 22;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Update.ImageOptions.SvgImage")));
            this.btn_Update.Location = new System.Drawing.Point(109, 411);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(137, 48);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 16);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Nhập mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(124, 16);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Xác nhận mật khẩu";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.check_OldPass);
            this.groupControl1.Controls.Add(this.txt_OldPass);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(26, 97);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(303, 91);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Mật Khẩu Cũ";
            // 
            // check_OldPass
            // 
            this.check_OldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_OldPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("check_OldPass.ImageOptions.SvgImage")));
            this.check_OldPass.Location = new System.Drawing.Point(253, 45);
            this.check_OldPass.Name = "check_OldPass";
            this.check_OldPass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.check_OldPass.Size = new System.Drawing.Size(37, 37);
            this.check_OldPass.TabIndex = 51;
            this.check_OldPass.CheckedChanged += new System.EventHandler(this.check_OldPass_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.check_NewPass);
            this.groupControl2.Controls.Add(this.txt_ReNewPass);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txt_NewPass);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(26, 221);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(303, 173);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Mật Khẩu Mới";
            // 
            // check_NewPass
            // 
            this.check_NewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_NewPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("check_NewPass.ImageOptions.SvgImage")));
            this.check_NewPass.Location = new System.Drawing.Point(253, 61);
            this.check_NewPass.Name = "check_NewPass";
            this.check_NewPass.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.check_NewPass.Size = new System.Drawing.Size(37, 37);
            this.check_NewPass.TabIndex = 51;
            this.check_NewPass.CheckedChanged += new System.EventHandler(this.check_NewPass_CheckedChanged);
            // 
            // frm_01_TransPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 492);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.labelControl6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_TransPass";
            this.Text = "Đổi Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txt_OldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ReNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_OldPass;
        private DevExpress.XtraEditors.TextEdit txt_NewPass;
        private DevExpress.XtraEditors.TextEdit txt_ReNewPass;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckButton check_OldPass;
        private DevExpress.XtraEditors.CheckButton check_NewPass;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
    }
}