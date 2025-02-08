using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocExists
{
    /* Exist : collection.Exist(x=>x== thông tin cần tìm kiếm)*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Khai báo danh sách số nguyên     
        List<int> dsInt = new List<int>();

        // 📌 Sự kiện khi nhấn nút "Tạo danh sách số ngẫu nhiên"
        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            // Lấy số lượng phần tử từ TextBox
            int n = int.Parse(txtN.Text);

            // Tạo đối tượng Random để sinh số ngẫu nhiên
            Random rd = new Random();

            // Khởi tạo lại danh sách (reset danh sách cũ)
            dsInt = new List<int>();

            // Vòng lặp để tạo danh sách số ngẫu nhiên
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100); // Sinh số ngẫu nhiên từ 0 đến 99
                dsInt.Add(x); // Thêm số vào danh sách
            }

            // Xóa danh sách cũ trên ListBox
            lstN.Items.Clear();

            // Duyệt danh sách và hiển thị lên ListBox
            dsInt.ForEach(x => lstN.Items.Add(x));
        }

        // 📌 Sự kiện khi nhấn nút "Tìm số"
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy số cần tìm từ TextBox
            int k = int.Parse(txtTim.Text);

            // Kiểm tra xem số k có tồn tại trong danh sách không
            bool kq = dsInt.Exists(x => x == k);

            // Hiển thị kết quả tìm kiếm
            if (kq == true)
                MessageBox.Show("Có tồn tại " + k + " trong danh sách");
            else
                MessageBox.Show("Ko tồn tại " + k + " trong danh sách");
        }

        // Khai báo danh sách sản phẩm
        List<SanPham> dsSP = new List<SanPham>();

        // 📌 Hàm tạo danh sách sản phẩm mẫu
        public void TaoGiaDanhSachSanPham()
        {
            // Thêm các sản phẩm vào danh sách
            dsSP.Add(new SanPham() { Ma = "SP1", Ten = "Coca" });
            dsSP.Add(new SanPham() { Ma = "S2", Ten = "Pepsi" });
            dsSP.Add(new SanPham() { Ma = "SP3", Ten = "STING" });
            dsSP.Add(new SanPham() { Ma = "SP4", Ten = "REDBULL" });
        }

        // 📌 Sự kiện khi Form Load - hiển thị danh sách sản phẩm
        private void Form1_Load(object sender, EventArgs e)
        {
            // Gọi hàm tạo danh sách sản phẩm
            TaoGiaDanhSachSanPham();

            // Duyệt danh sách sản phẩm và hiển thị lên ListView
            dsSP.ForEach(x =>
            {
                // Tạo một dòng mới trong ListView
                ListViewItem lvi = new ListViewItem((listView1.Items.Count + 1) + "");
                lvi.SubItems.Add(x.Ma); // Thêm mã sản phẩm vào cột thứ 2
                lvi.SubItems.Add(x.Ten); // Thêm tên sản phẩm vào cột thứ 3
                listView1.Items.Add(lvi); // Thêm vào ListView
            });
        }

        // 📌 Sự kiện khi nhấn nút "Tìm sản phẩm"
        private void btnTimSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra sản phẩm có tồn tại không
            bool kq = dsSP.Exists(x => x.Ten == txtTenSP.Text);

            // Hiển thị kết quả tìm kiếm
            if (kq == true)
            {
                MessageBox.Show("Có tìm thấy sản phẩm [" + txtTenSP.Text + "]");
            }
            else
            {
                MessageBox.Show("Ko tìm thấy sản phẩm [" + txtTenSP.Text + "]");
            }
        }

    }
}
