using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SinhVien> dsSV = new List<SinhVien>();
            dsSV.Add(new SinhVien() { Ma = "sv1", Ten = "An" });
            dsSV.Add(new SinhVien() { Ma = "sv2", Ten = "Bình" });
            dsSV.Add(new SinhVien() { Ma = "sv3", Ten = "Hạnh" });
            dsSV.Add(new SinhVien() { Ma = "sv4", Ten = "Phúc" });
            dsSV.Add(new SinhVien() { Ma = "sv5", Ten = "Giải" });
            dsSV.Add(new SinhVien() { Ma = "sv6", Ten = "Thoát" });
            Dictionary<string, SinhVien> dic = dsSV.ToDictionary(x=>x.Ma);
            lvSinhVien.Items.Clear();
            foreach(KeyValuePair<string,SinhVien> item in dic)
            {
                ListViewItem lvi = new ListViewItem(item.Key);
                lvi.SubItems.Add(item.Value.Ten);
                lvSinhVien.Items.Add(lvi);
            }
        }
    }
}
