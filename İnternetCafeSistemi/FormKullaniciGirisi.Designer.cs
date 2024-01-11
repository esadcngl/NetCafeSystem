namespace İnternetCafeSistemi
{
    partial class FormKullaniciGirisi
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linklabelSifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(106, 177);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(82, 30);
            this.btnGiris.TabIndex = 9;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(123, 120);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(116, 24);
            this.txtSifre.TabIndex = 8;
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(84, 122);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(41, 17);
            this.labelSifre.TabIndex = 7;
            this.labelSifre.Text = "Sifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(123, 76);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(116, 24);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // linklabelSifreUnuttum
            // 
            this.linklabelSifreUnuttum.AutoSize = true;
            this.linklabelSifreUnuttum.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklabelSifreUnuttum.Location = new System.Drawing.Point(120, 147);
            this.linklabelSifreUnuttum.Name = "linklabelSifreUnuttum";
            this.linklabelSifreUnuttum.Size = new System.Drawing.Size(87, 15);
            this.linklabelSifreUnuttum.TabIndex = 10;
            this.linklabelSifreUnuttum.TabStop = true;
            this.linklabelSifreUnuttum.Text = "şifremi unuttum";
            this.linklabelSifreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelSifreUnuttum_LinkClicked);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.arrow__1_;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGeri.Location = new System.Drawing.Point(221, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(37, 31);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.close__3___1_;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKapat.Location = new System.Drawing.Point(264, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(37, 31);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.linklabelSifreUnuttum);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklabelSifreUnuttum;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKapat;
    }
}