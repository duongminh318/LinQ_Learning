using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate int ChangeInt(int x);
        public int Tang2(int x)
        {
            return x + 2;
        }
        public int Giam2(int x)
        {
            return x - 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeInt d = new ChangeInt(Giam2);
            label1.Text = d(100)+"";
        }
    }
}
