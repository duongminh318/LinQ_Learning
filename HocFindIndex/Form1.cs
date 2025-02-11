using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocFindIndex
{
    public partial class Form1 : Form
    {
        /*int index = ds.FindIndex(x => điều_kiện);
         * Nếu tìm thấy phần tử → Trả về index (vị trí đầu tiên của phần tử thỏa mãn).
            Nếu không tìm thấy → Trả về -1.
         * 
        */
        public Form1()
        {
            InitializeComponent();
        }
        // Danh sách lưu trữ các số nguyên
        List<int> dsInt = new List<int>();

        // Đối tượng Random để tạo số ngẫu nhiên
        Random rd = new Random();

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            // Xóa danh sách cũ và tạo danh sách mới
            dsInt = new List<int>();

            // Lấy số lượng phần tử từ TextBox
            int n = int.Parse(txtN.Text);

            // Tạo n số ngẫu nhiên từ 0 đến 99 và thêm vào danh sách
            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);
            }

            // Xóa danh sách hiển thị cũ và cập nhật danh sách mới lên ListBox
            lstNguon.Items.Clear();
            dsInt.ForEach(x => { lstNguon.Items.Add(x); });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            // Lấy số cần tìm từ TextBox
            int k = int.Parse(txtTim.Text);

            // Tìm vị trí đầu tiên của số trong danh sách
            int kq = dsInt.FindIndex(x => x == k);

            // Hiển thị kết quả vào TextBox
            txtViTri.Text = kq + ""; // Nếu không tìm thấy, kq sẽ là -1
        }

        // Danh sách chứa các sản phẩm
        List<SanPham> dsSP = new List<SanPham>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm các sản phẩm vào danh sách khi form load
            dsSP.Add(new SanPham() { Ma = "sp1", Ten = "Bia Ken", XuatXu = "Việt Nam" });
            dsSP.Add(new SanPham() { Ma = "sp2", Ten = "Bia 333", XuatXu = "Việt Nam" });
            dsSP.Add(new SanPham() { Ma = "sp3", Ten = "Kem đánh răng", XuatXu = "Trung Quốc" });
            dsSP.Add(new SanPham() { Ma = "sp4", Ten = "Bóng đèn", XuatXu = "Nhật Bản" });
            dsSP.Add(new SanPham() { Ma = "sp5", Ten = "Nón Lá", XuatXu = "Việt Nam" });

            // Xóa danh sách hiển thị cũ và cập nhật danh sách sản phẩm vào ListView
            lvSanPham.Items.Clear();
            dsSP.ForEach(x => DuaVaoListView(x));
        }



        // Hàm đưa sản phẩm vào ListView
        public void DuaVaoListView(SanPham x)
        {
            // Tạo một dòng mới trong ListView
            ListViewItem lvi = new ListViewItem(x.Ma);
            lvi.SubItems.Add(x.Ten);
            lvi.SubItems.Add(x.XuatXu);

            // Thêm dòng vào ListView
            lvSanPham.Items.Add(lvi);
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            // Lấy thông tin xuất xứ cần tìm từ TextBox
            string xx = txtXuatXu.Text;

            // Tìm vị trí đầu tiên của sản phẩm có xuất xứ tương ứng
            int kq = dsSP.FindIndex(x => x.XuatXu == xx);

            // Hiển thị kết quả vào TextBox (nếu không tìm thấy sẽ là -1)
            txtKetQuaTimSP.Text = kq + "";
        }

    }
}
