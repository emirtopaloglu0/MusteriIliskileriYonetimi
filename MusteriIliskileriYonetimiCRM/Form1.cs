using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM
{
    public partial class Form1 : Form
    {

        public static Form1 instance;

        public char[] charsToTrim = { '*', ' ', '\'', '_', '-', '+', '$', '!', '^', '#', '%', '&', '/', '?', '(', ')', '=', '<', '>', '|', '£', '½', '{', '[', ']', '}' };

        public string pool = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.CloseApp();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            u_MusteriPanel1.Hide();
        }

        public void LoggedIn()
        {
            u_MusteriPanel1.Visible = true;
            loginPanel1.Visible = false ;
        }
    }
}
