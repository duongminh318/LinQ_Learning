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
    public partial class frmTruyVanDanhMucQuerySyntax : Form
    {
        public frmTruyVanDanhMucQuerySyntax()
        {
            InitializeComponent();
        }

        private void frmTruyVanDanhMucQuerySyntax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            var dsDM = from x in context.DanhMucs
                       select x;
            lvDanhMuc.Items.Clear();
            foreach(var dm in dsDM)
            {
                ListViewItem lvi = new ListViewItem(dm.MaDanhMuc+"");
                lvi.SubItems.Add(dm.TenDanhMuc);
                lvDanhMuc.Items.Add(lvi);
            }
        }
    }
}
