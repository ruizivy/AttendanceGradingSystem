namespace AttendanceGradingSystem
{
    partial class frmAddCourse
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
            this.btnSave = new System.Windows.Forms.Button();
            this.gridCourse = new DevExpress.XtraGrid.GridControl();
            this.ViewCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCourseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdAbbrv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grduserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(872, 568);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridCourse
            // 
            this.gridCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridCourse.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCourse.Location = new System.Drawing.Point(12, 12);
            this.gridCourse.MainView = this.ViewCourse;
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(995, 532);
            this.gridCourse.TabIndex = 11;
            this.gridCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewCourse});
            // 
            // ViewCourse
            // 
            this.ViewCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCourseID,
            this.grdCourseName,
            this.grdAbbrv,
            this.gridIsEdited,
            this.grduserID});
            this.ViewCourse.GridControl = this.gridCourse;
            this.ViewCourse.Name = "ViewCourse";
            this.ViewCourse.OptionsFind.AlwaysVisible = true;
            this.ViewCourse.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.ViewCourse_RowCellStyle);
            this.ViewCourse.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewCourse_FocusedRowChanged);
            this.ViewCourse.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.ViewCourse_CellValueChanged);
            this.ViewCourse.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewCourse_ValidateRow);
            this.ViewCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewCourse_KeyDown);
            this.ViewCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ViewCourse_KeyPress);
            // 
            // grdCourseID
            // 
            this.grdCourseID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCourseID.AppearanceCell.Options.UseFont = true;
            this.grdCourseID.Caption = "CourseID";
            this.grdCourseID.FieldName = "CourseID";
            this.grdCourseID.Name = "grdCourseID";
            // 
            // grdCourseName
            // 
            this.grdCourseName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCourseName.AppearanceCell.Options.UseFont = true;
            this.grdCourseName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCourseName.AppearanceHeader.Options.UseFont = true;
            this.grdCourseName.Caption = "Course Name";
            this.grdCourseName.FieldName = "CourseName";
            this.grdCourseName.Name = "grdCourseName";
            this.grdCourseName.Visible = true;
            this.grdCourseName.VisibleIndex = 0;
            this.grdCourseName.Width = 281;
            // 
            // grdAbbrv
            // 
            this.grdAbbrv.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdAbbrv.AppearanceCell.Options.UseFont = true;
            this.grdAbbrv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdAbbrv.AppearanceHeader.Options.UseFont = true;
            this.grdAbbrv.Caption = "Abbrv";
            this.grdAbbrv.FieldName = "Abbrv";
            this.grdAbbrv.Name = "grdAbbrv";
            this.grdAbbrv.Visible = true;
            this.grdAbbrv.VisibleIndex = 1;
            this.grdAbbrv.Width = 311;
            // 
            // gridIsEdited
            // 
            this.gridIsEdited.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridIsEdited.AppearanceCell.Options.UseFont = true;
            this.gridIsEdited.Caption = "IsEdited";
            this.gridIsEdited.FieldName = "IsEdited";
            this.gridIsEdited.Name = "gridIsEdited";
            this.gridIsEdited.Width = 104;
            // 
            // grduserID
            // 
            this.grduserID.Caption = "UserID";
            this.grduserID.FieldName = "UserID";
            this.grduserID.Name = "grduserID";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnadd.Location = new System.Drawing.Point(12, 568);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(177, 46);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add New Course";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(223, 568);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.gridCourse);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddCourse";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.frmAddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraGrid.GridControl gridCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewCourse;
        private DevExpress.XtraGrid.Columns.GridColumn grdCourseID;
        private DevExpress.XtraGrid.Columns.GridColumn grdCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn grdAbbrv;
        private DevExpress.XtraGrid.Columns.GridColumn gridIsEdited;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn grduserID;
    }
}