using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocObjectInitialzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /*SanPham sp = new SanPham()
            {
                Ma=int.Parse(txtMa.Text),
                Ten=txtTen.Text
            };*/
            /*var sp = new SanPham()
            {
                Ma = int.Parse(txtMa.Text),
                Ten = txtTen.Text
            };*/
            SanPham sp = new SanPham();
            sp.Ma = int.Parse(txtMa.Text);
            sp.Ten = txtTen.Text;
            lstSanPham.Items.Add(sp.Ma+"-"+sp.Ten);
        }
    }
}
