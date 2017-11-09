namespace AttendanceGradingSystem
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.lblUserpro = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lnkEditConnection = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox1
            // 
            this.picbox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.picbox1.Image = ((System.Drawing.Image)(resources.GetObject("picbox1.Image")));
            this.picbox1.Location = new System.Drawing.Point(132, 18);
            this.picbox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(230, 241);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 50;
            this.picbox1.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(154, 341);
            this.txtpass.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(243, 26);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TabIndexChanged += new System.EventHandler(this.btnlogin_Click_1);
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(175, 446);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // txtProfile
            // 
            this.txtProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfile.Location = new System.Drawing.Point(155, 384);
            this.txtProfile.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(242, 26);
            this.txtProfile.TabIndex = 3;
            this.txtProfile.TextChanged += new System.EventHandler(this.txtProfile_TextChanged);
            this.txtProfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lblUserpro
            // 
            this.lblUserpro.AutoSize = true;
            this.lblUserpro.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserpro.Location = new System.Drawing.Point(37, 389);
            this.lblUserpro.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblUserpro.Name = "lblUserpro";
            this.lblUserpro.Size = new System.Drawing.Size(111, 18);
            this.lblUserpro.TabIndex = 49;
            this.lblUserpro.Text = "Profile Name:";
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegister.LinkColor = System.Drawing.Color.Red;
            this.lnkRegister.Location = new System.Drawing.Point(3, 560);
            this.lnkRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(95, 16);
            this.lnkRegister.TabIndex = 6;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Create Account\r\n";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked_1);
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(320, 446);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(135, 46);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(60, 346);
            this.lblpass.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(86, 18);
            this.lblpass.TabIndex = 48;
            this.lblpass.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(154, 297);
            this.txtUser.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(243, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(62, 302);
            this.lblUser.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 18);
            this.lblUser.TabIndex = 47;
            this.lblUser.Text = "Username:";
            // 
            // lnkEditConnection
            // 
            this.lnkEditConnection.AutoSize = true;
            this.lnkEditConnection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditConnection.LinkColor = System.Drawing.Color.Red;
            this.lnkEditConnection.Location = new System.Drawing.Point(108, 560);
            this.lnkEditConnection.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkEditConnection.Name = "lnkEditConnection";
            this.lnkEditConnection.Size = new System.Drawing.Size(96, 16);
            this.lnkEditConnection.TabIndex = 7;
            this.lnkEditConnection.TabStop = true;
            this.lnkEditConnection.Text = "Edit Connection";
            this.lnkEditConnection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditConnection_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(469, 577);
            this.Controls.Add(this.lnkEditConnection);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.lblUserpro);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label lblUserpro;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel lnkEditConnection;

    }
}