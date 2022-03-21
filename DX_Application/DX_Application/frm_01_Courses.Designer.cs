namespace DX_Application
{
    partial class frm_01_Courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_01_Courses));
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.grid_Students = new DevExpress.XtraGrid.GridControl();
            this.view_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcol_StudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_FName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_DayoBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_Major = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grid_Courses = new DevExpress.XtraGrid.GridControl();
            this.view_Courses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcol_CoursesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_CoursesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_Semester = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_DateStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_DayoWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_TeacherID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcol_RoomID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.grid_Students);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.layoutControl2.Location = new System.Drawing.Point(706, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(550, 789);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // grid_Students
            // 
            this.grid_Students.Location = new System.Drawing.Point(12, 12);
            this.grid_Students.MainView = this.view_Students;
            this.grid_Students.Name = "grid_Students";
            this.grid_Students.Size = new System.Drawing.Size(526, 765);
            this.grid_Students.TabIndex = 4;
            this.grid_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view_Students});
            // 
            // view_Students
            // 
            this.view_Students.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcol_StudentID,
            this.colcol_FName,
            this.colcol_DayoBirth,
            this.colcol_Major,
            this.colcol_Phone});
            this.view_Students.GridControl = this.grid_Students;
            this.view_Students.Name = "view_Students";
            this.view_Students.OptionsView.ShowAutoFilterRow = true;
            this.view_Students.OptionsView.ShowFooter = true;
            this.view_Students.OptionsView.ShowGroupPanel = false;
            this.view_Students.OptionsView.ShowViewCaption = true;
            this.view_Students.ViewCaption = "Danh Sách Sinh Viên";
            // 
            // colcol_StudentID
            // 
            this.colcol_StudentID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_StudentID.AppearanceHeader.Options.UseFont = true;
            this.colcol_StudentID.Caption = "MSSV";
            this.colcol_StudentID.FieldName = "col_StudentID";
            this.colcol_StudentID.Name = "colcol_StudentID";
            this.colcol_StudentID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "col_ID", "{0}")});
            this.colcol_StudentID.Visible = true;
            this.colcol_StudentID.VisibleIndex = 0;
            this.colcol_StudentID.Width = 69;
            // 
            // colcol_FName
            // 
            this.colcol_FName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_FName.AppearanceHeader.Options.UseFont = true;
            this.colcol_FName.Caption = "Tên đầy đủ";
            this.colcol_FName.FieldName = "col_FName";
            this.colcol_FName.Name = "colcol_FName";
            this.colcol_FName.Visible = true;
            this.colcol_FName.VisibleIndex = 1;
            this.colcol_FName.Width = 223;
            // 
            // colcol_DayoBirth
            // 
            this.colcol_DayoBirth.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_DayoBirth.AppearanceHeader.Options.UseFont = true;
            this.colcol_DayoBirth.Caption = "Ngày sinh";
            this.colcol_DayoBirth.FieldName = "col_DayoBirth";
            this.colcol_DayoBirth.Name = "colcol_DayoBirth";
            this.colcol_DayoBirth.Visible = true;
            this.colcol_DayoBirth.VisibleIndex = 2;
            this.colcol_DayoBirth.Width = 134;
            // 
            // colcol_Major
            // 
            this.colcol_Major.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Major.AppearanceHeader.Options.UseFont = true;
            this.colcol_Major.Caption = "Chuyên ngành";
            this.colcol_Major.FieldName = "col_Major";
            this.colcol_Major.Name = "colcol_Major";
            this.colcol_Major.Visible = true;
            this.colcol_Major.VisibleIndex = 3;
            this.colcol_Major.Width = 129;
            // 
            // colcol_Phone
            // 
            this.colcol_Phone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Phone.AppearanceHeader.Options.UseFont = true;
            this.colcol_Phone.Caption = "Di động";
            this.colcol_Phone.FieldName = "col_Phone";
            this.colcol_Phone.Name = "colcol_Phone";
            this.colcol_Phone.Visible = true;
            this.colcol_Phone.VisibleIndex = 4;
            this.colcol_Phone.Width = 113;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layoutControlGroup1.AppearanceGroup.Options.UseBackColor = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(550, 789);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grid_Students;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(530, 769);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grid_Courses);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(706, 789);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grid_Courses
            // 
            this.grid_Courses.Location = new System.Drawing.Point(12, 12);
            this.grid_Courses.MainView = this.view_Courses;
            this.grid_Courses.Name = "grid_Courses";
            this.grid_Courses.Size = new System.Drawing.Size(682, 765);
            this.grid_Courses.TabIndex = 4;
            this.grid_Courses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view_Courses});
            // 
            // view_Courses
            // 
            this.view_Courses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcol_CoursesID,
            this.colcol_CoursesName,
            this.colcol_Semester,
            this.colcol_DateStr,
            this.colcol_DateEnd,
            this.colcol_DayoWeek,
            this.colcol_Status,
            this.colcol_TeacherID,
            this.colcol_RoomID});
            this.view_Courses.GridControl = this.grid_Courses;
            this.view_Courses.Name = "view_Courses";
            this.view_Courses.OptionsView.ShowAutoFilterRow = true;
            this.view_Courses.OptionsView.ShowFooter = true;
            this.view_Courses.OptionsView.ShowGroupPanel = false;
            this.view_Courses.OptionsView.ShowViewCaption = true;
            this.view_Courses.ViewCaption = "Danh Sách Học Phần Giảng Dạy";
            this.view_Courses.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.view_Courses_RowClick);
            this.view_Courses.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.view_Courses_FocusedRowChanged);
            // 
            // colcol_CoursesID
            // 
            this.colcol_CoursesID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_CoursesID.AppearanceHeader.Options.UseFont = true;
            this.colcol_CoursesID.Caption = "Mã lớp";
            this.colcol_CoursesID.FieldName = "col_CoursesID";
            this.colcol_CoursesID.Name = "colcol_CoursesID";
            this.colcol_CoursesID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "col_ClassID", "{0}")});
            this.colcol_CoursesID.Visible = true;
            this.colcol_CoursesID.VisibleIndex = 0;
            this.colcol_CoursesID.Width = 111;
            // 
            // colcol_CoursesName
            // 
            this.colcol_CoursesName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_CoursesName.AppearanceHeader.Options.UseFont = true;
            this.colcol_CoursesName.Caption = "Tên lớp";
            this.colcol_CoursesName.FieldName = "col_CoursesName";
            this.colcol_CoursesName.Name = "colcol_CoursesName";
            this.colcol_CoursesName.Visible = true;
            this.colcol_CoursesName.VisibleIndex = 1;
            this.colcol_CoursesName.Width = 407;
            // 
            // colcol_Semester
            // 
            this.colcol_Semester.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Semester.AppearanceHeader.Options.UseFont = true;
            this.colcol_Semester.Caption = "Niên khóa";
            this.colcol_Semester.FieldName = "col_Semester";
            this.colcol_Semester.Name = "colcol_Semester";
            this.colcol_Semester.Visible = true;
            this.colcol_Semester.VisibleIndex = 2;
            this.colcol_Semester.Width = 122;
            // 
            // colcol_DateStr
            // 
            this.colcol_DateStr.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_DateStr.AppearanceHeader.Options.UseFont = true;
            this.colcol_DateStr.Caption = "Ngày bắt đầu";
            this.colcol_DateStr.FieldName = "col_DateStr";
            this.colcol_DateStr.Name = "colcol_DateStr";
            this.colcol_DateStr.Visible = true;
            this.colcol_DateStr.VisibleIndex = 3;
            this.colcol_DateStr.Width = 130;
            // 
            // colcol_DateEnd
            // 
            this.colcol_DateEnd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_DateEnd.AppearanceHeader.Options.UseFont = true;
            this.colcol_DateEnd.Caption = "Ngày kết thúc";
            this.colcol_DateEnd.FieldName = "col_DateEnd";
            this.colcol_DateEnd.Name = "colcol_DateEnd";
            this.colcol_DateEnd.Visible = true;
            this.colcol_DateEnd.VisibleIndex = 4;
            this.colcol_DateEnd.Width = 126;
            // 
            // colcol_DayoWeek
            // 
            this.colcol_DayoWeek.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_DayoWeek.AppearanceHeader.Options.UseFont = true;
            this.colcol_DayoWeek.Caption = "Thứ";
            this.colcol_DayoWeek.FieldName = "col_DayoWeek";
            this.colcol_DayoWeek.Name = "colcol_DayoWeek";
            this.colcol_DayoWeek.Visible = true;
            this.colcol_DayoWeek.VisibleIndex = 5;
            this.colcol_DayoWeek.Width = 82;
            // 
            // colcol_Status
            // 
            this.colcol_Status.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_Status.AppearanceHeader.Options.UseFont = true;
            this.colcol_Status.Caption = "Trạng thái";
            this.colcol_Status.FieldName = "col_Status";
            this.colcol_Status.Name = "colcol_Status";
            this.colcol_Status.Visible = true;
            this.colcol_Status.VisibleIndex = 6;
            this.colcol_Status.Width = 130;
            // 
            // colcol_TeacherID
            // 
            this.colcol_TeacherID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_TeacherID.AppearanceHeader.Options.UseFont = true;
            this.colcol_TeacherID.Caption = "ID Giảng viên";
            this.colcol_TeacherID.FieldName = "col_TeacherID";
            this.colcol_TeacherID.Name = "colcol_TeacherID";
            this.colcol_TeacherID.Visible = true;
            this.colcol_TeacherID.VisibleIndex = 7;
            this.colcol_TeacherID.Width = 111;
            // 
            // colcol_RoomID
            // 
            this.colcol_RoomID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcol_RoomID.AppearanceHeader.Options.UseFont = true;
            this.colcol_RoomID.Caption = "ID Phòng học";
            this.colcol_RoomID.FieldName = "col_RoomID";
            this.colcol_RoomID.Name = "colcol_RoomID";
            this.colcol_RoomID.Visible = true;
            this.colcol_RoomID.VisibleIndex = 8;
            // 
            // Root
            // 
            this.Root.AppearanceGroup.BackColor = System.Drawing.Color.NavajoWhite;
            this.Root.AppearanceGroup.Options.UseBackColor = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(706, 789);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grid_Courses;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(686, 769);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frm_01_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 789);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.layoutControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_01_Courses";
            this.Text = "Danh Sách Lớp";
            this.Load += new System.EventHandler(this.frm_01_Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl grid_Students;
        private DevExpress.XtraGrid.Views.Grid.GridView view_Students;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_StudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_FName;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_DayoBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Major;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Phone;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grid_Courses;
        private DevExpress.XtraGrid.Views.Grid.GridView view_Courses;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_CoursesID;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_CoursesName;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Semester;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_DateStr;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_DateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_DayoWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_Status;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_TeacherID;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colcol_RoomID;
    }
}