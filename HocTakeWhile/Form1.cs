using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTakeWhile
{
    public partial class Form1 : Form
    {
        /*takewhile : lấy các phần tử từ đầu danh sách cho đến khi gặp một phần tử
         * không thỏa mãn điều kiện.
         * IEnumerable<T> TakeWhile(Func<T, bool> predicate)
         *  - predicate: Hàm điều kiện xác định phần tử nào sẽ được lấy.
            - Phương thức này ngừng lấy dữ liệu ngay khi gặp phần tử đầu tiên không thỏa mãn điều kiện.

         * */
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>(); // Danh sách chứa các số nguyên
        Random rd = new Random(); // Đối tượng tạo số ngẫu nhiên

        // tạo ds số nguyên ngẫu nhiên
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text); // Lấy số lượng phần tử từ TextBox
            dsInt.Clear(); // Xóa danh sách cũ

            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100); // Sinh số ngẫu nhiên từ 0 đến 99
                dsInt.Add(x); // Thêm số vào danh sách
            }

            lstN.Items.Clear(); // Xóa danh sách hiển thị cũ
            dsInt.ForEach(x => lstN.Items.Add(x)); // Hiển thị danh sách mới lên ListBox
        }

        // lọc lẻ liện tiếp từ đầu danh sách
        private void button1_Click(object sender, EventArgs e)
        {
            var dsKq = dsInt
                            .TakeWhile(x => x % 2 != 0) // Lấy số lẻ từ đầu danh sách
                            .ToList();

            lstTakeWhile.Items.Clear(); // Xóa danh sách hiển thị cũ
            dsKq.ForEach(x => lstTakeWhile.Items.Add(x)); // Hiển thị kết quả mới
        }

        /*
         * TakeWhile hữu ích khi cần lấy các phần tử liên tiếp từ đầu danh sách.
         * Khác Where, nó không kiểm tra toàn bộ danh sách.
         *  Ứng dụng tốt trong phân trang, lọc dữ liệu theo điều kiện nhất định.
        
      */
    }
}
