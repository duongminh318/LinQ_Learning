using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLazyLoading
{
    /*Thực thi trì hoãn và tải chậm*/
    /*Deferred Execution = LINQ hoãn thực thi đến khi cần.
    Lazy Loading = EF tải dữ liệu liên quan khi cần thiết. (lười loading) */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo một danh sách các chuỗi với các phần tử ban đầu "A", "B", "C"
            var source = new List<string> { "A", "B", "C" };

            // Định nghĩa một truy vấn LINQ để chọn tất cả các phần tử trong danh sách source
            // Tại thời điểm này, truy vấn chỉ được định nghĩa, chưa được thực thi.
            // Đây là ví dụ của "lazy loading" (deferred execution) - thực thi trì hoãn.
            var values = from c in source
                         select c;

            // Thêm phần tử "D" vào danh sách source
            // Vì LINQ sử dụng deferred execution, truy vấn values sẽ bao gồm cả phần tử "D" này 
            // khi nó được thực thi trong tương lai.
            source.Add("D");

            // Bắt đầu duyệt qua các phần tử trong truy vấn values
            // Tại thời điểm này, truy vấn mới thực sự được thực thi.
            // Kết quả là truy vấn sẽ bao gồm các phần tử "A", "B", "C", và cả "D".
            foreach (var c in values)
            {
                // Thêm từng phần tử vào listBox1 (một thành phần UI, ví dụ trong WinForms)
                listBox1.Items.Add(c);
                // Kết quả cuối cùng: "A", "B", "C", và "D" sẽ được thêm vào listBox1.Items.
            }
        }
        /* KHÔNG SỬ DỤNG Deferred Execution DO CÓ TOLIST*/
        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo một danh sách các số nguyên từ 1 đến 9
            var source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Định nghĩa một truy vấn LINQ để chọn các phần tử chẵn trong danh sách source
            // Sau đó, sử dụng .ToList() để thực thi ngay truy vấn và lưu kết quả vào danh sách values
            // Điều này có nghĩa là truy vấn sẽ được thực thi ngay lập tức và không còn lazy loading.
            var values = (from c in source
                          where c % 2 == 0
                          select c).ToList();

            // Thêm các phần tử mới vào danh sách source sau khi truy vấn đã được thực thi
            // Các phần tử mới này sẽ không ảnh hưởng đến kết quả của truy vấn vì truy vấn đã thực thi trước đó.
            source.Add(114);
            source.Add(113);
            source.Add(116);
            //hiển thị kết quả ra 
            // Duyệt qua từng phần tử trong danh sách values (kết quả truy vấn đã thực thi trước đó)
            foreach (var c in values)
            {
                // Thêm từng phần tử vào listBox2 (một thành phần UI, ví dụ trong WinForms)
                listBox2.Items.Add(c);
                // Kết quả cuối cùng: chỉ có các số chẵn từ danh sách ban đầu (2, 4, 6, 8) được thêm vào listBox2.Items.
            }

        }
    }
}
