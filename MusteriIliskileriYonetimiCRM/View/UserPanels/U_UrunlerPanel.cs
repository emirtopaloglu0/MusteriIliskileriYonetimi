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
                //Urunler_Listbox.Items.Clear();
                panel1.Controls.Clear();
                //foreach (var u in urunler)
                //{
                //    var kat = DB_Connection.db.Kategoriler.Find(u.Kategori_Id);
                //    var fiyat = u.Fiyat.ToString().Trim();
                //    Urunler_Listbox.Items.Add($"Ürün Kodu: {u.Id} - Ürün: {u.Ad} - Kategori: {kat.Ad} - Fiyat: {fiyat.Substring(0, fiyat.Length-2)} - Stok: {u.Stok}\n");
                //}

                int i = 1;
                foreach (var item in urunler)
                {
                    //PictureBox picture = new PictureBox();
                    //picture.Image = Properties.Resources.cargo;
                    //picture.Location = new Point(3, i * 40);
                    //picture.Size = new Size(100, 117);
                    //picture.Tag = item.Id;

                    //panel1.Controls.Add(picture);

                    Label label = new Label();
                    label.Text = item.Ad;
                    label.Tag = item.Id;
                    label.Font = new Font("Figtree", 14, FontStyle.Bold);
                    label.AutoSize = true;
                    label.Location = new Point(150, i * 40);

                    panel1.Controls.Add(label);

                    Button btn = new Button();
                    btn.Tag = item.Id;
                    btn.Text = "Sepete Ekle";
                    btn.Click += CartAdd;
                    btn.Location = new Point(700, i * 40);
                    btn.Font = new Font("Figtree", 14, FontStyle.Bold);
                    btn.AutoSize = true;
                    panel1.Controls.Add(btn);
                    i++;
                }


            }
            catch
            {

            }



        }

        private void CartAdd(object sender, EventArgs e)
        {
            AddCart_Btn_Click(sender, e);
        }

        private void Kategoriler_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = Kategoriler_Combobox.SelectedIndex + 1;
            var urunler = DB_Connection.db.Urunler.Where(x => x.Kategori_Id == index).ToList();
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
            Button btn = (Button)sender;
            var tag = btn.Tag;
            var urun = DB_Connection.db.Urunler.Find(tag);
            //var urun = Urunler_Listbox.SelectedItem.ToString().Split(':', '-');
            Popup.instance.Success("Sepete Eklendi", $"{urun.Ad.Trim()} sepete eklendi");
            U_SepetPanel.instance.list.Add(Int32.Parse(tag.ToString().Trim()));

        }
    }
}
