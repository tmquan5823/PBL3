﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if(btn_DangXuat.Visible == false)
            {
                btn_DangXuat.Visible = true;
            }
            else
            {
                btn_DangXuat.Visible = false;
            }
        }
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout?", "Logout message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_QuanLyNV_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.Clear();
            }
            UCQuanLyNhanVien uc = new UCQuanLyNhanVien();
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            lbl_form.Text = "Quản lý nhân viên";
        }

        private void btn_QuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.Clear();
            }
            UCQuanLyDoanhThu uc = new UCQuanLyDoanhThu();
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            lbl_form.Text = "Quản lý doanh thu";
        }

        private void btn_QuanLySP_Click(object sender, EventArgs e)
        {
            if(panel_main.Controls.Count > 0)
            {
                panel_main.Controls.Clear();
            }
            UCQuanLySanPham uc = new UCQuanLySanPham();
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            lbl_form.Text = "Quản lý sản phẩm";
        }

        private void btn_QuanLyKhoHang_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.Clear();
            }
            UCQuanLyKhoHang uc = new UCQuanLyKhoHang();
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            lbl_form.Text = "Quản lý kho hàng";
        }

        private void btn_QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count > 0)
            {
                panel_main.Controls.Clear();
            }
            UCQuanLyHoaDon uc = new UCQuanLyHoaDon();
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            lbl_form.Text = "Quản lý hóa đơn";
        }
    }
}
