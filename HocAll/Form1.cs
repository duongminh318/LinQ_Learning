using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAll
{
    public partial class Form1 : Form
    {
        /*All: kiểm tra tất cả các phần tử trong một tập hợp có thỏa mãn điều kiện 
            -  nào đó hay không. công dụng tương tự TrueForAll

         * bool result = danhSach.All(x => x.Điều_kiện);
                ✅ Trả về true nếu tất cả phần tử thỏa mãn điều kiện.
                ❌ Trả về false nếu có ít nhất một phần tử không thỏa mãn điều kiện.
                🔍 Nếu danh sách rỗng (List<T> không có phần tử nào), All() luôn trả về true (vì không có phần tử nào vi phạm điều kiện).
        * Khi nào dùng cái nào?
            ✅ Dùng All() khi cần kiểm tra trên bất kỳ IEnumerable<T> nào.
            ✅ Dùng TrueForAll() nếu chắc chắn đang làm việc với List<T>.

         */
        public Form1()
        {
            InitializeComponent();
        }
        // Khai báo danh sách số nguyên
        List<int> dsInt = new List<int>();

        // Xử lý khi nhấn nút "Nhập"
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị nhập vào không phải số hợp lệ thì báo lỗi
            if (!int.TryParse(txtGiaTri.Text, out int x))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm số hợp lệ vào danh sách
            dsInt.Add(x);

            // Hiển thị số vừa nhập vào ListBox mà không cần xóa danh sách cũ
            lstGiaTri.Items.Add(x);
        }

        // Xử lý khi nhấn nút kiểm tra "Toàn số chẵn"
        private void btnToanSoChan_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu danh sách rỗng thì báo lỗi
            if (dsInt.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xem tất cả các số trong danh sách có phải số chẵn không
            bool kq = dsInt.All(x => x % 2 == 0);

            // Hiển thị kết quả kiểm tra
            MessageBox.Show(kq ? "Toàn bộ số là số chẵn." : "Không phải toàn bộ là số chẵn.");
        }

        // Xử lý khi nhấn nút kiểm tra "Toàn số dương"
        private void btnToanSoDuong_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu danh sách rỗng thì báo lỗi
            if (dsInt.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xem tất cả các số trong danh sách có phải số dương không
            bool kq = dsInt.All(x => x > 0);

            // Hiển thị kết quả kiểm tra
            MessageBox.Show(kq ? "Toàn bộ số là số dương." : "Không phải toàn bộ là số dương.");
        }

        // Xử lý khi nhấn nút kiểm tra "Toàn số lẻ"
        private void btToanSoLe_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu danh sách rỗng thì báo lỗi
            if (dsInt.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xem tất cả các số trong danh sách có phải số lẻ không
            bool kq = dsInt.All(x => x % 2 != 0);

            // Hiển thị kết quả kiểm tra
            MessageBox.Show(kq ? "Toàn bộ số là số lẻ." : "Không phải toàn bộ là số lẻ.");
        }


    }
}
