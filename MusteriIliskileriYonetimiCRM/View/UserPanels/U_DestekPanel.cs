using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Model;
using MusteriIliskileriYonetimiCRM.Properties;
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
    public partial class U_DestekPanel : UserControl
    {
        public static U_DestekPanel instance;
        public U_DestekPanel()
        {
            InitializeComponent();
            instance = this;
        }


        internal void LoadData()
        {
            Siparisler_Listbox.Items.Clear();
            var musteri = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);
            var siparisler = DB_Connection.db.Siparisler.
                Where
                (x => x.MusteriId == musteri.Id && (x.TeslimTarihi != null && x.IptalTarihi == null))
                .ToList();

            foreach (var siparis in siparisler)
            {
                var tahmini = Convert.ToDateTime(siparis.SiparisTarihi);
                Siparisler_Listbox.Items.
                    Add($"Sipariş Kodu: {siparis.Id} - Sipariş Tarihi: {siparis.SiparisTarihi} - " +
                    $"Tutar: {siparis.Tutar} - " +
                    $"Adres: {siparis.TeslimSehri} {siparis.TeslimAdresi} - " +
                    $"Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }
            LoadSupport();
        }
        
        private void LoadSupport()
        {
            Support_Combobox.Items.Clear();
            var supportCategories = DB_Connection.db.DestekKategorileri.ToList();
            foreach (var supportCategory in supportCategories)
            {
                Support_Combobox.Items.Add(supportCategory.Ad.Trim());
            }
        }

        private void CreateTicket_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.TalepOlustur();
            if (SoruMesajlari.instance.res != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (Support_Combobox.SelectedIndex > -1)
                {
                    if (Siparisler_Listbox.SelectedIndex > -1)
                    {
                        var siparis = Siparisler_Listbox.SelectedItem.ToString().Split(':', '-');

                        AddSupportTicketToDb(siparis);

                        BasariliMesajlari.TalepOlusturuldu();
                    }
                    else
                        HataMesajlari.SatiriSeciniz();
                }
                else
                    HataMesajlari.DestekKategorisi();
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
        }

        private void AddSupportTicketToDb(string[] siparis)
        {
            DestekTalepleri destek = new DestekTalepleri();
            destek.SiparisId = siparis[1].Trim();
            destek.KategoriId = Support_Combobox.SelectedIndex + 1;
            destek.Talep = Talep_Box.Text;
            destek.TalepTarihi = DateTime.Now;
            destek.TamamlandiMi = false;
            destek.MusteriId = Settings.Default.U_Id;
            DB_Connection.db.DestekTalepleri.Add(destek);
            DB_Connection.db.SaveChanges();
        }

        private void ViewTickets_Btn_Click(object sender, EventArgs e)
        {
            if (Siparisler_Listbox.SelectedIndex > -1)
            {
                var siparis = Siparisler_Listbox.SelectedItem.ToString().Split(':', '-');

                SupportHistoryForm f = new SupportHistoryForm();
                SupportHistoryForm.instance.LoadData();
                SupportHistoryForm.instance.siparisId = siparis[1].Trim();
                f.ShowDialog();
            }

        }
    }
}
