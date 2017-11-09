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
using System.IO;
using MySqlDButilities;

namespace AttendanceGradingSystem
{
    public partial class frmAddSubject : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlDataAdapter adptr;
        MySqlCommand cmd;
        public static string SubjectID;
        public string gradingID;
        public static string userid;
        public frmAddSubject()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }
        public bool IsAllInputValid(string val)
        {
            string query = "SELECT * FROM tblsubject WHERE SubjectName ='" + txtSubjName.Text + "' AND UserID = "+userid+" " + val;
            DataTable dt = db.SelectQuery(query);
            if (txtsubjCode.Text.Equals("") || txtSubjName.Text.Equals("") && txtUnits.Text.Equals("") ||
                txtsubjCode.Text.Equals(" ") || txtSubjName.Text.Equals(" ") && txtUnits.Text.Equals(" "))
            {
                MessageBox.Show("Please fill up the whole form.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            txtSubjName.Text = db.CorrectCasing(txtSubjName.Text);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Name already exist!", "Duplicate",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }
        public bool InputValidationPeriod(string val)
        {
            string query1 = "SELECT * FROM tblgnames WHERE GradingName = '" + txtGradingName.Text + "' AND UserID = "+userid+"" + val;
            DataTable table = db.SelectQuery(query1);
            if (txtGradingName.Text.Equals("") || txtGradingName.Text.Equals(" "))
            {
                MessageBox.Show("Please fill up the whole form.", "Warning!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(table.Rows.Count != 0)
            {
                MessageBox.Show("Grading name already exist", "Duplicate Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public bool validation(string val)
        {
            foreach(string i in id)
            {
                 foreach(string s in subjID)
                    {
                        string query = "SELECT * FROM tblgradingperiod WHERE GNID =" + i + " AND SubjectID = " + s + "" + val;
                        DataTable tables = db.SelectQuery(query);
                        if (tables.Rows.Count != 0)
                        {
                            MessageBox.Show("There's already set grading period for this subject"  , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            id.Clear();
                            subjID.Clear();
                            return false;
                        }
                    }
            }
            return true;
        }
        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            lblnote.Visible = true;
            PopulateRecords();
            PopulateSubject();
            PopulateGradingName();
            btnUpdated.Enabled = false;
            btncancel.Visible = false;
        }

        public void AddSubject()
        {
            if (IsAllInputValid(""))
            {
                cmd = new MySqlCommand("insert_subject", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?subjcode", txtsubjCode.Text.ToUpper()));
                cmd.Parameters.Add(new MySqlParameter("?subjname", db.CorrectCasing(txtSubjName.Text)));
                cmd.Parameters.Add(new MySqlParameter("?stype", "Insert"));
                cmd.Parameters.Add(new MySqlParameter("?units", txtUnits.Text));
                cmd.Parameters.Add(new MySqlParameter("?subjID", SubjectID));
                cmd.Parameters.Add(new MySqlParameter("?userid", userid));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                db.CloseConnection();
                PopulateRecords();
            }

        }
        public void UpdateSubject()
        {
            cmd = new MySqlCommand("insert_subject", db.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?subjcode", txtsubjCode.Text.ToUpper()));
            cmd.Parameters.Add(new MySqlParameter("?subjname", db.CorrectCasing(txtSubjName.Text)));
            cmd.Parameters.Add(new MySqlParameter("?stype", "Update"));
            cmd.Parameters.Add(new MySqlParameter("?units", txtUnits.Text));
            cmd.Parameters.Add(new MySqlParameter("?subjID", SubjectID));
            cmd.Parameters.Add(new MySqlParameter("?userid", userid));
            cmd.ExecuteNonQuery();  

            MessageBox.Show("Update successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            db.CloseConnection();
            PopulateRecords();
            btnAdded.Enabled = true;
            btnUpdated.Enabled = false;
        }
        public void Clear()
        {
            txtsubjCode.Text = "";
            txtSubjName.Text = "";
            txtUnits.Text = "";
        }
       
        public void PopulateRecords()
        {
            lstSubj.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblsubject WHERE UserID = "+userid+" ORDER BY SubjectName");
            
            foreach (DataRow rows in dt.Rows)
            {
                ListViewItem item = new ListViewItem(rows["SubjectID"].ToString() + "|" + rows["SubjectCode"].ToString());
                item.SubItems.Add(rows["SubjectCode"].ToString());
                item.SubItems.Add(rows["SubjectName"].ToString());
                item.SubItems.Add(rows["SubjectUnits"].ToString());
                lstSubj.Items.Add(item);
            }
        }
        public void PopulateGradingName()
        {
            lstGradingPeriod.Items.Clear();
            DataTable table = db.SelectQuery("SELECT * FROM tblgnames WHERE UserID = "+userid+" ORDER BY GNID");

            foreach(DataRow row in table.Rows)
            {
                ListViewItem itm = new ListViewItem(row["GradingName"].ToString());
                itm.SubItems.Add(row["GNID"].ToString());
                lstGradingPeriod.Items.Add(itm);
            }
        }
        public void PopulateSubject()
        {
            lstsubjects.Items.Clear();
            DataTable dt = db.SelectQuery("SELECT * FROM tblsubject WHERE UserID = "+userid+" ORDER BY SubjectName ");
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(row["SubjectName"].ToString());
                itm.SubItems.Add(row["SubjectUnits"].ToString());
                itm.SubItems.Add(row["SubjectID"].ToString());
                lstsubjects.Items.Add(itm);
            }
        }

        private void lstSubj_Click(object sender, EventArgs e)
        {
            btnUpdated.Enabled = true;
            btnAdded.Enabled = false;
            ListViewItem itm = lstSubj.SelectedItems[0];
            SubjectID = itm.Text.Split('|').GetValue(0).ToString();
            txtsubjCode.Text = itm.Text.Split('|').GetValue(1).ToString();
            txtSubjName.Text = itm.SubItems[2].Text;
            txtUnits.Text = itm.SubItems[3].Text;
        }
        public bool IsSelected()
        {
            try
            {
                int index = lstGradingPeriod.SelectedIndices[0];
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Please select");
                return false;
            }
        }
        public bool IsSelectedSubj()
        {
            try
            {
                int index = lstsubjects.SelectedIndices[0];
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {

        }
        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void addgradingperiod_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (InputValidationPeriod(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to add this following details", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    string query = "INSERT INTO tblgnames(GradingName , UserID) VALUES('" + db.CorrectCasing(txtGradingName.Text) + "', "+userid+")";
                    cmd = new MySqlCommand(query, db.OpenConnection());
                    cmd.ExecuteNonQuery();
                    db.CloseConnection();
                    MessageBox.Show("The following details was successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateGradingName();
                    txtGradingName.Text = "";
                }
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete the selected subject?",
             "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) && !gradingID.Equals("0"))
            {
                db.InsertQuery("DELETE FROM tblgnames WHERE GNID = " + gradingID + ";");
                MessageBox.Show("Record deleted successfully!", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateGradingName();
            }
            btnadd.Enabled = true;
        }
        private void btnAddTerms_Click_1(object sender, EventArgs e)
        {
            
        }
        List<string> id = new List<string>();
        List<string> subjID = new List<string>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lstGradingPeriod.CheckedItems)
            {
                id.Add(itm.SubItems[1].Text);
            }
            foreach (ListViewItem item in lstsubjects.CheckedItems)
            {
                subjID.Add(item.SubItems[2].Text);
            }
            if (validation(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to save the following selected items?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    foreach (string i in id)
                    {
                        foreach (string s in subjID)
                        {
                            string query = "INSERT INTO attendance_db.tblgradingperiod(GNID,SubjectID) VALUES(" + i + "," + s + ")";
                            cmd = new MySqlCommand(query, db.OpenConnection());
                            cmd.ExecuteNonQuery();
                            db.CloseConnection();
                        }
                    }
                    MessageBox.Show("Selected records was successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                db.RemoveAllCheckItems(lstGradingPeriod);
                db.RemoveAllCheckItems(lstsubjects);
                id.Clear();
                subjID.Clear();
                chkgrdName.Checked = false;
                chkSubjct.Checked = false;
            }
        }

        private void lstGradingPeriod_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            if (IsSelected())
            {
                if (btnUpdate.Enabled == true)
                {
                    string n = "";
                    for (int i = 0; i < lstGradingPeriod.Items.Count; i++)
                    {
                        if (lstGradingPeriod.Items[i].Selected)
                        {
                            n = lstGradingPeriod.Items[i].SubItems[0].Text;
                        }
                        if (n == lstGradingPeriod.Items[i].SubItems[0].Text)
                        {
                           // lstGradingPeriod.Items[i].BackColor = SystemColors.Highlight;
                            ListViewItem itm = lstGradingPeriod.SelectedItems[0];
                            txtGradingName.Text = itm.SubItems[0].Text;
                            gradingID = itm.SubItems[1].Text;
                        }
                        else
                        {
                            lstGradingPeriod.Items[i].BackColor = SystemColors.ScrollBar;
                        }
                    }
                    n = "";
                   
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            grpGrading.Enabled = true;
            //lstsubjects.Enabled = false;
            btncancel.Visible = false;
            db.RemoveAllCheckItems(lstGradingPeriod);
            db.RemoveAllCheckItems(lstsubjects);
        }

        private void tabSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateSubject();
        }

        private void grpSubject_Enter(object sender, EventArgs e)
        {

        }

        private void lstGradingPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSubj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdated_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to update the following items? ", "Update",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                UpdateSubject();
            }
        }

        private void btnAdded_Click_1(object sender, EventArgs e)
        {
            if (IsAllInputValid(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to add the following items?", "Add",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {

                    AddSubject();
                }
            }
        }

        private void btndeleted_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txtUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextHandler(ref sender, ref e, true);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to delete the selected subject?",
          "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) && !SubjectID.Equals("0"))
            {
                db.InsertQuery("DELETE FROM tblsubject WHERE SubjectID = " + SubjectID + ";");
                MessageBox.Show("Record deleted Successfully!", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulateRecords();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want update?", "Update" , MessageBoxButtons.YesNo , MessageBoxIcon.Question))
            {
                string query = "UPDATE tblgnames SET GradingName= '"+txtGradingName.Text+"' WHERE GNID =" +gradingID+";";
                db.InsertQuery(query);
                MessageBox.Show("Record was update successfully", "Update" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            PopulateGradingName();
            txtGradingName.Text = "";
        }

        private void chkgrdName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkgrdName.Checked == true)
            {
                db.SetAllItemToCheck(lstGradingPeriod);
            }
            else if (chkgrdName.Checked == false)
            {
                db.RemoveAllCheckItems(lstGradingPeriod);
            }
        }

        private void chkSubjct_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubjct.Checked == true)
            {
                db.SetAllItemToCheck(lstsubjects);
            }
            else if (chkSubjct.Checked == false)
            {
                db.RemoveAllCheckItems(lstsubjects);
            }
        }
        List<string> gnaID = new List<string>();

        public void PopulateSetgPeriod()
        {
            lstGradingPeriod.Items.Clear();
            if (IsSelectedSubj())
            {
                foreach (string g in gnaID)
                {
                    foreach (string su in subjids)
                    {
                        string query1 = "SELECT * FROM tblgradingperiod g INNER JOIN tblgnames gn " +
                                        "ON g.GNID = gn.GNID INNER JOIN tblsubject su " +
                                        "ON su.SubjectID = g.SubjectID  " +
                                        "WHERE su.SubjectID = " + su + "  AND gn.GNID = " + g + " AND gn.UserID = "+userid+";";
                        DataTable dt = db.SelectQuery(query1);

                        if (dt.Rows.Count != 0)
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                ListViewItem itm = new ListViewItem(row["GradingName"].ToString());
                                itm.SubItems.Add(row["GNID"].ToString());
                                //itm.SubItems.Add(row["SubjectID"].ToString());
                                lstGradingPeriod.Items.Add(itm);
                               // itm.Checked = row["SubjectID"].ToString().Equals(su) ? false : true;
                                db.SetAllItemToCheck(lstGradingPeriod);
                            }
                        }
                    }
                }
            }
            else
            {
                PopulateGradingName();
            }
            
        }
        List<string> subjids = new List<string>();
        private void lstsubjects_Click(object sender, EventArgs e)
        {
            grpGrading.Enabled = false;
            gnaID.Clear();
            subjids.Clear();
            if (IsSelectedSubj())
            {
                ListViewItem itms = lstsubjects.SelectedItems[0];
                subjids.Add(itms.SubItems[2].Text);
                string gnameID = "SELECT * FROM tblgnames WHERE UserID = " + userid + "";
                DataTable tab = db.SelectQuery(gnameID);
                foreach (DataRow r in tab.Rows)
                    gnaID.Add(r["GNID"].ToString());
                PopulateSetgPeriod();
            }
            else
            {
                PopulateGradingName();
            }
        }
      
        private void lstsubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstsubjects_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem itm in lstsubjects.CheckedItems)
                lstsubjects.CheckBoxes = true;
            PopulateGradingName();
        }

        private void lstsubjects_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            grpGrading.Enabled = false;
            gnaID.Clear();
            subjids.Clear();
            btncancel.Visible = true;
            if (IsSelectedSubj())
            {
                ListViewItem itms = lstsubjects.SelectedItems[0];
                subjids.Add(itms.SubItems[2].Text);
                string gnameID = "SELECT * FROM tblgnames WHERE UserID = " + userid + "";
                DataTable tab = db.SelectQuery(gnameID);
                foreach (DataRow r in tab.Rows)
                    gnaID.Add(r["GNID"].ToString());
                PopulateSetgPeriod();
            }
            else
            {
                PopulateGradingName();
            }
        }

        private void txtsubjCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.' && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSubjName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.' && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtGradingName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.' && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
