using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace tabvid
{
    public partial class Form1 : Form
    {
        Queries myQueries = new Queries();
        public Form1()
        {
            InitializeComponent();


            //These using statements display the data to the list views
            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllMovies, connection);
                connection.Open();

                //Retrieves specific columns from the table
                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["MovieID"].ToString(), reader["Rating"].ToString(), reader["Title"].ToString(), reader["Year"].ToString(), reader["Rental_Cost"].ToString(), reader["Copies"].ToString(), reader["Plot"].ToString(), reader["Genre"].ToString()
                    });

                    //Adds them as items to the list view
                    LVMovies.Items.Add(item);
                }

                reader.Close();
            }

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllCustomers, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["CustID"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["Address"].ToString(), reader["Phone"].ToString()
                    });

                    LVCustomers.Items.Add(item);
                }

                reader.Close();
            }

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllRented, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["RMID"].ToString(), reader["MovieIDFK"].ToString(), reader["CustIDFK"].ToString(), reader["DateRented"].ToString(), reader["DateReturned"].ToString()
                    });

                    LVRents.Items.Add(item);
                }

                reader.Close();
            }

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadTopCustomer, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["FirstName"].ToString(), reader["LastName"].ToString()
                    });

                    LVTopCustomer.Items.Add(item);
                }

                reader.Close();
            }

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadTopMovie, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["Title"].ToString(), reader["MovieID"].ToString()
                    });

                    LVTopMovie.Items.Add(item);
                }

                reader.Close();
            }
        }


      

        private void btnAddMovie_Click_1(object sender, EventArgs e)
        {

            if (rbtnAddMovie.Checked)
            {
                myQueries.AddMovieRecord(txtMovieRate.Text.ToString(), txtMovieTitle.Text.ToString(), txtMovieYear.Text.ToString(), txtMovieCost.Text.ToString(), txtMovieCopies.Text.ToString(), txtMoviePlot.Text.ToString(), txtMovieGenre.Text.ToString());

                LVMovies.Items.Clear();

                using (SqlConnection connection = new SqlConnection(myClass.connectionString))
                {
                    SqlCommand Command = new SqlCommand(myQueries.LoadAllMovies, connection);

                    connection.Open();

                    SqlDataReader reader = Command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(new[] {
                            reader["MovieID"].ToString(), reader["Rating"].ToString(), reader["Title"].ToString(), reader["Year"].ToString(), reader["Rental_Cost"].ToString(), reader["Copies"].ToString(), reader["Plot"].ToString(), reader["Genre"].ToString()
                        });

                        LVMovies.Items.Add(item);
                    }

                    reader.Close();
                }

                txtMovieRate.Text = "";
                txtMovieTitle.Text = "";
                txtMovieYear.Text = "";
                txtMovieCost.Text = "";
                txtMovieCopies.Text = "";
                txtMoviePlot.Text = "";
                txtMovieGenre.Text = "";
            }

            else if (rbtnUpdateMovie.Checked)
            {
                myQueries.UpdateMovieRecord(txtUpdateID.Text.ToString(), txtMovieRate.Text.ToString(), txtMovieTitle.Text.ToString(), txtMovieYear.Text.ToString(), txtMovieCost.Text.ToString(), txtMovieCopies.Text.ToString(), txtMoviePlot.Text.ToString(), txtMovieGenre.Text.ToString());

                LVMovies.Items.Clear();

                using (SqlConnection connection = new SqlConnection(myClass.connectionString))
                {
                    SqlCommand Command = new SqlCommand(myQueries.LoadAllMovies, connection);

                    connection.Open();

                    SqlDataReader reader = Command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(new[] {
                            reader["MovieID"].ToString(), reader["Rating"].ToString(), reader["Title"].ToString(), reader["Year"].ToString(), reader["Rental_Cost"].ToString(), reader["Copies"].ToString(), reader["Plot"].ToString(), reader["Genre"].ToString()
                        });

                        LVMovies.Items.Add(item);
                    }

                    reader.Close();
                }
            }

            else
            {
                MessageBox.Show("Please select 'Add new' or 'Update existing'.");
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            myQueries.AddCustomer(txtCustomerFirstname.Text.ToString(), txtCustomerSurname.Text.ToString(), txtCustomerAddress.Text.ToString(), txtCustomerPhone.Text.ToString());

            LVCustomers.Items.Clear();

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllCustomers, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["CustID"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["Address"].ToString(), reader["Phone"].ToString()
                    });

                    LVCustomers.Items.Add(item);
                }

                reader.Close();
            }

            txtCustomerFirstname.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerPhone.Text = "";
            rbtnAddMovie.Checked = false;

        }

        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {

            myQueries.DeleteCustomer(txtDeleteCustomerID.Text.ToString());

            LVCustomers.Items.Clear();

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllCustomers, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["CustID"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["Address"].ToString(), reader["Phone"].ToString()
                    });

                    LVCustomers.Items.Add(item);
                }

                reader.Close();
            }

            txtDeleteCustomerID.Text = "";
        }

        private void btnUpdateCustomer_Click_1(object sender, EventArgs e)
        {

            myQueries.UpdateCustomer(txtUpdateCustID.Text.ToString(), txtUpdateCustName.Text.ToString(), txtUpdateCustLastname.Text.ToString(), txtUpdateCustAddress.Text.ToString(), txtUpdateCustPhone.Text.ToString());

            LVCustomers.Items.Clear();

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllCustomers, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["CustID"].ToString(), reader["FirstName"].ToString(), reader["LastName"].ToString(), reader["Address"].ToString(), reader["Phone"].ToString()
                    });

                    LVCustomers.Items.Add(item);
                }

                reader.Close();

            }
        }

        private void rbtnAddMovie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteMovie_Click_1(object sender, EventArgs e)
        {
            string movieToDelete = txtDeleteMovieID.Text;

            myQueries.DeleteMovieRecord(movieToDelete);

            LVMovies.Items.Clear();

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllMovies, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["MovieID"].ToString(), reader["Rating"].ToString(), reader["Title"].ToString(), reader["Year"].ToString(), reader["Rental_Cost"].ToString(), reader["Copies"].ToString(), reader["Plot"].ToString(), reader["Genre"].ToString()
                    });

                    LVMovies.Items.Add(item);
                }

                reader.Close();
            }

            btnDeleteMovie.Text = "";

        }

        private void btnRentMovie_Click_1(object sender, EventArgs e)
        {
            myQueries.RentMovie(txtRentedID.Text.ToString(), txtRenterID.Text.ToString(), txtRentDate.Text.ToString(), txtReturnDate.Text.ToString());

            LVRents.Items.Clear();

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllRented, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["RMID"].ToString(), reader["MovieIDFK"].ToString(), reader["CustIDFK"].ToString(), reader["DateRented"].ToString(), reader["DateReturned"].ToString()
                    });

                    LVRents.Items.Add(item);
                }

                reader.Close();
            }

            txtRentedID.Text = "";
            txtRenterID.Text = "";
            txtRentDate.Text = "";
            txtReturnDate.Text = "";
        }

        private void btnReturnMovie_Click_1(object sender, EventArgs e)
        {

            myQueries.ReturnMovie(txtReturnMovieID.Text.ToString());

            LVRents.Items.Clear();

            using (SqlConnection connection = new SqlConnection(myClass.connectionString))
            {
                SqlCommand Command = new SqlCommand(myQueries.LoadAllRented, connection);

                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new[] {
                        reader["RMID"].ToString(), reader["MovieIDFK"].ToString(), reader["CustIDFK"].ToString(), reader["DateRented"].ToString(), reader["DateReturned"].ToString()
                    });

                    LVRents.Items.Add(item);
                }

                reader.Close();
            }

            txtReturnMovieID.Text = "";
        }
    }
}


      