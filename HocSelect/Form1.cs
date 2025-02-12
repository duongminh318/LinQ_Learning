using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSelect
{
    public partial class Form1 : Form
    {

        /*
         * Hàm Select() trong LINQ được sử dụng để biến đổi từng phần tử trong một tập hợp (collection) 
         * và trả về một tập hợp mới dựa trên phép biến đổi đó.
         * var result = collection.Select(x => newType);
                collection: Tập hợp ban đầu (List, Array, Dictionary, ...).
                x: Phần tử trong tập hợp.
                newType: Giá trị mới mà ta muốn lấy từ x.
         */

        /*
        - Select() giúp chuyển đổi dữ liệu mà không thay đổi số lượng phần tử.
        - Nó có thể được dùng để lấy một thuộc tính, tính toán giá trị mới hoặc chuyển đổi kiểu dữ liệu.
        - Thường được sử dụng kết hợp với Where() để lọc và biến đổi dữ liệu.
        */
        public Form1()
        {
            InitializeComponent(); // Khởi tạo giao diện của form
        }

        // Danh sách chứa các sinh viên
        List<SinhVien> dsSV = new List<SinhVien>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm các sinh viên vào danh sách khi form tải lên
            dsSV.Add(new SinhVien()
            {
                Ma = "SV01",
                Ten = "An",
                Phone = "098236425",
                Email = "an@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "SV02",
                Ten = "Bình",
                Phone = "091236434",
                Email = "binh@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "SV03",
                Ten = "Hạnh",
                Phone = "097239225",
                Email = "hanh@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "SV04",
                Ten = "Phúc",
                Phone = "097230124",
                Email = "phuc@abc.edu.vn"
            });

            // Xóa danh sách hiển thị cũ trên ListView trước khi cập nhật
            lvGoc.Items.Clear();

            // Duyệt qua danh sách sinh viên và thêm vào ListView
            dsSV.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma); // Cột đầu tiên là mã sinh viên
                lvi.SubItems.Add(x.Ten);    // Thêm cột Tên
                lvi.SubItems.Add(x.Phone);  // Thêm cột Số điện thoại
                lvi.SubItems.Add(x.Email);  // Thêm cột Email
                lvGoc.Items.Add(lvi);       // Thêm dòng vào ListView
            });
        }

        // Xử lý khi nhấn button1: Sử dụng phương thức Select trong LINQ để chọn một số thuộc tính cần hiển thị
        private void button1_Click(object sender, EventArgs e)
        {
            var dsLoc = dsSV.Select(x => new { x.Ma, x.Ten }); // Chọn chỉ Mã và Tên của sinh viên
            dataGridView1.DataSource = dsLoc.ToList(); // Đưa danh sách lọc vào DataGridView để hiển thị
        }

        // Xử lý khi nhấn button2: Sử dụng cú pháp LINQ truy vấn thay vì phương thức Select trực tiếp
        private void button2_Click(object sender, EventArgs e)
        {
            var dsLoc = from sv in dsSV
                        select new { sv.Ma, sv.Ten }; // Lọc danh sách theo Mã và Tên
            dataGridView1.DataSource = dsLoc.ToList(); // Hiển thị dữ liệu lên DataGridView
        }

    }
}
