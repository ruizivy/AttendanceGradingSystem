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
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Security.Cryptography;
using Microsoft.Win32;
using MySqlDButilities;

namespace AttendanceGradingSystem
{
    public partial class frmConnection : Form
    {
        MyUtilities db = new MyUtilities();
        ConnectionSetUp setup = new ConnectionSetUp();
        MySqlConnection conn;
        string ConnString;
        bool isNotDone = true;
        
        public frmConnection()
        {
            InitializeComponent();
            
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            
        }
        public void TestConnection()
        {
            db.server = txtserver.Text;
            db.port = txtport.Text;
            db.database = txtdatabase.Text;
            db.username = txtuid.Text;
            db.password = txtpassword.Text;
            try
            {
                string constr = "SERVER=" + db.server + ";" +
                                 "PORT=" + db.port + ";" +
                                 "DATABASE=" + db.database + ";" +
                                 "UID=" + db.username + ";" +
                                 "PASSWORD=" + db.password + ";";
                string DBenc = setup.AES_Encrypt(constr,"sehun");

                setup.CreateRegistryKey("ConnString", DBenc);
                string connString = setup.AES_Decrypt(DBenc, "sehun");
                conn = new MySqlConnection();
                conn.ConnectionString = connString;
               conn.Open();
               conn.Close();
                MessageBox.Show("Valid Connection");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Apply()
        {
            db.server = txtserver.Text;
            db.port = txtport.Text;
            db.database = txtdatabase.Text;
            db.username = txtuid.Text;
            db.password = txtpassword.Text;
            try
            {
                string constr =  "SERVER=" + db.server + ";" +
                                 "PORT=" + db.port + ";" +
                                 "DATABASE=" + db.database + ";" +
                                 "UID=" + db.username + ";" +
                                 "PASSWORD=" + db.password + ";";
                string DBenc = setup.AES_Encrypt(constr, "sehun");

                setup.CreateRegistryKey("ConnString", DBenc);
                string connString = setup.AES_Decrypt(DBenc, "sehun");
                conn = new MySqlConnection();
                conn.ConnectionString = connString;

                conn.Open();
                MessageBox.Show("Succesfully Connected");
                isNotDone = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void btntest_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            TestConnection();
            Apply();
        }

        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing && isNotDone)
            //    Environment.Exit(1);
            //frmLogin login = new frmLogin();
            //login.ShowDialog();
           // this.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void txtserver_KeyPress(object sender, KeyPressEventArgs e)
        {
            db.TextBoxHander(ref sender, ref e);
        }
    }
}
