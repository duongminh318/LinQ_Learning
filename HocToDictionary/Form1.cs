using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocToDictionary
{
    public partial class Form1 : Form
    {
        /*chuyển đổi một danh sách (List<T>) hoặc một tập hợp (IEnumerable<T>) 
         * thành một từ điển (Dictionary<TKey, TValue>), với mỗi phần tử có một khóa (key)
         * và một giá trị (value).
        Dictionary<TKey, TValue> dictionary = list.ToDictionary(keySelector, valueSelector);
        🔹 keySelector: Hàm chọn khóa.
        🔹 valueSelector: Hàm chọn giá trị.
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo danh sách sinh viên
            List<SinhVien> dsSV = new List<SinhVien>();

            // Thêm các đối tượng SinhVien vào danh sách
            dsSV.Add(new SinhVien() { Ma = "sv1", Ten = "An" });
            dsSV.Add(new SinhVien() { Ma = "sv2", Ten = "Bình" });
            dsSV.Add(new SinhVien() { Ma = "sv3", Ten = "Hạnh" });
            dsSV.Add(new SinhVien() { Ma = "sv4", Ten = "Phúc" });
            dsSV.Add(new SinhVien() { Ma = "sv5", Ten = "Giải" });
            dsSV.Add(new SinhVien() { Ma = "sv6", Ten = "Thoát" });

            // Chuyển danh sách List<SinhVien> thành Dictionary<string, SinhVien>
            // Key là thuộc tính "Ma" của sinh viên
            Dictionary<string, SinhVien> dic = dsSV.ToDictionary(x => x.Ma);

            // Xóa tất cả các item hiện có trong ListView trước khi thêm mới
            lvSinhVien.Items.Clear();

            // Duyệt từng phần tử trong Dictionary
            foreach (KeyValuePair<string, SinhVien> item in dic)
            {
                // Tạo một ListViewItem với key là "Ma" của sinh viên
                ListViewItem lvi = new ListViewItem(item.Key);

                // Thêm cột phụ (subitem) chứa giá trị "Ten" của SinhVien vào ListViewItem
                lvi.SubItems.Add(item.Value.Ten);

                // Thêm ListViewItem vào ListView
                lvSinhVien.Items.Add(lvi);
            }
        }
        /*📌 Giải thích chính:
        Danh sách dsSV chứa nhiều đối tượng SinhVien, mỗi sinh viên có Ma (mã số) và Ten (tên).
        Hàm ToDictionary(x => x.Ma):
            Chuyển List<SinhVien> thành Dictionary<string, SinhVien>.
            Key là Ma của sinh viên, Value là toàn bộ đối tượng SinhVien.
        Duyệt Dictionary và hiển thị lên ListView:
            Tạo ListViewItem, trong đó:
                Cột đầu tiên (item.Key) là Ma của sinh viên.
                Cột tiếp theo (item.Value.Ma) cũng chính là Ma.
            Lỗi dư thừa: item.Key đã là Ma, nên item.Value.Ma thực chất là trùng lặp.*/
    }
}
