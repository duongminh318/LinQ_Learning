using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAll
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
            int x = int.Parse(txtGiaTri.Text);
            dsInt.Add(x);
            lstGiaTri.Items.Clear();
            dsInt.ForEach(t=> { lstGiaTri.Items.Add(t); });
        }

        private void btnToanSoChan_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.All(x=>x%2==0);//TrueForAll
            if (kq)
                MessageBox.Show("Toàn chẵn");
            else
                MessageBox.Show("Ko phải Toàn chẵn");
        }

        private void btnToanSoDuong_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.All(x=>x>0);
            if (kq)
                MessageBox.Show("toàn số dương");
            else
                MessageBox.Show("Không phải toàn số dương");
        }
    }
}
