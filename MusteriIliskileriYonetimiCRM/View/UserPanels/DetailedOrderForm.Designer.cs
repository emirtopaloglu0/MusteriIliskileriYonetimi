namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    partial class DetailedOrderForm
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
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.Siparis_Listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::MusteriIliskileriYonetimiCRM.Properties.Resources.close2;
            this.ExitButton.Location = new System.Drawing.Point(951, 11);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(83, 82);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Siparis_Listbox
            // 
            this.Siparis_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Siparis_Listbox.FormattingEnabled = true;
            this.Siparis_Listbox.HorizontalScrollbar = true;
            this.Siparis_Listbox.ItemHeight = 23;
            this.Siparis_Listbox.Location = new System.Drawing.Point(12, 11);
            this.Siparis_Listbox.Name = "Siparis_Listbox";
            this.Siparis_Listbox.Size = new System.Drawing.Size(934, 418);
            this.Siparis_Listbox.TabIndex = 11;
            // 
            // DetailedOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.Siparis_Listbox);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailedOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailedOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.ListBox Siparis_Listbox;
    }
}