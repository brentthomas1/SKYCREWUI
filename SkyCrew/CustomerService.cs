using System;
using System.Data;
// STEP 1: Uncomment the following line when switching back to database
// using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SkyCrew
{
    public partial class CustomerService : MaterialForm
    {
        private Timer refreshTimer;

        public CustomerService()
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

            // Set form properties
            this.Sizable = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize timer for periodic refresh
            refreshTimer = new Timer();
            refreshTimer.Interval = 60000; // Refresh every minute
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();

            LoadShiftData();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadShiftData();
        }

        private void LoadShiftData()
        {
            try
            {
                // STEP 2: To switch back to database:
                // 1. Remove the mock data implementation below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string query = @"
                        SELECT 
                            COUNT(*) as TotalShifts,
                            SUM(CASE WHEN Status = 'Available' THEN 1 ELSE 0 END) as AvailableShifts,
                            SUM(CASE WHEN Status = 'Completed' THEN 1 ELSE 0 END) as CompletedShifts
                        FROM Shifts
                        WHERE Date >= DATEADD(day, -30, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblShiftStats.Text = $"Shift Statistics\n" +
                            $"Total: {reader["TotalShifts"]}\n" +
                            $"Available: {reader["AvailableShifts"]}\n" +
                            $"Completed: {reader["CompletedShifts"]}";
                    }

                    reader.Close();

                    // Load notifications
                    query = @"
                        SELECT TOP 5
                            Message,
                            CreatedAt
                        FROM Notifications
                        WHERE Role = 'CustomerService'
                        ORDER BY CreatedAt DESC";

                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();

                    string notifications = "Notifications\n";
                    while (reader.Read())
                    {
                        notifications += $"{reader["Message"]}\n";
                    }
                    lblNotifications.Text = notifications;
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                var shiftStats = MockDataProvider.GetMockShiftStats();
                if (shiftStats.Rows.Count > 0)
                {
                    lblShiftStats.Text = $"Shift Statistics\nTotal: {shiftStats.Rows[0]["TotalShifts"]}\nCompleted: {shiftStats.Rows[0]["CompletedShifts"]}";
                }

                // Load notifications
                var notifications = MockDataProvider.GetMockNotifications("Customer Service");
                lblNotifications.Text = "Notifications\n" + string.Join("\n", notifications);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlQuickActions_Paint(object sender, PaintEventArgs e)
        {
            // This is a placeholder for any custom painting logic
        }

        private void pnlShiftStats_Paint(object sender, PaintEventArgs e)
        {
            // This is a placeholder for any custom painting logic
        }
    }
}

