using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLambdaExpression
{/*
      // Lambda Expression: Hàm vô danh, ngắn gọn, được sử dụng với delegate hoặc Func/Action
        // Cú pháp: (tham số) => biểu thức hoặc khối lệnh
        Func<int, int> square = x => x * x; // Lambda trả về bình phương của x
        Console.WriteLine(square(5)); // Kết quả: 25

        // Lambda với nhiều tham số và khối lệnh
        Func<int, int, int> add = (x, y) => 
        { 
            return x + y; 
        }; 
        Console.WriteLine(add(3, 4)); // Kết quả: 7
  */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Định nghĩa delegate ChangeInt, nhận 1 tham số kiểu int và trả về kiểu int
        public delegate int ChangeInt(int x);

        // Phương thức Tang2, nhận một số nguyên x và trả về x + 2
        public int Tang2(int x)
        {
            return x + 2;
        }

        // Định nghĩa delegate TongDelegate, nhận 2 tham số kiểu int và trả về kiểu int
        public delegate int TongDelegate(int x, int y);

        private void button1_Click(object sender, EventArgs e)
        {
            // Sử dụng phương thức Tang2 làm delegate d1
            ChangeInt d1 = new ChangeInt(Tang2);

            // Sử dụng Lambda Expression, cách viết đầy đủ với (int x)
            ChangeInt d2 = ((int x) => x + 2);

            // Sử dụng Lambda Expression, cách viết rút gọn khi kiểu dữ liệu của tham số được suy diễn
            ChangeInt d3 = (x => x + 2);

            // Sử dụng Anonymous Method (phương thức vô danh) để khai báo delegate
            ChangeInt d4 = delegate (int x)
            {
                return x + 2;
            };

            // Gọi delegate d3 với tham số 100, kết quả là 102 (100 + 2)
            label1.Text = d3(100) + "";

            // Khai báo delegate TongDelegate bằng Lambda Expression dạng tường minh
            TongDelegate d5 = (x, y) => { return x + y; };
            // Gọi d5 với tham số 3 và 4, kết quả là 7 (3 + 4)
            label1.Text += "\nd5=" + d5(3, 4);

            // Khai báo delegate TongDelegate với Lambda Expression dạng rút gọn
            TongDelegate d6 = (x, y) => x - y;
        }

    }
}
