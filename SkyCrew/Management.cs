using System;
using System.Data;
// STEP 1: Uncomment the following line when switching back to database
// using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SkyCrew
{
    public partial class Management : MaterialForm
    {
        public Management()
        {
            InitializeComponent();

            // Initialize MaterialSkin Manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Set the color scheme (white and blue)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Set form properties
            this.Sizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadData();

            // Bind event handlers
            btnOpenPilotForm.Click += btnOpenPilotForm_Click;
            btnOpenGroundCrewForm.Click += btnOpenGroundCrewForm_Click;
            btnOpenCustomerServiceForm.Click += btnOpenCustomerServiceForm_Click;
            btnOpenAdminForm.Click += btnOpenAdminForm_Click;
            btnExit.Click += btnExit_Click;
            dataGridViewBookings.CellContentClick += dataGridViewBookings_CellContentClick;
        }

        private void LoadData()
        {
            try
            {
                // STEP 2: To switch back to database:
                // 1. Remove the mock data implementation below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    // Load Staff Data
                    string staffQuery = @"
                        SELECT StaffID, FirstName + ' ' + LastName as Name, Role
                        FROM Users 
                        WHERE Role != 'Customer'
                        ORDER BY Role, StaffID";
                    SqlDataAdapter staffAdapter = new SqlDataAdapter(staffQuery, conn);
                    DataTable staffTable = new DataTable();
                    staffAdapter.Fill(staffTable);
                    dataGridViewStaff.DataSource = staffTable;

                    // Load Flights Data
                    string flightsQuery = @"
                        SELECT FlightNumber, DepartureCity as Departure, ArrivalCity as Arrival, Status
                        FROM Flights
                        WHERE DepartureTime >= GETDATE()
                        ORDER BY DepartureTime";
                    SqlDataAdapter flightsAdapter = new SqlDataAdapter(flightsQuery, conn);
                    DataTable flightsTable = new DataTable();
                    flightsAdapter.Fill(flightsTable);
                    dataGridViewFlights.DataSource = flightsTable;

                    // Load Bookings Data
                    string bookingsQuery = @"
                        SELECT 
                            b.BookingID,
                            u.FirstName + ' ' + u.LastName as PassengerName,
                            f.FlightNumber,
                            b.Status
                        FROM Bookings b
                        JOIN Users u ON b.UserID = u.UserID
                        JOIN Flights f ON b.FlightID = f.FlightID
                        ORDER BY b.BookingID DESC";
                    SqlDataAdapter bookingsAdapter = new SqlDataAdapter(bookingsQuery, conn);
                    DataTable bookingsTable = new DataTable();
                    bookingsAdapter.Fill(bookingsTable);
                    dataGridViewBookings.DataSource = bookingsTable;
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                dataGridViewStaff.DataSource = MockDataProvider.GetMockStaffData();
                dataGridViewFlights.DataSource = MockDataProvider.GetMockFlightData(10);
                dataGridViewBookings.DataSource = MockDataProvider.GetMockBookingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenPilotForm_Click(object sender, EventArgs e)
        {
            Pilot pilotForm = new Pilot();
            pilotForm.Show();
        }

        private void btnOpenGroundCrewForm_Click(object sender, EventArgs e)
        {
            GroundCrew groundCrewForm = new GroundCrew();
            groundCrewForm.Show();
        }

        private void btnOpenCustomerServiceForm_Click(object sender, EventArgs e)
        {
            CustomerService customerServiceForm = new CustomerService();
            customerServiceForm.Show();
        }

        private void btnOpenAdminForm_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void dataGridViewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // STEP 3: To switch back to database:
            // 1. Remove the mock implementation below (if any is added later)
            // 2. Uncomment the following database code block if needed
            /* DATABASE CODE START - UNCOMMENT THIS BLOCK
            if (e.RowIndex >= 0)
            {
                string bookingId = dataGridViewBookings.Rows[e.RowIndex].Cells["BookingID"].Value.ToString();
                // Add any booking-specific functionality here
            }
            DATABASE CODE END */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
