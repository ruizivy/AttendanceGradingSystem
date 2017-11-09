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

namespace AttendanceGradingSystem
{
    public partial class frmSetStudent : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        DataTable table;
        List<StudentDetails> students2;
        public static string userid;

        public frmSetStudent()
        {
            InitializeComponent();
            lblID.Visible = false;
            chkView.Visible = false;
            txtsearch.Enabled = false;
            students2 = new List<StudentDetails>();
            cmbfilter.SelectedItem = cmbfilter.Items[0];
        }

        private void frmSetStudentToSubjects_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            populateStudents();
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = "+userid+" ORDER BY SubjectName ASC;", cmbSubjects, "SubjectID", "SubjectName");
           
        }  
        public bool inputValidation(string val)
        {
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            string subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName  = '"+ cmbSubjects.Text + "' AND  UserID = "+userid+";", "SubjectID").ToString();
            string sch = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = "+subj+"  AND ScheduleDay = '"+day[0].ToString().Trim()+"' AND ScheduleTimeFrom = '"+time[0].ToString().Trim()+"' AND ScheduleTimeTo = '"+time[1].ToString().Remove(0,1)+"'", "ScheduleID").ToString();
            foreach (string i in students)
            {
                string query = "SELECT * FROM tblsubjectclass WHERE StudID = '" + i + "' AND ScheduleID = "+sch+" AND UserID = "+userid+";"+ val;
                DataTable table = db.SelectQuery(query);
                if (table.Rows.Count != 0)
                {
                    MessageBox.Show("Student name already exist", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RemoveAllCheckItems(lstStudents);
                    return false;
                }
            }
            if (cmbSchedule.Text.Equals("") || cmbSchedule.Text.Equals(null))
            {
                MessageBox.Show("Please Select Schedule of the subject", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void populateStudents()
        {
            lstStudents.Items.Clear();
            if (cmbSchedule.Text.Equals("") || cmbSubjects.Text.Equals("")) return;
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = " + userid + "", "SubjectID").ToString();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            students2 = new List<StudentDetails>();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string query = "SELECT * FROM tblstudent s INNER JOIN tblcourse c  " +
                                "ON s.CourseID = c.CourseID INNER JOIN tblsubjectclass sc " +
                                "ON s.StudentID = sc.StudID  INNER JOIN tblsubject su " +
                //"ON sc.SubjectID = su.SubjectID  INNER JOIN tblschedule sch "+
                //"ON sc.ScheduleID = sch.ScheduleID "+
                                "WHERE s.Status = 'Active' AND sc.UserID = " + userid + " AND sc.SubjectID NOT IN(" + subjid + ") AND sc.ScheduleID NOT IN(" + schedID + ") AND s.StudentID NOT IN(" + lblID.Text + ") " +//AND sc.SubjectID = " + subjid + " AND sc.ScheduleID = " + schedID + " " +
                                "GROUP BY sc.StudID ORDER BY s.LName ASC;";
            DataTable tbl = db.SelectQuery(query);
            foreach (DataRow row in tbl.Rows)
            {
                StudentDetails ss = new StudentDetails(row["StudNum"].ToString(), row["FName"].ToString() , row["LName"].ToString(), row["Section"].ToString(), row["Abbrv"].ToString(), row["StudentID"].ToString());
                students2.Add(ss);
            }
            DisplayStudents(students2);
        }
        private void DisplayStudents(List<StudentDetails> ss)
        {
            lstStudents.Items.Clear();
            foreach (StudentDetails ss2 in ss)
            {
                ListViewItem itm = new ListViewItem(ss2.StudentNumber2);
                itm.SubItems.Add(ss2.fName2 + " " + ss2.lName2);
                itm.SubItems.Add(ss2.Section);
                itm.SubItems.Add(ss2.Course2);
                itm.SubItems.Add(ss2.StudentID2);
                lstStudents.Items.Add(itm);
            }
        }
        public void PopulateStudentsInSubjects()
        {
            lstStudents.Items.Clear();
            if (cmbSchedule.Text.Equals("")) return;
            students2 = new List<StudentDetails>();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = " + userid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            DataTable table = db.SelectQuery("SELECT * FROM tblstudent s INNER JOIN tblcourse c " +
                    "ON s.CourseID = c.CourseID INNER JOIN tblsubjectclass sc " +
                    "ON sc.StudID = s.StudentID INNER JOIN tblsubject su " +
                    "ON s.Status = 'Active' AND su.SubjectID = sc.SubjectID WHERE sc.SubjectID = " + subjid + " AND sc.UserID = " + userid + " AND sc.ScheduleID = " + schedID + " ORDER BY LName;");
            foreach (DataRow row in table.Rows)
            {
                StudentDetails ss = new StudentDetails(row["StudNum"].ToString(), row["FName"].ToString(), row["LName"].ToString(), row["Section"].ToString(), row["Abbrv"].ToString(), row["StudentID"].ToString());
                students2.Add(ss);
            }
            DisplayStudents(students2);
        }
        public string filter()
        {
            string fil = "";
            if (cmbfilter.Text == "Student Number")
                fil += "s.StudNum";
            if (cmbfilter.Text == "Lastname")
                fil += "s.LName";
            if (cmbfilter.Text == "Firstname")
                fil += "s.FName";
            if (cmbfilter.Text == "Section")
                fil += "s.Section";
            if (cmbfilter.Text == "Course")
                fil += "c.Abbrv";

            return fil;
        }
        public void SearchStudent(string sKey , int index)
        {
            lstStudents.Items.Clear();
            try {
                switch (index)
                {
                    case 0 :
                        List<StudentDetails> ss = students2.Where(s => s.StudentNumber2.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudents(ss);
                        break;
                    case 1:
                        List<StudentDetails> ss2 = students2.Where(s => s.lastName.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudents(ss2);
                        break;
                    case 2:
                        List<StudentDetails> ss3 = students2.Where(s => s.firstName.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                         DisplayStudents(ss3);
                        break;
                    case 3 : 
                        List<StudentDetails> ss4 = students2.Where(s => s.Section.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                         DisplayStudents(ss4);
                        break;
                    case 4: 
                        List<StudentDetails> ss5 = students2.Where(s => s.Course2.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                         DisplayStudents(ss5);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void PopulateStudents1()
        {
            lstStudents.Items.Clear();
            if (cmbSchedule.Text.Equals("")) return;
            students2 = new List<StudentDetails>();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '"+ cmbSubjects.Text +"' AND UserID = "+userid+";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            DataTable table = db.SelectQuery("SELECT * FROM tblstudent s INNER JOIN tblcourse c  "+
                                "ON s.CourseID = c.CourseID INNER JOIN tblsubjectclass sc " +
                                "ON s.StudentID = sc.StudID "+
                                "WHERE sc.UserID = " + userid + " AND sc.SubjectID NOT IN(" + subjid + ") AND sc.ScheduleID NOT IN(" + schedID + ") AND s.StudentID NOT IN(" + lblID.Text + ") " +
                                "AND "+filter()+" LIKE '%"+txtsearch.Text+"%' AND s.Status = 'Active' "+
                                 "GROUP BY sc.StudID ORDER BY s.LName ASC;");
            foreach (DataRow row in table.Rows)
            {
                if (txtsearch.Text.Equals("") || txtsearch.Text.Equals(" ")) return;
                StudentDetails ss = new StudentDetails(row["StudNum"].ToString(), row["FName"].ToString(), row["LName"].ToString(), row["Section"].ToString(), row["Abbrv"].ToString(), row["StudentID"].ToString());
                students2.Add(ss);
            }
            DisplayStudents(students2);
        }
        private void lstSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void BindToComboBox(string query, ComboBox cmb , string key , string value)
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
        public static void RemoveAllCheckItems(ListView lst)
        {
            if (lst.Items.Count == 0) return;
            for (int i = 0; i < lst.Items.Count; i++)
            {
                try
                {
                    lst.Items[i].Checked = false;
                }
                catch (Exception ex) { }
            }
        }
        public static void SetAllItemToCheck(ListView lst)
        {
            if (lst.Items.Count == 0) return;
            for (int i = 0; i < lst.Items.Count; i++)
            {
                try
                {
                    lst.Items[i].Checked = true;
                }
                catch (Exception ex) { }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            txtsearch.ForeColor = Color.Black;
        }

        
        List<string> remStuds = new List<string>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to save the following selected items?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (inputValidation(""))
                    {
                        foreach (string s in students)
                        {
                            string[] day = cmbSchedule.Text.Split('|');
                            string[] time = day[1].ToString().Split('-');
                            string subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName  = '" + cmbSubjects.Text + "' AND UserID = "+userid+"; ", "SubjectID").ToString();
                            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subj + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
                            string user = userid;
                            string query = "INSERT INTO `attendance_db`.`tblsubjectclass` (`StudID`, `SubjectID`, `ScheduleID`, `UserID`) VALUES ('" + s + "', '" + subj + "', '" + schedID + "', " + userid + ");";
                            cmd = new MySqlCommand(query, db.OpenConnection());
                            cmd.ExecuteNonQuery();
                            db.CloseConnection();
                        }
                    }
                    MessageBox.Show("The following items was succesfully save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ids.Clear();
                    lblID.Text = "";
                    GetStudID();
                    for (int i = 0; i < ids.Count; i++)
                    {
                        lblID.Text += ids[i] + ",";
                    }
                    lblID.Text = lblID.Text.Substring(0, lblID.Text.Length - 1);
                    RemoveAllCheckItems(lstStudents);
                    populateStudents();
                }
            }
            else if (btnSave.Text == "Remove")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove the selected items?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    remStuds.Clear();
                    foreach (ListViewItem item in lstStudents.CheckedItems)
                    {
                        remStuds.Add(item.SubItems[4].Text);
                    }
                    foreach (string rm in remStuds)
                    {
                        string query1 = "DELETE FROM tblsubjectclass WHERE StudID =" + rm + ";";
                        db.InsertQuery(query1);
                    }
                    MessageBox.Show("The following items was succesfully remove from the list", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateStudentsInSubjects();
                    RemoveAllCheckItems(lstStudents);
                }
            }
        }
        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text.Equals("") || (txtsearch.Text.Equals(" ")))
            {
                txtsearch.Text = "Searchbox";
                txtsearch.ForeColor = Color.Gray;
            }
        }
        public void PopulateSched()
        {
            cmbSchedule.Items.Clear();
            string subjids = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = "+userid+"", "SubjectID").ToString();
            string query = "SELECT * FROM tblschedule WHERE SubjectID = " + subjids + ";";
            DataTable tbl = new DataTable();
            adptr = new MySqlDataAdapter(query, db.OpenConnection());
            adptr.Fill(tbl);
            db.CloseConnection();
            foreach (DataRow row in tbl.Rows)
            {
                cmbSchedule.Items.Add(row["ScheduleDay"].ToString() + " | " + row["ScheduleTimeFrom"].ToString() + " - " + row["ScheduleTimeTo"].ToString());
            }
        }
        private void cmbSubjects_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PopulateSched();
            lstStudents.Items.Clear();
            chkView.Visible = false;
        }
        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            ids.Clear();
            lblID.Text = "";
            GetStudID();
            for (int i = 0; i < ids.Count; i++)
            {
                    lblID.Text += ids[i] + ",";  
            }
            lblID.Text = lblID.Text.Substring(0, lblID.Text.Length - 1);
            chkView.Visible = true;
            populateStudents();
        }
        List<string> ids = new List<string>();
        public void GetStudID()
        {
            if (cmbSchedule.Text.Equals("") || cmbSubjects.Text.Equals("")) return;
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = "+userid+";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            DataTable table = db.SelectQuery("SELECT * FROM tblstudent s INNER JOIN tblcourse c " +
                    "ON s.CourseID = c.CourseID INNER JOIN tblsubjectclass sc " +
                    "ON sc.StudID = s.StudentID INNER JOIN tblsubject su " +
                    "ON su.SubjectID = sc.SubjectID WHERE s.Status = 'Active' AND sc.SubjectID = " + subjid + " AND sc.UserID = " + userid + " AND sc.ScheduleID = " + schedID + " ORDER BY LName;");
            foreach (DataRow r in table.Rows)
            {
                ids.Add(r["StudID"].ToString());
            }
            if (table.Rows.Count == 0)
            {
                ids.Add("0");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
           if (cmbSchedule.Text.Equals("") || cmbSubjects.Text.Equals("")) return;
            if (chkView.Checked == true)
            {
                PopulateStudentsInSubjects();
                btnSave.Text = "Remove";
            }
            else
            {
                populateStudents();
                btnSave.Text = "Save";
            }
        }
        List<string> students = new List<string>();
        private void lstStudents_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            students.Clear();
            foreach (ListViewItem itm in lstStudents.CheckedItems)
            {
                students.Add(itm.SubItems[4].Text);
            }
        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Enabled = true;
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbfilter.Text == "Student Number")
            {
                db.TextHandler(ref sender, ref e, true);
            }
            else
                db.TextBoxHander(ref sender, ref e);
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            lstStudents.Items.Clear();
            if (chkView.Checked == true)
            {
                SearchStudent(txtsearch.Text, cmbfilter.SelectedIndex);
            }
            else
                PopulateStudents1();
        }
    }
    class StudentDetails
    {
        public string sNum;
        public string fName2;
        public string lName2;
        public string sec;
        public string course;
        public string studID;
        public StudentDetails(string sn, string f, string l, string se, string c, string si)
        {
            this.sNum = sn;
            this.fName2 = f;
            this.lName2 = l;
            this.sec = se; 
            this.course = c;
            this.studID = si;
        }
        public string StudentNumber2
        {
            get { return this.sNum; }
        }
        public string firstName
        {
            get { return this.fName2; }
        }
        public string lastName
        {
            get { return this.lName2; }
        }
        public string Section
        {
            get { return this.sec; }
        }
        public string Course2
        {
            get { return this.course; }
        }
        public string StudentID2
        {
            get { return this.studID; }
        }
    }
}
