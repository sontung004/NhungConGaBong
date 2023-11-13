using System;
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
        List<NhanVien> nvList = new List<NhanVien>();
        List<KhachHang> khList = new List<KhachHang>();
        public int selectedIndex;
        public frmHopDong()
        {
            InitializeComponent();
            dgvDanhSachHD.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvDanhSachHD.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
            dgvHopDongview.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvHopDongview.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        public void frmHopDong_Load(object sender, EventArgs e)
        {
            ComBoBoxDatNongNghiep();
            ComBoBoxChonTenHD();
            ComBoBoxDatChuaSuDung();
            ComBoBoxDatPhiNongNghiep();
            cbbChuaSuDung.Enabled = false;
            cbbNongNghiep.Enabled = false;
            cbbPhiNongNghiep.Enabled = false;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"FileKhachHang.csv";
            khList = KhachHang.ReadFromFile(fileName);
            cboKhachHang.DataSource = khList;
            cboKhachHang.DisplayMember = "MaKH";
            cboKhachHang.SelectedIndex = 0;
            fileName = path + @"FileNhanVien.csv";
            nvList = NhanVien.ReadFromFile(fileName);
            cboNhanVien.DataSource = nvList;
            cboNhanVien.DisplayMember = "MaNV";

            dtpNgayLap.Value = DateTime.Now;
        }
        void ComBoBoxChonTenHD()
        {
            cboHopDong.Items.Add("Đăng kí quyền sở hữu đất");
            cboHopDong.Items.Add("Chuyển nhượng quyền sử đụng đất");
            cboHopDong.Items.Add("Đấu giá đất");
            cboHopDong.Items.Add("Quyền sửa chữa nhà");
        }
        void ComBoBoxDatNongNghiep()
        {
            cbbNongNghiep.Items.Add("1. Đất chuyên trồng lúa nước");
            cbbNongNghiep.Items.Add("2. Đất trồng lúa nước còn lại");
            cbbNongNghiep.Items.Add("3. Đất lúa nương");
            cbbNongNghiep.Items.Add("4. Đất bằng trồng cây hàng năm khác");
            cbbNongNghiep.Items.Add("5. Đất nương rẫy trồng cây hàng năm khác");
            cbbNongNghiep.Items.Add("6. Đất trồng cây lâu năm");
            cbbNongNghiep.Items.Add("7. Đất rừng sản xuất");
            cbbNongNghiep.Items.Add("8. Đất rừng phòng hộ");
            cbbNongNghiep.Items.Add("9. Đất rừng đặc dụng");
            cbbNongNghiep.Items.Add("10. Đất nuôi trồng thủy sản");
            cbbNongNghiep.Items.Add("11. Đất làm muối");
            cbbNongNghiep.Items.Add("12. Đất nông nghiệp khác");
        }
        void ComBoBoxDatPhiNongNghiep()
        {
            cbbPhiNongNghiep.Items.Add("1. Đất ở tại nông thôn");
            cbbPhiNongNghiep.Items.Add("2.Đất ở tại đô thị");
            cbbPhiNongNghiep.Items.Add("3. Đất xây dựng cơ sở giáo dục và đào tạo");
            cbbPhiNongNghiep.Items.Add("4. Đất xây dựng cơ sở thể dục thể thao");
            cbbPhiNongNghiep.Items.Add("5. Đất xây dựng cơ sở khoa học và công nghệ");
            cbbPhiNongNghiep.Items.Add("6. Đất an ninh");
            cbbPhiNongNghiep.Items.Add("7. Đất khu công nghiệp");
            cbbPhiNongNghiep.Items.Add("8. Đất khu vui chơi, giải trí công cộng");
            cbbPhiNongNghiep.Items.Add("9. Đất chợ");
            cbbPhiNongNghiep.Items.Add("10. Đất công trình năng lượng");
            cbbPhiNongNghiep.Items.Add("11. Đất công trình bưu chính, viễn thông");
            cbbPhiNongNghiep.Items.Add("12. Đất có di tích lịch sử - văn hóa");
            cbbPhiNongNghiep.Items.Add("13. Đất danh lam thắng cảnh");
            cbbPhiNongNghiep.Items.Add("14. Đất cơ sở tôn giáo");
            cbbPhiNongNghiep.Items.Add("15. Đất sông, ngòi, kênh, rạch, suối");
            cbbPhiNongNghiep.Items.Add("16. Đất làm nghĩa trang, nghĩa địa, nhà tang lễ, nhà hỏa táng");
        }
        void ComBoBoxDatChuaSuDung()
        {
            cbbChuaSuDung.Items.Add("1. Đất bằng chưa sử dụng");
            cbbChuaSuDung.Items.Add("2. Đất đồi núi chưa sử dụng");
            cbbChuaSuDung.Items.Add("3. Núi đá không có rừng cây");

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
                DialogResult result = MessageBox.Show("Số ThửaB không được để trống. Bạn có muốn tiếp tục mà không điền Số Thửa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

            hd.MaNV = cboNhanVien.Text;
            hd.MaKH = cboKhachHang.Text;
            hd.DienTich = txtDienTich.Text;
            hd.SoTo = Convert.ToInt32(txtSoTo.Text);
            hd.SoThua = Convert.ToInt32(txtSoThua.Text);
            hd.TriGia = txtTriGia.Text;
            hd.NgayLap = Convert.ToDateTime(dtpNgayLap.Value);

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
                    //dgvDanhSachHD.DataSource = hdList;
                    dgvDanhSachHD.AutoGenerateColumns = true;
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
                dgvDanhSachHD.AutoGenerateColumns = false;
                hdList[index].TenHD = cboHopDong.Text;

                if (rdbDatNongNghiep.Checked == true)
                    hdList[index].LoaiDat = cbbNongNghiep.Text;
                else if (rdbDatPhiNpngNghiep.Checked == true)
                    hdList[index].LoaiDat = cbbPhiNongNghiep.Text;
                else if (rdbDatChuaSuDung.Checked == true)
                    hdList[index].LoaiDat = cbbChuaSuDung.Text;
                hdList[index].DienTich = txtDienTich.Text;
                hdList[index].TriGia = txtTriGia.Text;
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
                cboNhanVien.Text = selectedRow.Cells["MaNV"].Value.ToString();
                cboKhachHang.Text = selectedRow.Cells["MaKH"].Value.ToString();
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
        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboKhachHang.ValueMember = "HoDemKH";
            if (cboKhachHang.SelectedIndex >= 0)
            {
                lblKhachHang.Text = cboKhachHang.SelectedValue.ToString();
                cboKhachHang.ValueMember = "TenKH";
                lblKhachHang.Text += " " + cboKhachHang.SelectedValue.ToString();
            }
            else
                lblKhachHang.Text = "";
        }
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNhanVien.ValueMember = "HoDem";
            if (cboNhanVien.SelectedIndex >= 0)
            {
                lblNhanVien.Text = cboNhanVien.SelectedValue.ToString();
                cboNhanVien.ValueMember = "Ten";
                lblNhanVien.Text += " " + cboNhanVien.SelectedValue.ToString();
            }
            else
                lblNhanVien.Text = "";
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            dgvHopDongview.AutoGenerateColumns = false;
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileHopDong.csv";
            hdList = HopDong.ReadFromFile(fileName);

            dgvHopDongview.DataSource = hdList;
            dgvHopDongview.AutoGenerateColumns = true;
        }
        private void SearchAll(string text)
        {
            text = text.ToUpper();
            var filtered = from hd in hdList
                           where hd.MaHD.ToUpper().Contains(text) //|| hd.MaNV.ToUpper().Contains(text) || hd.MaKH.ToUpper().Contains(text)
                           select hd;
            dgvHopDongview.DataSource = filtered.ToList();

        }
        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            string text = txtNhap.Text.Trim();
            SearchAll(text);
        }

        private void dgvDanhSachHD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            dgvHopDongview.AutoGenerateColumns = false;
            int selectedIndex = dgvHopDongview.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hợp đồng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    hdList.RemoveAt(selectedIndex);
                    string _Path = AppDomain.CurrentDomain.BaseDirectory;
                    string fileName = _Path + @"\FileHopDong.csv";
                    HopDong.SaveToFile(hdList, fileName, false);
                    dgvHopDongview.DataSource = null;
                    btnXuat.PerformClick();
                    dgvHopDongview.AutoGenerateColumns = true;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
