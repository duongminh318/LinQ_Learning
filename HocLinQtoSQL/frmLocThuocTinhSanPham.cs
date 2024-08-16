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
    public partial class frmLocThuocTinhSanPham : Form
    {
        public frmLocThuocTinhSanPham()
        {
            InitializeComponent();
        }

        private void frmLocThuocTinhSanPham_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            /*var dsSP = context.SanPhams
                            .Select(x=>
                            new {
                                x.Ma,
                                x.Ten
                                }
                            );*/
            var dsSP = from x in context.SanPhams
                       select new { x.Ma, x.Ten };
            dgvSanPham.DataSource = dsSP.ToList();
        }
    }
}
