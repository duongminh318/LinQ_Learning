using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocRemoveAll
{
    public partial class Form1 : Form
    {
        /*
         * RemoveAll là một phương thức của List<T>
         * giúp xóa tất cả phần tử thỏa mãn một điều kiện nhất định.
         * int RemoveAll(Predicate<T> match)
            Tham số:
            match: Một biểu thức điều kiện (Predicate<T>) dùng để kiểm tra các phần tử cần xóa.
            Giá trị trả về:
            Trả về số lượng phần tử đã bị xóa.
         */
        public Form1()
        {
            InitializeComponent();
        }
        // Danh sách số nguyên
        List<int> dsInt = new List<int>();
        Random rd = new Random();

        // Sự kiện tạo danh sách số ngẫu nhiên
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text); // Lấy số lượng phần tử từ ô nhập
            dsInt = new List<int>(); // Khởi tạo danh sách mới

            // Tạo danh sách số nguyên ngẫu nhiên từ 0 đến 99
            for (int i = 0; i < n; i++)
            {
                dsInt.Add(rd.Next(100));
            }

            // Xóa danh sách hiển thị cũ
            lstN.Items.Clear();

            // Hiển thị danh sách số vừa tạo lên ListBox
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        // Sự kiện xóa tất cả số lẻ khỏi danh sách
        private void btnXoaSoLe_Click(object sender, EventArgs e)
        {
            dsInt.RemoveAll(x => x % 2 != 0); // Xóa các số lẻ

            lstN.Items.Clear(); // Xóa danh sách hiển thị cũ

            // Cập nhật danh sách hiển thị sau khi xóa
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        // Danh sách sản phẩm
        List<SanPham> dsSP = new List<SanPham>();

        // Sự kiện khi form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm một số sản phẩm vào danh sách
            dsSP.Add(new SanPham()
            {
                Ma = "sp1",
                Ten = "Cocacolala",
                Gia = 15,
                XuatXu = "Việt Nam"
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp2",
                Ten = "Pepsi",
                Gia = 25,
                XuatXu = "Trung quốc"
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp3",
                Ten = "Redbull",
                Gia = 18,
                XuatXu = "Việt Nam"
            });
            dsSP.Add(new SanPham()
            {
                Ma = "sp4",
                Ten = "Bia xyz",
                Gia = 19,
                XuatXu = "Trung quốc"
            });

            // Xóa danh sách hiển thị cũ
            lvSanPham.Items.Clear();

            // Hiển thị danh sách sản phẩm lên ListView
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia + "");
                lvi.SubItems.Add(x.XuatXu);
                lvSanPham.Items.Add(lvi);
            });
        }

        // Sự kiện xóa sản phẩm theo giá và xuất xứ
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text); // Lấy giá tối thiểu từ ô nhập
            int max = int.Parse(txtGiaMax.Text); // Lấy giá tối đa từ ô nhập
            string xx = txtXuatXu.Text; // Lấy xuất xứ từ ô nhập

            // Xóa các sản phẩm có giá trong khoảng [min, max] và xuất xứ khớp với nhập vào
            dsSP.RemoveAll(x => x.Gia >= min && x.Gia <= max && x.XuatXu == xx);

            // Xóa danh sách hiển thị cũ
            lvSanPham.Items.Clear();

            // Hiển thị danh sách sau khi xóa sản phẩm
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma);
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.Gia + "");
                lvi.SubItems.Add(x.XuatXu);
                lvSanPham.Items.Add(lvi);
            });
        }

    }
}
