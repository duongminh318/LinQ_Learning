using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLambdaExpression
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
        public delegate int TongDelegate(int x, int y);
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeInt d1 = new ChangeInt(Tang2);
            ChangeInt d2 = ((int x)=>x+2);
            ChangeInt d3 = (x => x + 2);
            ChangeInt d4 = delegate (int x)
              {
                  return x + 2;
              };
            label1.Text = d3(100) + "";
            // viết tường minh ra giống javascript như này
            TongDelegate d5 = (x, y) => { return x + y; };
            label1.Text += "\nd5=" + d5(3, 4);
            //hoặc gom gọn lại
            TongDelegate d6 = (x, y) => x - y;
        }
    }
}
