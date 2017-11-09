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

namespace AttendanceGradingSystem
{
    public partial class frmSetDetails : Form
    {
        MyUtilities db = new MyUtilities();
        public frmSetDetails()
        {
            InitializeComponent();
        }

        private void frmManageSubjectDetails_Load(object sender, EventArgs e)
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
        private void lblClose_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (!IsFormAlreadyOpened("frmAddSubject"))
                {
                    if (CloseAllOpenedWindow("frmAddSubject") == false) return;
                    frmAddSubject subj = new frmAddSubject();
                    subj.MdiParent = this;
                    subj.Show();
                }
            }
        }

        private void btnaddStudent_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (!IsFormAlreadyOpened("frmAddStudent"))
                {
                    if (CloseAllOpenedWindow("frmaddStudent") == false) return;
                    frmAddStudent stud = new frmAddStudent();
                    stud.MdiParent = this;
                    stud.Show();
                }
            }
        }
        List<double> critper = new List<double>();
        public bool validation()
        {
            critper.Clear();
            double percent =0;
            string qu = "SELECT * FROM tblcriteria WHERE UserID = " + frmCriteria.userid + " AND Active = 1";
            DataTable dt = db.SelectQuery(qu);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    critper.Add(Convert.ToDouble(r["Percentage"].ToString()));
                }
                for (int i = 0; i < critper.Count; i++)
                {
                    percent += critper[i];
                }
                if (percent != 100.00)
                {
                    MessageBox.Show("The total percentage of criteria must be 100% . Please complete form ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
                return true;
        }
        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            if (!IsFormAlreadyOpened("frmCriteria"))
            {
                if (CloseAllOpenedWindow("frmCriteria") == false) return;
                frmCriteria crit = new frmCriteria();
                crit.MdiParent = this;
                crit.Show();
            }
        }

        private void frmSetDetails_Load(object sender, EventArgs e)
        {

        }
        
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (validation())
            {
                //if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to close this session?", "Close Session",
                //    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                //{
                    this.Close();
                //}
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (!IsFormAlreadyOpened("frmAddCourse"))
                {
                    if (CloseAllOpenedWindow("frmAddCourse") == false) return;
                    frmAddCourse course = new frmAddCourse();
                    course.MdiParent = this;
                    course.Show();
                }
            }
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
