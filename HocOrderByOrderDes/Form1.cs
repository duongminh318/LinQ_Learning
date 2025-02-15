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


        /*| **Phương thức** | **Chức năng** | => sắp xếp 
        Cách đúng:

        OrderBy(x => x.Ten) ✅ (Tăng dần)
        OrderByDescending(x => x.Ten) ✅ (Giảm dần)
        ThenBy(x => x.Ma) ✅ (Tiêu chí phụ, tăng dần)
        ThenByDescending(x => x.Ma) ✅ (Tiêu chí phụ, giảm dần)
        - OrderBy(x => x.Ten).ThenBy(x => x.Ma) ✅ (Tăng dần)

        - OrderBy(x => x.Ten).ThenByDescending(x => x.Ma) ✅ (Giảm dần)

        - OrderByDescending(x => x.Ten).ThenBy(x => x.Ma) ✅ (Tăng dần)

        - cú pháp query :

        var result = from item in collection
             orderby item.Property
             select item;



        
         */



        List<int> dsInt;
        Random rd = new Random();
        List<SinhVien> dsSv = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            dsInt = new List<int>();
            int n = int.Parse(txtN.Text);
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        // Sắp xếp danh sách số nguyên theo thứ tự tăng dần
        private void btnTangDan_Click(object sender, EventArgs e)
        {
            dsInt = dsInt.OrderBy(x => x).ToList();
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        // Sắp xếp danh sách số nguyên theo thứ tự giảm dần
        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            dsInt = dsInt.OrderByDescending(x => x).ToList();
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x)); // load danh sách số nguyên đã sx lên ListBox
        }

        // Sắp xếp danh sách số nguyên theo thứ tự tăng dần bằng cú pháp LINQ query
        private void button1_Click(object sender, EventArgs e)
        {
            var ds = from x in dsInt
                     orderby x
                     select x;
            dsInt = ds.ToList();
            lstN.Items.Clear();
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách sinh viên
            dsSv.Add(new SinhVien() { Ma = 1, Ten = "Bình" });
            dsSv.Add(new SinhVien() { Ma = 2, Ten = "An" });
            dsSv.Add(new SinhVien() { Ma = 3, Ten = "Thoát" });
            dsSv.Add(new SinhVien() { Ma = 4, Ten = "Giải" });
            dsSv.Add(new SinhVien() { Ma = 5, Ten = "Bình" });

            HienThiSinhVienLenListView();
        }

        // Sắp xếp danh sách sinh viên theo tên (tăng dần)
        private void button2_Click(object sender, EventArgs e)
        {
            dsSv = dsSv.OrderBy(sv => sv.Ten).ToList();
            HienThiSinhVienLenListView();
        }

        // Hiển thị danh sách sinh viên lên ListView
        void HienThiSinhVienLenListView()
        {
            lvSinhVien.Items.Clear();
            dsSv.ForEach(sv =>
            {
                ListViewItem lvi = new ListViewItem(sv.Ma.ToString());
                lvi.SubItems.Add(sv.Ten);
                lvSinhVien.Items.Add(lvi);
            });
        }

        // Sắp xếp danh sách sinh viên theo tên (cú pháp LINQ query)
        private void button3_Click(object sender, EventArgs e)
        {
            var ds = from sv in dsSv
                     orderby sv.Ten
                     select sv;
            dsSv = ds.ToList();
            HienThiSinhVienLenListView();
        }

        // Sắp xếp danh sách sinh viên theo tên (giảm dần)
        private void button4_Click(object sender, EventArgs e)
        {
            dsSv = dsSv.OrderByDescending(sv => sv.Ten).ToList();
            HienThiSinhVienLenListView();
        }

        // Sắp xếp danh sách sinh viên theo tên (giảm dần) bằng cú pháp LINQ query
        private void button5_Click(object sender, EventArgs e)
        {
            var ds = from sv in dsSv
                     orderby sv.Ten descending
                     select sv;
            dsSv = ds.ToList();
            HienThiSinhVienLenListView();
        }

        // Sắp xếp danh sách sinh viên theo tên (tăng dần), nếu trùng thì sắp xếp theo mã (giảm dần)
        private void button6_Click(object sender, EventArgs e)
        {
            dsSv = dsSv
                .OrderBy(sv => sv.Ten) // Sắp xếp theo tên (A → Z)
                .ThenByDescending(sv => sv.Ma) // Nếu trùng tên, sắp xếp theo mã (giảm dần)
                .ToList();
            HienThiSinhVienLenListView();
        }
    }
}
