namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    partial class U_SepetPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Urunler_Listbox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearCart_Btn = new System.Windows.Forms.Button();
            this.RemoveItem_Btn = new System.Windows.Forms.Button();
            this.ConfirmCart_Btn = new System.Windows.Forms.Button();
            this.Kargo_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cities_Combobox = new System.Windows.Forms.ComboBox();
            this.Cities_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Address_Box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Urunler_Listbox
            // 
            this.Urunler_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urunler_Listbox.FormattingEnabled = true;
            this.Urunler_Listbox.HorizontalScrollbar = true;
            this.Urunler_Listbox.ItemHeight = 23;
            this.Urunler_Listbox.Location = new System.Drawing.Point(3, 195);
            this.Urunler_Listbox.Name = "Urunler_Listbox";
            this.Urunler_Listbox.Size = new System.Drawing.Size(1039, 372);
            this.Urunler_Listbox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusteriIliskileriYonetimiCRM.Properties.Resources.shopping_cart;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ClearCart_Btn
            // 
            this.ClearCart_Btn.BackColor = System.Drawing.Color.Teal;
            this.ClearCart_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCart_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearCart_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearCart_Btn.Location = new System.Drawing.Point(825, 3);
            this.ClearCart_Btn.Name = "ClearCart_Btn";
            this.ClearCart_Btn.Size = new System.Drawing.Size(216, 45);
            this.ClearCart_Btn.TabIndex = 9;
            this.ClearCart_Btn.Text = "Sepeti Temizle";
            this.ClearCart_Btn.UseVisualStyleBackColor = false;
            this.ClearCart_Btn.Click += new System.EventHandler(this.ClearCart_Btn_Click);
            // 
            // RemoveItem_Btn
            // 
            this.RemoveItem_Btn.BackColor = System.Drawing.Color.Teal;
            this.RemoveItem_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItem_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveItem_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveItem_Btn.Location = new System.Drawing.Point(109, 3);
            this.RemoveItem_Btn.Name = "RemoveItem_Btn";
            this.RemoveItem_Btn.Size = new System.Drawing.Size(216, 45);
            this.RemoveItem_Btn.TabIndex = 9;
            this.RemoveItem_Btn.Text = "Seçili Ürünü Çıkart";
            this.RemoveItem_Btn.UseVisualStyleBackColor = false;
            this.RemoveItem_Btn.Click += new System.EventHandler(this.RemoveItem_Btn_Click);
            // 
            // ConfirmCart_Btn
            // 
            this.ConfirmCart_Btn.BackColor = System.Drawing.Color.Teal;
            this.ConfirmCart_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmCart_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConfirmCart_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmCart_Btn.Location = new System.Drawing.Point(467, 3);
            this.ConfirmCart_Btn.Name = "ConfirmCart_Btn";
            this.ConfirmCart_Btn.Size = new System.Drawing.Size(216, 45);
            this.ConfirmCart_Btn.TabIndex = 9;
            this.ConfirmCart_Btn.Text = "Sepeti Onayla";
            this.ConfirmCart_Btn.UseVisualStyleBackColor = false;
            this.ConfirmCart_Btn.Click += new System.EventHandler(this.ConfirmCart_Btn_Click);
            // 
            // Kargo_Combobox
            // 
            this.Kargo_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kargo_Combobox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kargo_Combobox.FormattingEnabled = true;
            this.Kargo_Combobox.Location = new System.Drawing.Point(109, 89);
            this.Kargo_Combobox.Name = "Kargo_Combobox";
            this.Kargo_Combobox.Size = new System.Drawing.Size(212, 31);
            this.Kargo_Combobox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kargo Firması";
            // 
            // Cities_Combobox
            // 
            this.Cities_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cities_Combobox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cities_Combobox.FormattingEnabled = true;
            this.Cities_Combobox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.Cities_Combobox.Location = new System.Drawing.Point(467, 89);
            this.Cities_Combobox.Name = "Cities_Combobox";
            this.Cities_Combobox.Size = new System.Drawing.Size(158, 31);
            this.Cities_Combobox.TabIndex = 10;
            // 
            // Cities_Label
            // 
            this.Cities_Label.AutoSize = true;
            this.Cities_Label.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cities_Label.Location = new System.Drawing.Point(463, 63);
            this.Cities_Label.Name = "Cities_Label";
            this.Cities_Label.Size = new System.Drawing.Size(56, 23);
            this.Cities_Label.TabIndex = 11;
            this.Cities_Label.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(821, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Adres";
            // 
            // Address_Box
            // 
            this.Address_Box.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Address_Box.Location = new System.Drawing.Point(825, 89);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(216, 100);
            this.Address_Box.TabIndex = 12;
            this.Address_Box.Text = "";
            // 
            // U_SepetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cities_Label);
            this.Controls.Add(this.Cities_Combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kargo_Combobox);
            this.Controls.Add(this.ConfirmCart_Btn);
            this.Controls.Add(this.RemoveItem_Btn);
            this.Controls.Add(this.ClearCart_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Urunler_Listbox);
            this.Name = "U_SepetPanel";
            this.Size = new System.Drawing.Size(1045, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Urunler_Listbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearCart_Btn;
        private System.Windows.Forms.Button RemoveItem_Btn;
        private System.Windows.Forms.Button ConfirmCart_Btn;
        private System.Windows.Forms.ComboBox Kargo_Combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cities_Combobox;
        private System.Windows.Forms.Label Cities_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Address_Box;
    }
}
