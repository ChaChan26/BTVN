using System;
using System.Collections.Generic;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL
{
    /// <summary>
    /// Tầng DataAccess Layer (DAL) cho thực thể Sinh viên:
    /// Thực hiện các thao tác với nguồn dữ liệu (DataList): Thêm, sửa, xóa, tìm kiếm, lấy về từ DataList.
    /// </summary>
    public class SinhVienDAL
    {
        private List<SinhVien> sinhViens = new List<SinhVien>();

        public SinhVienDAL()
        {
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV01",
                HoTen = "Nguyễn Văn A",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(2004, 1, 15),
                DiaChi = "Hà Nội",
                SoDienThoai = "0912345678",
                Email = "a@gmail.com",
                MaLop = "L01",
                TenLop = "CNTT 1",
                Diem = 8.5,
                TrangThai = "Đang học"
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV02",
                HoTen = "Trần Thị B",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(2004, 5, 20),
                DiaChi = "Đà Nẵng",
                SoDienThoai = "0987654321",
                Email = "b@gmail.com",
                MaLop = "L01",
                TenLop = "CNTT 1",
                Diem = 9.0,
                TrangThai = "Đang học"
            });
            sinhViens.Add(new SinhVien
            {
                MaSV = "SV03",
                HoTen = "Lê Văn C",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(2004, 10, 10),
                DiaChi = "TP. Hồ Chí Minh",
                SoDienThoai = "0901234567",
                Email = "c@gmail.com",
                MaLop = "L02",
                TenLop = "CNTT 2",
                Diem = 7.5,
                TrangThai = "Đang học"
            });
        }

        // Lấy tất cả sinh viên
        public List<SinhVien> GetAllSinhVien()
        {
            return sinhViens;
        }

        // Lấy sinh viên theo mã SV
        public SinhVien? GetSinhVienById(string maSV)
        {
            return sinhViens.Find(s => s.MaSV.Equals(maSV, StringComparison.OrdinalIgnoreCase));
        }

        // Lấy danh sách sinh viên theo mã lớp (tìm kiếm phía CSDL / DAL)
        public List<SinhVien> GetSinhVienByMaLop(string maLop)
        {
            if (string.IsNullOrEmpty(maLop) || maLop.Equals("ALL", StringComparison.OrdinalIgnoreCase))
                return GetAllSinhVien();

            return sinhViens.FindAll(s => s.MaLop.Equals(maLop, StringComparison.OrdinalIgnoreCase));
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop) => GetSinhVienByMaLop(maLop);

        // Thêm sinh viên mới vào nguồn dữ liệu
        public void AddSinhVien(SinhVien sv)
        {
            sinhViens.Add(sv);
        }

        // Cập nhật thông tin sinh viên
        public void UpdateSinhVien(SinhVien svTam)
        {
            var sv = GetSinhVienById(svTam.MaSV);
            if (sv == null) return;

            sv.HoTen = svTam.HoTen;
            sv.GioiTinh = svTam.GioiTinh;
            sv.NgaySinh = svTam.NgaySinh;
            sv.DiaChi = svTam.DiaChi;
            sv.Email = svTam.Email;
            sv.SoDienThoai = svTam.SoDienThoai;
            sv.MaLop = svTam.MaLop;
            sv.TenLop = svTam.TenLop;
            sv.Diem = svTam.Diem;
            sv.TrangThai = svTam.TrangThai;
            sv.LopHoc = svTam.LopHoc;
        }

        // Xóa sinh viên khỏi nguồn dữ liệu
        public void DeleteSinhVien(string maSV)
        {
            var sv = GetSinhVienById(maSV);
            if (sv != null)
            {
                sinhViens.Remove(sv);
            }
        }

        // Tìm kiếm sinh viên đa tiêu chí
        public List<SinhVien> Search(string? tuKhoa, string? maLop, double diemToiThieu)
        {
            string kw = tuKhoa?.Trim().ToLower() ?? "";

            return sinhViens.FindAll(sv =>
                (string.IsNullOrEmpty(kw) || sv.MaSV.ToLower().Contains(kw) || sv.HoTen.ToLower().Contains(kw)) &&
                (string.IsNullOrEmpty(maLop) || maLop.Equals("ALL", StringComparison.OrdinalIgnoreCase) || sv.MaLop.Equals(maLop, StringComparison.OrdinalIgnoreCase)) &&
                sv.Diem >= diemToiThieu
            );
        }
    }
}
