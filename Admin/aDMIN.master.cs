using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_aDMIN : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button6_Click(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void btnDownloadReport_Click(object sender, EventArgs e)
    {
        // Fetch data from the database  
        DS_STAFFTableAdapters.STAFFMST_SELECTTableAdapter staffAdapter = new DS_STAFFTableAdapters.STAFFMST_SELECTTableAdapter();
        DataTable staffData = staffAdapter.select(); // Corrected method name to 'select' as per the provided type signature  

        // Create a GridView to render the data  
        GridView gridView = new GridView();
        gridView.DataSource = staffData;
        gridView.DataBind();

        // Export to Excel  
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=StaffReport.xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";

        using (StringWriter sw = new StringWriter())
        {
            using (HtmlTextWriter hw = new HtmlTextWriter(sw))
            {
                gridView.RenderControl(hw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }
    }

    // Removed the override keyword as the base class System.Web.UI.MasterPage does not contain a method named VerifyRenderingInServerForm.  
    public void VerifyRenderingInServerForm(Control control)
    {
        // Required for rendering GridView to HTML  
    }
}
