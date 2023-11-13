using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NhungConGaBong
{
    public partial class FrmNhanVien : Form
    {
        List<NhanVien> nvList = new List<NhanVien>();
        //List<NhanVien> nhanVienList = new List<NhanVien>();
        int rowIndex = -1;
        int index;
        public FrmNhanVien()
        {
            InitializeComponent();
            ////http://www.flounder.com/csharp_color_table.htm
            // MÀU NỀN CÁCH DÒNG  .
            dgvNhanVien.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
            dgvNhanVienView.AutoGenerateColumns = false;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNhanVien.csv";
            nvList = NhanVien.ReadFromFile(fileName);

            dtpNgaySinh.Value = DateTime.Now;

            //Tim va hien thi ma nv moi truoc khi nhap
            string maxMaNV = nvList.Select(nv => nv.MaNV)
                         .Where(maNV => maNV.StartsWith("NV"))
                         .OrderByDescending(maNV => maNV)
                         .FirstOrDefault();
            if (maxMaNV != null)
            {
                int currentNumber = int.Parse(maxMaNV.Substring(2));
                string newMaNV = "NV" + (currentNumber + 1).ToString("D2");
                txtMaNV.Text = newMaNV;
            }

        }
        public bool KiemTra()
        {
            if (txtHoDem.Text == "")
            {
                MessageBox.Show("Họ đệm không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoDem.Focus();
                return false;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Tên không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (cboGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Giới tính không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGioiTinh.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // Thêm các kiểm tra cho các trường thông tin khác nếu cần

            return true; // Không có trường nào để trống
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!KiemTra())
            {
                return; // Không thực hiện thêm nếu có trường thông tin trống
            }
            dgvNhanVien.AutoGenerateColumns = false;
            NhanVien nv = new NhanVien();

            string newMaNV = txtMaNV.Text;

            nv.MaNV = newMaNV;
            nv.HoDem = txtHoDem.Text.Trim();
            nv.Ten = txtTen.Text;
            nv.NgaySinh = DateTime.Now.Date;
            nv.GioiTinh = cboGioiTinh.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;

            nvList.Add(nv);

            //hien thi ma nhan vien tiep theo
            int currentNumber = int.Parse(newMaNV.Substring(2));
            string nextMaNV = "NV" + (currentNumber + 1).ToString("D2");
            txtMaNV.Text = nextMaNV;

            dgvNhanVien.DataSource = nvList;
            dgvNhanVien.AutoGenerateColumns = true;

            int rowIndex = dgvNhanVien.RowCount - 1;
            dgvNhanVien.Rows[rowIndex].Selected = true;
        }

        private void btnSaveToFile_Click_1(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileNhanVien.csv";
            List<NhanVien> existingData = NhanVien.ReadFromFile(fileName);
            foreach (var nv in existingData)
            {
                if (!nvList.Any(item => item.MaNV == nv.MaNV))
                {
                    nvList.Add(nv);
                }
            }
            var newData = existingData.Where(nv => !nvList.Any(item => item.MaNV == nv.MaNV)).ToList();
            nvList.AddRange(newData);

            NhanVien.SaveToFile(nvList, fileName, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn muốn xoá nhân viên {txtTen.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Tìm Index - Vị trí của ID trong List
            int index = nvList.FindIndex(a => a.MaNV == txtMaNV.Text);
            if (index >= 0)
            {
                dgvNhanVien.AutoGenerateColumns = false;

                nvList.RemoveAt(index);

                dgvNhanVien.DataSource = nvList;
                dgvNhanVien.AutoGenerateColumns = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn muốn sửa nội dung của nhân viên {txtMaNV.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            int index = nvList.FindIndex(a => a.MaNV == txtMaNV.Text);
            if (index >= 0)
            {
                dgvNhanVien.AutoGenerateColumns = false;

                nvList[index].HoDem = txtHoDem.Text;
                nvList[index].Ten = txtTen.Text;

                DateTime newNgaySinh;
                if (DateTime.TryParse(dtpNgaySinh.Text, out newNgaySinh))
                {
                    nvList[index].NgaySinh = newNgaySinh;
                }
                nvList[index].GioiTinh = cboGioiTinh.Text;
                nvList[index].DiaChi = txtDiaChi.Text;
                nvList[index].SDT = txtSDT.Text;

                dgvNhanVien.DataSource = nvList;

                dgvNhanVien.AutoGenerateColumns = true;
                dgvNhanVien.Rows[index].Selected = true;
            }
        }



        private void btnXuat_Click(object sender, EventArgs e)
        {
            string _Path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = _Path + @"\FileNhanVien.csv";
            List<NhanVien> nhanVienList = NhanVien.ReadFromFile(fileName);

            //dgvNhanVienView.AutoGenerateColumns = false;
            //dgvNhanVienView.DataSource = nhanVienList;
            //dgvNhanVienView.Columns["Mã nhân viên"].DataPropertyName = "MaNV";
            //dgvNhanVienView.Columns["H? ??m"].DataPropertyName = "HoDem";
            //dgvNhanVienView.Columns["Tên"].DataPropertyName = "Ten";
            //dgvNhanVienView.Columns["Ngày sinh"].DataPropertyName = "NgaySinh";
            //dgvNhanVienView.Columns["Gi?i tính"].DataPropertyName = "GioiTinh";
            //dgvNhanVienView.Columns["??a ch?"].DataPropertyName = "DiaChi";
            //dgvNhanVienView.Columns["S? ?i?n tho?i"].DataPropertyName = "SDT";
            dgvNhanVienView.DataSource = nhanVienList;
            dgvNhanVienView.Columns["MaNhanVien"].DataPropertyName = "MaNV";
            dgvNhanVienView.Columns["HoDemNV"].DataPropertyName = "HoDem";
            dgvNhanVienView.Columns["TenNV"].DataPropertyName = "Ten";
            dgvNhanVienView.Columns["NgaySinhNV"].DataPropertyName = "NgaySinh";
            dgvNhanVienView.Columns["GioiTinhNV"].DataPropertyName = "GioiTinh";
            dgvNhanVienView.Columns["DiaChiNV"].DataPropertyName = "DiaChi";
            dgvNhanVienView.Columns["SDTnv"].DataPropertyName = "SDT";

            dgvNhanVienView.AutoGenerateColumns = true;
        }

        private void FilterNhanVienLinQ2(string text)
        {
            text = text.ToUpper();
            var filtered = from n in nvList
                           where n.MaNV.ToUpper().Contains(text) || n.HoDem.ToUpper().Contains(text) || n.Ten.ToUpper().Contains(text) ||
                           n.SDT.ToUpper().Contains(text) || n.GioiTinh.ToUpper().Contains(text) || n.DiaChi.ToUpper().Contains(text)
                           select n;
            dgvNhanVienView.DataSource = filtered.ToList();

        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string text = txtFind.Text.Trim();
            FilterNhanVienLinQ2(text);
        }

        private void dgvNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;


                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString()!;
                txtHoDem.Text = dgvNhanVien.Rows[e.RowIndex].Cells["HoDem"].Value.ToString()!;
                txtTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells["Ten"].Value.ToString()!;
                dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                cboGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString()!;
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString()!;
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells["SDT"].Value.ToString()!;
            }
        }

        private void txtHoDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.ChuCai(txtHoDem, e);
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.ChuCai(txtTen, e);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Input.SoNguyen(txtSDT, e);
        }
    }

}