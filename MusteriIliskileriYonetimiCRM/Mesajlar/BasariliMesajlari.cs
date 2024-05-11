using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM.Mesajlar
{
    internal class BasariliMesajlari
    {
        internal static void IslemeAlindi()
        {
            MessageBox.Show("Talep İşleme Alınmıştır!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void KayitBasarili()
        {
            MessageBox.Show("Kayıt İşlemi Başarılı! \nHoş gedliniz!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static void SatinAlim()
        {
            MessageBox.Show("Sipariş Başarıyla Oluşturulmuştur!\nSiparişinizi 3 gün içerisinde iptal edebilirsiniz." +
                "\nEğer iptal edilmezse teslimat yapılacaktır\nİyi günlerde kullanın!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void SiparisIptalEdildi()
        {
            MessageBox.Show("Siparişiniz Başarılı Bir Şekilde İptal Edildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void TalepOlusturuldu()
        {
            MessageBox.Show("Talep Başarılı Bir Şekilde Oluşturuldu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
