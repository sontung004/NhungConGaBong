namespace NhungConGaBong
{
    partial class FrmNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbpDanhSach = new TabPage();
            label6 = new Label();
            txtFind = new TextBox();
            btnXuat = new Button();
            dgvNhanVienView = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoDemNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            NgaySinhNV = new DataGridViewTextBoxColumn();
            GioiTinhNV = new DataGridViewTextBoxColumn();
            DiaChiNV = new DataGridViewTextBoxColumn();
            SDTnv = new DataGridViewTextBoxColumn();
            tbpAdd = new TabPage();
            panel2 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSaveToFile = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            cboGioiTinh = new ComboBox();
            label1 = new Label();
            txtMaNV = new TextBox();
            txtSDT = new TextBox();
            label2 = new Label();
            label9 = new Label();
            txtHoDem = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTen = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            label5 = new Label();
            txtDiaChi = new TextBox();
            dgvNhanVien = new DataGridView();
            MaNV = new DataGridViewTextBoxColumn();
            HoDem = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            tbcNhanVien = new TabControl();
            tbpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienView).BeginInit();
            tbpAdd.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tbcNhanVien.SuspendLayout();
            SuspendLayout();
            // 
            // tbpDanhSach
            // 
            tbpDanhSach.Controls.Add(label6);
            tbpDanhSach.Controls.Add(txtFind);
            tbpDanhSach.Controls.Add(btnXuat);
            tbpDanhSach.Controls.Add(dgvNhanVienView);
            tbpDanhSach.Location = new Point(4, 29);
            tbpDanhSach.Name = "tbpDanhSach";
            tbpDanhSach.Padding = new Padding(3);
            tbpDanhSach.Size = new Size(1129, 516);
            tbpDanhSach.TabIndex = 1;
            tbpDanhSach.Text = "Danh Sách";
            tbpDanhSach.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 24);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 1;
            label6.Text = "Tìm kiếm:";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(304, 17);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(300, 27);
            txtFind.TabIndex = 14;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // btnXuat
            // 
            btnXuat.FlatAppearance.MouseDownBackColor = Color.Black;
            btnXuat.FlatStyle = FlatStyle.Popup;
            btnXuat.Location = new Point(8, 6);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(126, 48);
            btnXuat.TabIndex = 13;
            btnXuat.Text = "Xuất danh sách\r\n";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // dgvNhanVienView
            // 
            dgvNhanVienView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVienView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoDemNV, TenNV, NgaySinhNV, GioiTinhNV, DiaChiNV, SDTnv });
            dgvNhanVienView.Location = new Point(3, 74);
            dgvNhanVienView.Name = "dgvNhanVienView";
            dgvNhanVienView.RowHeadersWidth = 51;
            dgvNhanVienView.RowTemplate.Height = 29;
            dgvNhanVienView.Size = new Size(992, 393);
            dgvNhanVienView.TabIndex = 12;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNV";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.Width = 125;
            // 
            // HoDemNV
            // 
            HoDemNV.DataPropertyName = "HoDem";
            HoDemNV.HeaderText = "Họ đệm";
            HoDemNV.MinimumWidth = 6;
            HoDemNV.Name = "HoDemNV";
            HoDemNV.Width = 125;
            // 
            // TenNV
            // 
            TenNV.DataPropertyName = "Ten";
            TenNV.HeaderText = "Tên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.Width = 125;
            // 
            // NgaySinhNV
            // 
            NgaySinhNV.DataPropertyName = "NgaySinh";
            NgaySinhNV.HeaderText = "Ngày sinh";
            NgaySinhNV.MinimumWidth = 6;
            NgaySinhNV.Name = "NgaySinhNV";
            NgaySinhNV.Width = 125;
            // 
            // GioiTinhNV
            // 
            GioiTinhNV.DataPropertyName = "GioiTinh";
            GioiTinhNV.HeaderText = "Giới Tính";
            GioiTinhNV.MinimumWidth = 6;
            GioiTinhNV.Name = "GioiTinhNV";
            GioiTinhNV.Width = 125;
            // 
            // DiaChiNV
            // 
            DiaChiNV.DataPropertyName = "DiaChi";
            DiaChiNV.HeaderText = "Địa chỉ";
            DiaChiNV.MinimumWidth = 6;
            DiaChiNV.Name = "DiaChiNV";
            DiaChiNV.Width = 125;
            // 
            // SDTnv
            // 
            SDTnv.DataPropertyName = "SDT";
            SDTnv.HeaderText = "Số điện thoại";
            SDTnv.MinimumWidth = 6;
            SDTnv.Name = "SDTnv";
            SDTnv.Width = 125;
            // 
            // tbpAdd
            // 
            tbpAdd.Controls.Add(panel2);
            tbpAdd.Controls.Add(panel1);
            tbpAdd.Controls.Add(dgvNhanVien);
            tbpAdd.Location = new Point(4, 29);
            tbpAdd.Name = "tbpAdd";
            tbpAdd.Padding = new Padding(3);
            tbpAdd.Size = new Size(1129, 516);
            tbpAdd.TabIndex = 0;
            tbpAdd.Text = "Thêm";
            tbpAdd.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSaveToFile);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(1023, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 152);
            panel2.TabIndex = 16;
            // 
            // btnEdit
            // 
            btnEdit.Enabled = false;
            btnEdit.Location = new Point(3, 75);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(3, 108);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(3, 42);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(94, 29);
            btnSaveToFile.TabIndex = 14;
            btnSaveToFile.Text = "Lưu";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboGioiTinh);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtHoDem);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDiaChi);
            panel1.Location = new Point(9, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 105);
            panel1.TabIndex = 15;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(832, 10);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(151, 28);
            cboGioiTinh.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(117, 9);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(125, 27);
            txtMaNV.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(599, 10);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 8;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 64);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ đệm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(758, 14);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 5;
            label9.Text = "Giới tính:";
            // 
            // txtHoDem
            // 
            txtHoDem.Location = new Point(117, 61);
            txtHoDem.Name = "txtHoDem";
            txtHoDem.Size = new Size(125, 27);
            txtHoDem.TabIndex = 4;
            txtHoDem.KeyPress += txtHoDem_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 12);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 5;
            label8.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 64);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 14);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 5;
            label4.Text = "Số điện thoại:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(328, 61);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(159, 27);
            txtTen.TabIndex = 5;
            txtTen.KeyPress += txtTen_KeyPress;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(331, 9);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(156, 27);
            dtpNgaySinh.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 64);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 2;
            label5.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(599, 64);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(384, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNV, HoDem, Ten, NgaySinh, GioiTinh, DiaChi, SDT });
            dgvNhanVien.Dock = DockStyle.Bottom;
            dgvNhanVien.Location = new Point(3, 164);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(1123, 349);
            dgvNhanVien.TabIndex = 11;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.RowPostPaint += dgvNhanVien_RowPostPaint;
            // 
            // MaNV
            // 
            MaNV.DataPropertyName = "MaNV";
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.Width = 125;
            // 
            // HoDem
            // 
            HoDem.DataPropertyName = "HoDem";
            HoDem.HeaderText = "Họ đệm";
            HoDem.MinimumWidth = 6;
            HoDem.Name = "HoDem";
            HoDem.Width = 125;
            // 
            // Ten
            // 
            Ten.DataPropertyName = "Ten";
            Ten.HeaderText = "Tên";
            Ten.MinimumWidth = 6;
            Ten.Name = "Ten";
            Ten.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 125;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.Width = 125;
            // 
            // tbcNhanVien
            // 
            tbcNhanVien.Controls.Add(tbpAdd);
            tbcNhanVien.Controls.Add(tbpDanhSach);
            tbcNhanVien.Location = new Point(0, 1);
            tbcNhanVien.Name = "tbcNhanVien";
            tbcNhanVien.SelectedIndex = 0;
            tbcNhanVien.Size = new Size(1137, 549);
            tbcNhanVien.TabIndex = 0;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 545);
            Controls.Add(tbcNhanVien);
            Name = "FrmNhanVien";
            Text = "Nhân viên";
            Load += FrmNhanVien_Load;
            tbpDanhSach.ResumeLayout(false);
            tbpDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVienView).EndInit();
            tbpAdd.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tbcNhanVien.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tbpDanhSach;
        private TabPage tbpAdd;
        private Button btnDelete;
        private Button btnSaveToFile;
        private Button btnAdd;
        private Panel panel1;
        private ComboBox cboGioiTinh;
        private Label label1;
        private TextBox txtMaNV;
        private TextBox txtSDT;
        private Label label2;
        private Label label9;
        private TextBox txtHoDem;
        private Label label8;
        private Label label3;
        private Label label4;
        private TextBox txtTen;
        private DateTimePicker dtpNgaySinh;
        private Label label5;
        private TextBox txtDiaChi;
        private DataGridView dgvNhanVien;
        private TabControl tbcNhanVien;
        private Button btnEdit;
        private DataGridView dgvNhanVienView;
        private Button btnXuat;
        private TextBox txtFind;
        private Label label6;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoDemNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn NgaySinhNV;
        private DataGridViewTextBoxColumn GioiTinhNV;
        private DataGridViewTextBoxColumn DiaChiNV;
        private DataGridViewTextBoxColumn SDTnv;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoDem;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SDT;
        private Panel panel2;
    }
}