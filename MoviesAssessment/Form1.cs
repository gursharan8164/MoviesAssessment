using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesAssessment
{
    public partial class Form1 : Form
    {
        Data myData = new Data();
        DataTable CustomerTable = new DataTable();
        DataTable MovieTable = new DataTable();
        DataTable RentedMovieTable = new DataTable();
        DataTable BestCustomersTable = new DataTable();
        DataTable TopMoviesTable = new DataTable();

        public Form1()
        {
            //Load the form
            InitializeComponent();
            LoadDGVs();
            //Enter the current datetime into the customer date box
            txtCustDate.Text = DateTime.Now.ToString();

        }

        public void LoadDGVs()
        {
            //Load all datagridviews
            DGVCustomers.DataSource = myData.LoadDGVCustomers();
            DGVMovies.DataSource = myData.LoadDGVMovies();
            DGVRented.DataSource = myData.LoadDGVRentedMovies();
            DGVBestCust.DataSource = myData.LoadDGVBestCustomers();
            DGVTopMov.DataSource = myData.LoadDGVTopMovies();
            DGVMovNotReturned.DataSource = myData.ShowRentedMoviesOnly();
        }

        public void RentalCostUpdate()
        {
            //Work out and apply the rental cost depending on release year of movie
            try
            {
                int movieYear = Convert.ToInt32(txtMovYear.Text);
                int dateDiff = DateTime.Today.Year - movieYear;

                if (dateDiff <= 5)
                {
                    txtRentalCost.Text = 5.00.ToString();
                }
                else
                {
                    txtRentalCost.Text = 2.00.ToString();
                }
            }

            catch
            {

            }

        }

        private void FillFromTextBoxesCust()
        {
            //Fills all customer data entered into the text boxes into the datagridview
            myData.AllCusttextboxes = new string[]
            {
                txtCustID.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtCustDate.Text
            };

        }

        private void FillFromTextBoxesMov()
        {
            //Fills all movie data entered into the text boxes into the datagridview
            myData.AllMovtextboxes = new string[]
            {
                txtMovieID.Text, txtMovieName.Text, txtMovYear.Text, txtMovDate.Text, txtGenre.Text, txtRating.Text, txtPlot.Text, txtRentalCost.Text
            };

        }

        public void ClearCustTextBoxes()
        {
            //Clears all data from the customer text boxes but not the date
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCustID.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        public void ClearMovTextBoxes()
        {
            //Clears all data from the movie text boxes
            txtMovieID.Clear();
            txtMovieName.Clear();
            txtMovDate.Clear();
            txtMovYear.Clear();
            txtPlot.Clear();
            txtGenre.Clear();
            txtRentalCost.Clear();
            txtRating.Clear();
        }

        public void LoadAndRefreshDGVs()
        {
            //Loads and refreshes the datagridviews
            DGVColumnsClear();
            DGVCustomers.DataSource = myData.LoadDGVCustomers();
            DGVMovies.DataSource = myData.LoadDGVMovies();
            DGVRented.DataSource = myData.LoadDGVRentedMovies();
            DGVBestCust.DataSource = myData.LoadDGVBestCustomers();
            DGVTopMov.DataSource = myData.LoadDGVTopMovies();
            DGVMovNotReturned.DataSource = myData.ShowRentedMoviesOnly();
        }

        public void DGVColumnsClear()
        {
            // Clear the old data
            CustomerTable.Clear();
            MovieTable.Clear();
            RentedMovieTable.Clear();
            BestCustomersTable.Clear();
            TopMoviesTable.Clear();
        }

        private void btnTotalCust_Click(object sender, EventArgs e)
        {
            //Shows total customer count in this button box
            btnTotalCust.Text = myData.ReturnCountofCustomers();
        }

        private void btnTotalMov_Click(object sender, EventArgs e)
        {
            //Shows total movie count in this button box
            btnTotalMov.Text = myData.ReturnCountofMovies();
        }

        private void btnAddCust_Click(object sender, EventArgs e)//Add customer to DB button
        {
            //Enter the current datetime into the customer date box
            txtCustDate.Text = DateTime.Now.ToString();
            FillFromTextBoxesCust();
            MessageBox.Show(myData.AddNewDataCust(myData.AllCusttextboxes));
            LoadAndRefreshDGVs();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            //Add movie to DB button
            FillFromTextBoxesMov();
            MessageBox.Show(myData.AddNewDataMov(myData.AllMovtextboxes));
            LoadAndRefreshDGVs();
        }

        private void btnDelCust_Click(object sender, EventArgs e)
        {
            //Delete customer from DB button
            myData.DeleteCust(txtCustID.Text);
            LoadAndRefreshDGVs();
        }

        private void btnDelMovie_Click(object sender, EventArgs e)
        {
            //Delete movie from DB button
            myData.DeleteMov(txtMovieID.Text);
            LoadAndRefreshDGVs();
        }

        private void btnUptCust_Click(object sender, EventArgs e)
        {
            //Update customer details to DB button
            FillFromTextBoxesCust();
            myData.UpdateCust(myData.AllCusttextboxes);
            LoadAndRefreshDGVs();
        }

        private void btnUptMovie_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtRentalCost.Text, out n))
            {
                MessageBox.Show("Please enter in a number for Rental Cost");
                LoadAndRefreshDGVs();
            }

            else
            {
                //Update movie details to DB button
                FillFromTextBoxesMov();
                myData.UpdateMov(myData.AllMovtextboxes);
                LoadAndRefreshDGVs();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return a movie to DB button
            string Date = DateTime.Now.ToString();
            myData.ReturnMovie(txtCustID.Text, Date);
            LoadAndRefreshDGVs();
        }

        public void btnIssue_Click(object sender, EventArgs e)
        {
            // If the movie ID and customer ID boxes are empty, then it will not run
            if (txtMovieID.Text == string.Empty || txtCustID.Text == string.Empty)
            {
                MessageBox.Show("Please use the Customer and Movie tabs above and then click on the details to select a Customer and Movie before issuing");
                LoadAndRefreshDGVs();
            }

            else //run this if customer ID and movie ID is present in text boxes
            {
                //Updates the rental cost
                RentalCostUpdate();
                //Issue a movie from DB button
                string Date = DateTime.Now.ToString();
                myData.IssueMovie(txtCustID.Text, txtMovieID.Text, Date, "");
                LoadAndRefreshDGVs();
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Clear all text boxes
            ClearMovTextBoxes();
            ClearCustTextBoxes();
        }

        public void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // show the data in the dgv in the text boxes
                string clickText = DGVCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // show the output on the header
                Text = "Row : " + e.RowIndex.ToString() + "Col : " + e.ColumnIndex.ToString() + "Value : " + clickText;

                // pass data to the text boxes
                txtCustID.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCustDate.Text = DGVCustomers.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

            catch
            {

            }

        }

        public void DGVMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // show the data in the dgv in the text boxes
                string clickText = DGVMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // show the output on the header
                Text = "Row : " + e.RowIndex.ToString() + "Col : " + e.ColumnIndex.ToString() + "Value : " + clickText;

                //pass data to the textboxes
                txtMovieID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMovieName.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMovYear.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                RentalCostUpdate();
            }

            catch
            {

            }

        }

        public void DGVRented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Clear text boxes to start fresh
            ClearMovTextBoxes();
            ClearCustTextBoxes();

            try
            {
                // show the data in the dgv in the text boxes
                string clickText = DGVRented.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // show the output on the header
                Text = "Row : " + e.RowIndex.ToString() + "Col : " + e.ColumnIndex.ToString() + "Value : " + clickText;

                //pass data to the textboxes
                txtCustID.Text = DGVRented.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DGVRented.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVRented.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DGVRented.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMovieName.Text = DGVRented.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRentalCost.Text = DGVRented.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

            catch
            {

            }

        }

        private void btnCustRentedCount_Click(object sender, EventArgs e)
        {
            //Displays how many customers have rented movies in button
            btnCustRentedCount.Text = myData.ReturnCountofCustomersRented();
        }

        private void btnMovRentedCount_Click(object sender, EventArgs e)
        {
            //Displays how many movies are rented in button
            btnMovRentedCount.Text = myData.ReturnCountofMoviesRented();
        }

        private void DGVMovNotReturned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Clear text boxes to start fresh
            ClearMovTextBoxes();
            ClearCustTextBoxes();

            try
            {
                // show the data in the dgv in the text boxes
                string clickText = DGVMovNotReturned.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // show the output on the header
                Text = "Row : " + e.RowIndex.ToString() + "Col : " + e.ColumnIndex.ToString() + "Value : " + clickText;

                //pass data to the textboxes
                txtCustID.Text = DGVMovNotReturned.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DGVMovNotReturned.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVMovNotReturned.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DGVMovNotReturned.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMovieName.Text = DGVMovNotReturned.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRentalCost.Text = DGVMovNotReturned.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

            catch
            {

            }
        }
    }
}
