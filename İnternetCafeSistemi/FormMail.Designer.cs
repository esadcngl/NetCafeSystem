namespace İnternetCafeSistemi
{
    partial class FormMail
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDogrulama = new System.Windows.Forms.TextBox();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.btnGönder = new System.Windows.Forms.Button();
            this.txtBoxEposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doğrulama Kodu:";
            this.label2.Visible = false;
            // 
            // txtBoxDogrulama
            // 
            this.txtBoxDogrulama.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDogrulama.Location = new System.Drawing.Point(140, 163);
            this.txtBoxDogrulama.Name = "txtBoxDogrulama";
            this.txtBoxDogrulama.Size = new System.Drawing.Size(245, 21);
            this.txtBoxDogrulama.TabIndex = 10;
            this.txtBoxDogrulama.Visible = false;
            // 
            // btnDogrula
            // 
            this.btnDogrula.BackColor = System.Drawing.Color.Silver;
            this.btnDogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogrula.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDogrula.Location = new System.Drawing.Point(406, 162);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(75, 23);
            this.btnDogrula.TabIndex = 9;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = false;
            this.btnDogrula.Visible = false;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // btnGönder
            // 
            this.btnGönder.BackColor = System.Drawing.Color.Silver;
            this.btnGönder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGönder.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGönder.Location = new System.Drawing.Point(406, 89);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(75, 23);
            this.btnGönder.TabIndex = 8;
            this.btnGönder.Text = "Gönder";
            this.btnGönder.UseVisualStyleBackColor = false;
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // txtBoxEposta
            // 
            this.txtBoxEposta.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxEposta.Location = new System.Drawing.Point(140, 90);
            this.txtBoxEposta.Name = "txtBoxEposta";
            this.txtBoxEposta.Size = new System.Drawing.Size(245, 21);
            this.txtBoxEposta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-Posta Adresi:";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.arrow__1_;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGeri.Location = new System.Drawing.Point(434, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(37, 31);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::İnternetCafeSistemi.Properties.Resources.close__3___1_;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKapat.Location = new System.Drawing.Point(477, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(37, 31);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 275);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDogrulama);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.txtBoxEposta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDogrulama;
        private System.Windows.Forms.Button btnDogrula;
        private System.Windows.Forms.Button btnGönder;
        private System.Windows.Forms.TextBox txtBoxEposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKapat;
    }
}