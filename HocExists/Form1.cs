using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocExists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            dsInt = new List<int>();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x=>lstN.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtTim.Text);
            bool kq = dsInt.Exists(x => x == k);
            if (kq == true)
                MessageBox.Show("Có tồn tại "+k+" trong danh sách");
            else
                MessageBox.Show("Ko tồn tại " + k + " trong danh sách");
        }
        List<SanPham> dsSP = new List<SanPham>();
        public void TaoGiaDanhSachSanPham()
        {
            dsSP.Add(new SanPham() { Ma="SP1",Ten="Coca"});
            dsSP.Add(new SanPham() { Ma = "S2", Ten = "Pepsi" });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "STING" });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "REDBULL" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaoGiaDanhSachSanPham();
            dsSP.ForEach(x=> 
            {
                ListViewItem lvi = 
                new ListViewItem((listView1.Items.Count+1)+"");
                lvi.SubItems.Add(x.Ma);
                lvi.SubItems.Add(x.Ten);
                listView1.Items.Add(lvi);
            });
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            bool kq = dsSP.Exists(x => x.Ten == txtTenSP.Text);
            if(kq==true)
            {
                MessageBox.Show("Có tìm thấy sản phẩm ["+txtTenSP.Text+"]");
            }
            else
            {
                MessageBox.Show("Ko tìm thấy sản phẩm [" + txtTenSP.Text + "]");
            }
        }
    }
}
