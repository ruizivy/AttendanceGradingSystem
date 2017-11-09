using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlDButilities;

namespace AttendanceGradingSystem
{
    public partial class frmLogin : Form
    {
        MyUtilities db = new MyUtilities();
        ConnectionSetUp setup = new ConnectionSetUp();
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        MySqlConnection conn;
        DataTable table;
        public bool isnotdone = true;
        public static string dir = @"C:\Users\" + Environment.UserName + @"\configuration";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (db.OpenConnection() == null)
            {
                connde();
            }
            db.CloseConnection();
            lblUserpro.Visible = false;
            txtProfile.Visible = false;
            btnCancel.Visible = false;
        }
        public string connde()
        {
            string d = "";
            {
                try
                {
                    string DbDec = setup.ReadRegistryKey("ConnString", "sehun");
                   // string constr = setup.AES_Decrypt(DbDec, db.password);
                    conn = new MySqlConnection();
                    conn.ConnectionString = DbDec;

                    conn.Open();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    frmConnection conn = new frmConnection();
                    conn.ShowDialog();
                }
            }
            return d;
        }
        public void Login()
        {
            if (txtUser.Text.Equals("") || txtUser.Text.Equals(" ") || txtpass.Text.Equals("") || txtpass.Text.Equals(" "))
            {
                MessageBox.Show("Please complete the whole form.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {         
                string query = "SELECT * FROM tbluser WHERE Username = '" + txtUser.Text +"' ;";
                adptr = new MySqlDataAdapter(query, db.OpenConnection());
                table = new DataTable();
                adptr.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Username doesn't exist. Check the username you've enter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                db.CloseConnection();
                foreach (DataRow row in table.Rows)
                {
                     if (txtUser.Text.Equals(row["Username"].ToString().Trim()) && txtpass.Text.Equals(row["UserPassword"].ToString().Trim()))
                    {
                        frmSchedule.userid1 = row["UserID"].ToString();
                        frmSetStudent.userid = row["UserID"].ToString();
                      //  frmSubjectGrading.userid2 = row["UserID"].ToString();
                        frmManageGrading.mgUid = row["UserID"].ToString();
                        frmCriteria.userid = row["UserID"].ToString();
                        frmAddCourse.userid = row["UserID"].ToString();
                        frmAddStudent.userid = row["UserID"].ToString();
                        frmAddSubject.userid = row["UserID"].ToString();
                        frmSchedSubj.userid = row["UserID"].ToString();
                        frmAttendance.uid = row["UserID"].ToString();
                        frmTermsCriteria.userid = row["UserID"].ToString();
                        frmSetEntryDays.uid = row["UserID"].ToString();
                        frmChangeAccount.uid = row["UserID"].ToString();
                        frmMain.username = "User: " + row["UserProfile"].ToString();
                        txtUser.Text = "";
                        txtpass.Text = "";
                        frmMain.IsLogin = true;
                        frmMain main = new frmMain();
                        main.ShowDialog();
                        this.Hide();
                    }
                    else  if (txtpass.Text != row["UserPassword"].ToString())
                    {
                        MessageBox.Show("Incorrect password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("User doesn't exist", "Create an account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         public void Register()
        {
            DataTable dt = db.SelectQuery("SELECT * FROM tbluser WHERE Username = '" + txtUser.Text +"'");
            if (txtUser.Text != "" && txtpass.Text != "")
            {
                if(dt.Rows.Count != 0)
                {
                    MessageBox.Show("Username Already Exist!",
                      "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cmd = new MySqlCommand("insertuser", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?user", txtUser.Text));
                cmd.Parameters.Add(new MySqlParameter("?pass", txtpass.Text));
                cmd.Parameters.Add(new MySqlParameter("?userdp", txtProfile.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("User successfully saved!!! ", "Saved!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                db.CloseConnection();
            }
        }
        public void Clear()
        {
            txtUser.Text = "";
            txtpass.Text = "";
        }
        public bool InputValidation(string cons)
        {
            DataTable dt = db.SelectQuery("SELECT * FROM tbluser WHERE Username = '" + txtUser.Text + "'");
            db.CloseConnection();
            if (txtUser.Text.Equals("") && txtpass.Text.Equals("") && txtProfile.Text.Equals(""))
            {
                if (txtUser.Text.Equals(" ") || txtpass.Text.Equals(" ") || txtProfile.Text.Equals(" "))
                {
                    MessageBox.Show("Please fill up the whole form", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (txtUser.Text != "" && txtpass.Text != "")
            {
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Username Already Exist!",
                        "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            return true;
        }
        private bool IsAllInputValid(string cons)
        {
            if (txtUser.Text.Equals("") || txtpass.Text.Equals(""))
            {
                if (txtUser.Text.Equals(" ") || txtpass.Text.Equals(" "))
                {
                    MessageBox.Show("Please fill up the whole form", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
 

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && isnotdone)
            {
                Environment.Exit(1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void picbox1_Click(object sender, EventArgs e)
        {

        }

        public void LoginCS()
        {
            if (btnlogin.Text == "Login")
            {
                if (IsAllInputValid(""))
                {
                    Login();
                    // this.Hide();
                    //this.ShowInTaskbar = false;
                }
            }
            else if (btnlogin.Text == "Create")
            {
                if (InputValidation(""))
                {
                    Register();
                    txtpass.Text = "";
                    txtUser.Text = "";
                    lblUserpro.Visible = false;
                    txtProfile.Visible = false;
                    btnlogin.Text = "Login";
                    btnCancel.Visible = false;
                    lnkRegister.Visible = true;
                    lnkEditConnection.Visible = true;
                    picbox1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Picture\\user.png");
                }
            }
        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            LoginCS();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            btnlogin.Text = "Login";
            lnkRegister.Visible = true;
            lblUserpro.Visible = false;
            txtProfile.Visible = false;
            btnCancel.Visible = false;
            txtpass.Text = "";
            txtUser.Text = "";
            picbox1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Picture\\user.png");
        }

        private void lnkRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnlogin.Text = "Create";
            btnCancel.Visible = true;
            lblUserpro.Visible = true;
            txtProfile.Visible = true;
            lnkRegister.Visible = false;
            lnkEditConnection.Visible = false;
            txtUser.Text = "";
            txtpass.Text = "";
            picbox1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Picture\\user2.png");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                LoginCS();
            }
        }

        private void lnkEditConnection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConnection conn = new frmConnection();
            conn.Show();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextBoxHander(ref sender, ref e);
        }
    }
}

