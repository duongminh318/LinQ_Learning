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
    public partial class frmXemChiTietSanPhamQuerySyntax : Form
    {
        public frmXemChiTietSanPhamQuerySyntax()
        {
            InitializeComponent();
        }
        bool isFinished = false;
        private void frmXemChiTietSanPhamQuerySyntax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            cboSanPham.DataSource = dsSP;
            cboSanPham.ValueMember = "Ma";
            cboSanPham.DisplayMember = "Ten";
            isFinished = true;
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFinished == false) return;
            int ma =(int) cboSanPham.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = (from x in context.SanPhams
                         where x.Ma == ma
                         select x).FirstOrDefault();
            if(sp!=null)
            {
                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtGia.Text = sp.DonGia + "";
            }
        }
    }
}
