using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;

namespace WebApp
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings.Get("ConnInfo"));
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        SqlCommand SelectCommand = new SqlCommand();
        SqlCommand SqlQuery = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerEventMethod(object sender, EventArgs e)
        {
            registerUser();
        }

        private void registerUser()
        {
            SqlQuery.Connection = conn;
            conn.Open();
            SqlQuery.CommandType = CommandType.Text;
            SqlQuery.CommandText = "insert into stationary.dbo.userregistration (firstname, middlename, lastname, email, phonenumber, username, password) values (@firstname, @middlename, @lastname, @email, @phonenumber, @username, @password)";
            SqlQuery.Parameters.Clear();
            SqlQuery.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
            SqlQuery.Parameters.AddWithValue("@middlename", middlenameTextBox.Text);
            SqlQuery.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
            SqlQuery.Parameters.AddWithValue("@email", emailTextBox.Text);
            SqlQuery.Parameters.AddWithValue("@phonenumber", phoneNumberTextBox.Text);
            SqlQuery.Parameters.AddWithValue("@username", usernameTextBox.Text);
            SqlQuery.Parameters.AddWithValue("@password", passwordTextBox.Text);
            SqlQuery.ExecuteNonQuery();
            conn.Close();
        }
    }
}