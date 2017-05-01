using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using Entities;

public partial class Pages_Addproducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string selectedValue = ddlImage.SelectedValue;
        ShowImages();
        ddlImage.SelectedValue = selectedValue;
    }


    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        try
        {
            string filedirectoryname = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/ProductImage/") + filedirectoryname);
            lblResult.Text = "Image " + filedirectoryname + " Image Uploaded Successfully!";
            Page_Load(sender, e);
        }
        catch (Exception)
        {
            lblResult.Text = "Upload Unsuccessful!";
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            string movieName = movieNametxt.Text;
            string amountMovie = amountMovietxt.Text;
            double totalPrice = Convert.ToDouble(totalPricetxt.Text);
            totalPrice = totalPrice / 100;
            string movieImage = "../ProductImage/" + ddlImage.SelectedValue;


            movies movieList = new movies (movieName, amountMovie, totalPrice, movieImage);
            mothercode.AddProduct(movieList);
            lblResult.Text = "Upload succesful!";
            ClearTextFields();
        }
        catch (Exception)
        {
            lblResult.Text = "Upload failed!";
        }
    }

    private void ShowImages()
    {
        //Get all filepaths
        string[] images = Directory.GetFiles(Server.MapPath("~/ProductImage/"));

        //Get all filenames and add them to an arraylist
        ArrayList imageList = new ArrayList();

        foreach (string image in images)
        {
            string imageName = image.Substring(image.LastIndexOf(@"\") + 1);
            imageList.Add(imageName);
        }

        //Set the arrayList as the dropdownview's datasource and refresh
        ddlImage.DataSource = imageList;
        ddlImage.DataBind();
    }

    private void ClearTextFields()
    {
        
        movieNametxt.Text = "";
        amountMovietxt.Text = "";
        totalPricetxt.Text = "";


    }



}