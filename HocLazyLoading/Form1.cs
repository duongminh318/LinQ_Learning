using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLazyLoading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var source = new List<string> { "A","B","C"};
            var values = from c in source
                         select c;
            source.Add("D");
            foreach(var c in values)
            {
                listBox1.Items.Add(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var source = new List<int> {1,2,3,4,5,6,7,8,9 };
            var values = (from c in source
                         where c % 2 == 0
                         select c).ToList();
            source.Add(114);
            source.Add(113);
            source.Add(116);
            foreach(var c in values)
            {
                listBox2.Items.Add(c);
            }
        }
    }
}
