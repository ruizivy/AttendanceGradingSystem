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
    public partial class frmTermsCriteria : Form
    {
        DataTable table;
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        public static string userid;
        Dictionary<string, bool> idIsChecked = new Dictionary<string, bool>();
        Dictionary<string, bool> idIsChecked1 = new Dictionary<string, bool>();
        public frmTermsCriteria()
        {
            InitializeComponent();
            table = new DataTable();
        }

        private void lstcriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmTermsCriteria_Load(object sender, EventArgs e)
        {
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = "+userid+" ORDER BY SubjectName ASC", cmbSubject, "SubjectID", "SubjectName");
            PopulateCriteria();
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

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSchedule();
            PopulateGrading();
            PopulateSetGrading();
            db.RemoveAllCheckItems(lstcriteria);
            db.RemoveAllCheckItems(lstTerms);
        }
        public void PopulateSchedule()
        {
            cmbSchedule.Items.Clear();
            string SubjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubject.Text + "' AND UserID = "+userid+"", "SubjectID").ToString();
            string query = "SELECT * FROM tblschedule WHERE SubjectID =" + SubjID + "";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                cmbSchedule.Items.Add(row["ScheduleDay"].ToString() + " | " + row["ScheduleTimeFrom"].ToString() + " - " + row["ScheduleTimeTo"].ToString());
            }
        }
        public void PopulateGrading()
        {
            lstTerms.Items.Clear();
            string SubjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubject.Text + "' AND UserID = "+userid+"", "SubjectID").ToString();
            string query = "SELECT * FROM tblgnames g INNER JOIN tblgradingperiod p "+
                            "ON g.GNID = p.GNID "+ 
                            "WHERE p.SubjectID = "+SubjID+" AND g.UserID = "+userid+" ";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(row["GradingName"].ToString());
                itm.SubItems.Add(row["GNID"].ToString());
                itm.SubItems.Add(row["GID"].ToString());
                itm.SubItems.Add(row["UserID"].ToString());
                lstTerms.Items.Add(itm);
            }
        }
        public void PopulateCriteria()
        {
            lstcriteria.Items.Clear();
            string query = "SELECT * FROM tblcriteria WHERE UserID = "+userid+" AND Active = 1";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(row["CriteriaName"].ToString());
                itm.SubItems.Add(row["Percentage"].ToString());
                itm.SubItems.Add(row["UserID"].ToString());
                itm.SubItems.Add(row["CriteriaID"].ToString());
                lstcriteria.Items.Add(itm);
            }
        }
        List<string> gradeID = new List<string>();
        List<string> criteriaID = new List<string>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            gradeID.Clear();
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            foreach (ListViewItem itm in lstTerms.CheckedItems)
            {
                gradeID.Add(itm.SubItems[2].Text);
            }
            criteriaID.Clear();
            foreach (ListViewItem itms in lstcriteria.CheckedItems)
            {
                criteriaID.Add(itms.SubItems[3].Text);
            }
            string[] days = cmbSchedule.Text.Split('|');
            string[] time = days[1].ToString().Split('-'); 
            long subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = "+userid+";", "SubjectID");
            long schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subj + "  AND ScheduleDay = '" + days[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID");
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the following items?", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (validation(""))
                {
                    foreach (string g in gradeID)
                    {
                        foreach (string c in criteriaID)
                        {
                                    string query = "INSERT INTO tbltermgrading(GID , CriteriaID , ScheduleID , SubjectID) VALUES(" + g + ", " + c + " , " + schedID + " , "+subj+")";
                                    cmd = new MySqlCommand(query, db.OpenConnection());
                                    cmd.ExecuteNonQuery();
                                    db.CloseConnection();
                        }
                    }
                    MessageBox.Show("The following items selected was successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.RemoveAllCheckItems(lstTerms);
                    db.RemoveAllCheckItems(lstcriteria);
                }
                gradeID.Clear();
                criteriaID.Clear();
            }
        } 
        public bool validation(string cons)
        {
 
            double total = 0;
            foreach (string g in gradeID)
            {
                foreach (string c in criteriaID)
                {
                    string[] days = cmbSchedule.Text.Split('|');
                    string[] time = days[1].ToString().Split('-');
                    long gid1 = db.GetID("SELECT * FROM tblgradingperiod WHERE GNID =" + g + "", "GID");
                    long subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = "+userid+";", "SubjectID");
                    long schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subj + "  AND ScheduleDay = '" + days[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID");
                    string query = "SELECT * FROM tbltermgrading t INNER JOIN tblgradingperiod g ON t.GID = g.GID WHERE g.SubjectID = " + subj + " AND t.GID = " + gid1 + " AND t.CriteriaID = " + c + " AND ScheduleID =" + schedID + ";" + cons;
                    DataTable dt = db.SelectQuery(query);
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("There is already set criteria for this period...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        db.RemoveAllCheckItems(lstcriteria);
                        db.RemoveAllCheckItems(lstTerms);
                        gradeID.Clear();
                        criteriaID.Clear();
                        return false;
                    }
                }
            }
            if (lstcriteria.CheckedItems.Equals(false) || lstTerms.CheckedItems.Equals(false))
            {
                MessageBox.Show("Please select grading period and criteria..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                for (int i = 0; i < lstcriteria.Items.Count; i++)
                {
                    if (lstcriteria.Items[i].Checked)
                    {
                        total += Convert.ToDouble(lstcriteria.Items[i].SubItems[1].Text);
                    }
                }
            if (total != 100.00)
            {
                MessageBox.Show("The total value of all criteria percentage must be 100%.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
                return true;
        }
        private void chkView_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        public bool IsSelected()
        {
            try
            {
                int index = lstTerms.SelectedIndices[0];
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please select");
                return false;
            }
        }
        public void PopulateSetCriteria()
        {
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
            lstcriteria.Items.Clear();
            if (IsSelected())
            {
                long gnid = db.GetID("SELECT * FROM tblgnames WHERE GradingName ='" + lstTerms.SelectedItems[0].SubItems[0].Text + "' AND UserID = "+userid+"", "GNID");
                long gid = Convert.ToInt32(lstTerms.SelectedItems[0].SubItems[2].Text);
                string[] days = cmbSchedule.Text.Split('|');
                string[] time = days[1].ToString().Split('-');
                long subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubject.Text + "' AND UserID = "+userid+";", "SubjectID");
                long schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + days[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID");
               // long gid = db.GetID("SELECT * FROM tblgradingdetails WHERE GNID ="+gnid+" AND SubjectID = "+subjid+";" , "GID" );
                string query = "SELECT * FROM tblcriteria c INNER JOIN tbltermgrading tg " +
                                "ON c.CriteriaID = tg.CriteriaID " +
                                "WHERE SubjectID ="+subjid+" AND  ScheduleID = "+schedID+" AND GID = "+gid+" AND UserID = "+userid+";";
                DataTable dt = db.SelectQuery(query);
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem itm = new ListViewItem(row["CriteriaName"].ToString());
                        itm.SubItems.Add(row["Percentage"].ToString());
                        itm.SubItems.Add(row["UserID"].ToString());
                        itm.SubItems.Add(row["CriteriaID"].ToString());
                        lstcriteria.Items.Add(itm);
                        db.SetAllItemToCheck(lstcriteria);
                    }
                }
                else if (dt.Rows.Count == 0)
                {
                  PopulateCriteria();
                }
                    
            }
        }

        private void lstTerms_Click(object sender, EventArgs e)
        {
            if (cmbSubject.Text.Equals("") || cmbSchedule.Text.Equals("")) return;
             PopulateSetCriteria();
        }

        private void cmbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCriteria();
        }
        public void PopulateSetGrading()
        {
            if (cmbSchedule.Text.Equals("") || cmbSubject.Text.Equals("")) return;
            lstTerms.Items.Clear();
            string[] days = cmbSchedule.Text.Split('|');
            string[] time = days[1].ToString().Split('-');
            string subjid = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbSubject.Text + "' AND UserID = "+userid+"", "SubjectID").ToString();
            long schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjid + "  AND ScheduleDay = '" + days[0].ToString().Trim() + "' AND ScheduleTimeFrom = '" + time[0].ToString().Trim() + "' AND ScheduleTimeTo = '" + time[1].ToString().Remove(0, 1) + "'", "ScheduleID");
            string query = "SELECT * FROM tbltermgrading t INNER JOIN tblgradingperiod gd " +
                            "ON t.GID = gd.GID INNER JOIN tblgnames g " +
                            "gd.GNID = g.GNID " +
                            "WHERE gd.SubjectID = "+ subjid +" AND t.ScheduleID = "+schedID+" AND g.UserID = "+userid+"" +
                            "GROUP BY g.GradingName;";
            DataTable dt = db.SelectQuery(query);
            try
            {
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem itm = new ListViewItem(row["GradingName"].ToString());
                        itm.SubItems.Add(row["GNID"].ToString());
                        itm.SubItems.Add(row["GID"].ToString());
                        lstTerms.Items.Add(itm);
                        db.SetAllItemToCheck(lstTerms);
                    }
                }
            }
            catch (Exception ex)
            {
                PopulateGrading();
            }
        }

        private void lstTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstTerms_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lstTerms_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem itm in lstTerms.CheckedItems)
                lstTerms.CheckBoxes = true;
            PopulateCriteria();
        }

        private void lstcriteria_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem item in lstcriteria.CheckedItems)
                lstcriteria.CheckBoxes = true;
        }
    }
}
