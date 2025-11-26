using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManageResep
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvResep;
        private Panel panelInputs;
        private Label lblPasien;
        private ComboBox cbPasien;
        private Label lblObat;
        private ComboBox cbObat;
        private Label lblDosis;
        private TextBox txtDosis;
        private Label lblAturan;
        private TextBox txtAturan;
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
            this.dgvResep = new DataGridView();
            this.panelInputs = new Panel();
            this.lblPasien = new Label();
            this.cbPasien = new ComboBox();
            this.lblObat = new Label();
            this.cbObat = new ComboBox();
            this.lblDosis = new Label();
            this.txtDosis = new TextBox();
            this.lblAturan = new Label();
            this.txtAturan = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();

            this.Text = "Manage Resep";
            this.Dock = DockStyle.Fill;

            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(55, 110, 180);
            this.panelHeader.Controls.Add(this.lblTitle);
            lblTitle.Text = "Manage Resep";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 18);

            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(10);
            this.panelMain.Controls.Add(this.dgvResep);
            this.panelMain.Controls.Add(this.panelInputs);

            this.dgvResep.Dock = DockStyle.Fill;
            this.dgvResep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResep.MultiSelect = false;
            this.dgvResep.ReadOnly = true;

            this.panelInputs.Width = 380;
            this.panelInputs.Dock = DockStyle.Right;
            this.panelInputs.Padding = new Padding(8);
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;

            this.panelInputs.Controls.AddRange(new Control[] {
                lblPasien, cbPasien, lblObat, cbObat, lblDosis, txtDosis, lblAturan, txtAturan, btnAdd, btnUpdate, btnDelete, btnClear
            });

            int y = 12;
            lblPasien.Text = "Pasien"; lblPasien.Location = new System.Drawing.Point(12, y); lblPasien.AutoSize = true;
            cbPasien.Location = new System.Drawing.Point(12, y + 22); cbPasien.Width = 340; cbPasien.DropDownStyle = ComboBoxStyle.DropDownList;
            y += 60;
            lblObat.Text = "Obat"; lblObat.Location = new System.Drawing.Point(12, y); lblObat.AutoSize = true;
            cbObat.Location = new System.Drawing.Point(12, y + 22); cbObat.Width = 340; cbObat.DropDownStyle = ComboBoxStyle.DropDownList;
            y += 60;
            lblDosis.Text = "Dosis"; lblDosis.Location = new System.Drawing.Point(12, y); lblDosis.AutoSize = true;
            txtDosis.Location = new System.Drawing.Point(12, y + 22); txtDosis.Width = 340;
            y += 60;
            lblAturan.Text = "Aturan Pakai"; lblAturan.Location = new System.Drawing.Point(12, y); lblAturan.AutoSize = true;
            txtAturan.Location = new System.Drawing.Point(12, y + 22); txtAturan.Width = 340;
            y += 60;
            btnAdd.Text = "Tambah"; btnAdd.Location = new System.Drawing.Point(12, y); btnAdd.Width = 160; btnAdd.Height = 36;
            btnUpdate.Text = "Update"; btnUpdate.Location = new System.Drawing.Point(192, y); btnUpdate.Width = 160; btnUpdate.Height = 36;
            btnDelete.Text = "Hapus"; btnDelete.Location = new System.Drawing.Point(12, y + 46); btnDelete.Width = 160; btnDelete.Height = 36;
            btnClear.Text = "Clear"; btnClear.Location = new System.Drawing.Point(192, y + 46); btnClear.Width = 160; btnClear.Height = 36;

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvResep.CellClick += new DataGridViewCellEventHandler(this.dgvResep_CellClick);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
        }
    }
}
