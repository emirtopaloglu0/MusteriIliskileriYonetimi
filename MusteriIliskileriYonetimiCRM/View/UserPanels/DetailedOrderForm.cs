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
    public partial class DetailedOrderForm : Form
    {
        public static DetailedOrderForm instance;
        public DetailedOrderForm()
        {
            InitializeComponent();
            instance = this;
        }

        internal void LoadData()
        {
            var selectedOrder = U_SiparislerPanel.instance.selectedOrder_No;
            var siparis = DB_Connection.db.Siparis_Detay.Where(x=> x.SiparisId == selectedOrder).ToList();
            foreach (var item in siparis)
            {
                var urun = DB_Connection.db.Urunler.Find(item.UrunId);
                var fiyat = urun.Fiyat.ToString().Trim();
                Siparis_Listbox.Items.
                    Add($"Ürün Adı: {urun.Ad} - Birim Fiyatı: {fiyat.Substring(0, fiyat.Length - 2)} - " +
                    $"Adet: {item.Adet}");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
