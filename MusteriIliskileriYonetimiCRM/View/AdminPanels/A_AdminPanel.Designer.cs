namespace MusteriIliskileriYonetimiCRM.View.AdminPanels
{
    partial class A_AdminPanel
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
            this.Destek_Listbox = new System.Windows.Forms.ListBox();
            this.Answer_Btn = new System.Windows.Forms.Button();
            this.Tamamlandi_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Destek_Listbox
            // 
            this.Destek_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Destek_Listbox.FormattingEnabled = true;
            this.Destek_Listbox.HorizontalScrollbar = true;
            this.Destek_Listbox.ItemHeight = 23;
            this.Destek_Listbox.Location = new System.Drawing.Point(3, 118);
            this.Destek_Listbox.Name = "Destek_Listbox";
            this.Destek_Listbox.Size = new System.Drawing.Size(1239, 464);
            this.Destek_Listbox.TabIndex = 12;
            // 
            // Answer_Btn
            // 
            this.Answer_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Answer_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Answer_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Answer_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Answer_Btn.Location = new System.Drawing.Point(1026, 3);
            this.Answer_Btn.Name = "Answer_Btn";
            this.Answer_Btn.Size = new System.Drawing.Size(216, 65);
            this.Answer_Btn.TabIndex = 15;
            this.Answer_Btn.Text = "Cevapla";
            this.Answer_Btn.UseVisualStyleBackColor = false;
            this.Answer_Btn.Click += new System.EventHandler(this.Answer_Btn_Click);
            // 
            // Tamamlandi_Btn
            // 
            this.Tamamlandi_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Tamamlandi_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tamamlandi_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tamamlandi_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tamamlandi_Btn.Location = new System.Drawing.Point(804, 3);
            this.Tamamlandi_Btn.Name = "Tamamlandi_Btn";
            this.Tamamlandi_Btn.Size = new System.Drawing.Size(216, 65);
            this.Tamamlandi_Btn.TabIndex = 15;
            this.Tamamlandi_Btn.Text = "Tamamlandı Olarak İşaretle";
            this.Tamamlandi_Btn.UseVisualStyleBackColor = false;
            this.Tamamlandi_Btn.Click += new System.EventHandler(this.Tamamlandi_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusteriIliskileriYonetimiCRM.Properties.Resources.help_desk;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // A_AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tamamlandi_Btn);
            this.Controls.Add(this.Answer_Btn);
            this.Controls.Add(this.Destek_Listbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "A_AdminPanel";
            this.Size = new System.Drawing.Size(1245, 585);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Destek_Listbox;
        private System.Windows.Forms.Button Answer_Btn;
        private System.Windows.Forms.Button Tamamlandi_Btn;
    }
}
