namespace QuanLyNGK
{
    partial class frmLoaiNV
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpTtin = new DevExpress.XtraEditors.GroupControl();
            this.chkTT = new System.Windows.Forms.CheckBox();
            this.txtTenLoaiNV = new System.Windows.Forms.TextBox();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.txtMaLoaiNV = new System.Windows.Forms.TextBox();
            this.lblML = new System.Windows.Forms.Label();
            this.dgvLoaiNV = new System.Windows.Forms.DataGridView();
            this.MaLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTraCuuLoaiNV = new DevExpress.XtraEditors.GroupControl();
            this.cboMLNV = new System.Windows.Forms.ComboBox();
            this.btnTCTen = new System.Windows.Forms.Button();
            this.btnTCMa = new System.Windows.Forms.Button();
            this.txtMLNV = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblMaLoaiNV = new System.Windows.Forms.Label();
            this.btnThemLoaiNV = new System.Windows.Forms.Button();
            this.btnXoaLoaiNV = new System.Windows.Forms.Button();
            this.btnLamMoiLoaiNV = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grpTtin)).BeginInit();
            this.grpTtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTraCuuLoaiNV)).BeginInit();
            this.grpTraCuuLoaiNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(273, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quản lý loại nhân viên";
            // 
            // grpTtin
            // 
            this.grpTtin.Controls.Add(this.chkTT);
            this.grpTtin.Controls.Add(this.txtTenLoaiNV);
            this.grpTtin.Controls.Add(this.lblTT);
            this.grpTtin.Controls.Add(this.lblTL);
            this.grpTtin.Controls.Add(this.txtMaLoaiNV);
            this.grpTtin.Controls.Add(this.lblML);
            this.grpTtin.Location = new System.Drawing.Point(24, 170);
            this.grpTtin.Name = "grpTtin";
            this.grpTtin.Size = new System.Drawing.Size(371, 163);
            this.grpTtin.TabIndex = 1;
            this.grpTtin.Text = "Thông tin loại nhân viên";
            // 
            // chkTT
            // 
            this.chkTT.AutoSize = true;
            this.chkTT.Location = new System.Drawing.Point(109, 130);
            this.chkTT.Name = "chkTT";
            this.chkTT.Size = new System.Drawing.Size(86, 17);
            this.chkTT.TabIndex = 4;
            this.chkTT.Text = "Còn làm việc";
            this.chkTT.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiNV
            // 
            this.txtTenLoaiNV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiNV.Location = new System.Drawing.Point(109, 79);
            this.txtTenLoaiNV.Name = "txtTenLoaiNV";
            this.txtTenLoaiNV.Size = new System.Drawing.Size(146, 26);
            this.txtTenLoaiNV.TabIndex = 3;
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTT.Location = new System.Drawing.Point(20, 127);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(80, 18);
            this.lblTT.TabIndex = 2;
            this.lblTT.Text = "Trạng thái:";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTL.Location = new System.Drawing.Point(20, 82);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(64, 18);
            this.lblTL.TabIndex = 2;
            this.lblTL.Text = "Tên loại:";
            // 
            // txtMaLoaiNV
            // 
            this.txtMaLoaiNV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiNV.Location = new System.Drawing.Point(109, 33);
            this.txtMaLoaiNV.Name = "txtMaLoaiNV";
            this.txtMaLoaiNV.Size = new System.Drawing.Size(146, 26);
            this.txtMaLoaiNV.TabIndex = 3;
            // 
            // lblML
            // 
            this.lblML.AutoSize = true;
            this.lblML.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblML.Location = new System.Drawing.Point(20, 36);
            this.lblML.Name = "lblML";
            this.lblML.Size = new System.Drawing.Size(58, 18);
            this.lblML.TabIndex = 2;
            this.lblML.Text = "Mã loại:";
            // 
            // dgvLoaiNV
            // 
            this.dgvLoaiNV.AllowUserToAddRows = false;
            this.dgvLoaiNV.AllowUserToDeleteRows = false;
            this.dgvLoaiNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLoaiNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiNV,
            this.TenLoaiNV,
            this.TrangThai});
            this.dgvLoaiNV.Location = new System.Drawing.Point(413, 50);
            this.dgvLoaiNV.MultiSelect = false;
            this.dgvLoaiNV.Name = "dgvLoaiNV";
            this.dgvLoaiNV.ReadOnly = true;
            this.dgvLoaiNV.RowHeadersVisible = false;
            this.dgvLoaiNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiNV.Size = new System.Drawing.Size(303, 283);
            this.dgvLoaiNV.TabIndex = 2;
            this.dgvLoaiNV.SelectionChanged += new System.EventHandler(this.dgvLoaiNV_SelectionChanged);
            // 
            // MaLoaiNV
            // 
            this.MaLoaiNV.DataPropertyName = "MaLoaiNV";
            this.MaLoaiNV.HeaderText = "Loại nhân viên";
            this.MaLoaiNV.Name = "MaLoaiNV";
            this.MaLoaiNV.ReadOnly = true;
            // 
            // TenLoaiNV
            // 
            this.TenLoaiNV.DataPropertyName = "TenLoaiNV";
            this.TenLoaiNV.HeaderText = "Tên loại nhân viên";
            this.TenLoaiNV.Name = "TenLoaiNV";
            this.TenLoaiNV.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // grpTraCuuLoaiNV
            // 
            this.grpTraCuuLoaiNV.Controls.Add(this.cboMLNV);
            this.grpTraCuuLoaiNV.Controls.Add(this.btnTCTen);
            this.grpTraCuuLoaiNV.Controls.Add(this.btnTCMa);
            this.grpTraCuuLoaiNV.Controls.Add(this.txtMLNV);
            this.grpTraCuuLoaiNV.Controls.Add(this.lblTenLoai);
            this.grpTraCuuLoaiNV.Controls.Add(this.lblMaLoaiNV);
            this.grpTraCuuLoaiNV.Location = new System.Drawing.Point(24, 50);
            this.grpTraCuuLoaiNV.Name = "grpTraCuuLoaiNV";
            this.grpTraCuuLoaiNV.Size = new System.Drawing.Size(371, 114);
            this.grpTraCuuLoaiNV.TabIndex = 1;
            this.grpTraCuuLoaiNV.Text = "Tra cứu loại nhân viên";
            // 
            // cboMLNV
            // 
            this.cboMLNV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMLNV.FormattingEnabled = true;
            this.cboMLNV.Location = new System.Drawing.Point(97, 81);
            this.cboMLNV.Name = "cboMLNV";
            this.cboMLNV.Size = new System.Drawing.Size(158, 26);
            this.cboMLNV.TabIndex = 3;
            // 
            // btnTCTen
            // 
            this.btnTCTen.Location = new System.Drawing.Point(279, 80);
            this.btnTCTen.Name = "btnTCTen";
            this.btnTCTen.Size = new System.Drawing.Size(75, 23);
            this.btnTCTen.TabIndex = 2;
            this.btnTCTen.Text = "TCT";
            this.btnTCTen.UseVisualStyleBackColor = true;
            // 
            // btnTCMa
            // 
            this.btnTCMa.Location = new System.Drawing.Point(279, 35);
            this.btnTCMa.Name = "btnTCMa";
            this.btnTCMa.Size = new System.Drawing.Size(75, 23);
            this.btnTCMa.TabIndex = 2;
            this.btnTCMa.Text = "TCM";
            this.btnTCMa.UseVisualStyleBackColor = true;
            // 
            // txtMLNV
            // 
            this.txtMLNV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLNV.Location = new System.Drawing.Point(97, 33);
            this.txtMLNV.Name = "txtMLNV";
            this.txtMLNV.Size = new System.Drawing.Size(158, 26);
            this.txtMLNV.TabIndex = 1;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoai.Location = new System.Drawing.Point(20, 81);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(64, 18);
            this.lblTenLoai.TabIndex = 0;
            this.lblTenLoai.Text = "Tên loại:";
            // 
            // lblMaLoaiNV
            // 
            this.lblMaLoaiNV.AutoSize = true;
            this.lblMaLoaiNV.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiNV.Location = new System.Drawing.Point(20, 36);
            this.lblMaLoaiNV.Name = "lblMaLoaiNV";
            this.lblMaLoaiNV.Size = new System.Drawing.Size(58, 18);
            this.lblMaLoaiNV.TabIndex = 0;
            this.lblMaLoaiNV.Text = "Mã loại:";
            // 
            // btnThemLoaiNV
            // 
            this.btnThemLoaiNV.Location = new System.Drawing.Point(24, 339);
            this.btnThemLoaiNV.Name = "btnThemLoaiNV";
            this.btnThemLoaiNV.Size = new System.Drawing.Size(75, 38);
            this.btnThemLoaiNV.TabIndex = 3;
            this.btnThemLoaiNV.Text = "Thêm";
            this.btnThemLoaiNV.UseVisualStyleBackColor = true;
            this.btnThemLoaiNV.Click += new System.EventHandler(this.btnThemLoaiNV_Click);
            // 
            // btnXoaLoaiNV
            // 
            this.btnXoaLoaiNV.Location = new System.Drawing.Point(221, 339);
            this.btnXoaLoaiNV.Name = "btnXoaLoaiNV";
            this.btnXoaLoaiNV.Size = new System.Drawing.Size(75, 38);
            this.btnXoaLoaiNV.TabIndex = 3;
            this.btnXoaLoaiNV.Text = "Xóa";
            this.btnXoaLoaiNV.UseVisualStyleBackColor = true;
            this.btnXoaLoaiNV.Click += new System.EventHandler(this.btnXoaLoaiNV_Click);
            // 
            // btnLamMoiLoaiNV
            // 
            this.btnLamMoiLoaiNV.Location = new System.Drawing.Point(320, 339);
            this.btnLamMoiLoaiNV.Name = "btnLamMoiLoaiNV";
            this.btnLamMoiLoaiNV.Size = new System.Drawing.Size(75, 38);
            this.btnLamMoiLoaiNV.TabIndex = 3;
            this.btnLamMoiLoaiNV.Text = "Làm mới";
            this.btnLamMoiLoaiNV.UseVisualStyleBackColor = true;
            this.btnLamMoiLoaiNV.Click += new System.EventHandler(this.btnLamMoiLoaiNV_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(661, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(474, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(600, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatLoaiNV
            // 
            this.btnCapNhatLoaiNV.Location = new System.Drawing.Point(121, 339);
            this.btnCapNhatLoaiNV.Name = "btnCapNhatLoaiNV";
            this.btnCapNhatLoaiNV.Size = new System.Drawing.Size(75, 38);
            this.btnCapNhatLoaiNV.TabIndex = 3;
            this.btnCapNhatLoaiNV.Text = "Cập nhật";
            this.btnCapNhatLoaiNV.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiNV.Click += new System.EventHandler(this.btnCapNhatLoaiNV_Click);
            // 
            // frmLoaiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLamMoiLoaiNV);
            this.Controls.Add(this.btnCapNhatLoaiNV);
            this.Controls.Add(this.btnXoaLoaiNV);
            this.Controls.Add(this.btnThemLoaiNV);
            this.Controls.Add(this.dgvLoaiNV);
            this.Controls.Add(this.grpTraCuuLoaiNV);
            this.Controls.Add(this.grpTtin);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiNV";
            this.Text = "frmLoaiNV";
            this.Load += new System.EventHandler(this.frmLoaiNV_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grpTtin)).EndInit();
            this.grpTtin.ResumeLayout(false);
            this.grpTtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTraCuuLoaiNV)).EndInit();
            this.grpTraCuuLoaiNV.ResumeLayout(false);
            this.grpTraCuuLoaiNV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grpTtin;
        private System.Windows.Forms.TextBox txtTenLoaiNV;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.TextBox txtMaLoaiNV;
        private System.Windows.Forms.Label lblML;
        private System.Windows.Forms.DataGridView dgvLoaiNV;
        private DevExpress.XtraEditors.GroupControl grpTraCuuLoaiNV;
        private System.Windows.Forms.ComboBox cboMLNV;
        private System.Windows.Forms.Button btnTCTen;
        private System.Windows.Forms.Button btnTCMa;
        private System.Windows.Forms.TextBox txtMLNV;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblMaLoaiNV;
        private System.Windows.Forms.Button btnThemLoaiNV;
        private System.Windows.Forms.Button btnXoaLoaiNV;
        private System.Windows.Forms.Button btnLamMoiLoaiNV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox chkTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Button btnCapNhatLoaiNV;
    }
}