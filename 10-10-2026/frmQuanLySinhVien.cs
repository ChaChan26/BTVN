using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLySinhVien.BUL;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        // ==========================================
        // CÁC ĐỐI TƯỢNG TẦNG BUSINESS (BUL / BLL)
        // ==========================================
        private SinhVienBUL sinhVienBUL = new SinhVienBUL();
        private LopBus lopBus = new LopBus();

        // Thuộc tính / Alias tương thích hoàn toàn với code của thầy
        private SinhVienBUL svb => sinhVienBUL;
        private ComboBox cboLop => cboLopHoc;
        private TextBox txtMa => txtMaSV;
        private ErrorProvider errPMaSV => errorProvidermasv;
        private ErrorProvider erpHoten => errorProviderhoten;
        private ErrorProvider erpEmail;
        private ErrorProvider erpDienThoai;

        public frmQuanLySinhVien()
        {
            InitializeComponent();

            // Khởi tạo ErrorProvider cho Email và Số điện thoại
            erpEmail = new ErrorProvider(this.components ??= new System.ComponentModel.Container());
            erpEmail.ContainerControl = this;

            erpDienThoai = new ErrorProvider(this.components);
            erpDienThoai.ContainerControl = this;
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            // Thiết lập phong cách hiển thị cho DataGridView
            CauHinhGiaoDienDataGridView();

            // 1. Lấy về danh sách lớp học từ LopBus và hiển thị lên combobox
            KhoiTaoDanhSachLopHoc();

            // 2. Khởi tạo danh sách trạng thái
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp", "Đình chỉ" });
            cboTrangThai.SelectedIndex = 0;

            // 3. Lấy về danh sách sinh viên từ SinhVienBUL và hiển thị lên DataGridView
            HienThiLenDataGridView(sinhVienBUL.GetAllSinhVien());

            // 4. Thiết lập trạng thái ban đầu của các button
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = true;

            // 5. Con trỏ thiết lập mặc định ở txtMaSV
            BeginInvoke(new Action(() =>
            {
                txtMaSV.Focus();
                txtMaSV.Select();
            }));

            // Đăng ký sự kiện TextChanged cho txtMaSV
            txtMaSV.TextChanged += txtMaSV_TextChanged;
        }

        private void CauHinhGiaoDienDataGridView()
        {
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85);
            dgvSinhVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvSinhVien.ColumnHeadersHeight = 36;

            dgvSinhVien.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvSinhVien.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvSinhVien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 237, 253);
            dgvSinhVien.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvSinhVien.RowTemplate.Height = 32;
        }

        private void KhoiTaoDanhSachLopHoc()
        {
            // ComboBox nhập liệu lớp học (gọi từ tầng BUL: LopBus)
            cboLopHoc.DataSource = new List<LopHoc>(lopBus.GetAllLopHoc());
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";

            // ComboBox lọc lớp học (có tùy chọn "Tất cả lớp")
            cboLocLop.DisplayMember = "TenLop";
            cboLocLop.ValueMember = "MaLop";
            cboLocLop.DataSource = lopBus.GetDanhSachLoc();
            cboLocLop.SelectedIndex = 0;

            // Đăng ký sự kiện khi đổi lớp trên ComboBox lọc
            cboLocLop.SelectedIndexChanged += cboLocLop_SelectedIndexChanged;
        }

        /// <summary>
        /// YÊU CẦU: Khi chọn lớp nào thì hiển thị sinh viên của lớp đấy trên giao diện.
        /// Thể hiện cả 2 phương thức:
        /// 1. Tìm kiếm phía cơ sở dữ liệu (Database / DAL / BUL)
        /// 2. Tìm kiếm trên giao diện (In-memory filter bằng LINQ)
        /// </summary>
        private void cboLocLop_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboLocLop.SelectedValue == null) return;
            string maLop = cboLocLop.SelectedValue.ToString() ?? "";

            // --- PHƯƠNG THỨC 1: Tìm kiếm phía cơ sở dữ liệu (DAL/BUL) ---
            var danhSach = TimKiemPhiaCoSoDuLieu(maLop);

            // --- PHƯƠNG THỨC 2: Tìm kiếm trên giao diện (Client-side / In-memory) ---
            // var danhSach = TimKiemTrenGiaoDien(maLop);

            HienThiLenDataGridView(danhSach);
        }

        // Tên sự kiện tương thích nếu combobox có tên cboLop
        private void cboLop_SelectedIndexChanged(object? sender, EventArgs e)
        {
            cboLocLop_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// Tìm kiếm phía cơ sở dữ liệu / DAL: Truy vấn trực tiếp từ tầng BUL -> DAL
        /// </summary>
        public List<SinhVien> TimKiemPhiaCoSoDuLieu(string maLop)
        {
            return sinhVienBUL.GetSinhVienByMaLop(maLop);
        }

        /// <summary>
        /// Tìm kiếm trên giao diện: Lọc trực tiếp từ danh sách sinh viên hiện có trên bộ nhớ Form
        /// </summary>
        public List<SinhVien> TimKiemTrenGiaoDien(string maLop)
        {
            var tatCa = sinhVienBUL.GetAllSinhVien();
            if (string.IsNullOrEmpty(maLop) || maLop.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                return tatCa;

            return tatCa.Where(sv => sv.MaLop.Equals(maLop, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void HienThiLenDataGridView(List<SinhVien> danhSach)
        {
            dgvSinhVien.Rows.Clear();
            foreach (var sv in danhSach)
            {
                dgvSinhVien.Rows.Add(
                    sv.MaSV,
                    sv.HoTen,
                    sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.GioiTinh,
                    sv.Email,
                    sv.SoDienThoai,
                    sv.Diem.ToString("0.0"),
                    sv.TenLop,
                    sv.TrangThai
                );
            }
            lblTongSo.Text = $"Tổng số: {danhSach.Count}";
        }

        /// <summary>
        /// YÊU CẦU: Khi nhập mã Sinh viên vào txtMa:
        /// - Nếu mã tồn tại: hiển thị thông tin của sinh viên vào các điều khiển, disable Thêm, enable Sửa, Xóa
        /// - Nếu không tồn tại: xóa trống các điều khiển còn lại, enable Thêm, disable Sửa, Xóa
        /// </summary>
        private void XuLyNhapMaSV()
        {
            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }

            var sv = sinhVienBUL.GetSinhVienById(ma);
            if (sv != null)
            {
                // Tồn tại: hiển thị thông tin lên form, disable Thêm, enable Sửa/Xóa
                HienThiChiTietSinhVien(sv);
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                // Không tồn tại: xóa trống các điều khiển, enable Thêm, disable Sửa/Xóa
                XoaTrangCacDieuKhienConLai();
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void txtMaSV_TextChanged(object? sender, EventArgs e)
        {
            // Xóa thông báo lỗi mã SV khi người dùng đang gõ lại
            errPMaSV.SetError(txtMaSV, "");

            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma)) return;

            // Nếu người dùng nhập trúng mã sinh viên đã có, tự động tải dữ liệu
            var sv = sinhVienBUL.GetSinhVienById(ma);
            if (sv != null)
            {
                HienThiChiTietSinhVien(sv);
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtMaSV_Leave(object? sender, EventArgs e)
        {
            XuLyNhapMaSV();
        }

        private void txtMaSV_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                XuLyNhapMaSV();
            }
        }

        private void HienThiChiTietSinhVien(SinhVien sv)
        {
            txtMaSV.Text = sv.MaSV;
            txtHoTen.Text = sv.HoTen;

            if (sv.GioiTinh == "Nữ")
                rdoNu.Checked = true;
            else
                rdoNam.Checked = true;

            if (sv.NgaySinh >= dtpNgaySinh.MinDate && sv.NgaySinh <= dtpNgaySinh.MaxDate)
                dtpNgaySinh.Value = sv.NgaySinh;

            txtEmail.Text = sv.Email;
            txtDienThoai.Text = sv.SoDienThoai;

            if (!string.IsNullOrEmpty(sv.MaLop))
                cboLopHoc.SelectedValue = sv.MaLop;

            numDiem.Value = (decimal)Math.Clamp(sv.Diem, (double)numDiem.Minimum, (double)numDiem.Maximum);

            if (!string.IsNullOrEmpty(sv.TrangThai) && cboTrangThai.Items.Contains(sv.TrangThai))
                cboTrangThai.SelectedItem = sv.TrangThai;
            else
                cboTrangThai.SelectedIndex = 0;
        }

        private void XoaTrangCacDieuKhienConLai()
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            dtpNgaySinh.Value = new DateTime(2006, 1, 1);
            rdoNam.Checked = true;
            numDiem.Value = 0;
            if (cboLopHoc.Items.Count > 0)
                cboLopHoc.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0)
                cboTrangThai.SelectedIndex = 0;
        }

        /// <summary>
        /// Xóa sạch các thông báo lỗi hiển thị trên ErrorProvider
        /// </summary>
        private void XoaTatCaLoiErrorProvider()
        {
            errPMaSV.SetError(txtMaSV, "");
            erpHoten.SetError(txtHoTen, "");
            erpEmail.SetError(txtEmail, "");
            erpDienThoai.SetError(txtDienThoai, "");
        }

        /// <summary>
        /// YÊU CẦU: Nhấn Làm mới -> Xóa trống form, Enable Thêm, Disable Sửa/Xóa, tiêu điểm về txtMaSV
        /// </summary>
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            XoaTatCaLoiErrorProvider();
            txtMaSV.Clear();
            XoaTrangCacDieuKhienConLai();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaSV.Focus();
        }

        /// <summary>
        /// CHỨC NĂNG THÊM SINH VIÊN (Khớp chuẩn theo code của thầy)
        /// Kiểm tra tính hợp lệ bằng Data Annotations (IsInValid).
        /// Nếu sai trường nào thì dùng ErrorProvider để báo lỗi tương ứng.
        /// </summary>
        private void btnThem_Click(object? sender, EventArgs e)
        {
            butThem_Click(sender, e);
        }

        // Tên phương thức theo đúng mã nguồn của thầy
        private void butThem_Click(object? sender, EventArgs e)
        {
            // Xóa thông báo lỗi cũ trước khi kiểm tra
            XoaTatCaLoiErrorProvider();

            SinhVien sv = new SinhVien();
            sv.MaSV = txtMaSV.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.HoTen = txtHoTen.Text.Trim();
            sv.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            sv.Email = txtEmail.Text.Trim();
            sv.SoDienThoai = txtDienThoai.Text.Trim();
            sv.MaLop = cboLop.SelectedValue?.ToString() ?? "";
            var lopChon = cboLop.SelectedItem as LopHoc;
            sv.TenLop = lopChon?.TenLop ?? "";
            sv.Diem = (double)numDiem.Value;
            sv.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang học";

            List<ValidationResult> errors = sv.IsInValid();
            if (errors.Count == 0)
            {
                try
                {
                    svb.AddSinhVien(sv);
                    HienThiLenDataGridView(svb.GetAllSinhVien());
                    MessageBox.Show($"Thêm sinh viên '{sv.HoTen}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                catch (Exception ex)
                {
                    // Lỗi trùng mã sinh viên hoặc lỗi từ tầng BUL
                    errPMaSV.SetError(txtMaSV, ex.Message);
                    txtMaSV.Focus();
                    MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Hiển thị thông báo lỗi tương ứng với từng trường
                Control? firstControlWithError = null;

                foreach (var error in errors)
                {
                    if (error.MemberNames != null && error.MemberNames.Any())
                    {
                        string fieldName = error.MemberNames.First();
                        switch (fieldName)
                        {
                            case "MaSV":
                                errPMaSV.SetError(txtMaSV, error.ErrorMessage);
                                firstControlWithError ??= txtMaSV;
                                break;
                            case "HoTen":
                                erpHoten.SetError(txtHoTen, error.ErrorMessage);
                                firstControlWithError ??= txtHoTen;
                                break;
                            case "Email":
                                erpEmail.SetError(txtEmail, error.ErrorMessage);
                                firstControlWithError ??= txtEmail;
                                break;
                            case "SoDienThoai":
                                erpDienThoai.SetError(txtDienThoai, error.ErrorMessage);
                                firstControlWithError ??= txtDienThoai;
                                break;
                            default:
                                break;
                        }
                    }
                }

                // Đưa con trỏ focus vào ô lỗi đầu tiên
                firstControlWithError?.Focus();

                // Hiển thị thông báo tổng hợp (đặt ngoài vòng lặp foreach để không hiện lặp lại nhiều lần)
                string errorMessage = string.Join("\n• ", errors.Select(err => err.ErrorMessage));
                MessageBox.Show("Dữ liệu không hợp lệ:\n• " + errorMessage, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// CHỨC NĂNG SỬA SINH VIÊN
        /// Kiểm tra tính hợp lệ bằng Data Annotations (IsInValid) và dùng ErrorProvider báo lỗi.
        /// Xác thực người dùng trước khi cập nhật.
        /// </summary>
        private void btnSua_Click(object? sender, EventArgs e)
        {
            XoaTatCaLoiErrorProvider();

            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                errPMaSV.SetError(txtMaSV, "Vui lòng nhập mã sinh viên cần sửa!");
                txtMaSV.Focus();
                return;
            }

            var svCu = svb.GetSinhVienById(ma);
            if (svCu == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần sửa trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = new SinhVien();
            sv.MaSV = ma;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.HoTen = txtHoTen.Text.Trim();
            sv.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            sv.Email = txtEmail.Text.Trim();
            sv.SoDienThoai = txtDienThoai.Text.Trim();
            sv.MaLop = cboLop.SelectedValue?.ToString() ?? "";
            var lopChon = cboLop.SelectedItem as LopHoc;
            sv.TenLop = lopChon?.TenLop ?? "";
            sv.Diem = (double)numDiem.Value;
            sv.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Đang học";

            List<ValidationResult> errors = sv.IsInValid();
            if (errors.Count == 0)
            {
                // Xác thực trước khi thực hiện chức năng nguy hiểm (ghi đè dữ liệu)
                var dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn cập nhật thông tin cho sinh viên '{sv.HoTen}' (Mã: {sv.MaSV}) không?",
                    "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dialogResult != DialogResult.Yes)
                    return;

                try
                {
                    svb.UpdateSinhVien(sv);
                    HienThiLenDataGridView(svb.GetAllSinhVien());
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Báo lỗi bằng ErrorProvider
                Control? firstControlWithError = null;
                foreach (var error in errors)
                {
                    if (error.MemberNames != null && error.MemberNames.Any())
                    {
                        string fieldName = error.MemberNames.First();
                        switch (fieldName)
                        {
                            case "MaSV":
                                errPMaSV.SetError(txtMaSV, error.ErrorMessage);
                                firstControlWithError ??= txtMaSV;
                                break;
                            case "HoTen":
                                erpHoten.SetError(txtHoTen, error.ErrorMessage);
                                firstControlWithError ??= txtHoTen;
                                break;
                            case "Email":
                                erpEmail.SetError(txtEmail, error.ErrorMessage);
                                firstControlWithError ??= txtEmail;
                                break;
                            case "SoDienThoai":
                                erpDienThoai.SetError(txtDienThoai, error.ErrorMessage);
                                firstControlWithError ??= txtDienThoai;
                                break;
                            default:
                                break;
                        }
                    }
                }

                firstControlWithError?.Focus();
                string errorMessage = string.Join("\n• ", errors.Select(err => err.ErrorMessage));
                MessageBox.Show("Dữ liệu sửa không hợp lệ:\n• " + errorMessage, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// CHỨC NĂNG XÓA SINH VIÊN
        /// Xác thực người dùng trước khi xóa (chức năng nguy hiểm).
        /// </summary>
        private void btnXoa_Click(object? sender, EventArgs e)
        {
            XoaTatCaLoiErrorProvider();

            string ma = txtMaSV.Text.Trim();
            var sv = svb.GetSinhVienById(ma);
            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show(
                $"CẢNH BÁO: Bạn có chắc chắn muốn xóa sinh viên '{sv.HoTen}' (Mã: {sv.MaSV}) không?\nHành động này không thể hoàn tác!",
                "Xác nhận xóa sinh viên",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (dialogResult != DialogResult.Yes)
                return;

            try
            {
                svb.DeleteSinhVien(ma);
                HienThiLenDataGridView(svb.GetAllSinhVien());
                btnLamMoi_Click(sender, e);
                MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tìm kiếm sinh viên theo Từ khóa, Lớp và Điểm tối thiểu
        /// </summary>
        private void btnTimKiem_Click(object? sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();
            string? maLopLoc = cboLocLop.SelectedValue?.ToString();
            double diemToiThieu = (double)numLocDiem.Value;

            var ketQua = svb.Search(tuKhoa, maLopLoc, diemToiThieu);
            HienThiLenDataGridView(ketQua);
        }

        /// <summary>
        /// Hiển thị tất cả sinh viên và đặt lại bộ lọc
        /// </summary>
        private void btnTatCa_Click(object? sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            if (cboLocLop.Items.Count > 0)
                cboLocLop.SelectedIndex = 0;
            numLocDiem.Value = 0;

            HienThiLenDataGridView(svb.GetAllSinhVien());
        }

        /// <summary>
        /// Khi người dùng click chọn dòng trên DataGridView:
        /// Hiển thị thông tin lên form, disable Thêm, enable Sửa và Xóa
        /// </summary>
        private void dgvSinhVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                XoaTatCaLoiErrorProvider();
                var row = dgvSinhVien.Rows[e.RowIndex];
                string? maSV = row.Cells[0]?.Value?.ToString();
                if (!string.IsNullOrEmpty(maSV))
                {
                    var sv = svb.GetSinhVienById(maSV);
                    if (sv != null)
                    {
                        HienThiChiTietSinhVien(sv);
                        btnThem.Enabled = false;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                }
            }
        }

        private void lblHeaderTitle_Click(object? sender, EventArgs e)
        {
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
