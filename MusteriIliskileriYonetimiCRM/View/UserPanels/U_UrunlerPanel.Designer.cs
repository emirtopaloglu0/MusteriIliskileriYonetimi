namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    partial class U_UrunlerPanel
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
            this.Kategoriler_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCart_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Urunler_Listbox
            // 
            this.Urunler_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urunler_Listbox.FormattingEnabled = true;
            this.Urunler_Listbox.HorizontalScrollbar = true;
            this.Urunler_Listbox.ItemHeight = 23;
            this.Urunler_Listbox.Location = new System.Drawing.Point(0, 126);
            this.Urunler_Listbox.Name = "Urunler_Listbox";
            this.Urunler_Listbox.Size = new System.Drawing.Size(1039, 441);
            this.Urunler_Listbox.TabIndex = 0;
            // 
            // Kategoriler_Combobox
            // 
            this.Kategoriler_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kategoriler_Combobox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategoriler_Combobox.FormattingEnabled = true;
            this.Kategoriler_Combobox.Location = new System.Drawing.Point(398, 15);
            this.Kategoriler_Combobox.Name = "Kategoriler_Combobox";
            this.Kategoriler_Combobox.Size = new System.Drawing.Size(216, 31);
            this.Kategoriler_Combobox.TabIndex = 1;
            this.Kategoriler_Combobox.SelectedIndexChanged += new System.EventHandler(this.Kategoriler_Combobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(307, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori";
            // 
            // AddCart_Btn
            // 
            this.AddCart_Btn.BackColor = System.Drawing.Color.Teal;
            this.AddCart_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCart_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCart_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCart_Btn.Location = new System.Drawing.Point(398, 75);
            this.AddCart_Btn.Name = "AddCart_Btn";
            this.AddCart_Btn.Size = new System.Drawing.Size(216, 45);
            this.AddCart_Btn.TabIndex = 6;
            this.AddCart_Btn.Text = "Sepete Ekle";
            this.AddCart_Btn.UseVisualStyleBackColor = false;
            this.AddCart_Btn.Click += new System.EventHandler(this.AddCart_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(620, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sıfırla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Clear_Button);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusteriIliskileriYonetimiCRM.Properties.Resources.digital;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 441);
            this.panel1.TabIndex = 8;
            // 
            // U_UrunlerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddCart_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kategoriler_Combobox);
            this.Controls.Add(this.Urunler_Listbox);
            this.Name = "U_UrunlerPanel";
            this.Size = new System.Drawing.Size(1045, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Urunler_Listbox;
        private System.Windows.Forms.ComboBox Kategoriler_Combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCart_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
