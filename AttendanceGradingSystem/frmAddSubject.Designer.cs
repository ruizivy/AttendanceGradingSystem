namespace AttendanceGradingSystem
{
    partial class frmAddSubject
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
            this.lstSubj = new System.Windows.Forms.ListView();
            this.clmsubjectcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmunits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conMenStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstGradingPeriod = new System.Windows.Forms.ListView();
            this.clmgrading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGradingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSubjects = new System.Windows.Forms.TabControl();
            this.tabAddsubject = new System.Windows.Forms.TabPage();
            this.btnAdded = new System.Windows.Forms.Button();
            this.lblnote = new System.Windows.Forms.Label();
            this.btnUpdated = new System.Windows.Forms.Button();
            this.txtSubjName = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblsubjcode = new System.Windows.Forms.Label();
            this.lblunits = new System.Windows.Forms.Label();
            this.txtsubjCode = new System.Windows.Forms.TextBox();
            this.lblsubjectname = new System.Windows.Forms.Label();
            this.addgradingperiod = new System.Windows.Forms.TabPage();
            this.lblnotes = new System.Windows.Forms.Label();
            this.chkSubjct = new System.Windows.Forms.CheckBox();
            this.chkgrdName = new System.Windows.Forms.CheckBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstsubjects = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpGrading = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtGradingName = new System.Windows.Forms.TextBox();
            this.lblGrading = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.conMenStrip1.SuspendLayout();
            this.tabSubjects.SuspendLayout();
            this.tabAddsubject.SuspendLayout();
            this.addgradingperiod.SuspendLayout();
            this.grpGrading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSubj
            // 
            this.lstSubj.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstSubj.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmsubjectcode,
            this.clmCode,
            this.clmSubject,
            this.clmunits});
            this.lstSubj.ContextMenuStrip = this.conMenStrip1;
            this.lstSubj.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSubj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lstSubj.FullRowSelect = true;
            this.lstSubj.GridLines = true;
            this.lstSubj.Location = new System.Drawing.Point(7, 237);
            this.lstSubj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstSubj.Name = "lstSubj";
            this.lstSubj.Size = new System.Drawing.Size(972, 290);
            this.lstSubj.TabIndex = 6;
            this.lstSubj.UseCompatibleStateImageBehavior = false;
            this.lstSubj.View = System.Windows.Forms.View.Details;
            this.lstSubj.SelectedIndexChanged += new System.EventHandler(this.lstSubj_SelectedIndexChanged);
            this.lstSubj.Click += new System.EventHandler(this.lstSubj_Click);
            // 
            // clmsubjectcode
            // 
            this.clmsubjectcode.Text = "Subject Code";
            this.clmsubjectcode.Width = 0;
            // 
            // clmCode
            // 
            this.clmCode.Text = "Subject Code";
            this.clmCode.Width = 205;
            // 
            // clmSubject
            // 
            this.clmSubject.Text = "Subject Name";
            this.clmSubject.Width = 460;
            // 
            // clmunits
            // 
            this.clmunits.Text = "Units";
            this.clmunits.Width = 300;
            // 
            // conMenStrip1
            // 
            this.conMenStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.conMenStrip1.Name = "conMenStrip1";
            this.conMenStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lstGradingPeriod
            // 
            this.lstGradingPeriod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstGradingPeriod.CheckBoxes = true;
            this.lstGradingPeriod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmgrading,
            this.clmGradingName});
            this.lstGradingPeriod.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGradingPeriod.FullRowSelect = true;
            this.lstGradingPeriod.GridLines = true;
            this.lstGradingPeriod.Location = new System.Drawing.Point(28, 191);
            this.lstGradingPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstGradingPeriod.Name = "lstGradingPeriod";
            this.lstGradingPeriod.Size = new System.Drawing.Size(289, 326);
            this.lstGradingPeriod.TabIndex = 18;
            this.lstGradingPeriod.UseCompatibleStateImageBehavior = false;
            this.lstGradingPeriod.View = System.Windows.Forms.View.Details;
            this.lstGradingPeriod.Click += new System.EventHandler(this.lstGradingPeriod_Click);
            // 
            // clmgrading
            // 
            this.clmgrading.Text = "Grading Name";
            this.clmgrading.Width = 284;
            // 
            // clmGradingName
            // 
            this.clmGradingName.Text = "ID";
            this.clmGradingName.Width = 0;
            // 
            // tabSubjects
            // 
            this.tabSubjects.Controls.Add(this.tabAddsubject);
            this.tabSubjects.Controls.Add(this.addgradingperiod);
            this.tabSubjects.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSubjects.Location = new System.Drawing.Point(13, 20);
            this.tabSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.SelectedIndex = 0;
            this.tabSubjects.Size = new System.Drawing.Size(994, 596);
            this.tabSubjects.TabIndex = 19;
            this.tabSubjects.SelectedIndexChanged += new System.EventHandler(this.tabSubjects_SelectedIndexChanged);
            // 
            // tabAddsubject
            // 
            this.tabAddsubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tabAddsubject.Controls.Add(this.btnAdded);
            this.tabAddsubject.Controls.Add(this.lblnote);
            this.tabAddsubject.Controls.Add(this.btnUpdated);
            this.tabAddsubject.Controls.Add(this.txtSubjName);
            this.tabAddsubject.Controls.Add(this.txtUnits);
            this.tabAddsubject.Controls.Add(this.lblsubjcode);
            this.tabAddsubject.Controls.Add(this.lblunits);
            this.tabAddsubject.Controls.Add(this.txtsubjCode);
            this.tabAddsubject.Controls.Add(this.lblsubjectname);
            this.tabAddsubject.Controls.Add(this.lstSubj);
            this.tabAddsubject.Location = new System.Drawing.Point(4, 28);
            this.tabAddsubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddsubject.Name = "tabAddsubject";
            this.tabAddsubject.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddsubject.Size = new System.Drawing.Size(986, 564);
            this.tabAddsubject.TabIndex = 0;
            this.tabAddsubject.Text = "Subjects";
            // 
            // btnAdded
            // 
            this.btnAdded.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdded.Location = new System.Drawing.Point(756, 48);
            this.btnAdded.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdded.Name = "btnAdded";
            this.btnAdded.Size = new System.Drawing.Size(100, 40);
            this.btnAdded.TabIndex = 4;
            this.btnAdded.Text = "Add";
            this.btnAdded.UseVisualStyleBackColor = true;
            this.btnAdded.Click += new System.EventHandler(this.btnAdded_Click_1);
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote.ForeColor = System.Drawing.Color.Red;
            this.lblnote.Location = new System.Drawing.Point(-3, 530);
            this.lblnote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(343, 32);
            this.lblnote.TabIndex = 26;
            this.lblnote.Text = "Note: Must add grading period in every subject. \r\n         Click to update subjec" +
    "t details.  Right Click to delete.";
            // 
            // btnUpdated
            // 
            this.btnUpdated.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdated.Location = new System.Drawing.Point(757, 122);
            this.btnUpdated.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdated.Name = "btnUpdated";
            this.btnUpdated.Size = new System.Drawing.Size(100, 40);
            this.btnUpdated.TabIndex = 6;
            this.btnUpdated.Text = "Update";
            this.btnUpdated.UseVisualStyleBackColor = true;
            this.btnUpdated.Click += new System.EventHandler(this.btnUpdated_Click_1);
            // 
            // txtSubjName
            // 
            this.txtSubjName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjName.Location = new System.Drawing.Point(278, 87);
            this.txtSubjName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSubjName.Name = "txtSubjName";
            this.txtSubjName.Size = new System.Drawing.Size(366, 26);
            this.txtSubjName.TabIndex = 2;
            this.txtSubjName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubjName_KeyPress);
            // 
            // txtUnits
            // 
            this.txtUnits.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnits.Location = new System.Drawing.Point(278, 142);
            this.txtUnits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUnits.MaxLength = 1;
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(366, 26);
            this.txtUnits.TabIndex = 3;
            this.txtUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnits_KeyPress);
            // 
            // lblsubjcode
            // 
            this.lblsubjcode.AutoSize = true;
            this.lblsubjcode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjcode.Location = new System.Drawing.Point(155, 35);
            this.lblsubjcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubjcode.Name = "lblsubjcode";
            this.lblsubjcode.Size = new System.Drawing.Size(110, 18);
            this.lblsubjcode.TabIndex = 17;
            this.lblsubjcode.Text = "Subject Code:";
            // 
            // lblunits
            // 
            this.lblunits.AutoSize = true;
            this.lblunits.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunits.Location = new System.Drawing.Point(213, 142);
            this.lblunits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblunits.Name = "lblunits";
            this.lblunits.Size = new System.Drawing.Size(52, 18);
            this.lblunits.TabIndex = 21;
            this.lblunits.Text = "Units:";
            // 
            // txtsubjCode
            // 
            this.txtsubjCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubjCode.Location = new System.Drawing.Point(278, 30);
            this.txtsubjCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsubjCode.Name = "txtsubjCode";
            this.txtsubjCode.Size = new System.Drawing.Size(366, 26);
            this.txtsubjCode.TabIndex = 1;
            this.txtsubjCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubjCode_KeyPress);
            // 
            // lblsubjectname
            // 
            this.lblsubjectname.AutoSize = true;
            this.lblsubjectname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjectname.Location = new System.Drawing.Point(154, 92);
            this.lblsubjectname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubjectname.Name = "lblsubjectname";
            this.lblsubjectname.Size = new System.Drawing.Size(116, 18);
            this.lblsubjectname.TabIndex = 19;
            this.lblsubjectname.Text = "Subject Name:";
            // 
            // addgradingperiod
            // 
            this.addgradingperiod.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.addgradingperiod.Controls.Add(this.lblnotes);
            this.addgradingperiod.Controls.Add(this.chkSubjct);
            this.addgradingperiod.Controls.Add(this.chkgrdName);
            this.addgradingperiod.Controls.Add(this.btncancel);
            this.addgradingperiod.Controls.Add(this.btnSave);
            this.addgradingperiod.Controls.Add(this.lstsubjects);
            this.addgradingperiod.Controls.Add(this.grpGrading);
            this.addgradingperiod.Controls.Add(this.lstGradingPeriod);
            this.addgradingperiod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addgradingperiod.Location = new System.Drawing.Point(4, 28);
            this.addgradingperiod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addgradingperiod.Name = "addgradingperiod";
            this.addgradingperiod.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addgradingperiod.Size = new System.Drawing.Size(986, 564);
            this.addgradingperiod.TabIndex = 1;
            this.addgradingperiod.Text = "Grading Period";
            this.addgradingperiod.Click += new System.EventHandler(this.addgradingperiod_Click);
            // 
            // lblnotes
            // 
            this.lblnotes.AutoSize = true;
            this.lblnotes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotes.ForeColor = System.Drawing.Color.Red;
            this.lblnotes.Location = new System.Drawing.Point(8, 540);
            this.lblnotes.Name = "lblnotes";
            this.lblnotes.Size = new System.Drawing.Size(397, 16);
            this.lblnotes.TabIndex = 25;
            this.lblnotes.Text = "Note: To set grading name select subject then select grading period";
            // 
            // chkSubjct
            // 
            this.chkSubjct.AutoSize = true;
            this.chkSubjct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSubjct.Location = new System.Drawing.Point(468, 43);
            this.chkSubjct.Name = "chkSubjct";
            this.chkSubjct.Size = new System.Drawing.Size(83, 22);
            this.chkSubjct.TabIndex = 24;
            this.chkSubjct.Text = "Select All";
            this.chkSubjct.UseVisualStyleBackColor = true;
            this.chkSubjct.CheckedChanged += new System.EventHandler(this.chkSubjct_CheckedChanged);
            // 
            // chkgrdName
            // 
            this.chkgrdName.AutoSize = true;
            this.chkgrdName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgrdName.Location = new System.Drawing.Point(30, 168);
            this.chkgrdName.Name = "chkgrdName";
            this.chkgrdName.Size = new System.Drawing.Size(83, 22);
            this.chkgrdName.TabIndex = 23;
            this.chkgrdName.Text = "Select All";
            this.chkgrdName.UseVisualStyleBackColor = true;
            this.chkgrdName.CheckedChanged += new System.EventHandler(this.chkgrdName_CheckedChanged);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(753, 516);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 40);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(856, 516);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstsubjects
            // 
            this.lstsubjects.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstsubjects.CheckBoxes = true;
            this.lstsubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lstsubjects.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsubjects.FullRowSelect = true;
            this.lstsubjects.GridLines = true;
            this.lstsubjects.Location = new System.Drawing.Point(468, 67);
            this.lstsubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstsubjects.Name = "lstsubjects";
            this.lstsubjects.Size = new System.Drawing.Size(474, 444);
            this.lstsubjects.TabIndex = 20;
            this.lstsubjects.UseCompatibleStateImageBehavior = false;
            this.lstsubjects.View = System.Windows.Forms.View.Details;
            this.lstsubjects.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstsubjects_ItemChecked);
            this.lstsubjects.SelectedIndexChanged += new System.EventHandler(this.lstsubjects_SelectedIndexChanged_1);
            this.lstsubjects.Click += new System.EventHandler(this.lstsubjects_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject Name";
            this.columnHeader3.Width = 351;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Units";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SubjectID";
            this.columnHeader2.Width = 0;
            // 
            // grpGrading
            // 
            this.grpGrading.Controls.Add(this.btnUpdate);
            this.grpGrading.Controls.Add(this.btnadd);
            this.grpGrading.Controls.Add(this.txtGradingName);
            this.grpGrading.Controls.Add(this.lblGrading);
            this.grpGrading.Location = new System.Drawing.Point(28, 4);
            this.grpGrading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGrading.Name = "grpGrading";
            this.grpGrading.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGrading.Size = new System.Drawing.Size(289, 137);
            this.grpGrading.TabIndex = 19;
            this.grpGrading.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(150, 84);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 41);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(37, 84);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(86, 41);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // txtGradingName
            // 
            this.txtGradingName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradingName.Location = new System.Drawing.Point(21, 47);
            this.txtGradingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGradingName.Name = "txtGradingName";
            this.txtGradingName.Size = new System.Drawing.Size(253, 26);
            this.txtGradingName.TabIndex = 1;
            this.txtGradingName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradingName_KeyPress);
            // 
            // lblGrading
            // 
            this.lblGrading.AutoSize = true;
            this.lblGrading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrading.Location = new System.Drawing.Point(49, 27);
            this.lblGrading.Name = "lblGrading";
            this.lblGrading.Size = new System.Drawing.Size(172, 18);
            this.lblGrading.TabIndex = 0;
            this.lblGrading.Text = "Grading Period Name:";
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.tabSubjects);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(148, 70);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddSubject_Load);
            this.conMenStrip1.ResumeLayout(false);
            this.tabSubjects.ResumeLayout(false);
            this.tabAddsubject.ResumeLayout(false);
            this.tabAddsubject.PerformLayout();
            this.addgradingperiod.ResumeLayout(false);
            this.addgradingperiod.PerformLayout();
            this.grpGrading.ResumeLayout(false);
            this.grpGrading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSubj;
        private System.Windows.Forms.ColumnHeader clmsubjectcode;
        private System.Windows.Forms.ColumnHeader clmSubject;
        private System.Windows.Forms.ColumnHeader clmunits;
        private System.Windows.Forms.ListView lstGradingPeriod;
        private System.Windows.Forms.ColumnHeader clmGradingName;
        private System.Windows.Forms.TabControl tabSubjects;
        private System.Windows.Forms.TabPage tabAddsubject;
        private System.Windows.Forms.TabPage addgradingperiod;
        private System.Windows.Forms.GroupBox grpGrading;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtGradingName;
        private System.Windows.Forms.Label lblGrading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstsubjects;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader clmgrading;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnAdded;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Button btnUpdated;
        private System.Windows.Forms.TextBox txtSubjName;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblsubjcode;
        private System.Windows.Forms.Label lblunits;
        private System.Windows.Forms.TextBox txtsubjCode;
        private System.Windows.Forms.Label lblsubjectname;
        private System.Windows.Forms.ColumnHeader clmCode;
        private System.Windows.Forms.ContextMenuStrip conMenStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkSubjct;
        private System.Windows.Forms.CheckBox chkgrdName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblnotes;
    }
}