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
    public partial class frmTruyVanSanPhamTheoDanhMucMethodSyntax : Form
    {
        public frmTruyVanSanPhamTheoDanhMucMethodSyntax()
        {
            InitializeComponent();
        }
        bool isFinished = false;
        private void frmTruyVanSanPhamTheoDanhMucMethodSyntax_Load(object sender, EventArgs e)
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
            if (isFinished == false) return;
            if (lstDanhMuc.SelectedIndex == -1) return;
            int madm =(int) lstDanhMuc.SelectedValue;
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams
                                        .Where(x=>x.MaDanhMuc==madm)
                                        .ToList();
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            });
        }
    }
}
