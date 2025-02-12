using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTrueForAll
{
    public partial class Form1 : Form
    {
        /*
         * TrueForAll là một phương thức của List<T> dùng để kiểm tra xem tất cả các phần tử 
         * trong danh sách có thỏa mãn một điều kiện nhất định hay không.
         * bool result = danhSach.TrueForAll(predicate);
            predicate: Biểu thức điều kiện (hàm lambda hoặc delegate).
result: Trả về true nếu tất cả phần tử trong danh sách thỏa mãn điều kiện, 
        ngược lại trả về false.
         */
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>(); // Danh sách số nguyên

        // Sự kiện khi nhấn nút "Nhập"
        // Nhập giá trị vào danh sách và hiển thị lên ListBox
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int gt = int.Parse(txtGiaTri.Text); // Lấy giá trị từ ô nhập
            dsInt.Add(gt); // Thêm vào danh sách
            lstGiaTri.Items.Clear(); // Xóa danh sách hiện tại để cập nhật mới
            dsInt.ForEach(x => lstGiaTri.Items.Add(x)); // Hiển thị lại danh sách trên ListBox
        }

        // Sự kiện kiểm tra danh sách có toàn số lẻ không
        private void button1_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.TrueForAll(x => x % 2 != 0); // Kiểm tra tất cả số có phải số lẻ không
            if (kq)
            {
                MessageBox.Show("Danh sách toàn lẻ");
            }
            else
            {
                MessageBox.Show("Danh sách có cả lẻ cả không lẻ");
            }
        }

        // Sự kiện kiểm tra danh sách có toàn số chẵn không
        private void button2_Click(object sender, EventArgs e)
        {
            bool kq = dsInt.TrueForAll(x => x % 2 == 0); // Kiểm tra tất cả số có phải số chẵn không
            if (kq)
            {
                MessageBox.Show("Danh sách toàn số chẵn");
            }
            else
            {
                MessageBox.Show("Danh sách có số chẵn và không chẵn");
            }
        }
        List<SanPham> dsSP = new List<SanPham>(); // Danh sách sản phẩm

        // Sự kiện chạy khi Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm sản phẩm vào danh sách
            dsSP.Add(new SanPham() { Ma = "sp1", Ten = "Coca", HanDung = new DateTime(2017, 3, 22) });
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Pepsi", HanDung = new DateTime(2026, 10, 22) });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "Redbull", HanDung = new DateTime(2027, 5, 22) });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Bia 333", HanDung = new DateTime(2025, 1, 22) });

            lvSanPham.Items.Clear(); // Xóa danh sách sản phẩm hiện tại

            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma); // Tạo dòng dữ liệu
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.HanDung.ToString("dd/MM/yyyy")); // Hiển thị hạn dùng theo định dạng dd/MM/yyyy
                lvSanPham.Items.Add(lvi); // Thêm vào ListView

                // Kiểm tra nếu sản phẩm đã hết hạn thì đổi màu thành đỏ
                if (x.HanDung.Date < DateTime.Now.Date)
                    lvi.ForeColor = Color.Red;
            });
        }

        // Sự kiện kiểm tra tất cả sản phẩm còn hạn không
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            bool kq = dsSP.TrueForAll(x => x.HanDung.Date >= DateTime.Now.Date); // Kiểm tra hạn dùng

            if (kq)
            {
                MessageBox.Show("Tất cả sản phẩm đều còn hạn");
            }
            else
            {
                MessageBox.Show("Trong kho có sản phẩm hết hạn rồi");
            }
        }

    }
}
