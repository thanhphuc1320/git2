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
    public class LoaiSP_BUS
    {
        public List<LoaiSP_DTO> DanhSachLoaiSP()
        {
            LoaiSP_DAO loaispDAO = new LoaiSP_DAO();
            return loaispDAO.LayDanhSachLoaiSP();
        }
        public string MaLoaiSPTiepTheo()
        {
            LoaiSP_DAO LoaispDAO = new LoaiSP_DAO();
            string MaLoaiSPLonNhat = LoaispDAO.LayMaLoaiSPLonNhat();

            if (string.IsNullOrEmpty(MaLoaiSPLonNhat))
            {
                return "lsp01";
            }
            else
            {
                int maso = int.Parse(MaLoaiSPLonNhat.Replace("lsp", ""));
                return "lsp" + (maso + 1).ToString("00");
            }
        }

        public bool ThemLoaiSP(LoaiSP_DTO LoaispDTO)
        {
            LoaiSP_DAO LoaispDao = new LoaiSP_DAO();
            return LoaispDao.ThemMoiLoaiSP(LoaispDTO);
        }
        public bool CapNhatLoaiSP(LoaiSP_DTO LoaispDTO)
        {
            LoaiSP_DAO LoaispDAO = new LoaiSP_DAO();
            return LoaispDAO.CapNhatLoaiSP(LoaispDTO);
        }
        public bool XoaLoaiSP(LoaiSP_DTO LoaispDTO)
        {
            LoaiSP_DAO LoaispDAO = new LoaiSP_DAO();
            return LoaispDAO.XoaLoaiSP(LoaispDTO);
        }
    }
}
