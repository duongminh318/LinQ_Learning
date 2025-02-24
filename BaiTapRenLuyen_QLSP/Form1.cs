using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapRenLuyen_QLSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*📌 Tóm tắt các chức năng
        ## Danh sách chức năng trong chương trình

| STT | Chức năng                              | Mô tả |
|-----|----------------------------------------|------------------------------------------------|
| 1   | Lưu sản phẩm                          | Thêm sản phẩm mới vào danh sách `dsSPGoc`. |
| 2   | Xóa sản phẩm được chọn                 | Xóa sản phẩm đang được chọn trong `ListView`. |
| 3   | Xóa sản phẩm theo xuất xứ              | Xóa tất cả sản phẩm có xuất xứ nhập vào. |
| 4   | Kiểm tra sản phẩm quá hạn              | Hiển thị thông báo nếu có sản phẩm hết hạn. |
| 5   | Xóa toàn bộ sản phẩm                   | Xóa hết sản phẩm trong danh sách. |
| 6   | Xóa sản phẩm quá hạn                   | Xóa tất cả sản phẩm có hạn sử dụng trước ngày hiện tại. |
| 7   | Tìm sản phẩm có giá cao nhất           | Tìm sản phẩm có `DonGia` lớn nhất. |
| 8   | Liệt kê sản phẩm quá hạn               | Hiển thị danh sách sản phẩm có hạn sử dụng trước ngày hiện tại. |
| 9   | Lọc sản phẩm theo khoảng giá          | Lọc sản phẩm trong khoảng giá `min - max`. |

---

### Ghi chú:
- `dsSPGoc`: Danh sách gốc chứa sản phẩm.
- `ListView`: Hiển thị danh sách sản phẩm.
- `DonGia`: Giá tiền của sản phẩm.
- `HanDung`: Hạn sử dụng của sản phẩm.
*/
        // Danh sách chứa tất cả sản phẩm
        List<SanPham> dsSPGoc = new List<SanPham>();

        // 📌 1. Thêm sản phẩm mới vào danh sách
        private void btnLuuSp_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng sản phẩm mới và gán dữ liệu từ các ô nhập
            SanPham sp = new SanPham();
            sp.Ma = txtMa.Text;
            sp.Ten = txtTen.Text;
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DonGia = int.Parse(txtDonGia.Text);
            sp.XuatXu = txtXuatXu.Text;
            sp.HanDung = dtpHanDung.Value;

            // Thêm sản phẩm vào danh sách
            dsSPGoc.Add(sp);

            // Xóa dữ liệu nhập cũ để nhập sản phẩm mới
            XoaDuLieuNhapCu();

            // Hiển thị danh sách sản phẩm lên ListView
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        // 📌 2. Xóa dữ liệu nhập cũ trên giao diện
        void XoaDuLieuNhapCu()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtXuatXu.Clear();
            txtMa.Focus(); // Đưa con trỏ về ô nhập Mã
        }

        // 📌 3. Hiển thị danh sách sản phẩm lên ListView
        void HienThiLenListView(List<SanPham> ds, ListView lv)
        {
            lv.Items.Clear(); // Xóa dữ liệu cũ

            ds.ForEach(sp =>
            {
                ListViewItem lvi = new ListViewItem(sp.Ma);
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.SoLuong + "");
                lvi.SubItems.Add(sp.DonGia + "");
                lvi.SubItems.Add(sp.XuatXu);
                lvi.SubItems.Add(sp.HanDung.ToString("dd/MM/yyyy"));
                lv.Items.Add(lvi);
            });
        }

        // 📌 4. Xóa sản phẩm được chọn trong danh sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPhamGoc.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Phải chọn sản phẩm trước khi xóa");
                return;
            }

            // Lấy vị trí của sản phẩm được chọn
            int vtXoa = lvSanPhamGoc.SelectedIndices[0];

            // Xóa sản phẩm khỏi danh sách
            dsSPGoc.RemoveAt(vtXoa);

            // Cập nhật lại danh sách trên ListView
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        // 📌 5. Xóa tất cả sản phẩm có xuất xứ được nhập vào
        private void btnXoaXuatXu_Click(object sender, EventArgs e)
        {
            // Duyệt danh sách từ cuối về đầu để tránh lỗi khi xóa phần tử
            for (int i = dsSPGoc.Count - 1; i >= 0; i--)
            {
                if (string.Compare(dsSPGoc[i].XuatXu, txtXuatXuXoa.Text, true) == 0)
                {
                    dsSPGoc.RemoveAt(i);
                }
            }

            // Cập nhật lại danh sách trên ListView
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        // 📌 6. Kiểm tra xem có sản phẩm nào quá hạn không
        private void btnKiemTraQuaHan_Click(object sender, EventArgs e)
        {
            bool kq = dsSPGoc.Any(sp => sp.HanDung.Date < DateTime.Now.Date);

            if (kq)
            {
                MessageBox.Show("Kho có sản phẩm hết hạn");
            }
            else
            {
                MessageBox.Show("Kho đặt chuẩn");
            }
        }

        // 📌 7. Xóa toàn bộ sản phẩm trong danh sách
        private void btnXoaToanBoSP_Click(object sender, EventArgs e)
        {
            dsSPGoc.Clear(); // Xóa toàn bộ sản phẩm
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        // 📌 8. Xóa tất cả sản phẩm đã quá hạn sử dụng
        private void btnXoaSpQuaHan_Click(object sender, EventArgs e)
        {
            dsSPGoc.RemoveAll(sp => sp.HanDung.Date < DateTime.Now.Date);
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        // 📌 9. Tìm sản phẩm có giá cao nhất
        private void btn1SPMax_Click(object sender, EventArgs e)
        {
            // Giả định sản phẩm đầu tiên có giá cao nhất
            SanPham sp = dsSPGoc[0];

            // Duyệt danh sách để tìm sản phẩm có giá cao nhất
            for (int i = 1; i < dsSPGoc.Count; i++)
            {
                if (sp.DonGia < dsSPGoc[i].DonGia)
                    sp = dsSPGoc[i];
            }

            // Lưu sản phẩm tìm được vào danh sách mới và hiển thị
            List<SanPham> dsTim = new List<SanPham>() { sp };
            HienThiLenListView(dsTim, lvSanPhamTimKiem);
        }

        // 📌 10. Lọc các sản phẩm đã quá hạn sử dụng
        private void btnSanPhamQuaHan_Click(object sender, EventArgs e)
        {
            var dsTim = dsSPGoc
                .Where(x => x.HanDung.Date < DateTime.Now.Date)
                .ToList();

            HienThiLenListView(dsTim, lvSanPhamTimKiem);
        }

        // 📌 11. Lọc sản phẩm theo khoảng giá nhập vào
        private void btnLocDonGia_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text);
            int max = int.Parse(txtGiaMax.Text);

            var dsTim = from sp in dsSPGoc
                        where sp.DonGia >= min && sp.DonGia <= max
                        select sp;

            HienThiLenListView(dsTim.ToList(), lvSanPhamTimKiem);
        }

        private void btn1SPJapan_Click(object sender, EventArgs e)
        {
            // to do
        }
    }
}
