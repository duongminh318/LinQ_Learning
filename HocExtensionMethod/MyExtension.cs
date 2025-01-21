﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace HocExtensionMethod
{
/*Extension Method: thêm 1 method mở rộng cho 1 object hay một thành phần
* nào đó trong c#
* >> tự tạo ra cho mình 1 phương thức riêng của element đó
* >> bất kỳ element nào đều có method đó
* >> áp dụng cho tất cả element nào thuộc class đó
* >> cài vào dữ liệu:int, string..; 
*       - hoặc các composenent : txt, lable, ...
*       - hoặc 1 object của 1 thư viện nào đó
*/
    public static class MyExtension
    {
        // extension method cho class kiểu int
        public static int TinhTongTu1ToiN(this int n)
        {
            int s = 0;
            for(int i=1;i<=n;i++)
            {
                s += i;
            }
            return s;
        }
        // extension method cho class kiểu string, 1 tham số s2
        public static string NoiChuoi(this string s1,string s2)
        {
            return s1 + " " + s2;
        }
        public static int LayGiaTriInt(this TextBox txt)
        {
            int x = 0;
            int.TryParse(txt.Text, out x); // chuyển đổ txt.Text sang kiểu int sau đó ném gt đã conver vào x
            return x;
        }
        public static void ToMauDo(this Button btn)
        {
            btn.BackColor = System.Drawing.Color.Red;
        }
        public static int TinhTuoi(this SinhVien sv)
        {
            return DateTime.Now.Year - sv.NamSinh.Year;
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
