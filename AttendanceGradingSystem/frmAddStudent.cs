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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AttendanceGradingSystem
{
    public partial class frmAddStudent : Form
    {
        MyUtilities db = new MyUtilities();
        MySqlCommand cmd;
        DataTable table;
        MySqlDataAdapter adptr;
        
        public static long studnum1 = 0;
        public static long courseID = 0;
        public static string abbrv;
        int selectedIndex = -1;
        private bool hasNewStudents = false;
        public static string userid;

        public frmAddStudent()
        {
            InitializeComponent();
            table = new DataTable();
           // gridStudents.Enabled = false;
        }
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
              PopulateStudent();
              PopulateCourse();
        }
        public void PopulateCourse()
        {
            RepoCourses.DataSource = db.SelectQuery("SELECT CourseID , Abbrv FROM tblcourse WHERE UserID = "+userid+" ORDER BY Abbrv ASC");
        }
        public void PopulateStudent()
        {
            string query = "SELECT s.StudentID ,s.StudNum , s.FName , s.LName , s.Section , s.Status , c.CourseID , 0 AS IsEdited FROM tblstudent s INNER JOIN tblcourse c " +
                            "ON s.CourseID = c.CourseID  WHERE s.Status = 'Active'  AND s.UserID = "+userid+" " +
                            "ORDER BY LName ASC";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            { btnDelete.Enabled = false; }
            else
                btnDelete.Enabled = true;
            grdStudents.DataSource = db.SelectQuery(query);
        }
        private void SaveAllUpdatedList()
        {
            ViewStudents.CloseEditForm();
            ViewStudents.UpdateCurrentRow();
            List<string> updateQueries = new List<string>();
          

            for (int i = 0; i < ViewStudents.RowCount; i++)
            {
                if (ViewStudents.GetRowCellValue(i, "IsEdited").ToString().Equals("1"))
                {
                    long courseID = Convert.ToInt64(ViewStudents.GetRowCellValue(i, "CourseID"));
                    string section1 = db.GetValue("SELECT * FROM tblcourse WHERE CourseID = " + courseID + " ", "Abbrv");
                    long StudID = Convert.ToInt64(ViewStudents.GetRowCellValue(i, "StudentID"));
                    string StudNum = ViewStudents.GetRowCellValue(i, "StudNum").ToString();
                    string fname  = ViewStudents.GetRowCellValue(i , "FName").ToString();
                    string lname = ViewStudents.GetRowCellValue(i , "LName").ToString();
                    string section = ViewStudents.GetRowCellValue( i , "Section").ToString();
                    string status = ViewStudents.GetRowCellValue(i, "Status").ToString();
                    string query = "UPDATE attendance_db.tblstudent SET StudNum = "+ StudNum +" , FName = '"+ db.CorrectCasing(fname) +"' ,LName = '"+ db.CorrectCasing(lname) +"', "+
                                    "Section = '"+ section.ToUpper() +"' , Status = 'Active' , CourseID = "+courseID+"  WHERE StudentID = "+ StudID +";";
                    updateQueries.Add(query);
                }
                else if (ViewStudents.GetRowCellValue(i, "IsEdited").ToString().Equals("2"))
                {
                    if (InputValidation(""))
                    {
                        string StudNum = ViewStudents.GetRowCellValue(i, "StudNum").ToString();
                        string fName = ViewStudents.GetRowCellValue(i, "FName").ToString();
                        string lName = ViewStudents.GetRowCellValue(i, "LName").ToString();
                        string section = ViewStudents.GetRowCellValue(i, "Section").ToString();
                        long courseID = Convert.ToInt64(ViewStudents.GetRowCellValue(i, "CourseID"));
                        string section1 = db.GetValue("SELECT * FROM tblcourse WHERE CourseID = " + courseID + " ", "Abbrv");
                        string query = "INSERT INTO `attendance_db`.`tblstudent` (`StudNum`, `FName`, `LName`, `Section`, `Status`, `CourseID` , UserID) " +
                                       "VALUES ('" + StudNum + "', '" + db.CorrectCasing(fName) + "', '" + db.CorrectCasing(lName) + "', '" + section1 + section.ToUpper() + "', 'Active', " + courseID + " , " + userid + ")";
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
                        grdStudents.DataSource = null;
                        PopulateStudent();
                    }
                }
                else
                    PopulateStudent();
            }
            DateTime dateValue = DateTime.Now;
        }

        public bool InputValidation( string cons)
        {
            for (int i = 0; i < ViewStudents.RowCount; i++)
            {
                if (ViewStudents.GetRowCellValue(i, "IsEdited").ToString().Equals("2"))
                {
                    string studNum1 = ViewStudents.GetRowCellValue(i, "StudNum").ToString();
                    string fname = ViewStudents.GetRowCellValue(i, "FName").ToString();
                    string query = "SELECT * FROM tblstudent WHERE StudNum = " + studNum1 + " AND UserID = "+userid+"" + cons;
                    DataTable dt = db.SelectQuery(query);
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("Student already exist", "Duplicate",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PopulateStudent();
                        return false;
                    }
                }
            }
            return true;
        }

        private void ViewStudents_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (ViewStudents.GetRowCellValue(e.RowHandle, "IsEdited") == null)
                {
                    return;
                }
                else if (ViewStudents.GetRowCellValue(e.RowHandle, "IsEdited").ToString().Equals("1"))
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                }
                else if (ViewStudents.GetRowCellValue(e.RowHandle, "IsEdited").ToString().Equals("2"))
                {
                    e.Appearance.BackColor = Color.Beige;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewStudents_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!e.Column.FieldName.ToString().Equals("IsEdited"))
            {
                if (ViewStudents.GetRowCellValue(e.RowHandle, "StudentID").ToString().Equals(""))
                {
                    ViewStudents.SetRowCellValue(e.RowHandle, "IsEdited", "2");
                }
                else
                {
                    ViewStudents.SetRowCellValue(e.RowHandle, "IsEdited", "1");
                }
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

        private void ViewStudents_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void ViewStudents_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = (GridView)sender;
            view.SetRowCellValue(e.RowHandle, view.Columns["IsEdited"], "2");
           // view.SetRowCellValue(e.RowHandle, view.Columns["CourseID"], " ");
            //view.SetRowCellValue(e.RowHandle, view.Columns["Status"], " ");
            //view.SetRowCellValue(e.RowHandle, view.Columns["Section"], " ");
            //view.SetRowCellValue(e.RowHandle, view.Columns["LName"], " ");
            //view.SetRowCellValue(e.RowHandle, view.Columns["FName"], " ");
            view.SetRowCellValue(e.RowHandle, view.Columns["StudNum"], " ");
        }

        private void ViewStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ViewStudents.CancelUpdateCurrentRow();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = "SELECT s.StudentID ,s.StudNum , s.FName , s.LName , s.Section , s.Status , c.CourseID , 0 AS IsEdited FROM tblstudent s INNER JOIN tblcourse c " +
                           "ON s.CourseID = c.CourseID  WHERE s.Status = 'Active'  AND s.UserID = " + userid + " " +
                           "ORDER BY LName ASC";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            { btnDelete.Enabled = false; }
            else
                btnDelete.Enabled = true;
            hasNewStudents = !hasNewStudents;
            if (hasNewStudents)
            {
                ViewStudents.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
                ViewStudents.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
                ViewStudents.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
                ViewStudents.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
                ViewStudents.OptionsBehavior.ReadOnly = false;

            }
            else
            {
                ViewStudents.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
                ViewStudents.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
                ViewStudents.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
                ViewStudents.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                ViewStudents.OptionsBehavior.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAllUpdatedList();
            inserttoclass();
        }
        List<string> stids = new List<string>();
        public void inserttoclass()
        {
            stids.Clear();
            string qu = "SELECT * FROM tblstudent WHERE UserID = " + userid + "";
            DataTable tab = db.SelectQuery(qu);
            foreach (DataRow r in tab.Rows)
                stids.Add(r["StudentID"].ToString());
            foreach (string s in stids)
            {
                string quer = "SELECT * FROM tblsubjectclass WHERE StudID = "+s+" AND UserID = "+userid+"";
                DataTable tb = db.SelectQuery(quer);
                if(tb.Rows.Count == 0)
                {
                    string insert = "INSERT INTO tblsubjectclass(StudID,SubjectID , ScheduleID , UserID) VALUES("+s+", 0 ,0 ,"+userid+")";
                    db.InsertQuery(insert);
                }
            }
        }
        private void gridStudents_Click(object sender, EventArgs e)
        {

        }

        private void ViewStudents_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ValidateNumberData(ref sender, ref e, "StudNum", "Please enter a number", false);
           // ValidateRequiredFields(ref sender, ref e, "StudNum", "Please enter  the student number", false);     
            ValidateRequiredFields(ref sender, ref e, "FName", "Please enter  the firstname", false);
            ValidateRequiredFields(ref sender, ref e, "LName", "Please enter  the lastname", false);
            ValidateRequiredFields(ref sender, ref e, "Section", "Please enter  section", false);
            ValidateRequiredFields(ref sender, ref e, "CourseID", "Please select course", false);
          
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = ViewStudents.GetRowCellValue(selectedIndex, "StudentID").ToString();

            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to delete the student? "+ "\n"  + "Note: All data of this student will also deleted.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string delete = "DELETE FROM tblstudent WHERE StudentID = " + id + " ;";
                int result = db.RunUpdateQuery(delete);

                if (result > 0)
                {
                    MessageBox.Show("Students was deleted.");
                    PopulateStudent();
                }
            }
        }

        private void ViewStudents_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            selectedIndex = e.FocusedRowHandle;
        }

        private void RepoCourses_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
            DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
            object value = row["Abbrv"];
        }
    }
}
