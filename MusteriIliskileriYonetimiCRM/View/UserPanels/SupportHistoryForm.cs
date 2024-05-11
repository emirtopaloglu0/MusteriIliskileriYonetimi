using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Class.Popup;
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
    public partial class SupportHistoryForm : Form
    {
        public static SupportHistoryForm instance;
        public SupportHistoryForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void LoadData()
        {
            var destek = DB_Connection.db.DestekTalepleri.Where(x => x.MusteriId == Properties.Settings.Default.U_Id).ToList();
            foreach (var item in destek)
            {
                if(item.YoneticiCevap != null && item.TamamlandiMi == false)
                {
                    Popup.instance.Info("Talebinize Cevap Geldi", "Taleplerinizden birine yöneticiden cevap geldi");
                }
                string durum = "Devam Ediyor";
                var kategori = DB_Connection.db.DestekKategorileri.Find(item.KategoriId);
                if (item.TamamlandiMi)
                {
                    durum = "Tamamlandı";
                }
                Siparis_Listbox.Items.Add($"Sipariş Kodu: {item.SiparisId} - Durum: {durum} - Destek Türü: {kategori.Ad} - Yönetici Mesajı: {item.YoneticiCevap} - " +
                    $"Talep Tarihi: {item.TalepTarihi} - İşleme Alınma Tarihi: {item.IslemTarihi}");
            }
        }
    }
}
