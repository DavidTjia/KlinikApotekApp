using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManagePasien
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvPasien;
        private Panel panelInputs;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblUmur;
        private TextBox txtUmur;
        private Label lblAlamat;
        private TextBox txtAlamat;
        private Label lblNoHP;
        private TextBox txtNoHP;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new Panel();
            this.lblTitle = new Label();
            this.panelMain = new Panel();
            this.dgvPasien = new DataGridView();
            this.panelInputs = new Panel();
            this.lblNama = new Label();
            this.txtNama = new TextBox();
            this.lblUmur = new Label();
            this.txtUmur = new TextBox();
            this.lblAlamat = new Label();
            this.txtAlamat = new TextBox();
            this.lblNoHP = new Label();
            this.txtNoHP = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();

            // Form
            this.Text = "Manage Pasien";
            this.Dock = DockStyle.Fill;

            // Header
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(55, 110, 180);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.lblTitle.Text = "Manage Pasien";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);

            // Main
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(10);
            this.panelMain.Controls.Add(this.dgvPasien);
            this.panelMain.Controls.Add(this.panelInputs);

            // DataGridView
            this.dgvPasien.Dock = DockStyle.Fill;
            this.dgvPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasien.MultiSelect = false;
            this.dgvPasien.ReadOnly = true;
            this.dgvPasien.Height = 300;
            this.dgvPasien.Top = 10;

            // PanelInputs (right)
            this.panelInputs.Width = 360;
            this.panelInputs.Dock = DockStyle.Right;
            this.panelInputs.Padding = new Padding(8);
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInputs.Controls.AddRange(new Control[] {
                lblNama, txtNama, lblUmur, txtUmur, lblAlamat, txtAlamat, lblNoHP, txtNoHP, btnAdd, btnUpdate, btnDelete, btnClear
            });

            // Arrange small controls positions
            int y = 12;
            lblNama.Text = "Nama"; lblNama.Location = new System.Drawing.Point(12, y); lblNama.AutoSize = true;
            txtNama.Location = new System.Drawing.Point(12, y + 22); txtNama.Width = 320;
            y += 60;
            lblUmur.Text = "Umur"; lblUmur.Location = new System.Drawing.Point(12, y); lblUmur.AutoSize = true;
            txtUmur.Location = new System.Drawing.Point(12, y + 22); txtUmur.Width = 320;
            y += 60;
            lblAlamat.Text = "Alamat"; lblAlamat.Location = new System.Drawing.Point(12, y); lblAlamat.AutoSize = true;
            txtAlamat.Location = new System.Drawing.Point(12, y + 22); txtAlamat.Width = 320; txtAlamat.Height = 60; txtAlamat.Multiline = true;
            y += 100;
            lblNoHP.Text = "No HP"; lblNoHP.Location = new System.Drawing.Point(12, y); lblNoHP.AutoSize = true;
            txtNoHP.Location = new System.Drawing.Point(12, y + 22); txtNoHP.Width = 320;
            y += 60;
            btnAdd.Text = "Tambah"; btnAdd.Location = new System.Drawing.Point(12, y); btnAdd.Width = 150; btnAdd.Height = 36;
            btnUpdate.Text = "Update"; btnUpdate.Location = new System.Drawing.Point(182, y); btnUpdate.Width = 150; btnUpdate.Height = 36;
            btnDelete.Text = "Hapus"; btnDelete.Location = new System.Drawing.Point(12, y + 46); btnDelete.Width = 150; btnDelete.Height = 36;
            btnClear.Text = "Clear"; btnClear.Location = new System.Drawing.Point(182, y + 46); btnClear.Width = 150; btnClear.Height = 36;

            // Event hooks
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvPasien.CellClick += new DataGridViewCellEventHandler(this.dgvPasien_CellClick);

            // Add to controls
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
        }
    }
}
