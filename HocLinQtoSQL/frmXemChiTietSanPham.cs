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
    public partial class frmXemChiTietSanPham : Form
    {
        public frmXemChiTietSanPham()
        {
            InitializeComponent();
        }

        private void frmXemChiTietSanPham_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            lstMaSanPham.Items.Clear();
            var dsMa = context.SanPhams.Select(x => x.Ma);
            foreach(var ma in dsMa)
            {
                lstMaSanPham.Items.Add(ma);
            }
        }

        private void lstMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMaSanPham.SelectedIndex == -1)
                return;
            int ma = int.Parse(lstMaSanPham.Text);
            SanPham sp = LayChiTietSanPham(ma);
            if(sp!=null)
            {

                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtGia.Text = sp.DonGia + "";
            }
        }
        public SanPham LayChiTietSanPham(int id)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams.FirstOrDefault(x=>x.Ma==id);
            return sp;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaTim.Text);
            SanPham sp = LayChiTietSanPham(ma);
            if (sp != null)
            {

                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtGia.Text = sp.DonGia + "";
            }
            else
            {
                MessageBox.Show("Tớ không thấy nhé thím");
            }
        }
    }
}
