using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormInputTransaksi
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvTransaksi;
        private Panel panelInputs;
        private Label lblPasien;
        private ComboBox cbPasien;
        private Label lblObat;
        private ComboBox cbObat;
        private Label lblJumlah;
        private NumericUpDown nudJumlah;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnHitung;
        private Button btnSave;
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
            this.dgvTransaksi = new DataGridView();
            this.panelInputs = new Panel();
            this.lblPasien = new Label();
            this.cbPasien = new ComboBox();
            this.lblObat = new Label();
            this.cbObat = new ComboBox();
            this.lblJumlah = new Label();
            this.nudJumlah = new NumericUpDown();
            this.lblTotal = new Label();
            this.txtTotal = new TextBox();
            this.btnHitung = new Button();
            this.btnSave = new Button();
            this.btnClear = new Button();

            this.Text = "Input Transaksi";
            this.Dock = DockStyle.Fill;

            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(50, 135, 185);
            this.panelHeader.Controls.Add(this.lblTitle);
            lblTitle.Text = "Input Transaksi";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 18);

            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(10);
            this.panelMain.Controls.Add(this.dgvTransaksi);
            this.panelMain.Controls.Add(this.panelInputs);

            this.dgvTransaksi.Dock = DockStyle.Fill;
            this.dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaksi.MultiSelect = false;
            this.dgvTransaksi.ReadOnly = true;

            this.panelInputs.Width = 380;
            this.panelInputs.Dock = DockStyle.Right;
            this.panelInputs.Padding = new Padding(8);
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;

            this.panelInputs.Controls.AddRange(new Control[] {
                lblPasien, cbPasien, lblObat, cbObat, lblJumlah, nudJumlah, lblTotal, txtTotal, btnHitung, btnSave, btnClear
            });

            int y = 12;
            lblPasien.Text = "Pasien"; lblPasien.Location = new System.Drawing.Point(12, y); lblPasien.AutoSize = true;
            cbPasien.Location = new System.Drawing.Point(12, y + 22); cbPasien.Width = 340; cbPasien.DropDownStyle = ComboBoxStyle.DropDownList;
            y += 60;
            lblObat.Text = "Obat"; lblObat.Location = new System.Drawing.Point(12, y); lblObat.AutoSize = true;
            cbObat.Location = new System.Drawing.Point(12, y + 22); cbObat.Width = 340; cbObat.DropDownStyle = ComboBoxStyle.DropDownList;
            y += 60;
            lblJumlah.Text = "Jumlah"; lblJumlah.Location = new System.Drawing.Point(12, y); lblJumlah.AutoSize = true;
            nudJumlah.Location = new System.Drawing.Point(12, y + 22); nudJumlah.Width = 120; nudJumlah.Minimum = 1; nudJumlah.Maximum = 1000;
            y += 60;
            lblTotal.Text = "Total"; lblTotal.Location = new System.Drawing.Point(12, y); lblTotal.AutoSize = true;
            txtTotal.Location = new System.Drawing.Point(12, y + 22); txtTotal.Width = 200; txtTotal.ReadOnly = true;
            y += 60;
            btnHitung.Text = "Hitung"; btnHitung.Location = new System.Drawing.Point(12, y); btnHitung.Width = 100; btnHitung.Height = 36;
            btnSave.Text = "Simpan Transaksi"; btnSave.Location = new System.Drawing.Point(122, y); btnSave.Width = 150; btnSave.Height = 36;
            btnClear.Text = "Clear"; btnClear.Location = new System.Drawing.Point(282, y); btnClear.Width = 70; btnClear.Height = 36;

            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
        }
    }
}
