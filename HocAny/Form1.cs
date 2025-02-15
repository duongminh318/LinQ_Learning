using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocAny
{
    public partial class Form1 : Form
    {
        /*✅ Any() là một phương thức mở rộng của LINQ được sử dụng để:

            1. Kiểm tra xem danh sách (hoặc tập hợp) có chứa bất kỳ phần tử nào không.
            2. Kiểm tra xem có ít nhất một phần tử trong danh sách thỏa mãn một điều kiện nhất định hay không.

            ✅ Any() kiểm tra có ít nhất một phần tử thỏa mãn điều kiện hay không.
            ✅ Hiệu quả hơn Count() > 0 vì nó dừng ngay khi tìm thấy phần tử đầu tiên.
            ✅ Khác với All() vì All() yêu cầu tất cả phần tử phải thỏa mãn điều kiện.

            🔹 Dùng Any() khi cần kiểm tra nhanh có phần tử nào thỏa mãn điều kiện không.
            🔹 Dùng All() khi cần kiểm tra tất cả phần tử có thỏa mãn không.
        */
        public Form1()
        {
            InitializeComponent();
        }
        // Khai báo danh sách chứa số nguyên
        List<int> dsInt = new List<int>();

        // Xử lý sự kiện khi nhấn nút "Nhập"
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox và chuyển thành số nguyên
            int x = int.Parse(txtGiaTri.Text);

            // Thêm giá trị vào danh sách
            dsInt.Add(x);

            // Xóa danh sách hiển thị cũ để cập nhật lại
            lstGiaTri.Items.Clear();

            // Duyệt qua danh sách và hiển thị từng giá trị lên ListBox
            dsInt.ForEach(gt => lstGiaTri.Items.Add(gt));
        }

        // Xử lý sự kiện khi nhấn nút kiểm tra có số chẵn trong danh sách không
        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ít nhất một số chẵn trong danh sách hay không bằng Any()
            bool kq = dsInt.Any(x => x % 2 == 0);

            // Hiển thị thông báo dựa trên kết quả kiểm tra
            if (kq)
                MessageBox.Show("Danh sách có chứa số chẵn");
            else
                MessageBox.Show("Ko chứa số chẵn nào cả");
        }

        // Khai báo danh sách SinhVien
        List<SinhVien> dsSV = new List<SinhVien>();

        // Xử lý sự kiện khi form được tải lên
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm sinh viên vào danh sách
            dsSV.Add(new SinhVien() { Ma = "sv1", Ten = "Tèo", DiemTrungBinh = 7 });
            dsSV.Add(new SinhVien() { Ma = "sv2", Ten = "Tý", DiemTrungBinh = 4.5 });
            dsSV.Add(new SinhVien() { Ma = "sv3", Ten = "Bin", DiemTrungBinh = 7.8 });
           // dsSV.Add(new SinhVien() { Ma = "sv3", Ten = "Bin", DiemTrungBinh = 8 });

            // Gán danh sách sinh viên vào DataGridView để hiển thị
            dataGridView1.DataSource = dsSV;
        }

        // Xử lý sự kiện khi nhấn nút kiểm tra sinh viên có học bổng không
        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ít nhất một sinh viên có điểm trung bình từ 8 trở lên hay không bằng Any()
            bool kq = dsSV.Any(sv => sv.DiemTrungBinh >= 8);

            // Hiển thị thông báo dựa trên kết quả kiểm tra
            if (kq)
                MessageBox.Show("Lớp này có sinh viên được học bổng");
            else
                MessageBox.Show("Lớp này không có ai được học bổng");
        }

    }
}
