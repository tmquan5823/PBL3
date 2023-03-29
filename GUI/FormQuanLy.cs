using System;
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
        private void btn_QuanLyNV_Click(object sender, EventArgs e)
        {

        }

        private void btn_QuanLyDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
