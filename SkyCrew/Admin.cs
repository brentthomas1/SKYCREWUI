using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SkyCrew;

namespace SkyCrew
{
    public partial class Admin : MaterialForm
    {
        public Admin()
        {
            InitializeComponent();

            // Initialize MaterialSkin Manager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Set the color scheme (white and blue)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Set form properties for a clean look
            this.Sizable = false;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            // STEP 1: To switch back to database:
            // 1. Remove the mock data implementation below
            // 2. Uncomment the following database code block
            /* DATABASE CODE START - UNCOMMENT THIS BLOCK
            using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
            {
                string query = @"
                    SELECT TOP 10
                        StaffID,
                        FirstName + ' ' + LastName as Name,
                        Role,
                        Email,
                        Status
                    FROM Staff
                    ORDER BY StaffID DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable staffData = new DataTable();
                adapter.Fill(staffData);
                dataGridViewReport.DataSource = staffData;
            }
            DATABASE CODE END */

            // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
            var staffData = MockDataProvider.GetMockStaffData();
            var flightData = MockDataProvider.GetMockFlightData();
            
            // Update your UI controls with the data
            dataGridViewReport.DataSource = staffData;
        }

        private void pnlDataAnalytics_Paint(object sender, PaintEventArgs e)
        {
            // This is a placeholder for any custom painting logic
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (comboBoxReportType.SelectedItem == null)
            {
                MessageBox.Show("Please select a report type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = comboBoxReportType.SelectedItem.ToString();

            try
            {
                // STEP 2: To switch back to database:
                // 1. Remove the mock data implementation below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string query = "";
                    switch (selectedReport)
                    {
                        case "Flight Report":
                            query = @"
                                SELECT 
                                    Status,
                                    COUNT(*) as Count
                                FROM Flights
                                GROUP BY Status";
                            break;
                        case "Staff Report":
                            query = @"
                                SELECT 
                                    StaffID,
                                    FirstName + ' ' + LastName as Name,
                                    Role,
                                    Email,
                                    Status
                                FROM Staff";
                            break;
                        case "Bookings Report":
                            query = @"
                                SELECT 
                                    b.BookingID,
                                    p.FirstName + ' ' + p.LastName as PassengerName,
                                    f.FlightNumber,
                                    b.BookingDate,
                                    b.Status,
                                    b.TicketPrice
                                FROM Bookings b
                                JOIN Passengers p ON b.PassengerID = p.PassengerID
                                JOIN Flights f ON b.FlightID = f.FlightID";
                            break;
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable reportTable = new DataTable();
                    adapter.Fill(reportTable);
                    dataGridViewReport.DataSource = reportTable;
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                switch (selectedReport)
                {
                    case "Staff Report":
                        dataGridViewReport.DataSource = MockDataProvider.GetMockStaffData();
                        break;
                    case "Flight Report":
                        dataGridViewReport.DataSource = MockDataProvider.GetMockFlightData();
                        break;
                    case "Bookings Report":
                        dataGridViewReport.DataSource = MockDataProvider.GetMockBookingData();
                        break;
                }

                MessageBox.Show($"{selectedReport} generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
