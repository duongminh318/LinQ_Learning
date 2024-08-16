using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTongHop_QLSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
        bool isFinishedForListBox = false;
        void HienThiDanhMucLenListBox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            lstDanhMuc.DataSource = context.DanhMucs.ToList();
            lstDanhMuc.ValueMember = "MaDanhMuc";
            lstDanhMuc.DisplayMember = "TenDanhMuc";
            isFinishedForListBox = true;
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFinishedForListBox == false) return;
            if (lstDanhMuc.SelectedValue == null) return;
            int madm = (int)lstDanhMuc.SelectedValue;
            List<SanPham> dsSP = TaiSanPhamTheoDanhMuc(madm);
            HienThiSanPhamLenListView(dsSP);
        }
        List<SanPham> TaiSanPhamTheoDanhMuc(int madm)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams
                .Where(x => x.MaDanhMuc == madm)
                .ToList();
            return dsSP;
        }

        private void HienThiSanPhamLenListView(List<SanPham> dsSP)
        {
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSanPham.Items.Add(lvi);
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtMa.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams
                .FirstOrDefault(x=>x.Ma==masp);
            if(sp==null)
            {
                //chính là thêm mới vì chưa tồn tại mã
                sp = new SanPham();
                context.SanPhams.InsertOnSubmit(sp);
            }
            sp.Ma = masp;
            sp.Ten = txtTen.Text;
            sp.DonGia = int.Parse(txtGia.Text);
            sp.MaDanhMuc = (int)lstDanhMuc.SelectedValue;
            context.SubmitChanges();
            List<SanPham> dsSp = 
                TaiSanPhamTheoDanhMuc((int)lstDanhMuc.SelectedValue);
            HienThiSanPhamLenListView(dsSp);
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSanPham.SelectedItems[0];
            int masp = int.Parse(lvi.SubItems[0].Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams.FirstOrDefault(x=>x.Ma==masp);
            txtMa.Text = sp.Ma + "";
            txtTen.Text = sp.Ten;
            txtGia.Text = sp.DonGia + "";
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtGia.Clear();
            txtMa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(txtMa.Text);
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams
                .FirstOrDefault(x => x.Ma == masp);
            context.SanPhams.DeleteOnSubmit(sp);
            context.SubmitChanges();
            List<SanPham> dsSp =
                TaiSanPhamTheoDanhMuc((int)lstDanhMuc.SelectedValue);
            HienThiSanPhamLenListView(dsSp);
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            int madm = (int)lstDanhMuc.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc dm = context.DanhMucs
                .FirstOrDefault(x=>x.MaDanhMuc==madm);
            if(dm.SanPhams.Count>0)
            {
                MessageBox.Show("Danh mục ["+dm.TenDanhMuc+"] có "+dm.SanPhams.Count +" sản phẩm==>không cho xóa");
            }
            else
            {
                context.DanhMucs.DeleteOnSubmit(dm);
                context.SubmitChanges();
                HienThiDanhMucLenListBox();
            }
        }

        private void mnuThem_Click(object sender, EventArgs e)
        {
            frmDanhMuc frm = new frmDanhMuc();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                CSDLTestDataContext context = new CSDLTestDataContext();
                DanhMuc dm = new DanhMuc();
                dm.MaDanhMuc = int.Parse(frm.txtMa.Text);
                dm.TenDanhMuc = frm.txtTen.Text;
                context.DanhMucs.InsertOnSubmit(dm);
                context.SubmitChanges();
                HienThiDanhMucLenListBox();
            }
        }
    }
}
