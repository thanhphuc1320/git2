using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QuanLyNGK_BUS;
using QuanLyNGK_DTO;

namespace QuanLyNGK
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.MdiParent;
            if (txtTK.Text.Trim() == "admin" || txtMK.Text.Trim() == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                f.isDangNhap = true;
                frmMain fcha = (frmMain)this.MdiParent;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
                f.isDangNhap = false;
            }
            
        }
    }
}