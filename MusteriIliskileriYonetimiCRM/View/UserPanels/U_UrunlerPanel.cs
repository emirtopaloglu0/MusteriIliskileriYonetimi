using MusteriIliskileriYonetimiCRM.Class.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    public partial class U_UrunlerPanel : UserControl
    {
        public static U_UrunlerPanel instance;
        public U_UrunlerPanel()
        {
            InitializeComponent();
            instance = this;
        }


        internal void LoadData()
        {
            try
            {
                var kategoriler = DB_Connection.db.Kategoriler.ToList();
                Kategoriler_Combobox.Items.Clear();
                foreach (var k in kategoriler)
                {
                    Kategoriler_Combobox.Items.Add(k.Ad.Trim());
                }



                var urunler = DB_Connection.db.Urunler.ToList();
                Urunler_Listbox.Items.Clear();
                foreach (var u in urunler)
                {
                    var kat = DB_Connection.db.Kategoriler.Find(u.Kategori_Id);
                    var fiyat = u.Fiyat.ToString().Trim();
                    Urunler_Listbox.Items.Add($"Ürün Adı: {u.Ad} - Kategori: {kat.Ad} - Fiyat: {fiyat.Substring(0, fiyat.Length-2)} - Stok: {u.Stok}\n");
                }

            }
            catch
            {

            }



        }
    }
}
