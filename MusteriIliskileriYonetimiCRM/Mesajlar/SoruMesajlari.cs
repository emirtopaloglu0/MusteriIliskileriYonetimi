using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM.Mesajlar
{
    internal class SoruMesajlari
    {
        public static SoruMesajlari instance = new SoruMesajlari();
        public DialogResult res;

        public void CloseApp()
        {
            res = MessageBox.Show("Çıkmak İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void Kayit()
        {
            res = MessageBox.Show("Kayıt Olmak İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void SepetOnay()
        {
            res = MessageBox.Show("Sepeti Onaylamak İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void SepetTemizle()
        {
            res = MessageBox.Show("Sepeti Temizlemek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void SifreDegis()
        {
            res = MessageBox.Show("Şifrenizi Değiştirmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void SiparisIptal()
        {
            res = MessageBox.Show("Siparişi İptal Etmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void TalepOlustur()
        {
            res = MessageBox.Show("Talep Oluşturmak İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void UrunSilme()
        {
            res = MessageBox.Show("Ürünü Silmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
