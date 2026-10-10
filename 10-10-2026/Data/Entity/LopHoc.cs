using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLySinhVien.Data.Entity
{
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Mã lớp chỉ được chứa ký tự chữ và số.")]
        public string MaLop { get; set; } = string.Empty;

        // Alias chữ thường tương thích ngược
        public string maLop
        {
            get => MaLop;
            set => MaLop = value;
        }

        [Required(ErrorMessage = "Tên lớp không được để trống.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên lớp phải từ 2 đến 100 ký tự.")]
        public string TenLop { get; set; } = string.Empty;

        // Alias chữ thường tương thích ngược
        public string tenLop
        {
            get => TenLop;
            set => TenLop = value;
        }

        // Quan hệ 1 - n: Một lớp học có nhiều sinh viên
        public List<SinhVien> SinhViens { get; set; } = new List<SinhVien>();

        public override string ToString() => TenLop;

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

        public List<ValidationResult> IsInValid()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            Validator.TryValidateObject(this, context, results, true);
            return results;
        }
    }
}

namespace frmQuanLySinhVien.Entities
{
    // Alias tương thích ngược cho code cũ
    public class LopHoc : QuanLySinhVien.Data.Entity.LopHoc { }
}
