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
    public partial class frmLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        List<LoaiSP_DTO> lsLoaiSP;
        LoaiSP_BUS loaiSPBUS = new LoaiSP_BUS();
        LoaiSP_DTO LoaiSPChon;
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void dgvLoaiSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiSP.SelectedRows.Count > 0)
            {
                LoaiSPChon = (LoaiSP_DTO)dgvLoaiSP.SelectedRows[0].DataBoundItem;
            }
            else
            {
                LoaiSPChon = null;
            }
            BindingChiTiet();
        }

        private void BindingChiTiet()
        {
            if (LoaiSPChon != null)
            {
                txtMaLoaiSP.Text = LoaiSPChon.MaLoaiSP;
                txtTenLoaiSP.Text = LoaiSPChon.TenLoaiSP;
                if (LoaiSPChon.TrangThai == 1)
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
                txtMaLoaiSP.Text = null;
                txtTenLoaiSP.Text = null;
                chkTT.Checked = true;
            }
        }
        private void ChiTiet()
        {
            if (LoaiSPChon == null)
            {
                LoaiSPChon = new LoaiSP_DTO();
            }
            LoaiSPChon.MaLoaiSP = txtMaLoaiSP.Text;
            LoaiSPChon.TenLoaiSP = txtTenLoaiSP.Text;

            if (chkTT.Checked)
            {
                LoaiSPChon.TrangThai = 1;
            }
            else
            {
                LoaiSPChon.TrangThai = 0;
            }
        }

        private void LoadDSLoaiSP()
        {
            loaiSPBUS = new LoaiSP_BUS();
            lsLoaiSP = loaiSPBUS.DanhSachLoaiSP();
            dgvLoaiSP.DataSource = lsLoaiSP;

            cboMLSP.DataSource = lsLoaiSP;
            cboMLSP.ValueMember = "MaLoaiSP";
            cboMLSP.DisplayMember = "TenLoaiSP";
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            dgvLoaiSP.AutoGenerateColumns = false;
            LoadDSLoaiSP();
        }

        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            if (LoaiSPChon == null)
            {
                ChiTiet();

                bool kq = loaiSPBUS.ThemLoaiSP(LoaiSPChon);
                if (kq)
                {

                    MessageBox.Show(string.Format("Thêm mới loại sản phẩm có mã {0} thành công.", LoaiSPChon.MaLoaiSP));
                    LoadDSLoaiSP();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                    LoaiSPChon = null;
                }
            }
        }

        private void btnCapNhatLoaiSP_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (loaiSPBUS.CapNhatLoaiSP(LoaiSPChon))
            {

                MessageBox.Show("Cập nhật loại sản phẩm thành công");
                LoadDSLoaiSP();
            }
            else
            {
                MessageBox.Show("Cập nhật loại sản phẩm thất bại");

            }
        }

        private void btnXoaLoaiSP_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (loaiSPBUS.XoaLoaiSP(LoaiSPChon))
            {

                MessageBox.Show("Xóa loại sản phẩm thành công");
                LoadDSLoaiSP();
            }
            else
            {
                MessageBox.Show("Xóa loại sản phẩm thất bại");

            }
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            dgvLoaiSP.ClearSelection();
            string maloaitieptheo = loaiSPBUS.MaLoaiSPTiepTheo();
            LoaiSPChon = null;
            txtMaLoaiSP.Text = maloaitieptheo;
            txtTenLoaiSP.Text = null;
            chkTT.Checked = true;
        }
    }
}