using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Panel panelMain;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Panel panelCard;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        /// <param name="disposing"></param>
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelMain = new Panel();
            this.panelCard = new Panel();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnExit = new Button();

            // 
            // FormLogin
            // 
            this.Text = "Login - Klinik Apotek";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(520, 340);
            this.MaximizeBox = true;

            // 
            // panelHeader
            // 
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(60, 140, 200);
            this.panelHeader.Padding = new Padding(10);
            this.panelHeader.Controls.Add(this.lblTitle);

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Sistem Klinik & Apotek";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 18);

            // 
            // panelMain
            // 
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelMain.Padding = new Padding(20);
            this.panelMain.Controls.Add(this.panelCard);

            // 
            // panelCard (centered card)
            // 
            this.panelCard.Width = 420;
            this.panelCard.Height = 200;
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = BorderStyle.FixedSingle;
            this.panelCard.Location = new System.Drawing.Point((this.ClientSize.Width - this.panelCard.Width) / 2 - 4, 90);
            this.panelCard.Anchor = AnchorStyles.None;
            this.panelCard.Controls.Add(this.lblUsername);
            this.panelCard.Controls.Add(this.txtUsername);
            this.panelCard.Controls.Add(this.lblPassword);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.btnLogin);
            this.panelCard.Controls.Add(this.btnExit);

            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(24, 22);
            this.lblUsername.AutoSize = true;

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(24, 42);
            this.txtUsername.Width = 360;

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(24, 82);
            this.lblPassword.AutoSize = true;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(24, 102);
            this.txtPassword.Width = 360;
            this.txtPassword.PasswordChar = '●';

            // 
            // btnLogin
            // 
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(24, 142);
            this.btnLogin.Width = 170;
            this.btnLogin.Height = 32;
            this.btnLogin.FlatStyle = FlatStyle.Flat;

            // 
            // btnExit
            // 
            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(214, 142);
            this.btnExit.Width = 170;
            this.btnExit.Height = 32;
            this.btnExit.FlatStyle = FlatStyle.Flat;

            // Add panels to form
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);

            // Hookup events in designer (actual event handlers in FormLogin.cs)
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
        }
        #endregion
    }
}
