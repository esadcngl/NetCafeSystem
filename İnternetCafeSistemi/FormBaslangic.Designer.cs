namespace İnternetCafeSistemi
{
    partial class FormBaslangic
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
            this.btnKullanıcıGiris = new System.Windows.Forms.Button();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullanıcıGiris
            // 
            this.btnKullanıcıGiris.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKullanıcıGiris.Image = global::İnternetCafeSistemi.Properties.Resources.group150;
            this.btnKullanıcıGiris.Location = new System.Drawing.Point(257, 71);
            this.btnKullanıcıGiris.Name = "btnKullanıcıGiris";
            this.btnKullanıcıGiris.Size = new System.Drawing.Size(200, 200);
            this.btnKullanıcıGiris.TabIndex = 1;
            this.btnKullanıcıGiris.Text = "Kullanıcı Girişi";
            this.btnKullanıcıGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanıcıGiris.UseVisualStyleBackColor = true;
            this.btnKullanıcıGiris.Click += new System.EventHandler(this.btnKullanıcıGiris_Click);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminGiris.Image = global::İnternetCafeSistemi.Properties.Resources.admin180;
            this.btnAdminGiris.Location = new System.Drawing.Point(24, 71);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(200, 200);
            this.btnAdminGiris.TabIndex = 0;
            this.btnAdminGiris.Text = "Admin Girişi";
            this.btnAdminGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.close__3___1_;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKapat.Location = new System.Drawing.Point(444, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(37, 31);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKullanıcıGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaslangic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnKullanıcıGiris;
        private System.Windows.Forms.Button btnKapat;
    }
}