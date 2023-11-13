namespace NhungConGaBong
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            tbcKhachHang = new TabControl();
            tbpThemKH = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            dgvKhachHang = new DataGridView();
            makh = new DataGridViewTextBoxColumn();
            hodem = new DataGridViewTextBoxColumn();
            tenKH = new DataGridViewTextBoxColumn();
            Dienthoai = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            masothue = new DataGridViewTextBoxColumn();
            stk = new DataGridViewTextBoxColumn();
            nganhangid = new DataGridViewTextBoxColumn();
            gpbThongTin = new GroupBox();
            btnDong = new Button();
            panel2 = new Panel();
            txtHoDem = new TextBox();
            label1 = new Label();
            txtMaKH = new TextBox();
            label8 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            label4 = new Label();
            btnSua = new Button();
            panel1 = new Panel();
            btnThemNH = new Button();
            txtSoTK = new TextBox();
            cboNH = new ComboBox();
            label3 = new Label();
            txtMaSoThue = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnThem = new Button();
            panel3 = new Panel();
            btnHienSua = new Button();
            btnHienThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            tbpDanhSachKH = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvXuatKH = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            nh = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnXoaDS = new Button();
            btnXuatDS = new Button();
            label9 = new Label();
            txtTim = new TextBox();
            tbcKhachHang.SuspendLayout();
            tbpThemKH.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            gpbThongTin.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tbpDanhSachKH.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXuatKH).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tbcKhachHang
            // 
            tbcKhachHang.Controls.Add(tbpThemKH);
            tbcKhachHang.Controls.Add(tbpDanhSachKH);
            tbcKhachHang.Dock = DockStyle.Fill;
            tbcKhachHang.Location = new Point(0, 0);
            tbcKhachHang.Name = "tbcKhachHang";
            tbcKhachHang.SelectedIndex = 0;
            tbcKhachHang.Size = new Size(1452, 659);
            tbcKhachHang.TabIndex = 0;
            // 
            // tbpThemKH
            // 
            tbpThemKH.CausesValidation = false;
            tbpThemKH.Controls.Add(tableLayoutPanel1);
            tbpThemKH.Location = new Point(4, 29);
            tbpThemKH.Name = "tbpThemKH";
            tbpThemKH.Padding = new Padding(3);
            tbpThemKH.Size = new Size(1444, 626);
            tbpThemKH.TabIndex = 0;
            tbpThemKH.Text = "Thêm";
            tbpThemKH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1438, 620);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvKhachHang);
            panel5.Controls.Add(gpbThongTin);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(1432, 557);
            panel5.TabIndex = 0;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { makh, hodem, tenKH, Dienthoai, email, masothue, stk, nganhangid });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(396, 0);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new Size(1036, 557);
            dgvKhachHang.TabIndex = 20;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            dgvKhachHang.RowPostPaint += dgvKhachHang_RowPostPaint;
            // 
            // makh
            // 
            makh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            makh.DataPropertyName = "MaKH";
            makh.HeaderText = "Mã khách hàng";
            makh.MinimumWidth = 6;
            makh.Name = "makh";
            makh.ReadOnly = true;
            makh.Width = 138;
            // 
            // hodem
            // 
            hodem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            hodem.DataPropertyName = "HoDemKH";
            hodem.HeaderText = "Họ khách hàng";
            hodem.MinimumWidth = 6;
            hodem.Name = "hodem";
            hodem.ReadOnly = true;
            hodem.Width = 137;
            // 
            // tenKH
            // 
            tenKH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tenKH.DataPropertyName = "TenKH";
            tenKH.HeaderText = "Tên khách hàng";
            tenKH.MinimumWidth = 6;
            tenKH.Name = "tenKH";
            tenKH.ReadOnly = true;
            tenKH.Width = 140;
            // 
            // Dienthoai
            // 
            Dienthoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Dienthoai.DataPropertyName = "DienThoai";
            Dienthoai.HeaderText = "Số điện thoại";
            Dienthoai.MinimumWidth = 6;
            Dienthoai.Name = "Dienthoai";
            Dienthoai.ReadOnly = true;
            Dienthoai.Width = 126;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 75;
            // 
            // masothue
            // 
            masothue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            masothue.DataPropertyName = "MaSoThue";
            masothue.HeaderText = "Mã số thuế";
            masothue.MinimumWidth = 6;
            masothue.Name = "masothue";
            masothue.ReadOnly = true;
            masothue.Width = 111;
            // 
            // stk
            // 
            stk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stk.DataPropertyName = "STK";
            stk.HeaderText = "Số tài khoản";
            stk.MinimumWidth = 6;
            stk.Name = "stk";
            stk.ReadOnly = true;
            stk.Width = 120;
            // 
            // nganhangid
            // 
            nganhangid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nganhangid.DataPropertyName = "NganHangID";
            nganhangid.HeaderText = "Ngân hàng ID";
            nganhangid.MinimumWidth = 6;
            nganhangid.Name = "nganhangid";
            nganhangid.ReadOnly = true;
            nganhangid.Width = 130;
            // 
            // gpbThongTin
            // 
            gpbThongTin.BackColor = Color.DarkGray;
            gpbThongTin.Controls.Add(btnDong);
            gpbThongTin.Controls.Add(panel2);
            gpbThongTin.Controls.Add(btnSua);
            gpbThongTin.Controls.Add(panel1);
            gpbThongTin.Controls.Add(btnThem);
            gpbThongTin.Dock = DockStyle.Left;
            gpbThongTin.Location = new Point(0, 0);
            gpbThongTin.Name = "gpbThongTin";
            gpbThongTin.Size = new Size(396, 557);
            gpbThongTin.TabIndex = 24;
            gpbThongTin.TabStop = false;
            gpbThongTin.Text = "Thông tin";
            gpbThongTin.UseCompatibleTextRendering = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(200, 339);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(184, 29);
            btnDong.TabIndex = 1;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtHoDem);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtMaKH);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTen);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(11, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 147);
            panel2.TabIndex = 22;
            // 
            // txtHoDem
            // 
            txtHoDem.Location = new Point(125, 40);
            txtHoDem.Name = "txtHoDem";
            txtHoDem.Size = new Size(238, 27);
            txtHoDem.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(125, 7);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(238, 27);
            txtMaKH.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 43);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 13;
            label8.Text = "Họ khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 76);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(125, 73);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(238, 27);
            txtTen.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(125, 106);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(238, 27);
            txtSDT.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 109);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại";
            // 
            // btnSua
            // 
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(11, 339);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(183, 29);
            btnSua.TabIndex = 0;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThemNH);
            panel1.Controls.Add(txtSoTK);
            panel1.Controls.Add(cboNH);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaSoThue);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(11, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 146);
            panel1.TabIndex = 21;
            // 
            // btnThemNH
            // 
            btnThemNH.Image = (Image)resources.GetObject("btnThemNH.Image");
            btnThemNH.Location = new Point(322, 105);
            btnThemNH.Name = "btnThemNH";
            btnThemNH.Size = new Size(41, 29);
            btnThemNH.TabIndex = 11;
            btnThemNH.UseVisualStyleBackColor = true;
            btnThemNH.Click += btnThemNH_Click;
            // 
            // txtSoTK
            // 
            txtSoTK.Location = new Point(125, 72);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new Size(238, 27);
            txtSoTK.TabIndex = 2;
            // 
            // cboNH
            // 
            cboNH.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNH.FormattingEnabled = true;
            cboNH.Location = new Point(125, 105);
            cboNH.Name = "cboNH";
            cboNH.Size = new Size(191, 28);
            cboNH.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 42);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã số thuế";
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.Location = new Point(125, 39);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(238, 27);
            txtMaSoThue.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 9);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 27);
            txtEmail.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 108);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 10;
            label7.Text = "Tên ngân hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 75);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 8;
            label6.Text = "Số tài khoản";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 339);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(182, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Lưu";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHienSua);
            panel3.Controls.Add(btnHienThem);
            panel3.Controls.Add(btnLuu);
            panel3.Controls.Add(btnXoa);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 47);
            panel3.TabIndex = 23;
            // 
            // btnHienSua
            // 
            btnHienSua.Enabled = false;
            btnHienSua.Image = (Image)resources.GetObject("btnHienSua.Image");
            btnHienSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnHienSua.Location = new Point(101, 5);
            btnHienSua.Name = "btnHienSua";
            btnHienSua.Size = new Size(94, 29);
            btnHienSua.TabIndex = 1;
            btnHienSua.Text = "Sửa";
            btnHienSua.UseVisualStyleBackColor = true;
            btnHienSua.Click += btnHienSua_Click;
            // 
            // btnHienThem
            // 
            btnHienThem.Image = (Image)resources.GetObject("btnHienThem.Image");
            btnHienThem.ImageAlign = ContentAlignment.BottomLeft;
            btnHienThem.Location = new Point(0, 5);
            btnHienThem.Name = "btnHienThem";
            btnHienThem.Size = new Size(94, 29);
            btnHienThem.TabIndex = 0;
            btnHienThem.Text = "Thêm";
            btnHienThem.UseVisualStyleBackColor = true;
            btnHienThem.Click += btnHienThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Enabled = false;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(302, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Enabled = false;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(202, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // tbpDanhSachKH
            // 
            tbpDanhSachKH.Controls.Add(tableLayoutPanel2);
            tbpDanhSachKH.Location = new Point(4, 29);
            tbpDanhSachKH.Name = "tbpDanhSachKH";
            tbpDanhSachKH.Padding = new Padding(3);
            tbpDanhSachKH.Size = new Size(1444, 626);
            tbpDanhSachKH.TabIndex = 1;
            tbpDanhSachKH.Text = "Danh Sách";
            tbpDanhSachKH.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(dgvXuatKH, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.598372F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 92.40163F));
            tableLayoutPanel2.Size = new Size(1438, 620);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // dgvXuatKH
            // 
            dgvXuatKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXuatKH.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, nh });
            dgvXuatKH.Dock = DockStyle.Fill;
            dgvXuatKH.Location = new Point(3, 50);
            dgvXuatKH.Name = "dgvXuatKH";
            dgvXuatKH.RowHeadersWidth = 51;
            dgvXuatKH.RowTemplate.Height = 29;
            dgvXuatKH.Size = new Size(1432, 567);
            dgvXuatKH.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            dataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 138;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.DataPropertyName = "HoDemKH";
            dataGridViewTextBoxColumn2.HeaderText = "Họ khách hàng";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 137;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn3.DataPropertyName = "TenKH";
            dataGridViewTextBoxColumn3.HeaderText = "Tên khách hàng";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.DataPropertyName = "DienThoai";
            dataGridViewTextBoxColumn4.HeaderText = "Số điện thoại";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 126;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.DataPropertyName = "MaSoThue";
            dataGridViewTextBoxColumn6.HeaderText = "Mã số thuế";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 111;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn7.DataPropertyName = "STK";
            dataGridViewTextBoxColumn7.HeaderText = "Số tài khoản";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 120;
            // 
            // nh
            // 
            nh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nh.DataPropertyName = "nghang";
            nh.HeaderText = "Ngân hàng";
            nh.MinimumWidth = 6;
            nh.Name = "nh";
            nh.Width = 111;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnXoaDS);
            panel4.Controls.Add(btnXuatDS);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtTim);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1432, 41);
            panel4.TabIndex = 25;
            // 
            // btnXoaDS
            // 
            btnXoaDS.Location = new Point(1324, 8);
            btnXoaDS.Name = "btnXoaDS";
            btnXoaDS.Size = new Size(94, 29);
            btnXoaDS.TabIndex = 25;
            btnXoaDS.Text = "Xoá";
            btnXoaDS.UseVisualStyleBackColor = true;
            btnXoaDS.Click += btnXoaDS_Click;
            // 
            // btnXuatDS
            // 
            btnXuatDS.Location = new Point(3, 13);
            btnXuatDS.Name = "btnXuatDS";
            btnXuatDS.Size = new Size(142, 29);
            btnXuatDS.TabIndex = 22;
            btnXuatDS.Text = "Xuất danh sách";
            btnXuatDS.UseVisualStyleBackColor = true;
            btnXuatDS.Click += btnXuatDS_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 17);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 23;
            label9.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            txtTim.Location = new Point(249, 13);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(264, 27);
            txtTim.TabIndex = 24;
            txtTim.TextChanged += txtTim_TextChanged;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 659);
            Controls.Add(tbcKhachHang);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            Load += frmKhachHang_Load;
            tbcKhachHang.ResumeLayout(false);
            tbpThemKH.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            gpbThongTin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            tbpDanhSachKH.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvXuatKH).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcKhachHang;
        private TabPage tbpThemKH;
        private TabPage tbpDanhSachKH;
        private Panel panel3;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private TextBox txtHoDem;
        private Label label1;
        private TextBox txtMaKH;
        private Label label8;
        private Label label2;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Label label4;
        private Panel panel1;
        private TextBox txtSoTK;
        private ComboBox cboNH;
        private Label label3;
        private TextBox txtMaSoThue;
        private Label label5;
        private TextBox txtEmail;
        private Label label7;
        private Label label6;
        private DataGridView dgvKhachHang;
        private Button btnLuu;
        private DataGridView dgvXuatKH;
        private Panel panel4;
        private Button btnXuatDS;
        private Label label9;
        private TextBox txtTim;
        private Button btnDong;
        private Button btnHienThem;
        private Button btnHienSua;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gpbThongTin;
        private DataGridViewTextBoxColumn makh;
        private DataGridViewTextBoxColumn hodem;
        private DataGridViewTextBoxColumn tenKH;
        private DataGridViewTextBoxColumn Dienthoai;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn masothue;
        private DataGridViewTextBoxColumn stk;
        private DataGridViewTextBoxColumn nganhangid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn nh;
        private Button btnXoaDS;
        private Button btnThemNH;
    }
}