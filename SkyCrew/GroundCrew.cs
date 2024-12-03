using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private void GroundCrew_Load(object sender, EventArgs e)
        {
            // Load any data or perform initialization here
        }

        private void LoadFlightSchedule()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT FlightNumber, DepartureTime, ArrivalTime, Status FROM Flights";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable flightTable = new DataTable();
                    adapter.Fill(flightTable);

                    dataGridViewShifts.DataSource = flightTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading flight schedule: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start; // The date user clicked
            LoadFlightsForDate(selectedDate);
        }

        private void LoadFlightsForDate(DateTime date)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading flights for date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAcceptShift_Click(object sender, EventArgs e)
        {
            // Implementation remains the same
        }

        private void buttonCancelShift_Click(object sender, EventArgs e)
        {
            // Implementation remains the same
        }

        private void dataGridViewShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement if needed
        }
    }
}
