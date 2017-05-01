using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using Entities;

public partial class PagesVisitor_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PageFiller();
    }

    private void PageFiller()
    {
        ArrayList movieList = new ArrayList();

        if (!IsPostBack)
        {
            movieList = mothercode.ShowMovies("%");
        }
        else
        {
            movieList = mothercode.ShowMovies(DropDownList1.SelectedValue);
        }

        StringBuilder ml = new StringBuilder();

        foreach (movies movies in movieList)
        {
            ml.Append(
                string.Format(
                    @"<table class='defaultmovietable'>
                
               <tr>
                  <th rowspan='3'><img runat='server' width='120px' height='180px' src={3} alt='MovieText' /></th>
                  <th>Movie Title: </th><td>{0}</td>
                  
               </tr>   
                <tr>
                  <th>Ticket Price: </th>
                  <td>{2} $</td>
                </tr>
                <tr>
                  <th>Amount left: </th>
                  <td>{1}</td>
                </tr>
              </table>",
                    movies.MovieName, movies.AmountMovie, movies.TotalPrice, movies.MovieImage));
            movielabel.Text = ml.ToString();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        PageFiller();
    }
}