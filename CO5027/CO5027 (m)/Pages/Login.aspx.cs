using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Pages
{
    public partial class PagesLogin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (logintxt.Text == "admin" && passwordtxt.Text == "admin")
            {
                Response.Redirect("~/Manage/JustMovie.aspx");
            }
            else
            {

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                connection.Open();
                string authenticateuser = "select count(*) from TblMoviePeople where LoginUsername='" + logintxt.Text + "'";
                SqlCommand com = new SqlCommand(authenticateuser, connection);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    string checkPasswordQuery = "select UserPasscode from TblMoviePeople where LoginUsername='" + logintxt.Text + "'";
                    SqlCommand passCom = new SqlCommand(checkPasswordQuery, connection);
                    string password = passCom.ExecuteScalar().ToString().Replace(" ", "");
                    if (password == passwordtxt.Text)
                    {
                        Session["New"] = logintxt.Text;
                        Response.Write("Password is correct");
                        Response.Redirect("~/Member/Contact.aspx");
                    }
                    else
                    {
                        Response.Write("Password is incorrect");
                        Response.Redirect("Login.aspx");
                    }

                }
                else
                {
                    Response.Write("Username is incorrect");
                }
                connection.Close();

            }



        }

    }
}