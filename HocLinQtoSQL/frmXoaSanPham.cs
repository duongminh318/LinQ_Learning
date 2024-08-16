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
    public partial class frmXoaSanPham : Form
    {
        public frmXoaSanPham()
        {
            InitializeComponent();
        }

        private void frmXoaSanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPhamLenListBox();
        }
        void HienThiSanPhamLenListBox()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            lstSanPham.DataSource = dsSP;
            lstSanPham.ValueMember = "Ma";
            lstSanPham.DisplayMember = "Ten";
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedValue == null) return;
            int masp = (int)lstSanPham.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams
                                .FirstOrDefault(x=>x.Ma==masp);
            if (sp != null)
            {
                try
                {
                    context.SanPhams.DeleteOnSubmit(sp);
                    context.SubmitChanges();
                    HienThiSanPhamLenListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
