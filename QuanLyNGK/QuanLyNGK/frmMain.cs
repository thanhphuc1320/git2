using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QuanLyNGK_DTO;
using QuanLyNGK_BUS;
using System.IO;

namespace QuanLyNGK
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool isDangNhap;
        public NhanVien_DTO nvDangNhap;
        public frmMain()
        {
            InitializeComponent();
            FormLoad();
            DongMoChucNang(true/*thêm loại nhân viên ở đây*/);
        }
        public void Skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Skin();

            
        }
        private void CloseAllForm() {
            foreach (Form f in this.MdiChildren) {
                f.Close();
            }
        }
        private void FormLoad()
        {
            frmLoad fLoad = new frmLoad();
            fLoad.MdiParent = this;
            fLoad.BringToFront();
            fLoad.Show();
        }

        public void DongMoChucNang(bool e/*loại nhân viên*/)
        {
            btnDN.Enabled = e;
            btnDX.Enabled = !e;
            btnTTin.Enabled = !e;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void btnDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllForm();
            frmDangNhap fDN = new frmDangNhap();
            fDN.MdiParent = this;
            fDN.BringToFront();
            fDN.Show();
        }

        private void btnQLLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllForm();
            frmLoaiNV fLNV = new frmLoaiNV();
            fLNV.MdiParent = this;
            fLNV.BringToFront();
            fLNV.Show();
        }

        private void btnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllForm();
            frmNhanVien fNV = new frmNhanVien();
            fNV.MdiParent = this;
            //fNV.Dock = DockStyle.Fill;
            fNV.BringToFront();
            fNV.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllForm();
            frmLoaiSP fLSP = new frmLoaiSP();
            fLSP.MdiParent = this;
            //fNV.Dock = DockStyle.Fill;
            fLSP.BringToFront();
            fLSP.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CloseAllForm();
            frmSanPham fSP = new frmSanPham();
            fSP.MdiParent = this;
            //fNV.Dock = DockStyle.Fill;
            fSP.BringToFront();
            fSP.Show();
        }

        private void btnXembaoCao_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            frmChonBaoCao fchon = new frmChonBaoCao();
            fchon.MdiParent = this;
            fchon.BringToFront();
            fchon.Show();
        }
        

        
    }
}
