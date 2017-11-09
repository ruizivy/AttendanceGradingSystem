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
    public partial class frmManageSubjects : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        DataTable table;
        MySqlDataAdapter adptr;
        public string subjID;
        public string schedID;
        public frmManageSubjects()
        {
            table = new DataTable();
            InitializeComponent();
        }

        private void frmManage_Load(object sender, EventArgs e)
        {

        }

        private bool IsFormAlreadyOpened(string formName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (formName == f.Name)
                    return true;
            }
            return false;
        }

        private bool CloseAllOpenedWindow(String currentForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if ((f.Visible == true) && (!f.Name.Equals(currentForm)))
                {
                    if (DialogResult.Yes == MessageBox.Show("Do you want to close the current session?", "Close Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        f.Close();
                        return true;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("frmSetStudent"))
            {
                if (CloseAllOpenedWindow("frmSetStudent") == false) return;
                frmSetStudent stud = new frmSetStudent();
                stud.MdiParent = this;
                stud.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (!IsFormAlreadyOpened("frmTermsCriteria"))
            {
                if (CloseAllOpenedWindow("frmTermsCriteria") == false) return;
                frmTermsCriteria term = new frmTermsCriteria();
                term.MdiParent = this;
                term.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //if (DialogResult.Yes == MessageBox.Show("Are you sure you want to close this session? ", "Close Session",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
                this.Close();
            //}
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("frmSchedule"))
            {
                if (CloseAllOpenedWindow("frmSchedule") == false) return;
                frmSchedSubj sched = new frmSchedSubj();
                sched.MdiParent = this;
                sched.Show();
            }

        }

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("frmSetEntryDays"))
            {
                if (CloseAllOpenedWindow("frmSetEntryDays") == false) return;
                frmSetEntryDays days = new frmSetEntryDays();
                days.MdiParent = this;
                days.Show();
            }
        }
    }
}
