using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySinhVien.Data.DAL;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.BUL
{
    /// <summary>
    /// Tầng Business Logic Layer (BUL/BLL) cho thực thể Sinh viên:
    /// Chứa các quy tắc nghiệp vụ: kiểm tra tính hợp lệ dữ liệu, kiểm tra trùng mã, kiểm tra tồn tại,
    /// và điều phối các thao tác dữ liệu qua tầng DAL.
    /// </summary>
    public class SinhVienBUL
    {
        private SinhVienDAL svd;

        public SinhVienBUL()
        {
            svd = new SinhVienDAL();
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return svd.GetAllSinhVien();
        }

        public SinhVien? GetSinhVienById(string maSV)
        {
            return svd.GetSinhVienById(maSV);
        }

        public List<SinhVien> GetSinhVienByMaLop(string maLop)
        {
            return svd.GetSinhVienByMaLop(maLop);
        }

        public List<SinhVien> GetSinhViensByMaLop(string maLop) => GetSinhVienByMaLop(maLop);

        public void AddSinhVien(SinhVien sv)
        {
            if (sv == null)
            {
                throw new Exception("Dữ liệu sinh viên không hợp lệ!");
            }

            var errors = sv.IsInValid();
            if (errors.Count > 0)
            {
                throw new Exception("Dữ liệu không hợp lệ:\n• " + string.Join("\n• ", errors.Select(e => e.ErrorMessage)));
            }

            var s = svd.GetSinhVienById(sv.MaSV);
            if (s != null)
            {
                throw new Exception($"Mã sinh viên '{sv.MaSV}' đã tồn tại trong hệ thống!");
            }

            // Thêm sinh viên vào nguồn dữ liệu
            svd.AddSinhVien(sv);
        }

        public void UpdateSinhVien(SinhVien sv)
        {
            if (sv == null)
            {
                throw new Exception("Dữ liệu sinh viên không hợp lệ!");
            }

            var errors = sv.IsInValid();
            if (errors.Count > 0)
            {
                throw new Exception("Dữ liệu không hợp lệ:\n• " + string.Join("\n• ", errors.Select(e => e.ErrorMessage)));
            }

            var s = svd.GetSinhVienById(sv.MaSV);
            if (s == null)
            {
                throw new Exception($"Không tìm thấy sinh viên có mã '{sv.MaSV}' để cập nhật!");
            }

            svd.UpdateSinhVien(sv);
        }

        public void DeleteSinhVien(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
            {
                throw new Exception("Vui lòng nhập mã sinh viên cần xóa!");
            }

            var s = svd.GetSinhVienById(maSV);
            if (s == null)
            {
                throw new Exception($"Không tìm thấy sinh viên có mã '{maSV}' cần xóa!");
            }

            svd.DeleteSinhVien(maSV);
        }

        public List<SinhVien> Search(string? tuKhoa, string? maLop, double diemToiThieu)
        {
            return svd.Search(tuKhoa, maLop, diemToiThieu);
        }
    }

    // Alias tương thích
    public class SinhVienBus : SinhVienBUL { }
    public class SinhVienBusiness : SinhVienBUL { }
}
