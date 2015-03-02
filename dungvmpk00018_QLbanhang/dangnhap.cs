using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace dungvmpk00018_QLbanhang
{
    public partial class dangnhap : Form
    {
        public static clsdangnhap ngDangNhap = new clsdangnhap();
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                DataTable dt = SQLConnection.KTDangNhap(txtusername.Text, txtPassword.Text);
               
                if (dt.Rows.Count > 0)
                   
                {

                    ngDangNhap.HoTen = dt.Rows[0].ItemArray[2].ToString();
                    //ngDangNhap.Matkhau = dt.Rows[0].ItemArray[8].ToString();
                    ngDangNhap.Chucvu = dt.Rows[0].ItemArray[5].ToString();
                    ngDangNhap.Tendangnhap = dt.Rows[0].ItemArray[6].ToString();
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    main form = new main();
                    form.Show();
                    this.Hide();
                }
                
                else if (txtPassword.Text == "" | txtusername.Text == "" | (txtPassword.Text == "" & txtusername.Text == ""))
                {
                    MessageBox.Show("Chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }


            }
        

        //private void btnThoát_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        

        
        }
    }

