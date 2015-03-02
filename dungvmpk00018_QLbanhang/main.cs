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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void khachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            if (dangnhap.ngDangNhap.Chucvu == "CV01      ")
            {

            } 
            if (dangnhap.ngDangNhap.Chucvu == "CV02      ")
            {
                btnnhanvien.Enabled = false;
                btnsp.Enabled = false;
            }
            if (dangnhap.ngDangNhap.Chucvu == "CV03      ")
            {
                btnthongke.Enabled = false;
                btnnhanvien.Enabled = false;
            }
         
            //if (frm_Login.NV.ChucVu == 3)
            //{
            //    btnchamcong.Enabled = false;
            //    btnQLNV.Enabled = false;


            //}
            //if (frm_Login.NV.ChucVu == 4)
            //{
            //    btnQLNV.Enabled = false;
            //    btnKhohang.Enabled = false;
            //    btnchamcong.Enabled = false;

            //}
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            qlkhachhang form = new qlkhachhang();
            form.Show();
            
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frmQLnv form = new frmQLnv();
            form.Show();
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            sanpham form = new sanpham();
            form.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlkhachhang form = new qlkhachhang();
            form.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chamcong form = new chamcong();
            form.Show();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogresult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadon form = new hoadon();
            form.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loaisp form = new loaisp();
            form.Show();
        }
    }
}
