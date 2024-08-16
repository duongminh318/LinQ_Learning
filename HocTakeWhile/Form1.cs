using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTakeWhile
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
            dsInt.Clear();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x=>lstN.Items.Add(x));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsKq = dsInt
                            .TakeWhile(x=>x%2!=0)
                            .ToList();
            lstTakeWhile.Items.Clear();
            dsKq.ForEach(x=>lstTakeWhile.Items.Add(x));
        }
    }
}
