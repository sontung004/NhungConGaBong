namespace NhungConGaBong
{
    partial class frmQLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKH));
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            mnuTrangChu = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuThemKhachHang = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuHopDong = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.36018F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1362, 552);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuTrangChu, mnuKhachHang, mnuNhanVien, mnuHopDong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1362, 39);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTrangChu
            // 
            mnuTrangChu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuTrangChu.Image = (Image)resources.GetObject("mnuTrangChu.Image");
            mnuTrangChu.Name = "mnuTrangChu";
            mnuTrangChu.Size = new Size(140, 35);
            mnuTrangChu.Text = "Trang chủ";
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.DropDownItems.AddRange(new ToolStripItem[] { mnuThemKhachHang, toolStripMenuItem2, toolStripMenuItem3 });
            mnuKhachHang.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuKhachHang.Image = (Image)resources.GetObject("mnuKhachHang.Image");
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(157, 35);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuThemKhachHang
            // 
            mnuThemKhachHang.Name = "mnuThemKhachHang";
            mnuThemKhachHang.Size = new Size(278, 28);
            mnuThemKhachHang.Text = "Thêm khách hàng";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(278, 28);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(278, 28);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuNhanVien.Image = (Image)resources.GetObject("mnuNhanVien.Image");
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(138, 35);
            mnuNhanVien.Text = "Nhân viên";
            // 
            // mnuHopDong
            // 
            mnuHopDong.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mnuHopDong.Image = (Image)resources.GetObject("mnuHopDong.Image");
            mnuHopDong.Name = "mnuHopDong";
            mnuHopDong.Size = new Size(140, 35);
            mnuHopDong.Text = "Hợp Đồng";
            // 
            // frmQLKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 552);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmQLKH";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý khách hàng";
            WindowState = FormWindowState.Maximized;
            Load += frmQLKH_Load;
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTrangChu;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuHopDong;
        private ToolStripMenuItem mnuThemKhachHang;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}