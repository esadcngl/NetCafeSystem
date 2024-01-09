namespace İnternetCafeSistemi
{
    partial class FormMasaSilme
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
            this.comboMasalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasaSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboMasalar
            // 
            this.comboMasalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMasalar.FormattingEnabled = true;
            this.comboMasalar.Location = new System.Drawing.Point(68, 71);
            this.comboMasalar.Name = "comboMasalar";
            this.comboMasalar.Size = new System.Drawing.Size(121, 21);
            this.comboMasalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek istediğiniz masayı seçiniz.";
            // 
            // btnMasaSil
            // 
            this.btnMasaSil.Font = new System.Drawing.Font("Oceanwide Primer Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasaSil.Location = new System.Drawing.Point(79, 111);
            this.btnMasaSil.Name = "btnMasaSil";
            this.btnMasaSil.Size = new System.Drawing.Size(99, 29);
            this.btnMasaSil.TabIndex = 2;
            this.btnMasaSil.Text = "Masayı Sil";
            this.btnMasaSil.UseVisualStyleBackColor = true;
            this.btnMasaSil.Click += new System.EventHandler(this.btnMasaSil_Click);
            // 
            // FormMasaSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 187);
            this.Controls.Add(this.btnMasaSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMasalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMasaSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMasalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasaSil;
    }
}