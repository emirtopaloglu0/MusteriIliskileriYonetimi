using MusteriIliskileriYonetimiCRM.Class.Musteri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriIliskileriYonetimiCRM.Properties;
using MusteriIliskileriYonetimiCRM.View.UserPanels;

namespace MusteriIliskileriYonetimiCRM.View.Login_Register
{
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            if(Mail_Box.Text == "admin" && Pass_Box.Text == "admin")
            {
                Form1.instance.AdminLoggedIn();
            }
            else if (C_Musteri.instance.Login(Mail_Box.Text, Pass_Box.Text))
            {
                Form1.instance.LoggedIn();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            Mail_Box.Text = Settings.Default.U_Mail;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                Pass_Box.PasswordChar = '\0';
            }
            else
            {
                Pass_Box.PasswordChar = '*';

            }
        }

        private void Pass_Box_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login_Btn_Click(sender, e);
            }
        }
    }
}
