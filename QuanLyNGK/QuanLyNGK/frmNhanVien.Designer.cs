namespace QuanLyNGK
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.colHANV = new System.Windows.Forms.DataGridViewImageColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTCLoai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTCMa = new System.Windows.Forms.TextBox();
            this.btnTCLoai = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTCTen = new System.Windows.Forms.Button();
            this.txtTCTen = new System.Windows.Forms.TextBox();
            this.btnTCMa = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkTT = new System.Windows.Forms.CheckBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboLoaiNV = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pboHANV = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHANV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý thông tin nhân viên";
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.AllowUserToOrderColumns = true;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHANV,
            this.colMaNV,
            this.colHoTen,
            this.colDiaChi,
            this.colSDT,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colLoaiNV,
            this.colMatKhau,
            this.colTrangThai});
            this.dgvNV.GridColor = System.Drawing.Color.Cyan;
            this.dgvNV.Location = new System.Drawing.Point(12, 264);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(1003, 220);
            this.dgvNV.TabIndex = 10;
            this.dgvNV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNV_CellFormatting);
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);
            // 
            // colHANV
            // 
            this.colHANV.DataPropertyName = "HinhAnhNV";
            this.colHANV.HeaderText = "Ảnh ";
            this.colHANV.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.colHANV.Name = "colHANV";
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã Nhân Viên";
            this.colMaNV.Name = "colMaNV";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHoTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colLoaiNV
            // 
            this.colLoaiNV.DataPropertyName = "LoaiNV";
            this.colLoaiNV.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colLoaiNV.HeaderText = "Loại nhân viên";
            this.colLoaiNV.Name = "colLoaiNV";
            this.colLoaiNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.Name = "colMatKhau";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.Name = "colTrangThai";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Loại NV:";
            // 
            // cboTCLoai
            // 
            this.cboTCLoai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTCLoai.FormattingEnabled = true;
            this.cboTCLoai.Location = new System.Drawing.Point(102, 100);
            this.cboTCLoai.Name = "cboTCLoai";
            this.cboTCLoai.Size = new System.Drawing.Size(162, 24);
            this.cboTCLoai.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã NV:";
            // 
            // txtTCMa
            // 
            this.txtTCMa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCMa.Location = new System.Drawing.Point(102, 27);
            this.txtTCMa.Name = "txtTCMa";
            this.txtTCMa.Size = new System.Drawing.Size(162, 23);
            this.txtTCMa.TabIndex = 17;
            // 
            // btnTCLoai
            // 
            this.btnTCLoai.BackColor = System.Drawing.Color.White;
            this.btnTCLoai.Image = global::QuanLyNGK.Properties.Resources.SearchIcon;
            this.btnTCLoai.Location = new System.Drawing.Point(224, 146);
            this.btnTCLoai.Name = "btnTCLoai";
            this.btnTCLoai.Size = new System.Drawing.Size(75, 41);
            this.btnTCLoai.TabIndex = 33;
            this.btnTCLoai.Text = "Loại NV";
            this.btnTCLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTCLoai.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Họ tên:";
            // 
            // btnTCTen
            // 
            this.btnTCTen.BackColor = System.Drawing.Color.White;
            this.btnTCTen.Image = global::QuanLyNGK.Properties.Resources.SearchIcon;
            this.btnTCTen.Location = new System.Drawing.Point(121, 146);
            this.btnTCTen.Name = "btnTCTen";
            this.btnTCTen.Size = new System.Drawing.Size(75, 41);
            this.btnTCTen.TabIndex = 31;
            this.btnTCTen.Text = "Tên NV";
            this.btnTCTen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTCTen.UseVisualStyleBackColor = false;
            // 
            // txtTCTen
            // 
            this.txtTCTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCTen.Location = new System.Drawing.Point(102, 66);
            this.txtTCTen.Name = "txtTCTen";
            this.txtTCTen.Size = new System.Drawing.Size(162, 23);
            this.txtTCTen.TabIndex = 20;
            // 
            // btnTCMa
            // 
            this.btnTCMa.BackColor = System.Drawing.Color.White;
            this.btnTCMa.Image = global::QuanLyNGK.Properties.Resources.SearchIcon;
            this.btnTCMa.Location = new System.Drawing.Point(20, 146);
            this.btnTCMa.Name = "btnTCMa";
            this.btnTCMa.Size = new System.Drawing.Size(75, 41);
            this.btnTCMa.TabIndex = 30;
            this.btnTCMa.Text = "Mã NV";
            this.btnTCMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTCMa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTCMa.UseVisualStyleBackColor = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chkTT);
            this.groupControl1.Controls.Add(this.dtpNgSinh);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.radNu);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.radNam);
            this.groupControl1.Controls.Add(this.txtMK);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.cboLoaiNV);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.txtSDT);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.pboHANV);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.lblNgaySinh);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Location = new System.Drawing.Point(12, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(679, 209);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông tin nhân viên";
            // 
            // chkTT
            // 
            this.chkTT.AutoSize = true;
            this.chkTT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTT.Location = new System.Drawing.Point(567, 26);
            this.chkTT.Name = "chkTT";
            this.chkTT.Size = new System.Drawing.Size(74, 20);
            this.chkTT.TabIndex = 37;
            this.chkTT.Text = "Còn làm";
            this.chkTT.UseVisualStyleBackColor = true;
            // 
            // dtpNgSinh
            // 
            this.dtpNgSinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgSinh.Location = new System.Drawing.Point(327, 56);
            this.dtpNgSinh.Name = "dtpNgSinh";
            this.dtpNgSinh.Size = new System.Drawing.Size(134, 23);
            this.dtpNgSinh.TabIndex = 36;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(71, 23);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(162, 23);
            this.txtMaNV.TabIndex = 17;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(404, 24);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(42, 20);
            this.radNu.TabIndex = 35;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã NV:";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(341, 24);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(52, 20);
            this.radNam.TabIndex = 35;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(327, 132);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(134, 23);
            this.txtMK.TabIndex = 19;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(378, 165);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 29);
            this.btnLamMoi.TabIndex = 34;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(71, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(162, 23);
            this.txtHoTen.TabIndex = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(263, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiNV.FormattingEnabled = true;
            this.cboLoaiNV.Location = new System.Drawing.Point(327, 95);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Size = new System.Drawing.Size(134, 24);
            this.cboLoaiNV.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(148, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(71, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(162, 23);
            this.txtDiaChi.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(71, 133);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 23);
            this.txtSDT.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(260, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mật khẩu:";
            // 
            // pboHANV
            // 
            this.pboHANV.BackColor = System.Drawing.Color.Yellow;
            this.pboHANV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboHANV.Image = global::QuanLyNGK.Properties.Resources._default;
            this.pboHANV.Location = new System.Drawing.Point(491, 56);
            this.pboHANV.Name = "pboHANV";
            this.pboHANV.Size = new System.Drawing.Size(157, 135);
            this.pboHANV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHANV.TabIndex = 24;
            this.pboHANV.TabStop = false;
            this.pboHANV.Click += new System.EventHandler(this.pboHANV_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "SĐT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(488, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Họ tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(260, 61);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(68, 16);
            this.lblNgaySinh.TabIndex = 27;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Loại NV:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.cboTCLoai);
            this.groupControl2.Controls.Add(this.btnTCMa);
            this.groupControl2.Controls.Add(this.txtTCTen);
            this.groupControl2.Controls.Add(this.txtTCMa);
            this.groupControl2.Controls.Add(this.btnTCTen);
            this.groupControl2.Controls.Add(this.btnTCLoai);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Location = new System.Drawing.Point(697, 49);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(318, 209);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Tra cứu nhân viên";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(897, 490);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(958, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(73, 490);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 561);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvNV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHANV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTCLoai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTCMa;
        private System.Windows.Forms.Button btnTCLoai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnTCTen;
        private System.Windows.Forms.TextBox txtTCTen;
        private System.Windows.Forms.Button btnTCMa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cboLoaiNV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pboHANV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkTT;
        private System.Windows.Forms.DataGridViewImageColumn colHANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
    }
}