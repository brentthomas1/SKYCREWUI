using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SkyCrew
{
    partial class Login
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
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxRole = new MaterialSkin.Controls.MaterialComboBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblRole = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Depth = 0;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTitle.Location = new System.Drawing.Point(480, 80);
            this.lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sign In";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(480, 140);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 50);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPassword.Hint = "Password";
            this.txtPassword.Location = new System.Drawing.Point(480, 210);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(300, 50);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.AutoResize = false;
            this.comboBoxRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxRole.Depth = 0;
            this.comboBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxRole.DropDownHeight = 174;
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.DropDownWidth = 121;
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxRole.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.IntegralHeight = false;
            this.comboBoxRole.ItemHeight = 43;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Ground Crew",
            "Pilot",
            "Customer Service",
            "Admin",
            "Management"});
            this.comboBoxRole.Location = new System.Drawing.Point(480, 280);
            this.comboBoxRole.MaxDropDownItems = 4;
            this.comboBoxRole.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(300, 49);
            this.comboBoxRole.StartIndex = 0;
            this.comboBoxRole.TabIndex = 3;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(480, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(300, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Access My Account";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = false;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(750, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(50, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = true;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.Location = new System.Drawing.Point(480, 120);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(480, 190);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Depth = 0;
            this.lblRole.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRole.Location = new System.Drawing.Point(480, 260);
            this.lblRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 19);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role:";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyCrew Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialLabel lblTitle;
        private MaterialTextBox txtEmail;
        private MaterialTextBox txtPassword;
        private MaterialComboBox comboBoxRole;
        private MaterialButton btnLogin;
        private MaterialButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialLabel lblEmail;
        private MaterialLabel lblPassword;
        private MaterialLabel lblRole;
    }
}
