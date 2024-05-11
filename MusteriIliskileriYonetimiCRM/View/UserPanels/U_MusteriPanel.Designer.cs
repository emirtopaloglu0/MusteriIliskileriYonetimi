namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    partial class U_MusteriPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Urunler_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.u_UrunlerPanel1 = new MusteriIliskileriYonetimiCRM.View.UserPanels.U_UrunlerPanel();
            this.u_SiparislerPanel1 = new MusteriIliskileriYonetimiCRM.View.UserPanels.U_SiparislerPanel();
            this.u_SepetPanel1 = new MusteriIliskileriYonetimiCRM.View.UserPanels.U_SepetPanel();
            this.u_DestekPanel1 = new MusteriIliskileriYonetimiCRM.View.UserPanels.U_DestekPanel();
            this.u_AyarlarPanel1 = new MusteriIliskileriYonetimiCRM.View.UserPanels.U_AyarlarPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Name_Label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Urunler_Btn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 579);
            this.panel1.TabIndex = 0;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name_Label.Location = new System.Drawing.Point(3, 31);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(25, 23);
            this.Name_Label.TabIndex = 5;
            this.Name_Label.Text = "...";
            this.Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(3, 513);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ayarlar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ShowAyarlar);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(3, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "Destek Talebi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ShowDestek);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(3, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Siparişlerim";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ShowSiparisler);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Alışveriş Sepetim";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowSepet);
            // 
            // Urunler_Btn
            // 
            this.Urunler_Btn.BackColor = System.Drawing.SystemColors.Info;
            this.Urunler_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Urunler_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Urunler_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Urunler_Btn.Location = new System.Drawing.Point(3, 104);
            this.Urunler_Btn.Name = "Urunler_Btn";
            this.Urunler_Btn.Size = new System.Drawing.Size(180, 45);
            this.Urunler_Btn.TabIndex = 4;
            this.Urunler_Btn.Text = "Ürünler";
            this.Urunler_Btn.UseVisualStyleBackColor = false;
            this.Urunler_Btn.Click += new System.EventHandler(this.ShowUrunler);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.u_UrunlerPanel1);
            this.panel2.Controls.Add(this.u_SiparislerPanel1);
            this.panel2.Controls.Add(this.u_SepetPanel1);
            this.panel2.Controls.Add(this.u_DestekPanel1);
            this.panel2.Controls.Add(this.u_AyarlarPanel1);
            this.panel2.Location = new System.Drawing.Point(195, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 571);
            this.panel2.TabIndex = 1;
            // 
            // u_UrunlerPanel1
            // 
            this.u_UrunlerPanel1.Location = new System.Drawing.Point(-1, -2);
            this.u_UrunlerPanel1.Name = "u_UrunlerPanel1";
            this.u_UrunlerPanel1.Size = new System.Drawing.Size(1045, 570);
            this.u_UrunlerPanel1.TabIndex = 4;
            this.u_UrunlerPanel1.Load += new System.EventHandler(this.u_UrunlerPanel1_Load);
            // 
            // u_SiparislerPanel1
            // 
            this.u_SiparislerPanel1.Location = new System.Drawing.Point(-1, 1);
            this.u_SiparislerPanel1.Name = "u_SiparislerPanel1";
            this.u_SiparislerPanel1.Size = new System.Drawing.Size(1045, 570);
            this.u_SiparislerPanel1.TabIndex = 3;
            // 
            // u_SepetPanel1
            // 
            this.u_SepetPanel1.Location = new System.Drawing.Point(0, 1);
            this.u_SepetPanel1.Name = "u_SepetPanel1";
            this.u_SepetPanel1.Size = new System.Drawing.Size(1045, 570);
            this.u_SepetPanel1.TabIndex = 2;
            // 
            // u_DestekPanel1
            // 
            this.u_DestekPanel1.Location = new System.Drawing.Point(-1, 3);
            this.u_DestekPanel1.Name = "u_DestekPanel1";
            this.u_DestekPanel1.Size = new System.Drawing.Size(1045, 570);
            this.u_DestekPanel1.TabIndex = 1;
            // 
            // u_AyarlarPanel1
            // 
            this.u_AyarlarPanel1.Location = new System.Drawing.Point(0, 1);
            this.u_AyarlarPanel1.Name = "u_AyarlarPanel1";
            this.u_AyarlarPanel1.Size = new System.Drawing.Size(1045, 570);
            this.u_AyarlarPanel1.TabIndex = 0;
            // 
            // U_MusteriPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "U_MusteriPanel";
            this.Size = new System.Drawing.Size(1245, 585);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Urunler_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private U_AyarlarPanel u_AyarlarPanel1;
        private U_DestekPanel u_DestekPanel1;
        private U_SiparislerPanel u_SiparislerPanel1;
        private U_SepetPanel u_SepetPanel1;
        private U_UrunlerPanel u_UrunlerPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_Label;
    }
}
