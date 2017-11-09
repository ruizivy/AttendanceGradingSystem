using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlDButilities;

namespace AttendanceGradingSystem
{
    public partial class frmSetEntryDays : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        DataTable table;
        public static string uid;
        public frmSetEntryDays()
        {
            InitializeComponent();
            btnsave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ResetDate();
           dtEnd.MinDate = dtStart.Value;
        }
        public void ResetDate()
        {
            dtStart.MinDate = Convert.ToDateTime("1/1/1753");
            dtStart.MaxDate = Convert.ToDateTime("12/31/9998");
            dtEnd.MinDate = Convert.ToDateTime("1/1/1753");
            dtEnd.MaxDate = Convert.ToDateTime("12/31/9998");
        }
        private void frmSetEntryDays_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = " + uid + " ORDER BY SubjectName ASC", cmbSubjects, "SubjectID", "SubjectName");
            //PopulateSchedule();
            //PopulateSubject();
        }
        public void PopulateSubject()
        {
            string query = "SELECT * FROM tblsubject WHERE UserID = " + uid + " ORDER BY SubjectName ASC";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow ro in dt.Rows)
            {
                cmbSubjects.Items.Add(ro["SubjectName"].ToString());
            }
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
        List<string> datedays = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {

        }
        public bool inputvalidation(string val)
        {
            string subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string[] sched = cmbSchedule.Text.Split('|');
            string[] time = sched[1].Split('-');
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE ScheduleDay ='" + sched[0].ToString().Trim() + "' AND ScheduleTimeFrom ='" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "' ;", "ScheduleID").ToString();
            for (int i = 0; i < lstDays.Items.Count; i++)
            {
                // MessageBox.Show(lstDays.Items[i].SubItems[0].Text);
                string query = "SELECT * FROM tblentrydays e " +
                    "WHERE SubjectID = " + subj + " AND ScheduleID = " + schedID + " AND UID = " + uid + " AND Term = '" + cmbGrading.Text + "' AND DateDays = '" + lstDays.Items[i].SubItems[0].Text + "' " +
                    "ORDER BY DateDays;";
                DataTable table = db.SelectQuery(query);
                if (table.Rows.Count != 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("There's already set entry days for this subject.. Do you want to overwrite?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Note that the existing schedule for the other grading period will be deleted.. Do you want to continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            OverWrite();
                            return false;
                        }
                    }
                    else
                        return false;
                }
            }
            for (int i = 0; i < lstDays.Items.Count; i++)
            {
                string query = "SELECT * FROM tblentrydays e " +
                   "WHERE SubjectID = " + subj + " AND ScheduleID = " + schedID + " AND UID = " + uid + "  AND DateDays = '" + lstDays.Items[i].SubItems[0].Text + "' " +
                   "ORDER BY DateDays;";
                DataTable table = db.SelectQuery(query);
                if (table.Rows.Count != 0)
                {
                    MessageBox.Show("The dates you've select was already in the other grading period. Please other dates",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            //if (dtStart.Value.TimeOfDay > dtEnd.Value.TimeOfDay)
            //{
            //    MessageBox.Show("Please select higher than the date start", "Warning",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            if (lstDays.Items.Count.Equals(0))
            {
                MessageBox.Show("Please set the start and end of school days", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbSchedule.Text.Equals("") || cmbSchedule.Text.Equals(null))
            {
                MessageBox.Show("Please Select Schedule of the Subject", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        public void PopulateSchedule()
        {
            cmbSchedule.Items.Clear();
            if (cmbSubjects.Text.Equals("")) return;
            string SubjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string query = "SELECT * FROM tblschedule WHERE SubjectID =" + SubjID + "";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                cmbSchedule.Items.Add(row["ScheduleDay"].ToString() + " | " + row["ScheduleTimeFrom"].ToString() + " - " + row["ScheduleTimeTo"].ToString());
            }
        }
        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSchedule();
            lstDays.Items.Clear();
            cmbGrading.Items.Clear();
        }
        public void populateEntryDays()
        {
            lstDays.Items.Clear();
            string subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string query = "SELECT * FROM tblentrydays WHERE SubjectID = " + subj + " AND Term = '" + cmbGrading.Text + "'";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                lstDays.Items.Add(row["DateDays"].ToString());
            }
        }
        List<string> gname = new List<string>();
        public void PopulateGrading()
        {
            ResetDate();
            cmbGrading.Items.Clear();
            string subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string gnames = "SELECT * FROM tblgnames g INNER JOIN tblgradingperiod gp " +
                "ON g.GNID = gp.GNID " +
                "WHERE gp.SubjectID = " + subj + "";
            DataTable tb = db.SelectQuery(gnames);

            foreach (DataRow row in tb.Rows)
            {
                cmbGrading.Items.Add(row["GradingName"].ToString());
                gname.Add(row["GradingName"].ToString());
            }
        }
        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            ResetDate();
            dtStart.MaxDate = dtEnd.Value;
        }
        public void populateDays()
        {
            lstDays.Items.Clear();
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            //string day = cmbSchedule.Text.Split('|')[0];
            string[] sched = cmbSchedule.Text.Split('|');
            string[] time = sched[1].Split('-');
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE ScheduleDay ='" + sched[0].ToString().Trim() + "' AND ScheduleTimeFrom ='" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "' ;", "ScheduleID").ToString();
            string query = "SELECT * FROM tblentrydays e " +
                           "WHERE e.SubjectID = " + subjid + " AND e.ScheduleID = " + schedID + " AND e.UID = " + uid + " AND e.Term = '" + cmbGrading.Text + "' " +
                           "ORDER BY e.ID;";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(row["DateDays"].ToString());
                
                string subjQuery = "SELECT * FROM tblsubject s INNER JOIN tblschedule sc " +
                    "ON s.SubjectID = sc.SubjectID WHERE s.SubjectID =" + subjid + " AND sc.ScheduleID = " + schedID + " AND s.UserID = " + uid + "";
                DataTable dta = db.SelectQuery(subjQuery);
                foreach (DataRow r in dta.Rows)
                {
                    itm.SubItems.Add(r["SubjectName"].ToString());
                    itm.SubItems.Add(r["ScheduleTimeFrom"].ToString() + " - " + r["ScheduleTimeTo"].ToString());
                }
                itm.SubItems.Add(row["ID"].ToString());
                lstDays.Items.Add(itm);
                // dtStart.Value = Convert.ToDateTime(row["DateDays"].ToString());              
            }
            try
            {
                if (dt.Rows.Count.Equals(0)) return;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        dtStart.Value = Convert.ToDateTime(dt.Rows[0]["DateDays"].ToString());
                        dtEnd.Value = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1]["DateDays"].ToString());
                        ResetDate();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Eto error oh :( " + ex.Message);
            }
        }

        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDays.Items.Clear();
            PopulateGrading();
            populateDays1();
            btnDelete.Enabled = true;
        }
        List<string> dates = new List<string>();
        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            lstDays.Items.Clear();
            dates.Clear();
            btnsave.Enabled = true;
            if (cmbSubjects.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            string days = cmbSchedule.Text.Split('|')[0].ToString();
            string time = cmbSchedule.Text.Split('|')[1].ToString();
            string[] individualDays = days.Split('-');
            //char[] delimiter = { ',', '[', ']' }; 
            //string id = cmbSubjects.SelectedValue.ToString().Split(delimiter)[0];
            DateTime dtSemStart = Convert.ToDateTime(dtStart.Value.ToShortDateString());
            DateTime dtSemEnd = Convert.ToDateTime(dtEnd.Value.ToShortDateString());

            int totalDays = Convert.ToInt32((dtSemEnd - dtSemStart).TotalDays.ToString());

            for (int i = 0; i < totalDays + 1; i++)
            {
                string dayName = dtSemStart.AddDays(i).DayOfWeek.ToString().Trim();
                foreach (string d in individualDays)
                {
                    if (d.Trim().Equals(dayName))
                    {
                        // lstDays.Items.Add(dtSemStart.AddDays(i).ToLongDateString());
                        ListViewItem itm = new ListViewItem(dtSemStart.AddDays(i).ToLongDateString());
                        itm.SubItems.Add(cmbSubjects.Text);
                        itm.SubItems.Add(time);
                        lstDays.Items.Add(itm);
                        dates.Add(itm.SubItems[0].Text);
                    }
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveDays();
            btnsave.Enabled = false;
        }
        public void SaveDays()
        {
            if (cmbSubjects.Text.Trim().Equals("") || cmbSchedule.Text.Trim().Equals("")) return;

            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            string subjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string sch = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjID + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            if (inputvalidation(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the following items?", "Save items", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    foreach (string d in dates)
                    {
                        string query = "INSERT INTO attendance_db.tblentrydays (DateDays,SubjectID, ScheduleID , UID ,Term ) VALUES ('" + d + "', " + subjID + ", " + sch + " , " + uid + " , '" + cmbGrading.Text + "')";
                        cmd = new MySqlCommand(query, db.OpenConnection());
                        cmd.ExecuteNonQuery();
                        db.CloseConnection();
                    }
                    MessageBox.Show("Entry of days was successfully saved", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstDays.Items.Clear();
                    dates.Clear();
                    //dtStart.Value = DateTime.Now;
                    //dtEnd.Value = DateTime.Now;
                    populateDays();
                }
            }
        }
        List<string> ids = new List<string>();
        List<string> dateover = new List<string>();
        List<string> dont = new List<string>(); 
        public void OverWrite()
        {
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            string subjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string sch = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjID + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();
            string query = "SELECT DISTINCT DateDays FROM tblentrydays e " +
               "WHERE e.SubjectID = " + subjID + " AND e.ScheduleID = " + sch + " AND e.UID = " + uid + " AND e.Term = '" + cmbGrading.Text + "' " +
               "ORDER BY e.ID;";
            int count = 0;
            DataTable tbl = db.SelectQuery(query);
            foreach (DataRow r in tbl.Rows)
                ids.Add(r["DateDays"].ToString());
            for (int j = 0; j < dates.Count; j++)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    if (dates[j] == ids[i])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    dateover.Add(dates[j]);
                }
                count = 0;
            }
            List<string> eid = new List<string>();
            foreach (string saved in dateover)
            {
                string que = "SELECT * FROM tblentrydays WHERE DateDays = '" + saved + "'";
                DataTable dt = db.SelectQuery(que);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow ro in dt.Rows)
                        eid.Add(ro["ID"].ToString());
                }
            }
            foreach (string e in eid)
            {
                string delete = "DELETE FROM tblentrydays WHERE ID = " + e + "";
                db.InsertQuery(delete);
            } 
            foreach (string savedate in dateover)
            {
                string query1 = "INSERT INTO attendance_db.tblentrydays (DateDays,SubjectID, ScheduleID , UID, Term) VALUES ('" + savedate + "', " + subjID + ", " + sch + " , " + uid + " , '" + cmbGrading.Text + "')";

                cmd = new MySqlCommand(query1, db.OpenConnection());
                cmd.ExecuteNonQuery();
                db.CloseConnection();
            }
            List<string> ei = new List<string>();
            string qu = "SELECT * FROM tblentrydays WHERE Term != '" + cmbGrading.Text + "'";
            DataTable dat = db.SelectQuery(qu);
            if (dat.Rows.Count != 0)
            {
                foreach (DataRow ro in dat.Rows)
                    ei.Add(ro["ID"].ToString());
            }
            foreach (string ie in ei)
            {
                string del = "DELETE FROM tblentrydays WHERE ID = " + ie + "";
                db.InsertQuery(del);
            }
            MessageBox.Show("Entry of days was successfully saved", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstDays.Items.Clear();
            dates.Clear();
            ids.Clear();
            dateover.Clear();
            populateDays();
            eid.Clear();
        }

        private void cmbGrading_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDate();
            dtStart.Enabled = true;
            lblstart.Enabled = true;
            populateDays();
            btnDelete.Enabled = false;
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            if (lstDays.Items.Count != 0)
            {
                ResetDate();
                dtStart.Value = Convert.ToDateTime(lstDays.Items[0].SubItems[0].Text);
                dtEnd.Value = Convert.ToDateTime(lstDays.Items[lstDays.Items.Count - 1].SubItems[0].Text);
            }
            else
                pop();
            //for (int i = 0; i < lstDays.Items.Count; i++)
            //{ 
            //}

        }
        public void pop()
        {
            ResetDate();
            string[] day = cmbSchedule.Text.Split('|');
            string[] time = day[1].Split('-');
            string subjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            string sch = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjID + "  AND ScheduleDay = '" + day[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID").ToString();

            //if (cmbGrading.Text == "Midterm")
            {
                string select = "SELECT * FROM tblentrydays WHERE SubjectID = " + subjID + " AND ScheduleID = " + sch + " AND UID = " + uid + " ORDER BY ID asc";
                DataTable dt = db.SelectQuery(select);
                // if (dt.Rows.Count.Equals(0) || dt.Rows.Count.Equals(1)) return;
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ResetDate();
                        //  MessageBox.Show(row["DateDays"].ToString());
                        dtStart.Value = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1]["DateDays"].ToString());
                        dtEnd.Value = Convert.ToDateTime(dtEnd.Value.AddDays(1));
                        dtStart.Value = dtStart.Value.AddDays(1);
                        lblstart.Enabled = false;
                        dtStart.Enabled = false;
                        // populateDays(); 
                    }
                }
            }
        }
        public void populateDays1()
        {
            lstDays.Items.Clear();
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = " + uid + "", "SubjectID").ToString();
            //string day = cmbSchedule.Text.Split('|')[0];
            string[] sched = cmbSchedule.Text.Split('|');
            string[] time = sched[1].Split('-');
            string schedID = db.GetID("SELECT * FROM tblschedule WHERE ScheduleDay ='" + sched[0].ToString().Trim() + "' AND ScheduleTimeFrom ='" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "' ;", "ScheduleID").ToString();
            string query = "SELECT * FROM tblentrydays e " +
                           "WHERE e.SubjectID = " + subjid + " AND e.ScheduleID = " + schedID + " AND e.UID = " + uid + " " +
                           "ORDER BY e.ID;";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(row["DateDays"].ToString());
               
                string subjQuery = "SELECT * FROM tblsubject s INNER JOIN tblschedule sc " +
                    "ON s.SubjectID = sc.SubjectID WHERE s.SubjectID =" + subjid + " AND sc.ScheduleID = " + schedID + " AND s.UserID = " + uid + "";
                DataTable dta = db.SelectQuery(subjQuery);
                foreach (DataRow r in dta.Rows)
                {
                    itm.SubItems.Add(r["SubjectName"].ToString());
                    itm.SubItems.Add(r["ScheduleTimeFrom"].ToString() + " - " + r["ScheduleTimeTo"].ToString());
                }
                itm.SubItems.Add(row["ID"].ToString());
                lstDays.Items.Add(itm);
                // dtStart.Value = Convert.ToDateTime(row["DateDays"].ToString());              
            }
            try
            {

                if (dt.Rows.Count.Equals(0)) return;
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                       
                        dtStart.Value = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1]["DateDays"].ToString());
                        // dtStart.Value = Convert.ToDateTime(dtStart.Value.AddDays(2));
                        dtEnd.Value = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1]["DateDays"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Eto error oh :( " + ex.Message);
            }
        }
        List<string> ids2 = new List<string>();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbSubjects.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to delete the set schedule days ?" + "\n" +
                "Note : All set schedule days will be deleted for "+ cmbSubjects.Text , "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                for (int i = 0; i < lstDays.Items.Count; i++)
                {
                    string delete = "DELETE FROM tblentrydays WHERE ID = " + lstDays.Items[i].SubItems[3].Text + "";
                    db.InsertQuery(delete);
                }
                MessageBox.Show("The set schedule days was successfully deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ids2.Clear();
                populateDays1();
            }
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            //ids2.Clear();
        }
    }
}
