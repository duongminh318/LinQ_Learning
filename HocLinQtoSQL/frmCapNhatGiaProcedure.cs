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
    public partial class frmCapNhatGiaProcedure : Form
    {
        public frmCapNhatGiaProcedure()
        {
            InitializeComponent();
        }

        private void frmCapNhatGiaProcedure_Load(object sender, EventArgs e)
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

        private void mnuSuaGia_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            int masp =int.Parse(lvi.SubItems[0].Text);
            frmGiaMoi frm = new frmGiaMoi();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                int giamoi = int.Parse(frm.txtGiaMoi.Text);
                CSDLTestDataContext context = new CSDLTestDataContext();

                context.CapNhatGia(masp, giamoi);
                HienThiSanPhamLenListView();
            }
        }
    }
}
