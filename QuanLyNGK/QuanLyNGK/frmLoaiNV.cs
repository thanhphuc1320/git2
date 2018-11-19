using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QuanLyNGK_BUS;
using QuanLyNGK_DTO;
using System.IO;


namespace QuanLyNGK
{
    public partial class frmLoaiNV : DevExpress.XtraEditors.XtraForm
    {
        List<LoaiNV_DTO> lsLoaiNV;
        LoaiNV_BUS loaiNVBUS = new LoaiNV_BUS();
        LoaiNV_DTO LoaiNVChon;
        
        public frmLoaiNV()
        {
            InitializeComponent();
        }  

        private void dgvLoaiNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiNV.SelectedRows.Count > 0)
            {
                LoaiNVChon = (LoaiNV_DTO)dgvLoaiNV.SelectedRows[0].DataBoundItem;
            }
            else
            {
                LoaiNVChon = null;
            }
            BindingChiTiet();
        }
            
        

        private void BindingChiTiet()
        {
            if (LoaiNVChon != null)
            {
                txtMaLoaiNV.Text = LoaiNVChon.MaLoaiNV;
                txtTenLoaiNV.Text = LoaiNVChon.TenLoaiNV;
                if (LoaiNVChon.TrangThai == 1)
                {
                    chkTT.Checked = true;
                }
                else
                {
                    chkTT.Checked = false;
                }
            }
            else
            {
                txtMaLoaiNV.Text = null;
                txtTenLoaiNV.Text = null;
                chkTT.Checked = true;
            }
        }
        private void ChiTiet()
        {
            if (LoaiNVChon == null)
            {
                LoaiNVChon = new LoaiNV_DTO();
            }
            LoaiNVChon.MaLoaiNV = txtMaLoaiNV.Text;
            LoaiNVChon.TenLoaiNV = txtTenLoaiNV.Text;
            
            if (chkTT.Checked)
            {
                LoaiNVChon.TrangThai = 1;
            }
            else
            {
                LoaiNVChon.TrangThai = 0;
            }
        }
        
        private void LoadDSLoaiNV()
        {
            loaiNVBUS = new LoaiNV_BUS();
            lsLoaiNV = loaiNVBUS.DanhSachLoaiNV();
            dgvLoaiNV.DataSource = lsLoaiNV;

            cboMLNV.DataSource = lsLoaiNV;
            cboMLNV.ValueMember = "MaLoaiNV";
            cboMLNV.DisplayMember = "TenLoaiNV";
        }

        private void frmLoaiNV_Load_1(object sender, EventArgs e)
        {
            dgvLoaiNV.AutoGenerateColumns = false;
            LoadDSLoaiNV();
        }

        private void btnThemLoaiNV_Click(object sender, EventArgs e)
        {
            if (LoaiNVChon == null) 
            {
                ChiTiet();
                
                bool kq = loaiNVBUS.ThemLoaiNV(LoaiNVChon);
                if (kq)
                {
                    
                    MessageBox.Show(string.Format("Thêm mới loại nhân viên có mã {0} thành công.", LoaiNVChon.MaLoaiNV));
                    LoadDSLoaiNV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                    LoaiNVChon = null;
                }
            }
        }

        private void btnCapNhatLoaiNV_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (loaiNVBUS.CapNhatLoaiNV(LoaiNVChon))
            {

                MessageBox.Show("Cập nhật loại nhân viên thành công");
                LoadDSLoaiNV();
            }
            else
            {
                MessageBox.Show("Cập nhật loại nhân viên thất bại");

            }
        }

        private void btnXoaLoaiNV_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (loaiNVBUS.XoaLoaiNV(LoaiNVChon))
            {
                
                MessageBox.Show("Xóa loại nhân viên thành công");
                LoadDSLoaiNV();
            }
            else
            {
                MessageBox.Show("Xóa loại nhân viên thất bại");

            }
        }

        private void btnLamMoiLoaiNV_Click(object sender, EventArgs e)
        {
            dgvLoaiNV.ClearSelection();
            string maloaitieptheo = loaiNVBUS.MaLoaiNVTiepTheo();
            LoaiNVChon = null;
            txtMaLoaiNV.Text = maloaitieptheo;
            txtTenLoaiNV.Text = null;
            chkTT.Checked = true;
        }
    }
}