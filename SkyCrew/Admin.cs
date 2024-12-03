using System;
using System.Data;
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
            this.MaximizeBox = true;
            this.MinimizeBox = true;
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
                DataTable reportTable = new DataTable();
                switch (selectedReport)
                {
                    case "Flight Report":
                        reportTable = GetMockFlightReport();
                        break;
                    case "Staff Report":
                        reportTable = MockDataProvider.GetMockStaffData(15);
                        break;
                    case "Bookings Report":
                        reportTable = MockDataProvider.GetMockBookingData(20);
                        break;
                    default:
                        MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                dataGridViewReport.DataSource = reportTable;

                if (reportTable.Rows.Count > 0)
                {
                    MessageBox.Show($"{selectedReport} generated successfully! (Mock Data)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        chartReport.Series.Clear();
                        chartReport.Titles.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetMockFlightReport()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Count", typeof(int));

            string[] statuses = { "Scheduled", "Boarding", "In Flight", "Landed", "Delayed", "Cancelled" };
            Random random = new Random();

            foreach (string status in statuses)
            {
                dt.Rows.Add(status, random.Next(5, 50));
            }

            return dt;
        }

        private void VisualizeFlightData(DataTable reportTable)
        {
            try
            {
                chartReport.Series.Clear();

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

        private void VisualizeBookingData(DataTable reportTable)
        {
            try
            {
                chartReport.Series.Clear();

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
            // This is a placeholder for any custom painting logic
        }

        private void LoadDashboardData()
        {
            // Load mock data for testing
            var staffData = MockDataProvider.GetMockStaffData();
            var flightData = MockDataProvider.GetMockFlightData();
            
            // Update your UI controls with the data
            dataGridViewStaff.DataSource = staffData;
            dataGridViewFlights.DataSource = flightData;
        }
    }
}
