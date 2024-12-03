using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
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

            // Add roles to the combo box - using the roles from MockDataProvider
            var uniqueRoles = MockDataProvider.MockCredentials
                .Select(c => c.Role)
                .Distinct()
                .ToArray();
            comboBoxRole.Items.AddRange(uniqueRoles);
            comboBoxRole.SelectedIndex = 0; // Set default selection

            // Bind event handlers
            btnLogin.Click += buttonLogin_Click;
            btnExit.Click += buttonExit_Click;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role;
            if (MockDataProvider.ValidateLogin(username, password, out role))
            {
                MessageBox.Show($"Login successful as {role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the corresponding dashboard based on role
                Form dashboardForm = null;
                switch (role)
                {
                    case "Ground Crew":
                        dashboardForm = new GroundCrew();
                        break;
                    case "Pilot":
                        dashboardForm = new Pilot();
                        break;
                    case "Admin":
                        dashboardForm = new Admin();
                        break;
                    case "Management":
                        dashboardForm = new Management();
                        break;
                    default:
                        MessageBox.Show("Invalid role assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (dashboardForm != null)
                {
                    dashboardForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Role selection is now handled during login validation
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
