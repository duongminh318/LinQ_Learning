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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        List<SanPham> dsSPGoc = new List<SanPham>();
        private void btnLuuSp_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.Ma = txtMa.Text;
            sp.Ten = txtTen.Text;
            sp.SoLuong = int.Parse(txtSoLuong.Text);
            sp.DonGia = int.Parse(txtDonGia.Text);
            sp.XuatXu = txtXuatXu.Text;
            sp.HanDung = dtpHanDung.Value;
            dsSPGoc.Add(sp);
            XoaDuLieuNhapCu();
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }
        void XoaDuLieuNhapCu()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtXuatXu.Clear();
            txtMa.Focus();
        }
        void HienThiLenListView(List<SanPham>ds,ListView lv)
        {
            lv.Items.Clear();
            ds.ForEach(sp => 
            {
                ListViewItem lvi = new ListViewItem(sp.Ma);
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.SoLuong+"");
                lvi.SubItems.Add(sp.DonGia+"");
                lvi.SubItems.Add(sp.XuatXu);
                lvi.SubItems.Add(sp.HanDung.ToString("dd/MM/yyyy"));
                lv.Items.Add(lvi);
            });
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvSanPhamGoc.SelectedIndices.Count==0)
            {
                MessageBox.Show("Phải chọn sản phẩm trước khi xóa");
                return;
            }
            int vtXoa = lvSanPhamGoc.SelectedIndices[0];
            dsSPGoc.RemoveAt(vtXoa);
            HienThiLenListView(dsSPGoc, lvSanPhamGoc); ;
        }

        private void btnXoaXuatXu_Click(object sender, EventArgs e)
        {
            for(int i=dsSPGoc.Count-1;i>=0;i--)
            {
                if(string.Compare(
                    dsSPGoc[i].XuatXu,
                    txtXuatXuXoa.Text,true)==0)
                {
                    dsSPGoc.RemoveAt(i);
                }
            }
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        private void btnKiemTraQuaHan_Click(object sender, EventArgs e)
        {
            bool kq = dsSPGoc.Any(sp=> 
            {
                return sp.HanDung.Date < DateTime.Now.Date;
            });
            if(kq)
            {
                MessageBox.Show("Kho có sản phẩm hết hạn");
            }
            else
            {
                MessageBox.Show("Kho đặt chuẩn");
            }
        }

        private void btnXoaToanBoSP_Click(object sender, EventArgs e)
        {
            dsSPGoc.Clear();
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        private void btnXoaSpQuaHan_Click(object sender, EventArgs e)
        {
            dsSPGoc.RemoveAll(sp =>
                sp.HanDung.Date<DateTime.Now.Date);
            HienThiLenListView(dsSPGoc, lvSanPhamGoc);
        }

        private void btn1SPMax_Click(object sender, EventArgs e)
        {
            SanPham sp = dsSPGoc[0];
            for(int i=1;i<dsSPGoc.Count;i++)
            {
                if (sp.DonGia < dsSPGoc[i].DonGia)
                    sp = dsSPGoc[i];
            }
            //suy nghĩ cách tính max được cấp.
            List<SanPham> dsTim = new List<SanPham>() { sp };
            HienThiLenListView(dsTim, lvSanPhamTimKiem);
        }

        private void btnSanPhamQuaHan_Click(object sender, EventArgs e)
        {
            var dsTim = dsSPGoc
                .Where(x => x.HanDung.Date < DateTime.Now.Date)
                .ToList();
            HienThiLenListView(dsTim, lvSanPhamTimKiem);
        }

        private void btnLocDonGia_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtGiaMin.Text);
            int max = int.Parse(txtGiaMax.Text);
            var dsTim =from sp in dsSPGoc
                        where sp.DonGia >= min && sp.DonGia <= max
                        select sp;
            HienThiLenListView(dsTim.ToList(), lvSanPhamTimKiem);
        }
    }
}
