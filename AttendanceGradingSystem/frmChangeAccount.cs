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
    public partial class frmChangeAccount : Form
    {
        MyUtilities db = new MyUtilities();
        InteractionAddOns add = new InteractionAddOns();
        public string username;
        public string password;
        public static string uid;
        public string ProfileName;
        public frmChangeAccount()
        {
            InitializeComponent();
            lblmatch.Visible = false;
            lblNotif.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you , you want to close this session?", "Close Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void frmChangeAccount_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tbluser WHERE UserID ="+uid+"";
            DataTable dt = db.SelectQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                username = r["Username"].ToString();
                password = r["UserPassword"].ToString();
                ProfileName = r["UserProfile"].ToString();
            }
        }
        public void Clear()
        {
            txtCurrUser.Text = "";
            txtCurrPass.Text = "";
            txtNewUser.Text = "";
            txtNewProfile.Text = "";
            txtNewPass.Text = "";
            txtConPass.Text = "";
        }
        public bool InputValidation(string cons)
        {
            string query = "SELECT * FROM tbluser WHERE Username = '" +txtNewUser.Text +"'";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Username already exist. Change username" , "Duplicate" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return false;
            }
            if (txtCurrUser.Text.Equals("") || txtCurrPass.Text.Equals("") || txtNewUser.Text.Equals("") ||
                txtNewPass.Text.Equals("") || txtNewProfile.Text.Equals("") ||txtNewProfile.Text.Equals(""))
            {
                if (txtCurrUser.Text.Equals(" ") || txtCurrPass.Text.Equals(" ") || txtNewUser.Text.Equals(" ") ||
                txtNewPass.Text.Equals(" ") || txtNewProfile.Text.Equals(" ") || txtNewProfile.Text.Equals(" "))
                {
                    lblNotif.Text = "Please complete the whole form";
                    lblNotif.Visible = true;
                    return false;
                }
            }
            
            if (txtCurrUser.Text != username)
            {
                lblNotif.Text = "The username you've entered is incorrect";
                lblNotif.Visible = true;
                return false;
            }
            if (txtCurrPass.Text != password)
            {
                lblNotif.Text = "The password you've entered is incorrect";
                lblNotif.Visible = true;
                return false;
            }  
            return true;
        }
        public void UpdateUserAccount()
        {
            string query = "UPDATE tbluser SET Username ='" + txtNewUser.Text + "' , UserPassword='" + txtNewPass.Text + "', UserProfile ='" + db.CorrectCasing(txtNewProfile.Text) + "' WHERE UserID ="+uid+"";
            db.InsertQuery(query);
            MessageBox.Show("The following records update successfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InputValidation(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to save the following records?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    UpdateUserAccount();
                    this.Close();
                }
            }
            lblmatch.Visible = false;
        }

        private void txtConPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConPass.Text)
                lblmatch.Visible = true;
            else if (txtNewPass.Text == txtConPass.Text)
                lblmatch.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to cancel the following changes?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Clear();
        }

        private void frmChangeAccount_MouseDown(object sender, MouseEventArgs e)
        {
            add.FormDrag(ref sender, ref e, MousePosition, this.Location);
        }

        private void frmChangeAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (add.isMoving)
            {
                this.Location = add.FormMove(ref sender, ref e, MousePosition);
            }
        }

        private void frmChangeAccount_MouseUp(object sender, MouseEventArgs e)
        {
            add.FormDrop(ref sender, ref e);
        }
    }
}
