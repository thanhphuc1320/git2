using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyNGK_DTO;

namespace QuanLyNGK_DAO
{
    public class SanPham_DAO
    {
        public List<SanPham_DTO> LayDanhSachSanPham()
        {
            List<SanPham_DTO> lsKetQua = new List<SanPham_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan = "Select * From SANPHAM Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaSP = sdr["MaSP"].ToString();
                sp.TenSP = sdr["TenSP"].ToString();
                sp.LoaiSP = sdr["LoaiSP"].ToString();
                sp.NCC = sdr["NCC"].ToString();
                sp.GiaBan = int.Parse(sdr["GiaBan"].ToString());
                sp.SoLuongTon = int.Parse(sdr["SoLuongTon"].ToString());
                sp.HinhAnhSP = sdr["HinhAnhSP"].ToString();
                sp.HanSuDung = DateTime.Parse(sdr["HanSuDung"].ToString());
                sp.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsKetQua.Add(sp);
            }

            sdr.Close();
            conn.Close();

            return lsKetQua;
        }
        public string LayMaSPLonNhat()
        {
            string strTruyVan = "Select Max(MaSP) from SANPHAM";
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
        public bool ThemMoiSP(SanPham_DTO spDTO)
        {

            string strInsert = "Insert into SANPHAM (MaSP , TenSP, LoaiSP, NCC, GiaBan, SoLuongTon, HinhAnhSP, HanSuDung, TrangThai)"
                + "Values ("
                + "@MaSP, @TenSP, @LoaiSP, @NCC, @GiaBan, @SoLuongTon, @HinhAnhSP, @HanSuDung, 1)";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaSP", spDTO.MaSP));
            lsparamas.Add(new SqlParameter("@TenSP", spDTO.TenSP));
            lsparamas.Add(new SqlParameter("@LoaiSP", spDTO.LoaiSP));
            lsparamas.Add(new SqlParameter("@NCC", spDTO.NCC));
            lsparamas.Add(new SqlParameter("@GiaBan", spDTO.GiaBan));
            lsparamas.Add(new SqlParameter("@SoLuongTon", spDTO.SoLuongTon));
            lsparamas.Add(new SqlParameter("@HinhAnhSP", spDTO.HinhAnhSP));
            lsparamas.Add(new SqlParameter("@HanSuDung", spDTO.HanSuDung));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strInsert, lsparamas.ToArray(), con);
            con.Close();
            return thucthi;
        }
        public bool CapNhapSP(SanPham_DTO spDTO)
        {
            string strUpdate = "UPDATE SANPHAM set TenSP = @TenSP,LoaiSP = @LoaiSP,NCC= @NCC,GiaBan = @GiaBan,SoLuongTon = @SoLuongTon,HinhAnhSP = @HinhAnhSP,HanSuDung=@HanSuDung,TrangThai = 1" +
                "WHERE MaSP = @MaSP";

            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaSP", spDTO.MaSP));
            lsparamas.Add(new SqlParameter("@TenSP", spDTO.TenSP));
            lsparamas.Add(new SqlParameter("@LoaiSP", spDTO.LoaiSP));
            lsparamas.Add(new SqlParameter("@NCC", spDTO.NCC));
            lsparamas.Add(new SqlParameter("@GiaBan", spDTO.GiaBan));
            lsparamas.Add(new SqlParameter("@SoLuongTon", spDTO.SoLuongTon));
            lsparamas.Add(new SqlParameter("@HinhAnhSP", spDTO.HinhAnhSP));
            lsparamas.Add(new SqlParameter("@HanSuDung", spDTO.HanSuDung));
            lsparamas.Add(new SqlParameter("@TrangThai", spDTO.TrangThai));

            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strUpdate, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }

        public bool XoaSP(SanPham_DTO spDTO)
        {
            string strDelete = "delete SANPHAM where MaSP = @MaSP";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaSP", spDTO.MaSP));
            lsparamas.Add(new SqlParameter("@TenSP", spDTO.TenSP));
            lsparamas.Add(new SqlParameter("@LoaiSP", spDTO.LoaiSP));
            lsparamas.Add(new SqlParameter("@NCC", spDTO.NCC));
            lsparamas.Add(new SqlParameter("@GiaBan", spDTO.GiaBan));
            lsparamas.Add(new SqlParameter("@SoLuongTon", spDTO.SoLuongTon));
            lsparamas.Add(new SqlParameter("@HinhAnhSP", spDTO.HinhAnhSP));
            lsparamas.Add(new SqlParameter("@HanSuDung", spDTO.HanSuDung));
            lsparamas.Add(new SqlParameter("@TrangThai", spDTO.TrangThai));


            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strDelete, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }
    }
}
