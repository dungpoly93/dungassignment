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
    public partial class frmQLnv : Form
    {
        public frmQLnv()
        {
            InitializeComponent();
        }
        List<clsnhanvien> dsnv = new List<clsnhanvien>();

       

            private void cbbchucvu_SelectedIndexChanged(object sender, EventArgs e)
    {

        }

            //private void dtmNgaySinh_ValueChanged(object sender, EventArgs e)
            //{

            //}

            private void cbbgioitinh_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void btnthem_Click(object sender, EventArgs e)
            {
                 bool kt = KT();
            if (kt == true)
            {
                SQLConnection.themnhanvien(txtMaNV1.Text, txttennv.Text, txtdiachi.Text, txtsdt.Text, cbbgioitinh.Text, cbbchucvu.SelectedValue.ToString());

                clear();
              
                MessageBox.Show("Nhập hoàn thành", "Thông báo");
            }
          
        
            }

            private void btnnhaplai_Click(object sender, EventArgs e)
            {
            txtMaNV1.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text="";
            cbbgioitinh.SelectedIndex = 0;
            cbbchucvu.SelectedIndex = 0;
           
        }
            private void Loadchucvu()
            {
                DataTable dt = SQLConnection.loadchucvu();
                cbbchucvu.DataSource = dt;
                cbbchucvu.DisplayMember = "TenCV";
                cbbchucvu.ValueMember = "MaCV";
            }
            private void Form1_Load(object sender, EventArgs e)
            {


                Loadchucvu();
                cbbchucvu.SelectedIndex = 0;
               
            }
            private bool KT()
            {
                if (txtMaNV1.Text == "" || txttennv.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
                {
                    MessageBox.Show("Chưa nhập dữ liệu đủ vào các ô, vui lòng nhập liệu lại", "Thông báo");
                    return false;
                }
               


                return true;


            }
            private void clear()
            {
                txtMaNV1.Text = "";
                txttennv.Text = "";
              
                txtdiachi.Text = "";
                txtsdt.Text = "";
                cbbgioitinh.SelectedIndex = 0;
                cbbchucvu.SelectedIndex = 0;
            }

            private void btnhienthi_Click(object sender, EventArgs e)
            {
                List();
            }  
                
            private void List()
            {
              
                    lvwNhanVien.Items.Clear();
                    DataTable dt = SQLConnection.loadnhanvien();
                    foreach (DataRow row in dt.Rows)
                    {
                        Themhienthi(row);
                    }
                
            }
            private void Themhienthi(DataRow row)
            {
                try
                {

                    ListViewItem items = new ListViewItem((lvwNhanVien.Items.Count + 1).ToString());
                    items.SubItems.Add(row.ItemArray[0].ToString());
                    items.SubItems.Add(row.ItemArray[1].ToString());
                    items.SubItems.Add(row.ItemArray[2].ToString());
                    items.SubItems.Add(row.ItemArray[3].ToString());
                    items.SubItems.Add(row.ItemArray[4].ToString());

                    items.SubItems.Add(SQLConnection.laychucvu(row.ItemArray[5].ToString()));
                    lvwNhanVien.Items.Add(items);
                }
            catch
                {
                    MessageBox.Show("lỗi đó");
                }
            }

            private void frmQLnv_FormClosing(object sender, FormClosingEventArgs e)
            {
                DialogResult dialogresult = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogresult == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lvwNhanVien.SelectedIndices.Count == 1)
                {
                    int it = lvwNhanVien.SelectedIndices[0];
                    txtMaNV1.Text = lvwNhanVien.Items[it].SubItems[1].Text;
                    txttennv.Text = lvwNhanVien.Items[it].SubItems[2].Text;
                  
                    txtdiachi.Text = lvwNhanVien.Items[it].SubItems[3].Text;
                    txtsdt.Text = lvwNhanVien.Items[it].SubItems[4].Text;
                    cbbgioitinh.Text = lvwNhanVien.Items[it].SubItems[5].Text;
                    cbbchucvu.Text = lvwNhanVien.Items[it].SubItems[6].Text;
                    

                }
            }

            private void btnxoa_Click(object sender, EventArgs e)
            {

                if (lvwNhanVien.SelectedIndices.Count == 0)
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
                            int dem = lvwNhanVien.SelectedIndices.Count;
                            for (int i = dem - 1; i >= 0; i--)
                            {
                                int index = lvwNhanVien.SelectedIndices[i];
                                string manv = lvwNhanVien.Items[index].SubItems[1].Text;
                                SQLConnection.xoa(manv);
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

            public string manv { get; set; }

            private void btnsua_Click(object sender, EventArgs e)
            {
                for (int i = 0; i < lvwNhanVien.SelectedIndices.Count; i++)
                {
                    int index = lvwNhanVien.SelectedIndices[i];
                    SQLConnection.sua(txtMaNV1.Text, txttennv.Text, txtdiachi.Text, txtsdt.Text, cbbgioitinh.Text, cbbchucvu.SelectedValue.ToString());

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
                    DataTable dt = SQLConnection.TimTheoHoTen(txttimhoten.Text.Trim());
                    lvwNhanVien.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        Themhienthi(row);
                    }
                }
            }

            private void txttimhoten_TextChanged(object sender, EventArgs e)
            {

            }
    }

       
    
     
    }

