using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MaterialSkin;
using MaterialSkin.Controls;

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
            this.MaximizeBox = true;  // Enable maximize box if needed
            this.MinimizeBox = true;  // Enable minimize box if needed
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
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string reportQuery = "";

                    // Determine the report type and set the appropriate query
                    switch (selectedReport)
                    {
                        case "Flight Report":
                            reportQuery = @"
                            SELECT 
                                Status,
                                COUNT(*) AS Count
                            FROM Flights
                            GROUP BY Status
                            ORDER BY Status";
                            break;

                        case "Staff Report":
                            reportQuery = @"
                            SELECT 
                                FirstName, 
                                LastName, 
                                Role, 
                                Email, 
                                HireDate
                            FROM Users
                            WHERE Role != 'Customer'
                            ORDER BY Role, HireDate";
                            break;

                        case "Bookings Report":
                            reportQuery = @"
                            SELECT 
                                BookingDate, 
                                TicketPrice
                            FROM Bookings
                            ORDER BY BookingDate";
                            break;

                        default:
                            MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Execute the query and populate the DataGridView
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(reportQuery, conn);
                    DataTable reportTable = new DataTable();
                    dataAdapter.Fill(reportTable);

                    dataGridViewReport.DataSource = reportTable;

                    if (reportTable.Rows.Count > 0)
                    {
                        MessageBox.Show($"{selectedReport} generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Call method to visualize data based on the selected report
                        if (selectedReport == "Flight Report")
                        {
                            VisualizeFlightData(reportTable);
                        }
                        else if (selectedReport == "Bookings Report")
                        {
                            VisualizeBookingData(reportTable);
                        }
                        else
                        {
                            chartReport.Series.Clear(); // Clear chart if not applicable
                            chartReport.Titles.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Visualize flight status counts on the chart
        /// </summary>
        private void VisualizeFlightData(DataTable reportTable)
        {
            try
            {
                chartReport.Series.Clear(); // Clear any existing series

                Series statusSeries = new Series("Status Count")
                {
                    ChartType = SeriesChartType.Column,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Int32
                };

                foreach (DataRow row in reportTable.Rows)
                {
                    string status = row["Status"].ToString();
                    int count = Convert.ToInt32(row["Count"]);

                    statusSeries.Points.AddXY(status, count);
                }

                chartReport.Series.Add(statusSeries);
                chartReport.ChartAreas[0].AxisX.Title = "Status";
                chartReport.ChartAreas[0].AxisY.Title = "Count";
                chartReport.Titles.Clear();
                chartReport.Titles.Add("Flight Status Overview");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error visualizing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Visualize booking data on the chart
        /// </summary>
        private void VisualizeBookingData(DataTable reportTable)
        {
            try
            {
                chartReport.Series.Clear(); // Clear any existing series

                Series bookingSeries = new Series("Ticket Prices")
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime,
                    YValueType = ChartValueType.Double,
                    BorderWidth = 2
                };

                foreach (DataRow row in reportTable.Rows)
                {
                    DateTime bookingDate = Convert.ToDateTime(row["BookingDate"]);
                    double ticketPrice = Convert.ToDouble(row["TicketPrice"]);

                    bookingSeries.Points.AddXY(bookingDate, ticketPrice);
                }

                chartReport.Series.Add(bookingSeries);
                chartReport.ChartAreas[0].AxisX.Title = "Booking Date";
                chartReport.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd-yyyy";
                chartReport.ChartAreas[0].AxisY.Title = "Ticket Price";
                chartReport.Titles.Clear();
                chartReport.Titles.Add("Ticket Price Trends");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error visualizing booking data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlDataAnalytics_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
