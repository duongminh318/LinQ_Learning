using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapRenLuyenKyThuatLinQ
{
    public static class Class1
    {
        public static bool LaNguyenTo(this int n)
        {
            if (n == 0 || n == 1)
                return false;
            double can = Math.Sqrt(n);
            for(int i=2;i<=can;i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static List<int>DanhSachSoNguyenTo(this int n)
        {
            List<int> dsNT = new List<int>();
            for(int i=2;i<=n;i++)
            {
                if (i.LaNguyenTo())
                    dsNT.Add(i);
            }
            return dsNT;
        }
        public static int LayGiaTriNguyen(this TextBox txt)
        {
            int gt;
            int.TryParse(txt.Text, out gt);
            return gt;
        }
        public static void TuDoiMauNen(this Button btn)
        {
            btn.MouseHover += Btn_MouseHover;
            btn.MouseLeave += Btn_MouseLeave;
        }

        private static void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.Yellow;
            btn.ForeColor = System.Drawing.Color.Blue;
        }

        private static void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.Red;
            btn.ForeColor = System.Drawing.Color.White;
        }
    }
}
