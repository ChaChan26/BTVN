using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace frmQuanLySinhVien.Entities
{
    public class SinhVien
    {
        [Required]
        [RegularExpression(@"sv[0-9]+", ErrorMessage = "Mã sinh viên phải bắt đầu bằng 'sv' và theo sau là các chữ số.")]
        public string maSinhVien { get; set; } = string.Empty;
        public string tenSinhVien { get; set; } = string.Empty;
        public string gioiTinh { get; set; } = string.Empty;
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; } = string.Empty;
        public string sdt { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string maLop { get; set; } = string.Empty;
        public string tenLop { get; set; } = string.Empty;
        public double diem { get; set; }
    }
}
