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
    public partial class loaisp : Form
    {
        public loaisp()
        {
            InitializeComponent();
        }
        List<clsloaisp> dsnv = new List<clsloaisp>();
        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            bool kt = KT();
            if (kt == true)
            {
                
                    SQLConnection.themloaisp(txtmaloai.Text, txttenloai.Text);

                    clear();

                    MessageBox.Show("Nhập hoàn thành", "Thông báo");
              
            }
        }
        private bool KT()
        {
            if (txtmaloai.Text == "" || txttenloai.Text == "" )
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }




            return true;


        }
        private void clear()
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";


        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List();
        }
        private void List()
        {
            lvwloaisp.Items.Clear();
            DataTable dt = SQLConnection.loadloaisp();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {

            ListViewItem items = new ListViewItem((lvwloaisp.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
      


            lvwloaisp.Items.Add(items);
        }

        private void lvwloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwloaisp.SelectedIndices.Count == 1)
            {
                int it = lvwloaisp.SelectedIndices[0];
                txtmaloai.Text = lvwloaisp.Items[it].SubItems[1].Text;
                txttenloai.Text = lvwloaisp.Items[it].SubItems[2].Text;

               


            }
        }

        private void loaisp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogresult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvwloaisp.SelectedIndices.Count == 0)
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
                        int dem = lvwloaisp.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwloaisp.SelectedIndices[i];
                            string maloai = lvwloaisp.Items[index].SubItems[1].Text;
                            SQLConnection.xoaloaisp(maloai);
                        }
                        List();
                        clear();
                    }

                }
                catch
                {
                    MessageBox.Show("lỗi không thể xóa dữ liệu");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lvwloaisp.SelectedIndices.Count; i++)
                {
                    int index = lvwloaisp.SelectedIndices[i];
                    SQLConnection.sualoaisp(txtmaloai.Text, txttenloai.Text);

                }
                List();
                clear();
            }
            catch
            {
                MessageBox.Show("không thể sửa mã loại sản phẩm");
            }
        }

    }
}
