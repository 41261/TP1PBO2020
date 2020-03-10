using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_PBO
{
    public partial class FormLogin : Form
    {
        Login log = new Login();
        FormMenu menu = new FormMenu();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelpassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            log.username = Convert.ToString(textBoxUsername.Text);
            log.password = Convert.ToString(textBoxPassword.Text);

            if(log.username == "" && log.password == "pbo123" || log.username != "" && log.password != "pbo123" || log.username == "" && log.password == "")
            {
                MessageBox.Show("Username atau password salah, silahkan login lagi");
            }
            else
            {
                this.Hide();
                menu.ShowDialog();
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                this.Show();
            }
        }
    }
}
