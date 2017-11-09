using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using AttendanceGradingSystem;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace MySqlDButilities
{
    class ConnectionSetUp
    {
        public void CreateRegistryKey(string key, string value)
        {
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
                regKey.CreateSubKey("Attendance_GradingSystem_DataConnection");
                regKey = regKey.OpenSubKey("Attendance_GradingSystem_DataConnection", true);
                regKey.SetValue(key, value);
            }
            catch (Exception e)
            {

            }
        }
        public string ReadRegistryKey(string Key, string passkey)
        {
            string retVal = "";
            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software", true);
                regKey.CreateSubKey("Attendance_GradingSystem_DataConnection");
                regKey = regKey.OpenSubKey("Attendance_GradingSystem_DataConnection", true);
                retVal = regKey.GetValue(Key).ToString();
                retVal = AES_Decrypt(retVal, passkey);

            }
            catch (Exception e)
            { retVal = ""; }
            return retVal;
        }

        public string ConvertToBytes(string value)
        {
            string retVal = "";

            try
            {
                byte[] arr = Encoding.ASCII.GetBytes(value);
                foreach (byte b in arr)
                {
                    retVal += b.ToString();
                }
            }
            catch (Exception e)
            { return value; }

            return retVal;
        }

        public string AES_Encrypt(string clearText, string passkey)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            string encryptedString = "";

            try
            {
                byte[] hash = new byte[32];
                byte[] temp = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passkey));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESEncrypter = AES.CreateEncryptor();
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(clearText);
                encryptedString = Convert.ToBase64String
                    (DESEncrypter.TransformFinalBlock(buffer, 0, buffer.Length));

            }
            catch (Exception e)
            { return ""; }
            return encryptedString;
        }
        public string decryptedString;
        public string AES_Decrypt(string encrypted, string passkey)
        {
            RijndaelManaged AES = new RijndaelManaged();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            decryptedString = "";

            try
            {

                byte[] hash = new byte[32];
                byte[] temp = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passkey));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = CipherMode.ECB;
                ICryptoTransform DESdecrypter = AES.CreateDecryptor();
                byte[] buffer = Convert.FromBase64String(encrypted);
                decryptedString = ASCIIEncoding.ASCII.GetString
                    (DESdecrypter.TransformFinalBlock(buffer, 0, buffer.Length));
            }
            catch (Exception e)
            { return ""; }
            return decryptedString;
        }

    }
    class MyUtilities
    {
        public static int RecordCount = 0;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adptr;
        ConnectionSetUp ConnSetup = new ConnectionSetUp();
        public string server, port, database ,username, password;
        public MyUtilities()
        {
            conn = new MySqlConnection();
            cmd = new MySqlCommand();
            adptr = new MySqlDataAdapter();
        }
        public MySqlConnection OpenConnection()
        {
            conn.ConnectionString = GetReadRegistryKey();
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public DataTable SelectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                adptr = new MySqlDataAdapter(query, OpenConnection());
                adptr.Fill(dt);
                adptr.Dispose();
                CloseConnection();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public string GetReadRegistryKey()
        {
            string temp = "";

            try
            {
                temp = ConnSetup.ReadRegistryKey("ConnString", "sehun");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return temp;
        }
        public void InsertQuery(string query)
        {
            cmd.CommandText = query;
            try
            {
                cmd.Connection = OpenConnection();
                int res = cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private string ReadFromIniFile()
        {
            string text = string.Empty;
            if (!File.Exists(frmLogin.dir + "\\settings.ini"))
                File.WriteAllText(frmLogin.dir + "\\settings.ini", "");
            else
            {
                string[] datas = File.ReadAllLines(frmLogin.dir + "\\settings.ini");
                foreach (string s in datas)
                    text += s;
            }
            return text;
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public bool IsConnectionValid(string connStr)
        {
            conn.ConnectionString = connStr;
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable ExecuteQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, OpenConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            CloseConnection();
            return table;
        }

        public String DataLookUp(string column, string table, string defaultValue, string criteria)
        {
            string query = "SELECT " + column + "FROM " + table + " " + (criteria.Trim().Length > 0 ? "WHERE " + criteria + " " : "");
            DataTable dt = ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                return defaultValue;
            }
            else { }
            return "";
        }
        public int ExecuteUpdate(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, OpenConnection());
                CloseConnection();
                return command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        public bool RunTransaction(List<string> queries)
        {
            bool returnValue = false;
            try
            {
                this.conn.Open();
                this.cmd = this.conn.CreateCommand();
                MySqlTransaction transaction = this.conn.BeginTransaction();
                this.cmd.Connection = this.conn;
                this.cmd.Transaction = transaction;
                try
                {
                    foreach (string query in queries)
                    {
                        if (query.Trim().Length > 0)
                        {
                            this.cmd.CommandText = query;
                            this.cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    returnValue = true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    returnValue = false;
                }
                this.cmd.Dispose();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                if (this.conn.State != ConnectionState.Closed)
                {
                    this.conn.Close();
                }
                returnValue = false;
            }
            return returnValue;
        }

        public int RunUpdateQuery(string updateQuery)
        {
            try
            {
                this.conn.Open();
                this.cmd = new MySqlCommand(updateQuery, this.conn);
                RecordCount = this.cmd.ExecuteNonQuery();
                this.cmd.Dispose();
                this.conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("There is a problem encountered while updating the record : " + ex.Message,
                                "Running Update Query ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (this.conn.State != ConnectionState.Closed)
                {
                    this.conn.Close();
                }
            }
            return RecordCount;

        }
        public void RemoveAllCheckItems(ListView lst)
        {
            if (lst.Items.Count == 0) return;
            for (int i = 0; i < lst.Items.Count; i++)
            {
                try
                {
                    lst.Items[i].Checked = false;
                }
                catch (Exception ex) { }
            }
        }
        public void SetAllItemToCheck(ListView lst)
        {
            if (lst.Items.Count == 0) return;
            for (int i = 0; i < lst.Items.Count; i++)
            {
                try
                {
                    lst.Items[i].Checked = true;
                }
                catch (Exception ex) { }
            }
        }
        public string CorrectCasing(string source)
        {
            string retval = " ";
            if (source.Contains(' '))
            {
                string[] temp = source.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Length > 1)
                        retval += temp[i].Substring(0, 1).ToUpper() + temp[i].Substring(1).ToLower() + " ";
                    else
                        retval += temp[i].ToUpper();
                }
            }
            else
                retval += source.Substring(0, 1).ToUpper() + source.Substring(1).ToLower() + " ";
            retval = retval.Trim();
            return retval;
        }
        public long GetID(string query, string colname)
        {
            DataTable dt = SelectQuery(query);
            if (dt.Rows.Count != 0)
            {
                DataRow r = dt.Rows[0];
                long i = Convert.ToInt64(r[colname].ToString());
                return i;
            }
            else
                return 0;
        }
        public string GetValue(string query, string colname)
        {
            DataTable dt = SelectQuery(query);
            if (dt.Rows.Count != 0)
            {
                DataRow r = dt.Rows[0];
                string i = r[colname].ToString();
                return i;             
            }
            else
                return "";
        }
        public void TextHandler(ref object sender, ref KeyPressEventArgs e, bool IsDigit)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && IsDigit)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !IsDigit)
                e.Handled = true;
        }
        public void DecimalHandler(ref object sender, ref KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Contains(".") && e.KeyChar == '.')
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        public void TextBoxHander(ref object sender, ref KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '.' && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
    class InteractionAddOns
    {
        Point formPoint;
        Point mousePoint;
        public bool isMoving;

        public InteractionAddOns()
        {
            formPoint = new Point();
            mousePoint = new Point();
            isMoving = false;
        }
        public Point FormMove(ref object sender, ref MouseEventArgs e, Point mouseXY)
        {
            Point m = mouseXY;
            int x, y;
            x = m.X - mousePoint.X;
            y = m.Y - mousePoint.Y;
            x = formPoint.X + x;
            y = formPoint.Y + y;
            m = new Point(x, y);
            return m;
        }
        public void FormDrag(ref object sender, ref MouseEventArgs e, Point mouseXY, Point formXY)
        {
            if (e.Button == MouseButtons.Left)
            {
                formPoint = formXY;
                mousePoint = mouseXY;
                isMoving = true;
            }
        }
        public void FormDrop(ref object sender, ref MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMoving = false;
        }

    }
}
