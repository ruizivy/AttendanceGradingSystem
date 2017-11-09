namespace AttendanceGradingSystem
{
    partial class frmManageSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubjects));
            this.label1 = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.btnCriteriaSubject = new System.Windows.Forms.Button();
            this.btnStudentSubject = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tlCreateClass = new System.Windows.Forms.ToolTip(this.components);
            this.panelSide.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Subject Details";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelSide.Controls.Add(this.btnAddSchedule);
            this.panelSide.Controls.Add(this.btnSetDate);
            this.panelSide.Controls.Add(this.btnCriteriaSubject);
            this.panelSide.Controls.Add(this.btnStudentSubject);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 84);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(199, 649);
            this.panelSide.TabIndex = 1;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSchedule.BackgroundImage")));
            this.btnAddSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSchedule.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Location = new System.Drawing.Point(24, 3);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(150, 150);
            this.btnAddSchedule.TabIndex = 1;
            this.btnAddSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlCreateClass.SetToolTip(this.btnAddSchedule, "Set Schedule");
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnSetDate
            // 
            this.btnSetDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetDate.BackgroundImage")));
            this.btnSetDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetDate.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSetDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDate.Location = new System.Drawing.Point(24, 339);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(150, 150);
            this.btnSetDate.TabIndex = 3;
            this.btnSetDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlCreateClass.SetToolTip(this.btnSetDate, "Set Entry of Days");
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // btnCriteriaSubject
            // 
            this.btnCriteriaSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriteriaSubject.BackgroundImage")));
            this.btnCriteriaSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriteriaSubject.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCriteriaSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriteriaSubject.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriteriaSubject.Location = new System.Drawing.Point(24, 174);
            this.btnCriteriaSubject.Name = "btnCriteriaSubject";
            this.btnCriteriaSubject.Size = new System.Drawing.Size(150, 150);
            this.btnCriteriaSubject.TabIndex = 2;
            this.btnCriteriaSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlCreateClass.SetToolTip(this.btnCriteriaSubject, "Set Criteria for Grading");
            this.btnCriteriaSubject.UseVisualStyleBackColor = true;
            this.btnCriteriaSubject.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStudentSubject
            // 
            this.btnStudentSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudentSubject.BackgroundImage")));
            this.btnStudentSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentSubject.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnStudentSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentSubject.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSubject.Location = new System.Drawing.Point(24, 504);
            this.btnStudentSubject.Name = "btnStudentSubject";
            this.btnStudentSubject.Size = new System.Drawing.Size(150, 150);
            this.btnStudentSubject.TabIndex = 4;
            this.btnStudentSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlCreateClass.SetToolTip(this.btnStudentSubject, "Create Class");
            this.btnStudentSubject.UseVisualStyleBackColor = true;
            this.btnStudentSubject.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1293, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1354, 84);
            this.panelHeader.TabIndex = 0;
            // 
            // frmManageSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageSubjects";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManage_Load);
            this.panelSide.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.Button btnCriteriaSubject;
        private System.Windows.Forms.Button btnStudentSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ToolTip tlCreateClass;

    }
}