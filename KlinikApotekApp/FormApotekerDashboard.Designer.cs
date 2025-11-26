using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormApotekerDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSidebar;
        private Button btnViewObat;
        private Button btnInputTransaksi;
        private Button btnViewResep;
        private Button btnLogout;
        private Panel panelContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new Panel();
            this.lblHeader = new Label();
            this.panelSidebar = new Panel();
            this.btnViewObat = new Button();
            this.btnInputTransaksi = new Button();
            this.btnViewResep = new Button();
            this.btnLogout = new Button();
            this.panelContainer = new Panel();

            this.Text = "Apoteker Dashboard - Klinik Apotek";
            this.WindowState = FormWindowState.Maximized;

            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(50, 135, 185);
            this.panelHeader.Controls.Add(this.lblHeader);

            this.lblHeader.Text = "Dashboard Apoteker";
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(16, 20);

            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.Width = 200;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            this.panelSidebar.Padding = new Padding(10);
            this.panelSidebar.Controls.Add(this.btnViewObat);
            this.panelSidebar.Controls.Add(this.btnInputTransaksi);
            this.panelSidebar.Controls.Add(this.btnViewResep);
            this.panelSidebar.Controls.Add(this.btnLogout);

            int top = 20;
            foreach (var btn in new Button[] { btnViewObat, btnInputTransaksi, btnViewResep, btnLogout })
            {
                btn.Width = 170;
                btn.Height = 40;
                btn.Left = 12;
                btn.Top = top;
                btn.FlatStyle = FlatStyle.Flat;
                top += 48;
            }

            this.btnViewObat.Text = "View Obat";
            this.btnInputTransaksi.Text = "Input Transaksi";
            this.btnViewResep.Text = "View Resep";
            this.btnLogout.Text = "Logout";

            this.panelContainer.Dock = DockStyle.Fill;
            this.panelContainer.Padding = new Padding(12);
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);

            this.btnViewObat.Click += new System.EventHandler(this.btnViewObat_Click);
            this.btnInputTransaksi.Click += new System.EventHandler(this.btnInputTransaksi_Click);
            this.btnViewResep.Click += new System.EventHandler(this.btnViewResep_Click);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        }
    }
}
