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
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }
        List<clshoadon> dsnv = new List<clshoadon>();
        private void btnthem_Click(object sender, EventArgs e)
        {
  try
            {

                bool kt = KT();
                if (kt == true)
                {
                    SQLConnection.themhd(txtMaHD.Text, dtpNgaylap.Value, int.Parse(txtTongtien.Text));

                    clear();

                    MessageBox.Show("Nhập hoàn thành", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            dtpNgaylap.Value = DateTime.Now;
            txtTongtien.Text = "";
        }
        private bool KT()
        {
            if (txtMaHD.Text == "" || txtTongtien.Text == "" )
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }




            return true;


        }
        private void clear()
        {
            txtMaHD.Text = "";
            dtpNgaylap.Value = DateTime.Now;
            txtTongtien.Text = "";

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {

            List();
        }
        private void List()
        {
            lvwhoadon.Items.Clear();
            DataTable dt = SQLConnection.loadhd();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {



            ListViewItem items = new ListViewItem((lvwhoadon.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[0].ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());
           


            lvwhoadon.Items.Add(items);

        }

        private void hoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogresult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (lvwhoadon.SelectedIndices.Count == 0)
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
                        int dem = lvwhoadon.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwhoadon.SelectedIndices[i];
                            string mahd = lvwhoadon.Items[index].SubItems[1].Text;
                            SQLConnection.xoahd(mahd);
                        }
                        List();
                        clear();
                    }
                }
                catch
                {
                    MessageBox.Show("loi xay ra");
                }

            }
        }

        private void lvwhoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwhoadon.SelectedIndices.Count == 1)
            {
                int it = lvwhoadon.SelectedIndices[0];
                txtMaHD.Text = lvwhoadon.Items[it].SubItems[1].Text;
                dtpNgaylap.Text = lvwhoadon.Items[it].SubItems[2].Text;

                txtTongtien.Text = lvwhoadon.Items[it].SubItems[3].Text;
           

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwhoadon.SelectedIndices.Count; i++)
            {
                int index = lvwhoadon.SelectedIndices[i];
                SQLConnection.suahd1(txtMaHD.Text, dtpNgaylap.Value,int.Parse(txtTongtien.Text),txtMaHD.Text);

            }
            List();
            clear();
        }       
        }
    }

