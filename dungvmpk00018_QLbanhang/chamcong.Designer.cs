﻿namespace dungvmpk00018_QLbanhang
{
    partial class chamcong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.cbbtennv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwchamcong = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chức vụ";
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.Location = new System.Drawing.Point(119, 67);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(121, 21);
            this.cbbchucvu.TabIndex = 2;
            // 
            // cbbtennv
            // 
            this.cbbtennv.FormattingEnabled = true;
            this.cbbtennv.Location = new System.Drawing.Point(119, 32);
            this.cbbtennv.Name = "cbbtennv";
            this.cbbtennv.Size = new System.Drawing.Size(121, 21);
            this.cbbtennv.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(329, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvwchamcong
            // 
            this.lvwchamcong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwchamcong.Location = new System.Drawing.Point(12, 130);
            this.lvwchamcong.Name = "lvwchamcong";
            this.lvwchamcong.Size = new System.Drawing.Size(567, 193);
            this.lvwchamcong.TabIndex = 5;
            this.lvwchamcong.UseCompatibleStateImageBehavior = false;
            this.lvwchamcong.View = System.Windows.Forms.View.Details;
            this.lvwchamcong.SelectedIndexChanged += new System.EventHandler(this.lvwchamcong_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chức vụ";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hệ số lương";
            this.columnHeader4.Width = 212;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lương";
            this.columnHeader5.Width = 92;
            // 
            // chamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 335);
            this.Controls.Add(this.lvwchamcong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbtennv);
            this.Controls.Add(this.cbbchucvu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "chamcong";
            this.Text = "chamcong";
            this.Load += new System.EventHandler(this.chamcong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbchucvu;
        private System.Windows.Forms.ComboBox cbbtennv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvwchamcong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}