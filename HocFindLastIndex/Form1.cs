using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindLastIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsNguon = new List<int>();
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsNguon = new List<int>();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsNguon.Add(x);
            }
            lstN.Items.Clear();
            dsNguon.ForEach(x => lstN.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtTim.Text);
            int kq = dsNguon.FindLastIndex(x=>x==k);
            txtKetQua.Text = kq + "";
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham()
            {
                Ma="sp1",
                Ten="Cocacola lala",
                Gia=1533
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp2",
                Ten = "Pepsi sisi",
                Gia = 2434
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp3",
                Ten = "Bia 333 lala",
                Gia = 1533
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp4",
                Ten = "Thuốc lá con Ngựa",
                Gia = 35533
            });
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia+"");
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            int gia = int.Parse(txtDGTim.Text);
            int kq = dsSP.FindLastIndex(x => x.Gia == gia);
            if(kq==-1)
            {
                MessageBox.Show("No thấy sản phẩm nào");
            }
            else
            {
                SanPham sp = dsSP[kq];
                txtMa.Text = sp.Ma;
                txtTenSp.Text = sp.Ten;
                txtDonGia.Text = sp.Gia + "";
            }
        }

      
    }
}
