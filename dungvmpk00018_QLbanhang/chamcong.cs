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
    public partial class chamcong : Form
    {
        public chamcong()
        {
            InitializeComponent();
        }

        private void chamcong_Load(object sender, EventArgs e)
        {
           
            loadnvlencbb();
            
        }
        private void loadnv()
        {
            lvwchamcong.Items.Clear();
            
                DataTable dt = SQLConnection.laynv();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lvwchamcong.Items.Add((i + 1).ToString());
                    lvwchamcong.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                    lvwchamcong.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    lvwchamcong.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    lvwchamcong.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
               
                }
            
            
        }
        private void loadnvlencbb()
        {
            DataTable dt = SQLConnection.loadnhanvien();
            cbbtennv.DataSource = dt;
            cbbtennv.DisplayMember = "TenNV";
            cbbtennv.ValueMember = "MaNV";
            DataTable dt1 = SQLConnection.loadchucvu();
            cbbchucvu.DataSource = dt1;
            cbbchucvu.DisplayMember = "TenCV";
            cbbchucvu.ValueMember = "MaCV";
        }
        private void Themhienthi(DataRow row)
        {

            ListViewItem items = new ListViewItem((lvwchamcong.Items.Count + 1).ToString());
            items.SubItems.Add(row.ItemArray[1].ToString());
            items.SubItems.Add(row.ItemArray[2].ToString());
            items.SubItems.Add(row.ItemArray[3].ToString());
            items.SubItems.Add(row.ItemArray[4].ToString());

        }

        private void lvwchamcong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadnv();
        }
    }
}
