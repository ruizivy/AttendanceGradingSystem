using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySqlDButilities;
using MySql.Data;
using MySql.Data.MySqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace AttendanceGradingSystem
{
    public partial class frmAddCourse : Form
    {
        MyUtilities db = new MyUtilities();
        DataTable table;
        public static bool hasNewCourse = false;
        int selectedindex = -1;
        public static string userid;
        public frmAddCourse()
        {
            InitializeComponent();
            table = new DataTable();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            PopulateCourse();
        }
        public void PopulateCourse()
        {
            string query = "SELECT * , 0 AS IsEdited FROM tblcourse WHERE IsActive = 'Active'  AND UserID = "+userid+";";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            { btnDelete.Enabled = false; }
            else
                btnDelete.Enabled = true;
            gridCourse.DataSource = db.SelectQuery(query);

        }
        public bool InputValidation(string cons)
        {
            for (int i = 0; i < ViewCourse.RowCount; i++)
            {
                if (ViewCourse.GetRowCellValue(i, "IsEdited").ToString().Equals("2"))
                {
                    string coursename = ViewCourse.GetRowCellValue(i, "CourseName").ToString();
                    string abbrv = ViewCourse.GetRowCellValue(i, "Abbrv").ToString();
                    string query = "SELECT * FROM tblcourse WHERE CourseName = '" + coursename + "' AND Abbrv = '" + abbrv + "' AND UserID = "+userid+"" + cons;
                    DataTable dt = db.SelectQuery(query);
                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show("Duplicate Course Name!!", "Duplicate",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PopulateCourse();
                        return false;
                    }
                }
            }
                return true;
        }
        private void SaveAllUpdatedList()
        {
            ViewCourse.CloseEditForm();
            ViewCourse.UpdateCurrentRow();
            List<string> updateQueries = new List<string>();

            for (int i = 0; i < ViewCourse.RowCount; i++)
            {
                if (ViewCourse.GetRowCellValue(i, "IsEdited").ToString().Equals("1"))
                {
                    long corID = Convert.ToInt64(ViewCourse.GetRowCellValue(i, "CourseID"));
                    string courseName = ViewCourse.GetRowCellValue(i, "CourseName").ToString();
                    string abbrv = ViewCourse.GetRowCellValue(i, "Abbrv").ToString();
                    string query = "UPDATE attendance_db.tblcourse SET CourseName = '"+ courseName +"' , Abbrv ='"+ abbrv.ToUpper() +"' WHERE CourseID = "+corID+"";
                    updateQueries.Add(query);
                        
                }
                else if (ViewCourse.GetRowCellValue(i, "IsEdited").ToString().Equals("2"))
                {
                    if (InputValidation(""))
                    {
                        string courseName = ViewCourse.GetRowCellValue(i, "CourseName").ToString();
                        string abbrv = ViewCourse.GetRowCellValue(i, "Abbrv").ToString();
                        string query = "INSERT INTO attendance_db.tblcourse(CourseName , Abbrv , IsActive , UserID) VALUES('" + db.CorrectCasing(courseName) + "' , '" + abbrv.ToUpper() + "' , 'Active' , "+userid+")";
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
                        gridCourse.DataSource = null;
                        PopulateCourse();
                    }
                }
                else
                    PopulateCourse();
            }
            DateTime dateValue = DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveAllUpdatedList();
        }

        private void ViewCourse_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (ViewCourse.GetRowCellValue(e.RowHandle, "IsEdited") == null)
                {
                    return;
                }
                else if (ViewCourse.GetRowCellValue(e.RowHandle, "IsEdited").ToString().Equals("1"))
                {
                    e.Appearance.BackColor = Color.Aqua;
                }
                else if (ViewCourse.GetRowCellValue(e.RowHandle, "IsEdited").ToString().Equals("2"))
                {
                    e.Appearance.BackColor = Color.Beige;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewCourse_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!e.Column.FieldName.ToString().Equals("IsEdited"))
            {
                if (ViewCourse.GetRowCellValue(e.RowHandle, "CourseID").ToString().Equals(""))
                {
                    ViewCourse.SetRowCellValue(e.RowHandle, "IsEdited", "2");
                }
                else
                {
                    ViewCourse.SetRowCellValue(e.RowHandle, "IsEdited", "1");
                }
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            hasNewCourse = !hasNewCourse;
            string query = "SELECT * , 0 AS IsEdited FROM tblcourse WHERE IsActive = 'Active'  AND UserID = " + userid + ";";
            DataTable dt = db.SelectQuery(query);
            if (dt.Rows.Count == 0)
            { btnDelete.Enabled = false; }
            else
                btnDelete.Enabled = true;
            if (hasNewCourse)
            {
                ViewCourse.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
                ViewCourse.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
                ViewCourse.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.True;
                ViewCourse.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
                ViewCourse.OptionsBehavior.ReadOnly = false;
            }
            else
            {

                ViewCourse.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
                ViewCourse.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
                ViewCourse.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
                ViewCourse.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                ViewCourse.OptionsBehavior.ReadOnly = true;
            }
        }

        private void ViewCourse_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ValidateRequiredFields(ref sender, ref e, "CourseName", "Please enter your course name.", false);
            ValidateRequiredFields(ref sender, ref e, "Abbrv", "Please enter the course abbreviation.", false);

        }

        private void ViewCourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ViewCourse.CancelUpdateCurrentRow();
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

        private void ViewCourse_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            selectedindex = e.FocusedRowHandle;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (selectedindex == 0)return;
            string id = ViewCourse.GetRowCellValue(selectedindex, "CourseID").ToString();
            if (DialogResult.Yes == MessageBox.Show("Are you sure, you want to delete the selected item ? ", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                
                string delete = "UPDATE tblcourse  SET IsActive = 'In-Active' WHERE CourseID = " + id;
                int result = db.RunUpdateQuery(delete);

                if (result > 0)
                {
                    MessageBox.Show("Course was deleted.");
                    PopulateCourse();
                }
            } 
        }

        private void ViewCourse_KeyPress(object sender, KeyPressEventArgs e )
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }
       
    }
}
