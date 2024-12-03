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

            // Set up event handlers
            btnShiftDetails1.Click += BtnShiftDetails_Click;
            btnShiftDetails2.Click += BtnShiftDetails_Click;
            btnShiftDetails3.Click += BtnShiftDetails_Click;
            btnShiftDetails4.Click += BtnShiftDetails_Click;
            btnSignUpForShift.Click += BtnSignUpForShift_Click;

            // Load initial data
            LoadShifts();
            LoadNotifications();
            UpdateShiftStats();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadShifts();
            LoadNotifications();
            UpdateShiftStats();
        }

        private void LoadShifts()
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
                        SELECT TOP 4 
                            FlightNumber,
                            DepartureTime,
                            ArrivalTime,
                            Status,
                            Gate,
                            Aircraft
                        FROM Flights 
                        WHERE Status = 'Scheduled'
                        AND DepartureTime > GETDATE()
                        ORDER BY DepartureTime";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable flightData = new DataTable();
                    adapter.Fill(flightData);
                    
                    MaterialButton[] shiftButtons = { btnShiftDetails1, btnShiftDetails2, btnShiftDetails3, btnShiftDetails4 };
                    for (int i = 0; i < flightData.Rows.Count && i < shiftButtons.Length; i++)
                    {
                        DataRow row = flightData.Rows[i];
                        string flightNumber = row["FlightNumber"].ToString();
                        DateTime departureTime = Convert.ToDateTime(row["DepartureTime"]);
                        DateTime arrivalTime = Convert.ToDateTime(row["ArrivalTime"]);

                        shiftButtons[i].Text = $"Flight {flightNumber} - {departureTime:MM/dd HH:mm} to {arrivalTime:MM/dd HH:mm}";
                        shiftButtons[i].Tag = row;
                        shiftButtons[i].Visible = true;
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                DataTable flightData = MockDataProvider.GetMockFlightData(4);
                MaterialButton[] shiftButtons = { btnShiftDetails1, btnShiftDetails2, btnShiftDetails3, btnShiftDetails4 };
                
                for (int i = 0; i < flightData.Rows.Count && i < shiftButtons.Length; i++)
                {
                    DataRow row = flightData.Rows[i];
                    string flightNumber = row["FlightNumber"].ToString();
                    DateTime departureTime = Convert.ToDateTime(row["DepartureTime"]);
                    DateTime arrivalTime = Convert.ToDateTime(row["ArrivalTime"]);

                    shiftButtons[i].Text = $"Flight {flightNumber} - {departureTime:MM/dd HH:mm} to {arrivalTime:MM/dd HH:mm}";
                    shiftButtons[i].Tag = row;
                    shiftButtons[i].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading shifts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNotifications()
        {
            try
            {
                // STEP 3: To switch back to database:
                // 1. Remove the mock notifications implementation below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string query = @"
                        SELECT TOP 5
                            Message,
                            CreatedAt
                        FROM Notifications
                        WHERE UserRole = 'CustomerService'
                        AND CreatedAt >= DATEADD(day, -7, GETDATE())
                        ORDER BY CreatedAt DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing notifications
                    foreach (Control c in pnlNotifications.Controls)
                    {
                        if (c != lblNotifications)
                            c.Dispose();
                    }

                    int yPos = 50;
                    while (reader.Read())
                    {
                        MaterialLabel notifLabel = new MaterialLabel
                        {
                            Text = $"{reader["Message"]}\n{Convert.ToDateTime(reader["CreatedAt"]):MM/dd HH:mm}",
                            Location = new Point(15, yPos),
                            Size = new Size(370, 40),
                            Depth = 0
                        };
                        pnlNotifications.Controls.Add(notifLabel);
                        yPos += 45;
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                foreach (Control c in pnlNotifications.Controls)
                {
                    if (c != lblNotifications)
                        c.Dispose();
                }

                string[] notifications = MockDataProvider.GetMockNotifications("customer service", 5);
                int yPos = 50;
                DateTime baseTime = DateTime.Now;

                foreach (string notification in notifications)
                {
                    MaterialLabel notifLabel = new MaterialLabel
                    {
                        Text = $"{notification}\n{baseTime.AddHours(-new Random().Next(1, 24)):MM/dd HH:mm}",
                        Location = new Point(15, yPos),
                        Size = new Size(370, 40),
                        Depth = 0
                    };
                    pnlNotifications.Controls.Add(notifLabel);
                    yPos += 45;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateShiftStats()
        {
            try
            {
                // STEP 4: To switch back to database:
                // 1. Remove the mock statistics implementation below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string query = @"
                        SELECT 
                            COUNT(*) as TotalShifts,
                            SUM(CASE WHEN Status = 'Scheduled' THEN 1 ELSE 0 END) as AvailableShifts,
                            SUM(CASE WHEN Status = 'Completed' THEN 1 ELSE 0 END) as CompletedShifts
                        FROM Flights
                        WHERE DepartureTime >= DATEADD(day, -30, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing stats
                    foreach (Control c in pnlShiftStats.Controls)
                    {
                        if (c != lblShiftStats)
                            c.Dispose();
                    }

                    if (reader.Read())
                    {
                        int yPos = 50;
                        string[] stats = {
                            $"Total Shifts: {reader["TotalShifts"]}",
                            $"Available Shifts: {reader["AvailableShifts"]}",
                            $"Completed Shifts: {reader["CompletedShifts"]}"
                        };

                        foreach (string stat in stats)
                        {
                            MaterialLabel statLabel = new MaterialLabel
                            {
                                Text = stat,
                                Location = new Point(15, yPos),
                                Size = new Size(370, 30),
                                Depth = 0
                            };
                            pnlShiftStats.Controls.Add(statLabel);
                            yPos += 35;
                        }
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                foreach (Control c in pnlShiftStats.Controls)
                {
                    if (c != lblShiftStats)
                        c.Dispose();
                }

                DataTable statsData = MockDataProvider.GetMockShiftStats();
                DataRow stats = statsData.Rows[0];

                int yPos = 50;
                string[] statLabels = {
                    $"Total Shifts: {stats["TotalShifts"]}",
                    $"Available Shifts: {stats["AvailableShifts"]}",
                    $"Completed Shifts: {stats["CompletedShifts"]}",
                    $"Cancelled Shifts: {stats["CancelledShifts"]}"
                };

                foreach (string stat in statLabels)
                {
                    MaterialLabel statLabel = new MaterialLabel
                    {
                        Text = stat,
                        Location = new Point(15, yPos),
                        Size = new Size(370, 30),
                        Depth = 0
                    };
                    pnlShiftStats.Controls.Add(statLabel);
                    yPos += 35;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating shift statistics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnShiftDetails_Click(object sender, EventArgs e)
        {
            if (sender is MaterialButton button && button.Tag != null)
            {
                // STEP 5: To switch back to database:
                // 1. Remove the mock implementation below
                // 2. Uncomment the following database code block
                /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                string flightNumber = button.Tag.ToString();
                using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                {
                    string query = @"
                        SELECT 
                            FlightNumber,
                            DepartureTime,
                            ArrivalTime,
                            Status,
                            Gate,
                            Aircraft
                        FROM Flights 
                        WHERE FlightNumber = @FlightNumber";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FlightNumber", flightNumber);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        string details = $"Flight Details:\n\n" +
                                       $"Flight Number: {reader["FlightNumber"]}\n" +
                                       $"Departure: {Convert.ToDateTime(reader["DepartureTime"]):MM/dd/yyyy HH:mm}\n" +
                                       $"Arrival: {Convert.ToDateTime(reader["ArrivalTime"]):MM/dd/yyyy HH:mm}\n" +
                                       $"Status: {reader["Status"]}\n" +
                                       $"Gate: {reader["Gate"]}\n" +
                                       $"Aircraft: {reader["Aircraft"]}";

                        MessageBox.Show(details, "Flight Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                DataRow row = (DataRow)button.Tag;
                string details = $"Flight Details:\n\n" +
                               $"Flight Number: {row["FlightNumber"]}\n" +
                               $"Departure: {Convert.ToDateTime(row["DepartureTime"]):MM/dd/yyyy HH:mm}\n" +
                               $"Arrival: {Convert.ToDateTime(row["ArrivalTime"]):MM/dd/yyyy HH:mm}\n" +
                               $"Status: {row["Status"]}\n" +
                               $"Gate: {row["Gate"]}\n" +
                               $"Aircraft: {row["Aircraft"]}";

                MessageBox.Show(details, "Flight Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSignUpForShift_Click(object sender, EventArgs e)
        {
            using (var dialog = new MaterialDialog(this, "Sign Up for Shift", 
                   "Please select a shift from the available shifts above.", "Sign Up", true, "Cancel"))
            {
                DialogResult result = dialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // STEP 6: To switch back to database:
                    // 1. Remove the mock implementation message below
                    // 2. Uncomment the following database code block
                    /* DATABASE CODE START - UNCOMMENT THIS BLOCK
                    using (SqlConnection conn = DatabaseConnection.ConnectToDatabase())
                    {
                        string updateQuery = "UPDATE Flights SET Status = 'Assigned' WHERE FlightNumber = @FlightNumber";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@FlightNumber", selectedFlightNumber);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Shift signed up successfully!", "Success", 
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadShifts();
                        }
                    }
                    DATABASE CODE END */

                    // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                    MessageBox.Show("Shift signed up successfully! (Mock Implementation)", 
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadShifts();
                }
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
