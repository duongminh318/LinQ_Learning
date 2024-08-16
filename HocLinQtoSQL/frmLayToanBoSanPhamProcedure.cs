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
    public partial class frmLayToanBoSanPhamProcedure : Form
    {
        public frmLayToanBoSanPhamProcedure()
        {
            InitializeComponent();
        }

        private void frmLayToanBoSanPhamProcedure_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<LayToanBoSanPhamResult> dsSP = 
                context.LayToanBoSanPham().ToList();
            dataGridView1.DataSource = dsSP;
        }
    }
}
