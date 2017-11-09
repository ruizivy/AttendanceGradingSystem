namespace AttendanceGradingSystem
{
    partial class frmCriteria
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.GridCriteria = new DevExpress.XtraGrid.GridControl();
            this.ViewCriteria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCourseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCriteriaName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdpercentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.conMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCriteria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCriteria)).BeginInit();
            this.conMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCriteria
            // 
            gridLevelNode1.RelationName = "Level1";
            this.GridCriteria.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GridCriteria.Location = new System.Drawing.Point(13, 13);
            this.GridCriteria.MainView = this.ViewCriteria;
            this.GridCriteria.Name = "GridCriteria";
            this.GridCriteria.Size = new System.Drawing.Size(994, 535);
            this.GridCriteria.TabIndex = 0;
            this.GridCriteria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewCriteria});
            this.GridCriteria.Click += new System.EventHandler(this.GridCriteria_Click);
            // 
            // ViewCriteria
            // 
            this.ViewCriteria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCourseID,
            this.grdCriteriaName,
            this.grdpercentage,
            this.grdIsEdited,
            this.grdActive,
            this.grdUserID});
            this.ViewCriteria.GridControl = this.GridCriteria;
            this.ViewCriteria.Name = "ViewCriteria";
            this.ViewCriteria.OptionsFind.AlwaysVisible = true;
            this.ViewCriteria.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.ViewCriteria_RowCellStyle);
            this.ViewCriteria.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ViewCriteria_InitNewRow);
            this.ViewCriteria.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ViewCriteria_FocusedRowChanged);
            this.ViewCriteria.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.ViewCriteria_CellValueChanged);
            this.ViewCriteria.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.ViewCriteria_InvalidRowException);
            this.ViewCriteria.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ViewCriteria_ValidateRow);
            this.ViewCriteria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewCriteria_KeyDown);
            // 
            // grdCourseID
            // 
            this.grdCourseID.Caption = "CriteriaID";
            this.grdCourseID.FieldName = "CriteriaID";
            this.grdCourseID.Name = "grdCourseID";
            // 
            // grdCriteriaName
            // 
            this.grdCriteriaName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCriteriaName.AppearanceCell.Options.UseFont = true;
            this.grdCriteriaName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCriteriaName.AppearanceHeader.Options.UseFont = true;
            this.grdCriteriaName.Caption = "Criteria Name";
            this.grdCriteriaName.FieldName = "CriteriaName";
            this.grdCriteriaName.Name = "grdCriteriaName";
            this.grdCriteriaName.Visible = true;
            this.grdCriteriaName.VisibleIndex = 0;
            // 
            // grdpercentage
            // 
            this.grdpercentage.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdpercentage.AppearanceCell.Options.UseFont = true;
            this.grdpercentage.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdpercentage.AppearanceHeader.Options.UseFont = true;
            this.grdpercentage.Caption = "Percentage";
            this.grdpercentage.FieldName = "Percentage";
            this.grdpercentage.Name = "grdpercentage";
            this.grdpercentage.Visible = true;
            this.grdpercentage.VisibleIndex = 1;
            // 
            // grdIsEdited
            // 
            this.grdIsEdited.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdIsEdited.AppearanceCell.Options.UseFont = true;
            this.grdIsEdited.Caption = "IsEdited";
            this.grdIsEdited.FieldName = "IsEdited";
            this.grdIsEdited.Name = "grdIsEdited";
            // 
            // grdActive
            // 
            this.grdActive.Caption = "IsActive?";
            this.grdActive.FieldName = "Active";
            this.grdActive.Name = "grdActive";
            // 
            // grdUserID
            // 
            this.grdUserID.Caption = "UserID";
            this.grdUserID.FieldName = "UserID";
            this.grdUserID.Name = "grdUserID";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(13, 569);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(223, 46);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add New Criteria";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(872, 569);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 46);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // conMenuStrip1
            // 
            this.conMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCriteriaToolStripMenuItem});
            this.conMenuStrip1.Name = "conMenuStrip1";
            this.conMenuStrip1.Size = new System.Drawing.Size(177, 26);
            // 
            // newCriteriaToolStripMenuItem
            // 
            this.newCriteriaToolStripMenuItem.Name = "newCriteriaToolStripMenuItem";
            this.newCriteriaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newCriteriaToolStripMenuItem.Text = "Create New Criteria";
            this.newCriteriaToolStripMenuItem.Click += new System.EventHandler(this.newCriteriaToolStripMenuItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(278, 569);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Criteria";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.ContextMenuStrip = this.conMenuStrip1;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.GridCriteria);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmCriteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCriteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCriteria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCriteria)).EndInit();
            this.conMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCriteria;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewCriteria;
        private DevExpress.XtraGrid.Columns.GridColumn grdCriteriaName;
        private DevExpress.XtraGrid.Columns.GridColumn grdpercentage;
        private DevExpress.XtraGrid.Columns.GridColumn grdIsEdited;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private DevExpress.XtraGrid.Columns.GridColumn grdCourseID;
        private System.Windows.Forms.ContextMenuStrip conMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newCriteriaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn grdActive;
        private System.Windows.Forms.Button btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn grdUserID;

    }
}