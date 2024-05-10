using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Model;
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
    public partial class U_SepetPanel : UserControl
    {
        public static U_SepetPanel instance;
        public List<int> list = new List<int>(); //idlerden isimleri gelecek
        public U_SepetPanel()
        {
            InitializeComponent();
            instance = this;
        }

        internal void LoadCart()
        {
            try
            {
                Urunler_Listbox.Items.Clear();
                foreach (var item in list)
                {
                    var deger = item;
                    var u = DB_Connection.db.Urunler.Find(item);
                    var kat = DB_Connection.db.Kategoriler.Find(u.Kategori_Id);
                    var fiyat = u.Fiyat.ToString().Trim();
                    Urunler_Listbox.Items.Add($"Ürün Kodu: {u.Id} - Ürün: {u.Ad} - Kategori: {kat.Ad} - Fiyat: {fiyat.Substring(0, fiyat.Length - 2)} - Stok: {u.Stok}\n");
                }
            }
            catch
            {

            }


        }

        private void RemoveItem_Btn_Click(object sender, EventArgs e)
        {
            if ((Urunler_Listbox.SelectedIndex != -1))
            {
                SoruMesajlari.instance.UrunSilme();
                if (SoruMesajlari.instance.res == DialogResult.Yes)
                {
                    var urun = Urunler_Listbox.SelectedItem.ToString().Split(':', '-');
                    Urunler_Listbox.Items.Remove(Urunler_Listbox.SelectedItem);
                    list.Remove(Int32.Parse(urun[1]));
                }
            }

        }

        private void ClearCart_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.SepetTemizle();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Urunler_Listbox.Items.Clear();
                list.Clear();
            }
        }

        private void ConfirmCart_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.SepetOnay();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {

            }
        }
    }
}
