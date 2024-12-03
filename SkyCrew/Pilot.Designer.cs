using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SkyCrew
{
    partial class Pilot
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
            this.pnlUpcomingFlights = new System.Windows.Forms.Panel();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.lblUpcomingFlights = new MaterialSkin.Controls.MaterialLabel();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnRequestLeave = new MaterialSkin.Controls.MaterialButton();
            this.lblQuickActions = new MaterialSkin.Controls.MaterialLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.pnlUpcomingFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.pnlQuickActions.SuspendLayout();
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
            this.lblWelcome.Size = new System.Drawing.Size(189, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome back, John!";
            // 
            // pnlUpcomingFlights
            // 
            this.pnlUpcomingFlights.BackColor = System.Drawing.Color.White;
            this.pnlUpcomingFlights.Controls.Add(this.dataGridViewFlights);
            this.pnlUpcomingFlights.Controls.Add(this.lblUpcomingFlights);
            this.pnlUpcomingFlights.Location = new System.Drawing.Point(20, 160);
            this.pnlUpcomingFlights.Name = "pnlUpcomingFlights";
            this.pnlUpcomingFlights.Size = new System.Drawing.Size(500, 400);
            this.pnlUpcomingFlights.TabIndex = 2;
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
            this.dataGridViewFlights.Size = new System.Drawing.Size(480, 340);
            this.dataGridViewFlights.TabIndex = 1;
            // 
            // lblUpcomingFlights
            // 
            this.lblUpcomingFlights.AutoSize = true;
            this.lblUpcomingFlights.Depth = 0;
            this.lblUpcomingFlights.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUpcomingFlights.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblUpcomingFlights.Location = new System.Drawing.Point(10, 10);
            this.lblUpcomingFlights.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUpcomingFlights.Name = "lblUpcomingFlights";
            this.lblUpcomingFlights.Size = new System.Drawing.Size(155, 24);
            this.lblUpcomingFlights.TabIndex = 0;
            this.lblUpcomingFlights.Text = "Upcoming Flights";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.Controls.Add(this.btnRequestLeave);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(540, 420);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(312, 140);
            this.pnlQuickActions.TabIndex = 3;
            this.pnlQuickActions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuickActions_Paint);
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.AutoSize = false;
            this.btnRequestLeave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRequestLeave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRequestLeave.Depth = 0;
            this.btnRequestLeave.HighEmphasis = true;
            this.btnRequestLeave.Icon = null;
            this.btnRequestLeave.Location = new System.Drawing.Point(10, 50);
            this.btnRequestLeave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRequestLeave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRequestLeave.Size = new System.Drawing.Size(280, 36);
            this.btnRequestLeave.TabIndex = 1;
            this.btnRequestLeave.Text = "Request Leave";
            this.btnRequestLeave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRequestLeave.UseAccentColor = false;
            this.btnRequestLeave.UseVisualStyleBackColor = true;
            this.btnRequestLeave.Click += new System.EventHandler(this.BtnRequestLeave_Click);
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Depth = 0;
            this.lblQuickActions.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuickActions.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblQuickActions.Location = new System.Drawing.Point(10, 10);
            this.lblQuickActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(123, 24);
            this.lblQuickActions.TabIndex = 0;
            this.lblQuickActions.Text = "Quick Actions";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(540, 160);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(540, 320);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(312, 94);
            this.listBoxNotifications.TabIndex = 5;
            // 
            // Pilot
            // 
            this.ClientSize = new System.Drawing.Size(893, 600);
            this.Controls.Add(this.listBoxNotifications);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pnlQuickActions);
            this.Controls.Add(this.pnlUpcomingFlights);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblTitle);
            this.Name = "Pilot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyCrew - Pilot Dashboard";
            this.pnlUpcomingFlights.ResumeLayout(false);
            this.pnlUpcomingFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblTitle;
        private MaterialLabel lblWelcome;
        private Panel pnlUpcomingFlights;
        private DataGridView dataGridViewFlights;
        private MaterialLabel lblUpcomingFlights;
        private Panel pnlQuickActions;
        private MaterialButton btnRequestLeave;
        private MaterialLabel lblQuickActions;
        private MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxNotifications;
    }
}
