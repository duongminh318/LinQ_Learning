using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTrueForAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int gt = int.Parse(txtGiaTri.Text);
            dsInt.Add(gt);
            lstGiaTri.Items.Clear();
            dsInt.ForEach(x=>lstGiaTri.Items.Add(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.TrueForAll(x => x % 2 != 0);
            if(kq)
            {
                MessageBox.Show("Danh sách toàn lẻ");
            }
            else
            {
                MessageBox.Show("Danh sách có cả lẻ cả không lẻ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.TrueForAll(x=>x%2==0);
            if(kq)
            {
                MessageBox.Show("danh sách toàn số chẵn");
            }
            else
            {
                MessageBox.Show("danh sách có số chẵn và không chẵn");
            }
        }
        List<SanPham> dsSP = new List<SanPham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham()
                { Ma="sp1",Ten="Coca",
                HanDung =new DateTime(2017,3,22)});
            dsSP.Add(new SanPham()
            {
                Ma = "sp2",
                Ten = "Pepsi",
                HanDung = new DateTime(2017, 10, 22)
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp3",
                Ten = "Redbull",
                HanDung = new DateTime(2017, 5, 22)
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp4",
                Ten = "Bia 333",
                HanDung = new DateTime(2017, 1, 22)
            });
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.HanDung.ToString("dd/MM/yyyy"));
                lvSanPham.Items.Add(lvi);
                if (x.HanDung.Date < DateTime.Now.Date)
                    lvi.ForeColor = Color.Red;
            });
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            bool kq = dsSP.TrueForAll(
                x => x.HanDung.Date >= DateTime.Now.Date);
            if(kq)
            {
                MessageBox.Show("Tất cả sản phẩm đều còn hạn");
            }
            else
            {
                MessageBox.Show("Trong kho có sản phẩm hết hạn rồi");
            }
        }
              
    }
}
