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
    public partial class frmThemSanPhamProcedure : Form
    {
        public frmThemSanPhamProcedure()
        {
            InitializeComponent();
        }

        private void frmThemSanPhamProcedure_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenGridView();
            HienThiDanhMucLenCombobox();
        }
        void HienThiSanPhamLenGridView()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<LayToanBoSanPhamResult> dsSP =
                context.LayToanBoSanPham().ToList();
            dgvSanPham.DataSource = dsSP;
        }
        void HienThiDanhMucLenCombobox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            cboDanhMuc.DataSource = dsDM;
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtMa.Text);
            string tensp = txtTen.Text;
            int gia = int.Parse(txtGia.Text);
            int madm = (int)cboDanhMuc.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            context.ThemSanPham(masp, tensp, gia, madm);
            HienThiSanPhamLenGridView();
        }
    }
}
