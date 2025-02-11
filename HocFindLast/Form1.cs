using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindLast
{
    public partial class Form1 : Form
    {
        /* FindLast: tìm phần tử cuối cùng của list thoả mãn dk
         * T List<T>.FindLast(Predicate<T> match)
         * match: Điều kiện tìm kiếm (biểu thức lambda hoặc phương thức).
         * Kết quả trả về:
            Nếu tìm thấy, trả về giá trị cuối cùng trong danh sách thỏa mãn điều kiện.
            Nếu không tìm thấy, trả về giá trị mặc định của kiểu dữ liệu (default(T)).
            default(int) → 0
            default(string) → null
            default(object) → null
         */
        public Form1()
        {
            InitializeComponent();
        }
        // Danh sách chứa các số thực
        List<double> dsNguon = new List<double>();
        // Đối tượng Random để tạo số ngẫu nhiên
        Random rd = new Random();

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            // Lấy số lượng phần tử từ textbox
            int n = int.Parse(txtN.Text);

            // Khởi tạo lại danh sách mới
            dsNguon = new List<double>();

            // Tạo danh sách ngẫu nhiên n phần tử
            for (int i = 0; i < n; i++)
            {
                double x = Math.Round(rd.NextDouble() * 100, 2); // Tạo số thực ngẫu nhiên từ 0 đến 100, làm tròn 2 chữ số
                dsNguon.Add(x);
            }

            // Xóa danh sách hiển thị cũ
            lstN.Items.Clear();

            // Hiển thị danh sách số thực lên ListBox
            dsNguon.ForEach(x => lstN.Items.Add(x));
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy số cần tìm từ textbox
            double k = double.Parse(txtTim.Text);

            // Tìm phần tử cuối cùng trong danh sách có giá trị bằng k
            double kq = dsNguon.FindLast(x => x == k);

            // Hiển thị kết quả tìm kiếm vào textbox
            txtKetQua.Text = kq + "";
        }

        // Danh sách chứa các sản phẩm
        List<SanPham> dsSp = new List<SanPham>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm sản phẩm vào danh sách
            dsSp.Add(new SanPham()
            {
                Ma = "sp1",
                Ten = "Cocacola",
                NgayNhapKho = new DateTime(2017, 3, 23)
            });

            dsSp.Add(new SanPham()
            {
                Ma = "sp2",
                Ten = "Pepsi",
                NgayNhapKho = new DateTime(2017, 3, 24)
            });

            dsSp.Add(new SanPham()
            {
                Ma = "sp3",
                Ten = "Bia 333",
                NgayNhapKho = new DateTime(2017, 3, 23)
            });

            dsSp.Add(new SanPham()
            {
                Ma = "sp4",
                Ten = "Sting dâu",
                NgayNhapKho = new DateTime(2017, 2, 28)
            });

            // Xóa dữ liệu cũ trong ListView
            lvSanPham.Items.Clear();

            // Duyệt danh sách sản phẩm và thêm vào ListView
            dsSp.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma); // Tạo dòng mới trong ListView với cột đầu tiên là Mã sản phẩm
                lvi.SubItems.Add(x.Ten); // Thêm cột Tên sản phẩm
                lvi.SubItems.Add(x.NgayNhapKho.ToString("dd/MM/yyyy")); // Thêm cột Ngày nhập kho (định dạng ngày)
                lvSanPham.Items.Add(lvi); // Thêm vào ListView
            });
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            // Tìm sản phẩm có ngày nhập kho cuối cùng trùng với ngày nhập từ DateTimePicker
            SanPham sp = dsSp.FindLast(x => x.NgayNhapKho.Date == dtpNgayNhap.Value.Date);

            if (sp == null)
            {
                // Nếu không tìm thấy, hiển thị thông báo
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                // Nếu tìm thấy, hiển thị thông tin sản phẩm lên các textbox
                txtMa.Text = sp.Ma;
                txtTen.Text = sp.Ten;
                txtNgayNhap.Text = sp.NgayNhapKho.ToString("dd/MM/yyyy");
            }
        }

    }
}
