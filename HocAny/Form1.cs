using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsInt.Add(x);
            lstGiaTri.Items.Clear();
            dsInt.ForEach(gt => lstGiaTri.Items.Add(gt));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.Any(x => x % 2 == 0);
            if (kq == true)
                MessageBox.Show("Danh sách có chứa số chẵn");
            else
                MessageBox.Show("Ko chứa số chẵn nào cả");
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSV.Add(new SinhVien()
            { Ma="sv1",Ten="Tèo",DiemTrungBinh=7});
            dsSV.Add(new SinhVien()
            { Ma = "sv2", Ten = "Tý", DiemTrungBinh = 4.5 });
            dsSV.Add(new SinhVien()
            { Ma = "sv3", Ten = "Bin", DiemTrungBinh = 7.8 });
            dataGridView1.DataSource = dsSV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kq = dsSV.Any(sv=>sv.DiemTrungBinh>=8);
            if(kq==true)
            {
                MessageBox.Show("Lớp này có Sinh viên được học bổng");
            }
            else
            {
                MessageBox.Show("Lớp này không có ai được học bổng");
            }
        }
    }
}
