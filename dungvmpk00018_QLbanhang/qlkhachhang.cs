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
    public partial class qlkhachhang : Form
    {
        public qlkhachhang()
        {
            InitializeComponent();
        }
        List<clskhachhang> dsnv = new List<clskhachhang>();

        private void txtMaNV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {

                bool kt = KT();
                if (kt == true)
                {
                    SQLConnection.themkhachhang(txtMakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text);

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
            txtMakh.Text = "";
            txttenkh.Text = "";

            txtdiachi.Text = "";
            txtsdt.Text = "";

        }
        private bool KT()
        {
            if (txtMakh.Text == "" || txttenkh.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                return false;
            }




            return true;


        }
        private void clear()
        {
            txtMakh.Text = "";
            txttenkh.Text = "";

            txtdiachi.Text = "";
            txtsdt.Text = "";

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            List();
            //Hienthi();

        }
        private void List()
            
        {
            lvwkhachhang.Items.Clear();
            DataTable dt = SQLConnection.loadkhachhang();
            foreach (DataRow row in dt.Rows)
            {
                Themhienthi(row);
            }
        }
        private void Themhienthi(DataRow row)
        {
            
       

                ListViewItem items = new ListViewItem((lvwkhachhang.Items.Count + 1).ToString());
                items.SubItems.Add(row.ItemArray[0].ToString());
                items.SubItems.Add(row.ItemArray[1].ToString());
                items.SubItems.Add(row.ItemArray[2].ToString());
                items.SubItems.Add(row.ItemArray[3].ToString());


                lvwkhachhang.Items.Add(items);
            
        }
        private void qlkhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogresult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvwkhachhang.SelectedIndices.Count == 0)
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
                        int dem = lvwkhachhang.SelectedIndices.Count;
                        for (int i = dem - 1; i >= 0; i--)
                        {
                            int index = lvwkhachhang.SelectedIndices[i];
                            string makh = lvwkhachhang.Items[index].SubItems[1].Text;
                            SQLConnection.xoakhachhang(makh);
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

        private void lvwkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwkhachhang.SelectedIndices.Count == 1)
            {
                int it = lvwkhachhang.SelectedIndices[0];
                txtMakh.Text = lvwkhachhang.Items[it].SubItems[1].Text;
                txttenkh.Text = lvwkhachhang.Items[it].SubItems[2].Text;
              
                txtdiachi.Text = lvwkhachhang.Items[it].SubItems[3].Text;
                txtsdt.Text = lvwkhachhang.Items[it].SubItems[4].Text;
               

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lvwkhachhang.SelectedIndices.Count; i++)
            {
                int index = lvwkhachhang.SelectedIndices[i];
                SQLConnection.suakh(txtMakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text);

            }
            List();
            clear();
        }

        private void qlkhachhang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txttimhoten.Text == "")
            {
                List();
            }
            else
            {
                DataTable dt = SQLConnection.Timtheotenkh(txttimhoten.Text.Trim());
                lvwkhachhang.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    Themhienthi(row);
                }
            }
        }
    }
}