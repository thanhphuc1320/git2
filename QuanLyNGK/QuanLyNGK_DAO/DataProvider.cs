using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNGK_DAO
{
    public class DataProvider
    {
        private static string strKetNoi = @"Data Source=.;Initial Catalog=NGK;Integrated Security=True;";

        public static SqlConnection TaoKetNoi()
        {
            SqlConnection conn = new SqlConnection(strKetNoi);
            conn.Open();
            return conn;
        }

        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlConnection con)
        {
            SqlCommand com = new SqlCommand(strTruyVan, con);
            return com.ExecuteReader();
        }
        public static bool ThucThiCauLenh(String strCauLenh, SqlParameter[] arrparamas, SqlConnection ketnoi)
        {
            SqlCommand com = new SqlCommand(strCauLenh, ketnoi);
            com.Parameters.AddRange(arrparamas);
            int iketqua = com.ExecuteNonQuery();
            return iketqua > 0;
        }
        public static SqlDataReader TruyVanDuLieu(string strTruyVan, SqlParameter[] param, SqlConnection conn)
        {
            SqlCommand com = new SqlCommand(strTruyVan, conn);
            com.Parameters.AddRange(param);
            return com.ExecuteReader();
        }
    }
}
