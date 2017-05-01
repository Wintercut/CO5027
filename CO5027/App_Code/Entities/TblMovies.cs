using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TblMovies
/// </summary>
/// 
namespace Entities
{
    public class movies
    {
        private string type;

        public int MovieID { set; get; }

        public string MovieName { set; get; }

        public string AmountMovie { set; get; }

        public double TotalPrice { set; get; }

        public string MovieImage { set; get; }

        public movies(int movieID, string movieName, string amountMovie, double totalPrice, string movieImage)
        {
            MovieID = movieID;
            MovieName = movieName;
            AmountMovie = amountMovie;
            TotalPrice = totalPrice;
            MovieImage = movieImage;
        }
        public movies(string movieName, string amountMovie, double totalPrice, string movieImage)
        {
            
            MovieName = movieName;
            AmountMovie = amountMovie;
            TotalPrice = totalPrice;
            MovieImage = movieImage;
        }  
    }
}
















