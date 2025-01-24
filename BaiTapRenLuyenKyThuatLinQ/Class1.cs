using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapRenLuyenKyThuatLinQ
{
    /*Yêu cầu:
        Hãy cài một hàm kiểm tra số nguyên tố  vào kiểu số nguyên
        Hãy cài một hàm xuất danh sách các số nguyên tố từ 1->N vào kiểu số nguyên
        Hãy cài đặt hàm gán sự kiện di chuyển chuột vào Button làm đổi màu nền*/
    public static class Class1
    {
        // Kiểm tra một số nguyên n có phải là số nguyên tố hay không
        public static bool LaNguyenTo(this int n)
        {
            if (n == 0 || n == 1)
                return false; // 0 và 1 không phải số nguyên tố.

            double can = Math.Sqrt(n); // Tính căn bậc hai của n để tối ưu việc kiểm tra.
            for (int i = 2; i <= can; i++) // Duyệt từ 2 đến căn bậc hai của n.
            {
                if (n % i == 0)
                    return false; // Nếu n chia hết cho i, thì không phải số nguyên tố.
            }
            return true; // Nếu không chia hết cho bất kỳ số nào, n là số nguyên tố.
        }

        // Trả về danh sách các số nguyên tố từ 2 đến n
        public static List<int> DanhSachSoNguyenTo(this int n)
        {
            List<int> dsNT = new List<int>(); // Tạo danh sách chứa các số nguyên tố.
            for (int i = 2; i <= n; i++) // Duyệt từ 2 đến n.
            {
                if (i.LaNguyenTo()) // Gọi hàm LaNguyenTo để kiểm tra i có phải số nguyên tố.
                    dsNT.Add(i); // Nếu là số nguyên tố, thêm i vào danh sách.
            }
            return dsNT; // Trả về danh sách các số nguyên tố từ 2 đến n.
        }

        // Lấy giá trị số nguyên từ TextBox
        public static int LayGiaTriNguyen(this TextBox txt)
        {
            int gt; // Khai báo biến `gt` để lưu giá trị số nguyên.
            int.TryParse(txt.Text, out gt);
            // Thử chuyển đổi giá trị chuỗi trong TextBox sang số nguyên.
            // Nếu chuyển đổi thành công, giá trị sẽ được lưu vào `gt`.
            return gt; // Trả về giá trị số nguyên (hoặc 0 nếu chuyển đổi thất bại).
        }
        public static void TuDoiMauNen(this Button btn)
        {
            // Gắn sự kiện khi chuột di chuyển vào nút (MouseHover) và khi chuột rời khỏi nút (MouseLeave)
            btn.MouseHover += Btn_MouseHover; // Khi chuột di chuyển vào nút
            btn.MouseLeave += Btn_MouseLeave; // Khi chuột rời khỏi nút
        }

        private static void Btn_MouseLeave(object sender, EventArgs e)
        {
            // Sự kiện khi chuột rời khỏi nút
            Button btn = sender as Button; // Ép kiểu sender thành Button
            btn.BackColor = System.Drawing.Color.Yellow; // Đổi màu nền thành màu vàng
            btn.ForeColor = System.Drawing.Color.Blue;   // Đổi màu chữ thành màu xanh dương
        }

        private static void Btn_MouseHover(object sender, EventArgs e)
        {
            // Sự kiện khi chuột di chuyển vào nút
            Button btn = sender as Button; // Ép kiểu sender thành Button
            btn.BackColor = System.Drawing.Color.Red;   // Đổi màu nền thành màu đỏ
            btn.ForeColor = System.Drawing.Color.White; // Đổi màu chữ thành màu trắng
        }

    }
}
