﻿using MusteriIliskileriYonetimiCRM.Class.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriIliskileriYonetimiCRM.Properties;
using MusteriIliskileriYonetimiCRM.Class.Order;
using MusteriIliskileriYonetimiCRM.Mesajlar;

namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    public partial class U_SiparislerPanel : UserControl
    {
        public static U_SiparislerPanel instance;

        public string selectedOrder_No;
        public U_SiparislerPanel()
        {
            InitializeComponent();
            instance = this;
        }


        internal void LoadCurrentOrders()
        {
            Siparisler_Listbox.Items.Clear();
            var user = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            var siparisler = DB_Connection.db.Siparisler.Where(x => x.MusteriId == user.Id && (x.TeslimTarihi == null && x.IptalTarihi == null)).ToList();

            foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }
        }

        private void CurrentOrders_Btn_Click(object sender, EventArgs e)
        {
            LoadCurrentOrders();
        }

        private void DeliveredOrders_Btn_Click(object sender, EventArgs e)
        {
            Siparisler_Listbox.Items.Clear();
            var user = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            var siparisler = DB_Connection.db.Siparisler.Where(x => x.MusteriId == user.Id && (x.TeslimTarihi != null && x.IptalTarihi == null)).ToList();

            foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }
        }

        private void CancelledOrders_Btn_Click(object sender, EventArgs e)
        {
            Siparisler_Listbox.Items.Clear();
            var user = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            var siparisler = DB_Connection.db.Siparisler.Where(x => x.MusteriId == user.Id && (x.TeslimTarihi == null && x.IptalTarihi != null)).ToList();

            foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }
        }

        private void ViewDetails_Btn_Click(object sender, EventArgs e)
        {
            if (Siparisler_Listbox.SelectedIndex > -1)
            {
                var siparis = Siparisler_Listbox.SelectedItem.ToString().Split(':', '-');

                selectedOrder_No = siparis[1].Trim();
                DetailedOrderForm f = new DetailedOrderForm();
                DetailedOrderForm.instance.LoadData();
                f.ShowDialog();

            }
        }

        private void CancelOrder_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var siparis = Siparisler_Listbox.SelectedItem.ToString().Split(':', '-');

                var order = DB_Connection.db.Siparisler.Find(siparis[1].Trim());

                if (order != null)
                {
                    var dt = Convert.ToDateTime(order.SiparisTarihi);
                    if (DateTime.Now <= dt.Date.AddDays(3))
                    {
                        SoruMesajlari.instance.SiparisIptal();
                        if (SoruMesajlari.instance.res == DialogResult.Yes)
                        {
                            order.IptalTarihi = DateTime.Now;
                            DB_Connection.db.SaveChanges();

                            BasariliMesajlari.SiparisIptalEdildi();
                            LoadCurrentOrders();
                        }
                    }
                    else
                    {
                        HataMesajlari.SiparisZamanAsimi();
                    }
                }
                else
                    HataMesajlari.SatiriSeciniz();
            }
            catch
            {

            }

        }
    }
}
