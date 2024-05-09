using MusteriIliskileriYonetimiCRM.Mesajlar;
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

        public static Form1 instance = new Form1();

        public char[] charsToTrim = { '*', ' ', '\'', '_', '-', '+', '$', '!', '^', '#', '%', '&', '/', '?', '(', ')', '=', '<', '>', '|', '£', '½', '{', '[', ']', '}' };

        public string pool = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.CloseApp();
            if(SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
