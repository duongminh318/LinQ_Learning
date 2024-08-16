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
    public partial class frmXoaDanhMuc : Form
    {
        public frmXoaDanhMuc()
        {
            InitializeComponent();
        }

        private void frmXoaDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }
        void HienThiDanhMucLenListBox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            lstDanhMuc.DataSource = dsDM;
            lstDanhMuc.ValueMember = "MaDanhMuc";
            lstDanhMuc.DisplayMember = "TenDanhMuc";
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedValue == null) return;
            int madm = (int)lstDanhMuc.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc dm = context.DanhMucs
                .FirstOrDefault(x=>x.MaDanhMuc==madm);
            if(dm!=null)
            {
                if(dm.SanPhams.Count>0)
                {
                    MessageBox.Show("Không thể xóa ["+dm.TenDanhMuc+"] vì nó có "+dm.SanPhams.Count+" sản phẩm");
                    return;
                }
                try
                {
                    context.DanhMucs.DeleteOnSubmit(dm);
                    context.SubmitChanges();
                    HienThiDanhMucLenListBox();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
