namespace AttendanceGradingSystem
{
    partial class frmSchedSubj
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
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gridSched = new DevExpress.XtraGrid.GridControl();
            this.gridSubjSched = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdSection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTimeStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTimeEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.lblview = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubjSched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(867, 577);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(135, 46);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add New ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gridSched
            // 
            this.gridSched.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSched.Location = new System.Drawing.Point(12, 109);
            this.gridSched.MainView = this.gridSubjSched;
            this.gridSched.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridSched.Name = "gridSched";
            this.gridSched.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridSched.Size = new System.Drawing.Size(995, 461);
            this.gridSched.TabIndex = 3;
            this.gridSched.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSubjSched});
            // 
            // gridSubjSched
            // 
            this.gridSubjSched.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdSection,
            this.grdTimeStart,
            this.grdTimeEnd,
            this.grdDay});
            this.gridSubjSched.GridControl = this.gridSched;
            this.gridSubjSched.Name = "gridSubjSched";
            this.gridSubjSched.OptionsFind.AlwaysVisible = true;
            // 
            // grdSection
            // 
            this.grdSection.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdSection.AppearanceCell.Options.UseFont = true;
            this.grdSection.Caption = "Section";
            this.grdSection.FieldName = "Section";
            this.grdSection.Name = "grdSection";
            this.grdSection.OptionsColumn.AllowEdit = false;
            this.grdSection.Visible = true;
            this.grdSection.VisibleIndex = 0;
            this.grdSection.Width = 87;
            // 
            // grdTimeStart
            // 
            this.grdTimeStart.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTimeStart.AppearanceCell.Options.UseFont = true;
            this.grdTimeStart.Caption = "Time Start";
            this.grdTimeStart.FieldName = "ScheduleTimeFrom";
            this.grdTimeStart.Name = "grdTimeStart";
            this.grdTimeStart.OptionsColumn.AllowEdit = false;
            this.grdTimeStart.Visible = true;
            this.grdTimeStart.VisibleIndex = 1;
            this.grdTimeStart.Width = 118;
            // 
            // grdTimeEnd
            // 
            this.grdTimeEnd.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTimeEnd.AppearanceCell.Options.UseFont = true;
            this.grdTimeEnd.Caption = "Time End";
            this.grdTimeEnd.FieldName = "ScheduleTimeTo";
            this.grdTimeEnd.Name = "grdTimeEnd";
            this.grdTimeEnd.OptionsColumn.AllowEdit = false;
            this.grdTimeEnd.Visible = true;
            this.grdTimeEnd.VisibleIndex = 2;
            this.grdTimeEnd.Width = 111;
            // 
            // grdDay
            // 
            this.grdDay.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDay.AppearanceCell.Options.UseFont = true;
            this.grdDay.Caption = "Day";
            this.grdDay.FieldName = "ScheduleDay";
            this.grdDay.Name = "grdDay";
            this.grdDay.OptionsColumn.AllowEdit = false;
            this.grdDay.Visible = true;
            this.grdDay.VisibleIndex = 3;
            this.grdDay.Width = 154;
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
            // lblview
            // 
            this.lblview.AutoSize = true;
            this.lblview.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblview.Location = new System.Drawing.Point(373, 9);
            this.lblview.Name = "lblview";
            this.lblview.Size = new System.Drawing.Size(185, 33);
            this.lblview.TabIndex = 5;
            this.lblview.Text = "View Schedule";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(71, 59);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(183, 18);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Filter by Subject Name:";
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(258, 55);
            this.cmbSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(670, 26);
            this.cmbSubjects.TabIndex = 13;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // frmSchedSubj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblview);
            this.Controls.Add(this.gridSched);
            this.Controls.Add(this.btnAddNew);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmSchedSubj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSchedSubj";
            this.Load += new System.EventHandler(this.frmSchedSubj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSubjSched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private DevExpress.XtraGrid.GridControl gridSched;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSubjSched;
        private DevExpress.XtraGrid.Columns.GridColumn grdSection;
        private DevExpress.XtraGrid.Columns.GridColumn grdTimeStart;
        private DevExpress.XtraGrid.Columns.GridColumn grdTimeEnd;
        private DevExpress.XtraGrid.Columns.GridColumn grdDay;
        private System.Windows.Forms.Label lblview;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}