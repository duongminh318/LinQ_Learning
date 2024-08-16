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
    public partial class frmTimSanPhamTheoDonGiaMethodSyntax : Form
    {
        public frmTimSanPhamTheoDonGiaMethodSyntax()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text);
            int max = int.Parse(txtGiaMax.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams
                .Where(x => x.DonGia >= min && x.DonGia <= max)
                .ToList();
            lvSanPham.Items.Clear();
            foreach(SanPham sp in dsSP)
            {
                ListViewItem lvi = new ListViewItem(sp.Ma+"");
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.DonGia+"");
                lvSanPham.Items.Add(lvi);
            }
        }
    }
}
