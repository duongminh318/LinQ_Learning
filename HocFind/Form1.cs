using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> dsDouble = new List<double>();
        List<SanPham> dsSP = new List<SanPham>();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            dsDouble.Clear();
            for(int i=0;i<n;i++)
            {
                double x =Math.Round( rd.NextDouble() * 100,2);
                dsDouble.Add(x);
            }
            lstN.Items.Clear();
            dsDouble.ForEach(x=>lstN.Items.Add(x));


        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double k = double.Parse(txtTim.Text);
            double kq = dsDouble.Find(x => x == k);
            MessageBox.Show(kq+"");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gia = double.Parse(txtGia.Text);
            SanPham sp = dsSP.Find(x=>x.Gia==gia);
            if(sp!=null)
            {
                MessageBox.Show("Thấy sản phẩm : "+sp.Ten);
            }
            else
            {
                MessageBox.Show("Không thấy sản phẩm đạt yêu cầu");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP = new List<SanPham>();
            dsSP.Add(new SanPham() { Ma="sp1",Ten="Coca",Gia=15});
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "pepsi", Gia = 25 });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "String", Gia = 10 });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Redbull", Gia = 25 });
            dsSP.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia+"");
                lvSanPham.Items.Add(lvi);
            }
            );
        }
    }
}
