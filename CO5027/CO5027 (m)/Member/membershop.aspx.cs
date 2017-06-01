using System;
using System.Collections;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;

namespace Member
{
    public partial class MemberShop : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ControlCreation();
        }
        protected void ConfirmaClick(object sender, EventArgs e)
        {
            DatabaseAdd();
            finished.Text = "Your Ticket has been set, thank you for booking at Movies & Co";
            confirm.Visible = false;
            cancel.Visible = false;
        }

        protected void Cancel(object sender, EventArgs e)
        {
            Session["orders"] = null;
            confirm.Visible = false;
            cancel.Visible = false;
            finished.Visible = false;
        }

        protected void Order(object sender, EventArgs e)
        {
            Transcript();
        }

        private void ControlCreation()
        {
            ArrayList movieList = Mothercode.ShowMovies("%");
            foreach (TblMovies movie in movieList)
            {
            
                Panel moviePanel = new Panel();
                Image movieimage = new Image { ImageUrl = movie.MovieImage, CssClass = "ProductsImage" };
                Literal literalno1 = new Literal { Text = "<br />" };
                Literal literalno2 = new Literal { Text = "<br />" };
                Label movienamelabel = new Label { Text = movie.MovieName, CssClass = "ProductsName" };
                Label moviepricelabel = new Label
                {
                    Text = String.Format("{0:0.00}", "$" + movie.TotalPrice + "<br />"),
                    CssClass = "ProductsPrice"
                };
                TextBox textBox = new TextBox
                {
                    
                    ID = "txtbox" + Guid.NewGuid().ToString("N"),
                    CssClass = "ProductsTextBox",
                    Width = 60,
                    Text = "0"
                };

            
                RegularExpressionValidator regex = new RegularExpressionValidator
                {
                    ValidationExpression = "^[0-9]*",
                    ControlToValidate = textBox.ID,
                    ErrorMessage = "Please enter a number."
                };

               
                moviePanel.Controls.Add(movieimage);
                moviePanel.Controls.Add(literalno1);
                moviePanel.Controls.Add(movienamelabel);
                moviePanel.Controls.Add(literalno2);
                moviePanel.Controls.Add(moviepricelabel);
                moviePanel.Controls.Add(textBox);
                moviePanel.Controls.Add(regex);

                pnlProducts.Controls.Add(moviePanel);
            }
        }

        
        private ArrayList GetOrders()
        {
            
            ContentPlaceHolder cph = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            ControlFinder<TextBox> cf = new ControlFinder<TextBox>();
            cf.FindChildControlsRecursive(cph);
            var textBoxList = cf.FoundControls;

            
            ArrayList orderList = new ArrayList();

            foreach (TextBox textBox in textBoxList)
            {
                
                if (textBox.Text != "")
                {
                    int amountOfOrders = Convert.ToInt32(textBox.Text);

                    
                    if (amountOfOrders > 0)
                    {
                        TblMovies movies = Mothercode.GetMoviesById(Convert.ToInt32(textBox.ID));
                        Order order = new Order(
                            Session["New"].ToString(), movies.MovieName, amountOfOrders, movies.TotalPrice, DateTime.Now, false);

                        
                        orderList.Add(order);
                    }
                }
            }
            return orderList;
        }

        
        private void Transcript()
        {
            double totalAmount = 0;
            ArrayList orderList = GetOrders();
            Session["orders"] = orderList;

            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");
            sb.Append("<h3>Please review your order</h3>");

            
            foreach (Order order in orderList)
            {
                double totalRow = order.grandtotal*order.amountbought;
                sb.Append(String.Format(@"<tr>
                                            <td width = '50px'>{0} X </td>
                                            <td width = '200px'>{1} ({2})</td>
                                            <td>{3}</td><td>€</td>
                                        </tr>", order.amountbought, order.moviebought, order.grandtotal, String.Format("{0:0.00}", totalRow)));
                totalAmount = totalAmount + totalRow;
            }

            
            sb.Append(String.Format(@"<tr>
                                        <td><b>Total: </b></td>
                                        <td><b>{0} € </b></td>
                                      </tr>", totalAmount));
            sb.Append("</table>");

            
            finished.Text = sb.ToString();
            finished.Visible = true;
            confirm.Visible = true;
            cancel.Visible = true;
        }

        
        private void DatabaseAdd()
        {
            ArrayList orderList = (ArrayList)Session["orders"];
            Mothercode.AddingNewOrders(orderList);
            Session["orders"] = null;
        }

   
    }
}
