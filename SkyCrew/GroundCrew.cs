using System;
using System.Configuration;
using System.Data;
// STEP 1: Uncomment the following line when switching back to database
// using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SkyCrew
{
    public partial class GroundCrew : MaterialForm
    {
        public GroundCrew()
        {
            InitializeComponent();
            LoadFlightSchedule();
            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;

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
        }

        private void LoadFlightSchedule()
        {
            try
            {
                // STEP 2: To switch back to database:
                // 1. Remove the mock data implementation below (DataTable flightTable = MockDataProvider.GetMockFlightData(10);)
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FlightNumber, DepartureTime, ArrivalTime, Status FROM Flights";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable flightTable = new DataTable();
                    adapter.Fill(flightTable);
                    dataGridViewShifts.DataSource = flightTable;
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                DataTable flightTable = MockDataProvider.GetMockFlightData(10);
                dataGridViewShifts.DataSource = flightTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flight schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            LoadFlightsForDate(selectedDate);
        }

        private void LoadFlightsForDate(DateTime date)
        {
            try
            {
                // STEP 3: To switch back to database:
                // 1. Remove the mock data implementation (DataTable allFlights = MockDataProvider... and the foreach loop)
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT FlightNumber, DepartureTime, ArrivalTime, Status 
                        FROM Flights 
                        WHERE CAST(DepartureTime AS DATE) = @SelectedDate";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", date);
                    DataTable flightTable = new DataTable();
                    adapter.Fill(flightTable);
                    dataGridViewShifts.DataSource = flightTable;

                    if (flightTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No flights scheduled for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS BLOCK WHEN SWITCHING TO DATABASE
                DataTable allFlights = MockDataProvider.GetMockFlightData(20);
                DataTable filteredFlights = allFlights.Clone();

                foreach (DataRow row in allFlights.Rows)
                {
                    DateTime departureTime = Convert.ToDateTime(row["DepartureTime"]);
                    if (departureTime.Date == date.Date)
                    {
                        filteredFlights.ImportRow(row);
                    }
                }

                dataGridViewShifts.DataSource = filteredFlights;

                if (filteredFlights.Rows.Count == 0)
                {
                    MessageBox.Show("No flights scheduled for the selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flights for date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAcceptShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to accept.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFlightNumber = dataGridViewShifts.SelectedRows[0].Cells["FlightNumber"].Value.ToString();

            try
            {
                // STEP 4: To switch back to database:
                // 1. Remove the mock implementation message below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    conn.Open();
                    string updateQuery = "UPDATE Flights SET Status = 'Accepted' WHERE FlightNumber = @FlightNumber";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FlightNumber", selectedFlightNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Shift accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFlightsForDate(monthCalendar1.SelectionStart); // Refresh for the selected date
                    }
                    else
                    {
                        MessageBox.Show("Failed to accept the shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                MessageBox.Show("Shift accepted successfully! (Mock Implementation)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFlightsForDate(monthCalendar1.SelectionStart);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accepting shift: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to drop.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFlightNumber = dataGridViewShifts.SelectedRows[0].Cells["FlightNumber"].Value.ToString();
            string selectedStatus = dataGridViewShifts.SelectedRows[0].Cells["Status"].Value.ToString();

            if (!string.Equals(selectedStatus, "Accepted", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only accepted shifts can be dropped.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // STEP 5: To switch back to database:
                // 1. Remove the mock implementation message below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    conn.Open();
                    string updateQuery = "UPDATE Flights SET Status = 'Scheduled' WHERE FlightNumber = @FlightNumber";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@FlightNumber", selectedFlightNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Shift dropped successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFlightsForDate(monthCalendar1.SelectionStart); // Refresh for the selected date
                    }
                    else
                    {
                        MessageBox.Show("Failed to drop the shift. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                MessageBox.Show("Shift dropped successfully! (Mock Implementation)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFlightsForDate(monthCalendar1.SelectionStart);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
        }

        private void GroundCrew_Load(object sender, EventArgs e)
        {
            // Load initial data
            LoadShiftData();
        }

        private void LoadShiftData()
        {
            // Load mock data for testing
            var shiftData = MockDataProvider.GetMockShiftStats();
            dataGridViewShifts.DataSource = shiftData;

            // Load notifications
            var notifications = MockDataProvider.GetMockNotifications("Ground Crew");
            listBoxNotifications.Items.Clear();
            listBoxNotifications.Items.AddRange(notifications);
        }
    }
}
