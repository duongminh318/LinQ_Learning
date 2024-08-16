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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnToSoChan_Click(object sender, EventArgs e)
        {
            lstSo.ToSoTrongListBox(x => x % 2 == 0);
        }

        private void btnToSole_Click(object sender, EventArgs e)
        {
            lstSo.ToSoTrongListBox(x => x % 2 != 0);
        }

        private void btnToNguyenTo_Click(object sender, EventArgs e)
        {
            lstSo.ToSoTrongListBox(x=>x.IsPrime());
        }
    }
}
