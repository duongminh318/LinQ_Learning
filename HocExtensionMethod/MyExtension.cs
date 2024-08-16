using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace HocExtensionMethod
{
    public static class MyExtension
    {
        public static int TinhTongTu1ToiN(this int n)
        {
            int s = 0;
            for(int i=1;i<=n;i++)
            {
                s += i;
            }
            return s;
        }
        public static string NoiChuoi(this string s1,string s2)
        {
            return s1 + " " + s2;
        }
        public static int LayGiaTriInt(this TextBox txt)
        {
            int x = 0;
            int.TryParse(txt.Text, out x);
            return x;
        }
        public static void ToMauDo(this Button btn)
        {
            btn.BackColor = System.Drawing.Color.Red;
        }
        public static int TinhTuoi(this SinhVien sv)
        {
            return DateTime.Now.Year - sv.NamSinh.Year + 1;
        }
        public static void ThayDoiMauNen(this Button btn)
        {
            btn.MouseHover += Btn_MouseHover;
            btn.MouseLeave += Btn_MouseLeave;
        }

        private static void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.Yellow;
        }

        private static void Btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.Red;
        }
    }
}
