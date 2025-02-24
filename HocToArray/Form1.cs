using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToArray
{
    public partial class Form1 : Form
    {
        /*chuyển danh sách (List<T>) hoặc tập hợp (IEnumerable<T>) 
         * thành một mảng (T[]).*/
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo danh sách số nguyên
            List<int> dsInt = new List<int>();

            // Thêm nhiều phần tử vào danh sách
            dsInt.AddRange(new int[] { 5, 7, 1, 0, 35 });

            // Chuyển đổi danh sách List<int> sang mảng int[]
            var arr = dsInt.ToArray();

            // Xóa nội dung cũ trong Label trước khi hiển thị
            lblKetQua.Text = "";

            // Duyệt qua từng phần tử trong mảng và nối vào chuỗi kết quả
            for (int i = 0; i < arr.Length; i++)
            {
                lblKetQua.Text += arr[i] + " ";
            }
        }


        /*
         * ToArray() giúp chuyển đổi danh sách (List<T>) hoặc tập hợp (IEnumerable<T>) thành mảng (T[]).
        Dữ liệu được sao chép nên không ảnh hưởng đến danh sách gốc.
        Dùng khi cần mảng thay vì danh sách động.
        Có thể kết hợp với LINQ để xử lý dữ liệu trước khi chuyển đổi.
         */
    }
}
