using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapRenLuyenKyThuatLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemSNT_Click(object sender, EventArgs e)
        {
            int n = txtN.LayGiaTriNguyen();
            lstSNT.Items.Clear();
            List<int> dsNT = n.DanhSachSoNguyenTo();
            foreach (int x in dsNT)
                lstSNT.Items.Add(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXemSNT.TuDoiMauNen();
        }
    }
}
