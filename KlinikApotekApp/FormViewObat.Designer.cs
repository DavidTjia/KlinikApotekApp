using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormViewObat
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvObat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelMain = new Panel();
            this.dgvObat = new DataGridView();

            this.Text = "View Obat";
            this.Dock = DockStyle.Fill;

            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(50, 135, 185);
            this.panelHeader.Controls.Add(this.lblTitle);
            lblTitle.Text = "Daftar Obat";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 18);

            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(10);
            this.panelMain.Controls.Add(this.dgvObat);

            this.dgvObat.Dock = DockStyle.Fill;
            this.dgvObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvObat.MultiSelect = false;
            this.dgvObat.ReadOnly = true;

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
        }
    }
}
