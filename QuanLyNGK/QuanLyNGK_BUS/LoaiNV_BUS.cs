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
    public class LoaiNV_BUS
    {
        public List<LoaiNV_DTO> DanhSachLoaiNV()
        {
            LoaiNV_DAO loainvDAO = new LoaiNV_DAO();
            return loainvDAO.LayDanhSachLoaiNV();
        }
        public string MaLoaiNVTiepTheo()
        {
            LoaiNV_DAO LoainvDAO = new LoaiNV_DAO();
            string MaLoaiNVLonNhat = LoainvDAO.LayMaLoaiNVLonNhat();

            if (string.IsNullOrEmpty(MaLoaiNVLonNhat))
            {
                return "lnv01";
            }
            else
            {
                int maso = int.Parse(MaLoaiNVLonNhat.Replace("lnv", ""));
                return "lnv" + (maso + 1).ToString("00");
            }
        }

        public bool ThemLoaiNV(LoaiNV_DTO LoainvDTO)
        {
            LoaiNV_DAO LoainvDao = new LoaiNV_DAO();
            return LoainvDao.ThemMoiLoaiNV(LoainvDTO);
        }
        public bool CapNhatLoaiNV(LoaiNV_DTO LoainvDTO)
        {
            LoaiNV_DAO LoainvDAO = new LoaiNV_DAO();
            return LoainvDAO.CapNhatLoaiNV(LoainvDTO);
        }
        public bool XoaLoaiNV(LoaiNV_DTO LoainvDTO)
        {
            LoaiNV_DAO LoainvDAO = new LoaiNV_DAO();
            return LoainvDAO.XoaLoaiNV(LoainvDTO);
        }
    }
}
