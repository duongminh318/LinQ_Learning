using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToList
{
    public partial class Form1 : Form
    {
        /* chuyển một tập hợp (IEnumerable<T> hoặc IQueryable<T>) thành danh sách (List<T>).

        */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo một danh sách số nguyên
            List<int> dsInt = new List<int>();

            // Tạo một đối tượng Random để sinh số ngẫu nhiên
            Random rd = new Random();

            // Tạo danh sách gồm 100 số ngẫu nhiên từ 0 đến 99
            for (int i = 0; i < 100; i++)
            {
                dsInt.Add(rd.Next(100));
            }

            /* 
            Lọc các số chẵn trong danh sách bằng LINQ.
            Cách viết 1: Sử dụng truy vấn LINQ (đã bị comment lại)
            IEnumerable<int> dsChan = from c in dsInt
                                      where c % 2 == 0
                                      select c;
            */

            // Cách viết 2: Sử dụng Lambda Expression
            IEnumerable<int> dsChan = dsInt.Where(c => c % 2 == 0);

            // Chuyển danh sách kết quả thành List<int>
            List<int> dsKq = dsChan.ToList();

            // Xóa toàn bộ dữ liệu cũ trong ListBox trước khi hiển thị
            lstData.Items.Clear();

            // Duyệt danh sách số chẵn và hiển thị lên ListBox
            dsKq.ForEach(x => lstData.Items.Add(x));
        }


        /*
         * 📌 Khi nào nên dùng ToList()?
             ✔ Khi cần một danh sách mới từ một tập hợp dữ liệu (IEnumerable<T>, IQueryable<T>).
            ✔ Khi muốn tránh việc thay đổi dữ liệu gốc.
            ✔ Khi làm việc với LINQ để lấy kết quả và thao tác trên danh sách.

        */
    }
}
