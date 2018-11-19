using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNGK_DTO;
using QuanLyNGK_BUS;
using Microsoft.Reporting.WinForms;

namespace QuanLyNGK
{
    public partial class frmXemBaoCao : Form
    {
        List<SanPham_DTO> lsTatCaSanPham;
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            this.rpvBC.RefreshReport();
        }

        public void XemTatCaSP (List<SanPham_DTO> lsSP)
        {
            this.rpvBC.LocalReport.ReportEmbeddedResource = "QuanLyNGK.rptTatCaSP.rdlc";

            ReportDataSource dl = new ReportDataSource("dsSP", lsSP);
            this.rpvBC.LocalReport.DataSources.Add(dl);

            this.rpvBC.RefreshReport();

        }
        
        internal void XemDanhsachSPtheoLoai(List<SanPham_DTO> SPtheoLoai, LoaiSP_DTO loaispchon)
        {
            this.rpvBC.LocalReport.ReportEmbeddedResource = "QuanLyNGK.rptXemSPTheoLoai.rdlc";


            ReportDataSource dl = new ReportDataSource("dsSP", SPtheoLoai);
            this.rpvBC.LocalReport.DataSources.Add(dl);
            this.rpvBC.LocalReport.SetParameters(new ReportParameter("paLoaiSP", loaispchon.TenLoaiSP));

            this.rpvBC.RefreshReport();

        }
        public void NhomSPtheoLoai()
        {
            List<LoaiSP_DTO> lsLoaiSP = (new LoaiSP_BUS()).DanhSachLoaiSP();
            lsTatCaSanPham = (new SanPham_BUS()).DanhSachSanPham();

            rpvBC.LocalReport.ReportEmbeddedResource = "QuanLyNGK.rptNhomSPtheoLoai.rdlc";
            rpvBC.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LayDSSPSubRPT);
            rpvBC.LocalReport.DataSources.Add(new ReportDataSource("dsLoaiSP", lsLoaiSP));

            rpvBC.RefreshReport();
        }

        private void LayDSSPSubRPT(object sender, SubreportProcessingEventArgs e)
        {
           // lấy mã loại
            string maLoaiSP = e.Parameters["paLoaiSP"].Values[0].ToString();

            List<SanPham_DTO> lsSanPham = lsTatCaSanPham.FindAll(o => o.LoaiSP == maLoaiSP);

            e.DataSources.Add(new ReportDataSource("dsSP", lsSanPham));
        }


        
    }
}
