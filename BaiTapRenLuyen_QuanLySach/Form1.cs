using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaiTapRenLuyen_QuanLySach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiNhaXuatBanLenListBox();
        }
        bool isFinished = false;
        void HienThiNhaXuatBanLenListBox()
        {
            CSDLSachDataContext context = new CSDLSachDataContext();
            lstNhaXuatBan.DataSource = context.Publishers.ToList();
            lstNhaXuatBan.ValueMember = "PublisherCode";
            lstNhaXuatBan.DisplayMember = "PublisherName";
            isFinished = true;
        }

        private void picHinh_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                picHinh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void lstNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFinished == false) return;
            if (lstNhaXuatBan.SelectedValue == null) return;
            string publisherCode =(string) lstNhaXuatBan.SelectedValue;
            List<Book> dsBook = DanhSachBookTheoPublisher(publisherCode);
            HienThiBookLenListView(dsBook);
        }
        List<Book> DanhSachBookTheoPublisher(string publisherCode)
        {
            CSDLSachDataContext context = new CSDLSachDataContext();
            List<Book> dsBook = context.Books
                .Where(x => x.PublisherCode == publisherCode)
                .ToList();
            return dsBook;
        }

        private void HienThiBookLenListView(List<Book> dsBook)
        {
            lvSach.Items.Clear();
            dsBook.ForEach(x=> {
                ListViewItem lvi = new ListViewItem((lvSach.Items.Count+1)+"");
                lvi.SubItems.Add(x.BookCode);
                lvi.SubItems.Add(x.BookName);
                lvi.SubItems.Add(x.Description);
                lvSach.Items.Add(lvi);
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CSDLSachDataContext context = new CSDLSachDataContext();
            Book b = context.Books.FirstOrDefault(x=>x.BookCode==txtMa.Text);
            if(b==null)
            {
                b = new Book();
                context.Books.InsertOnSubmit(b);
            }
            b.BookCode = txtMa.Text;
            b.BookName = txtTen.Text;
            b.Description = rtbMoTa.Text;
            if(picHinh.Image!=null)
            {
                
                MemoryStream ms = new MemoryStream();
                picHinh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                b.Image = new System.Data.Linq.Binary(ms.ToArray());
            }
            b.PublisherCode = (string)lstNhaXuatBan.SelectedValue;
            context.SubmitChanges();
            List<Book> dsBook = DanhSachBookTheoPublisher(b.PublisherCode);
            HienThiBookLenListView(dsBook);
        }

        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSach.SelectedItems[0];
            string bookCode = lvi.SubItems[1].Text;
            CSDLSachDataContext context = new CSDLSachDataContext();
            Book b = context.Books.FirstOrDefault(x=>x.BookCode==bookCode);
            txtMa.Text = b.BookCode;
            txtTen.Text = b.BookName;
            rtbMoTa.Text = b.Description;
            try
            {
                if (b.Image != null)
                {
                    byte[] arrByteHinh = b.Image.ToArray();
                    MemoryStream ms = new MemoryStream(arrByteHinh);
                    picHinh.Image = Image.FromStream(ms);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            frm.Show();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            rtbMoTa.Clear();
            picHinh.Image = null;
            txtMa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count == 0)
                return;
            ListViewItem lvi = lvSach.SelectedItems[0];
            string bookCode = lvi.SubItems[1].Text;
            CSDLSachDataContext context = new CSDLSachDataContext();
            Book b = context.Books.FirstOrDefault(x => x.BookCode == bookCode);
            DialogResult ret = MessageBox.Show(
                "Thím có chắc chắn muốn xóa["+b.BookName+"]?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk);
            if(ret==DialogResult.Yes)
            {
                string publisherCode = b.PublisherCode;

                context.Books.DeleteOnSubmit(b);
                context.SubmitChanges();

                List<Book> dsBook = DanhSachBookTheoPublisher(publisherCode);
                HienThiBookLenListView(dsBook);
            }
        }
    }
}
