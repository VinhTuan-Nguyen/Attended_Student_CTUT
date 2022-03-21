namespace DX_Application
{
    partial class frm_01_ClassRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_ClassRooms));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Capacity = new DevExpress.XtraEditors.TextEdit();
            this.txt_RoomName = new DevExpress.XtraEditors.TextEdit();
            this.txt_TeacherID = new DevExpress.XtraEditors.TextEdit();
            this.txt_RoomID = new DevExpress.XtraEditors.TextEdit();
            this.grid_ClassRooms = new DevExpress.XtraGrid.GridControl();
            this.tb_ClassRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ClassRooms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcol_RoomID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_Capacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_CreateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Capacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ClassRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClassRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ClassRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.grid_ClassRooms);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(908, 461);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.logical_32x32;
            this.groupControl1.Controls.Add(this.btn_Delete);
            this.groupControl1.Controls.Add(this.btn_Update);
            this.groupControl1.Controls.Add(this.btn_Add);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txt_Capacity);
            this.groupControl1.Controls.Add(this.txt_RoomName);
            this.groupControl1.Controls.Add(this.txt_TeacherID);
            this.groupControl1.Controls.Add(this.txt_RoomID);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 437);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin lớp";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Appearance.Options.UseForeColor = true;
            this.btn_Delete.Location = new System.Drawing.Point(184, 358);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 46);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseForeColor = true;
            this.btn_Update.Location = new System.Drawing.Point(67, 289);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(225, 53);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Sửa thông tin";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Appearance.Options.UseForeColor = true;
            this.btn_Add.Location = new System.Drawing.Point(67, 358);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 46);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Tạo mới";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 220);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Sức chứa:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên phòng học:";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 14);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mã Giảng viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 118);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã phòng học:";
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Capacity.Location = new System.Drawing.Point(27, 240);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Capacity.Properties.Appearance.Options.UseFont = true;
            this.txt_Capacity.Properties.Mask.BeepOnError = true;
            this.txt_Capacity.Properties.Mask.EditMask = "d";
            this.txt_Capacity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_Capacity.Size = new System.Drawing.Size(305, 22);
            this.txt_Capacity.TabIndex = 0;
            // 
            // txt_RoomName
            // 
            this.txt_RoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RoomName.Location = new System.Drawing.Point(27, 189);
            this.txt_RoomName.Name = "txt_RoomName";
            this.txt_RoomName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomName.Properties.Appearance.Options.UseFont = true;
            this.txt_RoomName.Size = new System.Drawing.Size(305, 22);
            this.txt_RoomName.TabIndex = 0;
            // 
            // txt_TeacherID
            // 
            this.txt_TeacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TeacherID.Enabled = false;
            this.txt_TeacherID.Location = new System.Drawing.Point(27, 87);
            this.txt_TeacherID.Name = "txt_TeacherID";
            this.txt_TeacherID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherID.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherID.Size = new System.Drawing.Size(305, 22);
            this.txt_TeacherID.TabIndex = 0;
            // 
            // txt_RoomID
            // 
            this.txt_RoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RoomID.Location = new System.Drawing.Point(27, 138);
            this.txt_RoomID.Name = "txt_RoomID";
            this.txt_RoomID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomID.Properties.Appearance.Options.UseFont = true;
            this.txt_RoomID.Size = new System.Drawing.Size(305, 22);
            this.txt_RoomID.TabIndex = 0;
            // 
            // grid_ClassRooms
            // 
            this.grid_ClassRooms.DataSource = this.tb_ClassRoomsBindingSource;
            this.grid_ClassRooms.Location = new System.Drawing.Point(373, 12);
            this.grid_ClassRooms.MainView = this.view_ClassRooms;
            this.grid_ClassRooms.Name = "grid_ClassRooms";
            this.grid_ClassRooms.Size = new System.Drawing.Size(523, 437);
            this.grid_ClassRooms.TabIndex = 4;
            this.grid_ClassRooms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view_ClassRooms});
            // 
            // tb_ClassRoomsBindingSource
            // 
            this.tb_ClassRoomsBindingSource.DataSource = typeof(DX_Application.tb_ClassRooms);
            // 
            // view_ClassRooms
            // 
            this.view_ClassRooms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcol_RoomID,
            this.colcol_RoomName,
            this.colcol_Capacity,
            this.colcol_CreateID});
            this.view_ClassRooms.GridControl = this.grid_ClassRooms;
            this.view_ClassRooms.Name = "view_ClassRooms";
            this.view_ClassRooms.OptionsView.ShowAutoFilterRow = true;
            this.view_ClassRooms.OptionsView.ShowFooter = true;
            this.view_ClassRooms.OptionsView.ShowGroupPanel = false;
            this.view_ClassRooms.OptionsView.ShowViewCaption = true;
            this.view_ClassRooms.ViewCaption = "Danh Mục Phòng Học";
            this.view_ClassRooms.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.view_ClassRooms_FocusedRowChanged);
            // 
            // colcol_RoomID
            // 
            this.colcol_RoomID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_RoomID.AppearanceHeader.Options.UseFont = true;
            this.colcol_RoomID.Caption = "Mã phòng học";
            this.colcol_RoomID.FieldName = "col_RoomID";
            this.colcol_RoomID.Name = "colcol_RoomID";
            this.colcol_RoomID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "col_RoomID", "{0}")});
            this.colcol_RoomID.Visible = true;
            this.colcol_RoomID.VisibleIndex = 0;
            this.colcol_RoomID.Width = 87;
            // 
            // colcol_RoomName
            // 
            this.colcol_RoomName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_RoomName.AppearanceHeader.Options.UseFont = true;
            this.colcol_RoomName.Caption = "Tên phòng học";
            this.colcol_RoomName.FieldName = "col_RoomName";
            this.colcol_RoomName.Name = "colcol_RoomName";
            this.colcol_RoomName.Visible = true;
            this.colcol_RoomName.VisibleIndex = 1;
            this.colcol_RoomName.Width = 261;
            // 
            // colcol_Capacity
            // 
            this.colcol_Capacity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Capacity.AppearanceHeader.Options.UseFont = true;
            this.colcol_Capacity.Caption = "Sức chứa";
            this.colcol_Capacity.FieldName = "col_Capacity";
            this.colcol_Capacity.Name = "colcol_Capacity";
            this.colcol_Capacity.Visible = true;
            this.colcol_Capacity.VisibleIndex = 2;
            this.colcol_Capacity.Width = 77;
            // 
            // colcol_CreateID
            // 
            this.colcol_CreateID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_CreateID.AppearanceHeader.Options.UseFont = true;
            this.colcol_CreateID.Caption = "Người tạo";
            this.colcol_CreateID.FieldName = "col_CreateID";
            this.colcol_CreateID.Name = "colcol_CreateID";
            this.colcol_CreateID.Visible = true;
            this.colcol_CreateID.VisibleIndex = 3;
            this.colcol_CreateID.Width = 80;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(908, 461);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grid_ClassRooms;
            this.layoutControlItem1.Location = new System.Drawing.Point(361, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(527, 441);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(361, 441);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // alert_Message
            // 
            this.alert_Message.AutoFormDelay = 2000;
            this.alert_Message.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            // 
            // frm_01_ClassRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 461);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_ClassRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng học";
            this.Load += new System.EventHandler(this.frm_01_ClassRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Capacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ClassRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClassRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ClassRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grid_ClassRooms;
        private System.Windows.Forms.BindingSource tb_ClassRoomsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView view_ClassRooms;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_RoomID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Capacity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Capacity;
        private DevExpress.XtraEditors.TextEdit txt_RoomName;
        private DevExpress.XtraEditors.TextEdit txt_TeacherID;
        private DevExpress.XtraEditors.TextEdit txt_RoomID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_CreateID;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
    }
}