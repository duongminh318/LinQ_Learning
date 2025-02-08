using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocForeach
{
    public partial class Form1 : Form
    {
    /* foreach: duyệt qua từng phần tử của 1 collection .foreach(x =>{hàm nặc danh biến x})*/
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            List<int> dsInt = new List<int>(); // Tạo danh sách số nguyên
            Random rd = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên
            int n = int.Parse(txtN.Text); // Lấy giá trị nhập từ TextBox

            // Tạo danh sách gồm n số ngẫu nhiên từ 0 đến 99
            for (int i = 0; i < n; i++)
            {
                dsInt.Add(rd.Next(100));
            }

            lstN.Items.Clear(); // Xóa danh sách cũ trên ListBox

            // Cách 1: Duyệt danh sách bằng foreach (đã comment lại)
            /*foreach (int x in dsInt)
                lstN.Items.Add(x);*/

            // Cách 2: Dùng ForEach để thêm giá trị trực tiếp vào ListBox (đã comment lại)
            // dsInt.ForEach(x => { lstN.Items.Add(x); });

            // Cách 3: Dùng ForEach gọi hàm ThemGiaTri (cách này tách logic tốt hơn)
            dsInt.ForEach(x => ThemGiaTri(x));
        }

        // Hàm thêm một giá trị vào ListBox
        public void ThemGiaTri(int x)
        {
            lstN.Items.Add(x);
        }

        // Danh sách sản phẩm
        List<SanPham> dsSP = new List<SanPham>();

        // Khi nhấn nút Lưu, tạo sản phẩm mới và thêm vào danh sách
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(); // Tạo đối tượng sản phẩm mới
            sp.Ma = txtMa.Text; // Gán mã sản phẩm từ TextBox
            sp.Ten = txtTen.Text; // Gán tên sản phẩm từ TextBox
            dsSP.Add(sp); // Thêm sản phẩm vào danh sách

            HienThiSanPham(); // Cập nhật ListView hiển thị sản phẩm
        }

        // Hàm hiển thị tất cả sản phẩm lên ListView
        public void HienThiSanPham()
        {
            lvSanPham.Items.Clear(); // Xóa dữ liệu cũ trên giao diện

            // Cách 1: Gọi phương thức riêng để hiển thị từng sản phẩm (đã comment lại)
            // dsSP.ForEach(x => HienThi1SanPham(x));

            // Cách 2: Dùng ForEach để thêm trực tiếp vào ListView
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma); // Tạo item mới với mã sản phẩm
                lvi.SubItems.Add(x.Ten); // Thêm tên sản phẩm vào cột phụ
                lvSanPham.Items.Add(lvi); // Thêm item vào ListView
            });
        }

        // Hàm hiển thị một sản phẩm lên ListView (có thể dùng trong ForEach)
        public void HienThi1SanPham(SanPham sp)
        {
            ListViewItem lvi = new ListViewItem(sp.Ma); // Tạo item với mã sản phẩm
            lvi.SubItems.Add(sp.Ten); // Thêm tên sản phẩm
            lvSanPham.Items.Add(lvi); // Thêm vào ListView
        }

    }
}
