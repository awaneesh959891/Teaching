using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Admin_ReportView : System.Web.UI.Page
{
    DS_REGI.StudentMst_SELECTDataTable StuDT = new DS_REGI.StudentMst_SELECTDataTable();
    DS_REGITableAdapters.StudentMst_SELECTTableAdapter StuAdapter = new DS_REGITableAdapters.StudentMst_SELECTTableAdapter();
    DS_STAFF.STAFFMST_SELECTDataTable SDT = new DS_STAFF.STAFFMST_SELECTDataTable();
    DS_STAFFTableAdapters.STAFFMST_SELECTTableAdapter SAdapter = new DS_STAFFTableAdapters.STAFFMST_SELECTTableAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindCombinedData();
        }
    }

    private void BindCombinedData()
    {
        // Fetch staff data
        SDT = SAdapter.select();

        // Fetch user data
        StuDT = StuAdapter.Select();

        // Create a new DataTable to combine both datasets
        DataTable combinedData = new DataTable();

        // Add columns to the combined DataTable
        combinedData.Columns.Add("RecordType", typeof(string));
        combinedData.Columns.Add("SID", typeof(int));
        combinedData.Columns.Add("Name", typeof(string));
        combinedData.Columns.Add("Mobile", typeof(string));
        combinedData.Columns.Add("Address", typeof(string));
        combinedData.Columns.Add("City", typeof(string));
        combinedData.Columns.Add("Pincode", typeof(string));
        combinedData.Columns.Add("Image", typeof(string));
        combinedData.Columns.Add("Qualification", typeof(string));
        combinedData.Columns.Add("Experience", typeof(string));
        combinedData.Columns.Add("CourseName", typeof(string));
        combinedData.Columns.Add("Email", typeof(string));
        combinedData.Columns.Add("Course", typeof(string));
        combinedData.Columns.Add("Uname", typeof(string));
        combinedData.Columns.Add("EDate", typeof(string));

        // Add staff data to the combined DataTable
        foreach (DataRow row in SDT.Rows)
        {
            combinedData.Rows.Add(
                "Staff",
                row["SID"],
                row["Name"],
                row["Mobile"],
                row["Address"],
                row["City"],
                row["Pincode"],
                row["Image"],
                row["Qualification"],
                row["Experience"],
                row["CName"],
                row["Email"],
                DBNull.Value, // Course (not applicable for staff)
                DBNull.Value, // Uname (not applicable for staff)
                DBNull.Value  // EDate (not applicable for staff)
            );
        }

        // Add user data to the combined DataTable
        foreach (DataRow row in StuDT.Rows)
        {
            combinedData.Rows.Add(
                "User",
                row["SID"],
                row["Name"],
                row["Mobile"],
                row["Address"],
                row["City"],
                row["Pincode"],
                row["Image"],
                DBNull.Value, // Qualification (not applicable for users)
                DBNull.Value, // Experience (not applicable for users)
                DBNull.Value, // CourseName (not applicable for users)
                row["Email"],
                row["Course"],
                row["Uname"],
                row["EDate"]
            );
        }

        // Bind the combined data to the GridView
        GridView1.DataSource = combinedData;
        GridView1.DataBind();

        // Update the label to show the total number of records
        lbl.Text = combinedData.Rows.Count.ToString();
    }
}
