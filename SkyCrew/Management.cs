using System;
using System.Data;
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
            // Use mock data for testing
            DataTable staffTable = GetMockStaffData();
            dataGridViewStaff.DataSource = staffTable;

            DataTable flightsTable = GetMockFlightsData();
            dataGridViewFlights.DataSource = flightsTable;

            DataTable bookingsTable = GetMockBookingsData();
            dataGridViewBookings.DataSource = bookingsTable;
        }

        private DataTable GetMockStaffData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StaffID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            dt.Rows.Add(1, "John Doe", "Pilot");
            dt.Rows.Add(2, "Jane Smith", "Ground Crew");
            dt.Rows.Add(3, "Bob Johnson", "Customer Service");

            return dt;
        }

        private DataTable GetMockFlightsData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FlightNumber", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Arrival", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add("FL123", "New York", "London", "On Time");
            dt.Rows.Add("FL456", "Paris", "Tokyo", "Delayed");
            dt.Rows.Add("FL789", "Sydney", "Dubai", "Cancelled");

            return dt;
        }

        private DataTable GetMockBookingsData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookingID", typeof(int));
            dt.Columns.Add("PassengerName", typeof(string));
            dt.Columns.Add("FlightNumber", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            dt.Rows.Add(1001, "Alice Brown", "FL123", "Confirmed");
            dt.Rows.Add(1002, "David Wilson", "FL456", "Pending");
            dt.Rows.Add(1003, "Emily Davis", "FL789", "Cancelled");

            return dt;
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
            // Implement any cell click logic if needed
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }
    }
}
