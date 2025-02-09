using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindAll
{
    public partial class Form1 : Form
    {
/*FindAll: tìm tất cả các phần tử thoả mãn dk*/
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsGoc = new List<int>();
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsGoc = new List<int>();
            for(int i=0;i<n;i++)
            {
                dsGoc.Add(rd.Next(100));
            }
            lstGoc.Items.Clear();
            dsGoc.ForEach(x=>lstGoc.Items.Add(x));
        }

        private void btnLocChan_Click(object sender, EventArgs e)
        {
            List<int> dsChan = dsGoc.FindAll(x => x % 2 == 0);
            lstChan.Items.Clear();
            dsChan.ForEach(x=>lstChan.Items.Add(x));
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma="sp1",Ten="Coca",DonGia=15});
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Pepsi", DonGia = 30 });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "String", DonGia = 25});
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Bia ken", DonGia = 50 });
            dsSP.Add(new SanPham() { Ma = "sp5", Ten = "Bia Sài Gòn", DonGia = 20 });
            lvSanPhamGoc.Items.Clear();
            dsSP.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPhamGoc.Items.Add(lvi);
            });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            List<SanPham> dsSpTim = dsSP.FindAll
                            (x=>x.DonGia>=min && x.DonGia<=max);
            lvSanPhamTim.Items.Clear();
            dsSpTim.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPhamTim.Items.Add(lvi);
            }
            );
        }
    }
}
