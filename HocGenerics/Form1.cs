using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocGenerics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> dsInt = new List<int>(); // create 1 list for save number
        //List<dataType> nameList= new List<dataType> //use save list variables
        private void btnTao_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            Random rd = new Random();
            for(int i=0;i<n;i++)
            {
                int x = rd.Next(100);
                dsInt.Add(x);           // add random number just created to list
            }
            dsInt.AddRange(new int[] { 113, 114 }); // add 2 defaul number to list
            lstSo.Items.Clear();
            for(int i=0;i<dsInt.Count;i++)
            {
                lstSo.Items.Add(dsInt[i]);     // add number in list to ListView
                // 
            }
        }

        private void lstSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndex != -1) // choice == true
            {
                txtGiaTri.Text = dsInt[lstSo.SelectedIndex] + ""; // get value number been choice in listView
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lstSo.SelectedIndex!=-1)  // choice==true
            {
                dsInt[lstSo.SelectedIndex] = int.Parse(txtGiaTri.Text); // edit number in List number
                lstSo.Items[lstSo.SelectedIndex] = dsInt[lstSo.SelectedIndex]; // set number in listView= number in List Number
            }
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndex != -1)
            {
                dsInt.RemoveAt(lstSo.SelectedIndex); // remove on list
                lstSo.Items.Clear();        // clear in ListView
                for (int i = 0; i < dsInt.Count; i++)
                {
                    lstSo.Items.Add(dsInt[i]); // loading again ListView
                }
            }
            else
            {
                MessageBox.Show("Thím Chưa chọn, không xóa được");
            }
        }
        Dictionary<int, string> dicSV = new Dictionary<int, string>();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int maSv = int.Parse(txtMa.Text);
            string tenSv = txtTen.Text;
            dicSV.Add(maSv, tenSv);
            txtMa.Text = "";
            txtTen.Text = "";

            HienThiSinhVien();
            //ok
        }

        private void HienThiSinhVien()
        {
            lvSinhVien.Items.Clear();
            foreach(KeyValuePair<int,string> item in dicSV)
            {
                ListViewItem lvi = new ListViewItem(item.Key + "");
                lvi.SubItems.Add(item.Value);
                lvSinhVien.Items.Add(lvi);
                // 12/01/2025 sẽ học linq
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0) return;
            ListViewItem lvi = lvSinhVien.SelectedItems[0];
            int ma =int.Parse(lvi.SubItems[0].Text);
            string ten = dicSV[ma];
            txtMa.Text = ma + "";
            txtTen.Text = ten;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMa.Text);
            dicSV.Remove(ma);
            HienThiSinhVien();
        }
    }
}
