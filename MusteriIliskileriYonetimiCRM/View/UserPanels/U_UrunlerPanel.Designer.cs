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
            this.SuspendLayout();
            // 
            // Urunler_Listbox
            // 
            this.Urunler_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urunler_Listbox.FormattingEnabled = true;
            this.Urunler_Listbox.HorizontalScrollbar = true;
            this.Urunler_Listbox.ItemHeight = 23;
            this.Urunler_Listbox.Location = new System.Drawing.Point(0, 149);
            this.Urunler_Listbox.Name = "Urunler_Listbox";
            this.Urunler_Listbox.Size = new System.Drawing.Size(1039, 418);
            this.Urunler_Listbox.TabIndex = 0;
            // 
            // Kategoriler_Combobox
            // 
            this.Kategoriler_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kategoriler_Combobox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategoriler_Combobox.FormattingEnabled = true;
            this.Kategoriler_Combobox.Location = new System.Drawing.Point(94, 3);
            this.Kategoriler_Combobox.Name = "Kategoriler_Combobox";
            this.Kategoriler_Combobox.Size = new System.Drawing.Size(216, 31);
            this.Kategoriler_Combobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori";
            // 
            // U_UrunlerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kategoriler_Combobox);
            this.Controls.Add(this.Urunler_Listbox);
            this.Name = "U_UrunlerPanel";
            this.Size = new System.Drawing.Size(1045, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Urunler_Listbox;
        private System.Windows.Forms.ComboBox Kategoriler_Combobox;
        private System.Windows.Forms.Label label1;
    }
}
