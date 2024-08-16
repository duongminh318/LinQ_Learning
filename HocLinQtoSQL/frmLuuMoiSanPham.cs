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
    public partial class frmLuuMoiSanPham : Form
    {
        public frmLuuMoiSanPham()
        {
            InitializeComponent();
        }

        private void frmLuuMoiSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenListView();
            HienThiDanhMucLenCombobox();
        }
        void HienThiSanPhamLenListView()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            lvSanPham.Items.Clear();
            dsSP.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            });
        }
        void HienThiDanhMucLenCombobox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            cboDanhMuc.DataSource = dsDM;
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboDanhMuc.SelectedValue==null)
                {
                    MessageBox.Show("Bạn phải chọn Danh mục");
                    return;
                }

                CSDLTestDataContext context = new CSDLTestDataContext();
                SanPham sp = new SanPham();
                sp.Ma = int.Parse(txtMaSP.Text);
                sp.Ten = txtTenSP.Text;
                sp.DonGia = int.Parse(txtGiaSP.Text);
                int madm = (int)cboDanhMuc.SelectedValue;
                sp.MaDanhMuc = madm;
                context.SanPhams.InsertOnSubmit(sp);
                context.SubmitChanges();
                MessageBox.Show("Đã lưu sản phẩm thành công");
                HienThiSanPhamLenListView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaSP.Clear();
            txtMaSP.Focus();
        }
    }
}
