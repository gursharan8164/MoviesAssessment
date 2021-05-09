using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesAssessment
{
    public class Data
    {
        // sets up connections to the DB
        SqlConnection Connection = new SqlConnection();
        SqlCommand Command = new SqlCommand();

        //sets up the datatables for the presentation
        DataTable CustomerTable = new DataTable();
        DataTable MovieTable = new DataTable();
        DataTable RentedMovieTable = new DataTable();
        DataTable RentedMoviesOnlyTable = new DataTable();
        DataTable BestCustomersTable = new DataTable();
        DataTable TopMoviesTable = new DataTable();
        public SqlDataAdapter da = new SqlDataAdapter();
        public string[] AllCusttextboxes { get; set; }
        public string[] AllMovtextboxes { get; set; }
        public string[] AllTextBoxes { get; set; }

        public Data()
        {
            // sets up the connection string and links to database
            Connection.ConnectionString = SqlCalls.ConString;
            Command.Connection = Connection;
        }

        public string ReturnCountofMovies()
        {
            // returns the count of the total number of movies in the database
            string answer = "";

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand Command = new SqlCommand(SqlCalls.CountOfMoviesSql, connection);
                connection.Open();
                answer = Command.ExecuteScalar().ToString();
                connection.Close();
                return answer;
            }
        }

        public string ReturnCountofCustomers()
        {
            // returns the count of the total number of customers in the database
            string answer = "";

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand Command = new SqlCommand(SqlCalls.CountOfCustomersSql, connection);
                connection.Open();
                answer = Command.ExecuteScalar().ToString();
                connection.Close();
                return answer;
            }
        }

        public string ReturnCountofCustomersRented()
        {
            // returns the count of the total number of customers in the database
            string answer = "";

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand Command = new SqlCommand(SqlCalls.CountOfCustomersRentedSql, connection);
                connection.Open();
                answer = Command.ExecuteScalar().ToString();
                connection.Close();
                return answer;
            }
        }

        public string ReturnCountofMoviesRented()
        {
            // returns the count of the total number of customers in the database
            string answer = "";

            using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
            {
                SqlCommand Command = new SqlCommand(SqlCalls.CountOfMoviesRentedSql, connection);
                connection.Open();
                answer = Command.ExecuteScalar().ToString();
                connection.Close();
                return answer;
            }
        }

        public DataTable LoadDGVCustomers()
        {
            DataTable dt = new DataTable();

            try
            {
                // add items to the customer data grid view from database
                CustomerTable.Clear();

                using (da = new SqlDataAdapter(SqlCalls.LoadDBVCustomersSql, Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                    //fill the datatable from the SQL
                    Connection.Close(); //close the connection
                }

            }

            catch
            {

            }

            return dt;

        }

        public DataTable LoadDGVMovies()
        {
            DataTable dt = new DataTable();

            try
            {
                // add items to the customer data grid view from database
                MovieTable.Clear();

                using (da = new SqlDataAdapter(SqlCalls.LoadDBVMoviesSql, Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                    //fill the datatable from the SQL
                    Connection.Close(); //close the connection
                }
            }

            catch
            {

            }

            return dt;

        }

        public DataTable LoadDGVRentedMovies()
        {
            DataTable dt = new DataTable();

            // add items to the rented data grid view from database
            RentedMovieTable.Clear();

            try
            {
                using (da = new SqlDataAdapter(SqlCalls.LoadDBVRentMoviesSql, Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                    //fill the datatable from the SQL
                    Connection.Close(); //close the connection
                }
            }

            catch
            {

            }

            return dt;
        }

        public DataTable ShowRentedMoviesOnly()
        {
            DataTable dt = new DataTable();

            RentedMoviesOnlyTable.Clear();

            try
            {
                using (da = new SqlDataAdapter(SqlCalls.ShowRentedMoviesOnlySql, Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                    //fill the datatable from the SQL
                    Connection.Close(); //close the connection
                }
            }

            catch
            {

            }

            return dt;
        }

        public DataTable LoadDGVBestCustomers()
        {
            DataTable dt = new DataTable();

            try
            {
                // add items to the rented data grid view from database
                BestCustomersTable.Clear();

                using (da = new SqlDataAdapter(SqlCalls.CustomerRentedCountSql, Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                    //fill the datatable from the SQL
                    Connection.Close(); //close the connection
                }
            }

            catch
            {

            }

            return dt;
        }

        public DataTable LoadDGVTopMovies()
        {
            DataTable dt = new DataTable();

            try
            {
                // add items to the rented data grid view from database
                TopMoviesTable.Clear();

                using (da = new SqlDataAdapter(SqlCalls.TopRentedMoviesSql, Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                    //fill the datatable from the SQL
                    Connection.Close(); //close the connection
                }
            }

            catch
            {

            }

            return dt;
        }

        public void UpdateCust(string[] Alltextboxes) //Update customer details to the DB
        {
            try
            {
                // this puts the parameters into the code so that data in the txtboxes is added to the DB
                using (SqlCommand update = new SqlCommand(SqlCalls.UpdateSqlCust, Connection))
                {
                    // dont add in ID as its auto incrementing so Alltextboxes[0] is not called
                    update.Parameters.AddWithValue("@CustID", Alltextboxes[0]);
                    update.Parameters.AddWithValue("@FirstName", Alltextboxes[1]);
                    update.Parameters.AddWithValue("@LastName", Alltextboxes[2]);
                    update.Parameters.AddWithValue("@Address", Alltextboxes[3]);
                    update.Parameters.AddWithValue("@Phone", Alltextboxes[4]);
                    update.Parameters.AddWithValue("@Date", Alltextboxes[5]);

                    Connection.Open();//Open the connection

                    update.ExecuteNonQuery();//Execute the nonquery as it doesn't return any data its only going up to the DB server

                    Connection.Close();//Close the connection
                }
            }

            catch
            {

            }

        }

        public void UpdateMov(string[] Alltextboxes) //Update movie details to the DB
        {
            try
            {
                // this puts the parameters into the code so that data in the txtboxes is added to the DB
                using (SqlCommand update = new SqlCommand(SqlCalls.UpdateSqlMov, Connection))
                {
                    // dont add in ID as its auto incrementing so Alltextboxes[0] is not called
                    update.Parameters.AddWithValue("@MovieID", Alltextboxes[0]);
                    update.Parameters.AddWithValue("@Title", Alltextboxes[1]);
                    update.Parameters.AddWithValue("@Year", Alltextboxes[2]);
                    update.Parameters.AddWithValue("@Date", Alltextboxes[3]);
                    update.Parameters.AddWithValue("@Genre", Alltextboxes[4]);
                    update.Parameters.AddWithValue("@Rating", Alltextboxes[5]);
                    update.Parameters.AddWithValue("@Plot", Alltextboxes[6]);
                    update.Parameters.AddWithValue("@Rental_Cost", Alltextboxes[7]);

                    Connection.Open();//Open the connection

                    update.ExecuteNonQuery();//Execute the nonquery as it doesn't return any data its only going up to the DB server

                    Connection.Close();//Close the connection
                }

            }

            catch
            {

            }

        }

        public string AddNewDataCust(string[] Alltextboxes) //Add a new customer to the DB
        {
            try
            {
                // this puts the parameters into the code so that data in the txtboxes is added to the DB
                using (SqlCommand Com = new SqlCommand(SqlCalls.AddNewDataSqlCust, Connection))
                {
                    // dont add in ID as its auto incrementing so Alltextboxes[0] is not called
                    Com.Parameters.AddWithValue("@CustID", Alltextboxes[0]);
                    Com.Parameters.AddWithValue("@FirstName", Alltextboxes[1]);
                    Com.Parameters.AddWithValue("@LastName", Alltextboxes[2]);
                    Com.Parameters.AddWithValue("@Address", Alltextboxes[3]);
                    Com.Parameters.AddWithValue("@Phone", Alltextboxes[4]);
                    Com.Parameters.AddWithValue("@Date", Alltextboxes[5]);

                    Connection.Open();//Open the connection

                    Com.ExecuteNonQuery();//Execute the nonquery as it doesn't return any data its only going up to the DB server

                    Connection.Close();//Close the connection

                    //return Alltextboxes[1] + " " + Alltextboxes[2] + " has been inserted ! ";

                }
            }

            catch
            {

            }

            return Alltextboxes[1] + " " + Alltextboxes[2] + " has been inserted ! ";

        }

        public string AddNewDataMov(string[] Alltextboxes) //Add a new movie to the DB
        {
            try
            {
                // this puts the parameters into the code so that data in the txtboxes is added to the DB
                using (SqlCommand Com = new SqlCommand(SqlCalls.AddNewDataSqlMov, Connection))
                {
                    // dont add in ID as its auto incrementing so Alltextboxes[0] is not called
                    Com.Parameters.AddWithValue("@MovieID", Alltextboxes[0]);
                    Com.Parameters.AddWithValue("@Title", Alltextboxes[1]);
                    Com.Parameters.AddWithValue("@Year", Alltextboxes[2]);
                    Com.Parameters.AddWithValue("@Date", Alltextboxes[3]);
                    Com.Parameters.AddWithValue("@Genre", Alltextboxes[4]);
                    Com.Parameters.AddWithValue("@Rating", Alltextboxes[5]);
                    Com.Parameters.AddWithValue("@Plot", Alltextboxes[6]);

                    Connection.Open();//Open the connection

                    Com.ExecuteNonQuery();//Execute the nonquery as it doesn't return any data its only going up to the DB server

                    Connection.Close();//Close the connection

                    //return Alltextboxes[1] + " has been inserted ! ";

                }

            }

            catch
            {

            }

            return Alltextboxes[1] + " has been inserted ! ";

        }

        public void IssueMovie(string CustID, string MovieID, string DateIssued, string DateReturn) //Issue a movie to the customer from the DB
        {
            try
            {
                // this puts the parameters into the code so that data in the txtboxes is added to the DB
                using (SqlCommand Com = new SqlCommand(SqlCalls.AddNewDataSqlRented, Connection))
                {
                    Com.Parameters.AddWithValue("@CustIDFK", CustID);
                    Com.Parameters.AddWithValue("@MovieIDFK", MovieID);
                    Com.Parameters.AddWithValue("@DateRented", DateIssued);
                    Com.Parameters.AddWithValue("@DateReturned", DateReturn);

                    Connection.Open();//Open the connection

                    Com.ExecuteNonQuery();//Execute the nonquery as it doesn't return any data its only going up to the DB server

                    Connection.Close();//Close the connection
                }

            }

            catch
            {

            }


        }

        public void ReturnMovie(string ID, string Datereturned) //Return a movie from the customer to the DB
        {
            try
            {
                // this puts the parameters into the code so that data in the txtboxes is added to the DB
                using (SqlCommand update = new SqlCommand(SqlCalls.UpdateDataSqlRented, Connection))
                {
                    update.Parameters.AddWithValue("@RMID", ID);
                    update.Parameters.AddWithValue("@DateReturned", Datereturned);

                    Connection.Open();//Open the connection

                    update.ExecuteNonQuery();//Execute the nonquery as it doesn't return any data its only going up to the DB server

                    Connection.Close();//Close the connection
                }

            }

            catch
            {

            }

        }

        public void DeleteCust(string CustID) // Delete a customer out of database
        {
            try
            {
                using (SqlCommand DeleteCust = new SqlCommand(SqlCalls.DeleteByIDCust, Connection))
                {
                    DeleteCust.Parameters.AddWithValue("@CustID", CustID);

                    Connection.Open();
                    DeleteCust.ExecuteNonQuery();
                    Connection.Close();
                }
            }

            catch
            {

            }

        }

        public void DeleteMov(string MovID) // Delete a movie out of database
        {
            try
            {
                using (SqlCommand DeleteMov = new SqlCommand(SqlCalls.DeleteByIDMov, Connection))
                {
                    DeleteMov.Parameters.AddWithValue("@MovieID", MovID);

                    Connection.Open();
                    DeleteMov.ExecuteNonQuery();
                    Connection.Close();
                }
            }

            catch
            {

            }

        }
    }
}
