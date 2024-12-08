using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIliskileriYonetimiCRM.Class.Order
{
    internal class C_Order
    {
        public static C_Order instance = new C_Order();

        public Siparisler sip_no;

        public string siparis_no;


        internal bool CreateOrder()
        {
           
            try
            {
                Random rand = new Random();
            again:
                var pool = Form1.instance.pool;

                char[] chars = new char[10];
                for (int i = 0; i < 10; i++)
                {
                    chars[i] = pool[rand.Next(pool.Length)];
                }

                string charsStr = new string(chars);
                sip_no = DB_Connection.db.Siparisler.Find(charsStr);

                if (sip_no == null)
                {
                    Siparisler siparis = new Siparisler();

                    siparis.Id = charsStr;
                    siparis_no = charsStr;

                    siparis.MusteriId = Properties.Settings.Default.U_Id;
                    siparis.SiparisTarihi = DateTime.Now;

                    DB_Connection.db.Siparisler.Add(siparis);
                    DB_Connection.db.SaveChanges();

                    return true;
                }
                else
                    goto again;
                

            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
                return false;
            }
        }
    }
}
