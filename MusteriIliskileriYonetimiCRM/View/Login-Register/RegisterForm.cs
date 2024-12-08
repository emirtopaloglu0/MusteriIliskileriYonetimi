using MusteriIliskileriYonetimiCRM.Class.Musteri;
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

namespace MusteriIliskileriYonetimiCRM.View.Login_Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.CloseApp();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            if (Name_Box.Text == string.Empty
                || Surname_Box.Text == string.Empty
                || IdentityNo_Box.Text == string.Empty
                || Pass_Box.Text == string.Empty
                || Mail_Box.Text == string.Empty
                || Address_RichBox.Text == string.Empty
                || (!Male_RadioBtn.Checked && !Female_RadioBtn.Checked))
            {
                HataMesajlari.BosOlamaz();
                return;
            }



            if (C_Musteri.instance.TcDogrula(IdentityNo_Box.Text))
            {
                SoruMesajlari.instance.Kayit();
                if (SoruMesajlari.instance.res != DialogResult.Yes)
                { return; }

                char cinsiyet = (Male_RadioBtn.Checked) ? cinsiyet = 'E' : cinsiyet = 'K';

                C_Musteri customer = new C_Musteri()
                {
                    Name = Name_Box.Text,
                    Surname = Surname_Box.Text,
                    IdNo = IdentityNo_Box.Text,
                    Password = Pass_Box.Text,
                    Email = Mail_Box.Text,
                    Gender = cinsiyet,
                    Address = Address_RichBox.Text
                };

                if (C_Musteri.instance.Register(customer))
                {
                    BasariliMesajlari.KayitBasarili();
                    Close();
                }

            }
            else
                HataMesajlari.TcKimlikYanlis();

        }

        private void TextboxChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;

            char[] charsToTrim = Form1.instance.charsToTrim;

            textbox.Text = textbox.Text.Trim(charsToTrim);
            textbox.SelectionStart = textbox.Text.Length;
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
    }
}
