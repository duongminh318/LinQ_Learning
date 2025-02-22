using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTake
{
    public partial class Form1 : Form
    {
        /*
         * lấy n phần tử đầu tiên từ 1 danh sách cho trước
         * syntax: ds.Take(n)
         * 📌 Lưu ý:

            Nếu n lớn hơn tổng số phần tử, nó sẽ trả về toàn bộ danh sách.
            Nếu n = 0, danh sách trả về sẽ rỗng.
         */
        List<int> dsInt = new List<int>(); // Danh sách số nguyên ngẫu nhiên
        List<DanhBa> dsDanhBa = new List<DanhBa>(); // Danh sách danh bạ
        Random rd = new Random(); // Đối tượng sinh số ngẫu nhiên

        int skip = 0, take = 10; // Biến điều khiển phân trang (skip: số phần tử bỏ qua, take: số phần tử lấy)

        public Form1()
        {
            InitializeComponent();
        }

        // =========================== PHẦN 1: LÀM VIỆC VỚI DANH SÁCH SỐ NGẪU NHIÊN ===========================

        private void btnTaoDS_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text); // Nhận số lượng phần tử từ TextBox
            dsInt.Clear(); // Xóa danh sách cũ

            for (int i = 0; i < n; i++)
            {
                int x = rd.Next(100); // Sinh số ngẫu nhiên từ 0 đến 99
                dsInt.Add(x); // Thêm số vào danh sách
            }

            lstN.Items.Clear(); // Xóa danh sách hiển thị cũ
            dsInt.ForEach(x => lstN.Items.Add(x)); // Hiển thị danh sách mới
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int take = int.Parse(txtTake.Text); // Lấy số lượng phần tử muốn lấy
            var dsKq = dsInt.Take(take).ToList(); // Lấy 'take' phần tử đầu tiên

            lstTake.Items.Clear(); // Xóa danh sách hiển thị cũ
            dsKq.ForEach(x => lstTake.Items.Add(x)); // Hiển thị danh sách mới
        }

        // =========================== PHẦN 2: QUẢN LÝ DANH BẠ VÀ PHÂN TRANG ===========================

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo 1000 danh bạ ngẫu nhiên khi ứng dụng mở
            for (int i = 0; i < 1000; i++)
            {
                DanhBa contact = new DanhBa();
                contact.Ten = "Tên " + i;

                string phone = "090"; // Số điện thoại bắt đầu với 090
                for (int j = 0; j < 7; j++)
                    phone += rd.Next(10); // Sinh số ngẫu nhiên (7 chữ số còn lại)

                contact.Phone = phone;
                dsDanhBa.Add(contact);
            }

            HienThiDanhBaLenListView(); // Hiển thị danh sách lần đầu
        }

        private void btnVeSau_Click(object sender, EventArgs e)
        {
            skip += take; // Tăng skip để chuyển sang trang tiếp theo
            if (skip >= dsDanhBa.Count) skip -= take; // Nếu vượt quá số lượng danh bạ, giữ nguyên trang
            HienThiDanhBaLenListView(); // Cập nhật danh sách hiển thị
        }

        private void btnVeTruoc_Click(object sender, EventArgs e)
        {
            skip -= take; // Giảm skip để quay lại trang trước
            if (skip < 0) skip = 0; // Đảm bảo không âm
            HienThiDanhBaLenListView(); // Cập nhật danh sách hiển thị
        }

        private void HienThiDanhBaLenListView()
        {
            lvDanhBa.Items.Clear(); // Xóa danh sách hiển thị cũ

            // Lấy danh sách danh bạ theo trang hiện tại
            var dsKq = dsDanhBa
                .Skip(skip) // Bỏ qua 'skip' phần tử
                .Take(take) // Lấy 'take' phần tử tiếp theo
                .ToList();

            // Hiển thị danh sách danh bạ lên ListView
            dsKq.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ten);
                lvi.SubItems.Add(x.Phone);
                lvDanhBa.Items.Add(lvi);
            });

            // Cập nhật vị trí trang hiện tại
            lblViTri.Text = (skip + take) + "/" + dsDanhBa.Count;
        }
    }
}
