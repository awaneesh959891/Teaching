using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Ensure the page is not cached
        Response.Cache.SetNoStore();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lbl.Text = ""; // Clear any previous error messages

        string username = txtname.Text.Trim();
        string password = txtpasss.Text.Trim();

        // Get the connection string from web.config
        string connectionString = ConfigurationManager.ConnectionStrings["OTeachingConnectionString"].ConnectionString;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            // Query to check if the username and password exist in the AdminMst table
            string query = "SELECT COUNT(*) FROM AdminMst WHERE Username = @Username AND Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            conn.Open();
            int count = (int)cmd.ExecuteScalar(); // Execute the query and get the result

            if (count > 0)
            {
                // Login successful, redirect to AddCategory.aspx
                Response.Redirect("AddCategory.aspx");
            }
            else
            {
                // Login failed, show error message
                lbl.Text = "Invalid Detail";
            }
        }
    }
}
