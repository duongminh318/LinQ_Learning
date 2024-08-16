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
    public partial class frmXoaNhieuSanPham : Form
    {
        public frmXoaNhieuSanPham()
        {
            InitializeComponent();
        }

        private void frmXoaNhieuSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenListView();
        }
        void HienThiSanPhamLenListView()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
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
            if (lvSanPham.CheckedItems.Count == 0) return;
            ListView.CheckedListViewItemCollection dsChecked 
                = lvSanPham.CheckedItems;
            List<SanPham> dsSpXoa = new List<SanPham>();
            CSDLTestDataContext context = new CSDLTestDataContext();
            foreach(ListViewItem lvi in dsChecked)
            {
                int masp = int.Parse(lvi.SubItems[0].Text);
                SanPham sp = context.SanPhams
                    .FirstOrDefault(x => x.Ma == masp);
                dsSpXoa.Add(sp);
            }
            context.SanPhams.DeleteAllOnSubmit(dsSpXoa);
            context.SubmitChanges();
            HienThiSanPhamLenListView();
        }
    }
}
