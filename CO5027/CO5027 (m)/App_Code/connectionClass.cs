using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using Entities;

public static class Mothercode
{
    private static SqlCommand cmmd;
    private static SqlConnection connection;

    static Mothercode()
    {
        string stringconnection = ConfigurationManager.ConnectionStrings["database"].ToString();
        connection = new SqlConnection(stringconnection);
        cmmd = new SqlCommand("", connection);
    }

    #region TblMovies
    

    public static TblMovies GetMoviesById(int movieiD)
    {
        string query = String.Format("SELECT * FROM TblMovies WHERE Movieid =  '{0}'", movieiD);
        TblMovies movies = null;

        try
        {
            connection.Open();
            cmmd.CommandText = query;
            SqlDataReader reader = cmmd.ExecuteReader();

            while (reader.Read())
            {
                int movieid = reader.GetInt32(0);
                string moviename = reader.GetString(1);
                string amountmovie = reader.GetString(2);
                double totalprice = reader.GetDouble(3);
                string movieimage = reader.GetString(4);
                string movietext = reader.GetString(5);

                movies = new TblMovies(movieid,moviename, amountmovie, totalprice, movieimage, movietext);
            }
        }
        finally
        {
            connection.Close();
        }

        return movies;
    }
    public static void AddMovie(TblMovies tblMovies)
    {
        string query = string.Format(
            @"insert into TblMovies VALUES ('{0}', '{1}', @price,'{2}','{3}')", 
            tblMovies.MovieName, tblMovies.AmountMovie, tblMovies.MovieImage, tblMovies.MovieText);
        cmmd.CommandText = query;
        cmmd.Parameters.Add(new SqlParameter("@price", tblMovies.TotalPrice));
  
        try
        {
            connection.Open();
            cmmd.ExecuteNonQuery();
        }
        finally
        {
            connection.Close();
            cmmd.Parameters.Clear();
        }

      
    }

  
    public static void AddingNewOrders(ArrayList orders)
    {
        try
        {
            
            cmmd.CommandText = "INSERT INTO TblOrders VALUES (@buyername, @moviebought, @amountbought, @grandtotal, @datepurchase, @orderconfirmed)";
            connection.Open();

            
            foreach (Order order in orders)
            {
                cmmd.Parameters.Add(new SqlParameter("@buyername", order.buyername));
                cmmd.Parameters.Add(new SqlParameter("@moviebought", order.moviebought));
                cmmd.Parameters.Add(new SqlParameter("@amountbought", order.amountbought));
                cmmd.Parameters.Add(new SqlParameter("@grandtotal", order.grandtotal));
                cmmd.Parameters.Add(new SqlParameter("@datepurchase", order.datepurchase));
                cmmd.Parameters.Add(new SqlParameter("@orderconfirmed", order.orderconfirmed));

                
                cmmd.ExecuteNonQuery();
                cmmd.Parameters.Clear();
            }
        }
        finally
        {
            connection.Close();
        }
    }

    public static ArrayList GetMoviebyName(string movie)
    {
        ArrayList list = new ArrayList();
        string query = string.Format("SELECT * FROM TblMovies WHERE MovieName LIKE '{0}'", movie);


        try
        {
            connection.Open();
            cmmd.CommandText = query;
            SqlDataReader reader = cmmd.ExecuteReader();

            while (reader.Read())

            {
                int movieid = reader.GetInt32(0);
                string moviename = reader.GetString(1);
                string amountmovie = reader.GetString(2);
                double totalprice = reader.GetDouble(3);
                string movieimage = reader.GetString(4);
                string movietext = reader.GetString(5);


                TblMovies movie1 = new TblMovies(movieid, moviename, amountmovie, totalprice, movieimage, movietext);
                list.Add(movie1);
            }
        }
        finally
        {
            connection.Close();
        }

        return list;
    }

    public static ArrayList ShowMovies(string movieName1)
    {
        ArrayList listmovie = new ArrayList();
        string query = string.Format("SELECT * FROM TblMovies WHERE MovieName LIKE '{0}'", movieName1);


        try
        {
            connection.Open();
            cmmd.CommandText = query;
            SqlDataReader reader = cmmd.ExecuteReader();

            while (reader.Read())

            {

                string moviename = reader.GetString(1);
                string amountmovie = reader.GetString(2);
                double totalprice = reader.GetDouble(3);
                string movieimage = reader.GetString(4);
                string movietext = reader.GetString(5);

                TblMovies movies1 = new TblMovies(moviename, amountmovie, totalprice, movieimage, movietext);
                listmovie.Add(movies1);
            }
        }
        finally
        {
            connection.Close();
        }

        return listmovie;
    }

}
    #endregion

