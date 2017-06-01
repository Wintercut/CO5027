using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from TblMoviePeople where LoginUsername='" + nametxt.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already Exist");
            }
            conn.Close();
        }

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            Guid newGUID = Guid.NewGuid();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
            conn.Open();
            string insertQuery =
                "insert into TblMoviePeople (MoviePeopleID,LoginUsername,UserEmail,UserPasscode) values (@MoviePeopleID ,@LoginUsername ,@UserEmail ,@UserPasscode)";
            SqlCommand com = new SqlCommand(insertQuery, conn);

            com.Parameters.AddWithValue("@MoviePeopleID", newGUID.ToString());
            com.Parameters.AddWithValue("@LoginUsername", nametxt.Text);
            com.Parameters.AddWithValue("@UserEmail", emailtxt.Text);
            com.Parameters.AddWithValue("@UserPasscode", passwordtxt.Text);

            com.ExecuteNonQuery();
            Response.Redirect("Login.aspx");
            Response.Write("Registration is successful");

            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error:" + ex.ToString());
        }
    }
}