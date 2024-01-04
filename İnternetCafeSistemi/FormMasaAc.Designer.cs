namespace İnternetCafeSistemi
{
    partial class FormMasaAc
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
            this.radioSüreli = new System.Windows.Forms.RadioButton();
            this.radioSüresiz = new System.Windows.Forms.RadioButton();
            this.comboSüreli = new System.Windows.Forms.ComboBox();
            this.btnMasaAc = new System.Windows.Forms.Button();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtMasaADI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioSüreli
            // 
            this.radioSüreli.AutoSize = true;
            this.radioSüreli.Location = new System.Drawing.Point(86, 110);
            this.radioSüreli.Name = "radioSüreli";
            this.radioSüreli.Size = new System.Drawing.Size(51, 17);
            this.radioSüreli.TabIndex = 0;
            this.radioSüreli.TabStop = true;
            this.radioSüreli.Text = "Süreli";
            this.radioSüreli.UseVisualStyleBackColor = true;
            this.radioSüreli.CheckedChanged += new System.EventHandler(this.radioSüresiz_CheckedChanged);
            // 
            // radioSüresiz
            // 
            this.radioSüresiz.AutoSize = true;
            this.radioSüresiz.Location = new System.Drawing.Point(148, 110);
            this.radioSüresiz.Name = "radioSüresiz";
            this.radioSüresiz.Size = new System.Drawing.Size(59, 17);
            this.radioSüresiz.TabIndex = 1;
            this.radioSüresiz.TabStop = true;
            this.radioSüresiz.Text = "Süresiz";
            this.radioSüresiz.UseVisualStyleBackColor = true;
            this.radioSüresiz.CheckedChanged += new System.EventHandler(this.radioSüresiz_CheckedChanged);
            // 
            // comboSüreli
            // 
            this.comboSüreli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSüreli.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "120",
            "180"});
            this.comboSüreli.Location = new System.Drawing.Point(86, 146);
            this.comboSüreli.Name = "comboSüreli";
            this.comboSüreli.Size = new System.Drawing.Size(121, 21);
            this.comboSüreli.TabIndex = 2;
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(107, 186);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(75, 45);
            this.btnMasaAc.TabIndex = 3;
            this.btnMasaAc.Text = "Masayı Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);
            // 
            // txtMasaID
            // 
            this.txtMasaID.Location = new System.Drawing.Point(98, 36);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.ReadOnly = true;
            this.txtMasaID.Size = new System.Drawing.Size(100, 20);
            this.txtMasaID.TabIndex = 4;
            // 
            // txtMasaADI
            // 
            this.txtMasaADI.Location = new System.Drawing.Point(98, 73);
            this.txtMasaADI.Name = "txtMasaADI";
            this.txtMasaADI.ReadOnly = true;
            this.txtMasaADI.Size = new System.Drawing.Size(100, 20);
            this.txtMasaADI.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "MasaID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Masa Adı:";
            // 
            // FormMasaAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasaADI);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.btnMasaAc);
            this.Controls.Add(this.comboSüreli);
            this.Controls.Add(this.radioSüresiz);
            this.Controls.Add(this.radioSüreli);
            this.Name = "FormMasaAc";
            this.Text = "FormMasaAc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioSüreli;
        private System.Windows.Forms.RadioButton radioSüresiz;
        private System.Windows.Forms.ComboBox comboSüreli;
        private System.Windows.Forms.Button btnMasaAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMasaID;
        public System.Windows.Forms.TextBox txtMasaADI;
    }
}