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
    public class NhanVien_BUS
    {
        public List<NhanVien_DTO> DanhSachNhanVien()
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.LayDanhSachNhanVien();
        }
        public string MaNVTiepTheo()
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            string MaLonNhat = nvDAO.LayMaNVLonNhat();

            if (string.IsNullOrEmpty(MaLonNhat))
            {
                // truong hop k co ma lon nhat
                return "nv01";
            }
            else
            {
                int maso = int.Parse(MaLonNhat.Replace("nv", ""));
                return "nv" + (maso + 1).ToString("00");
            }
        }

        public bool ThemNV(NhanVien_DTO nvDTO)
        {
            NhanVien_DAO nvDao = new NhanVien_DAO();
            return nvDao.ThemMoiNV(nvDTO);
        }
        public bool CapNhapNV(NhanVien_DTO nvDTO)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.CapNhapNV(nvDTO);
        }
        public bool XoaNV(NhanVien_DTO nvDTO)
        {
            NhanVien_DAO nvDAO = new NhanVien_DAO();
            return nvDAO.XoaNV(nvDTO);
        }

  
        
    }
}
