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
    public partial class frmTimSanPhamTheoDonGiaQuerySyntax : Form
    {
        public frmTimSanPhamTheoDonGiaQuerySyntax()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text);
            int max = int.Parse(txtGiaMax.Text);
            List<SanPham> dsSp = TimSanPhamTheoDonGia(min, max);
            lvSanPham.Items.Clear();
            dsSp.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma + "");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSanPham.Items.Add(lvi);
            });
        }
        public List<SanPham>TimSanPhamTheoDonGia(int min,int max)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            var dsSp = from x in context.SanPhams
                       where x.DonGia >= min && x.DonGia <= max
                       select x;
            return dsSp.ToList();
        }
    }
}
