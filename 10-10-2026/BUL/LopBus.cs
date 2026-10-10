using System;
using System.Collections.Generic;
using System.Linq;
using QuanLySinhVien.Data.DAL;
using QuanLySinhVien.Data.Entity;

namespace QuanLySinhVien.BUL
{
    /// <summary>
    /// Tầng Business Logic Layer (BUL/BLL) cho thực thể Lớp học:
    /// Thực hiện các nghiệp vụ yêu cầu liên quan đến Lớp học, làm cầu nối giữa Presentation và DAL.
    /// </summary>
    public class LopBus
    {
        private LopDAL lopDAL;

        public LopBus()
        {
            lopDAL = new LopDAL();
        }

        public List<LopHoc> GetAllLopHoc()
        {
            return lopDAL.GetAllLopHoc();
        }

        public LopHoc? GetLopHocById(string maLop)
        {
            return lopDAL.GetLopHocById(maLop);
        }

        public void AddLopHoc(LopHoc lh)
        {
            if (lh == null)
                throw new ArgumentNullException(nameof(lh), "Dữ liệu lớp học không hợp lệ!");

            var errors = lh.IsInValid();
            if (errors.Count > 0)
                throw new Exception("Dữ liệu không hợp lệ:\n• " + string.Join("\n• ", errors.Select(e => e.ErrorMessage)));

            if (lopDAL.GetLopHocById(lh.MaLop) != null)
                throw new Exception($"Mã lớp '{lh.MaLop}' đã tồn tại!");

            lopDAL.AddLopHoc(lh);
        }

        public void UpdateLopHoc(LopHoc lh)
        {
            if (lh == null)
                throw new ArgumentNullException(nameof(lh), "Dữ liệu lớp học không hợp lệ!");

            var errors = lh.IsInValid();
            if (errors.Count > 0)
                throw new Exception("Dữ liệu không hợp lệ:\n• " + string.Join("\n• ", errors.Select(e => e.ErrorMessage)));

            if (lopDAL.GetLopHocById(lh.MaLop) == null)
                throw new Exception($"Không tìm thấy lớp học có mã '{lh.MaLop}'!");

            lopDAL.UpdateLopHoc(lh);
        }

        public void DeleteLopHoc(string maLop)
        {
            if (string.IsNullOrWhiteSpace(maLop))
                throw new ArgumentException("Mã lớp không được để trống!", nameof(maLop));

            if (lopDAL.GetLopHocById(maLop) == null)
                throw new Exception($"Không tìm thấy lớp học có mã '{maLop}'!");

            lopDAL.DeleteLopHoc(maLop);
        }

        public List<LopHoc> GetDanhSachLoc()
        {
            return lopDAL.GetDanhSachLoc();
        }
    }

    // Alias dự phòng tương thích theo các tên gọi
    public class LopBusiness : LopBus { }
    public class LopBUL : LopBus { }
}
