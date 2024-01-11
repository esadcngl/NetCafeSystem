using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İnternetCafeSistemi
{
    public partial class FormYuklenmeEkrani : Form
    {
        public FormYuklenmeEkrani()
        {
            InitializeComponent();
            timer1.Start();

        }
        int startP = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            startP += rnd.Next(0,10);
            try { 
            progressBar1.Value = startP;
            label1.Text = startP + "%";
            label1.Location = new Point(146, 80);
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
               FormBaslangic formGirisEkranı = new FormBaslangic();
                formGirisEkranı.Show();
                this.Hide();
                timer1.Stop(); // Timer'ı buraya taşıdık
            }
            
            
            }catch  {
                progressBar1.Value = 100;
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                    FormBaslangic formGirisEkranı = new FormBaslangic();
                    formGirisEkranı.Show();
                    this.Hide();
                    timer1.Stop(); // Timer'ı buraya taşıdık
                }
            }

        }
    }
}
