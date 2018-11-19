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
    public class NhanVien_DAO
    {
        public List<NhanVien_DTO> LayDanhSachNhanVien()
        {
            List<NhanVien_DTO> lsKetQua = new List<NhanVien_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();

            string strTruyVan = "Select * From NHANVIEN Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.MaNV = sdr["MaNV"].ToString();//sdr.GetString(sdr.GetOrdinal("MaNV"));
                nv.HoTen = sdr["HoTen"].ToString();
                nv.DiaChi = sdr["DiaChi"].ToString();
                nv.SDT = sdr["SDT"].ToString();
                nv.HinhAnhNV = sdr["HinhAnhNV"].ToString();
                nv.GioiTinh = sdr["GioiTinh"].ToString();
                nv.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                nv.LoaiNV = sdr["LoaiNV"].ToString();
                nv.MatKhau = sdr["MatKhau"].ToString();
                nv.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsKetQua.Add(nv);
            }

            sdr.Close();
            conn.Close();

            return lsKetQua;
        }
        public string LayMaNVLonNhat()
        {
            string strTruyVan = "Select Max(MaNV) from NHANVIEN";
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
        public bool ThemMoiNV(NhanVien_DTO nvDTO)
        {

            string strInsert = "Insert into NHANVIEN (MaNV , HoTen, DiaChi, SDT, HinhAnhNV, GioiTinh, NgaySinh, LoaiNV, MatKhau, TrangThai)"
                + "Values ("
                + "@MaNV, @HoTen, @DiaChi, @SDT, @HinhAnhNV, @GioiTinh, @NgaySinh, @LoaiNV, @MatKhau, 1)";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaNV", nvDTO.MaNV));
            lsparamas.Add(new SqlParameter("@HoTen", nvDTO.HoTen));
            lsparamas.Add(new SqlParameter("@DiaChi", nvDTO.DiaChi));
            lsparamas.Add(new SqlParameter("@SDT", nvDTO.SDT));
            lsparamas.Add(new SqlParameter("@HinhAnhNV", nvDTO.HinhAnhNV));
            lsparamas.Add(new SqlParameter("@GioiTinh", nvDTO.GioiTinh));
            lsparamas.Add(new SqlParameter("@NgaySinh", nvDTO.NgaySinh));
            lsparamas.Add(new SqlParameter("@LoaiNV", nvDTO.LoaiNV));
            lsparamas.Add(new SqlParameter("@MatKhau", nvDTO.MatKhau));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strInsert, lsparamas.ToArray(), con);
            con.Close();
            return thucthi;
        }
        public bool CapNhapNV(NhanVien_DTO nvDTO)
        {
            string strUpdate = "UPDATE NHANVIEN set HoTen = @HoTen,DiaChi = @DiaChi,SDT= @SDT,HinhAnhNV = @HinhAnhNV,GioiTinh = @GioiTinh,NgaySinh = @NgaySinh,LoaiNV=@LoaiNV,MatKhau=@MatKhau,TrangThai = 1" +
                "WHERE MaNV = @MaNV";

            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaNV", nvDTO.MaNV));
            lsparamas.Add(new SqlParameter("@HoTen", nvDTO.HoTen));
            lsparamas.Add(new SqlParameter("@DiaChi", nvDTO.DiaChi));
            lsparamas.Add(new SqlParameter("@SDT", nvDTO.SDT));
            lsparamas.Add(new SqlParameter("@HinhAnhNV", nvDTO.HinhAnhNV));
            lsparamas.Add(new SqlParameter("@GioiTinh", nvDTO.GioiTinh));
            lsparamas.Add(new SqlParameter("@NgaySinh", nvDTO.NgaySinh));
            lsparamas.Add(new SqlParameter("@LoaiNV", nvDTO.LoaiNV));
            lsparamas.Add(new SqlParameter("@MatKhau", nvDTO.MatKhau));
            lsparamas.Add(new SqlParameter("@TrangThai", nvDTO.TrangThai));

            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strUpdate, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }

        public bool XoaNV(NhanVien_DTO nvDTO)
        {
            string strDelete = "delete NHANVIEN where MaNV = @MaNV";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaNV", nvDTO.MaNV));
            lsparamas.Add(new SqlParameter("@HoTen", nvDTO.HoTen));
            lsparamas.Add(new SqlParameter("@DiaChi", nvDTO.DiaChi));
            lsparamas.Add(new SqlParameter("@SDT", nvDTO.SDT));
            lsparamas.Add(new SqlParameter("@HinhAnhNV", nvDTO.HinhAnhNV));
            lsparamas.Add(new SqlParameter("@GioiTinh", nvDTO.GioiTinh));
            lsparamas.Add(new SqlParameter("@NgaySinh", nvDTO.NgaySinh));
            lsparamas.Add(new SqlParameter("@LoaiNV", nvDTO.LoaiNV));
            lsparamas.Add(new SqlParameter("@MatKhau", nvDTO.MatKhau));
            lsparamas.Add(new SqlParameter("@TrangThai", nvDTO.TrangThai));


            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strDelete, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }





        public NhanVien_DTO DangNhap(string strTK, string strMK)
        {
            NhanVien_DTO ketqua = null;
            string strTruyVan = "Select * From NHANVIEN Where MaNV = @MaNV AND MatKhau = @MatKhau AND TrangThai = 1";
            SqlParameter[] dsPars = new SqlParameter[2];
            dsPars[0] = new SqlParameter("@MaNV", strTK);
            dsPars[1] = new SqlParameter("@Password", strMK);

            SqlConnection con = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, dsPars, con);
            if (sdr.Read())
            {
                ketqua = new NhanVien_DTO();
                
                ketqua.MaNV = sdr["MaNV"].ToString();
                ketqua.HoTen = sdr["HoTen"].ToString();
                ketqua.DiaChi = sdr["DiaChi"].ToString();
                ketqua.SDT = sdr["SDT"].ToString();
                ketqua.HinhAnhNV = sdr["HinhAnhNV"].ToString();
                ketqua.GioiTinh = sdr["GioiTinh"].ToString();
                ketqua.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                ketqua.LoaiNV = sdr["LoaiNV"].ToString();
                ketqua.MatKhau = sdr["MatKhau"].ToString();
                ketqua.TrangThai = int.Parse(sdr["TrangThai"].ToString());
            }
            sdr.Close();
            con.Close();
            return ketqua;
        }
    }
}
