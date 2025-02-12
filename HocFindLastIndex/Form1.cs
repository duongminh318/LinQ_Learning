using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindLastIndex
{
    public partial class Form1 : Form
    {
        /*
         * FindLastIndex() được sử dụng để tìm vị trí (chỉ mục)
         *  của phần tử cuối cùng trong danh sách (List) thỏa mãn một điều kiện cụ thể.
         *  int index = danhSach.FindLastIndex(x => x == giaTriCanTim);
                Trả về: Vị trí (index) của phần tử cuối cùng thỏa mãn điều kiện.
                Nếu không tìm thấy: Trả về -1.
         */
        public Form1()
        {
            InitializeComponent();
        }
        // Danh sách số nguyên để lưu dữ liệu ngẫu nhiên
        List<int> dsNguon = new List<int>();
        Random rd = new Random();

        // Xử lý sự kiện khi nhấn nút "Tạo DS"
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n;

            // Kiểm tra xem txtN có phải số hợp lệ không
            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dsNguon = new List<int>(); // Tạo danh sách mới để tránh dữ liệu cũ
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100); // Sinh số ngẫu nhiên từ 0 đến 99
                dsNguon.Add(x);
            }

            // Cập nhật danh sách hiển thị trên giao diện
            lstN.Items.Clear();
            dsNguon.ForEach(x => lstN.Items.Add(x));
        }

        // Xử lý sự kiện khi nhấn nút "Tìm số cuối cùng"
        private void btnTim_Click(object sender, EventArgs e)
        {
            int k;

            // Kiểm tra xem txtTim có phải số hợp lệ không
            if (!int.TryParse(txtTim.Text, out k))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm vị trí cuối cùng của phần tử có giá trị bằng k
            int kq = dsNguon.FindLastIndex(x => x == k);

            // Hiển thị kết quả (nếu không tìm thấy, giá trị sẽ là -1)
            txtKetQua.Text = kq.ToString();
        }

        // ======================== XỬ LÝ SẢN PHẨM ========================

        // Danh sách sản phẩm
        List<SanPham> dsSP = new List<SanPham>();

        // Sự kiện khi form tải lên (Form1_Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm một số sản phẩm vào danh sách
            dsSP.Add(new SanPham() { Ma = "sp1", Ten = "Cocacola lala", Gia = 1533 });
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Pepsi sisi", Gia = 2434 });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "Bia 333 lala", Gia = 1533 });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Thuốc lá con Ngựa", Gia = 35533 });

            // Hiển thị danh sách sản phẩm trên ListView
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia.ToString());
                lvSanPham.Items.Add(lvi);
            });
        }

        // Xử lý tìm kiếm sản phẩm có giá trị lớn nhất từ dưới lên
        private void btnTimSP_Click(object sender, EventArgs e)
        {
            int gia;

            // Kiểm tra xem txtDGTim có phải số hợp lệ không
            if (!int.TryParse(txtDGTim.Text, out gia))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm vị trí cuối cùng của sản phẩm có giá bằng `gia`
            int kq = dsSP.FindLastIndex(x => x.Gia == gia);

            // Nếu không tìm thấy
            if (kq == -1)
            {
                MessageBox.Show("Không tìm thấy sản phẩm có giá: " + gia, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Lấy sản phẩm từ danh sách
                SanPham sp = dsSP[kq];

                // Hiển thị thông tin sản phẩm tìm thấy
                txtMa.Text = sp.Ma;
                txtTenSp.Text = sp.Ten;
                txtDonGia.Text = sp.Gia.ToString();
            }
        }



    }
}
