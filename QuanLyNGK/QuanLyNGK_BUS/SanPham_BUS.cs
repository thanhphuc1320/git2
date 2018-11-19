using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyNGK_DTO;
using QuanLyNGK_DAO;

namespace QuanLyNGK_BUS
{
    public class SanPham_BUS
    {
        public List<SanPham_DTO> DanhSachSanPham()
        {
            SanPham_DAO spDAO = new SanPham_DAO();
            return spDAO.LayDanhSachSanPham();
        }
        public string MaSPTiepTheo()
        {
            SanPham_DAO spDAO = new SanPham_DAO();
            string MaLonNhat = spDAO.LayMaSPLonNhat();

            if (string.IsNullOrEmpty(MaLonNhat))
            {
                // truong hop k co ma lon nhat
                return "sp01";
            }
            else
            {
                int maso = int.Parse(MaLonNhat.Replace("sp", ""));
                return "sp" + (maso + 1).ToString("00");
            }
        }

        public bool ThemSP(SanPham_DTO spDTO)
        {
            SanPham_DAO spDao = new SanPham_DAO();
            return spDao.ThemMoiSP(spDTO);
        }
        public bool CapNhapSP(SanPham_DTO spDTO)
        {
            SanPham_DAO spDAO = new SanPham_DAO();
            return spDAO.CapNhapSP(spDTO);
        }
        public bool XoaSP(SanPham_DTO spDTO)
        {
            SanPham_DAO spDAO = new SanPham_DAO();
            return spDAO.XoaSP(spDTO);
        }
    }
}
