using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManageObat
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvObat;
        private Panel panelInputs;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblStok;
        private TextBox txtStok;
        private Label lblHarga;
        private TextBox txtHarga;
        private Label lblDeskripsi;
        private TextBox txtDeskripsi;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

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
            this.panelInputs = new Panel();
            this.lblNama = new Label();
            this.txtNama = new TextBox();
            this.lblStok = new Label();
            this.txtStok = new TextBox();
            this.lblHarga = new Label();
            this.txtHarga = new TextBox();
            this.lblDeskripsi = new Label();
            this.txtDeskripsi = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();

            this.Text = "Manage Obat";
            this.Dock = DockStyle.Fill;

            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(55, 110, 180);
            this.panelHeader.Controls.Add(this.lblTitle);
            lblTitle.Text = "Manage Obat";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 18);

            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(10);
            this.panelMain.Controls.Add(this.dgvObat);
            this.panelMain.Controls.Add(this.panelInputs);

            this.dgvObat.Dock = DockStyle.Fill;
            this.dgvObat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvObat.MultiSelect = false;
            this.dgvObat.ReadOnly = true;

            this.panelInputs.Width = 360;
            this.panelInputs.Dock = DockStyle.Right;
            this.panelInputs.Padding = new Padding(8);
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;

            this.panelInputs.Controls.AddRange(new Control[] {
                lblNama, txtNama, lblStok, txtStok, lblHarga, txtHarga, lblDeskripsi, txtDeskripsi, btnAdd, btnUpdate, btnDelete, btnClear
            });

            int y = 12;
            lblNama.Text = "Nama Obat"; lblNama.Location = new System.Drawing.Point(12, y); lblNama.AutoSize = true;
            txtNama.Location = new System.Drawing.Point(12, y + 22); txtNama.Width = 320;
            y += 60;
            lblStok.Text = "Stok"; lblStok.Location = new System.Drawing.Point(12, y); lblStok.AutoSize = true;
            txtStok.Location = new System.Drawing.Point(12, y + 22); txtStok.Width = 320;
            y += 60;
            lblHarga.Text = "Harga"; lblHarga.Location = new System.Drawing.Point(12, y); lblHarga.AutoSize = true;
            txtHarga.Location = new System.Drawing.Point(12, y + 22); txtHarga.Width = 320;
            y += 60;
            lblDeskripsi.Text = "Deskripsi"; lblDeskripsi.Location = new System.Drawing.Point(12, y); lblDeskripsi.AutoSize = true;
            txtDeskripsi.Location = new System.Drawing.Point(12, y + 22); txtDeskripsi.Width = 320; txtDeskripsi.Height = 60; txtDeskripsi.Multiline = true;
            y += 100;
            btnAdd.Text = "Tambah"; btnAdd.Location = new System.Drawing.Point(12, y); btnAdd.Width = 150; btnAdd.Height = 36;
            btnUpdate.Text = "Update"; btnUpdate.Location = new System.Drawing.Point(182, y); btnUpdate.Width = 150; btnUpdate.Height = 36;
            btnDelete.Text = "Hapus"; btnDelete.Location = new System.Drawing.Point(12, y + 46); btnDelete.Width = 150; btnDelete.Height = 36;
            btnClear.Text = "Clear"; btnClear.Location = new System.Drawing.Point(182, y + 46); btnClear.Width = 150; btnClear.Height = 36;

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvObat.CellClick += new DataGridViewCellEventHandler(this.dgvObat_CellClick);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
        }
    }
}
