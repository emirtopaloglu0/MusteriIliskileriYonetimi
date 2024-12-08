using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Properties;
using MusteriIliskileriYonetimiCRM.View;
using MusteriIliskileriYonetimiCRM.View.AdminPanels;
using MusteriIliskileriYonetimiCRM.View.UserPanels;
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
            a_AdminPanel1.Hide();
            u_MusteriPanel1.Hide();
            this.Opacity = 0;
            LoadingScreen loadingScreen = new LoadingScreen();
            loadingScreen.Show();
        }

        public void LoggedIn()
        {
            u_MusteriPanel1.Visible = true;
            loginPanel1.Visible = false ;
            U_MusteriPanel.instance.LoggedIn();
        }

        internal void AdminLoggedIn()
        {
            u_MusteriPanel1.Visible = false;
            loginPanel1.Visible = false;
            a_AdminPanel1.Visible = true;
            A_AdminPanel.instance.LoadData();
        }


        internal void ShowForm()
        {
            this.Opacity = 100;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
