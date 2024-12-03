using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SkyCrew
{
    partial class GroundCrew
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
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.pnlUpcomingShifts = new System.Windows.Forms.Panel();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.lblUpcomingShifts = new MaterialSkin.Controls.MaterialLabel();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.buttonAcceptShift = new MaterialSkin.Controls.MaterialButton();
            this.buttonCancelShift = new MaterialSkin.Controls.MaterialButton();
            this.lblQuickActions = new MaterialSkin.Controls.MaterialLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.pnlUpcomingShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.pnlQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblWelcome.Location = new System.Drawing.Point(20, 80);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(228, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back, Jane!";
            // 
            // pnlUpcomingShifts
            // 
            this.pnlUpcomingShifts.BackColor = System.Drawing.Color.White;
            this.pnlUpcomingShifts.Controls.Add(this.dataGridViewShifts);
            this.pnlUpcomingShifts.Controls.Add(this.lblUpcomingShifts);
            this.pnlUpcomingShifts.Location = new System.Drawing.Point(20, 120);
            this.pnlUpcomingShifts.Name = "pnlUpcomingShifts";
            this.pnlUpcomingShifts.Size = new System.Drawing.Size(800, 400);
            this.pnlUpcomingShifts.TabIndex = 1;
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(10, 50);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.RowHeadersWidth = 62;
            this.dataGridViewShifts.RowTemplate.Height = 28;
            this.dataGridViewShifts.Size = new System.Drawing.Size(780, 340);
            this.dataGridViewShifts.TabIndex = 1;
            this.dataGridViewShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShifts_CellContentClick);
            // 
            // lblUpcomingShifts
            // 
            this.lblUpcomingShifts.AutoSize = true;
            this.lblUpcomingShifts.Depth = 0;
            this.lblUpcomingShifts.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblUpcomingShifts.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblUpcomingShifts.Location = new System.Drawing.Point(10, 10);
            this.lblUpcomingShifts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUpcomingShifts.Name = "lblUpcomingShifts";
            this.lblUpcomingShifts.Size = new System.Drawing.Size(147, 24);
            this.lblUpcomingShifts.TabIndex = 0;
            this.lblUpcomingShifts.Text = "Upcoming Shifts";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.Controls.Add(this.buttonAcceptShift);
            this.pnlQuickActions.Controls.Add(this.buttonCancelShift);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(840, 120);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(300, 200);
            this.pnlQuickActions.TabIndex = 2;
            // 
            // buttonAcceptShift
            // 
            this.buttonAcceptShift.AutoSize = false;
            this.buttonAcceptShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAcceptShift.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAcceptShift.Depth = 0;
            this.buttonAcceptShift.HighEmphasis = true;
            this.buttonAcceptShift.Icon = null;
            this.buttonAcceptShift.Location = new System.Drawing.Point(15, 60);
            this.buttonAcceptShift.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAcceptShift.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAcceptShift.Name = "buttonAcceptShift";
            this.buttonAcceptShift.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAcceptShift.Size = new System.Drawing.Size(270, 36);
            this.buttonAcceptShift.TabIndex = 1;
            this.buttonAcceptShift.Text = "Accept Shift";
            this.buttonAcceptShift.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAcceptShift.UseAccentColor = false;
            this.buttonAcceptShift.UseVisualStyleBackColor = true;
            this.buttonAcceptShift.Click += new System.EventHandler(this.buttonAcceptShift_Click);
            // 
            // buttonCancelShift
            // 
            this.buttonCancelShift.AutoSize = false;
            this.buttonCancelShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancelShift.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonCancelShift.Depth = 0;
            this.buttonCancelShift.HighEmphasis = true;
            this.buttonCancelShift.Icon = null;
            this.buttonCancelShift.Location = new System.Drawing.Point(15, 110);
            this.buttonCancelShift.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonCancelShift.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonCancelShift.Name = "buttonCancelShift";
            this.buttonCancelShift.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonCancelShift.Size = new System.Drawing.Size(270, 36);
            this.buttonCancelShift.TabIndex = 2;
            this.buttonCancelShift.Text = "Drop Shift";
            this.buttonCancelShift.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonCancelShift.UseAccentColor = false;
            this.buttonCancelShift.UseVisualStyleBackColor = true;
            this.buttonCancelShift.Click += new System.EventHandler(this.buttonCancelShift_Click);
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
            this.monthCalendar1.Location = new System.Drawing.Point(840, 340);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(840, 560);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(300, 60);
            this.listBoxNotifications.TabIndex = 4;
            // 
            // GroundCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1160, 626);
            this.Controls.Add(this.listBoxNotifications);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pnlQuickActions);
            this.Controls.Add(this.pnlUpcomingShifts);
            this.Controls.Add(this.lblWelcome);
            this.Name = "GroundCrew";
            this.Text = "SkyCrew - Ground Crew Dashboard";
            this.Load += new System.EventHandler(this.GroundCrew_Load);
            this.pnlUpcomingShifts.ResumeLayout(false);
            this.pnlUpcomingShifts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblWelcome;
        private System.Windows.Forms.Panel pnlUpcomingShifts;
        private MaterialLabel lblUpcomingShifts;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.Panel pnlQuickActions;
        private MaterialLabel lblQuickActions;
        private MaterialButton buttonAcceptShift;
        private MaterialButton buttonCancelShift;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxNotifications;
    }
}
