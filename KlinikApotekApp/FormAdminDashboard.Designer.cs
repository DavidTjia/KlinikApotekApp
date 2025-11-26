using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormAdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSidebar;
        private Button btnManagePasien;
        private Button btnManageObat;
        private Button btnManageResep;
        private Button btnManageTransaksi;
        private Button btnManageUsers;
        private Button btnLogout;
        private Panel panelContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer generated
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new Panel();
            this.lblHeader = new Label();
            this.panelSidebar = new Panel();
            this.btnManagePasien = new Button();
            this.btnManageObat = new Button();
            this.btnManageResep = new Button();
            this.btnManageTransaksi = new Button();
            this.btnManageUsers = new Button();
            this.btnLogout = new Button();
            this.panelContainer = new Panel();

            // 
            // FormAdminDashboard
            // 
            this.Text = "Admin Dashboard - Klinik Apotek";
            this.WindowState = FormWindowState.Maximized;

            // 
            // panelHeader
            // 
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(45, 110, 180);
            this.panelHeader.Padding = new Padding(10);
            this.panelHeader.Controls.Add(this.lblHeader);

            // 
            // lblHeader
            // 
            this.lblHeader.Text = "Dashboard Admin - Klinik & Apotek";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(16, 20);

            // 
            // panelSidebar
            // 
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 220;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            this.panelSidebar.Padding = new Padding(10);

            this.panelSidebar.Controls.Add(this.btnManagePasien);
            this.panelSidebar.Controls.Add(this.btnManageObat);
            this.panelSidebar.Controls.Add(this.btnManageResep);
            this.panelSidebar.Controls.Add(this.btnManageTransaksi);
            this.panelSidebar.Controls.Add(this.btnManageUsers);
            this.panelSidebar.Controls.Add(this.btnLogout);

            // Buttons layout vertical
            int top = 20;
            foreach (var btn in new Button[] { btnManagePasien, btnManageObat, btnManageResep, btnManageTransaksi, btnManageUsers, btnLogout })
            {
                btn.Width = 190;
                btn.Height = 40;
                btn.Left = 15;
                btn.Top = top;
                btn.FlatStyle = FlatStyle.Flat;
                top += 48;
            }

            // 
            // btnManagePasien
            // 
            this.btnManagePasien.Text = "Manage Pasien";
            // 
            // btnManageObat
            // 
            this.btnManageObat.Text = "Manage Obat";
            // 
            // btnManageResep
            // 
            this.btnManageResep.Text = "Manage Resep";
            // 
            // btnManageTransaksi
            // 
            this.btnManageTransaksi.Text = "Manage Transaksi";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Text = "Manage Users";
            // 
            // btnLogout
            // 
            this.btnLogout.Text = "Logout";

            // 
            // panelContainer
            // 
            this.panelContainer.Dock = DockStyle.Fill;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelContainer.Padding = new Padding(12);

            // Add to form
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);

            // event hooks
            this.btnManagePasien.Click += new System.EventHandler(this.btnManagePasien_Click);
            this.btnManageObat.Click += new System.EventHandler(this.btnManageObat_Click);
            this.btnManageResep.Click += new System.EventHandler(this.btnManageResep_Click);
            this.btnManageTransaksi.Click += new System.EventHandler(this.btnManageTransaksi_Click);
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        }
        #endregion
    }
}
