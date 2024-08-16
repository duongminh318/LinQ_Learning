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
    public partial class frmTruyVanDanhMucMethodSyntax : Form
    {
        public frmTruyVanDanhMucMethodSyntax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context
                                .DanhMucs
                                .ToList();
            lstDanhMuc.Items.Clear();
            dsDM.ForEach(x=> {
                lstDanhMuc.Items.Add(x.MaDanhMuc+"-"+x.TenDanhMuc);
            });
        }
    }
}
