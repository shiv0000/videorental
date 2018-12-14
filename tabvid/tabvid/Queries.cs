using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace tabvid
{
    class Queries
    {
        //Queries executed on program start from From1.cs
        public string LoadAllMovies = "SELECT * FROM Movies";
        public string LoadAllCustomers = "SELECT * FROM Customer";
        public string LoadAllRented = "SELECT * FROM RentedMovies";
        public string LoadTopCustomer = "SELECT TOP (1) dbo.Customer.FirstName, dbo.Customer.LastName, COUNT(dbo.RentedMovies.CustIDFK) AS toprenter FROM dbo.Customer INNER JOIN dbo.RentedMovies ON dbo.Customer.CustID = dbo.RentedMovies.CustIDFK GROUP BY dbo.Customer.FirstName, dbo.Customer.LastName, dbo.RentedMovies.CustIDFK ORDER BY toprenter DESC";
        public string LoadTopMovie = "SELECT TOP (1) Movies.Title, Movies.MovieID, COUNT(RentedMovies.MovieIDFK) AS topmovie FROM Movies INNER JOIN RentedMovies ON Movies.MovieID = RentedMovies.MovieIDFK GROUP BY Movies.Title, Movies.MovieID, RentedMovies.MovieIDFK ORDER BY topmovie DESC";

        public void AddMovieRecord(string Rating, string Title, string Year, string Cost, string Copies, string Plot, string Genre)
        {
            //Creates a connection to the database
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            //Query that is to be sent to the database
            string query = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) VALUES (@Rating, @Title, @Year, @Cost, @Copies, @Plot, @Genre)";

            SqlCommand AddMovieQuery = new SqlCommand(query, Connection);

            AddMovieQuery.Parameters.AddWithValue("Rating", Rating);
            AddMovieQuery.Parameters.AddWithValue("Title", Title);
            AddMovieQuery.Parameters.AddWithValue("Year", Year);
            AddMovieQuery.Parameters.AddWithValue("Cost", Cost);
            AddMovieQuery.Parameters.AddWithValue("Copies", Copies);
            AddMovieQuery.Parameters.AddWithValue("Plot", Plot);
            AddMovieQuery.Parameters.AddWithValue("Genre", Genre);

            //Opens the previously created connection to the database
            Connection.Open();

            //While the connection is open, executes the query
            AddMovieQuery.ExecuteNonQuery();

            //Closes the connection
            Connection.Close();
        }

        //Following methods follow the same basic structure

        public void UpdateMovieRecord(string id, string Rating, string Title, string Year, string Cost, string Copies, string Plot, string Genre)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            string query = "UPDATE Movies SET Rating = @Rating, Title = @Title, Year = @Year, Rental_Cost = @Cost, Copies = @Copies, Plot = @Plot, Genre = @Genre WHERE MovieID=" + id;

            SqlCommand UpdateMovieQuery = new SqlCommand(query, Connection);

            UpdateMovieQuery.Parameters.AddWithValue("Rating", Rating);
            UpdateMovieQuery.Parameters.AddWithValue("Title", Title);
            UpdateMovieQuery.Parameters.AddWithValue("Year", Year);
            UpdateMovieQuery.Parameters.AddWithValue("Cost", Cost);
            UpdateMovieQuery.Parameters.AddWithValue("Copies", Copies);
            UpdateMovieQuery.Parameters.AddWithValue("Plot", Plot);
            UpdateMovieQuery.Parameters.AddWithValue("Genre", Genre);

            Connection.Open();

            UpdateMovieQuery.ExecuteNonQuery();

            Connection.Close();
        }

        public void DeleteMovieRecord(string id)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            SqlCommand DeleteMovieQuery = new SqlCommand("DELETE FROM Movies WHERE MovieID=@id", Connection);

            DeleteMovieQuery.Parameters.AddWithValue("id", id);

            Connection.Open();

            DeleteMovieQuery.ExecuteNonQuery();

            Connection.Close();
        }

        public void AddCustomer(string Firstname, string Lastname, string Address, string Phone)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            string query = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES (@Firstname, @Lastname, @Address, @Phone)";

            SqlCommand AddCustQuery = new SqlCommand(query, Connection);

            AddCustQuery.Parameters.AddWithValue("Firstname", Firstname);
            AddCustQuery.Parameters.AddWithValue("Lastname", Lastname);
            AddCustQuery.Parameters.AddWithValue("Address", Address);
            AddCustQuery.Parameters.AddWithValue("Phone", Phone);

            Connection.Open();

            AddCustQuery.ExecuteNonQuery();

            Connection.Close();
        }

        public void UpdateCustomer(string id, string Firstname, string Lastname, string Address, string Phone)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            string query = "UPDATE Customer SET FirstName = @Firstname, LastName = @Lastname, Address = @Address, Phone = @Phone WHERE CustID = @id";

            SqlCommand UpdateCustQuery = new SqlCommand(query, Connection);

            UpdateCustQuery.Parameters.AddWithValue("id", id);
            UpdateCustQuery.Parameters.AddWithValue("Firstname", Firstname);
            UpdateCustQuery.Parameters.AddWithValue("Lastname", Lastname);
            UpdateCustQuery.Parameters.AddWithValue("Address", Address);
            UpdateCustQuery.Parameters.AddWithValue("Phone", Phone);

            Connection.Open();

            UpdateCustQuery.ExecuteNonQuery();

            Connection.Close();
        }

        public void DeleteCustomer(string id)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            SqlCommand DeleteCustomerQuery = new SqlCommand("DELETE FROM Customer WHERE CustID=@id", Connection);

            DeleteCustomerQuery.Parameters.AddWithValue("id", id);

            Connection.Open();

            DeleteCustomerQuery.ExecuteNonQuery();

            Connection.Close();
        }

        public void RentMovie(string MovieID, string CustID, string RentDate, string ReturnDate)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            string query = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES (@MovieID, @CustID, @RentDate, @ReturnDate)";

            SqlCommand RentQuery = new SqlCommand(query, Connection);

            RentQuery.Parameters.AddWithValue("MovieID", MovieID);
            RentQuery.Parameters.AddWithValue("CustID", CustID);
            RentQuery.Parameters.AddWithValue("RentDate", RentDate);
            RentQuery.Parameters.AddWithValue("ReturnDate", ReturnDate);

            Connection.Open();

            RentQuery.ExecuteNonQuery();

            Connection.Close();
        }

        public void ReturnMovie(string RMID)
        {
            SqlConnection Connection = new SqlConnection(myClass.connectionString);

            string query = "DELETE FROM RentedMovies WHERE RMID = @RMID";

            SqlCommand ReturnQuery = new SqlCommand(query, Connection);

            ReturnQuery.Parameters.AddWithValue("RMID", RMID);

            Connection.Open();

            ReturnQuery.ExecuteNonQuery();

            Connection.Close();
        }
    }
}



    