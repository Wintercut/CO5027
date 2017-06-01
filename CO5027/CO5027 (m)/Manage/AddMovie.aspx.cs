using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI;

namespace Manage
{
    public partial class ManageAddMovie : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = dropdownimageslist.SelectedValue;
            ShowImagesfromdb();
            dropdownimageslist.SelectedValue = value;
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from TblMovies where MovieName='" + movieNametxt.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    Response.Write("Produ");
                }
                conn.Close();
            }
        }

        private void ClearTextFields()
        {
            movieNametxt.Text = "";
            amountMovietxt.Text = "";
            totalPricetxt.Text = "";
           
        }
        protected void UploadsImageClick(object sender, EventArgs e)
        {
            try
            {
                string filedirectoryname = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/ProductImage/") + filedirectoryname);
                result.Text = "Image " + filedirectoryname + " Image Uploaded Successfully!";
                Page_Load(sender, e);
            }
            catch (Exception)
            {
                result.Text = "Upload Unsuccessful!";
            }
        }

        protected void Save(object sender, EventArgs e)
        {

            try
            {
                Guid newGUID = Guid.NewGuid();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                conn.Open();
                string query =
                    "insert into TblMovies (MovieId,MovieName,AmountMovie,TotalPrice, MovieImage, MovieText) values (@MovieId ,@MovieName ,@AmountMovie ,@TotalPrice, @MovieImage, @MovieText )";
                SqlCommand com = new SqlCommand(query, conn);

                com.Parameters.AddWithValue("@MovieId", newGUID.ToString());
                com.Parameters.AddWithValue("@MovieName", movieNametxt.Text);
                com.Parameters.AddWithValue("@AmountMovie", amountMovietxt.Text);
                com.Parameters.AddWithValue("@TotalPrice", totalPricetxt.Text);
                com.Parameters.AddWithValue("@MovieImage", "../ProductImage/" + dropdownimageslist.SelectedValue);
                com.Parameters.AddWithValue("@MovieText", movietxt.Text);

                com.ExecuteNonQuery();

                Response.Write("Movie Registration is successful");

                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

        private void ShowImagesfromdb()
        {

            string[] images = Directory.GetFiles(Server.MapPath("~/ProductImage/"));


            ArrayList dataSource = new ArrayList();

            foreach (string image in images)
            {
                string s = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                dataSource.Add(s);
            }


            dropdownimageslist.DataSource = dataSource;
            dropdownimageslist.DataBind();
        }




    }
}