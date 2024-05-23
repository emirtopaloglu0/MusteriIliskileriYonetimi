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
            var user = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            var siparisler = DB_Connection.db.Siparisler.Where(x => x.MusteriId == user.Id && (x.TeslimTarihi != null && x.IptalTarihi == null)).ToList();

            foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }

            LoadSupport();
        }


        private void LoadSupport()
        {
            Support_Combobox.Items.Clear();
            var kargolar = DB_Connection.db.DestekKategorileri.ToList();
            foreach (var k in kargolar)
            {
                Support_Combobox.Items.Add(k.Ad.Trim());
            }
        }

        private void CreateTicket_Btn_Click(object sender, EventArgs e)
        {

            SoruMesajlari.instance.TalepOlustur();
            if (SoruMesajlari.instance.res == DialogResult.Yes)
            {
                try
                {
                    if (Support_Combobox.SelectedIndex > -1)
                    {
                        if (Siparisler_Listbox.SelectedIndex > -1)
                        {
                            var siparis = Siparisler_Listbox.SelectedItem.ToString().Split(':', '-');

                            DestekTalepleri destek = new DestekTalepleri();
                            destek.SiparisId = siparis[1].Trim();
                            destek.KategoriId = Support_Combobox.SelectedIndex + 1;
                            destek.Talep = Talep_Box.Text;
                            destek.TalepTarihi = DateTime.Now;
                            destek.TamamlandiMi = false;
                            destek.MusteriId = Settings.Default.U_Id;
                            DB_Connection.db.DestekTalepleri.Add(destek);
                            DB_Connection.db.SaveChanges();
                            BasariliMesajlari.TalepOlusturuldu();
                        }
                        else
                            HataMesajlari.SatiriSeciniz();
                    }
                    else
                        HataMesajlari.DestekKategorisi();
                }
                catch
                {

                }
            }


        }

        private void ViewTickets_Btn_Click(object sender, EventArgs e)
        {
            if(Siparisler_Listbox.SelectedIndex > -1)
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
