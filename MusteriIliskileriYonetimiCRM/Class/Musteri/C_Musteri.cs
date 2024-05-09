using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriIliskileriYonetimiCRM.Properties;

namespace MusteriIliskileriYonetimiCRM.Class.Musteri
{
    internal class C_Musteri
    {
        public static C_Musteri instance = new C_Musteri();


        internal bool IsMusteriExist(string kimlik) //e-posta da kontrol edilebilirdi.
        {

            var user = DB_Connection.db.Musteriler.FirstOrDefault(x => x.KimlikNo == kimlik);

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        Model.Musteriler FindMusteri(string mail)
        {
            var user = DB_Connection.db.Musteriler.FirstOrDefault(x => x.Posta == mail);
            if (user != null)
                return user;
            else
                return null;
        }

        internal bool TcDogrula(string tcKimlikNo)
        {
            bool returnvalue = false;
            if (tcKimlikNo.Length == 11)
            {
                Int64 ATCNO, BTCNO, TcNo;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                TcNo = Int64.Parse(tcKimlikNo);

                ATCNO = TcNo / 100;
                BTCNO = TcNo / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                returnvalue = ((BTCNO * 100) + (Q1 * 10) + Q2 == TcNo);
            }
            return returnvalue;
        }

        internal bool Login(string mail, string sifre)
        {
            var user = FindMusteri(mail);

            if (user != null)
            {
                if (user.Sifre == sifre)
                {
                    Settings.Default.U_Adi = user.Ad;
                    Settings.Default.U_Soyadi = user.Soyad;
                    Settings.Default.U_Id = user.Id;
                    Settings.Default.U_Mail = user.Posta;
                    Settings.Default.Save();


                    return true;
                }
                else
                    HataMesajlari.SifreYanlis();
            }
            else
                HataMesajlari.KullaniciBulunamadi();

            return false;
        }

        internal bool Register(string ad, string soyad, string kimlik, string sifre, string mail,
            char cinsiyet, string adres)
        {
            try
            {
                if (IsMusteriExist(kimlik) != true)
                {
                    if (FindMusteri(mail) == null)
                    {
                        Musteriler musteri = new Musteriler();
                        musteri.Ad = ad;
                        musteri.Soyad = soyad;
                        musteri.KimlikNo = kimlik;
                        musteri.Sifre = sifre;
                        musteri.Posta = mail;
                        musteri.Cinsiyet = cinsiyet.ToString();
                        musteri.Adres = adres;
                        DB_Connection.db.Musteriler.Add(musteri);

                        DB_Connection.db.SaveChanges();

                        return true;
                    }
                }
                HataMesajlari.KullaniciVar();
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
            return false;
        }

    }
}
