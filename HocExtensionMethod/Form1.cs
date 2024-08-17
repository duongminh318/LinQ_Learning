using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace HocExtensionMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            //int n = int.Parse(txtN.Text);
            int n = txtN.LayGiaTriInt();
            lblKetQua.Text = n.TinhTongTu1ToiN() + "";
        }

        private void btnNoi_Click(object sender, EventArgs e)
        {
            lblKetQuaNoiChuoi.Text = 
                txtChuoi1.Text.NoiChuoi(txtChuoi2.Text);

            btnNoi.ToMauDo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien teo = new SinhVien();
            teo.Ma = 1;
            teo.Ten = "Tèo";
            teo.NamSinh = new DateTime(1998, 1, 1);
            int t = teo.TinhTuoi();
            button1.Text = $"Tèo {t} tuổi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNoi.ThayDoiMauNen();
        }
    }
}
