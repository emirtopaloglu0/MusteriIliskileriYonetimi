using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Class.Popup;
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
using MusteriIliskileriYonetimiCRM.Properties;

namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    public partial class U_AyarlarPanel : UserControl
    {
        public U_AyarlarPanel()
        {
            InitializeComponent();
        }

        private void ChangePass_Btn_Click(object sender, EventArgs e)
        {
            var musteri = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            if (musteri.Sifre == Oldpass_Box.Text)
            {
                SoruMesajlari.instance.SifreDegis();
                if (SoruMesajlari.instance.res != DialogResult.Yes)
                { return; }

                musteri.Sifre = NewPass_Box.Text;
                DB_Connection.db.SaveChanges();
                Oldpass_Box.Text = string.Empty;
                NewPass_Box.Text = string.Empty;
                Popup.instance.Success("Şifre Değiştirildi!",
                    "Şifreniz Başarıyla Değiştirilmiştir. Şifrenizi Unutmayın.");

            }
            else
                HataMesajlari.SifreYanlis();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NewPass_Box.PasswordChar = '\0';
            }
            else
            {
                NewPass_Box.PasswordChar = '*';
            }
        }
    }
}
