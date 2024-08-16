using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocOrderByOrderDes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt;
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            dsInt = new List<int>();
            int n = int.Parse(txtN.Text);
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x=> { lstN.Items.Add(x); });
        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {
            dsInt = dsInt.OrderBy(x => x).ToList();
            lstN.Items.Clear();
            dsInt.ForEach(x => { lstN.Items.Add(x); });
        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            dsInt = dsInt.OrderByDescending(x => x).ToList();
            lstN.Items.Clear();
            dsInt.ForEach(x => { lstN.Items.Add(x); });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = from x in dsInt
                    orderby x
                    select x;
            dsInt = ds.ToList();
            lstN.Items.Clear();
            dsInt.ForEach(x => { lstN.Items.Add(x); });
        }
        List<SinhVien> dsSv = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSv.Add(new SinhVien() { Ma=1,Ten="Bình"});
            dsSv.Add(new SinhVien() { Ma = 2, Ten = "An" });
            dsSv.Add(new SinhVien() { Ma = 3, Ten = "Thoát" });
            dsSv.Add(new SinhVien() { Ma = 4, Ten = "Giải" });
            dsSv.Add(new SinhVien() { Ma = 5, Ten = "Bình" });

            HienThiSinhVienLenListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsSv = dsSv.OrderBy(sv => sv.Ten).ToList();
            HienThiSinhVienLenListView();
        }
        void HienThiSinhVienLenListView()
        {
            lvSinhVien.Items.Clear();
            dsSv.ForEach(sv =>
            {
                ListViewItem lvi = new ListViewItem(sv.Ma + "");
                lvi.SubItems.Add(sv.Ten);
                lvSinhVien.Items.Add(lvi);
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ds = from sv in dsSv
                     orderby sv.Ten 
                     select sv;
            dsSv = ds.ToList();
            HienThiSinhVienLenListView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dsSv = dsSv.OrderByDescending(sv => sv.Ten).ToList();
            HienThiSinhVienLenListView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ds = from sv in dsSv
                     orderby sv.Ten descending
                     select sv;
            dsSv = ds.ToList();
            HienThiSinhVienLenListView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dsSv = dsSv
                .OrderByDescending(sv => sv.Ma)
                .OrderBy(sv => sv.Ten)                
                .ToList();
            HienThiSinhVienLenListView();
        }
    }
}
