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

namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    public partial class U_MusteriPanel : UserControl
    {
        public static U_MusteriPanel instance;
        public U_MusteriPanel()
        {
            InitializeComponent();
            instance = this;
        }



        internal void ShowAyarlar(object sender, EventArgs e)
        {
            u_AyarlarPanel1.Show();
            u_DestekPanel1.Hide();
            u_SepetPanel1.Hide();
            u_SiparislerPanel1.Hide();
            u_UrunlerPanel1.Hide();
        }
        internal void ShowDestek(object sender, EventArgs e)
        {
            u_AyarlarPanel1.Hide();
            u_DestekPanel1.Show();
            u_SepetPanel1.Hide();
            u_SiparislerPanel1.Hide();
            u_UrunlerPanel1.Hide();
        }
        internal void ShowSepet(object sender, EventArgs e)
        {
            u_AyarlarPanel1.Hide();
            u_DestekPanel1.Hide();
            u_SepetPanel1.Show();
            u_SiparislerPanel1.Hide();
            u_UrunlerPanel1.Hide();
            U_SepetPanel.instance.LoadCart();
        }
        internal void ShowSiparisler(object sender, EventArgs e)
        {
            u_AyarlarPanel1.Hide();
            u_DestekPanel1.Hide();
            u_SepetPanel1.Hide();
            u_SiparislerPanel1.Show();
            u_UrunlerPanel1.Hide();
            
        }
        internal void ShowUrunler(object sender, EventArgs e)
        {
            u_AyarlarPanel1.Hide();
            u_DestekPanel1.Hide();
            u_SepetPanel1.Hide();
            u_SiparislerPanel1.Hide();
            u_UrunlerPanel1.Show();
            var urunler = DB_Connection.db.Urunler.ToList();
            U_UrunlerPanel.instance.LoadKategoriler();
            U_UrunlerPanel.instance.LoadData(urunler);
        }

        private void u_UrunlerPanel1_Load(object sender, EventArgs e)
        {
            ShowSiparisler(sender, e);
        }
    }
}
