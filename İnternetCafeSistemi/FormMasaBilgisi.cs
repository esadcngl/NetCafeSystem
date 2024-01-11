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
           
        public static int Kullaniciid;
        TableOturumlar oturum = new TableOturumlar();

        public FormMasaBilgisi()
        {
            NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = Screen.PrimaryScreen.Bounds.Right - this.Width;
            this.Top = Screen.PrimaryScreen.Bounds.Bottom - this.Height;
            timer1.Start();
            
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            var oturumlar = netCafeDB.TableOturumlar.Where(o => o.KullaniciID == Kullaniciid).ToList();
            var eşleşenOturum = oturumlar.FirstOrDefault();

            var kullanicilar = netCafeDB.TableKullanicilar.Where(k => k.KullaniciID == Kullaniciid).ToList();
            var eşleşenKullanici = kullanicilar.FirstOrDefault();
            if (eşleşenOturum != null)
            {
                TimeSpan gecenSure = (TimeSpan)(DateTime.Now - eşleşenOturum.BaslangicZamani);
                txtBaslamaSaati.Text = eşleşenOturum.BaslangicZamani.ToString();
                txtGecenSüre.Text = gecenSure.Minutes.ToString();
                txtUcret.Text = eşleşenOturum.Ucret.ToString();
                
                if (gecenSure.Minutes.ToString() == eşleşenOturum.AcilisTuru)
                {
                   
                    TableSatis yeniSepet = new TableSatis();
                    yeniSepet.KullaniciID = eşleşenOturum.KullaniciID;
                    yeniSepet.MasaID = eşleşenOturum.MasaID;
                    yeniSepet.BaslangicZamani = eşleşenOturum.BaslangicZamani;
                    yeniSepet.BitisZamani = DateTime.Now;
                    yeniSepet.AcilisTuru = eşleşenOturum.AcilisTuru;
                    yeniSepet.KullanilanSüre = eşleşenOturum.KullanilanSure;
                    yeniSepet.Ucret = eşleşenOturum
                        .Ucret;
                    // TableSepet tablosuna yeni kaydı ekle
                    netCafeDB.TableSatis.Add(yeniSepet);
                    // Değişiklikleri kaydet
                    netCafeDB.SaveChanges();


                    // TableHareketler tablosuna ilgili hareketi ekle
                    TableHareketler hareket = new TableHareketler();
                    hareket.KullaniciID = eşleşenOturum.KullaniciID;
                    hareket.MasaID = eşleşenOturum.MasaID;
                    hareket.IslemTuru = "MASA KAPATMA";
                    hareket.IslemZamani = DateTime.Now;
                    netCafeDB.TableHareketler.Add(hareket);

                    eşleşenKullanici.IstekDurum = 0;
                    eşleşenKullanici.MasaID = null;
                    
                    oturum.KullaniciID = null;
                    oturum.MasaID = null;
                    oturum.BaslangicZamani = null;
                    oturum.BitisZamanı = null;
                    oturum.AcilisTuru = null;
                    oturum.KullanilanSure = null;
                    oturum.Ucret = null;
                    // TableMasalar tablosundaki ilgili masanın durumunu "BOŞ" olarak güncelle
                    TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaID == eşleşenOturum.MasaID);
                    if (masa != null)
                    {
                        masa.Durumu = "BOŞ";
                        masa.KullaniciID = null;
                       
                    }
                    netCafeDB.SaveChanges();
                    FormKullaniciGirisi formKullaniciGirisi = new FormKullaniciGirisi();
                    formKullaniciGirisi.Show();
                    timer1.Stop();
                    MessageBox.Show("süreniz Dolmuştur.");
                    this.Close();
                }
            }
        }
    }
}
