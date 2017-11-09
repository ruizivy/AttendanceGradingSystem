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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AttendanceGradingSystem
{
    public partial class frmCriteria : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        private bool hasNewCriteria = false;
        public static string userid;
        int selectedIndex = -1;
        public frmCriteria()
        {
            InitializeComponent();
        }

        private void frmCriteria_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            string query = "SELECT * , 0 AS IsEdited FROM tblcriteria WHERE UserID = "+userid+" AND Active = 1 ORDER BY Percentage ASC";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            { btnDelete.Enabled = false; }
            else
                btnDelete.Enabled = true;
            GridCriteria.DataSource = db.SelectQuery(query);
        }
        public bool InputValidation(string cons)
        {
            List<string> queries = new List<string>();
            double total = 0;
            for (int i = 0; i < ViewCriteria.RowCount; i++)
            {
                if (ViewCriteria.GetRowCellValue(i, "IsEdited").ToString().Equals("2"))
                {
                    string critname = ViewCriteria.GetRowCellValue(i, "CriteriaName").ToString();
                    double percent = Convert.ToDouble(ViewCriteria.GetRowCellValue(i, "Percentage"));
                    string query = "SELECT * FROM tblcriteria WHERE CriteriaName ='" + db.CorrectCasing(critname) + "' AND Percentage = " + percent + " AND UserID = "+userid+" AND Active =1";
                    DataTable tbl = db.SelectQuery(query);
                    if (tbl.Rows.Count != 0)
                    {
                        MessageBox.Show("Duplicate information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadData();
                        return false;
                    }
                }
                total += Convert.ToDouble(ViewCriteria.GetRowCellValue(i, "Percentage"));
                string critname1 = ViewCriteria.GetRowCellValue(i, "CriteriaName").ToString();
                double percent1 = Convert.ToDouble(ViewCriteria.GetRowCellValue(i, "Percentage"));
                if (ViewCriteria.GetRowCellValue(i, "CriteriaName").ToString().Equals(critname1) && ViewCriteria.GetRowCellValue(i, "Percentage").ToString().Equals(percent1))
                {
                    MessageBox.Show("Duplicate information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                } 
            }
            if (total != 100.00)
            {
                MessageBox.Show("The total percentage of all criteria must be 100%.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void SaveAllUpdatedList()
        {
            ViewCriteria.CloseEditForm();
            ViewCriteria.UpdateCurrentRow();
            List<string> updateQueries = new List<string>();

            for (int i = 0; i < ViewCriteria.RowCount; i++)
            {
                if (ViewCriteria.GetRowCellValue(i, "IsEdited").ToString().Equals("1"))
                {
                    long corID = Convert.ToInt64(ViewCriteria.GetRowCellValue(i, "CriteriaID"));
                    string critName = ViewCriteria.GetRowCellValue(i, "CriteriaName").ToString();
                    string percentage = ViewCriteria.GetRowCellValue(i, "Percentage").ToString();
                    string query = "UPDATE attendance_db.tblcriteria SET CriteriaName = '" + db.CorrectCasing(critName) + "', Percentage = " + percentage + " WHERE CriteriaID = " + corID + "";
                    updateQueries.Add(query);
                }
                else if (ViewCriteria.GetRowCellValue(i, "IsEdited").ToString().Equals("2"))
                {
                    if (InputValidation(""))
                    {
                        string critNames = ViewCriteria.GetRowCellValue(i, "CriteriaName").ToString();
                        double percent = Convert.ToDouble(ViewCriteria.GetRowCellValue(i, "Percentage"));
                        string query = "INSERT INTO `attendance_db`.`tblcriteria` (`CriteriaName`, `Percentage`, `UserID` ,`Active`) VALUES ('" + db.CorrectCasing(critNames) + "', '" + percent + "', " + userid + " , 1)";
                        updateQueries.Add(query);
                    }
                }
               
            }
            if (updateQueries.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to save the following items. ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (db.RunTransaction(updateQueries))
                    {
                        MessageBox.Show("Selected records updated successfully. ", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridCriteria.DataSource = null;
                        LoadData();
                    }
                }
                else
                    LoadData();
            DateTime dateValue = DateTime.Now;
            }
      }

        #region "Add Events"
        private void ValidateRequiredFields(ref object sender, ref ValidateRowEventArgs e,
                                             string colName, string errorMessage, bool hasTrue = false)
        {
            GridView view = (GridView)sender;
            GridColumn column = view.Columns[colName];
            if (view.GetRowCellValue(e.RowHandle, column) is DBNull ||
                    (view.GetRowCellValue(e.RowHandle, column) == null) ||
                    (view.GetRowCellValue(e.RowHandle, column).ToString().Trim().Length <= 0)
                    )
            {
                e.Valid = false;
                view.SetColumnError(column, errorMessage);
                view.FocusedColumn = view.VisibleColumns[0];
                hasTrue = false;
            }
            else
            {
                e.Valid = true;
                hasTrue = true;
            }
        }
        #endregion

        private void ViewCriteria_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (ViewCriteria.GetRowCellValue(e.RowHandle, "IsEdited") == null)
                {
                    return;
                }
                else if (ViewCriteria.GetRowCellValue(e.RowHandle, "IsEdited").ToString().Equals("1"))
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                }
                else if (ViewCriteria.GetRowCellValue(e.RowHandle, "IsEdited").ToString().Equals("2"))
                {
                    e.Appearance.BackColor = Color.Beige;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewCriteria_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (!e.Column.FieldName.ToString().Equals("IsEdited"))
                {
                    if (ViewCriteria.GetRowCellValue(e.RowHandle, "CriteriaID").ToString().Equals(""))
                    {
                        ViewCriteria.SetRowCellValue(e.RowHandle, "IsEdited", "2");
                    }
                    else
                    {
                        ViewCriteria.SetRowCellValue(e.RowHandle, "IsEdited", "1");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewCriteria_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ValidateRequiredFields(ref sender, ref e, "CriteriaName", "Please enter your criteria name" , false);
            //ValidateRequiredFields(ref sender, ref e, "Percentage", "Please enter the percentage of criteria", false);
            ValidateNumberData(ref sender, ref e, "Percentage", "Please enter a correct percentage", false);
        }

        private void ValidateNumberData(ref object sender, ref ValidateRowEventArgs e,
                                                   string colName, string errorMessage, bool hasTrue = false)
        {
            GridView view = (GridView)sender;
            GridColumn column = view.Columns[colName];
            if (view.GetRowCellValue(e.RowHandle, column) is DBNull ||
                    (view.GetRowCellValue(e.RowHandle, column) == null) ||
                    (view.GetRowCellValue(e.RowHandle, column).ToString().Trim().Length <= 0)
                    )
            {
                e.Valid = false;
                view.SetColumnError(column, errorMessage);
            }
            else
            {
                try
                {
                    double grade = Convert.ToDouble(view.GetRowCellValue(e.RowHandle, column).ToString());
                    e.Valid = true;
                    view.SetColumnError(column, "Please enter a number");
                }
                catch (Exception ex)
                {
                    e.Valid = false;
                }
            }
        }


        private void ViewCriteria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ViewCriteria.CancelUpdateCurrentRow();
            }
            //else if (e.KeyValue == 13)
            //{
            //    SaveAllUpdatedList();
            //}
        }

        private void ViewCriteria_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "SELECT * , 0 AS IsEdited FROM tblcriteria WHERE UserID = " + userid + " AND Active = 1 ORDER BY Percentage ASC";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            { btnDelete.Enabled = false; }
            else
                btnDelete.Enabled = true;
            hasNewCriteria = !hasNewCriteria;
            if (hasNewCriteria)
            {
                ViewCriteria.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
                ViewCriteria.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
                ViewCriteria.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
                ViewCriteria.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
                ViewCriteria.OptionsBehavior.ReadOnly = false;

            }
            else
            {
                ViewCriteria.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
                ViewCriteria.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
                ViewCriteria.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
                ViewCriteria.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                ViewCriteria.OptionsBehavior.ReadOnly = true;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveAllUpdatedList();
        }
        private void SaveNewCriteria()
        {
            List<string> ids = new List<string>();
            DataTable table = db.SelectQuery("SELECT * FROM tblcriteria");
            foreach (DataRow row in table.Rows)
                ids.Add(row["CriteriaID"].ToString());
            if (ids.Count > 0)
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    db.InsertQuery("UPDATE tblcriteria SET Active = 0 WHERE CriteriaID = "+ids[i]+";");
                 
                }
            }
            LoadData();
           // ViewCriteria.SetRowCellValue(selectedIndex, "CriteriaName", "Attendance");
            //SetFocusedRowCellValue("CriteriaName", "Attendance");
        }

        private void newCriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to create new criteria?", "Question?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                SaveNewCriteria();
            }
        }

        private void ViewCriteria_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            selectedIndex = e.FocusedRowHandle;
        }

        private void ViewCriteria_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = (GridView)sender;
            ViewCriteria.SetRowCellValue(e.RowHandle, "CriteriaName", "Attendance");
        }

        private void GridCriteria_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ViewCriteria.GetRowCellValue(selectedIndex, "CriteriaID").ToString();
            string name = ViewCriteria.GetRowCellValue(selectedIndex, "CriteriaName").ToString();
            if (name != "Attendance")
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure , you want to delete the selected item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string delete = "UPDATE tblcriteria SET Active = 0 WHERE CriteriaID = " + id;
                    int result = db.RunUpdateQuery(delete);

                    if (result > 0)
                    {
                        MessageBox.Show("Criteria is deleted");
                        LoadData();
                    }
                }
            }
            else
                MessageBox.Show("Criteria must have " + name, "Can't Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
 }
 