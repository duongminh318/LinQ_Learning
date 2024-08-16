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
    public partial class frmXemChiTietSanPhamProcedure : Form
    {
        public frmXemChiTietSanPhamProcedure()
        {
            InitializeComponent();
        }

        private void frmXemChiTietSanPhamProcedure_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            int masp = int.Parse(txtMa.Text);
            ChiTietSanPhamResult sp = context.ChiTietSanPham(masp)
                                             .FirstOrDefault();
            if (sp != null)
            {
                txtTenSP.Text = sp.Ten;
                txtDonGia.Text = sp.DonGia + "";
                lvSanPham.Items.Clear();
                ListViewItem lvi = new ListViewItem(sp.Ma + "");
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.DonGia + "");
                lvSanPham.Items.Add(lvi);
            }
            else
                MessageBox.Show("Không tìm thấy sản phẩm có mã =" + txtMa.Text);
        }
    }
}
