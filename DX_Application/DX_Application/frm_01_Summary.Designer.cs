namespace DX_Application
{
    partial class frm_01_Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_Summary));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grid_Attended = new DevExpress.XtraGrid.GridControl();
            this.view_Attended = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcol_Index_Attended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_DateAtd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colcol_TimeAtd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_CoursesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_TeacherID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_RoomID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.rdo_Differ = new System.Windows.Forms.RadioButton();
            this.rdo_NotYet = new System.Windows.Forms.RadioButton();
            this.rdo_Not = new System.Windows.Forms.RadioButton();
            this.rdo_Yes = new System.Windows.Forms.RadioButton();
            this.btn_Accept = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_AttendedID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DateAtd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TimeAtd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CourseID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TeacherID = new DevExpress.XtraEditors.TextEdit();
            this.txt_StudentID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_RoomID = new DevExpress.XtraEditors.TextEdit();
            this.alert_Message = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Attended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Attended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendedID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateAtd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeAtd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grid_Attended);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(875, 717);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grid_Attended
            // 
            this.grid_Attended.Location = new System.Drawing.Point(12, 12);
            this.grid_Attended.MainView = this.view_Attended;
            this.grid_Attended.Name = "grid_Attended";
            this.grid_Attended.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.grid_Attended.Size = new System.Drawing.Size(851, 693);
            this.grid_Attended.TabIndex = 4;
            this.grid_Attended.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view_Attended});
            // 
            // view_Attended
            // 
            this.view_Attended.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcol_Index_Attended,
            this.colcol_DateAtd,
            this.colcol_TimeAtd,
            this.colcol_CoursesID,
            this.colcol_StudentID,
            this.colcol_TeacherID,
            this.colcol_RoomID,
            this.colcol_Note});
            this.view_Attended.GridControl = this.grid_Attended;
            this.view_Attended.Name = "view_Attended";
            this.view_Attended.OptionsView.ShowAutoFilterRow = true;
            this.view_Attended.OptionsView.ShowFooter = true;
            this.view_Attended.OptionsView.ShowGroupPanel = false;
            this.view_Attended.OptionsView.ShowViewCaption = true;
            this.view_Attended.ViewCaption = "Danh Sách Điểm Danh";
            this.view_Attended.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.view_Attended_FocusedRowChanged);
            // 
            // colcol_Index_Attended
            // 
            this.colcol_Index_Attended.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Index_Attended.AppearanceHeader.Options.UseFont = true;
            this.colcol_Index_Attended.Caption = "Mã số điểm danh";
            this.colcol_Index_Attended.FieldName = "col_Index_Attended";
            this.colcol_Index_Attended.Name = "colcol_Index_Attended";
            this.colcol_Index_Attended.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "col_Index_Attended", "{0}")});
            this.colcol_Index_Attended.Visible = true;
            this.colcol_Index_Attended.VisibleIndex = 0;
            // 
            // colcol_DateAtd
            // 
            this.colcol_DateAtd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_DateAtd.AppearanceHeader.Options.UseFont = true;
            this.colcol_DateAtd.Caption = "Ngày điểm danh";
            this.colcol_DateAtd.ColumnEdit = this.repositoryItemDateEdit1;
            this.colcol_DateAtd.FieldName = "col_DateAtd";
            this.colcol_DateAtd.Name = "colcol_DateAtd";
            this.colcol_DateAtd.Visible = true;
            this.colcol_DateAtd.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colcol_TimeAtd
            // 
            this.colcol_TimeAtd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_TimeAtd.AppearanceHeader.Options.UseFont = true;
            this.colcol_TimeAtd.Caption = "Điểm danh lúc";
            this.colcol_TimeAtd.FieldName = "col_TimeAtd";
            this.colcol_TimeAtd.Name = "colcol_TimeAtd";
            this.colcol_TimeAtd.Visible = true;
            this.colcol_TimeAtd.VisibleIndex = 2;
            // 
            // colcol_CoursesID
            // 
            this.colcol_CoursesID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_CoursesID.AppearanceHeader.Options.UseFont = true;
            this.colcol_CoursesID.Caption = "Mã học phần";
            this.colcol_CoursesID.FieldName = "col_CoursesID";
            this.colcol_CoursesID.Name = "colcol_CoursesID";
            this.colcol_CoursesID.Visible = true;
            this.colcol_CoursesID.VisibleIndex = 3;
            // 
            // colcol_StudentID
            // 
            this.colcol_StudentID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_StudentID.AppearanceHeader.Options.UseFont = true;
            this.colcol_StudentID.Caption = "MSSV";
            this.colcol_StudentID.FieldName = "col_StudentID";
            this.colcol_StudentID.Name = "colcol_StudentID";
            this.colcol_StudentID.Visible = true;
            this.colcol_StudentID.VisibleIndex = 4;
            // 
            // colcol_TeacherID
            // 
            this.colcol_TeacherID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_TeacherID.AppearanceHeader.Options.UseFont = true;
            this.colcol_TeacherID.Caption = "ID Giảng viên";
            this.colcol_TeacherID.FieldName = "col_TeacherID";
            this.colcol_TeacherID.Name = "colcol_TeacherID";
            this.colcol_TeacherID.Visible = true;
            this.colcol_TeacherID.VisibleIndex = 5;
            // 
            // colcol_RoomID
            // 
            this.colcol_RoomID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_RoomID.AppearanceHeader.Options.UseFont = true;
            this.colcol_RoomID.Caption = "ID phòng học";
            this.colcol_RoomID.FieldName = "col_RoomID";
            this.colcol_RoomID.Name = "colcol_RoomID";
            this.colcol_RoomID.Visible = true;
            this.colcol_RoomID.VisibleIndex = 6;
            // 
            // colcol_Note
            // 
            this.colcol_Note.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Note.AppearanceHeader.Options.UseFont = true;
            this.colcol_Note.Caption = "Ghi chú";
            this.colcol_Note.FieldName = "col_Note";
            this.colcol_Note.Name = "colcol_Note";
            this.colcol_Note.Visible = true;
            this.colcol_Note.VisibleIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(875, 717);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grid_Attended;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(855, 697);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = global::DX_Application.Properties.Resources.notes_32x32;
            this.groupControl1.Controls.Add(this.txt_Note);
            this.groupControl1.Controls.Add(this.rdo_Differ);
            this.groupControl1.Controls.Add(this.rdo_NotYet);
            this.groupControl1.Controls.Add(this.rdo_Not);
            this.groupControl1.Controls.Add(this.rdo_Yes);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(912, 297);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(308, 308);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Ghi chú";
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Note.Location = new System.Drawing.Point(22, 125);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(265, 164);
            this.txt_Note.TabIndex = 4;
            // 
            // rdo_Differ
            // 
            this.rdo_Differ.AutoSize = true;
            this.rdo_Differ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdo_Differ.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Differ.Location = new System.Drawing.Point(181, 92);
            this.rdo_Differ.Name = "rdo_Differ";
            this.rdo_Differ.Size = new System.Drawing.Size(53, 18);
            this.rdo_Differ.TabIndex = 3;
            this.rdo_Differ.TabStop = true;
            this.rdo_Differ.Text = "Khác";
            this.rdo_Differ.UseVisualStyleBackColor = true;
            this.rdo_Differ.CheckedChanged += new System.EventHandler(this.rdo_Differ_CheckedChanged);
            // 
            // rdo_NotYet
            // 
            this.rdo_NotYet.AutoSize = true;
            this.rdo_NotYet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdo_NotYet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_NotYet.Location = new System.Drawing.Point(181, 68);
            this.rdo_NotYet.Name = "rdo_NotYet";
            this.rdo_NotYet.Size = new System.Drawing.Size(108, 18);
            this.rdo_NotYet.TabIndex = 3;
            this.rdo_NotYet.TabStop = true;
            this.rdo_NotYet.Text = "Vắng có phép";
            this.rdo_NotYet.UseVisualStyleBackColor = true;
            this.rdo_NotYet.CheckedChanged += new System.EventHandler(this.rdo_NotYet_CheckedChanged);
            // 
            // rdo_Not
            // 
            this.rdo_Not.AutoSize = true;
            this.rdo_Not.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdo_Not.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Not.Location = new System.Drawing.Point(24, 68);
            this.rdo_Not.Name = "rdo_Not";
            this.rdo_Not.Size = new System.Drawing.Size(133, 18);
            this.rdo_Not.TabIndex = 3;
            this.rdo_Not.TabStop = true;
            this.rdo_Not.Text = "Vắng không phép";
            this.rdo_Not.UseVisualStyleBackColor = true;
            this.rdo_Not.CheckedChanged += new System.EventHandler(this.rdo_Not_CheckedChanged);
            // 
            // rdo_Yes
            // 
            this.rdo_Yes.AutoSize = true;
            this.rdo_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdo_Yes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Yes.Location = new System.Drawing.Point(24, 92);
            this.rdo_Yes.Name = "rdo_Yes";
            this.rdo_Yes.Size = new System.Drawing.Size(68, 18);
            this.rdo_Yes.TabIndex = 3;
            this.rdo_Yes.TabStop = true;
            this.rdo_Yes.Text = "Có mặt";
            this.rdo_Yes.UseVisualStyleBackColor = true;
            this.rdo_Yes.CheckedChanged += new System.EventHandler(this.rdo_Yes_CheckedChanged);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Accept.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accept.Appearance.Options.UseFont = true;
            this.btn_Accept.Location = new System.Drawing.Point(912, 640);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(120, 43);
            this.btn_Accept.TabIndex = 4;
            this.btn_Accept.Text = "Cập nhật";
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new System.Drawing.Point(1100, 640);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(120, 43);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(912, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã số điểm danh:";
            // 
            // txt_AttendedID
            // 
            this.txt_AttendedID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_AttendedID.Enabled = false;
            this.txt_AttendedID.Location = new System.Drawing.Point(1029, 70);
            this.txt_AttendedID.Name = "txt_AttendedID";
            this.txt_AttendedID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AttendedID.Properties.Appearance.Options.UseFont = true;
            this.txt_AttendedID.Size = new System.Drawing.Size(191, 22);
            this.txt_AttendedID.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(912, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Ngày điểm danh:";
            // 
            // txt_DateAtd
            // 
            this.txt_DateAtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DateAtd.Enabled = false;
            this.txt_DateAtd.Location = new System.Drawing.Point(1029, 98);
            this.txt_DateAtd.Name = "txt_DateAtd";
            this.txt_DateAtd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateAtd.Properties.Appearance.Options.UseFont = true;
            this.txt_DateAtd.Size = new System.Drawing.Size(191, 22);
            this.txt_DateAtd.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(912, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Điểm danh lúc:";
            // 
            // txt_TimeAtd
            // 
            this.txt_TimeAtd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimeAtd.Enabled = false;
            this.txt_TimeAtd.Location = new System.Drawing.Point(1029, 126);
            this.txt_TimeAtd.Name = "txt_TimeAtd";
            this.txt_TimeAtd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeAtd.Properties.Appearance.Options.UseFont = true;
            this.txt_TimeAtd.Size = new System.Drawing.Size(191, 22);
            this.txt_TimeAtd.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(912, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 14);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Mã học phần:";
            // 
            // txt_CourseID
            // 
            this.txt_CourseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CourseID.Enabled = false;
            this.txt_CourseID.Location = new System.Drawing.Point(1029, 154);
            this.txt_CourseID.Name = "txt_CourseID";
            this.txt_CourseID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CourseID.Properties.Appearance.Options.UseFont = true;
            this.txt_CourseID.Size = new System.Drawing.Size(191, 22);
            this.txt_CourseID.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(912, 214);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 14);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "ID Giảng viên:";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(912, 186);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "MSSV:";
            // 
            // txt_TeacherID
            // 
            this.txt_TeacherID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TeacherID.Enabled = false;
            this.txt_TeacherID.Location = new System.Drawing.Point(1029, 210);
            this.txt_TeacherID.Name = "txt_TeacherID";
            this.txt_TeacherID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherID.Properties.Appearance.Options.UseFont = true;
            this.txt_TeacherID.Size = new System.Drawing.Size(191, 22);
            this.txt_TeacherID.TabIndex = 6;
            // 
            // txt_StudentID
            // 
            this.txt_StudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_StudentID.Enabled = false;
            this.txt_StudentID.Location = new System.Drawing.Point(1029, 182);
            this.txt_StudentID.Name = "txt_StudentID";
            this.txt_StudentID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentID.Properties.Appearance.Options.UseFont = true;
            this.txt_StudentID.Size = new System.Drawing.Size(191, 22);
            this.txt_StudentID.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(912, 242);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(88, 14);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "ID Phòng học:";
            // 
            // txt_RoomID
            // 
            this.txt_RoomID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_RoomID.Enabled = false;
            this.txt_RoomID.Location = new System.Drawing.Point(1029, 238);
            this.txt_RoomID.Name = "txt_RoomID";
            this.txt_RoomID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomID.Properties.Appearance.Options.UseFont = true;
            this.txt_RoomID.Size = new System.Drawing.Size(191, 22);
            this.txt_RoomID.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(948, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(237, 29);
            this.labelControl8.TabIndex = 12;
            this.labelControl8.Text = "Tổng kết điểm danh";
            // 
            // frm_01_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 717);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txt_RoomID);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_CourseID);
            this.Controls.Add(this.txt_StudentID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_TeacherID);
            this.Controls.Add(this.txt_DateAtd);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_TimeAtd);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_AttendedID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng kết điểm danh";
            this.Load += new System.EventHandler(this.frm_01_Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Attended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Attended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendedID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DateAtd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeAtd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CourseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TeacherID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoomID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grid_Attended;
        private DevExpress.XtraGrid.Views.Grid.GridView view_Attended;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Index_Attended;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_DateAtd;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_TimeAtd;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_CoursesID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_StudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_TeacherID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_RoomID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Note;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.RadioButton rdo_Differ;
        private System.Windows.Forms.RadioButton rdo_NotYet;
        private System.Windows.Forms.RadioButton rdo_Not;
        private System.Windows.Forms.RadioButton rdo_Yes;
        private DevExpress.XtraEditors.SimpleButton btn_Accept;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_AttendedID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_DateAtd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_TimeAtd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_CourseID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_TeacherID;
        private DevExpress.XtraEditors.TextEdit txt_StudentID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_RoomID;
        private DevExpress.XtraBars.Alerter.AlertControl alert_Message;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}