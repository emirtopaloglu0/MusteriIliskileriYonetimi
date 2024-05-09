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
            if (C_Musteri.instance.Login(Mail_Box.Text, Pass_Box.Text))
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
    }
}
