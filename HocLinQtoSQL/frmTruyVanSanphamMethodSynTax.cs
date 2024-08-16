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
    public partial class frmTruyVanSanphamMethodSynTax : Form
    {
        public frmTruyVanSanphamMethodSynTax()
        {
            InitializeComponent();
        }

        private void frmTruyVanSanphamMethodSynTax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            dataGridView1.DataSource = dsSP;
        }
    }
}
