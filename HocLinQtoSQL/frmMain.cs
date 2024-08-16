using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLinQtoSQL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTruyVanSanphamMethodSynTax frm = 
                new frmTruyVanSanphamMethodSynTax();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTruyVanSanPhamQuerySyntax frm =
                new frmTruyVanSanPhamQuerySyntax();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTimSanPhamTheoDonGiaMethodSyntax frm =
                new frmTimSanPhamTheoDonGiaMethodSyntax();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTimSanPhamTheoDonGiaQuerySyntax frm =
                new frmTimSanPhamTheoDonGiaQuerySyntax();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPham frm = new frmXemChiTietSanPham();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPhamQuerySyntax frm =
                new frmXemChiTietSanPhamQuerySyntax();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmTruyVanDanhMucMethodSyntax frm = 
                new frmTruyVanDanhMucMethodSyntax();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmTruyVanDanhMucQuerySyntax frm = 
                new frmTruyVanDanhMucQuerySyntax();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmXemChiTietDanhMucMethodSyntax frm 
                = new frmXemChiTietDanhMucMethodSyntax();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmXemChiTietDanhMucQuerySyntax frm =
                new frmXemChiTietDanhMucQuerySyntax();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmTruyVanSanPhamTheoDanhMucMethodSyntax frm = 
                new frmTruyVanSanPhamTheoDanhMucMethodSyntax();
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmTruyVanSanPhamTheoDanhMucQuerySyntax frm =
                new frmTruyVanSanPhamTheoDanhMucQuerySyntax();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmLuuMoiDanhMuc frm = new frmLuuMoiDanhMuc();
            frm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmLuuMoiSanPham frm = new frmLuuMoiSanPham();
            frm.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmLuuMoiNhieuSanPham frm = new frmLuuMoiNhieuSanPham();
            frm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmSuaSanPham frm = new frmSuaSanPham();
            frm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmSuaDanhMuc frm = new frmSuaDanhMuc();
            frm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmXoaSanPham frm = new frmXoaSanPham();
            frm.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmXoaDanhMuc frm = new frmXoaDanhMuc();
            frm.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmXoaNhieuSanPham frm = new frmXoaNhieuSanPham();
            frm.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frmXemChiTietSanPhamProcedure frm = new frmXemChiTietSanPhamProcedure();
            frm.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            frmLayToanBoSanPhamProcedure frm = 
                new frmLayToanBoSanPhamProcedure();
            frm.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            frmThemSanPhamProcedure frm =
                new frmThemSanPhamProcedure();
            frm.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            frmCapNhatGiaProcedure frm = 
                new frmCapNhatGiaProcedure();
            frm.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            frmXoaSanPhamProcedure frm = new frmXoaSanPhamProcedure();
            frm.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            frmTimKiemVaSapXep frm = new frmTimKiemVaSapXep();
            frm.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            frmLocThuocTinhSanPham frm = new frmLocThuocTinhSanPham();
            frm.Show();
        }
    }
}
