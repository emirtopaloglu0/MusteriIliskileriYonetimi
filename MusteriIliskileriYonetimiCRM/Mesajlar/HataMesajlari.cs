using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM.Mesajlar
{
    internal class HataMesajlari
    {
        internal static void BosOlamaz()
        {
            MessageBox.Show("Lütfen Boş Alan Bırakmayınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void TcKimlikYanlis()
        {
            MessageBox.Show("TC Kimlik Numaranız Geçersizdir!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void CatchError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void KullaniciVar()
        {
            MessageBox.Show("Böyle Bir Kullanıcı Bulunmaktadır. Lütfen Başka Bir E-posta veya Kimlik Numarası Deneyin", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void KullaniciBulunamadi()
        {
            MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void SifreYanlis()
        {
            MessageBox.Show("Girdiğiniz Şifre Yanlıştır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void SiparisZamanAsimi()
        {
            MessageBox.Show("Siparişinizin üstünden 3 gün geçtiği için iptal edemezsiniz!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void SatiriSeciniz()
        {
            MessageBox.Show("Sipariş Seçilemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void StokHatasi()
        {
            MessageBox.Show("Ürünleri kontrol ediniz! Bir veya daha fazla üründe stok sayısından fazla ürünü sepete eklediniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void DestekKategorisi()
        {
            MessageBox.Show("Destek Türü Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void DestekSecilemedi()
        {
            MessageBox.Show("Destek Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void IslemeAlin()
        {
            MessageBox.Show("Desteği İşleme Alınız!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
