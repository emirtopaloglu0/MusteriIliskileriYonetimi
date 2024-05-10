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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Urunler_Listbox
            // 
            this.Urunler_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urunler_Listbox.FormattingEnabled = true;
            this.Urunler_Listbox.HorizontalScrollbar = true;
            this.Urunler_Listbox.ItemHeight = 23;
            this.Urunler_Listbox.Location = new System.Drawing.Point(3, 126);
            this.Urunler_Listbox.Name = "Urunler_Listbox";
            this.Urunler_Listbox.Size = new System.Drawing.Size(1039, 441);
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
            // U_SepetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmCart_Btn);
            this.Controls.Add(this.RemoveItem_Btn);
            this.Controls.Add(this.ClearCart_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Urunler_Listbox);
            this.Name = "U_SepetPanel";
            this.Size = new System.Drawing.Size(1045, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Urunler_Listbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearCart_Btn;
        private System.Windows.Forms.Button RemoveItem_Btn;
        private System.Windows.Forms.Button ConfirmCart_Btn;
    }
}
