using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            dsInt = new List<int>();
            int n = int.Parse(txtN.Text);
            for (int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstNguon.Items.Clear();
            dsInt.ForEach(x=> { lstNguon.Items.Add(x); });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtTim.Text);
            int kq = dsInt.FindIndex(x=>x==k);
            txtViTri.Text = kq + "";
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma="sp1",Ten="Bia Ken",XuatXu="Việt Nam"});
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Bia 333", XuatXu = "Việt Nam" });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "Kem đánh răng", XuatXu = "Trung Quốc" });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Bóng đèn", XuatXu = "Nhật Bản" });
            dsSP.Add(new SanPham() { Ma = "sp5", Ten = "Nón Lá", XuatXu = "Việt Nam" });
            lvSanPham.Items.Clear();
            dsSP.ForEach(x => DuaVaoListView(x));
        }
        public void DuaVaoListView(SanPham x)
        {
            ListViewItem lvi = new ListViewItem(x.Ma);
            lvi.SubItems.Add(x.Ten);
            lvi.SubItems.Add(x.XuatXu);
            lvSanPham.Items.Add(lvi);
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            string xx = txtXuatXu.Text;
            int kq = dsSP.FindIndex(x=>x.XuatXu==xx);
            txtKetQuaTimSP.Text = kq + "";
        }
    }
}
