using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkipWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsInt.Clear();
            Random rd = new Random();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x=> { lstN.Items.Add(x); });
        }

        private void btnSkipWhile_Click(object sender, EventArgs e)
        {
            int skipWhile = int.Parse(txtSkipWhile.Text);
            var dsKq = dsInt
                .SkipWhile(k=>k>skipWhile)
                .ToList();
            lstKetQua.Items.Clear();
            dsKq.ForEach(x=>lstKetQua.Items.Add(x));
        }
    }
}
