namespace QuanLyNGK
{
    partial class frmLoaiSP
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
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLamMoiSP = new System.Windows.Forms.Button();
            this.btnXoaLoaiSP = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiSP = new System.Windows.Forms.Button();
            this.btnThemLoaiSP = new System.Windows.Forms.Button();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.grpTraCuuLoaiNV = new DevExpress.XtraEditors.GroupControl();
            this.cboMLSP = new System.Windows.Forms.ComboBox();
            this.btnTCTen = new System.Windows.Forms.Button();
            this.btnTCMa = new System.Windows.Forms.Button();
            this.txtMLSP = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblMaLoaiNV = new System.Windows.Forms.Label();
            this.grpTtin = new DevExpress.XtraEditors.GroupControl();
            this.chkTT = new System.Windows.Forms.CheckBox();
            this.txtTenLoaiSP = new System.Windows.Forms.TextBox();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.txtMaLoaiSP = new System.Windows.Forms.TextBox();
            this.lblML = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colMaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTraCuuLoaiNV)).BeginInit();
            this.grpTraCuuLoaiNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTtin)).BeginInit();
            this.grpTtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(602, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = ">";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(663, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = ">>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(473, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.Location = new System.Drawing.Point(319, 339);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(75, 38);
            this.btnLamMoiSP.TabIndex = 23;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.UseVisualStyleBackColor = true;
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // btnXoaLoaiSP
            // 
            this.btnXoaLoaiSP.Location = new System.Drawing.Point(219, 339);
            this.btnXoaLoaiSP.Name = "btnXoaLoaiSP";
            this.btnXoaLoaiSP.Size = new System.Drawing.Size(75, 38);
            this.btnXoaLoaiSP.TabIndex = 24;
            this.btnXoaLoaiSP.Text = "Xóa";
            this.btnXoaLoaiSP.UseVisualStyleBackColor = true;
            this.btnXoaLoaiSP.Click += new System.EventHandler(this.btnXoaLoaiSP_Click);
            // 
            // btnCapNhatLoaiSP
            // 
            this.btnCapNhatLoaiSP.Location = new System.Drawing.Point(120, 339);
            this.btnCapNhatLoaiSP.Name = "btnCapNhatLoaiSP";
            this.btnCapNhatLoaiSP.Size = new System.Drawing.Size(75, 38);
            this.btnCapNhatLoaiSP.TabIndex = 25;
            this.btnCapNhatLoaiSP.Text = "Cập nhật";
            this.btnCapNhatLoaiSP.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiSP.Click += new System.EventHandler(this.btnCapNhatLoaiSP_Click);
            // 
            // btnThemLoaiSP
            // 
            this.btnThemLoaiSP.Location = new System.Drawing.Point(23, 339);
            this.btnThemLoaiSP.Name = "btnThemLoaiSP";
            this.btnThemLoaiSP.Size = new System.Drawing.Size(75, 38);
            this.btnThemLoaiSP.TabIndex = 26;
            this.btnThemLoaiSP.Text = "Thêm";
            this.btnThemLoaiSP.UseVisualStyleBackColor = true;
            this.btnThemLoaiSP.Click += new System.EventHandler(this.btnThemLoaiSP_Click);
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.AllowUserToAddRows = false;
            this.dgvLoaiSP.AllowUserToDeleteRows = false;
            this.dgvLoaiSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiSP,
            this.colTenLoaiNV,
            this.TrangThai});
            this.dgvLoaiSP.Location = new System.Drawing.Point(412, 50);
            this.dgvLoaiSP.MultiSelect = false;
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.ReadOnly = true;
            this.dgvLoaiSP.RowHeadersVisible = false;
            this.dgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiSP.Size = new System.Drawing.Size(306, 283);
            this.dgvLoaiSP.TabIndex = 18;
            this.dgvLoaiSP.SelectionChanged += new System.EventHandler(this.dgvLoaiSP_SelectionChanged);
            // 
            // grpTraCuuLoaiNV
            // 
            this.grpTraCuuLoaiNV.Controls.Add(this.cboMLSP);
            this.grpTraCuuLoaiNV.Controls.Add(this.btnTCTen);
            this.grpTraCuuLoaiNV.Controls.Add(this.btnTCMa);
            this.grpTraCuuLoaiNV.Controls.Add(this.txtMLSP);
            this.grpTraCuuLoaiNV.Controls.Add(this.lblTenLoai);
            this.grpTraCuuLoaiNV.Controls.Add(this.lblMaLoaiNV);
            this.grpTraCuuLoaiNV.Location = new System.Drawing.Point(23, 50);
            this.grpTraCuuLoaiNV.Name = "grpTraCuuLoaiNV";
            this.grpTraCuuLoaiNV.Size = new System.Drawing.Size(371, 114);
            this.grpTraCuuLoaiNV.TabIndex = 16;
            this.grpTraCuuLoaiNV.Text = "Tra cứu loại sản phẩm";
            // 
            // cboMLSP
            // 
            this.cboMLSP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMLSP.FormattingEnabled = true;
            this.cboMLSP.Location = new System.Drawing.Point(97, 81);
            this.cboMLSP.Name = "cboMLSP";
            this.cboMLSP.Size = new System.Drawing.Size(158, 26);
            this.cboMLSP.TabIndex = 3;
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
            // txtMLSP
            // 
            this.txtMLSP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLSP.Location = new System.Drawing.Point(97, 33);
            this.txtMLSP.Name = "txtMLSP";
            this.txtMLSP.Size = new System.Drawing.Size(158, 26);
            this.txtMLSP.TabIndex = 1;
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
            // grpTtin
            // 
            this.grpTtin.Controls.Add(this.chkTT);
            this.grpTtin.Controls.Add(this.txtTenLoaiSP);
            this.grpTtin.Controls.Add(this.lblTT);
            this.grpTtin.Controls.Add(this.lblTL);
            this.grpTtin.Controls.Add(this.txtMaLoaiSP);
            this.grpTtin.Controls.Add(this.lblML);
            this.grpTtin.Location = new System.Drawing.Point(23, 170);
            this.grpTtin.Name = "grpTtin";
            this.grpTtin.Size = new System.Drawing.Size(371, 163);
            this.grpTtin.TabIndex = 17;
            this.grpTtin.Text = "Thông tin loại sản phẩm";
            // 
            // chkTT
            // 
            this.chkTT.AutoSize = true;
            this.chkTT.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTT.Location = new System.Drawing.Point(109, 127);
            this.chkTT.Name = "chkTT";
            this.chkTT.Size = new System.Drawing.Size(81, 22);
            this.chkTT.TabIndex = 5;
            this.chkTT.Text = "Còn bán";
            this.chkTT.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiSP
            // 
            this.txtTenLoaiSP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiSP.Location = new System.Drawing.Point(109, 79);
            this.txtTenLoaiSP.Name = "txtTenLoaiSP";
            this.txtTenLoaiSP.Size = new System.Drawing.Size(146, 26);
            this.txtTenLoaiSP.TabIndex = 3;
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
            // txtMaLoaiSP
            // 
            this.txtMaLoaiSP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiSP.Location = new System.Drawing.Point(109, 33);
            this.txtMaLoaiSP.Name = "txtMaLoaiSP";
            this.txtMaLoaiSP.Size = new System.Drawing.Size(146, 26);
            this.txtMaLoaiSP.TabIndex = 3;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(272, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(212, 23);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Quản lý loại sản phẩm";
            // 
            // colMaLoaiSP
            // 
            this.colMaLoaiSP.DataPropertyName = "MaLoaiSP";
            this.colMaLoaiSP.HeaderText = "Loại sản phẩm";
            this.colMaLoaiSP.Name = "colMaLoaiSP";
            this.colMaLoaiSP.ReadOnly = true;
            this.colMaLoaiSP.Width = 101;
            // 
            // colTenLoaiNV
            // 
            this.colTenLoaiNV.DataPropertyName = "TenLoaiSP";
            this.colTenLoaiNV.HeaderText = "Tên loại sản phẩm";
            this.colTenLoaiNV.Name = "colTenLoaiNV";
            this.colTenLoaiNV.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 101;
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 425);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLamMoiSP);
            this.Controls.Add(this.btnXoaLoaiSP);
            this.Controls.Add(this.btnCapNhatLoaiSP);
            this.Controls.Add(this.btnThemLoaiSP);
            this.Controls.Add(this.dgvLoaiSP);
            this.Controls.Add(this.grpTraCuuLoaiNV);
            this.Controls.Add(this.grpTtin);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLoaiSP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTraCuuLoaiNV)).EndInit();
            this.grpTraCuuLoaiNV.ResumeLayout(false);
            this.grpTraCuuLoaiNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTtin)).EndInit();
            this.grpTtin.ResumeLayout(false);
            this.grpTtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLamMoiSP;
        private System.Windows.Forms.Button btnXoaLoaiSP;
        private System.Windows.Forms.Button btnCapNhatLoaiSP;
        private System.Windows.Forms.Button btnThemLoaiSP;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private DevExpress.XtraEditors.GroupControl grpTraCuuLoaiNV;
        private System.Windows.Forms.ComboBox cboMLSP;
        private System.Windows.Forms.Button btnTCTen;
        private System.Windows.Forms.Button btnTCMa;
        private System.Windows.Forms.TextBox txtMLSP;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblMaLoaiNV;
        private DevExpress.XtraEditors.GroupControl grpTtin;
        private System.Windows.Forms.TextBox txtTenLoaiSP;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.TextBox txtMaLoaiSP;
        private System.Windows.Forms.Label lblML;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox chkTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}