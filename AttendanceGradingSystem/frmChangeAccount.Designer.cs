namespace AttendanceGradingSystem
{
    partial class frmChangeAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrUser = new System.Windows.Forms.Label();
            this.txtCurrUser = new System.Windows.Forms.TextBox();
            this.txtCurrPass = new System.Windows.Forms.TextBox();
            this.lblCurrPass = new System.Windows.Forms.Label();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.lblConPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIcon = new System.Windows.Forms.Button();
            this.txtNewProfile = new System.Windows.Forms.TextBox();
            this.lblNewProfile = new System.Windows.Forms.Label();
            this.tpMessage = new System.Windows.Forms.ToolTip(this.components);
            this.lblmatch = new System.Windows.Forms.Label();
            this.lblNotif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change User Account";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(417, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrUser
            // 
            this.lblCurrUser.AutoSize = true;
            this.lblCurrUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrUser.Location = new System.Drawing.Point(30, 183);
            this.lblCurrUser.Name = "lblCurrUser";
            this.lblCurrUser.Size = new System.Drawing.Size(149, 18);
            this.lblCurrUser.TabIndex = 2;
            this.lblCurrUser.Text = "Current Username:";
            // 
            // txtCurrUser
            // 
            this.txtCurrUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrUser.Location = new System.Drawing.Point(180, 180);
            this.txtCurrUser.Name = "txtCurrUser";
            this.txtCurrUser.Size = new System.Drawing.Size(262, 26);
            this.txtCurrUser.TabIndex = 1;
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrPass.Location = new System.Drawing.Point(180, 219);
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.Size = new System.Drawing.Size(262, 26);
            this.txtCurrPass.TabIndex = 2;
            // 
            // lblCurrPass
            // 
            this.lblCurrPass.AutoSize = true;
            this.lblCurrPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrPass.Location = new System.Drawing.Point(30, 225);
            this.lblCurrPass.Name = "lblCurrPass";
            this.lblCurrPass.Size = new System.Drawing.Size(147, 18);
            this.lblCurrPass.TabIndex = 4;
            this.lblCurrPass.Text = "Current Password:";
            // 
            // txtNewUser
            // 
            this.txtNewUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.Location = new System.Drawing.Point(182, 328);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(262, 26);
            this.txtNewUser.TabIndex = 4;
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(50, 331);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(126, 18);
            this.lblNewUser.TabIndex = 6;
            this.lblNewUser.Text = "New Username:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(182, 367);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(262, 26);
            this.txtNewPass.TabIndex = 5;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(54, 373);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(124, 18);
            this.lblNewPass.TabIndex = 8;
            this.lblNewPass.Text = "New Password:";
            // 
            // txtConPass
            // 
            this.txtConPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPass.Location = new System.Drawing.Point(182, 407);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(262, 26);
            this.txtConPass.TabIndex = 6;
            this.tpMessage.SetToolTip(this.txtConPass, "The password input match.");
            this.txtConPass.UseSystemPasswordChar = true;
            this.txtConPass.TextChanged += new System.EventHandler(this.txtConPass_TextChanged);
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPass.Location = new System.Drawing.Point(32, 410);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(149, 18);
            this.lblConPass.TabIndex = 10;
            this.lblConPass.Text = "Confirm Password:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(207, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(335, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIcon.BackgroundImage")));
            this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(1, 1);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(70, 70);
            this.btnIcon.TabIndex = 14;
            this.btnIcon.UseVisualStyleBackColor = true;
            // 
            // txtNewProfile
            // 
            this.txtNewProfile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewProfile.Location = new System.Drawing.Point(182, 287);
            this.txtNewProfile.Name = "txtNewProfile";
            this.txtNewProfile.Size = new System.Drawing.Size(262, 26);
            this.txtNewProfile.TabIndex = 3;
            // 
            // lblNewProfile
            // 
            this.lblNewProfile.AutoSize = true;
            this.lblNewProfile.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProfile.Location = new System.Drawing.Point(30, 290);
            this.lblNewProfile.Name = "lblNewProfile";
            this.lblNewProfile.Size = new System.Drawing.Size(149, 18);
            this.lblNewProfile.TabIndex = 17;
            this.lblNewProfile.Text = "New Profile Name:";
            // 
            // lblmatch
            // 
            this.lblmatch.AutoSize = true;
            this.lblmatch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatch.ForeColor = System.Drawing.Color.Red;
            this.lblmatch.Location = new System.Drawing.Point(185, 437);
            this.lblmatch.Name = "lblmatch";
            this.lblmatch.Size = new System.Drawing.Size(155, 16);
            this.lblmatch.TabIndex = 18;
            this.lblmatch.Text = "Password doesn\'t match..";
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.Red;
            this.lblNotif.Location = new System.Drawing.Point(4, 550);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(177, 18);
            this.lblNotif.TabIndex = 19;
            this.lblNotif.Text = "Password doesn\'t match..";
            // 
            // frmChangeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(469, 577);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.lblmatch);
            this.Controls.Add(this.txtNewProfile);
            this.Controls.Add(this.lblNewProfile);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.lblConPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.txtCurrPass);
            this.Controls.Add(this.lblCurrPass);
            this.Controls.Add(this.txtCurrUser);
            this.Controls.Add(this.lblCurrUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangeAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmChangeAccount_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmChangeAccount_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmChangeAccount_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmChangeAccount_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrUser;
        private System.Windows.Forms.TextBox txtCurrUser;
        private System.Windows.Forms.TextBox txtCurrPass;
        private System.Windows.Forms.Label lblCurrPass;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.TextBox txtNewProfile;
        private System.Windows.Forms.Label lblNewProfile;
        private System.Windows.Forms.ToolTip tpMessage;
        private System.Windows.Forms.Label lblmatch;
        private System.Windows.Forms.Label lblNotif;
    }
}