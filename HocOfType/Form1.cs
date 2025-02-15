using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocOfType
{
    public partial class Form1 : Form
    {
        /*OfType<T>() trong LINQ được sử dụng để lọc ra các phần tử thuộc một 
         * kiểu dữ liệu cụ thể từ một tập hợp không đồng nhất (chứa nhiều kiểu dữ liệu khác nhau).
         * var result = collection.OfType<T>();
                -  T là kiểu dữ liệu mà bạn muốn lọc.
        -  Khi nào dùng OfType<T>()?
            ✔ Khi danh sách chứa nhiều kiểu dữ liệu khác nhau (như ArrayList).
            ✔ Khi muốn lấy ra đối tượng thuộc một lớp cụ thể trong danh sách List<object> hoặc danh sách List<Person> chứa nhiều kiểu con (SinhVien, GiaoVien,...).

            🚀 Tóm lại, OfType<T>() rất hữu ích khi làm việc với danh sách không đồng nhất!
         */
        public Form1()
        {
            InitializeComponent();
        }
        // Danh sách lưu trữ nhân viên
        List<NhanVien> dsNV = new List<NhanVien>();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = null;

            // Nếu là nhân viên thời vụ, tạo đối tượng `NhanVienThoiVu`, ngược lại là `NhanVienChinhThuc`
            if (chkLaThoiVu.Checked)
                nv = new NhanVienThoiVu();
            else
                nv = new NhanVienChinhThuc();

            // Gán thông tin cho nhân viên
            nv.Ma = txtMa.Text;
            nv.Ten = txtTen.Text;

            // Thêm vào danh sách
            dsNV.Add(nv);

            // Hiển thị danh sách lên ListView
            HienThiLenListView();
        }

        void HienThiLenListView()
        {
            lvNhanVienGoc.Items.Clear(); // Xóa danh sách cũ trước khi cập nhật

            dsNV.ForEach(nv =>
            {
                // Tạo ListViewItem với thông tin nhân viên
                ListViewItem lvi = new ListViewItem(nv.Ma);
                lvi.SubItems.Add(nv.Ten);
                lvNhanVienGoc.Items.Add(lvi);

                // Nếu là nhân viên chính thức, đổi màu chữ thành xanh
                if (nv is NhanVienChinhThuc)
                    lvi.ForeColor = Color.Blue;

                // Nếu là nhân viên thời vụ, đổi màu chữ thành đỏ
                else if (nv is NhanVienThoiVu)
                    lvi.ForeColor = Color.Red;
            });
        }

        private void btnChinhThuc_Click(object sender, EventArgs e)
        {
            // Lọc ra các nhân viên chính thức từ danh sách
            var dsCT = dsNV.OfType<NhanVienChinhThuc>();

            lvNhanVienLoc.Items.Clear(); // Xóa danh sách cũ trước khi cập nhật

            foreach (var nv in dsCT)
            {
                // Tạo ListViewItem cho nhân viên chính thức
                ListViewItem lvi = new ListViewItem(nv.Ma);
                lvi.SubItems.Add(nv.Ten);
                lvNhanVienLoc.Items.Add(lvi);
            }
        }

        private void btnThoiVu_Click(object sender, EventArgs e)
        {
            // Lọc ra các nhân viên thời vụ từ danh sách
            var dsTV = dsNV.OfType<NhanVienThoiVu>();

            lvNhanVienLoc.Items.Clear(); // Xóa danh sách cũ trước khi cập nhật

            foreach (var nv in dsTV)
            {
                // Tạo ListViewItem cho nhân viên thời vụ
                ListViewItem lvi = new ListViewItem(nv.Ma);
                lvi.SubItems.Add(nv.Ten);
                lvNhanVienLoc.Items.Add(lvi);
            }
        }
    }
}
