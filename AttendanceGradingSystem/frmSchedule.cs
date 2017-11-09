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
    public partial class frmSchedule : Form
    {
        MyUtilities db = new MyUtilities();
        InteractionAddOns add = new InteractionAddOns();
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        DataTable table;

        public static string userid1;
        public static long subjID;
        public long schedID;
        public static long subjectID;

        public frmSchedule()
        {
            InitializeComponent();
            table = new DataTable();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = "+userid1+" ORDER BY SubjectName ASC", ref cmbsubject);
           // grpSchedule.Enabled = false;  
            this.MouseDown += new MouseEventHandler(frmSchedule_MouseDown);
            this.MouseMove += new MouseEventHandler(frmSchedule_MouseMove);
            this.MouseUp += new MouseEventHandler(frmSchedule_MouseUp);
           // PopulateSubject();
        }
        public void PopulateSubject()
        {
            string query = "SELECT * FROM tblsubject WHERE UserID = " + userid1 + " ORDER BY SubjectName ASC";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                cmbsubject.Items.Add(row["SubjectName"].ToString());
            }
        }
        private void BindToComboBox(string query, ref ComboBox cmb)
        {
            table.Clear();
            cmb.Items.Clear();
            Dictionary<string, string> d = new Dictionary<string, string>();
            MySqlDataAdapter adpter = new MySqlDataAdapter(query, db.OpenConnection());
            adpter.Fill(table);
            db.CloseConnection();
            foreach (DataRow row in table.Rows)
            {
                d.Add(row["SubjectID"].ToString(), row["SubjectName"].ToString());
            }

            if (d.Count > 0)
            {
                cmb.DataSource = new BindingSource(d, null);
                cmb.ValueMember = "key";
                cmb.DisplayMember = "value";
            }
        }

        private void cmbsubject_TextChanged(object sender, EventArgs e)
        {
            if (cmbsubject.Text != "")
                grpSchedule.Enabled = true;
            else if (cmbsubject.Text == "")
                grpSchedule.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to save the following? ", "Saved Schedule!!",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (isAllInputValid(""))
                    {
                        SaveSchedule();
                    }
                }
            }
            else if (btnSave.Text == "Update")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure, you want update schedule?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    UpdateSched();
                    btnSave.Text = "Save";
                    populateSched();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  db.TextHandler(ref sender, ref e, true);
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.' && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public bool isAllInputValid(string cons)
        {
            string subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName ='" + cmbsubject.Text + "' AND UserID = "+userid1+"", "SubjectID").ToString();
            bool isNoCheckboxChecked = true;
            string query = "SELECT * FROM tblschedule WHERE SubjectID = " + subj +" AND ScheduleTimeFrom = '" +dtpTimeStart.Text+"' AND ScheduleTimeTo = '"+dtpTimeEnd.Text+"'" + cons;
            DataTable table = db.SelectQuery(query);
            if (table.Rows.Count != 0)
            {
                MessageBox.Show("There's already set schedule for this subject!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtroom.Text.Equals("")|| dtpTimeStart.Text.Equals("") || dtpTimeEnd.Text.Equals(""))
            {
                MessageBox.Show("Please complete the requirements!!", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    if ((c as CheckBox).Checked)
                        isNoCheckboxChecked = false;
                }
            }
            if (isNoCheckboxChecked == false)
            {
                MessageBox.Show("Please select day(s)", "Warning" ,MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return false;
            }
            if (statusCheckBox().Length.Equals(0))
            {
                MessageBox.Show("Please select day(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public void Clear()
        {
            txtroom.Text = "";
            chkmon.Checked = false;
            chktue.Checked = false;
            chkwed.Checked = false;
            chkthu.Checked = false;
            chkfri.Checked = false;
            chksat.Checked = false;
            chksun.Checked = false;
        }

        public void SaveSchedule()
        {
            subjectID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbsubject.Text + "' AND UserID = "+userid1+"", "SubjectID");

            cmd = new MySqlCommand("insert_schedule", db.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?timestart", dtpTimeStart.Text));
            cmd.Parameters.Add(new MySqlParameter("?timeend", dtpTimeEnd.Text));
            cmd.Parameters.Add(new MySqlParameter("?stype", "Insert"));
            cmd.Parameters.Add(new MySqlParameter("?daysched", statusCheckBox().Substring(0, statusCheckBox().Length-1)));
            cmd.Parameters.Add(new MySqlParameter("?schedroom", txtroom.Text.ToUpper()));
            cmd.Parameters.Add(new MySqlParameter("?subjid", subjectID));
            cmd.Parameters.Add(new MySqlParameter("?schedID", schedID));
            cmd.ExecuteNonQuery();

            MessageBox.Show("The following details was successfully save!!" , "Save Schedule" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            db.CloseConnection();
        }
        public void UpdateSched()
        {
            long subj = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbsubject.Text + "' AND UserID = " + userid1 + "", "SubjectID");
          //  long sched = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjectID + " AND ScheduleTimeFrom  = '" + dtpTimeStart.Text + "' AND ScheduleTimeTo = '" + dtpTimeEnd.Text + "' ", "ScheduleID");

            cmd = new MySqlCommand("insert_schedule", db.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?timestart", dtpTimeStart.Text));
            cmd.Parameters.Add(new MySqlParameter("?timeend", dtpTimeEnd.Text));
            cmd.Parameters.Add(new MySqlParameter("?stype", "Update"));
            cmd.Parameters.Add(new MySqlParameter("?daysched", statusCheckBox().Substring(0, statusCheckBox().Length - 1)));
            cmd.Parameters.Add(new MySqlParameter("?schedroom", txtroom.Text.ToUpper()));
            cmd.Parameters.Add(new MySqlParameter("?subjid", subj));
            cmd.Parameters.Add(new MySqlParameter("?schedID", schedID));
            cmd.ExecuteNonQuery();
            //string update = "UPDATE tblschedule SET ScheduleTimeFrom = '" + dtpTimeStart.Text + "' , ScheduleTimeTo = '" + dtpTimeEnd.Text + "' , " +
            //    "ScheduleDay = '" + statusCheckBox().Substring(0, statusCheckBox().Length - 1) + "' , ScheduleRoom = '" + txtroom.Text.ToUpper() + "' WHERE ScheduleID = " + schedID + "";
            //db.InsertQuery(update);

            MessageBox.Show("The following details was successfully updated!!", "Update Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            db.CloseConnection();
        }
        public bool IsSubjectValid(string cons)
        {
            return true;
        }
        public string statusCheckBox()
        {
                string checkboxesText = "";
                if (chkmon.Checked == true)
                    checkboxesText += "Monday-";
                if (chktue.Checked == true)
                    checkboxesText += "Tuesday-";
                if (chkwed.Checked == true)
                    checkboxesText += "Wednesday-";
                if (chkthu.Checked == true)
                    checkboxesText += "Thursday-";
                if (chkfri.Checked == true)
                    checkboxesText += "Friday-";
                if (chksat.Checked == true)
                    checkboxesText += "Saturday-";
                if (chksun.Checked == true)
                    checkboxesText += "Sunday-";

                return checkboxesText;
        }

        private void grpSchedule_Enter(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (dtpTimeStart.Text.Equals("1:00:00 AM") || dtpTimeEnd.Text.Equals("1:00:00 AM"))return;
            populateSched();            
        }
        public void populateSched()
        {
            chkmon.Checked = false;
            chktue.Checked = false;
            chkwed.Checked = false;
            chkthu.Checked = false;
            chkfri.Checked = false;
            chksat.Checked = false;
            chksun.Checked = false;
            btnSave.Text = "Save";

            long subjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '"+cmbsubject.Text+"' AND UserID = "+userid1+"" , "SubjectID");
            //long schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjID + " AND ScheduleTimeFrom  = '" + dtpTimeStart.Text + "' AND ScheduleTimeTo = '" + dtpTimeEnd.Text + "' ", "ScheduleID");

            string query = "SELECT * FROM tblschedule s INNER JOIN tblsubject su " +
                "ON s.SubjectID = su.SubjectID WHERE su.UserID = " + userid1 + " AND s.SubjectID = " +subjID + " ";
            DataTable tbl = db.SelectQuery(query);
           // if (tbl.Rows.Count.Equals(0)) return;
            if (tbl.Rows.Count != 0)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    txtroom.Text = row["ScheduleRoom"].ToString();
                    dtpTimeStart.Value = Convert.ToDateTime(row["ScheduleTimeFrom"].ToString());
                    dtpTimeEnd.Value = Convert.ToDateTime(row["ScheduleTimeTo"].ToString());
                    string day = row["ScheduleDay"].ToString();
                    schedID = db.GetID("SELECT * FROM tblschedule WHERE SubjectID = " + subjID + " AND ScheduleTimeFrom  = '" + dtpTimeStart.Text + "' AND ScheduleTimeTo = '" + dtpTimeEnd.Text + "' ", "ScheduleID");
                    string[] indday = day.Split('-');
                    foreach (string d in indday)
                    {
                        if (d.Equals(chkmon.Text))
                            chkmon.Checked = true;
                        if (d.Equals(chktue.Text))
                            chktue.Checked = true;
                        if (d.Equals(chkwed.Text))
                            chkwed.Checked = true;
                        if (d.Equals(chkthu.Text))
                            chkthu.Checked = true;
                        if (d.Equals(chkfri.Text))
                            chkfri.Checked = true;
                        if (d.Equals(chksat.Text))
                            chksat.Checked = true;
                        if (d.Equals(chksun.Text))
                            chksun.Checked = true;
                    }
                    btnSave.Text = "Update";
                }
            }
            else
            {
                txtroom.Text = "";
                dtpTimeStart.Value = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
                dtpTimeEnd.Value = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
                chkmon.Checked = false;
                chktue.Checked = false;
                chkwed.Checked = false;
                chkthu.Checked = false;
                chkfri.Checked = false;
                chksat.Checked = false;
                chksun.Checked = false;
                btnSave.Text = "Save";
            }
        }

        private void frmSchedule_MouseDown(object sender, MouseEventArgs e)
        {
            add.FormDrag(ref sender, ref e, MousePosition, this.Location);
        }

        private void frmSchedule_MouseMove(object sender, MouseEventArgs e)
        {
            if (add.isMoving)
            {
                this.Location = add.FormMove(ref sender, ref e, MousePosition);
            }
        }

        private void frmSchedule_MouseUp(object sender, MouseEventArgs e)
        {
            add.FormDrop(ref sender, ref e);
        }

    }
}
