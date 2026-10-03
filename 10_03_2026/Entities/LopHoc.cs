using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace frmQuanLySinhVien.Entities
{
    public class LopHoc
    {
        [Required]
        [RegularExpression(@"cse[0-9]+", ErrorMessage = "Mã lớp phải bắt đầu bằng 'cse' và theo sau là các chữ số.")]
        public string maLop { get; set; } = string.Empty;
        public string tenLop { get; set; } = string.Empty;
    }
}
