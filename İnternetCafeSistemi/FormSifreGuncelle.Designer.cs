namespace İnternetCafeSistemi
{
    partial class FormSifreGuncelle
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(175, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnayla.Location = new System.Drawing.Point(212, 167);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 26);
            this.btnOnayla.TabIndex = 16;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // confirmpass
            // 
            this.confirmpass.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirmpass.Location = new System.Drawing.Point(174, 114);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.PasswordChar = '*';
            this.confirmpass.Size = new System.Drawing.Size(163, 22);
            this.confirmpass.TabIndex = 15;
            // 
            // newpass
            // 
            this.newpass.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newpass.Location = new System.Drawing.Point(174, 73);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '*';
            this.newpass.Size = new System.Drawing.Size(163, 22);
            this.newpass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yeni Şifre Onayla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yeni Şifre Giriniz:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.arrow__1_;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGeri.Location = new System.Drawing.Point(372, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(37, 31);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.close__3___1_;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKapat.Location = new System.Drawing.Point(415, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(37, 31);
            this.btnKapat.TabIndex = 18;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormSifreGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 249);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.newpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSifreGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSifreGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKapat;
    }
}