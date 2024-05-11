using MusteriIliskileriYonetimiCRM.Class.Connection;
using MusteriIliskileriYonetimiCRM.Mesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriIliskileriYonetimiCRM.View.AdminPanels
{
    public partial class A_AdminPanel : UserControl
    {
        public static A_AdminPanel instance;
        public int destek_Id;
        public A_AdminPanel()
        {
            InitializeComponent();
            instance = this;
        }

        internal void LoadData()
        {
            Destek_Listbox.Items.Clear();
            var destek = DB_Connection.db.DestekTalepleri.Where(x=> x.TamamlandiMi == false).ToList();
            foreach ( var item in destek )
            {
                var kategori = DB_Connection.db.DestekKategorileri.Find(item.KategoriId);
                Destek_Listbox.Items.Add($"Destek No: {item.Id} - Sipariş Kodu: {item.SiparisId} - Tür: {item.KategoriId} - Talep: {item.Talep}");
            }
        }

        private void Answer_Btn_Click(object sender, EventArgs e)
        {
            if (Destek_Listbox.SelectedIndex > -1)
            {
                var destek = Destek_Listbox.SelectedItem.ToString().Split(':', '-');

                destek_Id = Int32.Parse(destek[1].Trim());
                A_DestekCevapForm f = new A_DestekCevapForm();
                f.ShowDialog();

            }
            else
                HataMesajlari.DestekSecilemedi();
        }

        private void Tamamlandi_Btn_Click(object sender, EventArgs e)
        {
            var destek = Destek_Listbox.SelectedItem.ToString().Split(':', '-');
            var destekler = DB_Connection.db.DestekTalepleri.Find(Int32.Parse(destek[1].Trim()));
            if (destekler.IslemTarihi != null)
            {
                destekler.TamamlandiMi = true;
                DB_Connection.db.SaveChanges();

            }
            else
                HataMesajlari.IslemeAlin();
        }
    }
}
