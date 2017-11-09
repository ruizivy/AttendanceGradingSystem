namespace AttendanceGradingSystem
{
    partial class frmSetDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetDetails));
            this.panelside = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnaddStudent = new System.Windows.Forms.Button();
            this.btnAddCriteria = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tlstudents = new System.Windows.Forms.ToolTip(this.components);
            this.panelside.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelside.Controls.Add(this.btnAddCourse);
            this.panelside.Controls.Add(this.btnaddStudent);
            this.panelside.Controls.Add(this.btnAddCriteria);
            this.panelside.Controls.Add(this.btnAddSubject);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 0);
            this.panelside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(224, 733);
            this.panelside.TabIndex = 11;
            this.panelside.Paint += new System.Windows.Forms.PaintEventHandler(this.panelside_Paint);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.BackgroundImage")));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCourse.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(37, 386);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(150, 150);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlstudents.SetToolTip(this.btnAddCourse, "Add Course");
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnaddStudent
            // 
            this.btnaddStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddStudent.BackgroundImage")));
            this.btnaddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddStudent.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnaddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddStudent.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddStudent.Location = new System.Drawing.Point(27, 557);
            this.btnaddStudent.Name = "btnaddStudent";
            this.btnaddStudent.Size = new System.Drawing.Size(150, 150);
            this.btnaddStudent.TabIndex = 4;
            this.btnaddStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlstudents.SetToolTip(this.btnaddStudent, "Add Students");
            this.btnaddStudent.UseVisualStyleBackColor = true;
            this.btnaddStudent.Click += new System.EventHandler(this.btnaddStudent_Click);
            // 
            // btnAddCriteria
            // 
            this.btnAddCriteria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCriteria.BackgroundImage")));
            this.btnAddCriteria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCriteria.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCriteria.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCriteria.Location = new System.Drawing.Point(27, 217);
            this.btnAddCriteria.Name = "btnAddCriteria";
            this.btnAddCriteria.Size = new System.Drawing.Size(150, 150);
            this.btnAddCriteria.TabIndex = 2;
            this.btnAddCriteria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlstudents.SetToolTip(this.btnAddCriteria, "Add Criteria");
            this.btnAddCriteria.UseVisualStyleBackColor = true;
            this.btnAddCriteria.Click += new System.EventHandler(this.btnAddCriteria_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSubject.BackgroundImage")));
            this.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSubject.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAddSubject.Location = new System.Drawing.Point(27, 41);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(150, 150);
            this.btnAddSubject.TabIndex = 1;
            this.btnAddSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlstudents.SetToolTip(this.btnAddSubject, "Add Subject");
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(224, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1130, 93);
            this.pnlHeader.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1067, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 58);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage Information";
            // 
            // frmSetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panelside);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSetDetails_Load);
            this.panelside.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnaddStudent;
        private System.Windows.Forms.Button btnAddCriteria;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ToolTip tlstudents;
    }
}