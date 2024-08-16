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
    public partial class frmLuuMoiDanhMuc : Form
    {
        public frmLuuMoiDanhMuc()
        {
            InitializeComponent();
        }

        private void frmLuuMoiDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
        void HienThiDanhMucLenListBox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            lsbDanhMuc.Items.Clear();
            dsDM.ForEach(x=>
                    lsbDanhMuc.Items.Add(x.MaDanhMuc+"-"+x.TenDanhMuc));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                CSDLTestDataContext context = new CSDLTestDataContext();
                DanhMuc dm = new DanhMuc();
                dm.MaDanhMuc = int.Parse(txtMaDanhMuc.Text);
                dm.TenDanhMuc = txtTenDanhMuc.Text;
                context.DanhMucs.InsertOnSubmit(dm);
                context.SubmitChanges();
                MessageBox.Show("Đã lưu Danh Mục Thành Công");
                HienThiDanhMucLenListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
        }
    }
}
