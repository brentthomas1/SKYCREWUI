using System;
using System.Configuration;
using System.Data;
// STEP 1: Uncomment the following line when switching back to database
// using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SkyCrew;

namespace SkyCrew
{
    public partial class GroundCrew : MaterialForm
    {
        public GroundCrew()
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
            buttonAcceptShift.Click += buttonAcceptShift_Click;
            buttonCancelShift.Click += buttonCancelShift_Click;

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
                string connectionString = ConfigurationManager.ConnectionStrings["LNBAirlines"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            s.ShiftID,
                            s.Date,
                            s.StartTime,
                            s.EndTime,
                            s.Status,
                            s.AssignedTo,
                            s.Location
                        FROM Shifts s
                        WHERE s.Department = 'Ground Crew'
                        AND s.Date >= GETDATE()
                        ORDER BY s.Date, s.StartTime";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable shiftData = new DataTable();
                    adapter.Fill(shiftData);
                    dataGridViewShifts.DataSource = shiftData;

                    // Load notifications
                    query = @"
                        SELECT TOP 5
                            Message,
                            CreatedAt
                        FROM Notifications
                        WHERE Department = 'Ground Crew'
                        ORDER BY CreatedAt DESC";

                    cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBoxNotifications.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxNotifications.Items.Add($"{reader["Message"]} ({Convert.ToDateTime(reader["CreatedAt"]):g})");
                    }
                }
                DATABASE CODE END */

                // MOCK IMPLEMENTATION - REMOVE THIS WHEN SWITCHING TO DATABASE
                var shiftData = MockDataProvider.GetMockShiftStats();
                dataGridViewShifts.DataSource = shiftData;

                // Load notifications
                var notifications = MockDataProvider.GetMockNotifications("Ground Crew");
                listBoxNotifications.Items.Clear();
                listBoxNotifications.Items.AddRange(notifications);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAcceptShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to accept.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // STEP 3: To switch back to database:
            // Add your database-specific handling code here
            MessageBox.Show("Shift accepted successfully! (Mock Implementation)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadShiftData();
        }

        private void buttonCancelShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewShifts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a shift to cancel.", "No Shift Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // STEP 4: To switch back to database:
            // Add your database-specific handling code here
            MessageBox.Show("Shift cancelled successfully! (Mock Implementation)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadShiftData();
        }

        private void dataGridViewShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
            // STEP 5: To switch back to database:
            // Add your database-specific handling code here
        }

        private void GroundCrew_Load(object sender, EventArgs e)
        {
            // Load initial data
            LoadShiftData();
        }
    }
}
