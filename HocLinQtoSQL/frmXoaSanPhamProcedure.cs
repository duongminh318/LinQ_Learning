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
    public partial class frmXoaSanPhamProcedure : Form
    {
        public frmXoaSanPhamProcedure()
        {
            InitializeComponent();
        }

        private void frmXoaSanPhamProcedure_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenListView();
        }
        void HienThiSanPhamLenListView()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<LayToanBoSanPhamResult> dsSP =
                context.LayToanBoSanPham().ToList();
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0)
                return;
            int ma = 
                int.Parse(lvSanPham.SelectedItems[0].SubItems[0].Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            context.XoaSanPham(ma);
            HienThiSanPhamLenListView();
        }
    }
}
