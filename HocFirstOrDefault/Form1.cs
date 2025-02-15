using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFirstOrDefault
{
    public partial class Form1 : Form
    {
        /*lấy phần tử đầu tiên trong danh sách thỏa mãn điều kiện. 
         * Nếu danh sách trống hoặc không có phần tử nào thỏa mãn,
         * nó sẽ trả về giá trị mặc định (default value).
         * 
         * 
         * TSource? FirstOrDefault(Func<TSource, bool> predicate);
                - predicate: Điều kiện lọc phần tử.
                - Nếu có phần tử thỏa mãn, nó trả về phần tử đầu tiên.
                Nếu không có phần tử nào thỏa mãn, nó trả về default(T):
                null nếu là kiểu tham chiếu (string, class...)
                0 nếu là kiểu số (int, double...)
                false nếu là kiểu bool
         
         */
        public Form1()
        {
            InitializeComponent();
        }
        // Khai báo danh sách chuỗi
        List<string> dsChuoi = new List<string>();

        // Sự kiện khi bấm nút "Nhập"
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Thêm giá trị từ TextBox vào danh sách chuỗi
            dsChuoi.Add(txtGiaTri.Text);

            // Xóa danh sách hiển thị cũ
            lstGiaTri.Items.Clear();

            // Duyệt danh sách và hiển thị lên ListBox
            dsChuoi.ForEach(s => lstGiaTri.Items.Add(s));
        }

        // Sự kiện khi bấm nút "Tìm kiếm"
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Tìm phần tử đầu tiên trong danh sách (không có điều kiện)
            string kq = dsChuoi.FirstOrDefault();

            // Hiển thị kết quả tìm được (nếu danh sách rỗng sẽ hiển thị chuỗi rỗng)
            MessageBox.Show(kq);
        }

        // Khai báo danh sách sản phẩm
        List<SanPham> dsSP = new List<SanPham>();

        // Sự kiện khi form load (khởi tạo danh sách sản phẩm)
        private void Form1_Load(object sender, EventArgs e)
        {
            dsSP.Add(new SanPham() { Ma = "sp1", Ten = "Coca cola", Gia = 15 });
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Pepsi", Gia = 25 });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "Sting", Gia = 13 });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Redbull", Gia = 20 });

            // Gán danh sách sản phẩm vào DataGridView để hiển thị
            dgvSanPham.DataSource = dsSP;
        }

        // Sự kiện khi bấm nút "Tìm sản phẩm"
        private void btnTimSp_Click(object sender, EventArgs e)
        {
            // Tìm sản phẩm đầu tiên có giá > 20
            SanPham sp = dsSP.FirstOrDefault(x => x.Gia > 20);

            if (sp != null) // Nếu tìm thấy sản phẩm
            {
                txtMa.Text = sp.Ma;   // Hiển thị mã sản phẩm
                txtTen.Text = sp.Ten; // Hiển thị tên sản phẩm
                txtGia.Text = sp.Gia + ""; // Hiển thị giá sản phẩm (chuyển sang chuỗi)
            }
        }

    }
}
