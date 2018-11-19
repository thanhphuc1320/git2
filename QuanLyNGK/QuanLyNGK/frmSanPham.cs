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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        List<LoaiSP_DTO> lsLoaiSP;
        List<SanPham_DTO> lsSP;
        List<NCC_DTO> lsNCC;
        SanPham_BUS spBUS = new SanPham_BUS();
        SanPham_DTO SPChon;
        string strPathHA = "HinhAnhSP/";

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSP.AutoGenerateColumns = false;
            LoadDSLoaiSP();
            LoadDSSP();
            LoadDSNCC();
        }

        private void LoadDSNCC()
        {
            NCC_BUS NCCBUS = new NCC_BUS();
            lsNCC = NCCBUS.DanhSachNCC();
            cboLoaiNCC.DataSource = lsNCC;
            cboLoaiNCC.ValueMember = "MaNCC";
            cboLoaiNCC.DisplayMember = "TenNCC";

            DataGridViewComboBoxColumn cboDGVNCC = (DataGridViewComboBoxColumn)dgvSP.Columns["colNCC"];
            cboDGVNCC.DataSource = lsNCC;
            cboDGVNCC.ValueMember = "MaNCC";
            cboDGVNCC.DisplayMember = "TenNCC";
        }
        private void LoadDSSP()
        {
            lsSP = spBUS.DanhSachSanPham();
            dgvSP.DataSource = lsSP;
        }

        private void LoadDSLoaiSP()
        {
            LoaiSP_BUS loaiSPBUS = new LoaiSP_BUS();
            lsLoaiSP = loaiSPBUS.DanhSachLoaiSP();
            cboLoaiSP.DataSource = lsLoaiSP;
            cboLoaiSP.ValueMember = "MaLoaiSP";
            cboLoaiSP.DisplayMember = "TenLoaiSP";

            cboTCLoai.DataSource = lsLoaiSP;
            cboTCLoai.ValueMember = "MaLoaiSP";
            cboTCLoai.DisplayMember = "TenLoaiSP";


            DataGridViewComboBoxColumn cboDGVLoaiSP = (DataGridViewComboBoxColumn)dgvSP.Columns["colLoaiSP"];
            cboDGVLoaiSP.DataSource = lsLoaiSP;
            cboDGVLoaiSP.ValueMember = "MaLoaiSP";
            cboDGVLoaiSP.DisplayMember = "TenLoaiSP";

        }

        private void dgvSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSP.SelectedRows.Count > 0)
            {
                SPChon = (SanPham_DTO)dgvSP.SelectedRows[0].DataBoundItem;
            }
            else
            {
                SPChon = null;
            }
            BindingChiTiet();
        }
        private void BindingChiTiet()
        {
            if (SPChon != null)
            {
                txtMaSP.Text = SPChon.MaSP;
                txtTenSP.Text = SPChon.TenSP;
                txtGiaBan.Text = SPChon.GiaBan.ToString();
                txtSLT.Text = SPChon.SoLuongTon.ToString();
                
                dtpHSD.Value = SPChon.HanSuDung;
                cboLoaiSP.SelectedValue = SPChon.LoaiSP;
                cboLoaiNCC.SelectedValue = SPChon.NCC;
                
                if (SPChon.TrangThai == 1)
                {
                    chkTT.Checked = true;
                }
                else
                {
                    chkTT.Checked = false;
                }
                if (File.Exists(SPChon.HinhAnhSP))
                {
                    byte[] byteHASP = File.ReadAllBytes(SPChon.HinhAnhSP);
                    MemoryStream ms = new MemoryStream(byteHASP);
                    pboHASP.Image = Image.FromStream(ms);
                }
                else
                {
                    pboHASP.Image = null;
                }
            }
            else
            {
                txtMaSP.Text = null;
                txtTenSP.Text = null;
                txtGiaBan.Text = null;
                txtSLT.Text = null;
                
                dtpHSD.Value = DateTime.Now;
                cboLoaiSP.SelectedIndex = 0;
                cboLoaiNCC.SelectedIndex = 0;
                chkTT.Checked = true;
                pboHASP.Image = null;
            }
        }
        private void ChiTiet()
        {
            if (SPChon == null)
            {
                SPChon = new SanPham_DTO();
            }
            SPChon.MaSP = txtMaSP.Text;
            SPChon.TenSP = txtTenSP.Text;
            SPChon.GiaBan = int.Parse(txtGiaBan.Text);
            SPChon.SoLuongTon = int.Parse(txtSLT.Text);

            SPChon.HanSuDung = dtpHSD.Value;
            SPChon.LoaiSP = cboLoaiSP.SelectedValue.ToString();
            SPChon.NCC = cboLoaiNCC.SelectedValue.ToString();
            if (chkTT.Checked)
            {
                SPChon.TrangThai = 1;
            }
            else
            {
                SPChon.TrangThai = 0;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (SPChon == null)
            {
                ChiTiet();
                SPChon.HinhAnhSP = strPathHA + SPChon.MaSP + ".png";
                bool kq = spBUS.ThemSP(SPChon);
                if (kq)
                {
                    if (pboHASP.Image != null)
                    {
                        pboHASP.Image.Save(SPChon.HinhAnhSP);
                    }
                    MessageBox.Show(string.Format("Thêm mới sản phẩm có mã {0} thành công.", SPChon.MaSP));
                    LoadDSSP();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công!");
                    SPChon = null;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (spBUS.CapNhapSP(SPChon))
            {
                if (pboHASP.Image != null)
                {
                    pboHASP.Image.Save(SPChon.HinhAnhSP);
                }
                MessageBox.Show("Cập nhật sản phẩm thành công");
                LoadDSSP();
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (spBUS.XoaSP(SPChon))
            {
                if (pboHASP.Image != null)
                {
                    pboHASP.Image.Save(SPChon.HinhAnhSP);
                }
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadDSSP();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSP.ClearSelection();
            string matieptheo = spBUS.MaSPTiepTheo();
            SPChon = null;
            txtMaSP.Text = matieptheo;
            txtTenSP.Text = null;
            txtGiaBan.Text = null;
            txtSLT.Text = null;
            
            dtpHSD.Value = DateTime.Now;
            cboLoaiSP.SelectedIndex = 0;
            cboLoaiNCC.SelectedIndex = 0;
            chkTT.Checked = true;
            pboHASP.Image = null;
        }

        private void dgvSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvSP.Columns[e.ColumnIndex]).Name == "colHASP")
            {
                if (File.Exists(e.Value.ToString()))
                {
                    byte[] byteHASP = File.ReadAllBytes(e.Value.ToString());
                    MemoryStream ms = new MemoryStream(byteHASP);
                    e.Value = Image.FromStream(ms);
                }
                else
                {
                    e.Value = null;
                }
            }
        }

        private void pboHASP_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình Ảnh|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                byte[] byteHASP = File.ReadAllBytes(ofd.FileName);
                MemoryStream ms = new MemoryStream(byteHASP);
                pboHASP.Image = Image.FromStream(ms);
            }
        }
    }
}