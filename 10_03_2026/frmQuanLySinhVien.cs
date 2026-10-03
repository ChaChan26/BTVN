using frmQuanLySinhVien.Entities;

namespace QuanLySinhVien
{
    public partial class frmQuanLySinhVien : Form
    {
        List<SinhVien> sinhViens = new List<SinhVien>();
        List<LopHoc> lopHocs = new List<LopHoc>();

        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            textBox17.ReadOnly = true;

            // Dữ liệu mẫu lớp học
            lopHocs = new List<LopHoc>()
            {
                new LopHoc { maLop = "cse01", tenLop = "Công nghệ thông tin " },
                new LopHoc { maLop = "cse02", tenLop = "Khoa học máy tính " },
                new LopHoc { maLop = "cse03", tenLop = "Kỹ thuật phần mềm " },
                new LopHoc { maLop = "cse04", tenLop = "Hệ thống thông tin " }
            };

            comboBox1.DataSource = lopHocs;
            comboBox1.DisplayMember = "tenLop";
            comboBox1.ValueMember = "maLop";

            // Dữ liệu mẫu sinh viên
            sinhViens = new List<SinhVien>()
            {
                new SinhVien
                {
                    maSinhVien = "sv01",
                    tenSinhVien = "Nguyễn Văn An",
                    gioiTinh = "Nam",
                    ngaySinh = new DateTime(2003, 5, 15),
                    diaChi = "Hà Nội",
                    sdt = "0912345678",
                    email = "an.nguyen@vnu.edu.vn",
                    maLop = "cse01",
                    tenLop = "Công nghệ thông tin 1",
                    diem = 8.5
                },
                new SinhVien
                {
                    maSinhVien = "sv02",
                    tenSinhVien = "Trần Thị Bình",
                    gioiTinh = "Nữ",
                    ngaySinh = new DateTime(2003, 8, 20),
                    diaChi = "Đà Nẵng",
                    sdt = "0987654321",
                    email = "binh.tran@vnu.edu.vn",
                    maLop = "cse02",
                    tenLop = "Khoa học máy tính 1",
                    diem = 9.0
                },
                new SinhVien
                {
                    maSinhVien = "sv03",
                    tenSinhVien = "Lê Hoàng Cường",
                    gioiTinh = "Nam",
                    ngaySinh = new DateTime(2003, 11, 10),
                    diaChi = "TP. Hồ Chí Minh",
                    sdt = "0901234567",
                    email = "cuong.le@vnu.edu.vn",
                    maLop = "cse01",
                    tenLop = "Công nghệ thông tin 1",
                    diem = 7.5
                }
            };

            loaddata();
        }

        private void loaddata()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sinhViens;
            textBox17.Text = sinhViens.Count.ToString();

            void SetHeader(string colName, string headerText, string? format = null)
            {
                if (dataGridView1.Columns[colName] is DataGridViewColumn col)
                {
                    col.HeaderText = headerText;
                    if (format != null) col.DefaultCellStyle.Format = format;
                }
            }

            SetHeader("maSinhVien", "Mã SV");
            SetHeader("tenSinhVien", "Họ và tên");
            SetHeader("gioiTinh", "Giới tính");
            SetHeader("ngaySinh", "Ngày sinh", "dd/MM/yyyy");
            SetHeader("diaChi", "Địa chỉ");
            SetHeader("sdt", "SĐT");
            SetHeader("email", "Email");
            SetHeader("maLop", "Mã lớp");
            SetHeader("tenLop", "Tên lớp");
            SetHeader("diem", "Điểm");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMaSinhVien_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtMaSV_Leave(object sender, EventArgs e)
        {
            string ma = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                textBox21.Text = string.Empty;
                return;
            }

            SinhVien? sv = sinhViens.FirstOrDefault(s => s.maSinhVien.Equals(ma, StringComparison.OrdinalIgnoreCase));
            if (sv != null)
            {
                textBox1.Text = sv.tenSinhVien;
                if (sv.gioiTinh == "Nữ")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }

                if (sv.ngaySinh >= dateTimePicker1.MinDate && sv.ngaySinh <= dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = sv.ngaySinh;
                }

                textBox3.Text = sv.sdt;
                comboBox1.SelectedValue = sv.maLop;
                numericUpDown1.Value = (decimal)Math.Clamp(sv.diem, (double)numericUpDown1.Minimum, (double)numericUpDown1.Maximum);
                textBox21.Text = "Đã tồn tại";
            }
            else
            {
                textBox21.Text = "Mới";
            }
        }
    }
}
