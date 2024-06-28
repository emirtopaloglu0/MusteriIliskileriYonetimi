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
            if (Name_Box.Text != string.Empty && Surname_Box.Text != string.Empty
                && IdentityNo_Box.Text != string.Empty
                && Pass_Box.Text != string.Empty
                && Mail_Box.Text != string.Empty
                && Address_RichBox.Text != string.Empty
                && (Male_RadioBtn.Checked || Female_RadioBtn.Checked))
            {
                if (C_Musteri.instance.TcDogrula(IdentityNo_Box.Text))
                {
                    SoruMesajlari.instance.Kayit();
                    if (SoruMesajlari.instance.res != DialogResult.Yes)
                    { return; }

                    ActiveForm.UseWaitCursor = true;
                    char cinsiyet;

                    if (Male_RadioBtn.Checked) cinsiyet = 'E';
                    else cinsiyet = 'K';

                    if (C_Musteri.instance.Register(Name_Box.Text, Surname_Box.Text, IdentityNo_Box.Text,
                        Pass_Box.Text, Mail_Box.Text, cinsiyet, Address_RichBox.Text))
                    {
                        BasariliMesajlari.KayitBasarili();
                        ActiveForm.UseWaitCursor = false;
                        Close();
                    }

                }
                else
                    HataMesajlari.TcKimlikYanlis();
            }
            else
                HataMesajlari.BosOlamaz();
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
