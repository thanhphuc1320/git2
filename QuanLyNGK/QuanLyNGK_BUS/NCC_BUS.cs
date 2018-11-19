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
    public class NCC_BUS
    {
        public List<NCC_DTO> DanhSachNCC()
        {
            NCC_DAO nccDAO = new NCC_DAO();
            return nccDAO.LayDanhSachNCC();
        }
        public string MaNCCTiepTheo()
        {
            NCC_DAO nccDAO = new NCC_DAO();
            string MaNCCLonNhat = nccDAO.LayMaNCCLonNhat();

            if (string.IsNullOrEmpty(MaNCCLonNhat))
            {
                return "ncc01";
            }
            else
            {
                int maso = int.Parse(MaNCCLonNhat.Replace("ncc", ""));
                return "ncc" + (maso + 1).ToString("00");
            }
        }

        public bool ThemNCC(NCC_DTO nccDTO)
        {
            NCC_DAO nccDao = new NCC_DAO();
            return nccDao.ThemMoiNCC(nccDTO);
        }
        public bool CapNhatNCC(NCC_DTO nccDTO)
        {
            NCC_DAO nccDao = new NCC_DAO();
            return nccDao.CapNhatNCC(nccDTO);
        }
        public bool XoaNCC(NCC_DTO nccDTO)
        {
            NCC_DAO nccDao = new NCC_DAO();
            return nccDao.XoaNCC(nccDTO);
        }
    }
}
