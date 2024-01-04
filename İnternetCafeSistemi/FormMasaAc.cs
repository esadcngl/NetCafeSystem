using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafeSistemi
{
    public partial class FormMasaAc : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        private Timer timer;
        public FormMasaAc()
        {
            InitializeComponent();
            
            timer = new Timer();
            timer.Interval = 1000; // Her saniyede bir kontrol et
            
        }
        
        
        RadioButton radio;
        private void radioSüresiz_CheckedChanged(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
            if (radio == radioSüreli)
            {
                comboSüreli.Visible = true;
            }
            else
            {
                comboSüreli.Visible = false;
            }
        }
        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    // Şu anki zamanı al
        //    DateTime suAnkiZaman = DateTime.Now;

        //    // Geçen süreyi kontrol et
        //    //TimeSpan gecenSure = suAnkiZaman - baslangicZamani;

        //    // Maksimum süreyi aştıysa işlemleri gerçekleştir
        //    if (gecenSure.TotalMinutes >= Convert.ToInt32(comboSüreli.Text))
        //    {
        //        MasaKapat(); // Masa kapatma işlemi
        //    }
        //}
        private void MasaKapat()
        {
            // Burada masa kapatma işlemlerini gerçekleştirin
            // Örneğin, veritabanındaki durumu güncelleyebilir veya kullanıcıyı otomatik olarak çıkartabilirsiniz.

            // Timer'ı durdur
            timer.Stop();

            // Masa kapatma işlemleri burada gerçekleştirilecek
            // Örneğin, veritabanındaki durumu güncelleme veya kullanıcıyı otomatik olarak çıkartma işlemleri yapılabilir.
        }
        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            string dakika;
            if (radio == radioSüreli)
            {
                if (comboSüreli.Text == "")
                {
                    MessageBox.Show("Lütfen dakika seçiniz.");
                }
                else
                {
                    dakika = comboSüreli.Text;
                }
            }else if (radio == radioSüresiz)
            {
                dakika = "süresiz";
            }
            DateTime suAn = DateTime.Now;
            TimeSpan saatDakika = suAn.TimeOfDay;
            DateTime saatDakika2 = DateTime.Today.Add(saatDakika);
            TableOturumlar oturum = new TableOturumlar();
            TableMasalar masa = new TableMasalar();
            oturum.KullaniciID = 1;
            oturum.MasaID = Convert.ToInt32(txtMasaID.Text);
            oturum.BaslangicZamani =saatDakika2;
            netCafeDB.TableOturumlar.Add(oturum);
            netCafeDB.SaveChanges();
            int id = Convert.ToInt32(txtMasaID.Text);
            var guncellenicekMasa = netCafeDB.TableMasalar.Find(id);
            guncellenicekMasa.Durumu = "DOLU";
            netCafeDB.SaveChanges();
            
        }
    }
}
