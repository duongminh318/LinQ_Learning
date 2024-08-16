using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocLinQtoSQL
{
    public partial class frmLuuMoiNhieuSanPham : Form
    {
        public frmLuuMoiNhieuSanPham()
        {
            InitializeComponent();
        }

        private void frmLuuMoiNhieuSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenListView();
            HienThiDanhMucLenCombobox();
        }
        void HienThiSanPhamLenListView()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            });
        }
        void HienThiDanhMucLenCombobox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            cboDanhMuc.DataSource = context.DanhMucs.ToList();
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }
        List<SanPham> dsSPMoi = new List<SanPham>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedValue == null) return;
            int madm = (int)cboDanhMuc.SelectedValue;
            SanPham sp = new SanPham();
            sp.Ma = int.Parse(txtMaSP.Text);
            sp.Ten = txtTenSP.Text;
            sp.DonGia = int.Parse(txtDonGia.Text);
            sp.MaDanhMuc = madm;
            dsSPMoi.Add(sp);

            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn muốn lưu "+dsSPMoi.Count+" sản phẩm này không?",
                "Hỏi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(ret==DialogResult.Yes)
            {
                try
                {
                    CSDLTestDataContext context = new CSDLTestDataContext();
                    context.SanPhams.InsertAllOnSubmit(dsSPMoi);
                    context.SubmitChanges();
                    MessageBox.Show("Đã lưu " + dsSPMoi.Count + " sản phẩm thành công");
                    HienThiSanPhamLenListView();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
