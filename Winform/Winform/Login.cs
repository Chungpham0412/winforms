using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtEmail.Text;
            string pass = txtPassword.Text;
            if(user == "admin" && pass == "123456")
            {
                this.Hide();
                Main m = new Main();
                m.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
