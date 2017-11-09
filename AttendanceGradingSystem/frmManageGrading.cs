using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlDButilities;
using MySql.Data;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AttendanceGradingSystem
{
    public partial class frmManageGrading : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        DataTable table;
        public static string mgUid;
        private List<StudDetails> students;
        private List<Criteria> criterias;
        private List<Subject> subjects;
        private List<GradeDetails> gradedetail;
        private List<StudentGrades> studGrades;
        public static long studGradeID;
        public frmManageGrading()
        {
            InitializeComponent();
            students = new List<StudDetails>();
            criterias = new List<Criteria>();
            subjects = new List<Subject>();
            table = new DataTable();
            gradedetail = new List<GradeDetails>();
            studGrades = new List<StudentGrades>();
            tbGrades.Enabled = false;
            lstStudents.Enabled = false;
            lblpercent.Visible = false;
            lblTermID.Visible = false;
            btncancel.Visible = false;
            btnUpdate.Enabled = false;
            txtOver.Enabled = false;
            lblper.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageGrading_Load(object sender, EventArgs e)
        {
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = " + mgUid + " ORDER BY SubjectName ASC;", cmbsubject, "SubjectID", "SubjectName");
        }
        private void BindToComboBox(string query, ComboBox cmb, string key, string value)
        {
            cmb.Items.Clear();
            Dictionary<string, string> d = new Dictionary<string, string>();
            MySqlDataAdapter adpter = new MySqlDataAdapter(query, db.OpenConnection());
            adpter.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                d.Add(row[key].ToString(), row[value].ToString());
            }
            if (d.Count > 0)
            {
                cmb.DataSource = new BindingSource(d, null);
                cmb.ValueMember = "Key";
                cmb.DisplayMember = "Value";
            }
        }
        public void PopulateSchedule()
        {
            cmbSchedule.Items.Clear();
            subjects = new List<Subject>();
            string query = "SELECT * FROM tblschedule sc INNER JOIN tblsubject su " +
                           "ON sc.SubjectID = su.SubjectID " +
                           "WHERE su.SubjectName = '" + cmbsubject.Text + "' AND su.UserID =" + mgUid + " ;";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                Subject su = new Subject(r["SubjectID"].ToString(), r["SubjectCode"].ToString() , r["SubjectName"].ToString(), r["SubjectUnits"].ToString() , r["UserID"].ToString() ,
                    r["ScheduleID"].ToString() , r["ScheduleTimeTo"].ToString() , r["ScheduleTimeFrom"].ToString() , r["ScheduleDay"].ToString());
                subjects.Add(su);
               // cmbSchedule.Items.Add(r["ScheduleDay"].ToString() + " | " + r["ScheduleTimeFrom"].ToString() + " - " + r["ScheduleTimeTo"].ToString());
            }
            foreach(Subject sj in subjects)
            {
                cmbSchedule.Items.Add(sj.ScheduleDay + " | " + sj.ScheduleTimeFrom + " - " + sj.ScheduleTimeTo);
            }
        }
        private void cmbsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            tbGrades.Enabled = false;
            PopulateSchedule();
        }
        public void Clear()
        {
            lstStudents.Items.Clear();
            classNum.Clear();
            cmbterms.Items.Clear();
            lstcriterias.Items.Clear();
            lstGradeDetails.Items.Clear();
            lstStudentGrades.Items.Clear();
            cmbgradeperiod.Items.Clear();
            lstViewing.Items.Clear();
            lblStudName.Text = "Student Name:";
        }
        List<string> classNum = new List<string>();
        public void PopulateStudents()
        {
            if (cmbsubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            students = new List<StudDetails>();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbsubject.Text + "' AND UserID = " + mgUid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "'", "ScheduleID").ToString();
             string query2 = "SELECT * FROM tblstudent s INNER JOIN tblcourse c " +
                        "ON s.CourseID = c.CourseID INNER JOIN tblsubjectclass sc " +
                        "ON sc.StudID = s.StudentID INNER JOIN tblsubject su " +
                        "ON su.SubjectID = sc.SubjectID WHERE  s.Status = 'Active' AND sc.SubjectID = " + subjid+ " AND sc.UserID = " + mgUid + " AND sc.ScheduleID = " + schedID +
                        " ORDER BY LName;";
            DataTable dt2 = db.SelectQuery(query2);
            foreach (DataRow r in dt2.Rows)
            {
                StudDetails s = new StudDetails(r["FName"].ToString() + " " + r["LName"].ToString(), r["StudentID"].ToString(), r["StudNum"].ToString(), r["ClassID"].ToString());
                students.Add(s);
            }
            PopulateStuds(students);
        }
        private void PopulateStuds(List<StudDetails> ss)
        {
            lstStudents.Items.Clear();
            classNum.Clear();
            foreach (StudDetails s in students)
            {
                ListViewItem itm = new ListViewItem(s.StudentName);
                itm.SubItems.Add(s.StudentID);
                itm.SubItems.Add(s.StudentNumber);
                itm.SubItems.Add(s.ClassID);
                lstStudents.Items.Add(itm);
                classNum.Add(s.ClassID);
            }
        }
        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cmbSchedule.Text.Equals("")))
            {
                tbGrades.Enabled = true;
                lstStudents.Enabled = true;
            }
            Clear();
            PopulateStudents();
            PopulateGradingPeriod();
        }
        public void PopulateGradingPeriod()
        {
            cmbterms.Items.Clear();
            long subject = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbsubject.Text + "' AND UserID = " + mgUid + ";", "SubjectID");

            string query = "SELECT * FROM tblgradingperiod gp INNER JOIN tblgnames gn " +
                "ON gp.GNID = gn.GNID " +
                "WHERE gp.SubjectID = " + subject + " AND gn.UserID = " + mgUid + "";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                cmbterms.Items.Add(r["GradingName"].ToString());
                cmbgradeperiod.Items.Add(r["GradingName"].ToString());
            }
            //cmbterms.Text = cmbterms.SelectedItem[0];  
            cmbgradeperiod.Items.Add("Show All");
           // cmbgradeperiod.SelectedItem = cmbgradeperiod.Items[0];
            //cmbterms.SelectedItem = cmbterms.Items[0];
        }
        List<string> cNames = new List<string>();
        public void PopulateCriteria()
        {
            if (cmbsubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            lstcriterias.Items.Clear();
            criterias = new List<Criteria>();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName = '" + cmbsubject.Text + "' AND UserID = " + mgUid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string query = "SELECT c.CriteriaName , c.Percentage , tg.SubjectID , tg.ScheduleID , c.UserID , gn.GradingName , tg.ID FROM tbltermgrading tg INNER JOIN tblgradingperiod g " +
                             "ON tg.GID = g.GID INNER JOIN tblcriteria c " +
                             "ON tg.CriteriaID = c.CriteriaID INNER JOIN tblgnames gn " +
                             "ON g.GNID = gn.GNID " +
                             "WHERE tg.SubjectID = " + subjid + " AND ScheduleID = " + schedID + " AND c.UserID = " + mgUid + "  AND gn.GradingName = '" + cmbterms.Text + "';";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There's no criteria set for " + cmbsubject.Text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataRow r in dt.Rows)
            {
                Criteria c = new Criteria(r["CriteriaName"].ToString(), r["Percentage"].ToString(), r["ID"].ToString());
                criterias.Add(c);
            }
            PopulateCriteria2(criterias);
        }
       
        private void PopulateCriteria2(List<Criteria> c)
        {
            lstcriterias.Items.Clear();
            cNames.Clear();
            foreach (Criteria ct in criterias)
            {
                if (!(ct.CriteriaName.Equals("Attendance")))
                {
                    ListViewItem itm = new ListViewItem(ct.CriteriaName);
                    itm.SubItems.Add(ct.Percentage);
                    itm.SubItems.Add(ct.TgID);
                    lstcriterias.Items.Add(itm);
                }
                cNames.Add(ct.CriteriaName);
            }
        }
        private void cmbterms_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstcriterias.Items.Clear();
            lstGradeDetails.Items.Clear();
            PopulateCriteria();
            SetGradingDetails();
            PopulateGradeDetails();
            SetDefaultGrades();
        }
        public void SetGradingDetails()
        {
            if (cmbSchedule.Text.Equals("") || cmbsubject.Text.Equals("")) return;
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            long gnid = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName ='" + cmbterms.Text + "' AND UserID = " + mgUid + "", "GNID");
            long gid = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + gnid + " AND SubjectID = " + SubjID + "", "GID");
            foreach (string names in cNames)
            {
                long critID = db.GetID("SELECT CriteriaID FROM tblcriteria WHERE CriteriaName = '" + names + "' AND UserID = " + mgUid + "", "CriteriaID");
                double percent = Convert.ToDouble(db.GetValue("SELECT Percentage FROM tblcriteria WHERE CriteriaName = '" + names + "' AND UserID = " + mgUid + "", "Percentage"));
                long termid = db.GetID("SELECT ID FROM tbltermgrading WHERE GID = " + gid + " AND CriteriaID = " + critID + " AND SubjectID = " + SubjID + " AND ScheduleID = " + schedID + " ", "ID");

                string que = "SELECT CriteriaName , TermGradingID FROM tblgradingdetails WHERE CriteriaName = '" + names + "' AND TermGradingID = " + termid + " ";
                DataTable data = db.SelectQuery(que);
                if (data.Rows.Count == 0)
                {
                    if (names.Equals("Attendance") || names.Equals("Major Exam"))
                    {
                        string query2 = "INSERT INTO tblgradingdetails(TermGradingID, Name, Percentage ,OverScore, CriteriaName, Type ) " +
                                   "VALUES( " + termid + ", '" + names + "', " + "." + percent + " , 100  , '" + names + "'  , '" + cmbterms.Text + "')";
                        db.InsertQuery(query2);
                    }
                    else if (!(names.Equals("Attendance")) || !(names.Equals("Major Exam")))
                    {
                        string query2 = "INSERT INTO tblgradingdetails(TermGradingID, Name, Percentage ,OverScore, CriteriaName, Type ) " +
                                   "VALUES( " + termid + ", '" + names + " 1" + "', " + "." + percent + " , 100  , '" + names + "'  , '" + cmbterms.Text + "')";
                        db.InsertQuery(query2);
                    }

                }
            }
        }
        public void PopulateGradeDetails()
        {
            if (cmbSchedule.Text.Equals("") || cmbsubject.Text.Equals("")) return;
            gradedetail = new List<GradeDetails>();
            lstGradeDetails.Items.Clear();
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");  
            long gnid = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName ='" + cmbterms.Text + "' AND UserID = " + mgUid + "", "GNID");
            long gid = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + gnid + " AND SubjectID = " + SubjID + ";", "GID");
            string query2 = "SELECT * FROM tblgradingdetails g INNER JOIN tbltermgrading tg " +
                               "ON g.TermGradingID = tg.ID INNER JOIN tblgradingperiod gp " +
                               "ON tg.GID = gp.GID " +
                               "WHERE GNID = " + gnid + " AND tg.ScheduleID = " + schedID + " AND tg.SubjectID = " + SubjID + " ORDER BY g.Name ASC;";
            DataTable dt2 = db.SelectQuery(query2);
            foreach (DataRow r in dt2.Rows)
            {
                GradeDetails g = new GradeDetails(r["GDID"].ToString(), r["TermGradingID"].ToString(), r["Name"].ToString(), r["Percentage"].ToString(),
                        r["OverScore"].ToString(), r["CriteriaName"].ToString(), r["Type"].ToString());
                gradedetail.Add(g);
            }
            PopulateGradeDetail(gradedetail);
        }
        List<string> criteriaName = new List<string>();
        private void PopulateGradeDetail(List<GradeDetails> gradedetails)
        {
            lstGradeDetails.Items.Clear();
            criteriaName.Clear();
            foreach (GradeDetails gd in gradedetails)
            {
                if (!(gd.critName.Equals("Attendance")))
                {
                    ListViewItem itm = new ListViewItem(gd.GDID);
                    itm.SubItems.Add(gd.TermGradingID);
                    itm.SubItems.Add(gd.critName);
                    itm.SubItems.Add(gd.Percentage);
                    itm.SubItems.Add(gd.OverScore);
                    lstGradeDetails.Items.Add(itm);
                }
                criteriaName.Add(gd.critName);
            }
        }
        public bool IsSelected()
        {
            try
            {
                int index = lstStudents.SelectedIndices[0];
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void txtSetOver_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandler(ref sender, ref e , true);
        }

        private void lstcriterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveScore.Text = "Save";
            txtOver.Text = txtScore.Text = txtSetOver.Text = "0";
            btncancel.Visible = true;
            string n = "";
            for (int i = 0; i < lstcriterias.Items.Count; i++)
            {
                if (lstcriterias.Items[i].Selected)
                {
                    n = lstcriterias.Items[i].SubItems[0].Text;
                }
                if (n == lstcriterias.Items[i].SubItems[0].Text)
                {
                    lstcriterias.Items[i].BackColor = SystemColors.Highlight;
                    lblCrit.Text = "Criteria Name : " + lstcriterias.Items[i].SubItems[0].Text;
                    lblpercentage.Text = "Percentage : " + lstcriterias.Items[i].SubItems[1].Text + "%";
                    lblTermID.Text = lstcriterias.Items[i].SubItems[2].Text;
                }
                else
                {
                    lstcriterias.Items[i].BackColor = SystemColors.ScrollBar;
                }
            }
            n = "";
        }

        private void lstGradeDetails_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstcriterias.Items.Count; i++)
            {
                lstcriterias.Items[i].BackColor = SystemColors.ScrollBar;
            }
                btncancel.Visible = true;
            btnSaveScore.Text = "Update";
            ListViewItem itm = lstGradeDetails.SelectedItems[0];
            lblTermID.Text = itm.SubItems[1].Text;
            lblCrit.Text = "Criteria Name : " + itm.SubItems[2].Text;
            lblpercentage.Text = "Percentage : " + itm.SubItems[3].Text;
            txtSetOver.Text = itm.SubItems[4].Text;
        }
        public bool Valid(string con)
        {
            if (txtSetOver.Text.Equals("0") || lblCrit.Text.Equals("Criteria Name : ") || lblpercentage.Text.Equals("Percentage : ") || txtSetOver.Text.Equals(""))
            {
                MessageBox.Show("Please input number in set over all score except 0 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        string names;
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            PopulateStudents();
            if (btnSaveScore.Text == "Save")
            {
                if (Valid(""))
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you you want to save the following details?", "Saved?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string percent = lblpercentage.Text.Split(':')[1].Trim();
                        string name = lblCrit.Text.Split(':')[1].Trim();
                        string query = "INSERT INTO tblgradingdetails(TermGradingID, Name, Percentage ,OverScore , CriteriaName , Type) " +
                            "VALUES( " + lblTermID.Text + ", '" + name + " " + Count() + "', " + "." + Convert.ToDouble(percent.Trim('%')) + " , " + Convert.ToDouble(txtSetOver.Text) + " , '" + name + "' , '" + cmbterms.Text + "')";
                        names = name + " " + Count();
                        db.InsertQuery(query);
                        SetDefault();
                        //InsertAttendance();
                        MessageBox.Show("The following details was successfully saved");
                        txtOver.Text = txtScore.Text = txtSetOver.Text = "0";
                        lblCrit.Text = "Criteria Name : ";
                        lblpercentage.Text = "Percentage : ";
                    }

                }
            }
            else if (btnSaveScore.Text == "Update")
            {
                List<string> classids1 = new List<string>();
                if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to update the following details? ", "Update?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string updatequery = "UPDATE tblgradingdetails SET OverScore = " + Convert.ToDouble(txtSetOver.Text) + " WHERE TermGradingID =" + lstGradeDetails.SelectedItems[0].SubItems[1].Text + " AND Name = '" + lblCrit.Text.Split(':')[1].Trim() + "';";
                    db.InsertQuery(updatequery);
                    classids1.Clear();
                    string qu = "SELECT DISTINCT ClassID FROM tblstudentgrades WHERE GradingName = '" + cmbterms.Text + "' AND Name = '" + lblCrit.Text.Split(':')[1].Trim() + "' AND GradingDetailsID = " + lstGradeDetails.SelectedItems[0].SubItems[0].Text + ";";
                    DataTable tb = db.SelectQuery(qu);
                    foreach (DataRow r in tb.Rows)
                        classids1.Add(r["ClassID"].ToString());
                    foreach (string s in classids1)
                    {
                        string score = db.GetValue("SELECT * FROM tblstudentgrades WHERE GradingName = '" + cmbterms.Text + "'  AND Name = '" + lblCrit.Text.Split(':')[1].Trim() + "' AND ClassID = " + s + " ", "Score");
                        double raw = Math.Round((Convert.ToDouble(score) / Convert.ToDouble(txtSetOver.Text) * 50 + 50), 2);
                        string updatescore = "UPDATE tblstudentgrades SET RawScore = " + raw + ", Grade = " + raw * Convert.ToDouble(lstGradeDetails.SelectedItems[0].SubItems[3].Text) + " WHERE GradingDetailsID = " + lstGradeDetails.SelectedItems[0].SubItems[0].Text + " AND ClassID = " + s + " AND GradingName = '" + cmbterms.Text + "'";
                        db.InsertQuery(updatescore);
                    }
                    MessageBox.Show("The following details was successfully saved");
                    btnSaveScore.Text = "Save";
                    lblCrit.Text = "Criteria Name";
                    lblpercentage.Text = "Percentage";
                    txtOver.Text = txtScore.Text = txtSetOver.Text = "0";
                    btncancel.Visible = false;
                   // lstStudentGrades.Items.Clear();
                    StudentGrades1();
                }
            }
            PopulateGradeDetails();
        }
        List<string> terids = new List<string>();
        public int Count()
        {
            foreach (ListViewItem item in lstcriterias.SelectedItems)
                terids.Add(item.SubItems[2].Text);
            int Counter = 1;
            long gnid = db.GetID("SELECT * FROM tblgnames WHERE GradingName ='" + cmbterms.Text + "' AND UserID = " + mgUid + "", "GNID");
            string name = lblCrit.Text.Split(':')[1].Trim();
            string query = "SELECT Count(*) as 'Count' FROM tblgradingdetails WHERE Name LIKE '%" + name + "%' AND TermGradingID = " + Convert.ToDouble(lblTermID.Text) + "";
            DataTable tbl = db.SelectQuery(query);
            foreach (DataRow r in tbl.Rows)
            {
                Counter = Convert.ToInt32(r["Count"].ToString());
                Counter++;
            }
            return Counter;
        }
        public void SetDefault()
        {
            //classNum.Clear();
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            long GNID = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName = '" + cmbterms.Text + "' AND UserID = " + mgUid + "", "GNID");
            long GID = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + GNID + " AND SubjectID =" + SubjID + ";", "GID");
            long gradID = db.GetID("SELECT g.GDID FROM tblgradingdetails g INNER JOIN tbltermgrading t " +
                                    "ON g.TermGradingID = t.ID INNER JOIN tblcriteria c " +
                                    "ON c.CriteriaID = t.CriteriaID  " +
                                    "WHERE g.Type = '" + cmbterms.Text + "' AND g.CriteriaName = '" + lstcriterias.SelectedItems[0].SubItems[0].Text + "'  " +
                                    "AND c.UserID = " + mgUid + " AND t.ID = " + lstcriterias.SelectedItems[0].SubItems[2].Text + " AND g.Name = '" + names + "';", "GDID");
            string name = lblCrit.Text.Split(':')[1].Trim();
            foreach (string c in classNum)
            {
                string qu = "SELECT ClassID , GID , GradingDetailsID , GradingName , CriteriaName , Name FROM tblstudentgrades WHERE ClassID = " + c + " AND GID = " +
                    GID + "  AND GradingDetailsID = " + gradID + " AND GradingName = '" + cmbterms.Text + "' " +
                    " AND CriteriaName = '" + lstcriterias.SelectedItems[0].SubItems[0].Text + "' AND Name = '" + names + "'";
                DataTable tb = db.SelectQuery(qu);
                if (tb.Rows.Count == 0)
                {
                    double rscore = ((Convert.ToDouble(0) / Convert.ToDouble(txtSetOver.Text)) * 50 + 50);
                    string per = lstcriterias.SelectedItems[0].SubItems[1].Text;
                    string ok = "." + per;
                    double grade = rscore * Convert.ToDouble(ok);
                        string query = "INSERT INTO `attendance_db`.`tblstudentgrades` (`ClassID`, `GID`, `GradingDetailsID`, `GradingName`, `CriteriaName`, `Name`, `Score`, `RawScore`, `Grade`) " +
                        "VALUES (" + c + ", " + GID + ", " + gradID + ", '" + cmbterms.Text + "', '" + lstcriterias.SelectedItems[0].SubItems[0].Text + "', '" + names + "', 0, " + rscore + ", " + grade + ");";
                    db.InsertQuery(query);
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            btnSaveScore.Text = "Save";
            btncancel.Visible = false;
            lblCrit.Text = "Criteria Name : ";
            lblpercentage.Text = "Percentage : ";
            txtOver.Text = txtScore.Text = txtSetOver.Text = "0";
        }
        public void SetDefaultGrades()
        {
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            long GNID = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName = '" + cmbterms.Text + "' AND UserID = " + mgUid + "", "GNID");
            long GID = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + GNID + " AND SubjectID =" + SubjID + ";", "GID");
            foreach (string c in classNum)
            {
                foreach (string lists in criteriaName)
                {
                    foreach (string names in cNames)
                    {
                        long termid2 = db.GetID("SELECT c.ID FROM tbltermgrading c INNER JOIN tblgradingdetails g " +
                            "ON c.ID = g.TermgradingID WHERE c.GID = " + GID + "  AND c.SubjectID = " + SubjID + " AND c.ScheduleID = " + schedID + " AND g.Name = '" + lists + "' ", "ID");
                        long gDetailsID = db.GetID("SELECT GDID FROM tblgradingdetails WHERE Name = '" + lists + "' AND Type = '" + cmbterms.Text + "';", "GDID");
                        string percent = db.GetValue("SELECT Percentage FROM tblgradingdetails WHERE Name = '" + lists + "' AND TermGradingID = " + termid2 + " ", "Percentage").ToString();
                        if (!percent.Equals(""))
                        {
                            string OverScore = db.GetValue("SELECT OverScore FROM tblgradingdetails WHERE Name = '" + lists + "' ", "OverScore").ToString();
                            string l = lists.Split('1')[0].Trim();
                            if (names.Equals(l))
                            {
                                string qw = "SELECT ClassID , GID , GradingDetailsID , GradingName , Name FROM tblstudentgrades WHERE ClassID = " + c + " AND GID = " +
                                    GID + " AND GradingDetailsID = " + gDetailsID + " AND GradingName = '" + cmbterms.Text + "' AND Name = '" + lists + "'";
                                DataTable fg = db.SelectQuery(qw);
                                if (fg.Rows.Count == 0)
                                {
                                    double rawScore = 50;
                                    double grade = rawScore * Convert.ToDouble(percent);
                                    // rawScore = Math.Round(rawScore, 2);
                                    string query = "INSERT INTO `attendance_db`.`tblstudentgrades` (`ClassID`, `GID`, `GradingDetailsID`, `GradingName`, `CriteriaName`, `Name`, `Score`, `RawScore`, `Grade`) " +
                                                   "VALUES ( " + c + ", " + GID + " , " + gDetailsID + ",  '" + cmbterms.Text + "' , '" + names + "'  ,'" + lists + "', 0 , " + rawScore + " , " + grade + ");";
                                    //cmd = new MySqlCommand(query, db.OpenConnection());
                                    //cmd.ExecuteNonQuery();
                                    //db.CloseConnection();
                                    db.InsertQuery(query);
                                }
                            }
                        }
                    }
                }
            }
           // classNum.Clear();
            criteriaName.Clear();
            cNames.Clear();
            txtOver.Text = txtScore.Text = txtSetOver.Text = "0";
            StudentGrades1();
        }
        public void StudentGrades1()
        {
            
            if (cmbterms.Text.Equals("") || cmbSchedule.Text.Equals("") || cmbsubject.Text.Equals("")) return;
            lstStudentGrades.Items.Clear();
            studGrades = new List<StudentGrades>();
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");       
            foreach (string c in studClassID)
            {
                string query = "SELECT sg.StudentGradesID , sg.ClassID , sg.GID , sg.GradingDetailsID , sg.GradingName , sg.CriteriaName , sg.Name , sg.Score , sg.RawScore , g.OverScore , sg.Grade, g.Percentage FROM tblstudentgrades sg INNER JOIN tblsubjectclass sc " +
                               "ON sg.ClassID = sc.ClassID INNER JOIN tblstudent s " +
                               "ON sc.StudID = s.StudentID INNER JOIN tblgradingdetails g " +
                               "ON sg.GradingDetailsID = g.GDID WHERE sg.ClassID = " + c +
                               " AND sg.GradingName = '" + cmbterms.Text + "' AND sc.SubjectID = " + SubjID + "  AND sc.ScheduleID = " + schedID + " AND s.Status = 'Active'";
                DataTable tble = db.SelectQuery(query);
                foreach (DataRow r in tble.Rows)
                {
                    StudentGrades st = new StudentGrades(r["StudentGradesID"].ToString(), r["ClassID"].ToString(), r["GID"].ToString(), r["GradingDetailsID"].ToString(),
                        r["GradingName"].ToString(), r["CriteriaName"].ToString(), r["Name"].ToString(), r["Score"].ToString(), r["RawScore"].ToString(),r["OverScore"].ToString(), r["Grade"].ToString() , r["Percentage"].ToString());
                    studGrades.Add(st);
                }
            }
            PopulateStudentGradeDetails(studGrades);
        }
        private void PopulateStudentGradeDetails(List<StudentGrades> st)
        {
            lstStudentGrades.Items.Clear();
            foreach (StudentGrades s in st)
            {
                if (!(s.CriteriaName2.Equals("Attendance")))
                {
                    ListViewItem itm = new ListViewItem(s.StudentGradesID);
                    itm.SubItems.Add(s.ClassID);
                    itm.SubItems.Add(s.GID2);
                    itm.SubItems.Add(s.GradeDetailsID2);
                    itm.SubItems.Add(s.GradingName);
                    itm.SubItems.Add(s.CriteriaName2);
                    itm.SubItems.Add(s.Name2);
                    itm.SubItems.Add(s.Score);
                    itm.SubItems.Add(s.RawScore);
                    itm.SubItems.Add(s.Grade);
                    itm.SubItems.Add(s.OverScore2);
                    itm.SubItems.Add(s.percent2);
                    lstStudentGrades.Items.Add(itm);
                }
            }
        }
        List<string> studClassID = new List<string>();
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            studClassID.Clear();
            lstStudentGrades.Items.Clear();
            string s = "";
            for (int i = 0; i < lstStudents.Items.Count; i++)
            {
                if (lstStudents.Items[i].Selected)
                {
                    s = lstStudents.Items[i].SubItems[1].Text;
                }
                if (s == lstStudents.Items[i].SubItems[1].Text)
                {
                    lstStudents.Items[i].BackColor = SystemColors.Highlight;
                    lblStudName1.Text = lstStudents.Items[i].SubItems[0].Text;
                    studClassID.Add(lstStudents.Items[i].SubItems[3].Text);          
                }
                else
                {
                    lstStudents.Items[i].BackColor = SystemColors.ScrollBar;
                }
            }
            s = "";
            StudentGrades1();
            //attendance();
        }
        
        private void lstStudentGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            string n = "";
            for (int i = 0; i < lstStudentGrades.Items.Count; i++)
            {
                if (lstStudentGrades.Items[i].Selected)
                {
                    n = lstStudentGrades.Items[i].SubItems[0].Text;
                }
                if (n == lstStudentGrades.Items[i].SubItems[0].Text)
                {
                    lstStudentGrades.Items[i].BackColor = SystemColors.Highlight;
                    txtScore.Text = lstStudentGrades.Items[i].SubItems[7].Text;
                    txtOver.Text = lstStudentGrades.Items[i].SubItems[10].Text;
                    lblpercent.Text = lstStudentGrades.Items[i].SubItems[11].Text;
                    studGradeID = Convert.ToInt64(lstStudentGrades.Items[i].SubItems[0].Text);
                }
                else
                {
                    lstStudentGrades.Items[i].BackColor = SystemColors.ScrollBar;
                }
            }
            n = "";
        }
        public bool Validate(string cons)
        {
            int Score = Convert.ToInt32(txtScore.Text);
            int over = Convert.ToInt32(txtOver.Text);
            if (Score > over)
            {
                MessageBox.Show("The score you've entered is higher than to the over all score. Please input lower or equal to the over all score.", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validate(""))
            {
                double percent1 = Convert.ToDouble(lblpercent.Text);
                double rawScore = Math.Round(((Convert.ToDouble(txtScore.Text) / Convert.ToDouble(txtOver.Text)) * 50 + 50), 2);

                double grade = Convert.ToDouble(rawScore * percent1);
                string query = "UPDATE tblstudentgrades SET Score = " + Convert.ToDouble(txtScore.Text) + "  ,  RawScore = " + rawScore + ", Grade = " + grade + " " +
                    " WHERE StudentGradesID = " + studGradeID + ";";
                db.InsertQuery(query);
                MessageBox.Show("The following details was successfully updated.", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOver.Text = "0";
                txtScore.Text = "0";
                btnUpdate.Enabled = false;
                StudentGrades1();
            }
        }
        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandler(ref sender, ref e, true);
        }
        public enum ShowCommands : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }

        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        private void PrintReportToExcel()
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRng;
            object oMissing = Missing.Value;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = oXL.Workbooks._Open(@Application.StartupPath + "\\Record\\GradeRecord.xlsx", oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing);

                oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                //oSheet.Cells[row,col] = " data "
                oSheet.Cells[4, 6] = DateTime.Now.ToLongDateString(); //Print Date on excel row 4, column F (6)

                if (cmbgradeperiod.Text == "Show All")
                {
                    oSheet.Cells[4, 3] = cmbsubject.Text + " " + "Grade";
                }
                else
                    oSheet.Cells[4, 3] = cmbgradeperiod.Text;
                // oSheet.Cells[5, 1] = "Fullname";
                // int counter = 8;

                //int col2 = 1;
                //int row = 8;
                int count = 1;
                int col1 = 1;
                int row1 = 9;



                for (int i = 1; i < lstViewing.Columns.Count; i++)
                {
                    oSheet.Cells[8, col1++] = lstViewing.Columns[i].Text;
                }
                //for (int i = 0; i < lstViewing.Items.Count; i++)
                //{
                //    oSheet.Cells[row1, col++] = lstViewing.Items[i].Text;
                //    // oSheet.Cells[row1++ , col++] = lstViewing
                //    // oSheet.Cells[row1, 2] = lstViewing.Items[i].SubItems[1].Text + " " + lstViewing.Items[i].SubItems[2].Text + ", " + lstViewing.Items[i].SubItems[3].Text;
                //}
                //row1++;
                //col = 1;
                int col = 1;
                for (int j = 0; j < lstViewing.Items.Count; j++)
                {
                    for (int i = 1; i < lstViewing.Columns.Count; i++)
                    {
                        oSheet.Cells[row1, col] = lstViewing.Items[j].SubItems[i].Text;
                        //count++;
                        col++;
                    }
                    row1++;

                    col = 1;

                }
                oWB.SaveAs(Application.StartupPath + "\\Record\\" + cmbsubject.Text + DateTime.Now.Second + ".xlsx", oMissing, oMissing, oMissing, oMissing,
                             oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                             oMissing, oMissing, oMissing, oMissing, oMissing);
                //oWB.SaveAs(@Application.StartupPath + "\\Record\\GradeRecord" + cmbsubject.Text + "||" + cmbSchedule.Text + "||"+cmbgradeperiod.Text + "||" +DateTime.Now.Second+".xlsx", oMissing, oMissing, oMissing, oMissing, oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, oMissing, oMissing, oMissing, oMissing, oMissing);
                oWB.Close(oMissing, Application.StartupPath + "\\Record\\GradeRecord.xlsx", oMissing);
                oWB = oXL.Workbooks._Open(Application.StartupPath + "\\Record\\" + cmbsubject.Text + DateTime.Now.Second + ".xlsx", oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
                //oWB.Close(true, Type.Missing, Type.Missing);
                // oXL.Quit();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbgradeperiod_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendance();
            LoadListCritView();
            LoadDataListCrit();
            lstViewing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstViewing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lstViewing.Columns[0].Width = 0;
            if (cmbgradeperiod.Text == "Show All")
            {
                LoadGradingView();
                LoadDataGradeView();
                lstViewing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstViewing.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstViewing.Columns[0].Width = 0;
            }
        }
        List<string> critnames = new List<string>();
        public void LoadListCritView()
        {
            lstViewing.Clear();
            critnames.Clear();
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            long gnid = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName = '" + cmbgradeperiod.Text + "' AND UserID = " + mgUid + ";", "GNID");
            long gid = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + gnid + " AND SubjectID = " + SubjID + "", "GID");
            string query1 = "SELECT DISTINCT CriteriaName FROM tblgradingdetails c INNER JOIN tbltermgrading tg " +
                           "ON c.TermGradingID = tg.ID " +
                           "WHERE tg.GID = " + gid + " AND tg.SubjectID = " + SubjID + " AND tg.ScheduleID = " + schedID + " " +
                           "ORDER BY tg.CriteriaID";
            DataTable tb = db.SelectQuery(query1);
            foreach (DataRow row in tb.Rows)
                critnames.Add(row["CriteriaName"].ToString());
            lstViewing.Columns.Add("ClassID");
            lstViewing.Columns.Add("Fullname");
            for (int i = 0; i < critnames.Count; i++)
            {
                string query = "SELECT  gd.Name , gd.CriteriaName  FROM tblgradingdetails gd INNER JOIN tbltermgrading tg " +
                               "ON gd.TermGradingID = tg.ID " +
                                "WHERE  tg.GID = " + gid + " AND tg.SubjectID = " + SubjID + " AND tg.ScheduleID = " + schedID + " AND gd.CriteriaName = '" + critnames[i] + "' AND Type = '" + cmbgradeperiod.Text + "' ORDER BY gd.Name ASC ";

                DataTable tab = db.SelectQuery(query);
                foreach (DataRow r in tab.Rows)
                {
                    lstViewing.Columns.Add(r["Name"].ToString());
                }
                lstViewing.Columns.Add("Total " + critnames[i]);
            }
            lstViewing.Columns.Add("Total Grade");
            lstViewing.Columns.Add("Remarks");
        }
        List<string> criteria = new List<string>();
        public void LoadDataListCrit()
        {
            lstViewing.Items.Clear();
            if (cmbsubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            long gnid = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName = '" + cmbgradeperiod.Text + "' AND UserID = " + mgUid + ";", "GNID");
            long gid = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + gnid + " AND SubjectID = " + SubjID + "", "GID");
            string select = "SELECT * FROM tblstudentgrades sg INNER JOIN tblsubjectclass sc " +
                "ON sg.ClassID  = sc.ClassID WHERE sc.SubjectID = " + SubjID + " AND sc.ScheduleID = " + schedID + " AND sc.UserID = " + mgUid + "";
            DataTable dats = db.SelectQuery(select);
            if (dats.Rows.Count.Equals(0)) return;
            string q = "SELECT DISTINCT sg.ClassID , s.FName , s.LName FROM tblsubjectclass sc INNER JOIN tblstudent s " +
                "ON sc.StudID = s.StudentID INNER JOIN tblstudentgrades sg " +
                "ON sg.ClassID = sc.ClassID WHERE  s.Status = 'Active' AND sc.SubjectID = " + SubjID + " AND sc.ScheduleID = " + schedID + "  AND sc.UserID = " + mgUid + " ORDER BY s.LName ";
            string classids;

            DataTable dt = db.SelectQuery(q);
            if (dt.Rows.Count.Equals(0)) return;
            foreach (DataRow ro in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(ro["ClassID"].ToString());
                itm.SubItems.Add(ro["FName"].ToString() + " " + ro["LName"].ToString());
                classids = ro["ClassID"].ToString();
                List<double> totalgrades = new List<double>();
                DataTable tab = db.SelectQuery("SELECT DISTINCT gd.CriteriaName FROM tblgradingdetails gd INNER JOIN tbltermgrading tg  " +
                    "ON gd.TermGradingID = tg.ID WHERE tg.SubjectID = " + SubjID + " AND tg.ScheduleID = " + schedID + " AND gd.Type = '" + cmbgradeperiod.Text + "' ORDER BY gd.Name ASC");
                foreach (DataRow row in tab.Rows)
                {
                    List<double> score = new List<double>();
                    score.Clear();
                    int count = 0;
                    double scores = 0;
                    double scoress = 0;
                    DataTable tbl = db.SelectQuery("SELECT * FROM tblstudentgrades WHERE ClassID = " + classids + " AND GradingName = '" + cmbgradeperiod.Text + "' AND CriteriaName = '" + row["CriteriaName"].ToString() + "' ORDER BY Name ASC");
                    foreach (DataRow r in tbl.Rows)
                    {
                        itm.SubItems.Add(r["Grade"].ToString());
                        score.Add(Convert.ToDouble(r["Grade"].ToString()));
                    }
                    for (int i = 0; i < score.Count; i++)
                    {
                        scores += score[i];
                        count++;
                    }
                    scoress = ((scores / count));
                    totalgrades.Add(scoress);
                    itm.SubItems.Add(Math.Round(scoress, 2).ToString() + "%");
                }
                itm.SubItems.Add(Math.Round(totalgrades.Sum(), 2).ToString() + "%");

                if (totalgrades.Sum() <= 75)
                    itm.SubItems.Add("FAILED");
                else if (totalgrades.Sum() >= 76)
                    itm.SubItems.Add("PASSED");
                lstViewing.Items.Add(itm);
                totalgrades.Clear();
            }
        }
        public void LoadGradingView()
        {
            lstViewing.Clear();
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + " ", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            string gpquery = "SELECT * FROM tblgnames g INNER JOIN tblgradingperiod gp " +
                             "ON g.GNID = gp.GNID WHERE gp.SubjectID = " + SubjID + "  AND g.UserID = " + mgUid + " " +
                             "ORDER BY g.GNID;";
            lstViewing.Columns.Add("ClassID");
            lstViewing.Columns.Add("Fullname");
            DataTable dt = db.SelectQuery(gpquery);
            foreach (DataRow r in dt.Rows)
            {
                lstViewing.Columns.Add(r["GradingName"].ToString());
            }
            lstViewing.Columns.Add("Total Grade");
            lstViewing.Columns.Add("Remarks");
        }
        public void LoadDataGradeView()
        {
            // lstViewing.Clear();
           // gnames1.Clear();
            if (cmbsubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            long gnid = db.GetID("SELECT GNID FROM tblgnames WHERE GradingName = '" + cmbgradeperiod.Text + "' AND UserID = " + mgUid + ";", "GNID");
            long gid = db.GetID("SELECT GID FROM tblgradingperiod WHERE GNID = " + gnid + " AND SubjectID = " + SubjID + "", "GID");
            string select = "SELECT * FROM tblstudentgrades sg INNER JOIN tblsubjectclass sc " +
                "ON sg.ClassID  = sc.ClassID WHERE sc.SubjectID = " + SubjID + " AND sc.ScheduleID = " + schedID + " AND sc.UserID = " + mgUid + "";
            DataTable dats = db.SelectQuery(select);
            if (dats.Rows.Count.Equals(0)) return;
            string q = "SELECT DISTINCT sg.ClassID , s.FName , s.LName FROM tblsubjectclass sc INNER JOIN tblstudent s " +
                "ON sc.StudID = s.StudentID INNER JOIN tblstudentgrades sg " +
                "ON sg.ClassID = sc.ClassID WHERE  s.Status = 'Active' AND sc.SubjectID = " + SubjID + " AND sc.ScheduleID = " + schedID + "  AND sc.UserID = " + mgUid + " ORDER BY s.LName ";
            string classids;

            DataTable dt = db.SelectQuery(q);
            if (dt.Rows.Count.Equals(0)) return;
            foreach (DataRow ro in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(ro["ClassID"].ToString());
                itm.SubItems.Add(ro["FName"].ToString() + " " + ro["LName"].ToString());
                classids = ro["ClassID"].ToString();
                List<double> totalgrades = new List<double>();
                DataTable tab = db.SelectQuery("SELECT DISTINCT gd.CriteriaName FROM tblgradingdetails gd INNER JOIN tbltermgrading tg  " +
                    "ON gd.TermGradingID = tg.ID WHERE tg.SubjectID = " + SubjID + " AND tg.ScheduleID = " + schedID + " AND gd.Type = 'Prelim' ORDER BY gd.Name ASC");
                foreach (DataRow row in tab.Rows)
                {
                    List<double> score = new List<double>();
                    score.Clear();
                    int count = 0;
                    double scores = 0;
                    double scoress = 0;
                    DataTable tbl = db.SelectQuery("SELECT * FROM tblstudentgrades WHERE ClassID = " + classids + " AND GradingName = 'Prelim' AND CriteriaName = '" + row["CriteriaName"].ToString() + "' ORDER BY Name ASC");
                    foreach (DataRow r in tbl.Rows)
                    {
                        score.Add(Convert.ToDouble(r["Grade"].ToString()));
                    }
                    for (int i = 0; i < score.Count; i++)
                    {
                        scores += score[i];
                        count++;
                    }
                    scoress = ((scores / count));
                    totalgrades.Add(scoress);
                }
                itm.SubItems.Add(Math.Round(totalgrades.Sum(), 2).ToString() + "%");
                List<double> totalgrades1 = new List<double>();
                DataTable tab1 = db.SelectQuery("SELECT DISTINCT gd.CriteriaName FROM tblgradingdetails gd INNER JOIN tbltermgrading tg  " +
                    "ON gd.TermGradingID = tg.ID WHERE tg.SubjectID = " + SubjID + " AND tg.ScheduleID = " + schedID + " AND gd.Type = 'Midterm' ORDER BY gd.Name ASC");
                foreach (DataRow row in tab1.Rows)
                {
                    List<double> score = new List<double>();
                    score.Clear();
                    int count = 0;
                    double scores = 0;
                    double scoress = 0;
                    DataTable tbl = db.SelectQuery("SELECT * FROM tblstudentgrades WHERE ClassID = " + classids + " AND GradingName = 'Midterm' AND CriteriaName = '" + row["CriteriaName"].ToString() + "' ORDER BY Name ASC");
                    foreach (DataRow r in tbl.Rows)
                    {
                        score.Add(Convert.ToDouble(r["Grade"].ToString()));
                    }
                    for (int i = 0; i < score.Count; i++)
                    {
                        scores += score[i];
                        count++;
                    }
                    scoress = ((scores / count));
                    totalgrades1.Add(scoress);
                }

                itm.SubItems.Add(Math.Round(totalgrades1.Sum(), 2).ToString() + "%");
                List<double> totalgrades2 = new List<double>();
                DataTable tab2 = db.SelectQuery("SELECT DISTINCT gd.CriteriaName FROM tblgradingdetails gd INNER JOIN tbltermgrading tg  " +
                    "ON gd.TermGradingID = tg.ID WHERE tg.SubjectID = " + SubjID + " AND tg.ScheduleID = " + schedID + " AND gd.Type = 'Finals' ORDER BY gd.Name ASC");
                foreach (DataRow row in tab2.Rows)
                {
                    List<double> score = new List<double>();
                    score.Clear();
                    int count = 0;
                    double scores = 0;
                    double scoress = 0;
                    DataTable tbl = db.SelectQuery("SELECT * FROM tblstudentgrades WHERE ClassID = " + classids + " AND GradingName = 'Finals' AND CriteriaName = '" + row["CriteriaName"].ToString() + "' ORDER BY Name ASC");
                    foreach (DataRow r in tbl.Rows)
                    {
                        score.Add(Convert.ToDouble(r["Grade"].ToString()));
                    }
                    for (int i = 0; i < score.Count; i++)
                    {
                        scores += score[i];
                        count++;
                    }
                    scoress = ((scores / count));
                    totalgrades2.Add(scoress);
                }

                itm.SubItems.Add(Math.Round(totalgrades2.Sum(), 2).ToString() + "%");
                itm.SubItems.Add(Math.Round((totalgrades.Sum() + totalgrades1.Sum() + totalgrades2.Sum()) / 3, 2).ToString() + "%");

                if (totalgrades.Sum() <= 75)
                    itm.SubItems.Add("FAILED");
                else if (totalgrades.Sum() >= 76)
                    itm.SubItems.Add("PASSED");
                lstViewing.Items.Add(itm);
            }

        }
        public void attendance()
        {
            if (cmbsubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            AttCount();
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            double att = 100;
            
            foreach (string s in classNum)
            {
                string query = "SELECT * FROM tblattendance WHERE TermName = '" + cmbgradeperiod.Text + "' AND ClassID = " + s + "";
                DataTable tb = db.SelectQuery(query);
                if (tb.Rows.Count != 0)
                {
                    string select = "SELECT Count(*) as 'Count' FROM tblattendance WHERE TermName = '" + cmbgradeperiod.Text + "' AND ClassID = " + s + " AND Remarks = 'Absent'";
                    DataTable dt = db.SelectQuery(select);
                    foreach (DataRow row in dt.Rows)
                    {
                        double per = Convert.ToDouble(lblper.Text);
                        string numatt = Convert.ToString(att - Convert.ToDouble(row["Count"].ToString()));
                        double rawScore = Math.Round(((Convert.ToDouble(numatt) / Convert.ToDouble(100)) * 50 + 50), 2);
                        double grade = Convert.ToDouble(rawScore * per);
                        string query1 = "UPDATE tblstudentgrades SET Score = " + numatt + "  ,  RawScore = " + rawScore + ", Grade = " + grade + " " +
                                                "WHERE ClassID = " + s + " AND Name = 'Attendance' AND GradingName = '"+cmbgradeperiod.Text+"';";
                        db.InsertQuery(query1);
                    } 
                }
                //else if (tb.Rows.Count == 0)
                //{
                //    MessageBox.Show("There is no attendance record yet for " + cmbgradeperiod.Text, "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }
        public void AttCount()
        {
            if (cmbsubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            long SubjID = db.GetID("SELECT SubjectID FROM tblsubject WHERE SubjectName  =  '" + cmbsubject.Text + "' AND UserID = " + mgUid + "", "SubjectID");
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            long schedID = db.GetID("SELECT ScheduleID FROM tblschedule WHERE SubjectID =" + SubjID + "  AND ScheduleDay = '" + day[0].Trim() + "' AND ScheduleTimeFrom = '" + time[0].Trim() + "' " +
                                    "AND ScheduleTimeTo = '" + time[1].Remove(0, 1) + "';", "ScheduleID");
            string q = "SELECT DISTINCT g.Percentage FROM tblgradingdetails g INNER JOIN tbltermgrading t " +
                       "ON g.TermgradingID = t.ID WHERE g.Type = '" + cmbgradeperiod.Text + "' AND Name = 'Attendance' AND SubjectID = " + SubjID + " AND ScheduleID = " + schedID + " ";
            DataTable tb1 = db.SelectQuery(q);
            foreach (DataRow r1 in tb1.Rows)
            {
                lblper.Text = r1["Percentage"].ToString();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintReportToExcel();
        }
    }
    class Subject
    {
        public string subjID;
        public string subjCode;
        public string subjName;
        public string subjUnits;
        public string uid;
        public string SchedID;
        public string schedTimeto;
        public string schedtimefrom;
        public string schedDay;

        public Subject(string si ,string sc, string sn, string su , string u , string sID, string timeto , string timefrom, string day)
        {
            this.subjID = si;
            this.subjCode = sc;
            this.subjName = sn;
            this.subjUnits = su;
            this.uid = u;
            this.SchedID = sID;
            this.schedTimeto = timeto;
            this.schedtimefrom = timefrom;
            this.schedDay = day;
        }
        public string SubjectID
        {
            get { return this.subjID; }
        }
        public string SubjectCode
        {
            get { return this.subjCode; }
        }
        public string SubjectName
        {
            get { return this.subjName; }
        }
        public string SubjectUnits
        {
            get { return this.subjUnits; }
        }
        public string UserID
        {
            get { return this.uid; }
        }
        public string ScheduleID
        {
            get { return this.SchedID; }
        }
        public string ScheduleTimeFrom
        {
            get { return this.schedtimefrom; }
        }
        public string ScheduleTimeTo
        {
            get { return this.schedTimeto; }
        }
        public string ScheduleDay
        {
            get { return this.schedDay; }
        }
    }
   
    class StudDetails
    {
        public string sName;
        public string sID;
        public string studNum;
        public string cID;
        public StudDetails(string sn, string si, string st, string c)
        {
            this.sName = sn;
            this.sID = si;
            this.studNum = st;
            this.cID = c;
        }
        public string StudentName
        {
            get { return this.sName; }
        }
        public string StudentID
        {
            get { return this.sID; }
        }
        public string StudentNumber
        {
            get { return this.studNum; }
        }
        public string ClassID
        {
            get { return this.cID; }
        }
    }
    class Criteria
    {
        public string CritName;
        public string percentage;
        public string tgID;
        public Criteria(string c, string p, string tg)
        {
            this.CritName = c;
            this.percentage = p;
            this.tgID = tg;
        }
        public string CriteriaName
        {
            get { return this.CritName; }
        }
        public string Percentage
        {
            get { return this.percentage; }
        }
        public string TgID
        {
            get { return this.tgID; } 
        }
    }
    class GradeDetails
    {
        public string GDID;
        public string termID;
        public string Name;
        public string percent;
        public string overScore;
        public string cName;
        public string type;
        public GradeDetails(string g, string t, string n, string p, string o, string c, string ty)
        {
            this.GDID = g;
            this.termID = t;
            this.Name = n;
            this.percent = p;
            this.overScore = o;
            this.cName = c;
            this.type = ty;
        }
        public string GradeID
        {
            get { return this.GDID; }
        }
        public string TermGradingID
        {
            get { return this.termID; }
        }
        public string critName
        {
            get { return this.Name; }
        }
        public string Percentage
        {
            get { return this.percent; }
        }
        public string OverScore
        {
            get { return this.overScore; }
        }
        public string CriteriaName 
        {
            get { return this.cName; }
        }
        public string Type
        {
            get { return this.type; }
        }

    }
    class StudentGrades
    {
        public string stID;
        public string clID;
        public string gID;
        public string gDetailsID;
        public string gName;
        public string cName;
        public string n;
        public string score;
        public string rawScore;
        public string overScore2;
        public string grade;
        public string percent;
        public StudentGrades(string s, string c, string g, string gd, string gn ,string cn, string na, string sc, string rs, string os ,string gr , string p)
        {
            this.stID = s;
            this.clID = c;
            this.gID = g;
            this.gDetailsID = gd;
            this.gName = gn;
            this.cName = cn;
            this.n = na;
            this.score = sc;
            this.rawScore = rs;
            this.overScore2 = os;
            this.grade = gr;
            this.percent = p;
        }
        public string StudentGradesID
        {
            get { return this.stID; }
        }
        public string ClassID
        {
            get { return this.clID; }
        }
        public string GID2
        {
            get { return this.gID; }
        }
        public string GradeDetailsID2
        {
            get { return this.gDetailsID; }
        }
        public string GradingName
        {
            get{return this.gName;}
        }
        public string CriteriaName2
        {
            get { return this.cName; }
        }
        public string Name2
        {
            get { return this.n; }
        }
        public string Score
        {
            get { return this.score; }
        }
        public string RawScore
        {
            get { return this.rawScore; }
        }
        public string OverScore2
        {
            get { return this.overScore2; }
        }
        public string Grade
        {
            get { return this.grade; }
        }
        public string percent2
        {
            get { return this.percent; }
        }
    }
}
