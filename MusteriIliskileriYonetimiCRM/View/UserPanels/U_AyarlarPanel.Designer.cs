namespace MusteriIliskileriYonetimiCRM.View.UserPanels
{
    partial class U_AyarlarPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NewPass_Box = new System.Windows.Forms.TextBox();
            this.Oldpass_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangePass_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusteriIliskileriYonetimiCRM.Properties.Resources.settings2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(381, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Eski Şifre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Figtree", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(520, 298);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Yeni Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewPass_Box
            // 
            this.NewPass_Box.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NewPass_Box.Location = new System.Drawing.Point(479, 262);
            this.NewPass_Box.Name = "NewPass_Box";
            this.NewPass_Box.PasswordChar = '*';
            this.NewPass_Box.Size = new System.Drawing.Size(160, 30);
            this.NewPass_Box.TabIndex = 33;
            // 
            // Oldpass_Box
            // 
            this.Oldpass_Box.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Oldpass_Box.Location = new System.Drawing.Point(479, 226);
            this.Oldpass_Box.Name = "Oldpass_Box";
            this.Oldpass_Box.PasswordChar = '*';
            this.Oldpass_Box.Size = new System.Drawing.Size(160, 30);
            this.Oldpass_Box.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(381, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yeni Şifre";
            // 
            // ChangePass_Btn
            // 
            this.ChangePass_Btn.BackColor = System.Drawing.Color.Teal;
            this.ChangePass_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePass_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChangePass_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChangePass_Btn.Location = new System.Drawing.Point(423, 333);
            this.ChangePass_Btn.Name = "ChangePass_Btn";
            this.ChangePass_Btn.Size = new System.Drawing.Size(216, 45);
            this.ChangePass_Btn.TabIndex = 35;
            this.ChangePass_Btn.Text = "Şifreyi Değiştir";
            this.ChangePass_Btn.UseVisualStyleBackColor = false;
            this.ChangePass_Btn.Click += new System.EventHandler(this.ChangePass_Btn_Click);
            // 
            // U_AyarlarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChangePass_Btn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Oldpass_Box);
            this.Controls.Add(this.NewPass_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "U_AyarlarPanel";
            this.Size = new System.Drawing.Size(1045, 570);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox NewPass_Box;
        private System.Windows.Forms.TextBox Oldpass_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangePass_Btn;
    }
}
