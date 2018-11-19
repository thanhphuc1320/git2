using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNGK_DTO;

namespace QuanLyNGK_DAO
{
    public class LoaiNV_DAO
    {
        public List<LoaiNV_DTO> LayDanhSachLoaiNV()
        {
            List<LoaiNV_DTO> lsKQ = new List<LoaiNV_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From LOAINV Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                LoaiNV_DTO loainv = new LoaiNV_DTO();              
                loainv.MaLoaiNV = sdr["MaLoaiNV"].ToString();
                loainv.TenLoaiNV = sdr["TenLoaiNV"].ToString();
                loainv.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsKQ.Add(loainv);
            }

            sdr.Close();
            conn.Close();


            return lsKQ;
        }
        public string LayMaLoaiNVLonNhat()
        {
            string strTruyVan = "Select Max(MaLoaiNV) from LOAINV";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            string strKetQua = null;
            if (sdr.Read())
            {
                strKetQua = sdr[0].ToString();
            }
            sdr.Close();
            conn.Close();
            return strKetQua;
        }
        public bool ThemMoiLoaiNV(LoaiNV_DTO LoainvDTO)
        {

            string strInsert = "Insert into LOAINV (MaLoaiNV, TenLoaiNV, TrangThai)"
                + "Values ("
                + "@MaLoaiNV, @TenLoaiNV, 1)";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaLoaiNV", LoainvDTO.MaLoaiNV));
            lsparamas.Add(new SqlParameter("@TenLoaiNV", LoainvDTO.TenLoaiNV));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strInsert, lsparamas.ToArray(), con);
            con.Close();
            return thucthi;
        }
        public bool CapNhatLoaiNV(LoaiNV_DTO LoaivDTO)
        {
            string strUpdate = "UPDATE LOAINV set TenLoaiNV = @TenLoaiNV,TrangThai = 1" +
                "WHERE MaLoaiNV = @MaLoaiNV";

            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaLoaiNV", LoaivDTO.MaLoaiNV));
            lsparamas.Add(new SqlParameter("@TenLoaiNV", LoaivDTO.TenLoaiNV));
            lsparamas.Add(new SqlParameter("@TrangThai", LoaivDTO.TrangThai));

            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strUpdate, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }

        public bool XoaLoaiNV(LoaiNV_DTO LoainvDTO)
        {
            string strDelete = "delete LOAINV where MaLoaiNV = @MaLoaiNV";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaLoaiNV", LoainvDTO.MaLoaiNV));
            lsparamas.Add(new SqlParameter("@TenLoaiNV", LoainvDTO.TenLoaiNV));
            lsparamas.Add(new SqlParameter("@TrangThai", LoainvDTO.TrangThai));


            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strDelete, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }
    }
}
