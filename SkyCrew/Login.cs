using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SkyCrew
{
    public partial class Login : MaterialForm
    {
        public Login()
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

            // Add roles to the combo box
            comboBoxRole.Items.AddRange(new object[] {
                "Ground Crew",
                "Pilot",
                "Admin",
                "Management"
            });
            comboBoxRole.SelectedIndex = 0; // Set default selection

            // Bind event handlers
            btnLogin.Click += buttonLogin_Click;
            btnExit.Click += buttonExit_Click;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Handle login logic here
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = comboBoxRole.SelectedItem.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // For testing without database, we'll simulate a successful login
            // You can replace this with your actual database authentication logic

            if (email == "test@example.com" && password == "password")
            {
                MessageBox.Show($"Login successful as {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the corresponding dashboard based on role
                switch (role)
                {
                    case "Ground Crew":
                        GroundCrew groundCrewForm = new GroundCrew();
                        groundCrewForm.Show();
                        break;
                    case "Pilot":
                        Pilot pilotForm = new Pilot();
                        pilotForm.Show();
                        break;
                    case "Admin":
                        Admin adminForm = new Admin();
                        adminForm.Show();
                        break;
                    case "Management":
                        Management managementForm = new Management();
                        managementForm.Show();
                        break;
                    default:
                        MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle role selection change if needed
            // For now, no specific action is required
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
