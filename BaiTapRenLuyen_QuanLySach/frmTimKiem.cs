using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapRenLuyen_QuanLySach
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            CSDLSachDataContext context = new CSDLSachDataContext();
            var dsBook = context.Books
                .Where(x=>x.BookName.Contains(txtTen.Text))
                .Select(x=>new { x.BookCode,x.BookName,x.Description});
            dgvSach.DataSource = dsBook.ToList();
        }
    }
}
