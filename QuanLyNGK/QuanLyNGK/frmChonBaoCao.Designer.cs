namespace QuanLyNGK
{
    partial class frmChonBaoCao
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
            this.rdbTatca = new System.Windows.Forms.RadioButton();
            this.rdbSPtheoLoai = new System.Windows.Forms.RadioButton();
            this.rdbNhomtheoLoai = new System.Windows.Forms.RadioButton();
            this.rdpHoadon = new System.Windows.Forms.RadioButton();
            this.cboSPtheoLoai = new System.Windows.Forms.ComboBox();
            this.cboHoadon = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // rdbTatca
            // 
            this.rdbTatca.AutoSize = true;
            this.rdbTatca.Location = new System.Drawing.Point(119, 83);
            this.rdbTatca.Name = "rdbTatca";
            this.rdbTatca.Size = new System.Drawing.Size(178, 17);
            this.rdbTatca.TabIndex = 1;
            this.rdbTatca.TabStop = true;
            this.rdbTatca.Text = "Xem danh sách tất cả sản phẩm";
            this.rdbTatca.UseVisualStyleBackColor = true;
            // 
            // rdbSPtheoLoai
            // 
            this.rdbSPtheoLoai.AutoSize = true;
            this.rdbSPtheoLoai.Location = new System.Drawing.Point(119, 152);
            this.rdbSPtheoLoai.Name = "rdbSPtheoLoai";
            this.rdbSPtheoLoai.Size = new System.Drawing.Size(190, 17);
            this.rdbSPtheoLoai.TabIndex = 2;
            this.rdbSPtheoLoai.TabStop = true;
            this.rdbSPtheoLoai.Text = "Danh sách các sản phẩm theo loại";
            this.rdbSPtheoLoai.UseVisualStyleBackColor = true;
            // 
            // rdbNhomtheoLoai
            // 
            this.rdbNhomtheoLoai.AutoSize = true;
            this.rdbNhomtheoLoai.Location = new System.Drawing.Point(119, 227);
            this.rdbNhomtheoLoai.Name = "rdbNhomtheoLoai";
            this.rdbNhomtheoLoai.Size = new System.Drawing.Size(145, 17);
            this.rdbNhomtheoLoai.TabIndex = 3;
            this.rdbNhomtheoLoai.TabStop = true;
            this.rdbNhomtheoLoai.Text = "Nhóm sản phẩm theo loại";
            this.rdbNhomtheoLoai.UseVisualStyleBackColor = true;
            // 
            // rdpHoadon
            // 
            this.rdpHoadon.AutoSize = true;
            this.rdpHoadon.Location = new System.Drawing.Point(119, 293);
            this.rdpHoadon.Name = "rdpHoadon";
            this.rdpHoadon.Size = new System.Drawing.Size(67, 17);
            this.rdpHoadon.TabIndex = 4;
            this.rdpHoadon.TabStop = true;
            this.rdpHoadon.Text = "Hoá đơn";
            this.rdpHoadon.UseVisualStyleBackColor = true;
            // 
            // cboSPtheoLoai
            // 
            this.cboSPtheoLoai.FormattingEnabled = true;
            this.cboSPtheoLoai.Location = new System.Drawing.Point(434, 152);
            this.cboSPtheoLoai.Name = "cboSPtheoLoai";
            this.cboSPtheoLoai.Size = new System.Drawing.Size(121, 21);
            this.cboSPtheoLoai.TabIndex = 5;
            // 
            // cboHoadon
            // 
            this.cboHoadon.FormattingEnabled = true;
            this.cboHoadon.Location = new System.Drawing.Point(303, 289);
            this.cboHoadon.Name = "cboHoadon";
            this.cboHoadon.Size = new System.Drawing.Size(121, 21);
            this.cboHoadon.TabIndex = 6;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(283, 363);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(141, 51);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 446);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cboHoadon);
            this.Controls.Add(this.cboSPtheoLoai);
            this.Controls.Add(this.rdpHoadon);
            this.Controls.Add(this.rdbNhomtheoLoai);
            this.Controls.Add(this.rdbSPtheoLoai);
            this.Controls.Add(this.rdbTatca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonBaoCao";
            this.Text = "frmChonBaoCao";
            this.Load += new System.EventHandler(this.frmChonBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTatca;
        private System.Windows.Forms.RadioButton rdbSPtheoLoai;
        private System.Windows.Forms.RadioButton rdbNhomtheoLoai;
        private System.Windows.Forms.RadioButton rdpHoadon;
        private System.Windows.Forms.ComboBox cboSPtheoLoai;
        private System.Windows.Forms.ComboBox cboHoadon;
        private System.Windows.Forms.Button btnThongKe;
    }
}