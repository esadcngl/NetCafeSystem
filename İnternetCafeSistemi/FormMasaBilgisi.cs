using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafeSistemi
{
    public partial class FormMasaBilgisi : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
            FormKullaniciIstek formKullaniciGirisi = new FormKullaniciIstek();

        TableOturumlar oturum = new TableOturumlar();
        public FormMasaBilgisi()
        {
            NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.Bounds.Right - this.Width;
            this.Top = Screen.PrimaryScreen.Bounds.Bottom - this.Height;
            timer1.Start();
            var oturumlar = netCafeDB.TableOturumlar.Where(o => o.KullaniciID == formKullaniciGirisi.kullaniciID).ToList();
            if (oturumlar != null)
            {
                int oturumNo = oturum.OturumID;
                label1.Text = "OTURUM - " + oturumNo;
                txtBaslamaSaati.Text = oturum.BaslangicZamani.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var oturumlar = netCafeDB.TableOturumlar.Where(o => o.KullaniciID == formKullaniciGirisi.kullaniciID).ToList();
            if (oturumlar != null)
            {
                TimeSpan gecenSure = (TimeSpan)(DateTime.Now - oturum.BaslangicZamani);
                txtGecenSüre.Text = gecenSure.Minutes.ToString();
                txtUcret.Text = oturum.Ucret.ToString();
                if (gecenSure.ToString() == oturum.AcilisTuru)
                {
                    MessageBox.Show("süreniz Dolmuştur");
                    this.Close();

                }
            }
        }
    }
}
