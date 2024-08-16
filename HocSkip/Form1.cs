using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkip
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
            lstGoc.Items.Clear();
            dsInt.ForEach(x=>lstGoc.Items.Add(x));
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSkip.Text);
            var dsMoi = dsInt.Skip(n);
            lstSkip.Items.Clear();
            dsMoi.ToList().ForEach(x => lstSkip.Items.Add(x));
        }
    }
}
