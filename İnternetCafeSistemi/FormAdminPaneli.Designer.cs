namespace İnternetCafeSistemi
{
    partial class FormAdminPaneli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMasaInfo = new System.Windows.Forms.Panel();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.txtMasaDurumu = new System.Windows.Forms.TextBox();
            this.txtMasaAdı = new System.Windows.Forms.TextBox();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.masaDurumu = new System.Windows.Forms.Label();
            this.masaAdi = new System.Windows.Forms.Label();
            this.masaID = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPageMenü = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMasaOlustur = new System.Windows.Forms.Button();
            this.dataGridViewKullanici = new System.Windows.Forms.DataGridView();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.labelKullaniciID = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.LabelClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMasaInfo.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPageMenü.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 44);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.LabelClock);
            this.panel2.Location = new System.Drawing.Point(640, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 44);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "by Esox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NETCafeSystem";
            // 
            // panelMasaInfo
            // 
            this.panelMasaInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMasaInfo.Controls.Add(this.txtKullanici);
            this.panelMasaInfo.Controls.Add(this.labelKullanici);
            this.panelMasaInfo.Controls.Add(this.txtKullaniciID);
            this.panelMasaInfo.Controls.Add(this.labelKullaniciID);
            this.panelMasaInfo.Controls.Add(this.btnMasaAc);
            this.panelMasaInfo.Controls.Add(this.txtMasaDurumu);
            this.panelMasaInfo.Controls.Add(this.txtMasaAdı);
            this.panelMasaInfo.Controls.Add(this.txtMasaID);
            this.panelMasaInfo.Controls.Add(this.masaDurumu);
            this.panelMasaInfo.Controls.Add(this.masaAdi);
            this.panelMasaInfo.Controls.Add(this.masaID);
            this.panelMasaInfo.Location = new System.Drawing.Point(-1, 43);
            this.panelMasaInfo.Name = "panelMasaInfo";
            this.panelMasaInfo.Size = new System.Drawing.Size(207, 255);
            this.panelMasaInfo.TabIndex = 1;
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(68, 220);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(75, 23);
            this.btnMasaAc.TabIndex = 6;
            this.btnMasaAc.Text = "Masayı Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // txtMasaDurumu
            // 
            this.txtMasaDurumu.Location = new System.Drawing.Point(114, 89);
            this.txtMasaDurumu.Name = "txtMasaDurumu";
            this.txtMasaDurumu.ReadOnly = true;
            this.txtMasaDurumu.Size = new System.Drawing.Size(78, 20);
            this.txtMasaDurumu.TabIndex = 5;
            // 
            // txtMasaAdı
            // 
            this.txtMasaAdı.Location = new System.Drawing.Point(114, 59);
            this.txtMasaAdı.Name = "txtMasaAdı";
            this.txtMasaAdı.ReadOnly = true;
            this.txtMasaAdı.Size = new System.Drawing.Size(78, 20);
            this.txtMasaAdı.TabIndex = 4;
            // 
            // txtMasaID
            // 
            this.txtMasaID.Location = new System.Drawing.Point(114, 29);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.ReadOnly = true;
            this.txtMasaID.Size = new System.Drawing.Size(78, 20);
            this.txtMasaID.TabIndex = 3;
            // 
            // masaDurumu
            // 
            this.masaDurumu.AutoSize = true;
            this.masaDurumu.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaDurumu.Location = new System.Drawing.Point(11, 89);
            this.masaDurumu.Name = "masaDurumu";
            this.masaDurumu.Size = new System.Drawing.Size(106, 19);
            this.masaDurumu.TabIndex = 2;
            this.masaDurumu.Text = "Masa Durumu:";
            // 
            // masaAdi
            // 
            this.masaAdi.AutoSize = true;
            this.masaAdi.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaAdi.Location = new System.Drawing.Point(41, 59);
            this.masaAdi.Name = "masaAdi";
            this.masaAdi.Size = new System.Drawing.Size(76, 19);
            this.masaAdi.TabIndex = 1;
            this.masaAdi.Text = "Masa Adı:";
            // 
            // masaID
            // 
            this.masaID.AutoSize = true;
            this.masaID.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masaID.Location = new System.Drawing.Point(52, 29);
            this.masaID.Name = "masaID";
            this.masaID.Size = new System.Drawing.Size(65, 19);
            this.masaID.TabIndex = 0;
            this.masaID.Text = "MasaID:";
            // 
            // Tabs
            // 
            this.Tabs.AccessibleName = "";
            this.Tabs.Controls.Add(this.tabPageMenü);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tabs.Location = new System.Drawing.Point(206, 44);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(599, 258);
            this.Tabs.TabIndex = 2;
            this.Tabs.Tag = "";
            this.Tabs.Click += new System.EventHandler(this.Tabs_Click);
            // 
            // tabPageMenü
            // 
            this.tabPageMenü.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMenü.Controls.Add(this.flowLayoutPanel1);
            this.tabPageMenü.Location = new System.Drawing.Point(4, 24);
            this.tabPageMenü.Name = "tabPageMenü";
            this.tabPageMenü.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenü.Size = new System.Drawing.Size(591, 230);
            this.tabPageMenü.TabIndex = 0;
            this.tabPageMenü.Tag = "";
            this.tabPageMenü.Text = "MASALAR";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(585, 223);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridViewKullanici);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ÜYELER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 145);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnMasaOlustur
            // 
            this.btnMasaOlustur.Location = new System.Drawing.Point(51, 341);
            this.btnMasaOlustur.Name = "btnMasaOlustur";
            this.btnMasaOlustur.Size = new System.Drawing.Size(101, 47);
            this.btnMasaOlustur.TabIndex = 4;
            this.btnMasaOlustur.Text = "Masa Oluştur";
            this.btnMasaOlustur.UseVisualStyleBackColor = true;
            this.btnMasaOlustur.Click += new System.EventHandler(this.btnMasaOlustur_Click);
            // 
            // dataGridViewKullanici
            // 
            this.dataGridViewKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanici.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKullanici.Name = "dataGridViewKullanici";
            this.dataGridViewKullanici.Size = new System.Drawing.Size(341, 230);
            this.dataGridViewKullanici.TabIndex = 0;
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(114, 117);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.ReadOnly = true;
            this.txtKullaniciID.Size = new System.Drawing.Size(78, 20);
            this.txtKullaniciID.TabIndex = 8;
            // 
            // labelKullaniciID
            // 
            this.labelKullaniciID.AutoSize = true;
            this.labelKullaniciID.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullaniciID.Location = new System.Drawing.Point(30, 118);
            this.labelKullaniciID.Name = "labelKullaniciID";
            this.labelKullaniciID.Size = new System.Drawing.Size(85, 19);
            this.labelKullaniciID.TabIndex = 7;
            this.labelKullaniciID.Text = "Kullanıcı ID:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(113, 145);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.ReadOnly = true;
            this.txtKullanici.Size = new System.Drawing.Size(78, 20);
            this.txtKullanici.TabIndex = 10;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKullanici.Location = new System.Drawing.Point(48, 145);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(67, 19);
            this.labelKullanici.TabIndex = 9;
            this.labelKullanici.Text = "Kullanıcı:";
            // 
            // LabelClock
            // 
            this.LabelClock.AutoSize = true;
            this.LabelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelClock.Location = new System.Drawing.Point(0, 0);
            this.LabelClock.Name = "LabelClock";
            this.LabelClock.Size = new System.Drawing.Size(0, 20);
            this.LabelClock.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.Location = new System.Drawing.Point(4, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 20);
            this.labelDate.TabIndex = 1;
            // 
            // FormAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMasaOlustur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.panelMasaInfo);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdminPaneli";
            this.Text = "FormAdminPaneli";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMasaInfo.ResumeLayout(false);
            this.panelMasaInfo.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPageMenü.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMasaInfo;
        private System.Windows.Forms.Label masaAdi;
        private System.Windows.Forms.Label masaID;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageMenü;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMasaOlustur;
        private System.Windows.Forms.Label masaDurumu;
        private System.Windows.Forms.TextBox txtMasaDurumu;
        private System.Windows.Forms.TextBox txtMasaAdı;
        private System.Windows.Forms.TextBox txtMasaID;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.DataGridView dataGridViewKullanici;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Label labelKullaniciID;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label LabelClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDate;
    }
}