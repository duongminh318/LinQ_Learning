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
    public partial class frmTimKiemVaSapXep : Form
    {
        public frmTimKiemVaSapXep()
        {
            InitializeComponent();
        }
        List<SanPham> dsSP = null;
        private void btnTim_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            int gia = int.Parse(txtGia.Text);
            dsSP = context.SanPhams
                        .Where(x => x.DonGia > gia)
                        .ToList();
            HienThiLenListView();
        }
        void HienThiLenListView()
        {
            lvSanPham.Items.Clear();
            dsSP.ForEach(x=> {
                ListViewItem lvi = new ListViewItem(x.Ma+"");
                lvi.SubItems.Add(x.Ten);
                lvi.SubItems.Add(x.DonGia + "");
                lvSanPham.Items.Add(lvi);
            });
        }

        private void lvSanPham_ColumnClick(object sender,
            ColumnClickEventArgs e)
        {
            ColumnHeader col = lvSanPham.Columns[e.Column];
            if(e.Column==0)//cột mã
            {
                if(col.Tag==null || col.Tag.ToString()=="des")
                {
                    dsSP = dsSP.OrderBy(x => x.Ma).ToList();
                    col.Tag = "asc";
                }
                else
                {
                    dsSP = dsSP.OrderByDescending(x => x.Ma).ToList();
                    col.Tag = "des";
                }
            }
            else if(e.Column==1)//cột tên
            {
                if(col.Tag==null ||col.Tag.ToString()=="des")
                {
                    dsSP = dsSP.OrderBy(x=>x.Ten).ToList();
                    col.Tag = "asc";
                }
                else
                {
                    dsSP = dsSP.OrderByDescending(x => x.Ten).ToList();
                    col.Tag = "des";
                }
            }
            else if(e.Column==2)//cột giá
            {
                if(col.Tag==null || col.Tag.ToString()=="des")
                {
                    dsSP = dsSP.OrderBy(x=>x.DonGia).ToList();
                    col.Tag = "asc";
                }
                else
                {
                    dsSP = dsSP.OrderByDescending(x=>x.DonGia).ToList();
                    col.Tag = "des";
                }
            }
            HienThiLenListView();
        }
    }
}
