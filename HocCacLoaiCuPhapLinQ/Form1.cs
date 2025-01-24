using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocCacLoaiCuPhapLinQ
{
    /*
     * Syntax in LinQ
     * query syntax: giống như câu lệnh sql, from x in table, where điều kiện, select lấy ra cái gì đó
         * var result = from variable in source // Nguồn dữ liệu
                 where condition          // Điều kiện lọc (tùy chọn)
                 orderby sorting          // Sắp xếp (tùy chọn)
                 select projection;       // Chọn kết quả (tùy chọn)

     * method syntax: sử dụng lambda expresion trong câu lênh
         * var result = source
        .Where(condition)       // Lọc dữ liệu (tùy chọn)
        .OrderBy(keySelector)    // Sắp xếp (tăng dần - tùy chọn)
        .Select(projection);     // Chọn kết quả (tùy chọn)

     * mix: kết hợp cả hai cách trên vào 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrData = { 4,6,1,7,9,1,2,0};
        //query syntax
        private void button1_Click(object sender, EventArgs e)
        {
            var dsChan = from x in arrData  // chọn ra các số chẵn trong mảng
                         where x % 2 == 0
                         select x;
            string result = ""; // chuỗi rỗng để nữa in ra mảng chẵn
            foreach(var item in dsChan) // duyệt mảng
            {
                result += item+ "---"; // nỗi chuỗi
               
            }
            label1.Text = result ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dsChan = from x in arrData where x % 2 == 0 select x;
        }


        //method syntax
        private void button3_Click(object sender, EventArgs e)
        {
            var dsChan = arrData.Where(x => x % 2 == 0);
        }

        // mix
        private void button4_Click(object sender, EventArgs e)
        {
            var dsLe = (from x in arrData
                        where x % 2 != 0
                        select x).OrderByDescending(x=>x);
        }
    }
}
