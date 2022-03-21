namespace DX_Application
{
    partial class frm_SelectRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SelectRoom));
            this.cbb_ListRoom = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Accepted = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cbb_ListRoom
            // 
            this.cbb_ListRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_ListRoom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ListRoom.FormattingEnabled = true;
            this.cbb_ListRoom.Location = new System.Drawing.Point(75, 70);
            this.cbb_ListRoom.Name = "cbb_ListRoom";
            this.cbb_ListRoom.Size = new System.Drawing.Size(290, 24);
            this.cbb_ListRoom.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(107, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(226, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn Phòng Điểm Danh";
            // 
            // btn_Accepted
            // 
            this.btn_Accepted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Accepted.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accepted.Appearance.Options.UseFont = true;
            this.btn_Accepted.Location = new System.Drawing.Point(75, 113);
            this.btn_Accepted.Name = "btn_Accepted";
            this.btn_Accepted.Size = new System.Drawing.Size(115, 48);
            this.btn_Accepted.TabIndex = 2;
            this.btn_Accepted.Text = "Xác nhận";
            this.btn_Accepted.Click += new System.EventHandler(this.btn_Accepted_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(250, 113);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(115, 48);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_SelectRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 189);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accepted);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbb_ListRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SelectRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn phòng";
            this.Load += new System.EventHandler(this.frm_SelectRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_ListRoom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Accepted;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}