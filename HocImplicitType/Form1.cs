using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocImplicitType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = 113;
            var y = 5.5;
            var z = 7.5f;
            var s = "Obama";
            var d = new DateTime(2017, 2, 2);
            lblMessage.Text ="x="+ x.GetType().ToString();
            lblMessage.Text += "\ny=" + y.GetType().ToString();
            lblMessage.Text += "\nz=" + z.GetType().ToString();
            lblMessage.Text += "\ns=" + s.GetType().ToString();
            lblMessage.Text += "\nd=" + d.GetType().ToString();

            var t="Putin";
            t = "Kim jong un";
            t = 5.5;
        }
        void function1(float x)
        {

        }
    }
}
