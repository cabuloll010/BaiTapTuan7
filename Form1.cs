using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.BLL; // Gọi tầng BLL

namespace QuanLySinhVien.UI // Đổi thành namespace project UI của bạn (ví dụ: WinFormsApp10 hoặc QuanLySinhVien.UI)
{
    public partial class Form1 : Form
    {
        // Khởi tạo Service từ tầng BLL (Thay thế hoàn toàn cho AppDbContext)
        private readonly StudentService _studentService = new StudentService();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Sẵn sàng.";
            await TaiDanhSach();
        }

        private async Task TaiDanhSach()
        {
            try
            {
                var danhSach = await _studentService.LayDanhSachAsync();
                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = danhSach;
                lblTrangThai.Text = $"Đã tải {danhSach.Count} sinh viên.";
                lblTrangThai.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnTaiLai_Click(object sender, EventArgs e)
        {
            await TaiDanhSach();
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null && dgvSinhVien.CurrentRow.Index >= 0)
            {
                txtHoTen.Text = dgvSinhVien.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";
                txtDiem.Text = dgvSinhVien.CurrentRow.Cells["Grade"].Value?.ToString() ?? "";
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diem))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                await _studentService.ThemSinhVienAsync(txtHoTen.Text, diem);

                lblTrangThai.Text = "Đã thêm sinh viên mới!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null || dgvSinhVien.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (!double.TryParse(txtDiem.Text, out double diemMoi))
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["Id"].Value);

                await _studentService.SuaSinhVienAsync(id, txtHoTen.Text, diemMoi);

                lblTrangThai.Text = "Đã cập nhật thông tin!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null || dgvSinhVien.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["Id"].Value);
            string hoTen = dgvSinhVien.CurrentRow.Cells["FullName"].Value?.ToString() ?? "";

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa \"{hoTen}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua != DialogResult.Yes) return;

            try
            {
                await _studentService.XoaSinhVienAsync(id);

                lblTrangThai.Text = "Đã xóa sinh viên!";
                lblTrangThai.ForeColor = Color.DarkGreen;
                txtHoTen.Clear();
                txtDiem.Clear();
                await TaiDanhSach();
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private async void btnLocDat_Click(object sender, EventArgs e)
        {
            try
            {
                var ketQua = await _studentService.LocSinhVienDatAsync();

                dgvSinhVien.DataSource = null;
                dgvSinhVien.DataSource = ketQua;
                lblTrangThai.Text = $"Tìm thấy {ketQua.Count} sinh viên đạt (>=5).";
                lblTrangThai.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi: " + ex.Message;
                lblTrangThai.ForeColor = Color.Red;
            }
        }
    }
}