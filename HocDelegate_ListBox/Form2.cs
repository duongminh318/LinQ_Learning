using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocDelegate_ListBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

    // Sự kiện xử lý khi nhấn nút btnToSoChan, tô màu các số chẵn trong ListBox
         private void btnToSoChan_Click(object sender, EventArgs e)
        {
            // tham số chuyền vào là 1 lamda expression
            lstSo.ToSoTrongListBox(x => x % 2 == 0); // Sử dụng biểu thức lambda
                                         // để kiểm tra số chẵn (x chia hết cho 2)
        }

        // Sự kiện xử lý khi nhấn nút btnToSole,
        // tô màu các số lẻ trong ListBox
        private void btnToSole_Click(object sender, EventArgs e)
        {
            lstSo.ToSoTrongListBox(x => x % 2 != 0); // Sử dụng biểu thức lambda để kiểm tra số lẻ (x không chia hết cho 2)
            // x là từng số trong listbox
        }

        // Sự kiện xử lý khi nhấn nút btnToNguyenTo,
        // tô màu các số nguyên tố trong ListBox
        private void btnToNguyenTo_Click(object sender, EventArgs e)
        {
            lstSo.ToSoTrongListBox(x => x.IsPrime()); // Sử dụng phương thức mở rộng IsPrime để kiểm tra số nguyên tố
        }
    }
}