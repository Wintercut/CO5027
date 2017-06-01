using System;

namespace Entities
{
    public class Order
    {
        public int orderid { get; set; }
        public string buyername { get; set; }
        public string moviebought { get; set; }
        public int amountbought { get; set; }
        public double grandtotal { get; set; }
        public DateTime datepurchase { get; set; }
        public bool orderconfirmed { get; set; }

        public Order(int orderid1, string buyername1, string moviebought1, int amountbought1, double grandtotal1, DateTime datepurchase1, bool orderconfirmed1)
        {
            orderid = orderid1;
            buyername = buyername1;
            moviebought = moviebought1;
            amountbought = amountbought1;
            grandtotal = grandtotal1;
            datepurchase = datepurchase1;
            orderconfirmed = orderconfirmed1;
        }

        public Order(string buyername1, string moviebought1, int amountbought1, double grandtotal1, DateTime datepurchase1, bool orderconfirmed1)
        {
            buyername = buyername1;
            moviebought = moviebought1;
            amountbought = amountbought1;
            grandtotal = grandtotal1;
            datepurchase = datepurchase1;
            orderconfirmed = orderconfirmed1;
        }
    }
}