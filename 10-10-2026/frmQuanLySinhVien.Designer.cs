namespace QuanLySinhVien
{
    partial class frmQuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSubHeader = new Panel();
            lblHeaderTitle = new Label();
            pnlThongTin = new Panel();
            lblTitleThongTin = new Label();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblLopHoc = new Label();
            cboLopHoc = new ComboBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            lblDiem = new Label();
            numDiem = new NumericUpDown();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDienThoai = new Label();
            txtDienThoai = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            pnlTimKiem = new Panel();
            lblTuKhoa = new Label();
            txtTuKhoa = new TextBox();
            lblLocLop = new Label();
            cboLocLop = new ComboBox();
            lblLocDiem = new Label();
            numLocDiem = new NumericUpDown();
            btnTimKiem = new Button();
            btnTatCa = new Button();
            pnlDanhSach = new Panel();
            lblTitleDanhSach = new Label();
            lblTongSo = new Label();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colTenSV = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiem = new DataGridViewTextBoxColumn();
            colLop = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlStatusBar = new Panel();
            errorProvidermasv = new ErrorProvider(components);
            errorProviderdssv = new ErrorProvider(components);
            errorProviderhoten = new ErrorProvider(components);
            errorProvidertimkiem = new ErrorProvider(components);
            pnlSubHeader.SuspendLayout();
            pnlThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiem).BeginInit();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLocDiem).BeginInit();
            pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidermasv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderdssv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderhoten).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidertimkiem).BeginInit();
            SuspendLayout();
            // 
            // pnlSubHeader
            // 
            pnlSubHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSubHeader.BackColor = Color.FromArgb(248, 250, 252);
            pnlSubHeader.Controls.Add(lblHeaderTitle);
            pnlSubHeader.Location = new Point(3, 12);
            pnlSubHeader.Name = "pnlSubHeader";
            pnlSubHeader.Size = new Size(1244, 48);
            pnlSubHeader.TabIndex = 101;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 58, 95);
            lblHeaderTitle.Location = new Point(-1, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(275, 37);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "QUẢN LÝ SINH VIÊN";
            lblHeaderTitle.Click += lblHeaderTitle_Click;
            // 
            // pnlThongTin
            // 
            pnlThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.BorderStyle = BorderStyle.FixedSingle;
            pnlThongTin.Controls.Add(lblTitleThongTin);
            pnlThongTin.Controls.Add(lblMaSV);
            pnlThongTin.Controls.Add(txtMaSV);
            pnlThongTin.Controls.Add(lblHoTen);
            pnlThongTin.Controls.Add(txtHoTen);
            pnlThongTin.Controls.Add(lblLopHoc);
            pnlThongTin.Controls.Add(cboLopHoc);
            pnlThongTin.Controls.Add(lblNgaySinh);
            pnlThongTin.Controls.Add(dtpNgaySinh);
            pnlThongTin.Controls.Add(lblGioiTinh);
            pnlThongTin.Controls.Add(rdoNam);
            pnlThongTin.Controls.Add(rdoNu);
            pnlThongTin.Controls.Add(lblDiem);
            pnlThongTin.Controls.Add(numDiem);
            pnlThongTin.Controls.Add(lblEmail);
            pnlThongTin.Controls.Add(txtEmail);
            pnlThongTin.Controls.Add(lblDienThoai);
            pnlThongTin.Controls.Add(txtDienThoai);
            pnlThongTin.Controls.Add(lblTrangThai);
            pnlThongTin.Controls.Add(cboTrangThai);
            pnlThongTin.Controls.Add(btnThem);
            pnlThongTin.Controls.Add(btnSua);
            pnlThongTin.Controls.Add(btnXoa);
            pnlThongTin.Controls.Add(btnLamMoi);
            pnlThongTin.Location = new Point(2, 61);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Size = new Size(1222, 206);
            pnlThongTin.TabIndex = 0;
            // 
            // lblTitleThongTin
            // 
            lblTitleThongTin.AutoSize = true;
            lblTitleThongTin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTitleThongTin.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitleThongTin.Location = new Point(0, 1);
            lblTitleThongTin.Name = "lblTitleThongTin";
            lblTitleThongTin.Size = new Size(182, 25);
            lblTitleThongTin.TabIndex = 0;
            lblTitleThongTin.Text = "Thông tin sinh viên";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMaSV.ForeColor = Color.FromArgb(51, 65, 85);
            lblMaSV.Location = new Point(26, 48);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(108, 20);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sinh viên *";
            // 
            // txtMaSV
            // 
            txtMaSV.Font = new Font("Segoe UI", 9.5F);
            txtMaSV.Location = new Point(140, 44);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(210, 29);
            txtMaSV.TabIndex = 0;
            txtMaSV.KeyDown += txtMaSV_KeyDown;
            txtMaSV.Leave += txtMaSV_Leave;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.FromArgb(51, 65, 85);
            lblHoTen.Location = new Point(366, 48);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(87, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên *";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9.5F);
            txtHoTen.Location = new Point(464, 39);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(220, 29);
            txtHoTen.TabIndex = 3;
            // 
            // lblLopHoc
            // 
            lblLopHoc.AutoSize = true;
            lblLopHoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLopHoc.ForeColor = Color.FromArgb(51, 65, 85);
            lblLopHoc.Location = new Point(700, 48);
            lblLopHoc.Name = "lblLopHoc";
            lblLopHoc.Size = new Size(75, 20);
            lblLopHoc.TabIndex = 3;
            lblLopHoc.Text = "Lớp học *";
            // 
            // cboLopHoc
            // 
            cboLopHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLopHoc.Font = new Font("Segoe UI", 9.5F);
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(780, 44);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(220, 29);
            cboLopHoc.TabIndex = 7;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNgaySinh.ForeColor = Color.FromArgb(51, 65, 85);
            lblNgaySinh.Location = new Point(26, 88);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(79, 20);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 9.5F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(140, 82);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(210, 29);
            dtpNgaySinh.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGioiTinh.ForeColor = Color.FromArgb(51, 65, 85);
            lblGioiTinh.Location = new Point(366, 88);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(69, 20);
            lblGioiTinh.TabIndex = 5;
            lblGioiTinh.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Font = new Font("Segoe UI", 9.5F);
            rdoNam.Location = new Point(450, 86);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(65, 25);
            rdoNam.TabIndex = 4;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Segoe UI", 9.5F);
            rdoNu.Location = new Point(524, 86);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(52, 25);
            rdoNu.TabIndex = 5;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDiem.ForeColor = Color.FromArgb(51, 65, 85);
            lblDiem.Location = new Point(700, 88);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(57, 20);
            lblDiem.TabIndex = 6;
            lblDiem.Text = "Điểm *";
            // 
            // numDiem
            // 
            numDiem.DecimalPlaces = 1;
            numDiem.Font = new Font("Segoe UI", 9.5F);
            numDiem.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numDiem.Location = new Point(780, 84);
            numDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numDiem.Name = "numDiem";
            numDiem.Size = new Size(220, 29);
            numDiem.TabIndex = 8;
            numDiem.Value = new decimal(new int[] { 85, 0, 0, 65536 });
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location = new Point(26, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email *";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(140, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 29);
            txtEmail.TabIndex = 2;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDienThoai.ForeColor = Color.FromArgb(51, 65, 85);
            lblDienThoai.Location = new Point(366, 128);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(92, 20);
            lblDienThoai.TabIndex = 8;
            lblDienThoai.Text = "Điện thoại *";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 9.5F);
            txtDienThoai.Location = new Point(464, 119);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(220, 29);
            txtDienThoai.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTrangThai.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrangThai.Location = new Point(700, 128);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(80, 20);
            lblTrangThai.TabIndex = 9;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9.5F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(780, 124);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(220, 29);
            cboTrangThai.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(30, 130, 76);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(765, 162);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 34);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(25, 103, 210);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(870, 162);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(211, 47, 47);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(975, 162);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(71, 85, 105);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1080, 162);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 34);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTimKiem.BackColor = Color.White;
            pnlTimKiem.BorderStyle = BorderStyle.FixedSingle;
            pnlTimKiem.Controls.Add(lblTuKhoa);
            pnlTimKiem.Controls.Add(txtTuKhoa);
            pnlTimKiem.Controls.Add(lblLocLop);
            pnlTimKiem.Controls.Add(cboLocLop);
            pnlTimKiem.Controls.Add(lblLocDiem);
            pnlTimKiem.Controls.Add(numLocDiem);
            pnlTimKiem.Controls.Add(btnTimKiem);
            pnlTimKiem.Controls.Add(btnTatCa);
            pnlTimKiem.Location = new Point(3, 273);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1221, 56);
            pnlTimKiem.TabIndex = 1;
            // 
            // lblTuKhoa
            // 
            lblTuKhoa.AutoSize = true;
            lblTuKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTuKhoa.ForeColor = Color.FromArgb(51, 65, 85);
            lblTuKhoa.Location = new Point(16, 19);
            lblTuKhoa.Name = "lblTuKhoa";
            lblTuKhoa.Size = new Size(66, 20);
            lblTuKhoa.TabIndex = 0;
            lblTuKhoa.Text = "Từ khóa";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Font = new Font("Segoe UI", 9.5F);
            txtTuKhoa.Location = new Point(90, 14);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.PlaceholderText = "Mã, họ tên, email hoặc điện thoại";
            txtTuKhoa.Size = new Size(270, 29);
            txtTuKhoa.TabIndex = 14;
            // 
            // lblLocLop
            // 
            lblLocLop.AutoSize = true;
            lblLocLop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocLop.ForeColor = Color.FromArgb(51, 65, 85);
            lblLocLop.Location = new Point(366, 19);
            lblLocLop.Name = "lblLocLop";
            lblLocLop.Size = new Size(35, 20);
            lblLocLop.TabIndex = 1;
            lblLocLop.Text = "Lớp";
            // 
            // cboLocLop
            // 
            cboLocLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLop.Font = new Font("Segoe UI", 9.5F);
            cboLocLop.FormattingEnabled = true;
            cboLocLop.Location = new Point(402, 15);
            cboLocLop.Name = "cboLocLop";
            cboLocLop.Size = new Size(210, 29);
            cboLocLop.TabIndex = 15;
            // 
            // lblLocDiem
            // 
            lblLocDiem.AutoSize = true;
            lblLocDiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLocDiem.ForeColor = Color.FromArgb(51, 65, 85);
            lblLocDiem.Location = new Point(630, 19);
            lblLocDiem.Name = "lblLocDiem";
            lblLocDiem.Size = new Size(66, 20);
            lblLocDiem.TabIndex = 2;
            lblLocDiem.Text = "Điểm từ";
            // 
            // numLocDiem
            // 
            numLocDiem.DecimalPlaces = 1;
            numLocDiem.Font = new Font("Segoe UI", 9.5F);
            numLocDiem.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numLocDiem.Location = new Point(704, 12);
            numLocDiem.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numLocDiem.Name = "numLocDiem";
            numLocDiem.Size = new Size(80, 29);
            numLocDiem.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.ActiveBorder;
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(802, 10);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(110, 31);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnTatCa
            // 
            btnTatCa.BackColor = Color.White;
            btnTatCa.Cursor = Cursors.Hand;
            btnTatCa.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnTatCa.FlatStyle = FlatStyle.Flat;
            btnTatCa.Font = new Font("Segoe UI", 9.5F);
            btnTatCa.ForeColor = Color.FromArgb(51, 65, 85);
            btnTatCa.Location = new Point(918, 12);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(130, 31);
            btnTatCa.TabIndex = 18;
            btnTatCa.Text = "Hiển thị tất cả";
            btnTatCa.UseVisualStyleBackColor = false;
            btnTatCa.Click += btnTatCa_Click;
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDanhSach.BackColor = Color.White;
            pnlDanhSach.BorderStyle = BorderStyle.FixedSingle;
            pnlDanhSach.Controls.Add(lblTitleDanhSach);
            pnlDanhSach.Controls.Add(lblTongSo);
            pnlDanhSach.Controls.Add(dgvSinhVien);
            pnlDanhSach.Location = new Point(3, 335);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Size = new Size(1221, 332);
            pnlDanhSach.TabIndex = 2;
            // 
            // lblTitleDanhSach
            // 
            lblTitleDanhSach.AutoSize = true;
            lblTitleDanhSach.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTitleDanhSach.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitleDanhSach.Location = new Point(16, 12);
            lblTitleDanhSach.Name = "lblTitleDanhSach";
            lblTitleDanhSach.Size = new Size(185, 25);
            lblTitleDanhSach.TabIndex = 0;
            lblTitleDanhSach.Text = "Danh sách sinh viên";
            // 
            // lblTongSo
            // 
            lblTongSo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTongSo.BackColor = Color.FromArgb(241, 245, 249);
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.ForeColor = Color.FromArgb(15, 23, 42);
            lblTongSo.Location = new Point(1037, 9);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(165, 26);
            lblTongSo.TabIndex = 1;
            lblTongSo.Text = "Tổng số:";
            lblTongSo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.BorderStyle = BorderStyle.None;
            dgvSinhVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colTenSV, colNgaySinh, colGioiTinh, colEmail, colSDT, colDiem, colLop, colTrangThai });
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.GridColor = Color.FromArgb(226, 232, 240);
            dgvSinhVien.Location = new Point(16, 42);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 32;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(1136, 255);
            dgvSinhVien.TabIndex = 19;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            dgvSinhVien.CellContentClick += dgvSinhVien_CellContentClick;
            // 
            // colMaSV
            // 
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            colMaSV.Width = 105;
            // 
            // colTenSV
            // 
            colTenSV.HeaderText = "Họ và tên";
            colTenSV.MinimumWidth = 6;
            colTenSV.Name = "colTenSV";
            colTenSV.ReadOnly = true;
            colTenSV.Width = 160;
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            colNgaySinh.Width = 105;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            colGioiTinh.Width = 85;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 175;
            // 
            // colSDT
            // 
            colSDT.HeaderText = "Điện thoại";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            colSDT.Width = 120;
            // 
            // colDiem
            // 
            colDiem.HeaderText = "Điểm";
            colDiem.MinimumWidth = 6;
            colDiem.Name = "colDiem";
            colDiem.ReadOnly = true;
            colDiem.Width = 75;
            // 
            // colLop
            // 
            colLop.HeaderText = "Lớp";
            colLop.MinimumWidth = 6;
            colLop.Name = "colLop";
            colLop.ReadOnly = true;
            colLop.Width = 185;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            colTrangThai.Width = 120;
            // 
            // pnlStatusBar
            // 
            pnlStatusBar.BackColor = Color.FromArgb(241, 245, 249);
            pnlStatusBar.Dock = DockStyle.Bottom;
            pnlStatusBar.Location = new Point(0, 726);
            pnlStatusBar.Name = "pnlStatusBar";
            pnlStatusBar.Size = new Size(1244, 28);
            pnlStatusBar.TabIndex = 102;
            // 
            // errorProvidermasv
            // 
            errorProvidermasv.ContainerControl = this;
            // 
            // errorProviderdssv
            // 
            errorProviderdssv.ContainerControl = this;
            // 
            // errorProviderhoten
            // 
            errorProviderhoten.ContainerControl = this;
            // 
            // errorProvidertimkiem
            // 
            errorProvidertimkiem.ContainerControl = this;
            // 
            // frmQuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1244, 754);
            Controls.Add(pnlStatusBar);
            Controls.Add(pnlDanhSach);
            Controls.Add(pnlTimKiem);
            Controls.Add(pnlThongTin);
            Controls.Add(pnlSubHeader);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(1100, 720);
            Name = "frmQuanLySinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ứng dụng quản lý sinh viên";
            Load += frmQuanLySinhVien_Load;
            pnlSubHeader.ResumeLayout(false);
            pnlSubHeader.PerformLayout();
            pnlThongTin.ResumeLayout(false);
            pnlThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiem).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLocDiem).EndInit();
            pnlDanhSach.ResumeLayout(false);
            pnlDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidermasv).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderdssv).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderhoten).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidertimkiem).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSubHeader;
        private Label lblHeaderTitle;
        private Panel pnlThongTin;
        private Label lblTitleThongTin;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblLopHoc;
        private ComboBox cboLopHoc;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblDiem;
        private NumericUpDown numDiem;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDienThoai;
        private TextBox txtDienThoai;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Panel pnlTimKiem;
        private Label lblTuKhoa;
        private TextBox txtTuKhoa;
        private Label lblLocLop;
        private ComboBox cboLocLop;
        private Label lblLocDiem;
        private NumericUpDown numLocDiem;
        private Button btnTimKiem;
        private Button btnTatCa;
        private Panel pnlDanhSach;
        private Label lblTitleDanhSach;
        private Label lblTongSo;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colTenSV;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiem;
        private DataGridViewTextBoxColumn colLop;
        private DataGridViewTextBoxColumn colTrangThai;
        private Panel pnlStatusBar;
        private ErrorProvider errorProvidermasv;
        private ErrorProvider errorProviderdssv;
        private ErrorProvider errorProviderhoten;
        private ErrorProvider errorProvidertimkiem;
    }
}
