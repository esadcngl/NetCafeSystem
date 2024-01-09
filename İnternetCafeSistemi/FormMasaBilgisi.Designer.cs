namespace İnternetCafeSistemi
{
    partial class FormMasaBilgisi
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
            this.groupBoxHesap = new System.Windows.Forms.GroupBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtGecenSüre = new System.Windows.Forms.TextBox();
            this.txtBaslamaSaati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxHesap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHesap
            // 
            this.groupBoxHesap.Controls.Add(this.txtUcret);
            this.groupBoxHesap.Controls.Add(this.txtGecenSüre);
            this.groupBoxHesap.Controls.Add(this.txtBaslamaSaati);
            this.groupBoxHesap.Controls.Add(this.label4);
            this.groupBoxHesap.Controls.Add(this.label3);
            this.groupBoxHesap.Controls.Add(this.label2);
            this.groupBoxHesap.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxHesap.Location = new System.Drawing.Point(13, 95);
            this.groupBoxHesap.Name = "groupBoxHesap";
            this.groupBoxHesap.Size = new System.Drawing.Size(255, 201);
            this.groupBoxHesap.TabIndex = 0;
            this.groupBoxHesap.TabStop = false;
            this.groupBoxHesap.Text = "Oturum Bilgisi";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(136, 124);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(100, 26);
            this.txtUcret.TabIndex = 6;
            // 
            // txtGecenSüre
            // 
            this.txtGecenSüre.Location = new System.Drawing.Point(136, 92);
            this.txtGecenSüre.Name = "txtGecenSüre";
            this.txtGecenSüre.Size = new System.Drawing.Size(100, 26);
            this.txtGecenSüre.TabIndex = 5;
            // 
            // txtBaslamaSaati
            // 
            this.txtBaslamaSaati.Location = new System.Drawing.Point(136, 60);
            this.txtBaslamaSaati.Name = "txtBaslamaSaati";
            this.txtBaslamaSaati.Size = new System.Drawing.Size(100, 26);
            this.txtBaslamaSaati.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geçen Süre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlama Saati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "OTURUM - ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMasaBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxHesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMasaBilgisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NetCafeByEsadcngl v1";
            this.groupBoxHesap.ResumeLayout(false);
            this.groupBoxHesap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxHesap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtGecenSüre;
        private System.Windows.Forms.TextBox txtBaslamaSaati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}