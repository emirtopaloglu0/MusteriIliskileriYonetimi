namespace MusteriIliskileriYonetimiCRM.View.AdminPanels
{
    partial class A_DestekCevapForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cevap_Box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.Tamamlandi_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Cevap_Box
            // 
            this.Cevap_Box.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cevap_Box.Location = new System.Drawing.Point(232, 32);
            this.Cevap_Box.Name = "Cevap_Box";
            this.Cevap_Box.Size = new System.Drawing.Size(216, 124);
            this.Cevap_Box.TabIndex = 16;
            this.Cevap_Box.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Yetkili Olarak Cevabınız";
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::MusteriIliskileriYonetimiCRM.Properties.Resources.close2;
            this.ExitButton.Location = new System.Drawing.Point(475, 11);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(61, 61);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 13;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Tamamlandi_Btn
            // 
            this.Tamamlandi_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Tamamlandi_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tamamlandi_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tamamlandi_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tamamlandi_Btn.Location = new System.Drawing.Point(232, 162);
            this.Tamamlandi_Btn.Name = "Tamamlandi_Btn";
            this.Tamamlandi_Btn.Size = new System.Drawing.Size(216, 65);
            this.Tamamlandi_Btn.TabIndex = 18;
            this.Tamamlandi_Btn.Text = "Gönder";
            this.Tamamlandi_Btn.UseVisualStyleBackColor = false;
            this.Tamamlandi_Btn.Click += new System.EventHandler(this.Gonder_Btn_Click);
            // 
            // A_DestekCevapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.Tamamlandi_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cevap_Box);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_DestekCevapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_DestekCevapForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.RichTextBox Cevap_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Tamamlandi_Btn;
    }
}