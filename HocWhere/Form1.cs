using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocWhere
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
                Ma="Sv1",
                Ten="Nguyễn Thị Giải",
                Phone="0981564567",
                Email="giai@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv2",
                Ten = "Nguyễn Văn Thoát",
                Phone = "0981564575",
                Email = "thoat@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv3",
                Ten = "Trần Thị Vô",
                Phone = "0911568911",
                Email = "vo@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv4",
                Ten = "Hồ Văn Thường",
                Phone = "0941568933",
                Email = "thuong@abc.edu.vn"
            });

            lvGoc.Items.Clear();
            dsSV.ForEach(sv=> 
            {
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.Ten);
                lvi.SubItems.Add(sv.Phone);
                lvi.SubItems.Add(sv.Email);
                lvGoc.Items.Add(lvi);
            });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var dsLoc = dsSV
                .Where(sv=>sv.Phone.StartsWith(txtDauSo.Text))
                .ToList();
            dgvSinhVien.DataSource = dsLoc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsLoc = from sv in dsSV
                        where sv.Phone.StartsWith(txtDauSo.Text)
                        select sv;
            dgvSinhVien.DataSource = dsLoc.ToList();
        }
    }
}
