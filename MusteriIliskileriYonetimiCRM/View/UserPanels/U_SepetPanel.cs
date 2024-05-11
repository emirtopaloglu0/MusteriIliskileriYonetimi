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
        public List<int> list = new List<int>(); //idlerden isimleri gelecek
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


        private bool StokKontrol()
        {
            foreach (var j in Urunler_Listbox.Items)
            {

                short adet = 0;
                var urun = j.ToString().Split(':', '-');

                foreach (var k in Urunler_Listbox.Items)
                {
                    var urun2 = k.ToString().Split(':', '-');

                    if (urun[1] == urun2[1])
                    {
                        adet++;

                    }
                }

                var urunler = DB_Connection.db.Urunler.Find(Int32.Parse(urun[1]));
                if(Convert.ToInt16(urunler.Stok - adet) < 0)
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


            if (StokKontrol() == false)
            {
                HataMesajlari.StokHatasi();
                return;
            }

            SoruMesajlari.instance.SepetOnay();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                if (C_Order.instance.CreateOrder())
                {
                    try
                    {
                        decimal tutar = 0;
                        var Siparis_No = C_Order.instance.siparis_no;

                        foreach (var j in Urunler_Listbox.Items)
                        {

                            short adet = 0;
                            var urun = j.ToString().Split(':', '-');

                            foreach (var k in Urunler_Listbox.Items)
                            {
                                var urun2 = k.ToString().Split(':', '-');

                                if (urun[1] == urun2[1])
                                {
                                    adet++;
                                    
                                }
                            }

                            var s_detay = DB_Connection.db.Siparis_Detay.Where(x => x.SiparisId == Siparis_No).ToList();


                            foreach (var item in s_detay)
                            {
                                if (item.UrunId == Int32.Parse(urun[1]))
                                {
                                    goto devam;
                                }
                            }
                            var urunler = DB_Connection.db.Urunler.Find(Int32.Parse(urun[1]));
                            urunler.Stok = Convert.ToInt16(urunler.Stok - adet);


                            Siparis_Detay detay = new Siparis_Detay();
                            detay.SiparisId = Siparis_No;
                            detay.UrunId = Int32.Parse(urun[1]);
                            var fiyat = Convert.ToDecimal(urun[7]);
                            detay.Urun_Fiyat = fiyat;
                            detay.Adet = adet;
                            DB_Connection.db.Siparis_Detay.Add(detay);
                            DB_Connection.db.SaveChanges();

                            tutar += fiyat * Convert.ToDecimal(adet);
                        devam:;




                        }
                        var siparisler = DB_Connection.db.Siparisler.Find(Siparis_No);
                        siparisler.Tutar = tutar;
                        siparisler.Kargo_Id = Kargo_Combobox.SelectedIndex + 1;
                        siparisler.TeslimSehri = Cities_Combobox.SelectedItem.ToString().Trim();
                        siparisler.TeslimAdresi = Address_Box.Text;
                        DB_Connection.db.SaveChanges();

                        BasariliMesajlari.SatinAlim();

                        Urunler_Listbox.Items.Clear();
                        list.Clear();
                        Cities_Combobox.SelectedItem = null;
                        Address_Box.Text = null;

                    }
                    catch (Exception ex)
                    {
                        HataMesajlari.CatchError(ex);
                    }

                }
            }
        }
    }
}
