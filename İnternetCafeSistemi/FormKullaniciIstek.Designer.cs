namespace İnternetCafeSistemi
{
    partial class FormKullaniciIstek
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
            this.components = new System.ComponentModel.Container();
            this.btnsüresiz = new System.Windows.Forms.Button();
            this.btnSüreli15 = new System.Windows.Forms.Button();
            this.btnSüreli30 = new System.Windows.Forms.Button();
            this.btnSüreli45 = new System.Windows.Forms.Button();
            this.btnSüreli60 = new System.Windows.Forms.Button();
            this.btnSüreli120 = new System.Windows.Forms.Button();
            this.btnSüreli180 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMasalar = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnsüresiz
            // 
            this.btnsüresiz.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsüresiz.Location = new System.Drawing.Point(37, 77);
            this.btnsüresiz.Name = "btnsüresiz";
            this.btnsüresiz.Size = new System.Drawing.Size(186, 28);
            this.btnsüresiz.TabIndex = 0;
            this.btnsüresiz.Text = "Süresiz Masa Açma İsteği Gönder";
            this.btnsüresiz.UseVisualStyleBackColor = true;
            this.btnsüresiz.Click += new System.EventHandler(this.btnsüresiz_Click);
            // 
            // btnSüreli15
            // 
            this.btnSüreli15.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSüreli15.Location = new System.Drawing.Point(37, 111);
            this.btnSüreli15.Name = "btnSüreli15";
            this.btnSüreli15.Size = new System.Drawing.Size(186, 28);
            this.btnSüreli15.TabIndex = 1;
            this.btnSüreli15.Text = "15 dk Masa Açma İsteği Gönder";
            this.btnSüreli15.UseVisualStyleBackColor = true;
            this.btnSüreli15.Click += new System.EventHandler(this.btnSüreli15_Click);
            // 
            // btnSüreli30
            // 
            this.btnSüreli30.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSüreli30.Location = new System.Drawing.Point(37, 145);
            this.btnSüreli30.Name = "btnSüreli30";
            this.btnSüreli30.Size = new System.Drawing.Size(186, 28);
            this.btnSüreli30.TabIndex = 2;
            this.btnSüreli30.Text = "30 dk Masa Açma İsteği Gönder";
            this.btnSüreli30.UseVisualStyleBackColor = true;
            this.btnSüreli30.Click += new System.EventHandler(this.btnSüreli30_Click);
            // 
            // btnSüreli45
            // 
            this.btnSüreli45.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSüreli45.Location = new System.Drawing.Point(37, 179);
            this.btnSüreli45.Name = "btnSüreli45";
            this.btnSüreli45.Size = new System.Drawing.Size(186, 28);
            this.btnSüreli45.TabIndex = 3;
            this.btnSüreli45.Text = "45 dk Masa Açma İsteği Gönder";
            this.btnSüreli45.UseVisualStyleBackColor = true;
            this.btnSüreli45.Click += new System.EventHandler(this.btnSüreli45_Click);
            // 
            // btnSüreli60
            // 
            this.btnSüreli60.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSüreli60.Location = new System.Drawing.Point(37, 213);
            this.btnSüreli60.Name = "btnSüreli60";
            this.btnSüreli60.Size = new System.Drawing.Size(186, 28);
            this.btnSüreli60.TabIndex = 4;
            this.btnSüreli60.Text = "60 dk Masa Açma İsteği Gönder";
            this.btnSüreli60.UseVisualStyleBackColor = true;
            this.btnSüreli60.Click += new System.EventHandler(this.btnSüreli60_Click);
            // 
            // btnSüreli120
            // 
            this.btnSüreli120.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSüreli120.Location = new System.Drawing.Point(37, 247);
            this.btnSüreli120.Name = "btnSüreli120";
            this.btnSüreli120.Size = new System.Drawing.Size(186, 28);
            this.btnSüreli120.TabIndex = 5;
            this.btnSüreli120.Text = "120 dk Masa Açma İsteği Gönder";
            this.btnSüreli120.UseVisualStyleBackColor = true;
            this.btnSüreli120.Click += new System.EventHandler(this.btnSüreli120_Click);
            // 
            // btnSüreli180
            // 
            this.btnSüreli180.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSüreli180.Location = new System.Drawing.Point(37, 281);
            this.btnSüreli180.Name = "btnSüreli180";
            this.btnSüreli180.Size = new System.Drawing.Size(186, 28);
            this.btnSüreli180.TabIndex = 6;
            this.btnSüreli180.Text = "180 dk Masa Açma İsteği Gönder";
            this.btnSüreli180.UseVisualStyleBackColor = true;
            this.btnSüreli180.Click += new System.EventHandler(this.btnSüreli180_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Masa Seçiniz";
            // 
            // comboMasalar
            // 
            this.comboMasalar.FormattingEnabled = true;
            this.comboMasalar.Location = new System.Drawing.Point(67, 40);
            this.comboMasalar.Name = "comboMasalar";
            this.comboMasalar.Size = new System.Drawing.Size(121, 21);
            this.comboMasalar.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormKullaniciIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 332);
            this.Controls.Add(this.comboMasalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSüreli180);
            this.Controls.Add(this.btnSüreli120);
            this.Controls.Add(this.btnSüreli60);
            this.Controls.Add(this.btnSüreli45);
            this.Controls.Add(this.btnSüreli30);
            this.Controls.Add(this.btnSüreli15);
            this.Controls.Add(this.btnsüresiz);
            this.Name = "FormKullaniciIstek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsüresiz;
        private System.Windows.Forms.Button btnSüreli15;
        private System.Windows.Forms.Button btnSüreli30;
        private System.Windows.Forms.Button btnSüreli45;
        private System.Windows.Forms.Button btnSüreli60;
        private System.Windows.Forms.Button btnSüreli120;
        private System.Windows.Forms.Button btnSüreli180;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMasalar;
        private System.Windows.Forms.Timer timer1;
    }
}