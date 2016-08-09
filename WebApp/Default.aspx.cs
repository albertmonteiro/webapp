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
using System.Web.Security;
using System.Diagnostics;
using System.IO;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            validateUser();
        }

        private void validateUser()
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings.Get("ConnInfo"));

            conn.Open();
            string checkuser = "select count(*) from userregistration where username='" + usernameTextBox.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPasswordQuery = "select password from userregistration where username='" + usernameTextBox.Text + "'";
                SqlCommand passComm = new SqlCommand(checkPasswordQuery, conn);
                string password = passComm.ExecuteScalar().ToString();
                if (password == passwordTextBox.Text)
                {
                    lblMessage.Text = "Password is correct!";
                }
                else
                {
                    lblMessage.Text = "Password is NOT correct!";
                }
            }
            else
            {
                lblMessage.Text = "Username is NOT correct!";
            }
        }

    }
}