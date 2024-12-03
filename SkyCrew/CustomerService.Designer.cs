using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SkyCrew
{
    partial class CustomerService
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
            this.pnlAvailableShifts = new System.Windows.Forms.Panel();
            this.lblAvailableShifts = new MaterialSkin.Controls.MaterialLabel();
            this.btnShiftDetails1 = new MaterialSkin.Controls.MaterialButton();
            this.btnShiftDetails2 = new MaterialSkin.Controls.MaterialButton();
            this.btnShiftDetails3 = new MaterialSkin.Controls.MaterialButton();
            this.btnShiftDetails4 = new MaterialSkin.Controls.MaterialButton();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnSignUpForShift = new MaterialSkin.Controls.MaterialButton();
            this.lblQuickActions = new MaterialSkin.Controls.MaterialLabel();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lblNotifications = new MaterialSkin.Controls.MaterialLabel();
            this.pnlShiftStats = new System.Windows.Forms.Panel();
            this.lblShiftStats = new MaterialSkin.Controls.MaterialLabel();
            this.lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            this.pnlAvailableShifts.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.pnlShiftStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAvailableShifts
            // 
            this.pnlAvailableShifts.BackColor = System.Drawing.Color.White;
            this.pnlAvailableShifts.Controls.Add(this.lblAvailableShifts);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails1);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails2);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails3);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails4);
            this.pnlAvailableShifts.Location = new System.Drawing.Point(20, 100);
            this.pnlAvailableShifts.Name = "pnlAvailableShifts";
            this.pnlAvailableShifts.Size = new System.Drawing.Size(400, 220);
            this.pnlAvailableShifts.TabIndex = 0;
            // 
            // lblAvailableShifts
            // 
            this.lblAvailableShifts.AutoSize = true;
            this.lblAvailableShifts.Depth = 0;
            this.lblAvailableShifts.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAvailableShifts.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblAvailableShifts.Location = new System.Drawing.Point(10, 10);
            this.lblAvailableShifts.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAvailableShifts.Name = "lblAvailableShifts";
            this.lblAvailableShifts.Size = new System.Drawing.Size(166, 29);
            this.lblAvailableShifts.TabIndex = 0;
            this.lblAvailableShifts.Text = "Available Shifts";
            // 
            // btnShiftDetails1
            // 
            this.btnShiftDetails1.AutoSize = false;
            this.btnShiftDetails1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShiftDetails1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShiftDetails1.Depth = 0;
            this.btnShiftDetails1.HighEmphasis = true;
            this.btnShiftDetails1.Icon = null;
            this.btnShiftDetails1.Location = new System.Drawing.Point(15, 60);
            this.btnShiftDetails1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShiftDetails1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShiftDetails1.Name = "btnShiftDetails1";
            this.btnShiftDetails1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShiftDetails1.Size = new System.Drawing.Size(370, 36);
            this.btnShiftDetails1.TabIndex = 1;
            this.btnShiftDetails1.Text = "Shift 1 Details";
            this.btnShiftDetails1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShiftDetails1.UseAccentColor = false;
            this.btnShiftDetails1.UseVisualStyleBackColor = true;
            // 
            // btnShiftDetails2
            // 
            this.btnShiftDetails2.AutoSize = false;
            this.btnShiftDetails2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShiftDetails2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShiftDetails2.Depth = 0;
            this.btnShiftDetails2.HighEmphasis = true;
            this.btnShiftDetails2.Icon = null;
            this.btnShiftDetails2.Location = new System.Drawing.Point(15, 100);
            this.btnShiftDetails2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShiftDetails2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShiftDetails2.Name = "btnShiftDetails2";
            this.btnShiftDetails2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShiftDetails2.Size = new System.Drawing.Size(370, 36);
            this.btnShiftDetails2.TabIndex = 2;
            this.btnShiftDetails2.Text = "Shift 2 Details";
            this.btnShiftDetails2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShiftDetails2.UseAccentColor = false;
            this.btnShiftDetails2.UseVisualStyleBackColor = true;
            // 
            // btnShiftDetails3
            // 
            this.btnShiftDetails3.AutoSize = false;
            this.btnShiftDetails3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShiftDetails3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShiftDetails3.Depth = 0;
            this.btnShiftDetails3.HighEmphasis = true;
            this.btnShiftDetails3.Icon = null;
            this.btnShiftDetails3.Location = new System.Drawing.Point(15, 140);
            this.btnShiftDetails3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShiftDetails3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShiftDetails3.Name = "btnShiftDetails3";
            this.btnShiftDetails3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShiftDetails3.Size = new System.Drawing.Size(370, 36);
            this.btnShiftDetails3.TabIndex = 3;
            this.btnShiftDetails3.Text = "Shift 3 Details";
            this.btnShiftDetails3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShiftDetails3.UseAccentColor = false;
            this.btnShiftDetails3.UseVisualStyleBackColor = true;
            // 
            // btnShiftDetails4
            // 
            this.btnShiftDetails4.AutoSize = false;
            this.btnShiftDetails4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShiftDetails4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShiftDetails4.Depth = 0;
            this.btnShiftDetails4.HighEmphasis = true;
            this.btnShiftDetails4.Icon = null;
            this.btnShiftDetails4.Location = new System.Drawing.Point(15, 180);
            this.btnShiftDetails4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShiftDetails4.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShiftDetails4.Name = "btnShiftDetails4";
            this.btnShiftDetails4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShiftDetails4.Size = new System.Drawing.Size(370, 36);
            this.btnShiftDetails4.TabIndex = 4;
            this.btnShiftDetails4.Text = "Shift 4 Details";
            this.btnShiftDetails4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShiftDetails4.UseAccentColor = false;
            this.btnShiftDetails4.UseVisualStyleBackColor = true;
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.Controls.Add(this.btnSignUpForShift);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(440, 100);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(400, 220);
            this.pnlQuickActions.TabIndex = 1;
            this.pnlQuickActions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuickActions_Paint);
            // 
            // btnSignUpForShift
            // 
            this.btnSignUpForShift.AutoSize = false;
            this.btnSignUpForShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignUpForShift.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSignUpForShift.Depth = 0;
            this.btnSignUpForShift.HighEmphasis = true;
            this.btnSignUpForShift.Icon = null;
            this.btnSignUpForShift.Location = new System.Drawing.Point(15, 60);
            this.btnSignUpForShift.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignUpForShift.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignUpForShift.Name = "btnSignUpForShift";
            this.btnSignUpForShift.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSignUpForShift.Size = new System.Drawing.Size(370, 36);
            this.btnSignUpForShift.TabIndex = 0;
            this.btnSignUpForShift.Text = "Sign Up for Shift";
            this.btnSignUpForShift.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSignUpForShift.UseAccentColor = false;
            this.btnSignUpForShift.UseVisualStyleBackColor = true;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Depth = 0;
            this.lblQuickActions.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuickActions.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblQuickActions.Location = new System.Drawing.Point(10, 10);
            this.lblQuickActions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(150, 29);
            this.lblQuickActions.TabIndex = 1;
            this.lblQuickActions.Text = "Quick Actions";
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BackColor = System.Drawing.Color.White;
            this.pnlNotifications.Controls.Add(this.lblNotifications);
            this.pnlNotifications.Location = new System.Drawing.Point(20, 340);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(400, 200);
            this.pnlNotifications.TabIndex = 2;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Depth = 0;
            this.lblNotifications.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNotifications.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblNotifications.Location = new System.Drawing.Point(10, 10);
            this.lblNotifications.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(139, 29);
            this.lblNotifications.TabIndex = 0;
            this.lblNotifications.Text = "Notifications";
            // 
            // pnlShiftStats
            // 
            this.pnlShiftStats.BackColor = System.Drawing.Color.White;
            this.pnlShiftStats.Controls.Add(this.lblShiftStats);
            this.pnlShiftStats.Location = new System.Drawing.Point(440, 340);
            this.pnlShiftStats.Name = "pnlShiftStats";
            this.pnlShiftStats.Size = new System.Drawing.Size(400, 200);
            this.pnlShiftStats.TabIndex = 3;
            this.pnlShiftStats.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShiftStats_Paint);
            // 
            // lblShiftStats
            // 
            this.lblShiftStats.AutoSize = true;
            this.lblShiftStats.Depth = 0;
            this.lblShiftStats.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblShiftStats.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblShiftStats.Location = new System.Drawing.Point(10, 10);
            this.lblShiftStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblShiftStats.Name = "lblShiftStats";
            this.lblShiftStats.Size = new System.Drawing.Size(156, 29);
            this.lblShiftStats.TabIndex = 0;
            this.lblShiftStats.Text = "Shift Statistics";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Depth = 0;
            this.lblWelcome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblWelcome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblWelcome.Location = new System.Drawing.Point(20, 70);
            this.lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(198, 24);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome back, Agent!";
            // 
            // CustomerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlShiftStats);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlQuickActions);
            this.Controls.Add(this.pnlAvailableShifts);
            this.Name = "CustomerService";
            this.Text = "SkyCrew - Customer Service Dashboard";
            this.pnlAvailableShifts.ResumeLayout(false);
            this.pnlAvailableShifts.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            this.pnlShiftStats.ResumeLayout(false);
            this.pnlShiftStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAvailableShifts;
        private MaterialLabel lblAvailableShifts;
        private MaterialButton btnShiftDetails1;
        private MaterialButton btnShiftDetails2;
        private MaterialButton btnShiftDetails3;
        private MaterialButton btnShiftDetails4;
        private System.Windows.Forms.Panel pnlQuickActions;
        private MaterialButton btnSignUpForShift;
        private MaterialLabel lblQuickActions;
        private System.Windows.Forms.Panel pnlNotifications;
        private MaterialLabel lblNotifications;
        private System.Windows.Forms.Panel pnlShiftStats;
        private MaterialLabel lblShiftStats;
        private MaterialLabel lblWelcome;
    }
}
