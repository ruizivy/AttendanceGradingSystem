namespace AttendanceGradingSystem
{
    partial class frmAddStudent
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
            this.RepCourse = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.grdStudents = new DevExpress.XtraGrid.GridControl();
            this.ViewStudents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdStudNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdFName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdLName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCourse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepoCourses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RepCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // RepCourse
            // 
            this.RepCourse.AutoHeight = false;
            this.RepCourse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepCourse.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseID", "CourseID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abbrv", "Abbrv")});
            this.RepCourse.DisplayMember = "Abbrv";
            this.RepCourse.Name = "RepCourse";
            this.RepCourse.NullText = "Course";
            this.RepCourse.ShowFooter = false;
            this.RepCourse.ShowHeader = false;
            this.RepCourse.ValueMember = "CourseID";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(869, 567);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(17, 568);
            this.btnadd.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(161, 46);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add New Student";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.Location = new System.Drawing.Point(13, 11);
            this.grdStudents.MainView = this.ViewStudents;
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RepoCourses});
            this.grdStudents.Size = new System.Drawing.Size(994, 542);
            this.grdStudents.TabIndex = 3;
            this.grdStudents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewStudents});
            this.grdStudents.Click += new System.EventHandler(this.gridStudents_Click);
            // 
            // ViewStudents
            // 
            this.ViewStudents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdStudentID,
            this.grdStudNum,
            this.grdFName,
            this.grdLName,
            this.grdSection,
            this.grdStatus,
            this.grdCourse,
            this.grdIsEdited,
            this.grdUserID});
            this.ViewStudents.GridControl = this.grdStudents;
            this.ViewStudents.Name = "ViewStudents";
            this.ViewStudents.OptionsFind.AlwaysVisible = true;
            this.ViewStudents.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.ViewStudents_RowCellStyle);
            this.ViewStudents.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewStudents_InitNewRow);
            this.ViewStudents.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewStudents_FocusedRowChanged);
            this.ViewStudents.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.ViewStudents_CellValueChanged);
            this.ViewStudents.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewStudents_InvalidRowException);
            this.ViewStudents.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewStudents_ValidateRow);
            this.ViewStudents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewStudents_KeyDown);
            // 
            // grdStudentID
            // 
            this.grdStudentID.Caption = "StudentID";
            this.grdStudentID.FieldName = "StudentID";
            this.grdStudentID.Name = "grdStudentID";
            // 
            // grdStudNum
            // 
            this.grdStudNum.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdStudNum.AppearanceCell.Options.UseFont = true;
            this.grdStudNum.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdStudNum.AppearanceHeader.Options.UseFont = true;
            this.grdStudNum.Caption = "Student No.";
            this.grdStudNum.FieldName = "StudNum";
            this.grdStudNum.Name = "grdStudNum";
            this.grdStudNum.Visible = true;
            this.grdStudNum.VisibleIndex = 0;
            // 
            // grdFName
            // 
            this.grdFName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdFName.AppearanceCell.Options.UseFont = true;
            this.grdFName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdFName.AppearanceHeader.Options.UseFont = true;
            this.grdFName.Caption = "Firstname";
            this.grdFName.FieldName = "FName";
            this.grdFName.Name = "grdFName";
            this.grdFName.Visible = true;
            this.grdFName.VisibleIndex = 1;
            // 
            // grdLName
            // 
            this.grdLName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdLName.AppearanceCell.Options.UseFont = true;
            this.grdLName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdLName.AppearanceHeader.Options.UseFont = true;
            this.grdLName.Caption = "Lastname";
            this.grdLName.FieldName = "LName";
            this.grdLName.Name = "grdLName";
            this.grdLName.Visible = true;
            this.grdLName.VisibleIndex = 2;
            // 
            // grdSection
            // 
            this.grdSection.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSection.AppearanceCell.Options.UseFont = true;
            this.grdSection.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSection.AppearanceHeader.Options.UseFont = true;
            this.grdSection.Caption = "Section";
            this.grdSection.FieldName = "Section";
            this.grdSection.Name = "grdSection";
            this.grdSection.Visible = true;
            this.grdSection.VisibleIndex = 3;
            // 
            // grdStatus
            // 
            this.grdStatus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdStatus.AppearanceCell.Options.UseFont = true;
            this.grdStatus.Caption = "Status";
            this.grdStatus.FieldName = "Status";
            this.grdStatus.Name = "grdStatus";
            // 
            // grdCourse
            // 
            this.grdCourse.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCourse.AppearanceCell.Options.UseFont = true;
            this.grdCourse.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCourse.AppearanceHeader.Options.UseFont = true;
            this.grdCourse.Caption = "Course";
            this.grdCourse.ColumnEdit = this.RepoCourses;
            this.grdCourse.FieldName = "CourseID";
            this.grdCourse.Name = "grdCourse";
            this.grdCourse.Visible = true;
            this.grdCourse.VisibleIndex = 4;
            // 
            // RepoCourses
            // 
            this.RepoCourses.AutoHeight = false;
            this.RepoCourses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepoCourses.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CourseID", "CourseID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abbrv", "Abbrv")});
            this.RepoCourses.DisplayMember = "Abbrv";
            this.RepoCourses.Name = "RepoCourses";
            this.RepoCourses.NullText = "";
            this.RepoCourses.ShowFooter = false;
            this.RepoCourses.ShowHeader = false;
            this.RepoCourses.ValueMember = "CourseID";
            this.RepoCourses.EditValueChanged += new System.EventHandler(this.RepoCourses_EditValueChanged);
            // 
            // grdIsEdited
            // 
            this.grdIsEdited.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdIsEdited.AppearanceCell.Options.UseFont = true;
            this.grdIsEdited.Caption = "IsEdited";
            this.grdIsEdited.FieldName = "IsEdited";
            this.grdIsEdited.Name = "grdIsEdited";
            this.grdIsEdited.OptionsColumn.AllowEdit = false;
            // 
            // grdUserID
            // 
            this.grdUserID.Caption = "UserID";
            this.grdUserID.FieldName = "UserID";
            this.grdUserID.Name = "grdUserID";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(200, 569);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdStudents);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnadd;
        private DevExpress.XtraGrid.GridControl grdStudents;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewStudents;
        private DevExpress.XtraGrid.Columns.GridColumn grdStudNum;
        private DevExpress.XtraGrid.Columns.GridColumn grdFName;
        private DevExpress.XtraGrid.Columns.GridColumn grdLName;
        private DevExpress.XtraGrid.Columns.GridColumn grdSection;
        private DevExpress.XtraGrid.Columns.GridColumn grdStatus;
        private DevExpress.XtraGrid.Columns.GridColumn grdCourse;
        private DevExpress.XtraGrid.Columns.GridColumn grdIsEdited;
        private DevExpress.XtraGrid.Columns.GridColumn grdStudentID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepCourse;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepoCourses;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn grdUserID;


    }
}