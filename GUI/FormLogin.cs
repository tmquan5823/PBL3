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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void openNewForm()
        {
            if (txt_username.Text.Trim() == "quanly")
            {
                FormQuanLy frm = new FormQuanLy();
                frm.ShowDialog();
            }
            else if (txt_username.Text.Trim() == "nhanvien")
            {
                FormNhanVien frm = new FormNhanVien();
                frm.ShowDialog();
            }
            else return;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            openNewForm();
            this.Close();
        }
    }
}
