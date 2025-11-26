using System.Windows.Forms;

namespace KlinikApotekApp
{
    partial class FormManageUsers
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelMain;
        private DataGridView dgvUsers;
        private Panel panelInputs;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblRole;
        private ComboBox cbRole;
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
            this.dgvUsers = new DataGridView();
            this.panelInputs = new Panel();
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblRole = new Label();
            this.cbRole = new ComboBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();

            this.Text = "Manage Users";
            this.Dock = DockStyle.Fill;

            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(55, 110, 180);
            this.panelHeader.Controls.Add(this.lblTitle);
            lblTitle.Text = "Manage Users";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 18);

            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.Padding = new Padding(10);
            this.panelMain.Controls.Add(this.dgvUsers);
            this.panelMain.Controls.Add(this.panelInputs);

            this.dgvUsers.Dock = DockStyle.Fill;
            this.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.ReadOnly = true;

            this.panelInputs.Width = 360;
            this.panelInputs.Dock = DockStyle.Right;
            this.panelInputs.Padding = new Padding(8);
            this.panelInputs.BackColor = System.Drawing.Color.WhiteSmoke;

            this.panelInputs.Controls.AddRange(new Control[] {
                lblUsername, txtUsername, lblPassword, txtPassword, lblRole, cbRole, btnAdd, btnUpdate, btnDelete, btnClear
            });

            int y = 12;
            lblUsername.Text = "Username"; lblUsername.Location = new System.Drawing.Point(12, y); lblUsername.AutoSize = true;
            txtUsername.Location = new System.Drawing.Point(12, y + 22); txtUsername.Width = 320;
            y += 60;
            lblPassword.Text = "Password"; lblPassword.Location = new System.Drawing.Point(12, y); lblPassword.AutoSize = true;
            txtPassword.Location = new System.Drawing.Point(12, y + 22); txtPassword.PasswordChar = '●'; txtPassword.Width = 320;
            y += 60;
            lblRole.Text = "Role"; lblRole.Location = new System.Drawing.Point(12, y); lblRole.AutoSize = true;
            cbRole.Location = new System.Drawing.Point(12, y + 22); cbRole.Width = 320; cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Items.AddRange(new object[] { "Admin", "Apoteker" });
            y += 60;
            btnAdd.Text = "Tambah"; btnAdd.Location = new System.Drawing.Point(12, y); btnAdd.Width = 150; btnAdd.Height = 36;
            btnUpdate.Text = "Update"; btnUpdate.Location = new System.Drawing.Point(182, y); btnUpdate.Width = 150; btnUpdate.Height = 36;
            btnDelete.Text = "Hapus"; btnDelete.Location = new System.Drawing.Point(12, y + 46); btnDelete.Width = 150; btnDelete.Height = 36;
            btnClear.Text = "Clear"; btnClear.Location = new System.Drawing.Point(182, y + 46); btnClear.Width = 150; btnClear.Height = 36;

            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvUsers.CellClick += new DataGridViewCellEventHandler(this.dgvUsers_CellClick);

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
        }
    }
}
