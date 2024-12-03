using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SkyCrew
{
    partial class Management
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method remains the same
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.pnlStaffOverview = new System.Windows.Forms.Panel();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.lblStaffOverview = new MaterialSkin.Controls.MaterialLabel();
            this.pnlFlightsOverview = new System.Windows.Forms.Panel();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.lblFlightsOverview = new MaterialSkin.Controls.MaterialLabel();
            this.pnlBookingsOverview = new System.Windows.Forms.Panel();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.lblBookingsOverview = new MaterialSkin.Controls.MaterialLabel();
            this.btnOpenPilotForm = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenGroundCrewForm = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenCustomerServiceForm = new MaterialSkin.Controls.MaterialButton();
            this.btnOpenAdminForm = new MaterialSkin.Controls.MaterialButton();
            this.pnlStaffOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.pnlFlightsOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.pnlBookingsOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.Location = new System.Drawing.Point(20, 80);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LNB Airlines";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWelcome.Location = new System.Drawing.Point(20, 120);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(188, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome back, Jake!";
            // 
            // pnlStaffOverview
            // 
            this.pnlStaffOverview.BackColor = System.Drawing.Color.White;
            this.pnlStaffOverview.Controls.Add(this.dataGridViewStaff);
            this.pnlStaffOverview.Controls.Add(this.lblStaffOverview);
            this.pnlStaffOverview.Location = new System.Drawing.Point(20, 160);
            this.pnlStaffOverview.Name = "pnlStaffOverview";
            this.pnlStaffOverview.Size = new System.Drawing.Size(600, 300);
            this.pnlStaffOverview.TabIndex = 2;
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AllowUserToAddRows = false;
            this.dataGridViewStaff.AllowUserToDeleteRows = false;
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.ReadOnly = true;
            this.dataGridViewStaff.RowHeadersWidth = 62;
            this.dataGridViewStaff.RowTemplate.Height = 28;
            this.dataGridViewStaff.Size = new System.Drawing.Size(580, 240);
            this.dataGridViewStaff.TabIndex = 1;
            // 
            // lblStaffOverview
            // 
            this.lblStaffOverview.AutoSize = true;
            this.lblStaffOverview.Depth = 0;
            this.lblStaffOverview.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStaffOverview.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblStaffOverview.Location = new System.Drawing.Point(10, 10);
            this.lblStaffOverview.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStaffOverview.Name = "lblStaffOverview";
            this.lblStaffOverview.Size = new System.Drawing.Size(133, 24);
            this.lblStaffOverview.TabIndex = 0;
            this.lblStaffOverview.Text = "Staff Overview";
            // 
            // pnlFlightsOverview
            // 
            this.pnlFlightsOverview.BackColor = System.Drawing.Color.White;
            this.pnlFlightsOverview.Controls.Add(this.dataGridViewFlights);
            this.pnlFlightsOverview.Controls.Add(this.lblFlightsOverview);
            this.pnlFlightsOverview.Location = new System.Drawing.Point(20, 480);
            this.pnlFlightsOverview.Name = "pnlFlightsOverview";
            this.pnlFlightsOverview.Size = new System.Drawing.Size(600, 300);
            this.pnlFlightsOverview.TabIndex = 3;
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.AllowUserToAddRows = false;
            this.dataGridViewFlights.AllowUserToDeleteRows = false;
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.ReadOnly = true;
            this.dataGridViewFlights.RowHeadersWidth = 62;
            this.dataGridViewFlights.RowTemplate.Height = 28;
            this.dataGridViewFlights.Size = new System.Drawing.Size(580, 240);
            this.dataGridViewFlights.TabIndex = 1;
            // 
            // lblFlightsOverview
            // 
            this.lblFlightsOverview.AutoSize = true;
            this.lblFlightsOverview.Depth = 0;
            this.lblFlightsOverview.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFlightsOverview.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblFlightsOverview.Location = new System.Drawing.Point(10, 10);
            this.lblFlightsOverview.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFlightsOverview.Name = "lblFlightsOverview";
            this.lblFlightsOverview.Size = new System.Drawing.Size(149, 24);
            this.lblFlightsOverview.TabIndex = 0;
            this.lblFlightsOverview.Text = "Flights Overview";
            // 
            // pnlBookingsOverview
            // 
            this.pnlBookingsOverview.BackColor = System.Drawing.Color.White;
            this.pnlBookingsOverview.Controls.Add(this.dataGridViewBookings);
            this.pnlBookingsOverview.Controls.Add(this.lblBookingsOverview);
            this.pnlBookingsOverview.Location = new System.Drawing.Point(640, 160);
            this.pnlBookingsOverview.Name = "pnlBookingsOverview";
            this.pnlBookingsOverview.Size = new System.Drawing.Size(600, 620);
            this.pnlBookingsOverview.TabIndex = 4;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AllowUserToAddRows = false;
            this.dataGridViewBookings.AllowUserToDeleteRows = false;
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.ReadOnly = true;
            this.dataGridViewBookings.RowHeadersWidth = 62;
            this.dataGridViewBookings.RowTemplate.Height = 28;
            this.dataGridViewBookings.Size = new System.Drawing.Size(580, 560);
            this.dataGridViewBookings.TabIndex = 1;
            this.dataGridViewBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookings_CellContentClick);
            // 
            // lblBookingsOverview
            // 
            this.lblBookingsOverview.AutoSize = true;
            this.lblBookingsOverview.Depth = 0;
            this.lblBookingsOverview.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblBookingsOverview.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblBookingsOverview.Location = new System.Drawing.Point(10, 10);
            this.lblBookingsOverview.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBookingsOverview.Name = "lblBookingsOverview";
            this.lblBookingsOverview.Size = new System.Drawing.Size(171, 24);
            this.lblBookingsOverview.TabIndex = 0;
            this.lblBookingsOverview.Text = "Bookings Overview";
            // 
            // btnOpenPilotForm
            // 
            this.btnOpenPilotForm.AutoSize = false;
            this.btnOpenPilotForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPilotForm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenPilotForm.Depth = 0;
            this.btnOpenPilotForm.HighEmphasis = true;
            this.btnOpenPilotForm.Icon = null;
            this.btnOpenPilotForm.Location = new System.Drawing.Point(20, 800);
            this.btnOpenPilotForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenPilotForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenPilotForm.Name = "btnOpenPilotForm";
            this.btnOpenPilotForm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenPilotForm.Size = new System.Drawing.Size(150, 36);
            this.btnOpenPilotForm.TabIndex = 5;
            this.btnOpenPilotForm.Text = "Open Pilot Form";
            this.btnOpenPilotForm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenPilotForm.UseAccentColor = false;
            this.btnOpenPilotForm.UseVisualStyleBackColor = true;
            this.btnOpenPilotForm.Click += new System.EventHandler(this.btnOpenPilotForm_Click);
            // 
            // btnOpenGroundCrewForm
            // 
            this.btnOpenGroundCrewForm.AutoSize = false;
            this.btnOpenGroundCrewForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenGroundCrewForm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenGroundCrewForm.Depth = 0;
            this.btnOpenGroundCrewForm.HighEmphasis = true;
            this.btnOpenGroundCrewForm.Icon = null;
            this.btnOpenGroundCrewForm.Location = new System.Drawing.Point(180, 800);
            this.btnOpenGroundCrewForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenGroundCrewForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenGroundCrewForm.Name = "btnOpenGroundCrewForm";
            this.btnOpenGroundCrewForm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenGroundCrewForm.Size = new System.Drawing.Size(180, 36);
            this.btnOpenGroundCrewForm.TabIndex = 6;
            this.btnOpenGroundCrewForm.Text = "Open Ground Crew";
            this.btnOpenGroundCrewForm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenGroundCrewForm.UseAccentColor = false;
            this.btnOpenGroundCrewForm.UseVisualStyleBackColor = true;
            this.btnOpenGroundCrewForm.Click += new System.EventHandler(this.btnOpenGroundCrewForm_Click);
            // 
            // btnOpenCustomerServiceForm
            // 
            this.btnOpenCustomerServiceForm.AutoSize = false;
            this.btnOpenCustomerServiceForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenCustomerServiceForm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenCustomerServiceForm.Depth = 0;
            this.btnOpenCustomerServiceForm.HighEmphasis = true;
            this.btnOpenCustomerServiceForm.Icon = null;
            this.btnOpenCustomerServiceForm.Location = new System.Drawing.Point(370, 800);
            this.btnOpenCustomerServiceForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenCustomerServiceForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenCustomerServiceForm.Name = "btnOpenCustomerServiceForm";
            this.btnOpenCustomerServiceForm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenCustomerServiceForm.Size = new System.Drawing.Size(200, 36);
            this.btnOpenCustomerServiceForm.TabIndex = 7;
            this.btnOpenCustomerServiceForm.Text = "Open Customer Service";
            this.btnOpenCustomerServiceForm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenCustomerServiceForm.UseAccentColor = false;
            this.btnOpenCustomerServiceForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerServiceForm.Click += new System.EventHandler(this.btnOpenCustomerServiceForm_Click);
            // 
            // btnOpenAdminForm
            // 
            this.btnOpenAdminForm.AutoSize = false;
            this.btnOpenAdminForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenAdminForm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpenAdminForm.Depth = 0;
            this.btnOpenAdminForm.HighEmphasis = true;
            this.btnOpenAdminForm.Icon = null;
            this.btnOpenAdminForm.Location = new System.Drawing.Point(580, 800);
            this.btnOpenAdminForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpenAdminForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenAdminForm.Name = "btnOpenAdminForm";
            this.btnOpenAdminForm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpenAdminForm.Size = new System.Drawing.Size(150, 36);
            this.btnOpenAdminForm.TabIndex = 8;
            this.btnOpenAdminForm.Text = "Open Admin";
            this.btnOpenAdminForm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpenAdminForm.UseAccentColor = false;
            this.btnOpenAdminForm.UseVisualStyleBackColor = true;
            this.btnOpenAdminForm.Click += new System.EventHandler(this.btnOpenAdminForm_Click);
            // 
            // Management
            // 
            this.ClientSize = new System.Drawing.Size(1360, 860);
            this.Controls.Add(this.btnOpenAdminForm);
            this.Controls.Add(this.btnOpenCustomerServiceForm);
            this.Controls.Add(this.btnOpenGroundCrewForm);
            this.Controls.Add(this.btnOpenPilotForm);
            this.Controls.Add(this.pnlBookingsOverview);
            this.Controls.Add(this.pnlFlightsOverview);
            this.Controls.Add(this.pnlStaffOverview);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyCrew - Management Overview";
            this.Load += new System.EventHandler(this.Management_Load);
            this.pnlStaffOverview.ResumeLayout(false);
            this.pnlStaffOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.pnlFlightsOverview.ResumeLayout(false);
            this.pnlFlightsOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.pnlBookingsOverview.ResumeLayout(false);
            this.pnlBookingsOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblTitle;
        private MaterialLabel lblWelcome;
        private Panel pnlStaffOverview;
        private DataGridView dataGridViewStaff;
        private MaterialLabel lblStaffOverview;
        private Panel pnlFlightsOverview;
        private DataGridView dataGridViewFlights;
        private MaterialLabel lblFlightsOverview;
        private Panel pnlBookingsOverview;
        private DataGridView dataGridViewBookings;
        private MaterialLabel lblBookingsOverview;
        private MaterialButton btnOpenPilotForm;
        private MaterialButton btnOpenGroundCrewForm;
        private MaterialButton btnOpenCustomerServiceForm;
        private MaterialButton btnOpenAdminForm;
    }
}
