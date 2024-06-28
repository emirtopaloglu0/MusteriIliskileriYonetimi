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
using MusteriIliskileriYonetimiCRM.Properties;
using MusteriIliskileriYonetimiCRM.Class.Order;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using MusteriIliskileriYonetimiCRM.Model;

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

        internal void LoadOrders(List<Siparisler> siparisler)
        {
            try
            {
                //siparisler = siparisler.OrderByDescending(x => x.SiparisTarihi).ToList();
                panel1.Controls.Clear();
                int i = 1;
                foreach (var item in siparisler)
                {
                    Label label = new Label();
                    string tutar = item.Tutar.ToString();
                    label.Text = "Sipariş Tarihi: " + item.SiparisTarihi.ToString() 
                        + " \nTutar: " + tutar.Substring(0, tutar.Length - 2) + "\n";
                    label.Tag = item.Id;
                    label.Font = new Font("Figtree", 14, FontStyle.Bold);
                    label.AutoSize = true;
                    label.Location = new Point(150, i * 60);

                    panel1.Controls.Add(label);

                    Button btn = new Button();
                    btn.Tag = item.Id;
                    btn.Text = "Detaylı Göster";
                    btn.Click += ShowDetail;
                    btn.Location = new Point(500, i * 60);
                    btn.Font = new Font("Figtree", 14, FontStyle.Bold);
                    btn.AutoSize = true;
                    panel1.Controls.Add(btn);

                    if (item.TeslimTarihi == null)
                    {
                        Button btn2 = new Button();
                        btn2.Tag = item.Id;
                        btn2.Text = "Siparişi İptal Et";
                        btn2.Click += CancelOrder_Btn_Click;
                        btn2.Location = new Point(700, i * 60);
                        btn2.Font = new Font("Figtree", 14, FontStyle.Bold);
                        btn2.AutoSize = true;
                        panel1.Controls.Add(btn2);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                //HataMesajlari.CatchError(ex);
            }
        }
        private void ShowDetail(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            selectedOrder_No = btn.Tag.ToString();
            DetailedOrderForm f = new DetailedOrderForm();
            DetailedOrderForm.instance.LoadData();
            f.ShowDialog();
        }

        internal void LoadCurrentOrders()
        {
            Siparisler_Listbox.Items.Clear();
            var user = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            var siparisler = DB_Connection.db.Siparisler.Where(x => x.MusteriId == user.Id && (x.TeslimTarihi == null && x.IptalTarihi == null)).ToList();

            LoadOrders(siparisler);

            /*foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }*/
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

            LoadOrders(siparisler);


            /*foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }*/
        }

        private void CancelledOrders_Btn_Click(object sender, EventArgs e)
        {
            Siparisler_Listbox.Items.Clear();
            var user = DB_Connection.db.Musteriler.Find(Settings.Default.U_Id);

            var siparisler = DB_Connection.db.Siparisler.Where(x => x.MusteriId == user.Id && (x.TeslimTarihi == null && x.IptalTarihi != null)).ToList();

            LoadOrders(siparisler);


            /*foreach (var item in siparisler)
            {
                var tahmini = Convert.ToDateTime(item.SiparisTarihi);
                Siparisler_Listbox.Items.Add($"Sipariş Kodu: {item.Id} - Sipariş Tarihi: {item.SiparisTarihi} - Tutar: {item.Tutar} - " +
                    $"Adres: {item.TeslimSehri} {item.TeslimAdresi} - Tahmini Teslim Tarihi: {tahmini.Date.AddDays(3)}");
            }*/
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

                Button btn = (Button)sender;

                //var siparis = Siparisler_Listbox.SelectedItem.ToString().Split(':', '-');

                var order = DB_Connection.db.Siparisler.Find(btn.Tag.ToString());

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
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }

        }
    }
}
