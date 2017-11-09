using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AttendanceGradingSystem
{
    public partial class frmMain : Form
    {
        public static string username;
        public static bool IsLogin = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = username;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance view = new frmAttendance();
            view.ShowDialog();
            //frmManageAttendance view = new frmManageAttendance();
            //view.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to close the form?", "Close!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.ExitThread();
            else
            { }
        }

        private void btnManageSubject_Click(object sender, EventArgs e)
        {
            frmManageSubjects msubj = new frmManageSubjects();
            msubj.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmSetDetails manage = new frmSetDetails();
            manage.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
              //  Application.ExitThread();
                frmLogin log = new frmLogin();
                log.Show();
            }
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to change your account setting?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmChangeAccount acc = new frmChangeAccount();
                acc.ShowDialog();
            }
        }

        private void btnManageGrading_Click(object sender, EventArgs e)
        {
            frmManageGrading manage = new frmManageGrading();
            manage.ShowDialog();
        }
      
    }
}
