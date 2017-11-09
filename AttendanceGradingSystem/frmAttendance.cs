using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySqlDButilities;

namespace AttendanceGradingSystem
{
    public partial class frmAttendance : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        DataTable table;
        public static string uid;
        List<StudentAttendance> studAtt;
        List<Student2> students;
        public frmAttendance()
        {
            table = new DataTable();
            InitializeComponent();
            cmd = new MySqlCommand();
            tpNow.Start();
            lblDateNow.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            lblTotalAbsent.Text = "";
            lblTotalpresent.Text = "";
            lblID.Visible = false;
            grpRemarks.Visible = false;
            rdbPresent.Checked = true;
            studAtt = new List<StudentAttendance>();
            students = new List<Student2>();
            cmbfilter.SelectedItem = cmbfilter.Items[0];
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = "+uid+" ORDER BY SubjectName ASC", cmbSubject, "SubjectID", "SubjectName");
            lblFname.Visible = false;
            lblLName.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Enabled = false;
        }
        private void btnClose1_Click(object sender, EventArgs e)
        {
            //if (DialogResult.Yes == MessageBox.Show("Are you sure ,you want to close this session?", "Close Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
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
        public void PopulateSched()
        {
            cmbSchedule.Items.Clear();
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubject.Text + "' AND UserID="+uid+" ", "SubjectID").ToString();
            string query = "SELECT * FROM tblschedule  WHERE SubjectID =" + subjid + ";";
            DataTable tbl = db.SelectQuery(query);
            foreach (DataRow row in tbl.Rows)
            {
                cmbSchedule.Items.Add(row["ScheduleDay"].ToString() + " | " + row["ScheduleTimeFrom"].ToString() + " - " + row["ScheduleTimeTo"].ToString());
            }
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSchedule.Items.Clear();
            cmbDates.Items.Clear();
            cmbGrading.Items.Clear();
            PopulateSched();
            lstStudent.Items.Clear();
            chkSelectAll.Visible = true;
            lblDate2.Visible = true;
            cmbDates.Visible = true;
        }
        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDates.Items.Clear();
            cmbGrading.Items.Clear();
            AttendanceRecord();
            PopulateGrading();
            PopulateAttendance();
            lblTotalAbsent.Visible = false;
            lblTotalpresent.Visible = false;
            chkSelectAll.Visible = true;
            lblDate2.Visible = true;
            cmbDates.Visible = true;
        }
        public void PopulateGrading()
        {
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            long subjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = " + uid + "", "SubjectID");
            string query = "SELECT DISTINCT GradingName FROM tblgradingperiod gp INNER JOIN tblgnames g " +
                "ON gp.GNID = g.GNID WHERE gp.SubjectID = " + subjID + " AND g.UserID = " + uid + "";
            DataTable tb = db.SelectQuery(query);
            foreach (DataRow row in tb.Rows)
            {
                cmbGrading.Items.Add(row["GradingName"].ToString());
            }
            cmbGrading.SelectedItem = cmbGrading.Items[0];
        }

        public void PopulateDates()
        {
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            cmbDates.Items.Clear();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = "+uid+";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string query = "SELECT * FROM tblentrydays WHERE SubjectID =" + subjid + " AND ScheduleID =" + schedID + " AND UID = " + uid + " AND Term = '"+cmbGrading.Text+"' GROUP BY DateDays ORDER BY ID ASC";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                cmbDates.Items.Add(r["DateDays"].ToString());
            }
           // cmbDates.SelectedItem = cmbDates.Items[0];
        }
        private void cmbDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDates.Items.Clear();
        }
        public void AttendanceRecord()
        {

            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("") || cmbDates.Text.Equals("")) return;
            lstStudent.Items.Clear();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            students = new List<Student2>();
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = " + uid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string query1 = "SELECT * FROM tblstudent s INNER JOIN tblsubjectclass c " +
                            "ON s.StudentID = c.StudID WHERE s.Status = 'Active' AND c.SubjectID =" + subjid + " AND c.ScheduleID = " + schedID + " AND c.UserID = " + uid + " ORDER BY s.LName ASC;";
            DataTable tbl = db.SelectQuery(query1);
            try
            {
                if (tbl.Rows.Count != 0)
                {
                    foreach (DataRow r in tbl.Rows)
                    {
                        Student2 s = new Student2(r["StudentID"].ToString(), r["StudNum"].ToString(), r["LName"].ToString(), r["FName"].ToString(), r["ClassID"].ToString() , r["Section"].ToString());
                        students.Add(s);
                        //ListViewItem itm = new ListViewItem(r["FName"].ToString() + " " + r["LName"].ToString());
                        //itm.SubItems.Add(r["Section"].ToString());
                        //itm.SubItems.Add(r["ClassID"].ToString());
                        //lstStudent.Items.Add(itm);
                    }
                }
            }
            catch (Exception ex)
            {
                //AttendanceRecord();
               // MessageBox.Show("No data..");
            }
            DisplayStudAttendance(students);
        }
        public void PopulateAttendance()
        {
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            lstStudent.Items.Clear();
            studAtt = new List<StudentAttendance>();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = "+uid+";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string query = "SELECT * FROM tblAttendance a INNER JOIN tblsubjectclass sc " +
                                "ON sc.ClassID = a.ClassID INNER JOIN tblstudent s " +
                                "ON sc.StudID = s.StudentID  WHERE s.Status = 'Active' AND sc.SubjectID = " + subjid + " AND sc.ScheduleID =" + schedID + " AND a.Date ='" + cmbDates.Text + "' AND sc.UserID = " + uid + " GROUP BY s.StudentID ORDER BY s.LName ASC;";// WHERE Date ='" + cmbDates.Text + "'";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                StudentAttendance st = new StudentAttendance(row["LName"].ToString(), row["FName"].ToString(), row["Section"].ToString(), row["ClassID"].ToString(),
                    row["Date"].ToString(), row["Time"].ToString(), row["Remarks"].ToString(), row["EntryDaysID"].ToString(), row["AttendanceID"].ToString() , row["TermName"].ToString());
                studAtt.Add(st);
            }

            string query2 = "SELECT * , Count('Remarks') as Present FROM tblAttendance a INNER JOIN tblsubjectclass sc " +
              "ON sc.ClassID = a.ClassID INNER JOIN tblstudent s " +
              "ON sc.StudID = s.StudentID WHERE Date ='" + cmbDates.Text + "' AND sc.UserID = " + uid + " AND Remarks = 'Present' AND TermName  = '"+cmbGrading.Text+"'";
            DataTable dt1 = db.SelectQuery(query2);
            foreach (DataRow r in dt1.Rows)
            {
                lblTotalpresent.Text = "Total Present: " + r["Present"].ToString();
            }
            string query3 = "SELECT * , Count('Remarks') as Absent FROM tblAttendance a INNER JOIN tblsubjectclass sc " +
              "ON sc.ClassID = a.ClassID INNER JOIN tblstudent s " +
              "ON sc.StudID = s.StudentID WHERE Date ='" + cmbDates.Text + "' AND sc.UserID = " + uid + " AND Remarks = 'Absent' AND TermName = '"+cmbGrading.Text+"'";
            DataTable dt2 = db.SelectQuery(query3);
            foreach (DataRow r in dt2.Rows)
            {
                lblTotalAbsent.Text = "Total Absent: " + r["Absent"].ToString();
            }
            lblTotalAbsent.Visible = true;
            lblTotalpresent.Visible = true;
            DisplayStudAtt(studAtt);
        }
        private void DisplayStudAtt(List<StudentAttendance> st)
        {
            lstStudent.Items.Clear();
            foreach (StudentAttendance s in st)
            {
                ListViewItem itm = new ListViewItem(s.Firstname + " " + s.Lastname);
                itm.SubItems.Add(s.Section);
                itm.SubItems.Add(s.ClassID);
                itm.SubItems.Add(s.Date);
                itm.SubItems.Add(s.Time);
                itm.SubItems.Add(s.Remarks);
                itm.SubItems.Add(s.EntryDaysID);
                itm.SubItems.Add(s.AttendanceID);
                itm.SubItems.Add(s.TermName);
                lstStudent.Items.Add(itm);
                itm.Checked = s.Remarks.Equals("Absent") ? false : true;
            }
            lblTotalpresent.Visible = true;
            lblTotalAbsent.Visible = true;
        }

        private void rdbCancel_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbCancel.Checked == true)
            //{
            //    rdbCancel.Visible = false;
            //    rdbUpdate.Visible = false;
            //}
        }

        private void rdbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            lstStudent.CheckBoxes = true;
        }

        List<string> classID = new List<string>();
        public void SaveAtt()
        {
            if (cmbSchedule.Text.Equals("") || cmbSubject.Text.Equals("")) return;
            classID.Clear();
            foreach (ListViewItem itm in lstStudent.CheckedItems)
                classID.Add(itm.SubItems[2].Text);
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = " + uid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string entryID = db.GetID("SELECT * FROM tblentrydays WHERE SubjectID =" + subjid + " AND ScheduleID = " + schedID + " AND UID =" + uid + ";", "ID").ToString();

            if (DialogResult.Yes == MessageBox.Show("Are you sure , you want sa save the following selected student(s)", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (InputValidation(""))
                {
                    foreach(string c in classID)
                    {
                        string query = "INSERT INTO tblattendance(Date , Time ,Remarks ,ClassID , EntryDaysID , TermName) " +
                                        "VALUES('" + cmbDates.Text + "' , '" + DateTime.Now.ToLongTimeString() + "', 'Present' ,  " + c + " , " + entryID + " , '"+cmbGrading.Text+"')";
                        db.InsertQuery(query); 
                    }
                    InsertAbsent();
                    MessageBox.Show("The following seleted student(s) was saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classID.Clear();
                    PopulateAttendance();
                    
                }
            }

        }
        List<string> AbsentID = new List<string>();
        public void InsertAbsent()
        {
            if (cmbSchedule.Text.Equals("") || cmbSubject.Text.Equals("")) return;
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = " + uid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string entryID = db.GetID("SELECT * FROM tblentrydays WHERE SubjectID =" + subjid + " AND ScheduleID = " + schedID + " AND UID =" + uid + ";", "ID").ToString();

            ////string query = "SELECT * FROM tblsubjectclass sc INNER JOIN tblstudent s " +
            ////    "ON sc.StudID = s.StudentID";
            ////DataTable dt = db.SelectQuery(query);
            ////List<string> ids = new List<string>();
            ////foreach (DataRow r in dt.Rows)
            ////    ids.Add(r["ClassID"].ToString());

            for (int i = 0 ; i < lstStudent.Items.Count;i++)
            {
                if(lstStudent.Items[i].Checked == false)
                {
                    AbsentID.Add(lstStudent.Items[i].SubItems[2].Text); 
                }
            }
            foreach (string a in AbsentID)
            {
                string query1 = "INSERT INTO tblattendance(Date , Time ,Remarks ,ClassID , EntryDaysID , TermName) " +
                              "VALUES('" + cmbDates.Text + "' , '" + DateTime.Now.ToLongTimeString() + "', 'Absent' ,  " + a + " , " + entryID + " , '"+cmbGrading.Text+"')";
                db.InsertQuery(query1);
            }
            AbsentID.Clear();
        }
        public bool InputValidation(string cons)
        {
            bool isClickButton = true;
            foreach (string ci in classID)
            {
                string[] day = cmbSchedule.Text.Split('|');
                string[] time = day[1].ToString().Split('-');
                string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = " + uid + ";", "SubjectID").ToString();
                string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
                long entryID = db.GetID("SELECT * FROM tblentrydays WHERE DateDays = '" + cmbDates.Text + "'", "ID");
                string query = "SELECT * FROM tblattendance WHERE  ClassID = " + ci + " AND Date = '" + cmbDates.Text + "'  "; //AND  EntryDaysID = " + entryID + "";
                DataTable dt = db.SelectQuery(query);
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("The student you select has already record. Please check the student you selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    classID.Clear();
                    AbsentID.Clear();
                    PopulateAttendance();
                    grpRemarks.Visible = true;
                    return false;
                }
            }
             if (cmbDates.Text.Equals(""))
            {
                MessageBox.Show("Please select schedule day", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                classID.Clear();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < classID.Count; i++)
            {
                lblID.Text += classID[i] + ",";
            }
            lblID.Text = lblID.Text.Substring(0, lblID.Text.Length - 1);
           SaveAtt();
        }
        List<string> AttID = new List<string>();
        public void UpdateRemarks()
        {
            AttID.Clear();
            foreach (ListViewItem itm in lstStudent.CheckedItems)
            {
                AttID.Add(itm.SubItems[8].Text);
            }
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = " + uid + ";", "SubjectID").ToString();
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string entryID = db.GetID("SELECT * FROM tblentrydays WHERE SubjectID =" + subjid + " AND ScheduleID = " + schedID + " AND UID =" + uid + ";", "ID").ToString();


            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want save the following selected items?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (string attend in AttID)
                {
                    string query = "UPDATE tblattendance SET Remarks = '"+StatRemarks()+"'  , Time  = '"+DateTime.Now.ToLongTimeString()+"' WHERE AttendanceID = "+attend+";";
                    cmd = new MySqlCommand(query, db.OpenConnection());
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                }
                MessageBox.Show("Selected records update successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.RemoveAllCheckItems(lstStudent);
                AttID.Clear();
                btnSave.Enabled = true;
                PopulateAttendance();
            }
        }
        public string StatRemarks()
        {
            string rdbText = "";
            if (rdbAbsent.Checked == true)
                rdbText += "Absent";
            if (rdbPresent.Checked == true)
                rdbText += "Present";
            if (rdbLate.Checked == true)
                rdbText += "Late";
            if (rdbExcuse.Checked == true)
                rdbText += "Excuse";
            if (rdbNoClass.Checked == true)
                rdbText += "No Class";

                return rdbText;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void Search(string sKey , int index)
        {
            if (cmbSchedule.Text.Equals("") || cmbSubject.Text.Equals("") || cmbDates.Text.Equals("") || cmbGrading.Text.Equals("") || cmbfilter.Text.Equals("")) return;

            try
            {       
                switch (index)
                {
                    case 0:
                        List<Student2> st = students.Where(s => s.Lastname1.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAttendance(st);
                        break;
                    case 1:
                        List<Student2> st1 = students.Where(s => s.Firstname1.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAttendance(st1);
                        break;
                    case 2:
                        List<Student2> st2 = students.Where(s => s.Section1.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAttendance(st2);
                        break; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (txtSearch.Text == "" || txtSearch.Text == " ")
            {
                PopulateAttendance();
            }
        }
        private void DisplayStudAttendance(List<Student2> st)
        {
            lstStudent.Items.Clear();
            foreach (Student2 s in st)
            {
                ListViewItem itm = new ListViewItem(s.Firstname1 + " " + s.Lastname1);
                itm.SubItems.Add(s.Section1);
                itm.SubItems.Add(s.ClassID1);
                lstStudent.Items.Add(itm);
            }
            lblTotalAbsent.Visible = false;
            lblTotalpresent.Visible = false;
        }
        public void Searching(string sKey , int index)
        {
            if (cmbSchedule.Text.Equals("") || cmbSubject.Text.Equals("") || cmbGrading.Text.Equals("") || cmbDates.Text.Equals("") || cmbfilter.Text.Equals("")) return;
            try {
                switch (index)
                {
                    case 0:
                        List<StudentAttendance> st = studAtt.Where(s => s.Lastname.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAtt(st);
                        break;
                    case 1:
                        List<StudentAttendance> st1 = studAtt.Where(s => s.Firstname.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAtt(st1);
                        break;
                    case 2:
                        List<StudentAttendance> st2 = studAtt.Where(s => s.Section.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAtt(st2);
                        break;
                    case 3:
                        List<StudentAttendance> st3 = studAtt.Where(s => s.Date.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAtt(st3);
                        break;
                    case 4:
                        List<StudentAttendance> st4 = studAtt.Where(s => s.Time.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAtt(st4);
                        break;
                    case 5:
                        List<StudentAttendance> st5 = studAtt.Where(s => s.Remarks.ToLower().Contains(sKey.ToLower())).Select(s => s).ToList();
                        DisplayStudAtt(st5);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
                lstStudent.Items.Clear();
                //StudentsAtt();
        }

        private void cmbDates_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToLongDateString();
            string date = now.Split(',')[1].ToString().Trim();
            if (cmbDates.Text == now)
            {
                if(grpRemarks.Visible == false)
                    btnSave.Enabled = true;
            }
            else
                btnSave.Enabled = false;

            try
            {
                string select = "SELECT * FROM tblattendance a INNER JOIN tblsubjectclass sc " + 
                    "ON a.ClassID  = sc.ClassID WHERE Date = '" + cmbDates.Text + "' AND TermName = '" + cmbGrading.Text + "' AND sc.UserID = "+uid+"";
                DataTable tb = db.SelectQuery(select);
                if (tb.Rows.Count != 0)
                {
                    PopulateAttendance();
                    lblTotalAbsent.Visible = true;
                    lblTotalpresent.Visible = true;
                    grpRemarks.Visible = true;
                    btnCancel.Visible = true;
                    btnUpdate.Visible = true;
                    btnSave.Enabled = false;
                }
                else
                {
                    AttendanceRecord();
                    grpRemarks.Visible = false;
                    btnCancel.Visible = false;
                    btnUpdate.Visible = false;
                    lblTotalAbsent.Visible = false;
                    lblTotalpresent.Visible = false;
                  //  btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                AttendanceRecord();
            }
        }
        private void lstStudent_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //chkSelectAll.Checked = false;
            //for (int i = 0; i < lstStudent.Items.Count; i++)
            //{
            //    if (lstStudent.Items[i].Checked == false)
            //    {
            //        chkSelectAll.Checked = false;
                   
            //    }
            //}
        }

        private void tpNow_Tick(object sender, EventArgs e)
        {
            tpNow.Start();
            lblDateNow.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //grpRemarks.Visible = false;
            //btnSave.Enabled = true;
            //btnCancel.Visible = false;
            //AttID.Clear();
            //db.RemoveAllCheckItems(lstStudent);
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkSelectAll.Checked == true)
            {
                db.SetAllItemToCheck(lstStudent);
               
            }
            else
                db.RemoveAllCheckItems(lstStudent);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            grpRemarks.Visible = true;
            btnCancel.Visible = true;
            btnSave.Enabled = false;
            UpdateRemarks();
        }

        private void cmbGrading_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDates.Items.Clear();
            PopulateDates();
            lstStudent.Items.Clear();
            grpRemarks.Visible = false;
            lblTotalpresent.Visible = false;
            lblTotalAbsent.Visible = false;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextBoxHander(ref sender, ref e);
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string select = "SELECT * FROM tblattendance a INNER JOIN tblsubjectclass sc " + 
                " ON a.ClassID  = sc.ClassID WHERE Date = '" + cmbDates.Text + "' AND TermName = '" + cmbGrading.Text + "' AND sc.UserID = " + uid + "";
            DataTable tb = db.SelectQuery(select);
            if (tb.Rows.Count != 0)
            {
                Searching(txtSearch.Text, cmbfilter.SelectedIndex);
            }
            else
            {
                Search(txtSearch.Text, cmbfilter.SelectedIndex);
            }

            if (lstStudent.Items.Count == 0)
            {
                lblTotalAbsent.Visible = false;
                lblTotalpresent.Visible = false;
            }
        }
    }
    class Student2
    {
        public string studID1;
        public string studNum2;
        public string studLname;
        public string studFname;
        public string studclassID;
        public string studSection;

        public Student2(string s, string n, string l, string f, string c , string s1)
        {
            this.studID1 = s;
            this.studNum2 = n;
            this.studLname = l;
            this.studFname = f;
            this.studclassID = c;
            this.studSection = s1;
        }
        public string StudentID1
        {
            get { return this.studID1; }
        }
        public string StudentNumber2
        {
            get { return this.studNum2; }
        }
        public string Lastname1
        {
            get { return this.studLname; }
        }
        public string Firstname1
        {
            get { return this.studFname; }
        }
        public string ClassID1
        {
            get { return this.studclassID; }
        }
        public string Section1
        {
            get { return this.studSection; }
        }
    }
    class StudentAttendance
    {
        public string lName;
        public string fName;
        public string section;
        public string cID;
        public string date;
        public string time;
        public string remark;
        public string entryID;
        public string attendanceID;
        public string termName;

        public StudentAttendance(string l, string f, string s, string c, string d, string t, string r, string e, string a, string tn)
        {
            this.lName = l;
            this.fName = f;
            this.section = s;
            this.cID = c;
            this.date = d;
            this.time = t;
            this.remark = r;
            this.entryID = e;
            this.attendanceID = a;
            this.termName = tn;
        }
        public string Lastname
        {
            get { return this.lName; }
        }
        public string Firstname
        {
            get { return this.fName; }
        }
        public string Section
        {
            get { return this.section; }
        }
        public string ClassID
        {
            get { return this.cID; }
        }
        public string Date
        {
            get { return this.date; }
        }
        public string Time
        {
            get { return this.time; }
        }
        public string Remarks
        {
            get { return this.remark; }
        }
        public string EntryDaysID
        {
            get { return this.entryID; }
        }
        public string AttendanceID
        {
            get { return this.attendanceID; }
        }
        public string TermName
        {
            get { return this.termName; }
        }
            
 
    }
}
