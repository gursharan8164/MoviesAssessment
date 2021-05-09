namespace MoviesAssessment
{
    public class SqlCalls
    {
        //Connection String to DB
        public static string ConString { get; set; } = @"Data Source=LAPTOP-RAKIOMBV\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
        //Counts the total movies in DB
        public static string CountOfMoviesSql { get; set; } = "SELECT COUNT (MovieID) FROM Movies";
        //Counts the total customers in DB
        public static string CountOfCustomersSql { get; set; } = "SELECT COUNT (CustID) FROM Customer";
        //Counts the total customers that have rented movies
        public static string CountOfCustomersRentedSql { get; set; } = "SELECT COUNT (CustID) FROM CustomersRentedMovies";
        //Counts the total movies that have been rented
        public static string CountOfMoviesRentedSql { get; set; } = "SELECT COUNT (MovieID) FROM MoviesRented";
        //Load all movies from the DB
        public static string LoadDBVMoviesSql { get; set; } = "SELECT * FROM Movies";
        //Load all customers from the DB
        public static string LoadDBVCustomersSql { get; set; } = "SELECT * FROM Customer";
        //Load all rented movies from the DB
        public static string LoadDBVRentMoviesSql { get; set; } = "SELECT * FROM CustomerAndMoviesRented";
        //Add a new customer to the DB
        public static string AddNewDataSqlCust { get; set; } = "INSERT INTO Customer (FirstName, LastName, Address, Phone, Date) VALUES (@FirstName, @LastName, @Address, @Phone, @Date)";
        //Add a new movies to the DB
        public static string AddNewDataSqlMov { get; set; } = "INSERT INTO Movies (Title, Year, Date, Genre, Rating, Plot) VALUES (@Title, @Year, @Date, @Genre, @Rating, @Plot)";
        //Add a new rented movie to the DB
        public static string AddNewDataSqlRented { get; set; } = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES (@MovieIDFK, @CustIDFK, @DateRented, @DateReturned)";
        //Update and return a movie from the DB
        public static string UpdateDataSqlRented { get; set; } = "UPDATE RentedMovies set DateReturned=@DateReturned WHERE RMID=@RMID";
        //Update customer details to the DB
        public static string UpdateSqlCust { get; set; } =
            "UPDATE Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone, Date=@Date WHERE CustID=@CustID";
        //Update movie details to the DB
        public static string UpdateSqlMov { get; set; } =
            "UPDATE Movies set Title=@Title, Year=@Year, Date=@Date, Genre=@Genre, Rating=@Rating, Plot=@Plot, Rental_Cost=@Rental_Cost WHERE MovieID=@MovieID";
        //Delete a customer from the DB using the customer ID
        public static string DeleteByIDCust { get; set; } = "DELETE Customer WHERE CustID = @CustID";
        //Delete a movie from the DB using the movie ID
        public static string DeleteByIDMov { get; set; } = "DELETE Movies WHERE MovieID = @MovieID";
        //Count and list the customers with the most movies
        public static string CustomerRentedCountSql { get; set; } = "SELECT * FROM CustomersRentedMovies";
        //Count and list the top rented movies
        public static string TopRentedMoviesSql { get; set; } = "SELECT * FROM MoviesRented";
        //Show only the movies that have not been returned
        public static string ShowRentedMoviesOnlySql { get; set; } =
            "SELECT * FROM CustomerAndMoviesRented WHERE DateReturned = ''";

    }

}
