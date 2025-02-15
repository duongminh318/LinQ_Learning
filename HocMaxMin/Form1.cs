using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocMaxMin
{
    public partial class Form1 : Form
    {
        /*
         * Max và Min được sử dụng để tìm giá trị lớn nhất hoặc nhỏ nhất trong một tập hợp.

                Max(): Trả về giá trị lớn nhất trong danh sách.
                Min(): Trả về giá trị nhỏ nhất trong danh sách.
         */
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        Random rd = new Random();
        //tạo danh sách n số ngẫu nhiên 
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsInt = new List<int>();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x=> { lstN.Items.Add(x); });
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = dsInt.Max();
            MessageBox.Show("Số to tướng nhất="+max);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = dsInt.Min();
            MessageBox.Show("Số bé tẹo teo nhất="+min);
        }
    }
}
