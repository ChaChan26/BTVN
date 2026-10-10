using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity
{
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống.")]
        [RegularExpression(@"^(?i)sv[0-9]+$", ErrorMessage = "Mã sinh viên phải bắt đầu bằng 'SV' (hoặc 'sv') và theo sau là các chữ số (ví dụ: SV000123).")]
        public string MaSV { get; set; } = string.Empty;

        // Alias tương thích
        public string maSinhVien
        {
            get => MaSV;
            set => MaSV = value;
        }

        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Họ và tên phải từ 2 đến 100 ký tự.")]
        public string HoTen { get; set; } = string.Empty;

        // Alias tương thích theo các cách gọi khác nhau
        public string TenSV
        {
            get => HoTen;
            set => HoTen = value;
        }
        public string tenSinhVien
        {
            get => HoTen;
            set => HoTen = value;
        }

        [Required(ErrorMessage = "Vui lòng chọn giới tính.")]
        public string GioiTinh { get; set; } = "Nam";
        public string gioiTinh
        {
            get => GioiTinh;
            set => GioiTinh = value;
        }

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        public DateTime NgaySinh { get; set; } = DateTime.Now.AddYears(-18);
        public DateTime ngaySinh
        {
            get => NgaySinh;
            set => NgaySinh = value;
        }

        public string DiaChi { get; set; } = string.Empty;
        public string diaChi
        {
            get => DiaChi;
            set => DiaChi = value;
        }

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng 0 và có 10-11 chữ số.")]
        public string SoDienThoai { get; set; } = string.Empty;
        public string sdt
        {
            get => SoDienThoai;
            set => SoDienThoai = value;
        }

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng (ví dụ: an.nv@vju.ac.vn).")]
        public string Email { get; set; } = string.Empty;
        public string email
        {
            get => Email;
            set => Email = value;
        }

        [Required(ErrorMessage = "Vui lòng chọn lớp học.")]
        public string MaLop { get; set; } = string.Empty;
        public string maLop
        {
            get => MaLop;
            set => MaLop = value;
        }

        public string TenLop { get; set; } = string.Empty;
        public string tenLop
        {
            get => TenLop;
            set => TenLop = value;
        }

        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong thang điểm từ 0.0 đến 10.0.")]
        public double Diem { get; set; } = 0.0;
        public double diem
        {
            get => Diem;
            set => Diem = value;
        }

        public string TrangThai { get; set; } = "Đang học";
        public string trangThai
        {
            get => TrangThai;
            set => TrangThai = value;
        }

        // Quan hệ 1 - n: Tham chiếu tới đối tượng LopHoc
        public LopHoc? LopHoc { get; set; }

        /// <summary>
        /// Phương thức kiểm tra tính không hợp lệ theo đúng cách gọi của thầy (sv.IsInValid().Count > 0)
        /// </summary>
        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            Validator.TryValidateObject(this, context, results, true);
            return results;
        }

        /// <summary>
        /// Phương thức kiểm tra tính hợp lệ sử dụng Data Annotations
        /// </summary>
        public (bool IsValid, List<string> Errors) KiemTraHopLe()
        {
            var results = IsInValid();
            var errors = new List<string>();
            foreach (var r in results)
            {
                if (!string.IsNullOrEmpty(r.ErrorMessage))
                    errors.Add(r.ErrorMessage);
            }
            return (results.Count == 0, errors);
        }
    }
}

namespace frmQuanLySinhVien.Entities
{
    // Alias tương thích ngược cho code cũ
    public class SinhVien : QuanLySinhVien.Data.Entity.SinhVien { }
}
