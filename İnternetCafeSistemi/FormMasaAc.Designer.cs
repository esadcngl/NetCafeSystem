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
            this.SuspendLayout();
            // 
            // radioSüreli
            // 
            this.radioSüreli.AutoSize = true;
            this.radioSüreli.Location = new System.Drawing.Point(91, 38);
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
            this.radioSüresiz.Location = new System.Drawing.Point(153, 38);
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
            this.comboSüreli.Location = new System.Drawing.Point(91, 74);
            this.comboSüreli.Name = "comboSüreli";
            this.comboSüreli.Size = new System.Drawing.Size(121, 21);
            this.comboSüreli.TabIndex = 2;
            // 
            // btnMasaAc
            // 
            this.btnMasaAc.Location = new System.Drawing.Point(117, 114);
            this.btnMasaAc.Name = "btnMasaAc";
            this.btnMasaAc.Size = new System.Drawing.Size(75, 45);
            this.btnMasaAc.TabIndex = 3;
            this.btnMasaAc.Text = "Masayı Aç";
            this.btnMasaAc.UseVisualStyleBackColor = true;
            // 
            // FormMasaAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 204);
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
    }
}