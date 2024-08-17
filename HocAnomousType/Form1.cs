using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAnomousType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
/* AnomousType
 * một object không có class
 * tự tạo ra class trong quá trình thực thi
 * sử dụng var
 * object tương tự js
 
 */
        private void button1_Click(object sender, EventArgs e)
        {
            var x = new {
                Ma = 1,
                Ten = "Coca cola",
                Gia = 150,
                NgayNhap =new DateTime(207,3,21) };

            label1.Text = x.Ma + "-" + x.Ten + "->" + x.Gia;
            label1.Text += "\n" + x.GetType().ToString();
        }
    }
}
