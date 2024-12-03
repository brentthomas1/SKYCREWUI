using System;
using System.Data;
// STEP 1: Uncomment the following line when switching back to database
// using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SkyCrew;

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

            // Bind event handlers
            btnOpenPilotForm.Click += btnOpenPilotForm_Click;
            btnOpenGroundCrewForm.Click += btnOpenGroundCrewForm_Click;
            btnOpenCustomerServiceForm.Click += btnOpenCustomerServiceForm_Click;
            btnOpenAdminForm.Click += btnOpenAdminForm_Click;
            dataGridViewBookings.CellContentClick += dataGridViewBookings_CellContentClick;

            LoadDashboardData();
        }

        private void LoadDashboardData()
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
                        SELECT 
                            StaffID,
                            FirstName + ' ' + LastName as Name,
                            Role,
                            Email,
                            Status
                        FROM Staff
                        ORDER BY Role, StaffID";
                    SqlDataAdapter staffAdapter = new SqlDataAdapter(staffQuery, conn);
                    DataTable staffTable = new DataTable();
                    staffAdapter.Fill(staffTable);
                    dataGridViewStaff.DataSource = staffTable;

                    // Load Flights Data
                    string flightsQuery = @"
                        SELECT 
                            FlightNumber,
                            DepartureTime,
                            ArrivalTime,
                            Status,
                            Gate,
                            Aircraft
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
                            p.FirstName + ' ' + p.LastName as PassengerName,
                            f.FlightNumber,
                            b.BookingDate,
                            b.Status,
                            b.TicketPrice
                        FROM Bookings b
                        JOIN Passengers p ON b.PassengerID = p.PassengerID
                        JOIN Flights f ON b.FlightID = f.FlightID
                        ORDER BY b.BookingDate DESC";
                    SqlDataAdapter bookingsAdapter = new SqlDataAdapter(bookingsQuery, conn);
                    DataTable bookingsTable = new DataTable();
                    bookingsAdapter.Fill(bookingsTable);
                    dataGridViewBookings.DataSource = bookingsTable;
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                var staffData = MockDataProvider.GetMockStaffData();
                var flightData = MockDataProvider.GetMockFlightData();
                var bookingData = MockDataProvider.GetMockBookingData();

                // Update your UI controls with the data
                dataGridViewStaff.DataSource = staffData;
                dataGridViewFlights.DataSource = flightData;
                dataGridViewBookings.DataSource = bookingData;
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
            // Handle cell content click event
            // STEP 3: To switch back to database:
            // Add your database-specific handling code here
        }

        private void Management_Load(object sender, EventArgs e)
        {
            // Load initial data
            LoadDashboardData();
        }
    }
}
