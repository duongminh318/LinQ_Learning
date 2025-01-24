using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapRenLuyenKyThuatLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXemSNT_Click(object sender, EventArgs e)
        {
            int n = txtN.LayGiaTriNguyen();
            // Lấy giá trị số nguyên từ TextBox `txtN`. Nếu không nhập được số, giá trị mặc định là 0.

            lstSNT.Items.Clear();
            // Xóa toàn bộ các mục hiện có trong danh sách `lstSNT` để chuẩn bị thêm mới.

            List<int> dsNT = n.DanhSachSoNguyenTo();
            // Lấy danh sách các số nguyên tố từ 2 đến n bằng phương thức mở rộng `DanhSachSoNguyenTo`.

            foreach (int x in dsNT)
                lstSNT.Items.Add(x);
            // Duyệt từng số nguyên tố trong danh sách và thêm vào danh sách hiển thị `lstSNT`.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnXemSNT.TuDoiMauNen();
        }
    }
}
