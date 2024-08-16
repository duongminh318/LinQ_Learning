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
    public partial class frmSuaDanhMuc : Form
    {
        public frmSuaDanhMuc()
        {
            InitializeComponent();
        }

        private void frmSuaDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
        bool isFinished = false;
        void HienThiDanhMucLenListBox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            lstDanhMuc.DataSource = dsDM;
            lstDanhMuc.ValueMember = "MaDanhMuc";
            lstDanhMuc.DisplayMember = "TenDanhMuc";
            isFinished = true;
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFinished) return;
            if (lstDanhMuc.SelectedValue == null) return;
            DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
            txtMa.Text = dm.MaDanhMuc + "";
            txtTen.Text = dm.TenDanhMuc;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext();
                int madm = int.Parse(txtMa.Text);
                DanhMuc dm = context.DanhMucs
                    .FirstOrDefault(x => x.MaDanhMuc == madm);
                dm.TenDanhMuc = txtTen.Text;
                context.SubmitChanges();
                MessageBox.Show("Đã sửa danh mục OK");
                HienThiDanhMucLenListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
