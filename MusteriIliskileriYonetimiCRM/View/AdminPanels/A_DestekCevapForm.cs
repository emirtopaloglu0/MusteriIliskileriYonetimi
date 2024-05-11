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
    public partial class A_DestekCevapForm : Form
    {
        public static A_DestekCevapForm instance;
        public A_DestekCevapForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Gonder_Btn_Click(object sender, EventArgs e)
        {
            var destek = DB_Connection.db.DestekTalepleri.Find(A_AdminPanel.instance.destek_Id);

            destek.YoneticiCevap = Cevap_Box.Text;
            destek.IslemTarihi = DateTime.Now;
            DB_Connection.db.SaveChanges();
            BasariliMesajlari.IslemeAlindi();
            Close();
        }
    }
}
