using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dungvmpk00018_QLbanhang
{
    public partial class sanpham : Form
    {
        public sanpham()
        {
            InitializeComponent();
        }
        List<clssanpham> dsnv = new List<clssanpham>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            bool kt = KT();
            if (kt == true)
            {
                SQLConnection.themsp(txtMasp.Text, txttensp.Text, int.Parse(txtsoluong.Text), int.Parse(txtgiaban.Text), cbbtenloai.SelectedValue.ToString());

                clear();

                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
          
        
        }

        private void cbbtenloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtMasp.Text = "";
            txttensp.Text = "";
            txtsoluong.Text = "";
            txtgiaban.Text = "";
          
            cbbtenloai.SelectedIndex = 0;
        }
        private void loadloaisp()
        {
            DataTable dt = SQLConnection.loadloaisp();
            cbbtenloai.DataSource = dt;
            cbbtenloai.DisplayMember = "Tenloai";
            cbbtenloai.ValueMember = "Maloai";
        }

        private void sanpham_Load(object sender, EventArgs e)
        {
            loadloaisp();
            cbbtenloai.SelectedIndex = 0;
        }
        private bool KT()
        {
            if (txtMasp.Text == "" || txttensp.Text == "" || txtsoluong.Text == "" || txtgiaban.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }



            return true;


        }
        private void clear()
        {
            txtMasp.Text = "";
            txttensp.Text = "";

            txtsoluong.Text = "";
            txtgiaban.Text = "";
          
            cbbtenloai.SelectedIndex = 0;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            lvwsanpham.Items.Clear();
            DataTable dt = SQLConnection.loadsp();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {

            ListViewItem items = new ListViewItem((lvwsanpham.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());
            items.SubItems.Add(row.ItemArray[3].ToString());
       

            items.SubItems.Add(SQLConnection.laytenloaisp(row.ItemArray[4].ToString()));
            lvwsanpham.Items.Add(items);
        }

        private void lvwsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwsanpham.SelectedIndices.Count == 1)
            {
                int it = lvwsanpham.SelectedIndices[0];
                txtMasp.Text = lvwsanpham.Items[it].SubItems[1].Text;
                txttensp.Text = lvwsanpham.Items[it].SubItems[2].Text;

                txtsoluong.Text = lvwsanpham.Items[it].SubItems[3].Text;
                txtgiaban.Text = lvwsanpham.Items[it].SubItems[4].Text;
                cbbtenloai.Text = lvwsanpham.Items[it].SubItems[5].Text;
               


            }
        }

        private void sanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogresult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvwsanpham.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin cần xóa!", "Thông báo");
            }
            else
            {
                try
                {
                    DialogResult dialogResuit = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResuit == DialogResult.Yes)
                    {
                        int dem = lvwsanpham.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwsanpham.SelectedIndices[i];
                            string masp = lvwsanpham.Items[index].SubItems[1].Text;
                            SQLConnection.xoasp(masp);
                        }
                        List();
                        clear();
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwsanpham.SelectedIndices.Count; i++)
            {
                int index = lvwsanpham.SelectedIndices[i];
                SQLConnection.suasp(txtMasp.Text, txttensp.Text, txtsoluong.Text, txtgiaban.Text,cbbtenloai.SelectedValue.ToString());

            }
            List();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttimhoten.Text == "")
            {
                List();
            }
            else
            {
                DataTable dt = SQLConnection.Timtheotensp(txttimhoten.Text.Trim());
                lvwsanpham.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Themhienthi(row);
                }
            }
        }

    }
}
