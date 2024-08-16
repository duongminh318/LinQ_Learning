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
    public partial class frmGiaMoi : Form
    {
        public frmGiaMoi()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
