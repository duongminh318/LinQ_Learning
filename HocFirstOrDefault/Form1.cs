using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFirstOrDefault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> dsChuoi = new List<string>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            dsChuoi.Add(txtGiaTri.Text);
            lstGiaTri.Items.Clear();
            dsChuoi.ForEach(s=>lstGiaTri.Items.Add(s));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //string kq = dsChuoi.FirstOrDefault(s => s == txtTim.Text);
            string kq = dsChuoi.FirstOrDefault();
            MessageBox.Show(kq);
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham()
             { Ma = "sp1", Ten = "Coca cola", Gia = 15 });
            dsSP.Add(new SanPham()
            { Ma = "sp2", Ten = "Pepsi", Gia = 25 });
            dsSP.Add(new SanPham()
            { Ma = "sp3", Ten = "Sting", Gia = 13 });
            dsSP.Add(new SanPham()
            { Ma = "sp4", Ten = "Redbull", Gia = 20 });
            dgvSanPham.DataSource = dsSP;
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            SanPham sp = dsSP.FirstOrDefault(x=>x.Gia>20);
            if(sp!=null)
            {
                txtMa.Text = sp.Ma;
                txtTen.Text = sp.Ten;
                txtGia.Text = sp.Gia + "";
            }
        }
    }
}
