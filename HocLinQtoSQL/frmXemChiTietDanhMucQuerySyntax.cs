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
    public partial class frmXemChiTietDanhMucQuerySyntax : Form
    {
        public frmXemChiTietDanhMucQuerySyntax()
        {
            InitializeComponent();
        }
        bool isFinished = false;
        private void frmXemChiTietDanhMucQuerySyntax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            cboDanhMuc.DataSource = dsDM;
            cboDanhMuc.ValueMember = "MaDanhMuc";
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            isFinished = true;
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFinished == false) return;
            if (cboDanhMuc.SelectedIndex == -1) return;
            int madm =(int) cboDanhMuc.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc dm = (from x in context.DanhMucs
                         where x.MaDanhMuc==madm
                         select x).FirstOrDefault();
            if(dm!=null)
            {
                txtMa.Text = dm.MaDanhMuc + "";
                txtTen.Text = dm.TenDanhMuc;
            }
        }
    }
}
