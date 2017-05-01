using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entities;





public static class mothercode
{
    private static SqlCommand cmmd;
    private static SqlConnection connection;

    static mothercode()
    {
        string stringconnection = ConfigurationManager.ConnectionStrings["database"].ToString();
        connection = new SqlConnection(stringconnection);
        cmmd = new SqlCommand("", connection);
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
                
                string movieName = reader.GetString(1);
                string amountMovie = reader.GetString(2);
                double totalPrice = reader.GetDouble(3);
                string movieImage = reader.GetString(4);

                movies movies1 = new movies(movieName, amountMovie, totalPrice, movieImage);
                listmovie.Add(movies1);
            }
        }
        finally
        {
            connection.Close();
        }

        return listmovie;
    }

    public static void AddProduct(movies movie)
    {
        string query = string.Format(
            @"INSERT INTO TblMovies VALUES ('{0}', '{1}', @prices, '{2}')",
            movie.MovieName, movie.AmountMovie, movie.TotalPrice, movie.MovieImage);
        cmmd.CommandText = query;
        cmmd.Parameters.Add(new SqlParameter("@prices", movie.TotalPrice));
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
}
    