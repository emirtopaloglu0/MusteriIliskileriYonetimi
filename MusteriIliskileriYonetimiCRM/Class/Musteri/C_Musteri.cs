using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriIliskileriYonetimiCRM.Properties;
using System.Data.SqlClient;

namespace MusteriIliskileriYonetimiCRM.Class.Musteri
{
    internal class C_Musteri
    {


        public C_Musteri(string name = null, string surname = null, string ıdNo = null, string password = null, string email = null,
            char gender = 'E', string address = null)
        {
            Name = name;
            Surname = surname;
            IdNo = ıdNo;
            Password = password;
            Email = email;
            Gender = gender;
            Address = address;
        }

        public static C_Musteri instance = new C_Musteri();

        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }



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
            returnvalue = true;
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

        internal bool Register(C_Musteri customer)
        {
            try
            {
                if (IsMusteriExist(IdNo))
                {
                    HataMesajlari.KullaniciVar();
                    return false;
                }

                if (FindMusteri(Email) == null)
                {

                    Musteriler musteri = new Musteriler();
                    musteri.Ad = customer.Name;
                    musteri.Soyad = customer.Surname;
                    musteri.KimlikNo = customer.IdNo;
                    musteri.Sifre = customer.Password;
                    musteri.Posta = customer.Email;
                    musteri.Cinsiyet = customer.Gender.ToString();
                    musteri.Adres = customer.Address;
                    DB_Connection.db.Musteriler.Add(musteri);

                    DB_Connection.db.SaveChanges();

                    return true;
                }


            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
            return false;
        }

    }
}
