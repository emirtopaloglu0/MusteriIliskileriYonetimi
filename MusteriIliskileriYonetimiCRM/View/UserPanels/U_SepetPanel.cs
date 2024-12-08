using MusteriIliskileriYonetimiCRM.Class.Cart;
using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Class.Order;
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
        internal List<int> cartList; 

        decimal tutar = 0;

        public U_SepetPanel()
        {
            InitializeComponent();
            instance = this;
        }

        internal void LoadKargo()
        {
            var kargolar = DB_Connection.db.KargoFirmalari.ToList();
            Kargo_Combobox.Items.Clear();
            foreach (var k in kargolar)
            {
                Kargo_Combobox.Items.Add(k.Ad.Trim());
            }
        }

        internal void LoadCart()
        {
            try
            {
                Urunler_Listbox.Items.Clear();
                cartList = C_Cart.instance.GetCartList();

                tutar = 0;
                TutarLbl.Text = "0 ₺";

                foreach (var cartItem in cartList)
                {
                    //var deger = cartItem;
                    var product = DB_Connection.db.Urunler.Find(cartItem);
                    var category = DB_Connection.db.Kategoriler.Find(product.Kategori_Id);
                    var strPrice = product.Fiyat.ToString().Trim();
                    Urunler_Listbox.Items.Add($"Ürün Kodu: {product.Id} - Ürün: {product.Ad} - Kategori: {category.Ad} - Fiyat: {strPrice.Substring(0, strPrice.Length - 2)}\n");
                    
                    var price = Convert.ToDecimal(strPrice);
                    tutar += price;
                }
                var strTutar = tutar.ToString();
                TutarLbl.Text = strTutar.Substring(0, strTutar.Length - 2) + " ₺";
            }
            catch //(Exception ex)
            {
                //HataMesajlari.CatchError(ex);
            }
        }

        private void RemoveItem_Btn_Click(object sender, EventArgs e)
        {
            if ((Urunler_Listbox.SelectedIndex <= -1))
            {
                return;
            }
            SoruMesajlari.instance.UrunSilme();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                var urun = Urunler_Listbox.SelectedItem.ToString().Split(':', '-');
                Urunler_Listbox.Items.Remove(Urunler_Listbox.SelectedItem);

                //C_Cart cart = new C_Cart();
                C_Cart.instance.RemoveItem(Int32.Parse(urun[1]));
                LoadCart();

                //cartList.Remove(Int32.Parse(urun[1]));
            }
        }

        private void ClearCart_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.SepetTemizle();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Urunler_Listbox.Items.Clear();

                //C_Cart cart = new C_Cart();
                C_Cart.instance.ClearCart();

                LoadCart();
                //cartList.Clear();
            }
        }

        private bool StokKontrol()
        {
            foreach (var item1 in Urunler_Listbox.Items)
            {

                short adet = 0;
                var urun = item1.ToString().Split(':', '-');

                foreach (var item2 in Urunler_Listbox.Items)
                {
                    var urun2 = item2.ToString().Split(':', '-');

                    if (urun[1] == urun2[1])
                    {
                        adet++;

                    }
                }

                var urunler = DB_Connection.db.Urunler.Find(Int32.Parse(urun[1]));
                if (Convert.ToInt16(urunler.Stok - adet) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void ConfirmCart_Btn_Click(object sender, EventArgs e)
        {
            if (Kargo_Combobox.SelectedIndex == -1 || Cities_Combobox.SelectedIndex == -1 || Address_Box.Text == string.Empty)
            {
                HataMesajlari.BosOlamaz();
                return;
            }

            if (!StokKontrol())
            {
                HataMesajlari.StokHatasi();
                return;
            }

            SoruMesajlari.instance.SepetOnay();
            if (SoruMesajlari.instance.res != DialogResult.Yes)
            {
                return;
            }

            if (!C_Order.instance.CreateOrder())
            {
                return;
            }

            try
            {
                decimal tutar = 0;
                var siparis_No = C_Order.instance.siparis_no;

                foreach (var item1 in Urunler_Listbox.Items)
                {

                    short adet = 0;
                    var urun = item1.ToString().Split(':', '-');

                    foreach (var item2 in Urunler_Listbox.Items)
                    {
                        var urun2 = item2.ToString().Split(':', '-');

                        if (urun[1] == urun2[1])
                        {
                            adet++;
                        }
                    }
                    var s_detay = DB_Connection.db.Siparis_Detay.Where(x => x.SiparisId == siparis_No).ToList();

                    foreach (var item in s_detay)
                    {
                        if (item.UrunId == Int32.Parse(urun[1]))
                        {
                            goto devam;
                        }
                    }
                    var urunler = DB_Connection.db.Urunler.Find(Int32.Parse(urun[1]));
                    urunler.Stok = Convert.ToInt16(urunler.Stok - adet);
                    var fiyat = Convert.ToDecimal(urun[7]);

                    AddOrderDetail(siparis_No, adet, urun, fiyat);

                    tutar += fiyat * Convert.ToDecimal(adet);
                devam:;

                }

                UpdateOrderDB(tutar, siparis_No);

                BasariliMesajlari.SatinAlim();

                Urunler_Listbox.Items.Clear();
                cartList.Clear();
                Cities_Combobox.SelectedItem = null;
                Address_Box.Text = null;

            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
        }

        private void UpdateOrderDB(decimal tutar, string siparis_No)
        {
            var siparisler = DB_Connection.db.Siparisler.Find(siparis_No);
            siparisler.Tutar = tutar;
            siparisler.Kargo_Id = Kargo_Combobox.SelectedIndex + 1;
            siparisler.TeslimSehri = Cities_Combobox.SelectedItem.ToString().Trim();
            siparisler.TeslimAdresi = Address_Box.Text;
            DB_Connection.db.SaveChanges();
        }

        private static void AddOrderDetail(string siparis_No, short adet, string[] urun, decimal fiyat)
        {
            Siparis_Detay detay = new Siparis_Detay();
            detay.SiparisId = siparis_No;
            detay.UrunId = Int32.Parse(urun[1]);
            detay.Urun_Fiyat = fiyat;
            detay.Adet = adet;
            DB_Connection.db.Siparis_Detay.Add(detay);
            DB_Connection.db.SaveChanges();
        }
    }
}
