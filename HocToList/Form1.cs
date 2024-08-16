using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> dsInt = new List<int>();
            Random rd = new Random();
            for(int i=0;i<100;i++)
            {
                dsInt.Add(rd.Next(100));
            }
            /*IEnumerable<int> dsChan = from c in dsInt
                                      where c%2==0
                                      select c;*/
            IEnumerable<int> dsChan = dsInt.Where(c => c % 2 == 0);
            List<int> dsKq = dsChan.ToList();
            lstData.Items.Clear();
            dsKq.ForEach(x => lstData.Items.Add(x));
        }
    }
}
