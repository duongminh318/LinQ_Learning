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
    public partial class frmSuaSanPham : Form
    {
        public frmSuaSanPham()
        {
            InitializeComponent();
        }

        private void frmSuaSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenListView();
        }
        void HienThiSanPhamLenListView()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma + "");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            });
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            int ma =int.Parse( lvi.SubItems[0].Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams
                .FirstOrDefault(x => x.Ma == ma);
            if(sp!=null)
            {
                txtMa.Text = sp.Ma + "";
                txtTen.Text = sp.Ten;
                txtGia.Text = sp.DonGia + "";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            int ma = int.Parse(txtMa.Text);
            SanPham sp = context.SanPhams
                .FirstOrDefault(x => x.Ma == ma);
            if(sp!=null)
            {
                try
                {
                    sp.Ten = txtTen.Text;
                    sp.DonGia = int.Parse(txtGia.Text);
                    context.SubmitChanges();
                    MessageBox.Show("Chúc mừng nha, sửa rùi đóa");
                    HienThiSanPhamLenListView();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
