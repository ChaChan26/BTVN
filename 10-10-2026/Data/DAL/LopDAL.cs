using System;
using System.Collections.Generic;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.Data.DAL
{   
    /// <summary>
    /// Tầng DataAccess Layer (DAL) cho thực thể Lớp học:
    /// Thực hiện các thao tác với nguồn dữ liệu (DataList): Thêm, sửa, xóa, lấy về danh sách.
    /// </summary>
    public class LopDAL
    {
        private List<LopHoc> lopHocs = new List<LopHoc>();

        public LopDAL()
        {
            lopHocs.Add(new LopHoc { MaLop = "L01", TenLop = "CNTT 1" });
            lopHocs.Add(new LopHoc { MaLop = "L02", TenLop = "CNTT 2" });
            lopHocs.Add(new LopHoc { MaLop = "L03", TenLop = "CNTT 3" });
        }
        
        // Lấy tất cả lớp học
        public List<LopHoc> GetAllLopHoc()
        {
            return lopHocs;
        }

        // Lấy lớp học theo mã
        public LopHoc? GetLopHocById(string maLop)
        {
            return lopHocs.Find(l => l.MaLop.Equals(maLop, StringComparison.OrdinalIgnoreCase));
        }

        // Thêm lớp học mới
        public void AddLopHoc(LopHoc lh)
        {
            if (lh != null && GetLopHocById(lh.MaLop) == null)
            {
                lopHocs.Add(lh);
            }
        }

        // Sửa thông tin lớp học
        public void UpdateLopHoc(LopHoc lhMoi)
        {
            var lh = GetLopHocById(lhMoi.MaLop);
            if (lh != null)
            {
                lh.TenLop = lhMoi.TenLop;
            }
        }

        // Xóa lớp học
        public void DeleteLopHoc(string maLop)
        {
            var lh = GetLopHocById(maLop);
            if (lh != null)
            {
                lopHocs.Remove(lh);
            }
        }

        // Lấy danh sách dùng cho chức năng lọc (kèm tùy chọn "Tất cả lớp")
        public List<LopHoc> GetDanhSachLoc()
        {
            var danhSachLoc = new List<LopHoc>
            {
                new LopHoc { MaLop = "ALL", TenLop = "Tất cả lớp" }
            };
            danhSachLoc.AddRange(lopHocs);
            return danhSachLoc;
        }
    }
}
