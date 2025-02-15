using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocWhere
{
    public partial class Form1 : Form
    {
        /*Where trong LINQ dùng để lọc danh sách dựa trên một điều kiện nhất định. 
         * Nó giúp truy vấn dữ liệu một cách dễ dàng và hiệu quả.
         * var result = danhSach.Where(x => điều_kiện);
        danhSach: Tập hợp dữ liệu (List, Array, IEnumerable, ...).
        x => điều_kiện: Điều kiện lọc (ví dụ: x.Age > 18 để lấy những người trên 18 tuổi).
        Trả về một danh sách mới chứa các phần tử thỏa mãn điều kiện.
         */
        public Form1()
        {
            InitializeComponent();
        }
        // Khai báo danh sách sinh viên
        List<SinhVien> dsSV = new List<SinhVien>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu sinh viên vào danh sách
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv1",
                Ten = "Nguyễn Thị Giải",
                Phone = "0981564567",
                Email = "giai@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv2",
                Ten = "Nguyễn Văn Thoát",
                Phone = "0981564575",
                Email = "thoat@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv3",
                Ten = "Trần Thị Vô",
                Phone = "0911568911",
                Email = "vo@abc.edu.vn"
            });
            dsSV.Add(new SinhVien()
            {
                Ma = "Sv4",
                Ten = "Hồ Văn Thường",
                Phone = "0941568933",
                Email = "thuong@abc.edu.vn"
            });

            // Xóa dữ liệu cũ trong ListView trước khi hiển thị
            lvGoc.Items.Clear();

            // Duyệt qua danh sách sinh viên và thêm vào ListView
            dsSV.ForEach(sv =>
            {
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.Ten);
                lvi.SubItems.Add(sv.Phone);
                lvi.SubItems.Add(sv.Email);
                lvGoc.Items.Add(lvi);
            });
        }

        // 👉 Tìm kiếm sinh viên theo đầu số điện thoại (cách 1: Lambda Expression)
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập số điện thoại
            if (string.IsNullOrWhiteSpace(txtDauSo.Text))
            {
                MessageBox.Show("Vui lòng nhập đầu số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc danh sách sinh viên theo đầu số điện thoại
            var dsLoc = dsSV.Where(sv => sv.Phone.StartsWith(txtDauSo.Text)).ToList();

            // Kiểm tra nếu không có kết quả nào
            if (dsLoc.Count == 0)
            {
                MessageBox.Show($"Số {txtDauSo.Text} không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị kết quả lên DataGridView
            dgvSinhVien.DataSource = dsLoc;
        }

        // 👉 Tìm kiếm sinh viên theo đầu số điện thoại (cách 2: Query Syntax)
        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập số điện thoại
            if (string.IsNullOrWhiteSpace(txtDauSo.Text)) // khi txtDauSo.Text rỗng hoặc null
            {
                MessageBox.Show("Vui lòng nhập đầu số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lọc danh sách sinh viên theo đầu số điện thoại
            var dsLoc = dsSV.Where(sv => sv.Phone.StartsWith(txtDauSo.Text)).ToList();

            // Kiểm tra nếu không có kết quả nào
            if (dsLoc.Count == 0)
            {
                MessageBox.Show($"Số {txtDauSo.Text} không tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị kết quả lên DataGridView
            dgvSinhVien.DataSource = dsLoc;
        }

    }
}
