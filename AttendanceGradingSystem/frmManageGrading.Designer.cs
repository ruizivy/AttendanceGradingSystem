namespace AttendanceGradingSystem
{
    partial class frmManageGrading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageGrading));
            this.lblSchedule = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListView();
            this.clmStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblline = new System.Windows.Forms.Label();
            this.tbGrades = new System.Windows.Forms.TabControl();
            this.tbSet = new System.Windows.Forms.TabPage();
            this.grpSet = new System.Windows.Forms.GroupBox();
            this.lblpercent = new System.Windows.Forms.Label();
            this.grpScores = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblOver = new System.Windows.Forms.Label();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstStudentGrades = new System.Windows.Forms.ListView();
            this.clmStudentGradesID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmclID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGradingdetailsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmgradingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCriteriaName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRawScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOverScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmpercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStudName1 = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstcriterias = new System.Windows.Forms.ListView();
            this.clmCriteria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmpercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbterms = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.lstGradeDetails = new System.Windows.Forms.ListView();
            this.clmGDID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTermID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCritname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmscores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTermID = new System.Windows.Forms.Label();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.lblSet = new System.Windows.Forms.Label();
            this.txtSetOver = new System.Windows.Forms.TextBox();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.lblCrit = new System.Windows.Forms.Label();
            this.lblterms = new System.Windows.Forms.Label();
            this.tbViewGrades = new System.Windows.Forms.TabPage();
            this.lblper = new System.Windows.Forms.Label();
            this.btnprint = new System.Windows.Forms.Button();
            this.lblgperiod = new System.Windows.Forms.Label();
            this.cmbgradeperiod = new System.Windows.Forms.ComboBox();
            this.lstViewing = new System.Windows.Forms.ListView();
            this.lblSchedule.SuspendLayout();
            this.tbGrades.SuspendLayout();
            this.tbSet.SuspendLayout();
            this.grpSet.SuspendLayout();
            this.grpScores.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbViewGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSchedule
            // 
            this.lblSchedule.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblSchedule.Controls.Add(this.btnClose);
            this.lblSchedule.Controls.Add(this.lblheader);
            this.lblSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchedule.Location = new System.Drawing.Point(0, 0);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(1354, 72);
            this.lblSchedule.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1300, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 19;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(478, 11);
            this.lblheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(324, 45);
            this.lblheader.TabIndex = 19;
            this.lblheader.Text = "Manage Grading";
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 702);
            this.panelfooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(1354, 31);
            this.panelfooter.TabIndex = 19;
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(16, 176);
            this.cmbSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(288, 26);
            this.cmbSchedule.TabIndex = 21;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Schedule:";
            // 
            // lstStudents
            // 
            this.lstStudents.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStudentName,
            this.clmStudentID,
            this.clmStudNum,
            this.clmClassID});
            this.lstStudents.FullRowSelect = true;
            this.lstStudents.GridLines = true;
            this.lstStudents.Location = new System.Drawing.Point(16, 229);
            this.lstStudents.Margin = new System.Windows.Forms.Padding(4);
            this.lstStudents.MultiSelect = false;
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(288, 489);
            this.lstStudents.TabIndex = 22;
            this.lstStudents.UseCompatibleStateImageBehavior = false;
            this.lstStudents.View = System.Windows.Forms.View.Details;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // clmStudentName
            // 
            this.clmStudentName.Text = "Student Name";
            this.clmStudentName.Width = 282;
            // 
            // clmStudentID
            // 
            this.clmStudentID.Text = "StudentID";
            this.clmStudentID.Width = 0;
            // 
            // clmStudNum
            // 
            this.clmStudNum.Text = "StudNum";
            this.clmStudNum.Width = 0;
            // 
            // clmClassID
            // 
            this.clmClassID.Text = "ClassID";
            this.clmClassID.Width = 0;
            // 
            // cmbsubject
            // 
            this.cmbsubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(13, 102);
            this.cmbsubject.Margin = new System.Windows.Forms.Padding(4);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(288, 26);
            this.cmbsubject.TabIndex = 20;
            this.cmbsubject.SelectedIndexChanged += new System.EventHandler(this.cmbsubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(13, 80);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(120, 18);
            this.lblSubject.TabIndex = 23;
            this.lblSubject.Text = "Select Subject:";
            // 
            // lblline
            // 
            this.lblline.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblline.Location = new System.Drawing.Point(319, 57);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(16, 714);
            this.lblline.TabIndex = 33;
            // 
            // tbGrades
            // 
            this.tbGrades.Controls.Add(this.tbSet);
            this.tbGrades.Controls.Add(this.tbViewGrades);
            this.tbGrades.Location = new System.Drawing.Point(343, 79);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.SelectedIndex = 0;
            this.tbGrades.Size = new System.Drawing.Size(1017, 650);
            this.tbGrades.TabIndex = 34;
            // 
            // tbSet
            // 
            this.tbSet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSet.Controls.Add(this.grpSet);
            this.tbSet.Location = new System.Drawing.Point(4, 27);
            this.tbSet.Name = "tbSet";
            this.tbSet.Padding = new System.Windows.Forms.Padding(3);
            this.tbSet.Size = new System.Drawing.Size(1009, 619);
            this.tbSet.TabIndex = 0;
            this.tbSet.Text = "Grading Tab";
            // 
            // grpSet
            // 
            this.grpSet.Controls.Add(this.lblpercent);
            this.grpSet.Controls.Add(this.grpScores);
            this.grpSet.Controls.Add(this.lstStudentGrades);
            this.grpSet.Controls.Add(this.lblStudName1);
            this.grpSet.Controls.Add(this.lblStudName);
            this.grpSet.Controls.Add(this.label2);
            this.grpSet.Controls.Add(this.lstcriterias);
            this.grpSet.Controls.Add(this.cmbterms);
            this.grpSet.Controls.Add(this.groupBox1);
            this.grpSet.Controls.Add(this.lblterms);
            this.grpSet.Location = new System.Drawing.Point(3, 3);
            this.grpSet.Name = "grpSet";
            this.grpSet.Size = new System.Drawing.Size(1003, 609);
            this.grpSet.TabIndex = 20;
            this.grpSet.TabStop = false;
            // 
            // lblpercent
            // 
            this.lblpercent.AutoSize = true;
            this.lblpercent.Location = new System.Drawing.Point(45, 306);
            this.lblpercent.Name = "lblpercent";
            this.lblpercent.Size = new System.Drawing.Size(44, 18);
            this.lblpercent.TabIndex = 42;
            this.lblpercent.Text = "label3";
            // 
            // grpScores
            // 
            this.grpScores.Controls.Add(this.lblScore);
            this.grpScores.Controls.Add(this.lblOver);
            this.grpScores.Controls.Add(this.txtOver);
            this.grpScores.Controls.Add(this.txtScore);
            this.grpScores.Controls.Add(this.btnUpdate);
            this.grpScores.Location = new System.Drawing.Point(579, 382);
            this.grpScores.Name = "grpScores";
            this.grpScores.Size = new System.Drawing.Size(329, 177);
            this.grpScores.TabIndex = 41;
            this.grpScores.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(56, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(44, 18);
            this.lblScore.TabIndex = 21;
            this.lblScore.Text = "Score";
            // 
            // lblOver
            // 
            this.lblOver.AutoSize = true;
            this.lblOver.Location = new System.Drawing.Point(226, 0);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(40, 18);
            this.lblOver.TabIndex = 19;
            this.lblOver.Text = "Over";
            // 
            // txtOver
            // 
            this.txtOver.Location = new System.Drawing.Point(183, 43);
            this.txtOver.Name = "txtOver";
            this.txtOver.Size = new System.Drawing.Size(135, 26);
            this.txtOver.TabIndex = 20;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(18, 43);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(135, 26);
            this.txtScore.TabIndex = 12;
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 107);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 46);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstStudentGrades
            // 
            this.lstStudentGrades.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstStudentGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStudentGradesID,
            this.clmclID,
            this.clmGID,
            this.clmGradingdetailsID,
            this.clmgradingName,
            this.clmCriteriaName,
            this.clmName,
            this.clmScore,
            this.clmRawScore,
            this.clmGrade,
            this.clmOverScore,
            this.clmpercentage});
            this.lstStudentGrades.FullRowSelect = true;
            this.lstStudentGrades.GridLines = true;
            this.lstStudentGrades.Location = new System.Drawing.Point(20, 369);
            this.lstStudentGrades.Name = "lstStudentGrades";
            this.lstStudentGrades.Size = new System.Drawing.Size(451, 234);
            this.lstStudentGrades.TabIndex = 40;
            this.lstStudentGrades.UseCompatibleStateImageBehavior = false;
            this.lstStudentGrades.View = System.Windows.Forms.View.Details;
            this.lstStudentGrades.SelectedIndexChanged += new System.EventHandler(this.lstStudentGrades_SelectedIndexChanged);
            // 
            // clmStudentGradesID
            // 
            this.clmStudentGradesID.Text = "StudentGradesID";
            this.clmStudentGradesID.Width = 0;
            // 
            // clmclID
            // 
            this.clmclID.Text = "ClassID";
            this.clmclID.Width = 0;
            // 
            // clmGID
            // 
            this.clmGID.Text = "GID";
            this.clmGID.Width = 0;
            // 
            // clmGradingdetailsID
            // 
            this.clmGradingdetailsID.Text = "GradingDetailsID";
            this.clmGradingdetailsID.Width = 0;
            // 
            // clmgradingName
            // 
            this.clmgradingName.Text = "GradingName";
            this.clmgradingName.Width = 0;
            // 
            // clmCriteriaName
            // 
            this.clmCriteriaName.Text = "Criteria Name";
            this.clmCriteriaName.Width = 0;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 200;
            // 
            // clmScore
            // 
            this.clmScore.Text = "Score";
            this.clmScore.Width = 100;
            // 
            // clmRawScore
            // 
            this.clmRawScore.Text = "Equivalent Score";
            this.clmRawScore.Width = 150;
            // 
            // clmGrade
            // 
            this.clmGrade.Text = "Grade";
            this.clmGrade.Width = 0;
            // 
            // clmOverScore
            // 
            this.clmOverScore.Text = "OverScore";
            this.clmOverScore.Width = 0;
            // 
            // clmpercentage
            // 
            this.clmpercentage.Text = "Percentage";
            this.clmpercentage.Width = 0;
            // 
            // lblStudName1
            // 
            this.lblStudName1.AutoSize = true;
            this.lblStudName1.Location = new System.Drawing.Point(235, 333);
            this.lblStudName1.Name = "lblStudName1";
            this.lblStudName1.Size = new System.Drawing.Size(0, 18);
            this.lblStudName1.TabIndex = 39;
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudName.Location = new System.Drawing.Point(118, 333);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.Size = new System.Drawing.Size(118, 18);
            this.lblStudName.TabIndex = 38;
            this.lblStudName.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(-3, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1009, 18);
            this.label2.TabIndex = 35;
            // 
            // lstcriterias
            // 
            this.lstcriterias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstcriterias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCriteria,
            this.clmpercent,
            this.ID});
            this.lstcriterias.FullRowSelect = true;
            this.lstcriterias.GridLines = true;
            this.lstcriterias.Location = new System.Drawing.Point(20, 67);
            this.lstcriterias.Margin = new System.Windows.Forms.Padding(4);
            this.lstcriterias.MultiSelect = false;
            this.lstcriterias.Name = "lstcriterias";
            this.lstcriterias.Size = new System.Drawing.Size(297, 213);
            this.lstcriterias.TabIndex = 5;
            this.lstcriterias.UseCompatibleStateImageBehavior = false;
            this.lstcriterias.View = System.Windows.Forms.View.Details;
            this.lstcriterias.SelectedIndexChanged += new System.EventHandler(this.lstcriterias_SelectedIndexChanged);
            // 
            // clmCriteria
            // 
            this.clmCriteria.Text = "Criteria";
            this.clmCriteria.Width = 200;
            // 
            // clmpercent
            // 
            this.clmpercent.Text = "Percentage";
            this.clmpercent.Width = 90;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // cmbterms
            // 
            this.cmbterms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbterms.FormattingEnabled = true;
            this.cmbterms.Location = new System.Drawing.Point(20, 33);
            this.cmbterms.Margin = new System.Windows.Forms.Padding(4);
            this.cmbterms.Name = "cmbterms";
            this.cmbterms.Size = new System.Drawing.Size(297, 26);
            this.cmbterms.TabIndex = 4;
            this.cmbterms.SelectedIndexChanged += new System.EventHandler(this.cmbterms_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.lstGradeDetails);
            this.groupBox1.Controls.Add(this.lblTermID);
            this.groupBox1.Controls.Add(this.lblpercentage);
            this.groupBox1.Controls.Add(this.lblSet);
            this.groupBox1.Controls.Add(this.txtSetOver);
            this.groupBox1.Controls.Add(this.btnSaveScore);
            this.groupBox1.Controls.Add(this.lblCrit);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(344, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 219);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.AccessibleDescription = "";
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(65, 170);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(61, 30);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lstGradeDetails
            // 
            this.lstGradeDetails.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstGradeDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmGDID,
            this.clmTermID,
            this.clmCritname,
            this.clmp,
            this.clmscores});
            this.lstGradeDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGradeDetails.FullRowSelect = true;
            this.lstGradeDetails.GridLines = true;
            this.lstGradeDetails.Location = new System.Drawing.Point(300, 18);
            this.lstGradeDetails.Name = "lstGradeDetails";
            this.lstGradeDetails.Size = new System.Drawing.Size(347, 195);
            this.lstGradeDetails.TabIndex = 9;
            this.lstGradeDetails.UseCompatibleStateImageBehavior = false;
            this.lstGradeDetails.View = System.Windows.Forms.View.Details;
            this.lstGradeDetails.Click += new System.EventHandler(this.lstGradeDetails_Click);
            // 
            // clmGDID
            // 
            this.clmGDID.Text = "GDID";
            this.clmGDID.Width = 0;
            // 
            // clmTermID
            // 
            this.clmTermID.Text = "TermID";
            this.clmTermID.Width = 0;
            // 
            // clmCritname
            // 
            this.clmCritname.Text = "Criteria Name";
            this.clmCritname.Width = 200;
            // 
            // clmp
            // 
            this.clmp.Text = "Percentage";
            this.clmp.Width = 90;
            // 
            // clmscores
            // 
            this.clmscores.Text = "Score";
            this.clmscores.Width = 50;
            // 
            // lblTermID
            // 
            this.lblTermID.AutoSize = true;
            this.lblTermID.Location = new System.Drawing.Point(25, 25);
            this.lblTermID.Name = "lblTermID";
            this.lblTermID.Size = new System.Drawing.Size(0, 18);
            this.lblTermID.TabIndex = 21;
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercentage.Location = new System.Drawing.Point(16, 70);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(96, 18);
            this.lblpercentage.TabIndex = 20;
            this.lblpercentage.Text = "Percentage : ";
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(16, 126);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(75, 18);
            this.lblSet.TabIndex = 19;
            this.lblSet.Text = "Set Score:";
            // 
            // txtSetOver
            // 
            this.txtSetOver.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetOver.Location = new System.Drawing.Point(97, 122);
            this.txtSetOver.MaxLength = 3;
            this.txtSetOver.Name = "txtSetOver";
            this.txtSetOver.Size = new System.Drawing.Size(79, 26);
            this.txtSetOver.TabIndex = 6;
            this.txtSetOver.Text = "0";
            this.txtSetOver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSetOver_KeyPress);
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.AccessibleDescription = "";
            this.btnSaveScore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScore.Location = new System.Drawing.Point(132, 170);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(72, 30);
            this.btnSaveScore.TabIndex = 7;
            this.btnSaveScore.Text = "Save";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // lblCrit
            // 
            this.lblCrit.AutoSize = true;
            this.lblCrit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrit.Location = new System.Drawing.Point(16, 28);
            this.lblCrit.Name = "lblCrit";
            this.lblCrit.Size = new System.Drawing.Size(111, 18);
            this.lblCrit.TabIndex = 15;
            this.lblCrit.Text = "Criteria Name : ";
            // 
            // lblterms
            // 
            this.lblterms.AutoSize = true;
            this.lblterms.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblterms.Location = new System.Drawing.Point(74, 13);
            this.lblterms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblterms.Name = "lblterms";
            this.lblterms.Size = new System.Drawing.Size(176, 18);
            this.lblterms.TabIndex = 11;
            this.lblterms.Text = "Select Grading Period:";
            // 
            // tbViewGrades
            // 
            this.tbViewGrades.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbViewGrades.Controls.Add(this.lblper);
            this.tbViewGrades.Controls.Add(this.btnprint);
            this.tbViewGrades.Controls.Add(this.lblgperiod);
            this.tbViewGrades.Controls.Add(this.cmbgradeperiod);
            this.tbViewGrades.Controls.Add(this.lstViewing);
            this.tbViewGrades.Location = new System.Drawing.Point(4, 27);
            this.tbViewGrades.Name = "tbViewGrades";
            this.tbViewGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewGrades.Size = new System.Drawing.Size(1009, 619);
            this.tbViewGrades.TabIndex = 2;
            this.tbViewGrades.Text = "View Grades";
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Location = new System.Drawing.Point(477, 51);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(44, 18);
            this.lblper.TabIndex = 19;
            this.lblper.Text = "label3";
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(816, 571);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(187, 42);
            this.btnprint.TabIndex = 18;
            this.btnprint.Text = "PRINT TO EXCEL";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lblgperiod
            // 
            this.lblgperiod.AutoSize = true;
            this.lblgperiod.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgperiod.Location = new System.Drawing.Point(133, 28);
            this.lblgperiod.Name = "lblgperiod";
            this.lblgperiod.Size = new System.Drawing.Size(171, 18);
            this.lblgperiod.TabIndex = 4;
            this.lblgperiod.Text = "Select Grading Period";
            // 
            // cmbgradeperiod
            // 
            this.cmbgradeperiod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgradeperiod.FormattingEnabled = true;
            this.cmbgradeperiod.Location = new System.Drawing.Point(62, 51);
            this.cmbgradeperiod.Name = "cmbgradeperiod";
            this.cmbgradeperiod.Size = new System.Drawing.Size(327, 26);
            this.cmbgradeperiod.TabIndex = 17;
            this.cmbgradeperiod.SelectedIndexChanged += new System.EventHandler(this.cmbgradeperiod_SelectedIndexChanged);
            // 
            // lstViewing
            // 
            this.lstViewing.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstViewing.ForeColor = System.Drawing.Color.Black;
            this.lstViewing.GridLines = true;
            this.lstViewing.Location = new System.Drawing.Point(7, 97);
            this.lstViewing.Name = "lstViewing";
            this.lstViewing.Size = new System.Drawing.Size(1006, 468);
            this.lstViewing.TabIndex = 0;
            this.lstViewing.UseCompatibleStateImageBehavior = false;
            this.lstViewing.View = System.Windows.Forms.View.Details;
            // 
            // frmManageGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.tbGrades);
            this.Controls.Add(this.lblline);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.cmbsubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.lblSchedule);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageGrading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageGrading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageGrading_Load);
            this.lblSchedule.ResumeLayout(false);
            this.lblSchedule.PerformLayout();
            this.tbGrades.ResumeLayout(false);
            this.tbSet.ResumeLayout(false);
            this.grpSet.ResumeLayout(false);
            this.grpSet.PerformLayout();
            this.grpScores.ResumeLayout(false);
            this.grpScores.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbViewGrades.ResumeLayout(false);
            this.tbViewGrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblSchedule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstStudents;
        private System.Windows.Forms.ColumnHeader clmStudentName;
        private System.Windows.Forms.ColumnHeader clmStudentID;
        private System.Windows.Forms.ColumnHeader clmStudNum;
        private System.Windows.Forms.ColumnHeader clmClassID;
        private System.Windows.Forms.ComboBox cmbsubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.TabControl tbGrades;
        private System.Windows.Forms.TabPage tbSet;
        private System.Windows.Forms.GroupBox grpSet;
        private System.Windows.Forms.ListView lstcriterias;
        private System.Windows.Forms.ColumnHeader clmCriteria;
        private System.Windows.Forms.ColumnHeader clmpercent;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ComboBox cmbterms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblTermID;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.TextBox txtSetOver;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.Label lblCrit;
        private System.Windows.Forms.Label lblterms;
        private System.Windows.Forms.ListView lstGradeDetails;
        private System.Windows.Forms.ColumnHeader clmGDID;
        private System.Windows.Forms.ColumnHeader clmTermID;
        private System.Windows.Forms.ColumnHeader clmCritname;
        private System.Windows.Forms.ColumnHeader clmp;
        private System.Windows.Forms.ColumnHeader clmscores;
        private System.Windows.Forms.TabPage tbViewGrades;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label lblgperiod;
        private System.Windows.Forms.ComboBox cmbgradeperiod;
        private System.Windows.Forms.ListView lstViewing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudName1;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.ListView lstStudentGrades;
        private System.Windows.Forms.ColumnHeader clmStudentGradesID;
        private System.Windows.Forms.ColumnHeader clmclID;
        private System.Windows.Forms.ColumnHeader clmGID;
        private System.Windows.Forms.ColumnHeader clmGradingdetailsID;
        private System.Windows.Forms.ColumnHeader clmgradingName;
        private System.Windows.Forms.ColumnHeader clmCriteriaName;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmScore;
        private System.Windows.Forms.ColumnHeader clmRawScore;
        private System.Windows.Forms.ColumnHeader clmGrade;
        private System.Windows.Forms.GroupBox grpScores;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblOver;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader clmOverScore;
        private System.Windows.Forms.ColumnHeader clmpercentage;
        private System.Windows.Forms.Label lblpercent;
        private System.Windows.Forms.Label lblper;
    }
}