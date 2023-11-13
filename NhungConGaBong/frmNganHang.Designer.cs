namespace NhungConGaBong
{
    partial class frmNganHang
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
            btnLuuNH = new Button();
            btnThemNH = new Button();
            btnSuaNH = new Button();
            btnXoaNH = new Button();
            btnThemMoiNH = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTenNganHang = new TextBox();
            txtMaNH = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            txtTenGiaoDich = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvNganHang = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            manh = new DataGridViewTextBoxColumn();
            tennh = new DataGridViewTextBoxColumn();
            tengd = new DataGridViewTextBoxColumn();
            ngaylap = new DataGridViewTextBoxColumn();
            ngaysua = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNganHang).BeginInit();
            SuspendLayout();
            // 
            // btnLuuNH
            // 
            btnLuuNH.Location = new Point(415, 62);
            btnLuuNH.Name = "btnLuuNH";
            btnLuuNH.Size = new Size(101, 32);
            btnLuuNH.TabIndex = 13;
            btnLuuNH.Text = "Lưu";
            btnLuuNH.UseVisualStyleBackColor = true;
            btnLuuNH.Click += btnLuuNH_Click;
            // 
            // btnThemNH
            // 
            btnThemNH.Location = new Point(308, 62);
            btnThemNH.Name = "btnThemNH";
            btnThemNH.Size = new Size(101, 32);
            btnThemNH.TabIndex = 14;
            btnThemNH.Text = "Thêm";
            btnThemNH.UseVisualStyleBackColor = true;
            btnThemNH.Click += btnThemNH_Click;
            // 
            // btnSuaNH
            // 
            btnSuaNH.Enabled = false;
            btnSuaNH.Location = new Point(211, 62);
            btnSuaNH.Name = "btnSuaNH";
            btnSuaNH.Size = new Size(91, 32);
            btnSuaNH.TabIndex = 15;
            btnSuaNH.Text = "Sửa";
            btnSuaNH.UseVisualStyleBackColor = true;
            btnSuaNH.Click += btnSuaNH_Click;
            // 
            // btnXoaNH
            // 
            btnXoaNH.Enabled = false;
            btnXoaNH.Location = new Point(114, 62);
            btnXoaNH.Name = "btnXoaNH";
            btnXoaNH.Size = new Size(91, 32);
            btnXoaNH.TabIndex = 16;
            btnXoaNH.Text = "Xoá";
            btnXoaNH.UseVisualStyleBackColor = true;
            btnXoaNH.Click += btnXoaNH_Click;
            // 
            // btnThemMoiNH
            // 
            btnThemMoiNH.Location = new Point(11, 62);
            btnThemMoiNH.Name = "btnThemMoiNH";
            btnThemMoiNH.Size = new Size(91, 32);
            btnThemMoiNH.TabIndex = 17;
            btnThemMoiNH.Text = "Thêm mới";
            btnThemMoiNH.UseVisualStyleBackColor = true;
            btnThemMoiNH.Click += btnThemMoiNH_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 19);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 8;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 19);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 11;
            label2.Text = "Mã";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // txtTenNganHang
            // 
            txtTenNganHang.Location = new Point(211, 16);
            txtTenNganHang.Name = "txtTenNganHang";
            txtTenNganHang.Size = new Size(405, 27);
            txtTenNganHang.TabIndex = 5;
            // 
            // txtMaNH
            // 
            txtMaNH.Location = new Point(114, 16);
            txtMaNH.Name = "txtMaNH";
            txtMaNH.Size = new Size(53, 27);
            txtMaNH.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(41, 14);
            txtID.Name = "txtID";
            txtID.Size = new Size(31, 27);
            txtID.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(623, 19);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 19;
            label4.Text = "Tên giao dịch";
            // 
            // txtTenGiaoDich
            // 
            txtTenGiaoDich.Location = new Point(727, 14);
            txtTenGiaoDich.Name = "txtTenGiaoDich";
            txtTenGiaoDich.Size = new Size(159, 27);
            txtTenGiaoDich.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenNganHang);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtTenGiaoDich);
            panel1.Controls.Add(txtMaNH);
            panel1.Controls.Add(btnLuuNH);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThemNH);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSuaNH);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnXoaNH);
            panel1.Controls.Add(btnThemMoiNH);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 120);
            panel1.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvNganHang, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.3333359F));
            tableLayoutPanel1.Size = new Size(1045, 560);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // dgvNganHang
            // 
            dgvNganHang.AllowUserToAddRows = false;
            dgvNganHang.AllowUserToDeleteRows = false;
            dgvNganHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNganHang.Columns.AddRange(new DataGridViewColumn[] { id, manh, tennh, tengd, ngaylap, ngaysua });
            dgvNganHang.Dock = DockStyle.Fill;
            dgvNganHang.Location = new Point(3, 129);
            dgvNganHang.Name = "dgvNganHang";
            dgvNganHang.ReadOnly = true;
            dgvNganHang.RowHeadersWidth = 51;
            dgvNganHang.RowTemplate.Height = 29;
            dgvNganHang.Size = new Size(1039, 428);
            dgvNganHang.TabIndex = 21;
            dgvNganHang.CellClick += dgvNganHang_CellClick;
            dgvNganHang.RowPostPaint += dgvNganHang_RowPostPaint;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 53;
            // 
            // manh
            // 
            manh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            manh.DataPropertyName = "MaNH";
            manh.HeaderText = "Mã ngân hàng";
            manh.MinimumWidth = 6;
            manh.Name = "manh";
            manh.ReadOnly = true;
            manh.Width = 133;
            // 
            // tennh
            // 
            tennh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tennh.DataPropertyName = "TenNH";
            tennh.HeaderText = "Tên ngân hàng";
            tennh.MinimumWidth = 6;
            tennh.Name = "tennh";
            tennh.ReadOnly = true;
            tennh.Width = 135;
            // 
            // tengd
            // 
            tengd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tengd.DataPropertyName = "TenGD";
            tengd.HeaderText = "Tên giao dịch";
            tengd.MinimumWidth = 6;
            tengd.Name = "tengd";
            tengd.ReadOnly = true;
            tengd.Width = 127;
            // 
            // ngaylap
            // 
            ngaylap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ngaylap.DataPropertyName = "NgayLap";
            ngaylap.HeaderText = "Ngày lập";
            ngaylap.MinimumWidth = 6;
            ngaylap.Name = "ngaylap";
            ngaylap.ReadOnly = true;
            ngaylap.Width = 98;
            // 
            // ngaysua
            // 
            ngaysua.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ngaysua.DataPropertyName = "NgaySua";
            ngaysua.HeaderText = "Ngày sửa";
            ngaysua.MinimumWidth = 6;
            ngaysua.Name = "ngaysua";
            ngaysua.ReadOnly = true;
            // 
            // frmNganHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 560);
            Controls.Add(tableLayoutPanel1);
            Name = "frmNganHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ngân hàng";
            Load += frmNganHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNganHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLuuNH;
        private Button btnThemNH;
        private Button btnSuaNH;
        private Button btnXoaNH;
        private Button btnThemMoiNH;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTenNganHang;
        private TextBox txtMaNH;
        private TextBox txtID;
        private Label label4;
        private TextBox txtTenGiaoDich;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvNganHang;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn manh;
        private DataGridViewTextBoxColumn tennh;
        private DataGridViewTextBoxColumn tengd;
        private DataGridViewTextBoxColumn ngaylap;
        private DataGridViewTextBoxColumn ngaysua;
    }
}