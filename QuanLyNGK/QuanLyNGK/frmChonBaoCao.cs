using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNGK_BUS;
using QuanLyNGK_DTO;

namespace QuanLyNGK
{
    public partial class frmChonBaoCao : Form
    {
        SanPham_BUS sanpham;
        List<SanPham_DTO> lsSP;
        List<LoaiSP_DTO> lsloaiSP;
        LoaiSP_BUS loaispnbus;


        public frmChonBaoCao()
        {
            InitializeComponent();
        }

        private void frmChonBaoCao_Load(object sender, EventArgs e)
        {
            loaispnbus = new LoaiSP_BUS();
            lsloaiSP = loaispnbus.DanhSachLoaiSP();

            cboSPtheoLoai.DataSource = lsloaiSP;
            cboSPtheoLoai.DisplayMember = "TenLoaiSP";
            cboSPtheoLoai.ValueMember = "MaLoaiSP";

            //load danh sach san pham
            sanpham = new SanPham_BUS();
            lsSP = sanpham.DanhSachSanPham();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmXemBaoCao f = new frmXemBaoCao();

            if (rdbTatca.Checked)
            {
                f.XemTatCaSP(lsSP);
            }
            if (rdbSPtheoLoai.Checked)
            {
                LoaiSP_DTO loaispchon = (LoaiSP_DTO)cboSPtheoLoai.SelectedItem;

                List<SanPham_DTO> sptheoloai = lsSP.FindAll(o => o.LoaiSP == loaispchon.MaLoaiSP);
                f.XemDanhsachSPtheoLoai(sptheoloai, loaispchon);
            }
            if (rdbNhomtheoLoai.Checked)
            {
                f.NhomSPtheoLoai();
            }
            

            f.ShowDialog();
        }

      
    }
}
