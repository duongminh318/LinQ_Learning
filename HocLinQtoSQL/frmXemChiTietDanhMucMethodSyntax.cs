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
    public partial class frmXemChiTietDanhMucMethodSyntax : Form
    {
        public frmXemChiTietDanhMucMethodSyntax()
        {
            InitializeComponent();
        }

        private void frmXemChiTietDanhMucMethodSyntax_Load(object sender, EventArgs e)
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<DanhMuc> dsDM = context.DanhMucs.ToList();
            pnDanhMuc.Controls.Clear();
            foreach(DanhMuc dm in dsDM)
            {
                Button btn = new Button();
                btn.BackColor = Color.WhiteSmoke;
                btn.Text = dm.TenDanhMuc;
                btn.Tag = dm.MaDanhMuc;
                btn.Width = 250;
                btn.Height = 50;
                pnDanhMuc.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }
        Button btnPrevious = null;
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btnPrevious!=null)
            {
                btnPrevious.BackColor = Color.WhiteSmoke;
            }
            btnPrevious = btn;
            btn.BackColor = Color.Yellow;

            int ma =(int) btn.Tag;
            CSDLTestDataContext context = new CSDLTestDataContext();
            DanhMuc dm = context.DanhMucs
                .FirstOrDefault(x => x.MaDanhMuc == ma);
            if(dm!=null)
            {
                txtMa.Text = dm.MaDanhMuc + "";
                txtTen.Text = dm.TenDanhMuc;
            }
        }
    }
}
