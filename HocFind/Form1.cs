using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFind
{
    public partial class Form1 : Form
    {
/* find: tìm kiếm phần tử đầu tiên tìm thấy trong danh sách*/
        public Form1()
        {
            InitializeComponent();
        }
        // Khai báo danh sách số thực (double) và danh sách sản phẩm (SanPham)
        List<double> dsDouble = new List<double>();
        List<SanPham> dsSP = new List<SanPham>();

        // Sự kiện khi nhấn nút "Tạo Danh Sách"
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            // Lấy số lượng phần tử cần tạo từ ô nhập txtN
            int n = int.Parse(txtN.Text);

            // Tạo đối tượng Random để sinh số ngẫu nhiên
            Random rd = new Random();

            // Xóa danh sách cũ trước khi thêm mới
            dsDouble.Clear();

            // Tạo danh sách số thực ngẫu nhiên từ 0 đến 100, làm tròn 2 chữ số thập phân
            for (int i = 0; i < n; i++)
            {
                double x = Math.Round(rd.NextDouble() * 100, 2);
                dsDouble.Add(x);
            }

            // Xóa danh sách hiển thị cũ trong ListBox
            lstN.Items.Clear();

            // Thêm các số vừa tạo vào ListBox
            dsDouble.ForEach(x => lstN.Items.Add(x));
        }

        // Sự kiện khi nhấn nút "Tìm Kiếm"
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy số cần tìm từ ô nhập txtTim
            double k = double.Parse(txtTim.Text);

            // Tìm số đầu tiên trong danh sách khớp với giá trị nhập vào
            double kq = dsDouble.Find(x => x == k);

            // Hiển thị kết quả tìm kiếm
            MessageBox.Show(kq + "");
        }

        // Sự kiện khi nhấn nút "Tìm Sản Phẩm Theo Giá"
        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá sản phẩm cần tìm từ ô nhập txtGia
            double gia = double.Parse(txtGia.Text);

            // Tìm sản phẩm có giá bằng giá nhập vào
            SanPham sp = dsSP.Find(x => x.Gia == gia);

            // Kiểm tra nếu tìm thấy sản phẩm
            if (sp != null)
            {
                MessageBox.Show("Thấy sản phẩm: " + sp.Ten);
            }
            else
            {
                MessageBox.Show("Không thấy sản phẩm đạt yêu cầu");
            }
        }

        // Sự kiện khi Form tải lên (Form1_Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách sản phẩm
            dsSP = new List<SanPham>();

            // Thêm các sản phẩm vào danh sách
            dsSP.Add(new SanPham() { Ma = "sp1", Ten = "Coca", Gia = 15 });
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Pepsi", Gia = 25 });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "String", Gia = 10 });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Redbull", Gia = 25 });

            // Duyệt danh sách sản phẩm và thêm vào ListView
            dsSP.ForEach(x =>
            {
                // Tạo một dòng mới trong ListView
                ListViewItem lvi = new ListViewItem(x.Ma);

                // Thêm các cột phụ vào dòng này
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia + "");

                // Thêm dòng vào ListView lvSanPham
                lvSanPham.Items.Add(lvi);
            });
        }

    }
}
