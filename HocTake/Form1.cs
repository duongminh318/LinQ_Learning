using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>();
        Random rd = new Random();
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            dsInt.Clear();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int take = int.Parse(txtTake.Text);
            var dsKq = dsInt.Take(take).ToList();
            lstTake.Items.Clear();
            dsKq.ForEach(x=>lstTake.Items.Add(x));
        }
        List<DanhBa> dsDanhBa = new List<DanhBa>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<1000;i++)
            {
                DanhBa contact = new DanhBa();
                contact.Ten = "Tên " + i;
                string phone = "090";
                for (int j = 0; j < 7; j++)
                    phone += rd.Next(10);
                contact.Phone = phone;
                dsDanhBa.Add(contact);
            }
            HienThiDanhBaLenListView();
        }
        int skip = 0,take=10;

        private void btnVeSau_Click(object sender, EventArgs e)
        {
            skip += take;
            HienThiDanhBaLenListView();
        }

        private void btnVeTruoc_Click(object sender, EventArgs e)
        {
            skip -= take;
            HienThiDanhBaLenListView();
        }

        void HienThiDanhBaLenListView()
        {
            lvDanhBa.Items.Clear();
            var dsKq = dsDanhBa
                            .Skip(skip)
                            .Take(take)
                            .ToList();
            dsKq.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ten);
                lvi.SubItems.Add(x.Phone);
                lvDanhBa.Items.Add(lvi);
            });
            lblViTri.Text = (skip +10)+ "/" + dsDanhBa.Count;
        }
    }
}
