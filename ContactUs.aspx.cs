using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class ContactUs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblMessage.Text = "";
        lblError.Text = "";
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string email = txtEmail.Text.Trim();
        string subject = txtSubject.Text.Trim();
        string message = txtMessage.Text.Trim();

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(message))
        {
            lblError.Text = "All fields are required.";
            return;
        }

        string connectionString = ConfigurationManager.ConnectionStrings["OTeachingConnectionString"].ConnectionString;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO ContactUs (Name, Email, Subject, Message) VALUES (@Name, @Email, @Subject, @Message)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Subject", subject);
            cmd.Parameters.AddWithValue("@Message", message);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Your message has been submitted successfully!";
                ClearForm();
            }
            catch (Exception ex)
            {
                lblError.Text = "An error occurred while submitting your message. Please try again later.";
            }
        }
    }

    private void ClearForm()
    {
        txtName.Text = "";
        txtEmail.Text = "";
        txtSubject.Text = "";
        txtMessage.Text = "";
    }
}
