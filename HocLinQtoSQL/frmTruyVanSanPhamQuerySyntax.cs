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
    public partial class frmTruyVanSanPhamQuerySyntax : Form
    {
        public frmTruyVanSanPhamQuerySyntax()
        {
            InitializeComponent();
        }

        private void frmTruyVanSanPhamQuerySyntax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            var dsSP = from x in context.SanPhams
                       select x;
            lvSanPham.Items.Clear();
            foreach(var x in dsSP)
            {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            }
        }
    }
}
