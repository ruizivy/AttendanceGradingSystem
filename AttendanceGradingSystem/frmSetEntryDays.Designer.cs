namespace AttendanceGradingSystem
{
    partial class frmSetEntryDays
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
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.lblsubject = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.lblsetdays = new System.Windows.Forms.Label();
            this.btnGenerateSchedule = new System.Windows.Forms.Button();
            this.lstDays = new System.Windows.Forms.ListView();
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSchedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblgrading = new System.Windows.Forms.Label();
            this.cmbGrading = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(117, 207);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(258, 26);
            this.dtStart.TabIndex = 4;
            this.dtStart.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(529, 207);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(267, 26);
            this.dtEnd.TabIndex = 4;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjects.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(215, 55);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(675, 26);
            this.cmbSubjects.TabIndex = 1;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubject.Location = new System.Drawing.Point(92, 56);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(120, 18);
            this.lblsubject.TabIndex = 4;
            this.lblsubject.Text = "Select Subject:";
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.Location = new System.Drawing.Point(26, 212);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(90, 18);
            this.lblstart.TabIndex = 5;
            this.lblstart.Text = "Date Start:";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblend.Location = new System.Drawing.Point(444, 213);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(79, 18);
            this.lblend.TabIndex = 6;
            this.lblend.Text = "Date End:";
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(873, 584);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(148, 39);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Schedule:";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(215, 93);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(675, 26);
            this.cmbSchedule.TabIndex = 2;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // lblsetdays
            // 
            this.lblsetdays.AutoSize = true;
            this.lblsetdays.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsetdays.Location = new System.Drawing.Point(447, 2);
            this.lblsetdays.Name = "lblsetdays";
            this.lblsetdays.Size = new System.Drawing.Size(188, 33);
            this.lblsetdays.TabIndex = 10;
            this.lblsetdays.Text = "Set Entry Days";
            // 
            // btnGenerateSchedule
            // 
            this.btnGenerateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGenerateSchedule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSchedule.Location = new System.Drawing.Point(870, 200);
            this.btnGenerateSchedule.Name = "btnGenerateSchedule";
            this.btnGenerateSchedule.Size = new System.Drawing.Size(148, 41);
            this.btnGenerateSchedule.TabIndex = 5;
            this.btnGenerateSchedule.Text = "Generate Schedule";
            this.btnGenerateSchedule.UseVisualStyleBackColor = true;
            this.btnGenerateSchedule.Click += new System.EventHandler(this.btnGenerateSchedule_Click);
            // 
            // lstDays
            // 
            this.lstDays.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstDays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDate,
            this.clmSubject,
            this.clmSchedule,
            this.clmID});
            this.lstDays.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDays.FullRowSelect = true;
            this.lstDays.GridLines = true;
            this.lstDays.Location = new System.Drawing.Point(22, 246);
            this.lstDays.Name = "lstDays";
            this.lstDays.Size = new System.Drawing.Size(1000, 329);
            this.lstDays.TabIndex = 6;
            this.lstDays.UseCompatibleStateImageBehavior = false;
            this.lstDays.View = System.Windows.Forms.View.Details;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 432;
            // 
            // clmSubject
            // 
            this.clmSubject.Text = "Subject";
            this.clmSubject.Width = 286;
            // 
            // clmSchedule
            // 
            this.clmSchedule.Text = "Schedule";
            this.clmSchedule.Width = 271;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 0;
            // 
            // lblgrading
            // 
            this.lblgrading.AutoSize = true;
            this.lblgrading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrading.Location = new System.Drawing.Point(75, 148);
            this.lblgrading.Name = "lblgrading";
            this.lblgrading.Size = new System.Drawing.Size(176, 18);
            this.lblgrading.TabIndex = 13;
            this.lblgrading.Text = "Select Grading Period:";
            // 
            // cmbGrading
            // 
            this.cmbGrading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrading.FormattingEnabled = true;
            this.cmbGrading.Location = new System.Drawing.Point(257, 145);
            this.cmbGrading.Name = "cmbGrading";
            this.cmbGrading.Size = new System.Drawing.Size(245, 26);
            this.cmbGrading.TabIndex = 3;
            this.cmbGrading.SelectedIndexChanged += new System.EventHandler(this.cmbGrading_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(719, 584);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSetEntryDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1045, 632);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbGrading);
            this.Controls.Add(this.lblgrading);
            this.Controls.Add(this.lstDays);
            this.Controls.Add(this.btnGenerateSchedule);
            this.Controls.Add(this.lblsetdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSetEntryDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetEntryDays";
            this.Load += new System.EventHandler(this.frmSetEntryDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Label lblsetdays;
        private System.Windows.Forms.Button btnGenerateSchedule;
        private System.Windows.Forms.ListView lstDays;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmSubject;
        private System.Windows.Forms.ColumnHeader clmSchedule;
        private System.Windows.Forms.Label lblgrading;
        private System.Windows.Forms.ComboBox cmbGrading;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader clmID;
    }
}