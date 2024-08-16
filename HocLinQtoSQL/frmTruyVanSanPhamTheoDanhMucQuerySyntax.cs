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
    public partial class frmTruyVanSanPhamTheoDanhMucQuerySyntax : Form
    {
        public frmTruyVanSanPhamTheoDanhMucQuerySyntax()
        {
            InitializeComponent();
        }

        private void frmTruyVanSanPhamTheoDanhMucQuerySyntax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            tvDanhMuc.Nodes.Clear();
            foreach(DanhMuc dm in dsDM)
            {
                TreeNode nodeDM = new TreeNode(dm.TenDanhMuc);
                nodeDM.Tag = dm.MaDanhMuc;
                tvDanhMuc.Nodes.Add(nodeDM);
                List<SanPham> dsSP = (from x in context.SanPhams
                                     where x.MaDanhMuc == dm.MaDanhMuc
                                     select x).ToList();
                //List<SanPham> dsSP = dm.SanPhams.ToList();
                foreach(SanPham sp in dsSP)
                {
                    TreeNode nodeSP = new TreeNode(sp.Ten);
                    nodeSP.Tag = sp.Ma;
                    nodeDM.Nodes.Add(nodeSP);
                }
            }
        }

        private void tvDanhMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            if(e.Node.Level==0)//node danh mục
            {
                int madm = (int)e.Node.Tag;
                HienThiSanPhamLenListView(madm);
            }
            else if(e.Node.Level==1)//node sản phẩm
            {
                int masp =(int) e.Node.Tag;
                HienThi1SanPhamLenListView(masp);
            }
        }

        private void HienThi1SanPhamLenListView(int masp)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            SanPham sp = context.SanPhams
                .FirstOrDefault(x => x.Ma == masp);
            if(sp!=null)
            {
                lvSanPham.Items.Clear();
                ListViewItem lvi = new ListViewItem(sp.Ma+"");
                lvi.SubItems.Add(sp.Ten);
                lvi.SubItems.Add(sp.DonGia+"");
                lvSanPham.Items.Add(lvi);
            }
        }

        private void HienThiSanPhamLenListView(int madm)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSp =( from x in context.SanPhams
                                 where x.MaDanhMuc == madm
                                 select x).ToList();
            lvSanPham.Items.Clear();
            dsSp.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia+"");
                lvSanPham.Items.Add(lvi);
            });
        }
    }
}
