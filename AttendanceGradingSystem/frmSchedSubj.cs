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
    public partial class frmSchedSubj : Form
    {
        MyUtilities db = new MyUtilities();
        public static string userid;
        DataTable table;
        public frmSchedSubj()
        {
            table = new DataTable();
            InitializeComponent();
        }

        private void frmSchedSubj_Load(object sender, EventArgs e)
        {
            BindToComboBox("SELECT * FROM tblsubject WHERE UserID = "+userid+" ORDER BY SubjectName ASC", ref cmbSubjects, "SubjectID", "SubjectName");
          //  PopulateSubject();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmSchedule sched = new frmSchedule();
            sched.ShowDialog();
        }
        public void PopulateSubject()
        {
            string query = "SELECT * FROM tblsubject WHERE UserID = "+userid+" ORDER BY SubjectName ASC";
            DataTable tbl = db.SelectQuery(query);
            foreach (DataRow r in tbl.Rows)
            {
                cmbSubjects.Items.Add(r["SubjectName"].ToString());
            }
        }
        private void BindToComboBox(string query, ref ComboBox cmb, string key, string value)
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
        public void loadData()
        {
            //char[] delimiter = { ',', '[', ']' };
            //string id = cmbSubjects.SelectedValue.ToString();
            long subjID = db.GetID("SELECT * FROM tblsubject WHERE SubjectName = '" + cmbSubjects.Text + "' AND UserID = "+userid+" ", "SubjectID");
            string query = "SELECT * FROM tblsubjectclass sc INNER JOIN tblstudent s " +
                           "ON sc.StudID = s.StudentID INNER JOIN tblschedule sch " +
                           "ON sc.ScheduleID = sch.ScheduleID INNER JOIN tblsubject su " +
                           "ON sch.SubjectID = su.SubjectID " +
                           "WHERE sc.SubjectID = "+subjID+" AND su.UserID = "+userid+" " +
                           "GROUP BY Section;";
            gridSched.DataSource = db.SelectQuery(query);
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
