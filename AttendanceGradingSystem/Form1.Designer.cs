namespace AttendanceGradingSystem
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.btnapply = new System.Windows.Forms.Button();
            this.btntest = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuid = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluid = new System.Windows.Forms.Label();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.lblport = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnapply
            // 
            this.btnapply.BackColor = System.Drawing.SystemColors.Control;
            this.btnapply.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnapply.Location = new System.Drawing.Point(329, 377);
            this.btnapply.Margin = new System.Windows.Forms.Padding(4);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(133, 48);
            this.btnapply.TabIndex = 7;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = false;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // btntest
            // 
            this.btntest.BackColor = System.Drawing.SystemColors.Control;
            this.btntest.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntest.Location = new System.Drawing.Point(134, 377);
            this.btntest.Margin = new System.Windows.Forms.Padding(4);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(173, 48);
            this.btntest.TabIndex = 6;
            this.btntest.Text = "Test Connection";
            this.btntest.UseVisualStyleBackColor = false;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtpassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpassword.Location = new System.Drawing.Point(147, 308);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(288, 26);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtserver_KeyPress);
            // 
            // txtuid
            // 
            this.txtuid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtuid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtuid.Location = new System.Drawing.Point(147, 257);
            this.txtuid.Margin = new System.Windows.Forms.Padding(4);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(288, 26);
            this.txtuid.TabIndex = 4;
            this.txtuid.Text = "root";
            this.txtuid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtserver_KeyPress);
            // 
            // txtdatabase
            // 
            this.txtdatabase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtdatabase.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtdatabase.Location = new System.Drawing.Point(147, 205);
            this.txtdatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(288, 26);
            this.txtdatabase.TabIndex = 3;
            this.txtdatabase.Text = "attendance_db";
            this.txtdatabase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtserver_KeyPress);
            // 
            // txtport
            // 
            this.txtport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtport.Location = new System.Drawing.Point(147, 155);
            this.txtport.Margin = new System.Windows.Forms.Padding(4);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(288, 26);
            this.txtport.TabIndex = 2;
            this.txtport.Text = "3306";
            this.txtport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtserver_KeyPress);
            // 
            // txtserver
            // 
            this.txtserver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtserver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtserver.Location = new System.Drawing.Point(147, 108);
            this.txtserver.Margin = new System.Windows.Forms.Padding(4);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(288, 26);
            this.txtserver.TabIndex = 1;
            this.txtserver.Text = "localhost";
            this.txtserver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtserver_KeyPress);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblpass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpass.Location = new System.Drawing.Point(54, 308);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 18);
            this.lblpass.TabIndex = 52;
            this.lblpass.Text = "Password:";
            // 
            // lbluid
            // 
            this.lbluid.AutoSize = true;
            this.lbluid.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbluid.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluid.Location = new System.Drawing.Point(95, 260);
            this.lbluid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluid.Name = "lbluid";
            this.lbluid.Size = new System.Drawing.Size(42, 18);
            this.lbluid.TabIndex = 51;
            this.lbluid.Text = "UID:";
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbldatabase.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldatabase.Location = new System.Drawing.Point(61, 208);
            this.lbldatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(83, 18);
            this.lbldatabase.TabIndex = 50;
            this.lbldatabase.Text = "Database:";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblport.Location = new System.Drawing.Point(95, 158);
            this.lblport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(45, 18);
            this.lblport.TabIndex = 49;
            this.lblport.Text = "Port:";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblserver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblserver.Location = new System.Drawing.Point(82, 115);
            this.lblserver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(64, 18);
            this.lblserver.TabIndex = 48;
            this.lblserver.Text = "Server:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(271, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(194, 29);
            this.lblWelcome.TabIndex = 60;
            this.lblWelcome.Text = "Set Connection";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(788, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.btntest);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuid);
            this.Controls.Add(this.txtdatabase);
            this.Controls.Add(this.txtport);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluid);
            this.Controls.Add(this.lbldatabase);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.lblserver);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnection_FormClosing);
            this.Load += new System.EventHandler(this.frmConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuid;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluid;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

