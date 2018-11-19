using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyNGK_DTO;

namespace QuanLyNGK_DAO
{
    public class LoaiSP_DAO
    {
        public List<LoaiSP_DTO> LayDanhSachLoaiSP()
        {
            List<LoaiSP_DTO> lsKQ = new List<LoaiSP_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From LOAISP Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                LoaiSP_DTO loaisp = new LoaiSP_DTO();
                loaisp.MaLoaiSP = sdr["MaLoaiSP"].ToString();
                loaisp.TenLoaiSP = sdr["TenLoaiSP"].ToString();
                loaisp.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsKQ.Add(loaisp);
            }

            sdr.Close();
            conn.Close();


            return lsKQ;
        }
        public string LayMaLoaiSPLonNhat()
        {
            string strTruyVan = "Select Max(MaLoaiSP) from LOAISP";
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
        public bool ThemMoiLoaiSP(LoaiSP_DTO LoaispDTO)
        {

            string strInsert = "Insert into LOAISP (MaLoaiSP, TenLoaiSP, TrangThai)"
                + "Values ("
                + "@MaLoaiSP, @TenLoaiSP, 1)";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaLoaiSP", LoaispDTO.MaLoaiSP));
            lsparamas.Add(new SqlParameter("@TenLoaiSP", LoaispDTO.TenLoaiSP));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strInsert, lsparamas.ToArray(), con);
            con.Close();
            return thucthi;
        }
        public bool CapNhatLoaiSP(LoaiSP_DTO LoaispDTO)
        {
            string strUpdate = "UPDATE LOAISP set TenLoaiSP = @TenLoaiSP,TrangThai = 1" +
                "WHERE MaLoaiSP = @MaLoaiSP";

            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaLoaiSP", LoaispDTO.MaLoaiSP));
            lsparamas.Add(new SqlParameter("@TenLoaiSP", LoaispDTO.TenLoaiSP));
            lsparamas.Add(new SqlParameter("@TrangThai", LoaispDTO.TrangThai));

            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strUpdate, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }

        public bool XoaLoaiSP(LoaiSP_DTO LoaispDTO)
        {
            string strDelete = "delete LOAISP where MaLoaiSP = @MaLoaiSP";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaLoaiSP", LoaispDTO.MaLoaiSP));
            lsparamas.Add(new SqlParameter("@TenLoaiSP", LoaispDTO.TenLoaiSP));
            lsparamas.Add(new SqlParameter("@TrangThai", LoaispDTO.TrangThai));


            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strDelete, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }
    }
}
