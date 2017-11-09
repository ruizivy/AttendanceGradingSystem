namespace AttendanceGradingSystem
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.grpDays = new System.Windows.Forms.GroupBox();
            this.chkmon = new System.Windows.Forms.CheckBox();
            this.chksun = new System.Windows.Forms.CheckBox();
            this.chktue = new System.Windows.Forms.CheckBox();
            this.chksat = new System.Windows.Forms.CheckBox();
            this.chkwed = new System.Windows.Forms.CheckBox();
            this.chkfri = new System.Windows.Forms.CheckBox();
            this.chkthu = new System.Windows.Forms.CheckBox();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblsubject = new System.Windows.Forms.Label();
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.grpSchedule.SuspendLayout();
            this.grpDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSchedule
            // 
            this.grpSchedule.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpSchedule.Controls.Add(this.dtpTimeEnd);
            this.grpSchedule.Controls.Add(this.dtpTimeStart);
            this.grpSchedule.Controls.Add(this.txtroom);
            this.grpSchedule.Controls.Add(this.lblRoom);
            this.grpSchedule.Controls.Add(this.grpDays);
            this.grpSchedule.Controls.Add(this.lblTimeEnd);
            this.grpSchedule.Controls.Add(this.lblTimeStart);
            this.grpSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSchedule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSchedule.Location = new System.Drawing.Point(35, 141);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(808, 326);
            this.grpSchedule.TabIndex = 8;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Schedule";
            this.grpSchedule.Enter += new System.EventHandler(this.grpSchedule_Enter);
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeEnd.Location = new System.Drawing.Point(510, 78);
            this.dtpTimeEnd.MaxDate = new System.DateTime(2121, 1, 4, 0, 0, 0, 0);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(156, 26);
            this.dtpTimeEnd.TabIndex = 17;
            this.dtpTimeEnd.Value = new System.DateTime(2017, 1, 21, 1, 0, 0, 0);
            // 
            // dtpTimeStart
            // 
            this.dtpTimeStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeStart.Location = new System.Drawing.Point(510, 28);
            this.dtpTimeStart.MaxDate = new System.DateTime(2121, 1, 4, 0, 0, 0, 0);
            this.dtpTimeStart.Name = "dtpTimeStart";
            this.dtpTimeStart.Size = new System.Drawing.Size(156, 26);
            this.dtpTimeStart.TabIndex = 16;
            this.dtpTimeStart.Value = new System.DateTime(2017, 1, 21, 1, 0, 0, 0);
            // 
            // txtroom
            // 
            this.txtroom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroom.Location = new System.Drawing.Point(187, 49);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(164, 26);
            this.txtroom.TabIndex = 15;
            this.txtroom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(119, 54);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(55, 18);
            this.lblRoom.TabIndex = 14;
            this.lblRoom.Text = "Room:";
            // 
            // grpDays
            // 
            this.grpDays.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpDays.Controls.Add(this.chkmon);
            this.grpDays.Controls.Add(this.chksun);
            this.grpDays.Controls.Add(this.chktue);
            this.grpDays.Controls.Add(this.chksat);
            this.grpDays.Controls.Add(this.chkwed);
            this.grpDays.Controls.Add(this.chkfri);
            this.grpDays.Controls.Add(this.chkthu);
            this.grpDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDays.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDays.Location = new System.Drawing.Point(91, 127);
            this.grpDays.Name = "grpDays";
            this.grpDays.Size = new System.Drawing.Size(625, 174);
            this.grpDays.TabIndex = 11;
            this.grpDays.TabStop = false;
            this.grpDays.Text = "Days";
            // 
            // chkmon
            // 
            this.chkmon.AutoSize = true;
            this.chkmon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmon.Location = new System.Drawing.Point(27, 55);
            this.chkmon.Name = "chkmon";
            this.chkmon.Size = new System.Drawing.Size(79, 22);
            this.chkmon.TabIndex = 4;
            this.chkmon.Text = "Monday";
            this.chkmon.UseVisualStyleBackColor = true;
            // 
            // chksun
            // 
            this.chksun.AutoSize = true;
            this.chksun.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksun.Location = new System.Drawing.Point(493, 90);
            this.chksun.Name = "chksun";
            this.chksun.Size = new System.Drawing.Size(75, 22);
            this.chksun.TabIndex = 10;
            this.chksun.Text = "Sunday";
            this.chksun.UseVisualStyleBackColor = true;
            // 
            // chktue
            // 
            this.chktue.AutoSize = true;
            this.chktue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktue.Location = new System.Drawing.Point(27, 122);
            this.chktue.Name = "chktue";
            this.chktue.Size = new System.Drawing.Size(84, 22);
            this.chktue.TabIndex = 5;
            this.chktue.Text = "Tuesday";
            this.chktue.UseVisualStyleBackColor = true;
            // 
            // chksat
            // 
            this.chksat.AutoSize = true;
            this.chksat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksat.Location = new System.Drawing.Point(346, 122);
            this.chksat.Name = "chksat";
            this.chksat.Size = new System.Drawing.Size(85, 22);
            this.chksat.TabIndex = 9;
            this.chksat.Text = "Saturday";
            this.chksat.UseVisualStyleBackColor = true;
            // 
            // chkwed
            // 
            this.chkwed.AutoSize = true;
            this.chkwed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkwed.Location = new System.Drawing.Point(179, 55);
            this.chkwed.Name = "chkwed";
            this.chkwed.Size = new System.Drawing.Size(104, 22);
            this.chkwed.TabIndex = 6;
            this.chkwed.Text = "Wednesday";
            this.chkwed.UseVisualStyleBackColor = true;
            // 
            // chkfri
            // 
            this.chkfri.AutoSize = true;
            this.chkfri.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkfri.Location = new System.Drawing.Point(346, 55);
            this.chkfri.Name = "chkfri";
            this.chkfri.Size = new System.Drawing.Size(66, 22);
            this.chkfri.TabIndex = 8;
            this.chkfri.Text = "Friday";
            this.chkfri.UseVisualStyleBackColor = true;
            // 
            // chkthu
            // 
            this.chkthu.AutoSize = true;
            this.chkthu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkthu.Location = new System.Drawing.Point(179, 122);
            this.chkthu.Name = "chkthu";
            this.chkthu.Size = new System.Drawing.Size(89, 22);
            this.chkthu.TabIndex = 7;
            this.chkthu.Text = "Thursday";
            this.chkthu.UseVisualStyleBackColor = true;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeEnd.Location = new System.Drawing.Point(409, 80);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(76, 18);
            this.lblTimeEnd.TabIndex = 1;
            this.lblTimeEnd.Text = "TimeEnd:";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.AutoSize = true;
            this.lblTimeStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeStart.Location = new System.Drawing.Point(409, 33);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(87, 18);
            this.lblTimeStart.TabIndex = 0;
            this.lblTimeStart.Text = "TimeStart:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(729, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubject.Location = new System.Drawing.Point(77, 83);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(120, 18);
            this.lblsubject.TabIndex = 10;
            this.lblsubject.Text = "Select Subject:";
            // 
            // cmbsubject
            // 
            this.cmbsubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(196, 79);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(647, 26);
            this.cmbsubject.TabIndex = 11;
            this.cmbsubject.SelectedIndexChanged += new System.EventHandler(this.cmbsubject_SelectedIndexChanged);
            this.cmbsubject.TextChanged += new System.EventHandler(this.cmbsubject_TextChanged);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(302, 7);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(235, 29);
            this.lblSchedule.TabIndex = 12;
            this.lblSchedule.Text = "Add New Schedule";
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(841, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(50, 50);
            this.btnclose.TabIndex = 13;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(891, 542);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.cmbsubject);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpSchedule);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSchedule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSchedule_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSchedule_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSchedule_MouseUp);
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.grpDays.ResumeLayout(false);
            this.grpDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.ComboBox cmbsubject;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txtroom;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.GroupBox grpDays;
        private System.Windows.Forms.CheckBox chkmon;
        private System.Windows.Forms.CheckBox chksun;
        private System.Windows.Forms.CheckBox chktue;
        private System.Windows.Forms.CheckBox chksat;
        private System.Windows.Forms.CheckBox chkwed;
        private System.Windows.Forms.CheckBox chkfri;
        private System.Windows.Forms.CheckBox chkthu;
        private System.Windows.Forms.DateTimePicker dtpTimeStart;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Button btnclose;
    }
}