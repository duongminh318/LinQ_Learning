using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HocDelegate_ListBox
{
    public static class MyExtention
    {
        // Khai báo delegate MatNa, đại diện cho một phương thức
        // nhận một tham số kiểu int và trả về kiểu bool
        public delegate bool MatNa(int x);

        // Phương thức mở rộng (extension method) cho ListBox,
        // sử dụng delegate MatNa để tô màu các số trong ListBox
        public static void ToSoTrongListBox(this ListBox lst, MatNa mn)
        {
            lst.SelectedIndex = -1; // Đặt lại lựa chọn trong ListBox, không chọn mục nào ban đầu
            for (int i = 0; i < lst.Items.Count; i++) // Duyệt qua từng mục trong ListBox
            {
                int x = Convert.ToInt32(lst.Items[i]); // Chuyển đổi giá trị của mục hiện tại sang kiểu int
                if (mn(x) == true) // Gọi delegate MatNa để kiểm tra điều kiện với giá trị x
                {
                    lst.SelectedIndex = i; // Nếu điều kiện thỏa mãn,
                                           // chọn mục đó trong ListBox
                }
            }
        }


        // Phương thức mở rộng (extension method) cho kiểu int,
        // dùng để kiểm tra số nguyên tố
        public static bool IsPrime(this int x)
        {
            int dem = 0; // Biến đếm số lượng ước số của x
            for (int i = 1; i <= x; i++) // Duyệt từ 1 đến x để tìm ước số
            {
                if (x % i == 0) // Nếu i là ước số của x
                {
                    dem++; // Tăng biến đếm
                }
            }
            return dem == 2; // Số nguyên tố chỉ có đúng 2 ước số (1 và chính nó)
        }
    }
}
