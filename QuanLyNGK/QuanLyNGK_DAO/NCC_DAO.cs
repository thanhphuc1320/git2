using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyNGK_DTO;

namespace QuanLyNGK_DAO
{
    public class NCC_DAO
    {
        public List<NCC_DTO> LayDanhSachNCC()
        {
            List<NCC_DTO> lsKQ = new List<NCC_DTO>();
            SqlConnection conn = DataProvider.TaoKetNoi();
            string strTruyVan = "Select * From NHACUNGCAP Where TrangThai = 1";
            SqlDataReader sdr = DataProvider.TruyVanDuLieu(strTruyVan, conn);
            while (sdr.Read())
            {
                NCC_DTO ncc = new NCC_DTO();
                ncc.MaNCC = sdr["MaNCC"].ToString();
                ncc.TenNCC = sdr["TenNCC"].ToString();
                ncc.DiaChi = sdr["DiaChi"].ToString();
                ncc.SDT = sdr["SDT"].ToString();
                ncc.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsKQ.Add(ncc);
            }

            sdr.Close();
            conn.Close();


            return lsKQ;
        }
        public string LayMaNCCLonNhat()
        {
            string strTruyVan = "Select Max(MaNCC) from NHACUNGCAP";
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
        public bool ThemMoiNCC(NCC_DTO nccDTO)
        {

            string strInsert = "Insert into NHACUNGCAP (MaNCC, TenNCC, DiaChi, SDT, TrangThai)"
                + "Values ("
                + "@MaNCC, @TenNCC, @DiaChi, @SDT, 1)";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaNCC", nccDTO.MaNCC));
            lsparamas.Add(new SqlParameter("@TenNCC", nccDTO.TenNCC));
            lsparamas.Add(new SqlParameter("@DiaChi", nccDTO.DiaChi));
            lsparamas.Add(new SqlParameter("@SDT", nccDTO.SDT));

            SqlConnection con = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strInsert, lsparamas.ToArray(), con);
            con.Close();
            return thucthi;
        }
        public bool CapNhatNCC(NCC_DTO nccDTO)
        {
            string strUpdate = "UPDATE NHACUNGCAP set TenNCC = @TenNCC,DiaChi = @DiaChi,SDT = @SDT,TrangThai = 1" +
                "WHERE MaNCC = @MaNCC";

            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaNCC", nccDTO.MaNCC));
            lsparamas.Add(new SqlParameter("@TenNCC", nccDTO.TenNCC));
            lsparamas.Add(new SqlParameter("@DiaChi", nccDTO.DiaChi));
            lsparamas.Add(new SqlParameter("@SDT", nccDTO.SDT));
            lsparamas.Add(new SqlParameter("@TrangThai", nccDTO.TrangThai));

            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strUpdate, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }

        public bool XoaNCC(NCC_DTO nccDTO)
        {
            string strDelete = "delete NHACUNGCAP where MaNCC = @MaNCC";
            List<SqlParameter> lsparamas = new List<SqlParameter>();
            lsparamas.Add(new SqlParameter("@MaNCC", nccDTO.MaNCC));
            lsparamas.Add(new SqlParameter("@TenNCC", nccDTO.TenNCC));
            lsparamas.Add(new SqlParameter("@DiaChi", nccDTO.DiaChi));
            lsparamas.Add(new SqlParameter("@SDT", nccDTO.SDT));
            lsparamas.Add(new SqlParameter("@TrangThai", nccDTO.TrangThai));


            SqlConnection conn = DataProvider.TaoKetNoi();
            bool thucthi = DataProvider.ThucThiCauLenh(strDelete, lsparamas.ToArray(), conn);
            conn.Close();
            return thucthi;
        }
    }
}
