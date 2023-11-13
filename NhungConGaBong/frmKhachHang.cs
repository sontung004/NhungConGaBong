using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NhungConGaBong
{
    public partial class frmKhachHang : Form
    {
        List<KhachHang> khachhangList = new List<KhachHang>();
        List<KhachHang> khList = new List<KhachHang>();
        List<NganHang> nganhangList = new List<NganHang>();
        int maxMakh;
        public frmKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
            dgvXuatKH.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvXuatKH.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNganHang.csv";
            nganhangList = NganHang.ReadFromFile(fileName);
            cboNH.DataSource = nganhangList;
            cboNH.DisplayMember = "TenGD";
            cboNH.ValueMember = "ID";
            cboNH.SelectedIndex = -1;

            fileName = path + @"\FileKhachHang.csv";
            khachhangList = KhachHang.ReadFromFile(fileName);

            khList.Clear();
            gpbThongTin.Hide();
            maxMakh = khachhangList.Max(kh => int.Parse(kh.MaKH.Substring(2)));
            txtMaKH.Text = "KH" + (maxMakh + 1).ToString("D2");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;

            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.HoDemKH = txtHoDem.Text;
            kh.TenKH = txtTen.Text;
            kh.DienThoai = txtSDT.Text;
            kh.Email = txtEmail.Text;
            kh.MaSoThue = txtMaSoThue.Text;
            kh.STK = txtSoTK.Text;
            kh.NgayLap = DateTime.Now.Date;
            kh.NganHangID = Convert.ToInt32(cboNH.SelectedValue);
            khList.Add(kh);

            maxMakh++;
            txtMaKH.Text = "KH" + (maxMakh + 1).ToString("D2");

            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = khList;
            dgvKhachHang.AutoGenerateColumns = true;

            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileKhachHang.csv";
            KhachHang.SaveToFile(khList, fileName, true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            string maKH = txtMaKH.Text;
            string hoDem = txtHoDem.Text;
            string tenKH = txtTen.Text;
            string Dienthoai = txtSDT.Text;
            string email = txtEmail.Text;
            string masothue = txtMaSoThue.Text;
            string stk = txtSoTK.Text;
            int nganHangID = Convert.ToInt32(cboNH.SelectedValue);

            KhachHang khachHang = khList.FirstOrDefault(kh => kh.MaKH == maKH);

            if (khachHang != null)
            {
                khachHang.HoDemKH = hoDem;
                khachHang.TenKH = tenKH;
                khachHang.DienThoai = Dienthoai;
                khachHang.Email = email;
                khachHang.MaSoThue = masothue;
                khachHang.STK = stk;
                khachHang.NganHangID = nganHangID;
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = khList;
                dgvKhachHang.AutoGenerateColumns = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = false;
            int selectedIndex = dgvKhachHang.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    khList.RemoveAt(selectedIndex);
                    dgvKhachHang.DataSource = null;
                    dgvKhachHang.DataSource = khList;
                    dgvKhachHang.AutoGenerateColumns = true;
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                btnHienSua.Enabled = true;
                btnXoa.Enabled = true;
                DataGridViewRow selectedRow = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = selectedRow.Cells["MaKH"].Value.ToString()!;
                txtHoDem.Text = selectedRow.Cells["HoDem"].Value.ToString();
                txtTen.Text = selectedRow.Cells["tenKH"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["Dienthoai"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtMaSoThue.Text = selectedRow.Cells["MaSoThue"].Value.ToString();
                txtSoTK.Text = selectedRow.Cells["stk"].Value.ToString();
                cboNH.SelectedValue = Convert.ToInt32(selectedRow.Cells["NganHangID"].Value);
            }
        }

        private void FilterStudentLinQ2(string text)
        {
            text = text.ToUpper();
            var results = from s in khachhangList
                          join ng in nganhangList on s.NganHangID equals ng.ID
                          where s.HoDemKH.ToUpper().Contains(text) || s.TenKH.ToUpper().Contains(text) || s.MaKH.Contains(text) || ng.TenNH.Contains(text)
                          select new { s.MaKH, s.HoDemKH, s.TenKH, s.DienThoai, s.Email, s.MaSoThue, s.STK, Nghang = ng.TenNH };
            dgvXuatKH.DataSource = results.ToList();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string text = txtTim.Text.Trim();
            FilterStudentLinQ2(text);
        }

        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileKhachHang.csv";
            khachhangList = KhachHang.ReadFromFile(fileName);
            var results = khachhangList.Join(nganhangList, sv => sv.NganHangID, ng => ng.ID,
                    (st, ind) =>
                    {
                        string Nghang = ind.TenNH;
                        return new { st.MaKH, st.HoDemKH, st.TenKH, st.DienThoai, st.Email, st.MaSoThue, st.STK, Nghang, st.NgayLap };
                    });
            dgvXuatKH.DataSource = results.ToList();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            btnSua.Hide();
            btnThem.Hide();
            gpbThongTin.Hide();
        }

        private void btnHienThem_Click(object sender, EventArgs e)
        {
            gpbThongTin.Visible = true;
            btnSua.Hide();
            btnThem.Visible = true;
        }

        private void btnHienSua_Click(object sender, EventArgs e)
        {
            gpbThongTin.Visible = true;
            btnThem.Hide();
            btnSua.Visible = true;
        }

        private void dgvKhachHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            dgvXuatKH.AutoGenerateColumns = false;
            int selectedIndex = dgvXuatKH.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    khachhangList.RemoveAt(selectedIndex);
                    string _Path = AppDomain.CurrentDomain.BaseDirectory;
                    string fileName = _Path + @"\FileKhachHang.csv";
                    KhachHang.SaveToFile(khachhangList, fileName, false);
                    dgvXuatKH.DataSource = null;
                    btnXuatDS.PerformClick();
                    dgvXuatKH.AutoGenerateColumns = true;
                }
            }
        }

        private void btnThemNH_Click(object sender, EventArgs e)
        {
            var frm = new frmNganHang();
            frm.ShowDialog();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNganHang.csv";
            nganhangList = NganHang.ReadFromFile(fileName);
            cboNH.DataSource = nganhangList;
            cboNH.DisplayMember = "TenGD";
            cboNH.ValueMember = "ID";
            cboNH.SelectedIndex = -1;
            gpbThongTin.Visible = true;
        }
    }
}
