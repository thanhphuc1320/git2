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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        List<LoaiNV_DTO> lsLoaiNV;
        List<NhanVien_DTO> lsNV;
        NhanVien_BUS nvBUS = new NhanVien_BUS();
        NhanVien_DTO NVChon;
        string strPathHA = "HinhAnhNV/";

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.AutoGenerateColumns = false;
            LoadDSLoaiNV();
            LoadDSNV();
        }

        private void LoadDSNV()
        {
            lsNV = nvBUS.DanhSachNhanVien();
            dgvNV.DataSource = lsNV;
        }

        private void LoadDSLoaiNV()
        {
            LoaiNV_BUS loaiNVBUS = new LoaiNV_BUS();
            lsLoaiNV = loaiNVBUS.DanhSachLoaiNV();
            cboLoaiNV.DataSource = lsLoaiNV;
            cboLoaiNV.ValueMember = "MaLoaiNV";
            cboLoaiNV.DisplayMember = "TenLoaiNV";

            cboTCLoai.DataSource = lsLoaiNV;
            cboTCLoai.ValueMember = "MaLoaiNV";
            cboTCLoai.DisplayMember = "TenLoaiNV";


            DataGridViewComboBoxColumn cboDGVLoaiNV = (DataGridViewComboBoxColumn)dgvNV.Columns["colLoaiNV"];
            cboDGVLoaiNV.DataSource = lsLoaiNV;
            cboDGVLoaiNV.ValueMember = "MaLoaiNV";
            cboDGVLoaiNV.DisplayMember = "TenLoaiNV";
        }

        private void dgvNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((dgvNV.Columns[e.ColumnIndex]).Name == "colHANV")
            {
                if (File.Exists(e.Value.ToString()))
                {
                    byte[] byteHANV = File.ReadAllBytes(e.Value.ToString());
                    MemoryStream ms = new MemoryStream(byteHANV);
                    e.Value = Image.FromStream(ms);
                }
                else
                {
                    e.Value = null;
                }
            }
        
        }

        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
                NVChon = (NhanVien_DTO)dgvNV.SelectedRows[0].DataBoundItem;
            }
            else
            {
                NVChon = null;
            }
            BindingChiTiet();
        }

        private void BindingChiTiet()
        {
            if (NVChon != null)
            {
                txtMaNV.Text = NVChon.MaNV;
                txtHoTen.Text = NVChon.HoTen;
                txtDiaChi.Text = NVChon.DiaChi;
                txtSDT.Text = NVChon.SDT;
                if (NVChon.GioiTinh == "Nam") {
                    radNam.Checked = true;
                } else {
                    radNu.Checked = true;
                }
                dtpNgSinh.Value = NVChon.NgaySinh;
                cboLoaiNV.SelectedValue = NVChon.LoaiNV;
                txtMK.Text = NVChon.MatKhau;
                if (NVChon.TrangThai == 1)
                {
                    chkTT.Checked = true;
                }
                else
                {
                    chkTT.Checked = false;
                }
                if (File.Exists(NVChon.HinhAnhNV))
                {
                    byte[] byteHANV = File.ReadAllBytes(NVChon.HinhAnhNV);
                    MemoryStream ms = new MemoryStream(byteHANV);
                    pboHANV.Image = Image.FromStream(ms);
                }
                else
                {
                    pboHANV.Image = null;
                }
            }
            else
            {
                txtMaNV.Text = null;
                txtHoTen.Text = null;
                txtDiaChi.Text = null;
                txtSDT.Text = null;
                radNam.Checked = true;
                dtpNgSinh.Value = DateTime.Now;
                cboLoaiNV.SelectedIndex = 0;
                txtMK.Text = null;
                chkTT.Checked = true;        
                pboHANV.Image = null;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNV.ClearSelection();
            string matieptheo = nvBUS.MaNVTiepTheo();
            NVChon = null;
            txtMaNV.Text = matieptheo;
            txtHoTen.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
            radNam.Checked = true;
            dtpNgSinh.Value = DateTime.Now;
            cboLoaiNV.SelectedIndex = 0;
            txtMK.Text = null;
            chkTT.Checked = true;
            pboHANV.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (NVChon == null)
            {
                ChiTiet();
                NVChon.HinhAnhNV = strPathHA + NVChon.MaNV + ".png";
                bool kq = nvBUS.ThemNV(NVChon);
                if (kq)
                {
                    if (pboHANV.Image != null)
                    {
                        pboHANV.Image.Save(NVChon.HinhAnhNV);
                    }
                    MessageBox.Show(string.Format("Thêm mới nhân viên có mã {0} thành công.", NVChon.MaNV));
                    LoadDSNV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                    NVChon = null;
                }
            }
        }

        private void ChiTiet()
        {
            if (NVChon == null)
            {
                NVChon = new NhanVien_DTO();
            }
            NVChon.MaNV = txtMaNV.Text;
            NVChon.HoTen = txtHoTen.Text;
            NVChon.DiaChi = txtDiaChi.Text;
            NVChon.SDT = txtSDT.Text;
            if (radNam.Checked)
            {
                NVChon.GioiTinh = "Nam";
            }
            else
            {
                NVChon.GioiTinh = "Nữ";
            }
            NVChon.NgaySinh = dtpNgSinh.Value;
            NVChon.LoaiNV = cboLoaiNV.SelectedValue.ToString();
            NVChon.MatKhau = txtMK.Text;
            if (chkTT.Checked) {
                NVChon.TrangThai = 1;
            }
            else
            {
                NVChon.TrangThai = 0;
            }
        }

        private void pboHANV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình Ảnh|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                byte[] byteHANV = File.ReadAllBytes(ofd.FileName);
                MemoryStream ms = new MemoryStream(byteHANV);
                pboHANV.Image = Image.FromStream(ms);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (nvBUS.CapNhapNV(NVChon))
            {
                if (pboHANV.Image != null)
                {
                    pboHANV.Image.Save(NVChon.HinhAnhNV);
                }
                MessageBox.Show("Cập nhật nhân viên thành công");
                LoadDSNV();
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ChiTiet();

            if (nvBUS.XoaNV(NVChon))
            {
                if (pboHANV.Image != null)
                {
                    pboHANV.Image.Save(NVChon.HinhAnhNV);
                }
                MessageBox.Show("Xóa nhân viên thành công");
                LoadDSNV();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");

            }
        }

        
    }
}