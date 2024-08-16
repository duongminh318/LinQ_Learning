using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSelect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dsSV = new List<SinhVien>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSV.Add(new SinhVien()
            {
                Ma="SV01",
                Ten="An",
                Phone="098236425",
                Email="an@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "SV02",
                Ten = "Bình",
                Phone = "091236434",
                Email = "binh@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "SV03",
                Ten = "Hạnh",
                Phone = "097239225",
                Email = "hanh@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "SV04",
                Ten = "Phúc",
                Phone = "097230124",
                Email = "phuc@abc.edu.vn"
            });
            lvGoc.Items.Clear();
            dsSV.ForEach(x=> 
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Phone);
                lvi.SubItems.Add(x.Email);
                lvGoc.Items.Add(lvi);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsLoc = dsSV.Select(x => new { x.Ma,x.Ten});
            dataGridView1.DataSource = dsLoc.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dsLoc = from sv in dsSV
                        select new { sv.Ma, sv.Ten };
            dataGridView1.DataSource = dsLoc.ToList();
        }
    }
}
