namespace AttendanceGradingSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnManageSubject = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnManageGrading = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.tlsetdetails = new System.Windows.Forms.ToolTip(this.components);
            this.panelheader.SuspendLayout();
            this.panelfooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetails.BackgroundImage")));
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(158, 267);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(200, 200);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlsetdetails.SetToolTip(this.btnDetails, "Set Details");
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnManageSubject
            // 
            this.btnManageSubject.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnManageSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageSubject.BackgroundImage")));
            this.btnManageSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageSubject.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnManageSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSubject.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSubject.Location = new System.Drawing.Point(434, 270);
            this.btnManageSubject.Name = "btnManageSubject";
            this.btnManageSubject.Size = new System.Drawing.Size(200, 200);
            this.btnManageSubject.TabIndex = 2;
            this.btnManageSubject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlsetdetails.SetToolTip(this.btnManageSubject, "Manage Subjects");
            this.btnManageSubject.UseVisualStyleBackColor = false;
            this.btnManageSubject.Click += new System.EventHandler(this.btnManageSubject_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendance.BackgroundImage")));
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendance.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(740, 268);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(200, 200);
            this.btnAttendance.TabIndex = 3;
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlsetdetails.SetToolTip(this.btnAttendance, "Manage Attendance");
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnManageGrading
            // 
            this.btnManageGrading.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnManageGrading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageGrading.BackgroundImage")));
            this.btnManageGrading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageGrading.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnManageGrading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageGrading.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageGrading.Location = new System.Drawing.Point(1030, 267);
            this.btnManageGrading.Name = "btnManageGrading";
            this.btnManageGrading.Size = new System.Drawing.Size(200, 200);
            this.btnManageGrading.TabIndex = 4;
            this.btnManageGrading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlsetdetails.SetToolTip(this.btnManageGrading, "Manage Grading");
            this.btnManageGrading.UseVisualStyleBackColor = false;
            this.btnManageGrading.Click += new System.EventHandler(this.btnManageGrading_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(1188, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "ghgh";
            // 
            // panelheader
            // 
            this.panelheader.Controls.Add(this.button1);
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Controls.Add(this.lblheader);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1354, 100);
            this.panelheader.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1252, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(1299, 14);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 6;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(290, 18);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(827, 58);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "Attendance With Grading System";
            // 
            // panelfooter
            // 
            this.panelfooter.Controls.Add(this.lblUsername);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 500);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(1354, 100);
            this.panelfooter.TabIndex = 14;
            // 
            // tlsetdetails
            // 
            this.tlsetdetails.IsBalloon = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 600);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.btnManageGrading);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnManageSubject);
            this.Controls.Add(this.btnDetails);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panelfooter.ResumeLayout(false);
            this.panelfooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnManageSubject;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnManageGrading;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.ToolTip tlsetdetails;
        private System.Windows.Forms.Button button1;
    }
}