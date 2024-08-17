using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToSoChan_Click(object sender, EventArgs e)
        {
            //xóa các lựa chọn trước đó:
            lstSo.SelectedIndex = -1;
            //duyệt qua từng số
            for(int i=0;i<lstSo.Items.Count;i++)
            {
                //convert datatype
                int x = int.Parse(lstSo.Items[i].ToString());
                if(x%2==0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnToSole_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for(int i=0;i<lstSo.Items.Count;i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                if(x%2!=0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }
        public bool isPrime(int x)
        {
            int dem = 0;
            for(int i=1;i<=x;i++)
            {
                if (x % i == 0)
                    dem++;
            }
            return dem == 2;
        }
        private void btnToNguyenTo_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for(int i=0;i<lstSo.Items.Count;i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                if(isPrime(x))
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }
    }
}
