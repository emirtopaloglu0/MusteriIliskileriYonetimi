using MusteriIliskileriYonetimiCRM.Class.Connection;
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
using MusteriIliskileriYonetimiCRM.Class.Popup;

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

        internal void LoadKategoriler()
        {
            var kategoriler = DB_Connection.db.Kategoriler.ToList();
            Kategoriler_Combobox.Items.Clear();
            foreach (var k in kategoriler)
            {
                Kategoriler_Combobox.Items.Add(k.Ad.Trim());
            }
        }


        internal void LoadData(List<Urunler> urunler)
        {
            try
            {
                Urunler_Listbox.Items.Clear();
                foreach (var u in urunler)
                {
                    var kat = DB_Connection.db.Kategoriler.Find(u.Kategori_Id);
                    var fiyat = u.Fiyat.ToString().Trim();
                    Urunler_Listbox.Items.Add($"Ürün Kodu: {u.Id} - Ürün: {u.Ad} - Kategori: {kat.Ad} - Fiyat: {fiyat.Substring(0, fiyat.Length-2)} - Stok: {u.Stok}\n");
                }

            }
            catch
            {

            }



        }

        private void Kategoriler_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Kategoriler_Combobox.SelectedIndex + 1;
            var urunler = DB_Connection.db.Urunler.Where(x=> x.Kategori_Id == index).ToList();
            LoadData(urunler);
        }

        private void Clear_Button(object sender, EventArgs e)
        {
            LoadKategoriler();
            var urunler = DB_Connection.db.Urunler.ToList();
            LoadData(urunler);
        }

        private void AddCart_Btn_Click(object sender, EventArgs e)
        {
            var urun = Urunler_Listbox.SelectedItem.ToString().Split(':', '-');
            Popup.instance.Success("Sepete Eklendi", $"{urun[3].Trim()} sepete eklendi");
            U_SepetPanel.instance.list.Add(Int32.Parse(urun[1].Trim()));

        }
    }
}
