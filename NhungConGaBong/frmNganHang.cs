using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace NhungConGaBong
{
    public partial class frmNganHang : Form
    {
        List<NganHang> ngList = new List<NganHang>();
        public frmNganHang()
        {
            InitializeComponent();
            dgvNganHang.RowsDefaultCellStyle.BackColor = Color.MintCream;
            dgvNganHang.AlternatingRowsDefaultCellStyle.BackColor = Color.OldLace;
        }

        private void frmNganHang_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNganHang.csv";
            ngList = NganHang.ReadFromFile(fileName);
            dgvNganHang.DataSource = ngList;
            txtID.Text = (ngList.Max(x => x.ID) + 1).ToString();
            txtMaNH.Text = "NH" + txtID.Text;
        }

        private void dgvNganHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SacDataGridView.SetRowNumber(sender, e);
        }

        private void dgvNganHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                btnXoaNH.Enabled = true;
                btnSuaNH.Enabled = true;
                btnThemNH.Enabled = false;

                txtID.Text = dgvNganHang.Rows[e.RowIndex].Cells["ID"].Value.ToString()!;
                txtMaNH.Text = dgvNganHang.Rows[e.RowIndex].Cells["manh"].Value.ToString()!;
                txtTenNganHang.Text = dgvNganHang.Rows[e.RowIndex].Cells["tennh"].Value.ToString()!;
                txtTenGiaoDich.Text = dgvNganHang.Rows[e.RowIndex].Cells["tengd"].Value.ToString()!;
            }
        }

        private void btnThemMoiNH_Click(object sender, EventArgs e)
        {
            txtID.Text = (ngList.Max(x => x.ID) + 1).ToString();
            txtMaNH.Text = "";
            txtTenGiaoDich.Text = "";
            txtTenNganHang.Text = "";

            btnThemNH.Enabled = true;
            btnXoaNH.Enabled = false;
            btnSuaNH.Enabled = false;
        }

        private void btnSuaNH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn sửa nội dung ngân hàng {txtTenNganHang.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Tìm Index - Vị trí của ID trong List
            int index = ngList.FindIndex(a => a.ID == Convert.ToInt32(txtID.Text));
            if (index >= 0)
            {
                dgvNganHang.AutoGenerateColumns = false;

                ngList[index].TenNH = txtTenNganHang.Text;
                ngList[index].TenGD = txtTenGiaoDich.Text;
                ngList[index].NgaySua = DateTime.Now.Date;
                dgvNganHang.DataSource = ngList;

                dgvNganHang.AutoGenerateColumns = true;

                // XỬ lý Select dòng cuối vừa sửa                
                dgvNganHang.Rows[index].Selected = true;
            }
        }

        private void btnXoaNH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn muốn xoá ngân hàng {txtTenNganHang.Text}? (Yes/No)", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Tìm Index - Vị trí của ID trong List
            int index = ngList.FindIndex(a => a.ID == Convert.ToInt32(txtID.Text));
            if (index >= 0)
            {
                dgvNganHang.AutoGenerateColumns = false;

                ngList.RemoveAt(index);

                dgvNganHang.DataSource = ngList;
                dgvNganHang.AutoGenerateColumns = true;
            }
        }

        private void btnThemNH_Click(object sender, EventArgs e)
        {
            dgvNganHang.AutoGenerateColumns = false;
            string code = txtMaNH.Text.Trim().ToUpper();

            // Tìm và trả về Industry; != null là tìm thấy --> Mã tồn tại trong List (nganhList)
            NganHang item = ngList.Find(x => x.MaNH.ToUpper().Equals(code));
            if (item != null)
            {
                // Tìm index của List
                int index = ngList.IndexOf(item);
                MessageBox.Show($"Mã ngân hàng {code} đã tồn tại trong List ở vị trí {index}\n   Bạn vui lòng nhập mã ngân hàng khác", "Cảnh báo");
                return;
            }
            NganHang ng = new NganHang();
            ng.ID = Convert.ToInt32(txtID.Text);
            
            ng.MaNH = txtMaNH.Text;
            ng.TenNH = txtTenNganHang.Text;
            ng.TenGD = txtTenGiaoDich.Text;
            ng.NgayLap = DateTime.Now.Date;
            ng.NgaySua = ng.NgayLap;
            ngList.Add(ng);

            dgvNganHang.DataSource = ngList;
            dgvNganHang.AutoGenerateColumns = true;

            int rowIndex = dgvNganHang.RowCount - 1;
            dgvNganHang.Rows[rowIndex].Selected = true;

            txtID.Text = (ngList.Max(x => x.ID) + 1).ToString();
            txtMaNH.Text = "NH" + txtID.Text;
        }

        private void btnLuuNH_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = path + @"\FileNganHang.csv";
            NganHang.SaveToFile(ngList, fileName);
        }
    }
}
