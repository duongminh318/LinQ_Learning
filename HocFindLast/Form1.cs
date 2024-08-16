using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindLast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> dsNguon = new List<double>();
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsNguon = new List<double>();
            for(int i=0;i<n;i++)
            {
                double x =Math.Round(rd.NextDouble() * 100,2);
                dsNguon.Add(x);
            }
            lstN.Items.Clear();
            dsNguon.ForEach(x => lstN.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double k = double.Parse(txtTim.Text);
            double kq = dsNguon.FindLast(x=>x==k);
            txtKetQua.Text = kq + "";     
        }
        List<SanPham> dsSp = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSp.Add(new SanPham()
            {
                Ma="sp1",
                Ten="Cocacola",
                NgayNhapKho=new DateTime(2017,3,23)
            }
            );
            dsSp.Add(new SanPham()
            {
                Ma = "sp2",
                Ten = "Pepsi",
                NgayNhapKho = new DateTime(2017, 3, 24)
            }
            );
            dsSp.Add(new SanPham()
            {
                Ma = "sp3",
                Ten = "Bia 333",
                NgayNhapKho = new DateTime(2017, 3, 23)
            }
            );
            dsSp.Add(new SanPham()
            {
                Ma = "sp4",
                Ten = "Sting dâu",
                NgayNhapKho = new DateTime(2017, 2, 28)
            }
            );
            lvSanPham.Items.Clear();
            dsSp.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.NgayNhapKho.ToString("dd/MM/yyyy"));
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            SanPham sp = dsSp.FindLast(x=>x.NgayNhapKho.Date==dtpNgayNhap.Value.Date);
            if(sp==null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                txtMa.Text = sp.Ma;
                txtTen.Text = sp.Ten;
                txtNgayNhap.Text = sp.NgayNhapKho.ToString("dd/MM/yyyy");
            }
        }
    }
}
