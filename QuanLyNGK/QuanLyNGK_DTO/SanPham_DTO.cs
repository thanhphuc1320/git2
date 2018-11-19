using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNGK_DTO
{
    public class SanPham_DTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public string NCC { get; set; }
        public int GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string HinhAnhSP { get; set; }
        public DateTime HanSuDung { get; set; }
        public int TrangThai { get; set; }   
    }
}
