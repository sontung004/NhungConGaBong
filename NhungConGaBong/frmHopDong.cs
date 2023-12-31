﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungConGaBong
{
    public partial class frmHopDong : Form
    {
        List<HopDong> hdList = new List<HopDong>();
        List<HopDong> hopdongList = new List<HopDong>();
        List<NhanVien> nvList = new List<NhanVien>();
        List<KhachHang> khList = new List<KhachHang>();
        public int selectedIndex;
        public string MaNhanVien = "";
        public string MaKhachHang = "";
        public string tennv = "";
        public string tenkh = "";
        public frmHopDong()
        {
            InitializeComponent();
            dgvDanhSachHD.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvDanhSachHD.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
            dgvHopDongview.RowsDefaultCellStyle.BackColor = Color.FromArgb(210, 230, 255);
            dgvHopDongview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvNhanVienView.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 200, 220); // Màu hồng nhạt
            dgvNhanVienView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 255, 200); // Màu xanh lá cây nhạt
            dgvKhachHangView.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 230, 200); // Màu cam nhạt
            dgvKhachHangView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 200, 255); // Màu tím nhạt


        }

        public void frmHopDong_Load(object sender, EventArgs e)
        {
            rdbDatNongNghiep.Checked = true;
            cbbNongNghiep.Enabled = true;
            cbbPhiNongNghiep.Enabled = false;
            cbbChuaSuDung.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"FileKhachHang.csv";
            khList = KhachHang.ReadFromFile(fileName);
            //cboKhachHang.DataSource = khList;
            //cboKhachHang.DisplayMember = "MaKH";
            //cboKhachHang.SelectedIndex = 0;
            fileName = path + @"FileNhanVien.csv";
            nvList = NhanVien.ReadFromFile(fileName);
            //cboNhanVien.DataSource = nvList;
            //cboNhanVien.DisplayMember = "MaNV";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            dtpNgayLap.Value = DateTime.Now;



            dgvNhanVienView.AutoGenerateColumns = false;

            // Cấu hình các cột bạn muốn hiển thị
            dgvNhanVienView.Columns.Add("MaNV", "Mã NV");
            dgvNhanVienView.Columns.Add("HoDem", "Họ đệm");
            dgvNhanVienView.Columns.Add("Ten", "Tên");

            // Đặt tập dữ liệu cho DataGridView
            dgvNhanVienView.DataSource = nvList;

            dgvNhanVienView.CellClick += new DataGridViewCellEventHandler(dgvNhanVienView_CellClick);
            dgvKhachHangView.AutoGenerateColumns = false;

            // Thêm cấu hình cột cho DataGridView
            dgvKhachHangView.Columns.Add("MaKH", "Mã KH");
            dgvKhachHangView.Columns.Add("HoDemKH", "Họ đệm");
            dgvKhachHangView.Columns.Add("TenKH", "Tên");
            // ... và các cột khác

            // Gán dữ liệu cho DataGridView
            dgvKhachHangView.DataSource = khList;
            dgvKhachHangView.CellClick += new DataGridViewCellEventHandler(dgvKhachHangView_CellClick);
        }
        void ComBoBoxChonTenHD()
        {
            cboHopDong.Items.Add("Đăng kí quyền sở hữu đất");
            cboHopDong.Items.Add("Chuyển nhượng quyền sử đụng đất");
            cboHopDong.Items.Add("Đấu giá đất");
            cboHopDong.Items.Add("Quyền sửa chữa nhà");
        }
        private string GenerateRandomContractCode()
        {
            Random random = new Random();
            int randomCode = random.Next(1, 100000); // Tạo số ngẫu nhiên từ 1 đến 999.
            return "HD" + randomCode.ToString("0");
        }
        bool KiemTra()
        {
            if (cboHopDong.SelectedIndex <= -1)
            {
                MessageBox.Show("Tên hợp đồng bạn không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHopDong.Focus();
                return false;
            }
            if (txtDienTich.Text == "")
            {
                MessageBox.Show("Hãy nhập diện tích của thữa đất hợp đồng .", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienTich.Focus();
                return false;
            }
            if (txtTriGia.Text == "")
            {
                MessageBox.Show("Hãy nhập trị giá của thửa đất .", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTriGia.Focus();
                return false;
            }
            if (txtSoTo.Text == "")
            {
                DialogResult result = MessageBox.Show("Số Tờ không được để trống. Bạn có muốn tiếp tục mà không điền Số Tờ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    if (result == DialogResult.No)
                    {
                        txtSoTo.Focus();
                        return false;
                    }
                    else
                    {
                    }
            }
            if (txtSoThua.Text == "")
            {
                DialogResult result = MessageBox.Show("Số Thửa không được để trống. Bạn có muốn tiếp tục mà không điền Số Thửa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    if (result == DialogResult.No)
                    {
                        txtSoThua.Focus();
                        return false;
                    }
                    else
                    {
                        txtSoThua.Text = "0";
                    }


            }
            if (rdbDatNongNghiep.Checked == true)
            {
                if (cbbNongNghiep.SelectedIndex < 0)
                {
                    MessageBox.Show(" Loại đất Không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbNongNghiep.Focus();
                    return false;
                }
            }
            else if (rdbDatPhiNpngNghiep.Checked == true)
            {
                if (cbbPhiNongNghiep.SelectedIndex < 0)
                {
                    MessageBox.Show(" Loại đất Không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbPhiNongNghiep.Focus();
                    return false;
                }
            }
            else if (rdbDatNongNghiep.Checked == true)
            {
                if (cbbChuaSuDung.SelectedIndex < 0)
                {
                    MessageBox.Show(" Loại đất Không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbChuaSuDung.Focus();
                    return false;
                }
            }

            return true;// Không có trường nào để trống

        }
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return;
            }
            dgvDanhSachHD.AutoGenerateColumns = false;
            string randomContractCode = GenerateRandomContractCode();
            txtMaHD.Text = randomContractCode;

            string Ma = txtMaHD.Text.Trim().ToUpper();

            HopDong item = hdList.Find(x => x.MaHD.ToUpper().Equals(Ma));
            if (item != null)
            {
                int index = hdList.IndexOf(item);
                MessageBox.Show($"Mã hợp đồng {Ma} đã tồn tại trong List ở vị trí {index}\n   Bạn vui lòng nhập mã hợp đồng khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HopDong hd = new HopDong();


            hd.MaHD = txtMaHD.Text;

            hd.TenHD = cboHopDong.Text;

            if (rdbDatNongNghiep.Checked)
            {
                hd.LoaiDat = cbbNongNghiep.Text;
            }
            else if (rdbDatPhiNpngNghiep.Checked)
            {
                hd.LoaiDat = cbbPhiNongNghiep.Text;
            }
            else if (rdbDatChuaSuDung.Checked)
            {
                hd.LoaiDat = cbbChuaSuDung.Text;
            }

            hd.MaNV = MaNhanVien;
            hd.MaKH = MaKhachHang;
            hd.DienTich = txtDienTich.Text;
            hd.SoTo = Convert.ToInt32(txtSoTo.Text);
            hd.SoThua = Convert.ToInt32(txtSoThua.Text);
            hd.TriGia = Convert.ToInt32(txtTriGia.Text);
            hd.NgayLap = Convert.ToDateTime(dtpNgayLap.Value);

            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            hdList.Add(hd);
            dgvDanhSachHD.DataSource = hdList;
            dgvDanhSachHD.AutoGenerateColumns = true;


            int rowIndex = dgvDanhSachHD.RowCount - 1;
            dgvDanhSachHD.Rows[rowIndex].Selected = true;
        }


        private void rdbDatChuaSuDung_CheckedChanged(object sender, EventArgs e)
        {
            cbbChuaSuDung.Enabled = true;
            cbbNongNghiep.Enabled = false;
            cbbPhiNongNghiep.Enabled = false;
            cbbNongNghiep.SelectedIndex = -1;
            cbbPhiNongNghiep.SelectedIndex = -1;


        }

        private void rdbDatNongNghiep_CheckedChanged(object sender, EventArgs e)
        {
            cbbNongNghiep.Enabled = true;
            cbbChuaSuDung.Enabled = false;
            cbbPhiNongNghiep.Enabled = false;
            cbbChuaSuDung.SelectedIndex = -1;
            cbbPhiNongNghiep.SelectedIndex = -1;

        }
        private void rdbDatPhiNpngNghiep_CheckedChanged(object sender, EventArgs e)
        {
            cbbPhiNongNghiep.Enabled = true;
            cbbChuaSuDung.Enabled = false;
            cbbNongNghiep.Enabled = false;
            cbbChuaSuDung.SelectedIndex = -1;
            cbbNongNghiep.SelectedIndex = -1;

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileHopDong.csv";
            HopDong.SaveToFile(hdList, fileName, true);
            dgvDanhSachHD.AutoGenerateColumns = false;
            hdList.Clear();
            dgvDanhSachHD.DataSource = null;
            dgvDanhSachHD.AutoGenerateColumns = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDanhSachHD.AutoGenerateColumns = false;
            int selectedIndex = dgvDanhSachHD.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); hdList.RemoveAt(selectedIndex);
                if (result == DialogResult.Yes)
                {
                    hdList.RemoveAt(selectedIndex);
                    string _Path = AppDomain.CurrentDomain.BaseDirectory;
                    string fileName = _Path + @"\FileHopDong.csv";
                    HopDong.SaveToFile(hdList, fileName, false);
                    dgvDanhSachHD.DataSource = null;
                    btnXuat.PerformClick();
                    dgvDanhSachHD.DataSource = hdList;
                    //dgvDanhSachHD.AutoGenerateColumns = true;
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn sửa nội dung của hợp đồng {cboHopDong.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) { return; }

            int index = hdList.FindIndex(a => a.MaHD == txtMaHD.Text);
            HopDong hopDong = hdList.FirstOrDefault(hd => hd.MaHD == txtMaHD.Text);
            if (index >= 0)
            {
                hdList[index].MaNV = MaNhanVien;
                hdList[index].MaKH = MaKhachHang;
                dgvDanhSachHD.AutoGenerateColumns = false;
                hdList[index].TenHD = cboHopDong.Text;

                if (rdbDatNongNghiep.Checked == true)
                    hdList[index].LoaiDat = cbbNongNghiep.Text;
                else if (rdbDatPhiNpngNghiep.Checked == true)
                    hdList[index].LoaiDat = cbbPhiNongNghiep.Text;
                else if (rdbDatChuaSuDung.Checked == true)
                    hdList[index].LoaiDat = cbbChuaSuDung.Text;
                hdList[index].DienTich = txtDienTich.Text;
                hdList[index].TriGia = Convert.ToInt32(txtTriGia.Text);
                hdList[index].SoThua = Convert.ToInt32(txtSoThua.Text);
                hdList[index].SoTo = Convert.ToInt32(txtSoTo.Text);
                hdList[index].NgayLap = Convert.ToDateTime(dtpNgayLap.Value);
                dgvDanhSachHD.DataSource = hdList;

                dgvDanhSachHD.Rows[index].Selected = true;

            }
        }
        private void dgvDanhSachHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDanhSachHD.Rows[e.RowIndex];

                txtMaHD.Text = selectedRow.Cells["MaHD"].Value.ToString();
                txtTenNhanVien.Text = tennv;
                txtTenKhachHang.Text = tenkh;

                cboHopDong.Text = selectedRow.Cells["TenHD"].Value.ToString();
                txtDienTich.Text = selectedRow.Cells["DienTich"].Value.ToString();
                txtSoTo.Text = selectedRow.Cells["SoTo"].Value.ToString();
                txtSoThua.Text = selectedRow.Cells["SoThua"].Value.ToString();
                txtTriGia.Text = selectedRow.Cells["TriGia"].Value.ToString();
                dtpNgayLap.Text = selectedRow.Cells["NgayLap"].Value.ToString();


                string loaiDatValue = selectedRow.Cells["LoaiDat"].Value.ToString();

                // Cập nhật giá trị của combobox theo cột "LoaiDat"
                if (cbbNongNghiep.Items.Contains(loaiDatValue))
                {
                    rdbDatNongNghiep.Checked = true;

                    cbbNongNghiep.Text = loaiDatValue;

                }
                else if (cbbPhiNongNghiep.Items.Contains(loaiDatValue))
                {
                    rdbDatPhiNpngNghiep.Checked = true;
                    cbbPhiNongNghiep.Text = loaiDatValue;
                    rdbDatPhiNpngNghiep.Checked = true;
                }
                else if (cbbChuaSuDung.Items.Contains(loaiDatValue))
                {
                    rdbDatChuaSuDung.Checked = true;
                    cbbChuaSuDung.Text = loaiDatValue;

                }
                else
                {
                    MessageBox.Show("Giá trị không khớp với các lựa chọn có sẵn trong combobox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            dgvHopDongview.AutoGenerateColumns = false;
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileHopDong.csv";
            hopdongList = HopDong.ReadFromFile(fileName);

            var results = from hd in hopdongList
                          join nv in nvList on hd.MaNV equals nv.MaNV
                          select new
                          {
                              hd.MaHD,
                              nv.MaNV,
                              nv.HoDem,
                              nv.Ten,
                              hd.TenHD,
                              hd.LoaiDat,
                              hd.DienTich,
                              hd.TriGia,
                              hd.SoTo,
                              hd.SoThua,
                              hd.NgayLap,
                              hd.MaKH
                          } into ind
                          join kh in khList on ind.MaKH equals kh.MaKH
                          select new
                          {
                              ind.MaHD,
                              ind.MaNV,
                              hotennv = ind.HoDem + " " + ind.Ten,
                              ind.MaKH,
                              hotenkh = kh.HoDemKH + " " + kh.TenKH,
                              ind.TenHD,
                              ind.LoaiDat,
                              ind.DienTich,
                              ind.TriGia,
                              ind.SoTo,
                              ind.SoThua,
                              ind.NgayLap
                          };
            dgvHopDongview.DataSource = results.ToList();
            dgvHopDongview.AutoGenerateColumns = true;
        }
        private void SearchAll(string text)
        {
            text = text.ToUpper();
            var results = from hd in hopdongList
                              join nv in nvList on hd.MaNV equals nv.MaNV
                              select new
                              {
                                  hd.MaHD,
                                  nv.MaNV,
                                  nv.HoDem,
                                  nv.Ten,
                                  hd.TenHD,
                                  hd.LoaiDat,
                                  hd.DienTich,
                                  hd.TriGia,
                                  hd.SoTo,
                                  hd.SoThua,
                                  hd.NgayLap,
                                  hd.MaKH
                              } into ind
                              join kh in khList on ind.MaKH equals kh.MaKH
                              where ind.MaNV.ToUpper().Contains(text) || ind.MaHD.ToUpper().Contains(text) || kh.MaKH.ToUpper().Contains(text)||
                                    ind.HoDem.ToUpper().Contains(text)|| ind.Ten.ToUpper().Contains(text) ||
                                    ind.TenHD.ToUpper().Contains(text)||
                                    kh.TenKH.ToUpper().Contains(text) || kh.HoDemKH.ToUpper().Contains(text)    

                              select new
                              {
                                  ind.MaHD,
                                  ind.MaNV,
                                  hotennv = ind.HoDem + " " + ind.Ten,
                                  ind.MaKH,
                                  hotenkh = kh.HoDemKH + " " + kh.TenKH,
                                  ind.TenHD,
                                  ind.LoaiDat,
                                  ind.DienTich,
                                  ind.TriGia,
                                  ind.SoTo,
                                  ind.SoThua,
                                  ind.NgayLap
                              };
            dgvHopDongview.DataSource = results.ToList();

        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            string text = txtNhap.Text.Trim();
            SearchAll(text);
        }



        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            dgvHopDongview.AutoGenerateColumns = false;
            int selectedIndex = dgvHopDongview.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hợp đồng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    hopdongList.RemoveAt(selectedIndex);
                    string _Path = AppDomain.CurrentDomain.BaseDirectory;
                    string fileName = _Path + @"\FileHopDong.csv";
                    HopDong.SaveToFile(hopdongList, fileName, false);
                    dgvHopDongview.DataSource = null;
                    btnXuat.PerformClick();
                    dgvHopDongview.AutoGenerateColumns = true;
                }
            }
        }


        public void dgvNhanVienView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVienView.Rows[e.RowIndex];

                MaNhanVien = row.Cells["mnvName"].Value.ToString();
                txtTenNhanVien.Text = $"{row.Cells["HoDem"].Value} {row.Cells["Ten"].Value}";
                tennv = txtTenNhanVien.Text;
            }
        }

        public void dgvKhachHangView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHangView.Rows[e.RowIndex];

                MaKhachHang = row.Cells["makhachang"].Value.ToString();
                // Lấy thông tin từ cột cụ thể và hiển thị nó trong TextBox
                txtTenKhachHang.Text = $"{row.Cells["HoDemKH"].Value} {row.Cells["TenKH"].Value}";
                tenkh = txtTenKhachHang.Text;
            }
        }

        private void dgvDanhSachHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVienView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }
        private void dgvDanhSachHD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }
        private void dgvKhachHangView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);

        }
        private void dgvHopDongview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }
        private void txtDienTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoThuc(txtDienTich, e);
        }

        private void txtTriGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoNguyen(txtTriGia, e);
        }

        private void txtSoTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoNguyen(txtSoTo, e);
        }

        private void txtSoThua_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoNguyen(txtSoThua, e);
        }
        private void SearchNhanVien(string text)
        {
            text = text.ToUpper();
            var filtered = from nv in nvList
                           where nv.MaNV.ToUpper().Contains(text) || nv.HoDem.ToUpper().Contains(text) || nv.Ten.ToUpper().Contains(text) //|| hd.MaNV.ToUpper().Contains(text) || hd.MaKH.ToUpper().Contains(text)
                           select nv;
            dgvNhanVienView.DataSource = filtered.ToList();

        }
        private void txtTimNhanVien_TextChanged(object sender, EventArgs e)
        {
            string text = txtTimNhanVien.Text.Trim();
            SearchNhanVien(text);
        }
        private void SearchKhachHang
            (string text)
        {
            text = text.ToUpper();
            var filtered = from kh in khList
                           where kh.MaKH.ToUpper().Contains(text) || kh.HoDemKH.ToUpper().Contains(text) || kh.TenKH.ToUpper().Contains(text) //|| hd.MaNV.ToUpper().Contains(text) || hd.MaKH.ToUpper().Contains(text)
                           select kh;
            dgvKhachHangView.DataSource = filtered.ToList();

        }

        private void txtTimKhachHang_TextChanged(object sender, EventArgs e)
        {
            string text = txtTimKhachHang.Text.Trim();
            SearchKhachHang(text);
        }
    }
}
