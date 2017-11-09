namespace AttendanceGradingSystem
{
    partial class frmTermsCriteria
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
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTerms = new System.Windows.Forms.ListView();
            this.GradingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstcriteria = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpterms = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpterms.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(870, 563);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(157, 81);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(120, 18);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Select Subject:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(278, 80);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(639, 26);
            this.cmbSubject.TabIndex = 1;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set Grading Criteria";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(278, 118);
            this.cmbSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(639, 26);
            this.cmbSchedule.TabIndex = 2;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Schedule:";
            // 
            // lstTerms
            // 
            this.lstTerms.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstTerms.CheckBoxes = true;
            this.lstTerms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GradingName,
            this.GID,
            this.clmGID,
            this.clmUserID});
            this.lstTerms.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTerms.FullRowSelect = true;
            this.lstTerms.GridLines = true;
            this.lstTerms.Location = new System.Drawing.Point(30, 18);
            this.lstTerms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstTerms.Name = "lstTerms";
            this.lstTerms.Size = new System.Drawing.Size(286, 321);
            this.lstTerms.TabIndex = 3;
            this.lstTerms.UseCompatibleStateImageBehavior = false;
            this.lstTerms.View = System.Windows.Forms.View.Details;
            this.lstTerms.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstTerms_ItemChecked);
            this.lstTerms.Click += new System.EventHandler(this.lstTerms_Click);
            // 
            // GradingName
            // 
            this.GradingName.Text = "Grading Name";
            this.GradingName.Width = 280;
            // 
            // GID
            // 
            this.GID.Text = "GNID";
            this.GID.Width = 0;
            // 
            // clmGID
            // 
            this.clmGID.Text = "GID";
            this.clmGID.Width = 0;
            // 
            // clmUserID
            // 
            this.clmUserID.Text = "UserID";
            this.clmUserID.Width = 0;
            // 
            // lstcriteria
            // 
            this.lstcriteria.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstcriteria.CheckBoxes = true;
            this.lstcriteria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstcriteria.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstcriteria.FullRowSelect = true;
            this.lstcriteria.GridLines = true;
            this.lstcriteria.Location = new System.Drawing.Point(362, 18);
            this.lstcriteria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstcriteria.Name = "lstcriteria";
            this.lstcriteria.Size = new System.Drawing.Size(575, 321);
            this.lstcriteria.TabIndex = 4;
            this.lstcriteria.UseCompatibleStateImageBehavior = false;
            this.lstcriteria.View = System.Windows.Forms.View.Details;
            this.lstcriteria.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstcriteria_ItemChecked);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Criteria Name";
            this.columnHeader2.Width = 410;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Percentage";
            this.columnHeader3.Width = 159;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "UserID";
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CriteriaID";
            this.columnHeader5.Width = 0;
            // 
            // grpterms
            // 
            this.grpterms.Controls.Add(this.lstcriteria);
            this.grpterms.Controls.Add(this.lstTerms);
            this.grpterms.Location = new System.Drawing.Point(30, 204);
            this.grpterms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpterms.Name = "grpterms";
            this.grpterms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpterms.Size = new System.Drawing.Size(964, 348);
            this.grpterms.TabIndex = 6;
            this.grpterms.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(7, 602);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(610, 19);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Note: Click grading period names to view set criteria in the particular grading p" +
    "eriod.";
            // 
            // frmTermsCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpterms);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTermsCriteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Grading Period and Criteria";
            this.Load += new System.EventHandler(this.frmTermsCriteria_Load);
            this.grpterms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstTerms;
        private System.Windows.Forms.ColumnHeader GradingName;
        private System.Windows.Forms.ColumnHeader GID;
        private System.Windows.Forms.ListView lstcriteria;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox grpterms;
        private System.Windows.Forms.ColumnHeader clmGID;
        private System.Windows.Forms.ColumnHeader clmUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNote;
    }
}