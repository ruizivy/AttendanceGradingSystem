namespace AttendanceGradingSystem
{
    partial class frmAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.pnlheader = new System.Windows.Forms.Panel();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.cmbfilter = new System.Windows.Forms.ComboBox();
            this.lblfilter = new System.Windows.Forms.Label();
            this.cmbGrading = new System.Windows.Forms.ComboBox();
            this.lblGrading = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblTotalAbsent = new System.Windows.Forms.Label();
            this.lblTotalpresent = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpRemarks = new System.Windows.Forms.GroupBox();
            this.rdbNoClass = new System.Windows.Forms.RadioButton();
            this.rdbExcuse = new System.Windows.Forms.RadioButton();
            this.rdbLate = new System.Windows.Forms.RadioButton();
            this.rdbAbsent = new System.Windows.Forms.RadioButton();
            this.rdbPresent = new System.Windows.Forms.RadioButton();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lstStudent = new System.Windows.Forms.ListView();
            this.clmStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmsection1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmClD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmremarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmclassid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmentrydays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAttendanceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTerm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbDates = new System.Windows.Forms.ComboBox();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tpNow = new System.Windows.Forms.Timer(this.components);
            this.pnlheader.SuspendLayout();
            this.grpView.SuspendLayout();
            this.grpRemarks.SuspendLayout();
            this.panelfooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlheader.Controls.Add(this.btnClose1);
            this.pnlheader.Controls.Add(this.btnClose);
            this.pnlheader.Controls.Add(this.label1);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1354, 75);
            this.pnlheader.TabIndex = 1;
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose1.BackgroundImage")));
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose1.Location = new System.Drawing.Point(1291, 3);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(60, 60);
            this.btnClose1.TabIndex = 6;
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1936, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 117);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Attendance";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(172, 133);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(132, 18);
            this.lblSchedule.TabIndex = 19;
            this.lblSchedule.Text = "Select Schedule:";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(308, 125);
            this.cmbSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(846, 26);
            this.cmbSchedule.TabIndex = 2;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(169, 93);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(120, 18);
            this.lblSubject.TabIndex = 17;
            this.lblSubject.Text = "Select Subject:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(290, 87);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(864, 26);
            this.cmbSubject.TabIndex = 1;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1005, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.cmbfilter);
            this.grpView.Controls.Add(this.lblfilter);
            this.grpView.Controls.Add(this.cmbGrading);
            this.grpView.Controls.Add(this.lblGrading);
            this.grpView.Controls.Add(this.btnUpdate);
            this.grpView.Controls.Add(this.chkSelectAll);
            this.grpView.Controls.Add(this.btnCancel);
            this.grpView.Controls.Add(this.lblID);
            this.grpView.Controls.Add(this.lblLName);
            this.grpView.Controls.Add(this.lblFname);
            this.grpView.Controls.Add(this.btnSave);
            this.grpView.Controls.Add(this.lblTotalAbsent);
            this.grpView.Controls.Add(this.lblTotalpresent);
            this.grpView.Controls.Add(this.btnSearch);
            this.grpView.Controls.Add(this.txtSearch);
            this.grpView.Controls.Add(this.grpRemarks);
            this.grpView.Controls.Add(this.lblDate2);
            this.grpView.Controls.Add(this.lstStudent);
            this.grpView.Controls.Add(this.cmbDates);
            this.grpView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpView.Location = new System.Drawing.Point(91, 179);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(1174, 538);
            this.grpView.TabIndex = 24;
            this.grpView.TabStop = false;
            // 
            // cmbfilter
            // 
            this.cmbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfilter.FormattingEnabled = true;
            this.cmbfilter.Items.AddRange(new object[] {
            "Lastname",
            "Firstname",
            "Section",
            "Date",
            "Time",
            "Remarks"});
            this.cmbfilter.Location = new System.Drawing.Point(950, 35);
            this.cmbfilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbfilter.Name = "cmbfilter";
            this.cmbfilter.Size = new System.Drawing.Size(166, 24);
            this.cmbfilter.TabIndex = 46;
            // 
            // lblfilter
            // 
            this.lblfilter.AutoSize = true;
            this.lblfilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilter.Location = new System.Drawing.Point(884, 38);
            this.lblfilter.Name = "lblfilter";
            this.lblfilter.Size = new System.Drawing.Size(60, 16);
            this.lblfilter.TabIndex = 45;
            this.lblfilter.Text = "Filter By";
            // 
            // cmbGrading
            // 
            this.cmbGrading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrading.FormattingEnabled = true;
            this.cmbGrading.Location = new System.Drawing.Point(34, 33);
            this.cmbGrading.Name = "cmbGrading";
            this.cmbGrading.Size = new System.Drawing.Size(244, 26);
            this.cmbGrading.TabIndex = 3;
            this.cmbGrading.SelectedIndexChanged += new System.EventHandler(this.cmbGrading_SelectedIndexChanged);
            // 
            // lblGrading
            // 
            this.lblGrading.AutoSize = true;
            this.lblGrading.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrading.Location = new System.Drawing.Point(58, 14);
            this.lblGrading.Name = "lblGrading";
            this.lblGrading.Size = new System.Drawing.Size(171, 18);
            this.lblGrading.TabIndex = 44;
            this.lblGrading.Text = "Select Grading Period";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(884, 494);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(38, 71);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(83, 22);
            this.chkSelectAll.TabIndex = 8;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(763, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 38);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1072, 515);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(44, 18);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "label3";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(424, 41);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(0, 18);
            this.lblLName.TabIndex = 38;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(424, 30);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(0, 18);
            this.lblFname.TabIndex = 37;
            // 
            // lblTotalAbsent
            // 
            this.lblTotalAbsent.AutoSize = true;
            this.lblTotalAbsent.Location = new System.Drawing.Point(41, 478);
            this.lblTotalAbsent.Name = "lblTotalAbsent";
            this.lblTotalAbsent.Size = new System.Drawing.Size(44, 18);
            this.lblTotalAbsent.TabIndex = 34;
            this.lblTotalAbsent.Text = "label3";
            // 
            // lblTotalpresent
            // 
            this.lblTotalpresent.AutoSize = true;
            this.lblTotalpresent.Location = new System.Drawing.Point(476, 480);
            this.lblTotalpresent.Name = "lblTotalpresent";
            this.lblTotalpresent.Size = new System.Drawing.Size(44, 18);
            this.lblTotalpresent.TabIndex = 33;
            this.lblTotalpresent.Text = "label2";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(907, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.Location = new System.Drawing.Point(950, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 26);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Searchbox";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // grpRemarks
            // 
            this.grpRemarks.Controls.Add(this.rdbNoClass);
            this.grpRemarks.Controls.Add(this.rdbExcuse);
            this.grpRemarks.Controls.Add(this.rdbLate);
            this.grpRemarks.Controls.Add(this.rdbAbsent);
            this.grpRemarks.Controls.Add(this.rdbPresent);
            this.grpRemarks.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRemarks.Location = new System.Drawing.Point(34, 510);
            this.grpRemarks.Name = "grpRemarks";
            this.grpRemarks.Size = new System.Drawing.Size(584, 37);
            this.grpRemarks.TabIndex = 28;
            this.grpRemarks.TabStop = false;
            // 
            // rdbNoClass
            // 
            this.rdbNoClass.AutoSize = true;
            this.rdbNoClass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoClass.Location = new System.Drawing.Point(462, 0);
            this.rdbNoClass.Name = "rdbNoClass";
            this.rdbNoClass.Size = new System.Drawing.Size(97, 22);
            this.rdbNoClass.TabIndex = 17;
            this.rdbNoClass.TabStop = true;
            this.rdbNoClass.Text = "No Classes";
            this.rdbNoClass.UseVisualStyleBackColor = true;
            // 
            // rdbExcuse
            // 
            this.rdbExcuse.AutoSize = true;
            this.rdbExcuse.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcuse.Location = new System.Drawing.Point(346, 0);
            this.rdbExcuse.Name = "rdbExcuse";
            this.rdbExcuse.Size = new System.Drawing.Size(72, 22);
            this.rdbExcuse.TabIndex = 16;
            this.rdbExcuse.TabStop = true;
            this.rdbExcuse.Text = "Excuse";
            this.rdbExcuse.UseVisualStyleBackColor = true;
            // 
            // rdbLate
            // 
            this.rdbLate.AutoSize = true;
            this.rdbLate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLate.Location = new System.Drawing.Point(242, 0);
            this.rdbLate.Name = "rdbLate";
            this.rdbLate.Size = new System.Drawing.Size(54, 22);
            this.rdbLate.TabIndex = 15;
            this.rdbLate.TabStop = true;
            this.rdbLate.Text = "Late";
            this.rdbLate.UseVisualStyleBackColor = true;
            // 
            // rdbAbsent
            // 
            this.rdbAbsent.AutoSize = true;
            this.rdbAbsent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAbsent.Location = new System.Drawing.Point(127, 0);
            this.rdbAbsent.Name = "rdbAbsent";
            this.rdbAbsent.Size = new System.Drawing.Size(71, 22);
            this.rdbAbsent.TabIndex = 14;
            this.rdbAbsent.TabStop = true;
            this.rdbAbsent.Text = "Absent";
            this.rdbAbsent.UseVisualStyleBackColor = true;
            // 
            // rdbPresent
            // 
            this.rdbPresent.AutoSize = true;
            this.rdbPresent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPresent.Location = new System.Drawing.Point(20, 0);
            this.rdbPresent.Name = "rdbPresent";
            this.rdbPresent.Size = new System.Drawing.Size(75, 22);
            this.rdbPresent.TabIndex = 13;
            this.rdbPresent.TabStop = true;
            this.rdbPresent.Text = "Present";
            this.rdbPresent.UseVisualStyleBackColor = true;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.Location = new System.Drawing.Point(400, 14);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(99, 18);
            this.lblDate2.TabIndex = 27;
            this.lblDate2.Text = "Select Date:\r\n";
            // 
            // lstStudent
            // 
            this.lstStudent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstStudent.CheckBoxes = true;
            this.lstStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStudent,
            this.clmsection1,
            this.clmClD,
            this.clmDate,
            this.clmTime,
            this.clmremarks,
            this.clmclassid,
            this.clmentrydays,
            this.clmAttendanceID,
            this.clmTerm});
            this.lstStudent.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudent.FullRowSelect = true;
            this.lstStudent.GridLines = true;
            this.lstStudent.Location = new System.Drawing.Point(35, 93);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(1085, 382);
            this.lstStudent.TabIndex = 9;
            this.lstStudent.UseCompatibleStateImageBehavior = false;
            this.lstStudent.View = System.Windows.Forms.View.Details;
            this.lstStudent.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstStudent_ItemChecked);
            // 
            // clmStudent
            // 
            this.clmStudent.Text = "Student Name";
            this.clmStudent.Width = 302;
            // 
            // clmsection1
            // 
            this.clmsection1.Text = "Section";
            this.clmsection1.Width = 147;
            // 
            // clmClD
            // 
            this.clmClD.Text = "ClassID";
            this.clmClD.Width = 0;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 250;
            // 
            // clmTime
            // 
            this.clmTime.Text = "Time";
            this.clmTime.Width = 179;
            // 
            // clmremarks
            // 
            this.clmremarks.Text = "Remarks";
            this.clmremarks.Width = 201;
            // 
            // clmclassid
            // 
            this.clmclassid.Text = "ClassID";
            this.clmclassid.Width = 0;
            // 
            // clmentrydays
            // 
            this.clmentrydays.Text = "EntryDaysID";
            this.clmentrydays.Width = 0;
            // 
            // clmAttendanceID
            // 
            this.clmAttendanceID.Text = "AttendanceID";
            this.clmAttendanceID.Width = 0;
            // 
            // clmTerm
            // 
            this.clmTerm.Text = "Term";
            this.clmTerm.Width = 0;
            // 
            // cmbDates
            // 
            this.cmbDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDates.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDates.FormattingEnabled = true;
            this.cmbDates.Location = new System.Drawing.Point(339, 33);
            this.cmbDates.Name = "cmbDates";
            this.cmbDates.Size = new System.Drawing.Size(267, 26);
            this.cmbDates.TabIndex = 4;
            this.cmbDates.SelectedIndexChanged += new System.EventHandler(this.cmbDates_SelectedIndexChanged_1);
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.Location = new System.Drawing.Point(1062, 12);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(44, 18);
            this.lblDateNow.TabIndex = 25;
            this.lblDateNow.Text = "label2";
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelfooter.Controls.Add(this.lblDateNow);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 702);
            this.panelfooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(1354, 39);
            this.panelfooter.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(-3, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1402, 22);
            this.label2.TabIndex = 29;
            // 
            // tpNow
            // 
            this.tpNow.Tick += new System.EventHandler(this.tpNow_Tick);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1354, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.grpView);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.pnlheader);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAttendance";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            this.grpRemarks.ResumeLayout(false);
            this.grpRemarks.PerformLayout();
            this.panelfooter.ResumeLayout(false);
            this.panelfooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.ListView lstStudent;
        private System.Windows.Forms.ColumnHeader clmStudent;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmTime;
        private System.Windows.Forms.ColumnHeader clmremarks;
        private System.Windows.Forms.ColumnHeader clmclassid;
        private System.Windows.Forms.ColumnHeader clmentrydays;
        private System.Windows.Forms.ComboBox cmbDates;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.GroupBox grpRemarks;
        private System.Windows.Forms.RadioButton rdbLate;
        private System.Windows.Forms.RadioButton rdbAbsent;
        private System.Windows.Forms.RadioButton rdbPresent;
        private System.Windows.Forms.RadioButton rdbNoClass;
        private System.Windows.Forms.RadioButton rdbExcuse;
        private System.Windows.Forms.ColumnHeader clmAttendanceID;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTotalAbsent;
        private System.Windows.Forms.Label lblTotalpresent;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader clmClD;
        private System.Windows.Forms.ColumnHeader clmsection1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Timer tpNow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbGrading;
        private System.Windows.Forms.Label lblGrading;
        private System.Windows.Forms.ColumnHeader clmTerm;
        private System.Windows.Forms.ComboBox cmbfilter;
        private System.Windows.Forms.Label lblfilter;
    }
}