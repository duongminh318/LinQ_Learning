using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocRemoveAll
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
            int n = int.Parse(txtN.Text);
            dsInt = new List<int>();
            for(int i=0;i<n;i++)
            {
                dsInt.Add(rd.Next(100));
            }
            lstN.Items.Clear();
            dsInt.ForEach(x=>lstN.Items.Add(x));
        }

        private void btnXoaSoLe_Click(object sender, EventArgs e)
        {
            dsInt.RemoveAll(x => x % 2 != 0);
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x));
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham()
            {
                Ma="sp1",
                Ten="Cocacolala",
                Gia=15,
                XuatXu="Việt Nam"
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp2",
                Ten = "Pepsi",
                Gia = 25,
                XuatXu = "Trung quốc"
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp3",
                Ten = "Redbull",
                Gia = 18,
                XuatXu = "Việt Nam"
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp4",
                Ten = "Bia xyz",
                Gia = 19,
                XuatXu = "Trung quốc"
            });
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia+"");
                lvi.SubItems.Add(x.XuatXu);
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text);
            int max = int.Parse(txtGiaMax.Text);
            string xx = txtXuatXu.Text;
            dsSP.RemoveAll(x => 
                    x.Gia >= min && x.Gia <= max 
                    && x.XuatXu == xx);
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia + "");
                lvi.SubItems.Add(x.XuatXu);
                lvSanPham.Items.Add(lvi);
            });
        }
    }
}
