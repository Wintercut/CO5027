namespace Entities
{
    public class TblMovies
    {
        

        public int MovieId {  get; set; }

        public string MovieName {  get; set; }

        public string AmountMovie {  get; set; }

        public double TotalPrice {  get; set; }

        public string MovieImage {  get; set; }

        public string MovieText { get; set; }


        public TblMovies(int movieid, string moviename, string amountmovie, double totalprice, string movieimage, string movietext)
        {
            MovieId = movieid;
            MovieName = moviename;
            AmountMovie = amountmovie;
            TotalPrice = totalprice;
            MovieImage = movieimage;
            MovieText = movietext;
        }
        public TblMovies(string moviename, string amountmovie, double totalprice, string movieimage, string movietext)
        {

            MovieName = moviename;
            AmountMovie = amountmovie;
            TotalPrice = totalprice;
            MovieImage = movieimage;
            MovieText = movietext;
        }  
    }
}
















