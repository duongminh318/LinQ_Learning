using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSkipWhile
{
    public partial class Form1 : Form
    {
        /*
         * SkipWhile(condition): Bỏ qua các phần tử đầu thỏa mãn điều kiện.
                - Dừng bỏ qua ngay khi gặp phần tử đầu tiên không thỏa mãn.
                - Không kiểm tra lại điều kiện cho các phần tử tiếp theo.
         */
        List<int> dsInt = new List<int>(); // Danh sách chứa các số nguyên

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text); // Lấy số lượng phần tử từ TextBox
            dsInt.Clear(); // Xóa danh sách cũ

            Random rd = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100); // Sinh số ngẫu nhiên từ 0 đến 99
                dsInt.Add(x); // Thêm số vào danh sách
            }

            lstN.Items.Clear(); // Xóa danh sách hiển thị cũ
            dsInt.ForEach(x => lstN.Items.Add(x)); // Hiển thị danh sách mới lên ListBox
        }

        private void btnSkipWhile_Click(object sender, EventArgs e)
        {
            int skipWhile = int.Parse(txtSkipWhile.Text); // Lấy giá trị điều kiện từ TextBox

            var dsKq = dsInt
                .SkipWhile(k => k > skipWhile) // Bỏ qua các số lớn hơn skipWhile
                .ToList(); // Chuyển về danh sách

            lstKetQua.Items.Clear(); // Xóa danh sách hiển thị cũ
            dsKq.ForEach(x => lstKetQua.Items.Add(x)); // Hiển thị kết quả mới
        }

    }
}
