using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocForeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            List<int> dsInt = new List<int>();
            Random rd = new Random();
            int n = int.Parse(txtN.Text);
            for(int i=0;i<n;i++)
            {
                dsInt.Add(rd.Next(100));
            }
            lstN.Items.Clear();
            /*foreach (int x in dsInt)
                lstN.Items.Add(x);*/
            //dsInt.ForEach(x => { lstN.Items.Add(x); });
            dsInt.ForEach(x => ThemGiaTri(x));
        }
        public void ThemGiaTri(int x)
        {
            lstN.Items.Add(x);
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Ma = txtMa.Text;
            sp.Ten = txtTen.Text;
            dsSP.Add(sp);
            HienThiSanPham();
        }
        public void HienThiSanPham()
        {
            lvSanPham.Items.Clear();//xóa dữ liệu cũ trên giao diện
            //dsSP.ForEach(x =>HienThi1SanPham(x));
            dsSP.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvSanPham.Items.Add(lvi);
            });
        }
        public void HienThi1SanPham(SanPham sp)
        {
            ListViewItem lvi = new ListViewItem(sp.Ma);
            lvi.SubItems.Add(sp.Ten);
            lvSanPham.Items.Add(lvi);
        }
    }
}
