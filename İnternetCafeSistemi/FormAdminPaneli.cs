using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace İnternetCafeSistemi
{
    public partial class FormAdminPaneli : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        private List<Button> masalar = new List<Button>();
        private Timer timerMasalar;

        RadioButton radioSecilen;

        public FormAdminPaneli()
        {
            Properties.Settings.Default.Save();
            InitializeComponent();
            LoadMasalar();
            panelMasaInfo.Visible = false;
            dataGridViewKullaniciDoldur();
            dataGridViewLogDoldur();
            LabelClock.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            TableOturumlar oturum = new TableOturumlar();
            timerMasalar = new Timer();
            timerMasalar.Interval = 1000; // Her bir saniye
            timerMasalar.Tick += TimerMasalar_Tick;
            timerMasalar.Start();
        }

        private void btnMasaOlustur_Click(object sender, EventArgs e)
        {
            Button yeniMasa = new Button();
            // Butonun özelliklerini belirle
            yeniMasa.Text = "Masa-" + (flowLayoutPanel1.Controls.Count + 1).ToString();
            yeniMasa.TextAlign = ContentAlignment.BottomCenter;
            yeniMasa.Image = Image.FromFile("C:\\Users\\Esadcngl\\Desktop\\NetCafeSystem\\İnternetCafeSistemi\\desktop.png");
            yeniMasa.ImageAlign = ContentAlignment.TopCenter;
            yeniMasa.Width = 75;
            yeniMasa.Height = 85;
            yeniMasa.Click += MasaButtonClick;
            yeniMasa.FlatStyle = FlatStyle.Flat;
            yeniMasa.BackColor = Color.LightGreen;
            masalar.Add(yeniMasa);
            // Her masanın benzersiz bir adı olsun
            flowLayoutPanel1.Controls.Add(yeniMasa);

            TableMasalar masa = new TableMasalar();
            masa.MasaAdi = yeniMasa.Text;
            masa.Durumu = "BOŞ";
            netCafeDB.TableMasalar.Add(masa);
            netCafeDB.SaveChanges();
            MessageBox.Show("Yeni Masa Eklendi.");

        }
        private void LoadMasalar()
        {
            // Veritabanındaki masaları yükle
            var dbMasalar = netCafeDB.TableMasalar.ToList();

            foreach (var dbMasa in dbMasalar)
            {
                Button masaButonu = new Button();
                if (dbMasa.Durumu == "BOŞ")
                {
                    masaButonu.BackColor = Color.LightGreen;
                }
                else if (dbMasa.Durumu == "DOLU")
                {
                    masaButonu.BackColor = Color.Red;
                }
                else if (dbMasa.Durumu == "İSTEK")
                {
                    masaButonu.BackColor = Color.Orange;
                }
                masaButonu.Text = dbMasa.MasaAdi;
                masaButonu.TextAlign = ContentAlignment.BottomCenter;
                masaButonu.Image = Image.FromFile("C:\\Users\\Esadcngl\\Desktop\\NetCafeSystem\\İnternetCafeSistemi\\desktop.png");
                masaButonu.ImageAlign = ContentAlignment.TopCenter;
                masaButonu.Width = 75;
                masaButonu.Height = 85;
                masaButonu.FlatStyle = FlatStyle.Flat;
                masaButonu.Click += MasaButtonClick;

                flowLayoutPanel1.Controls.Add(masaButonu);
                masalar.Add(masaButonu);
            }
        }
        private void MasaButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Masanın adını kullanarak veritabanından bilgileri al
                string masaAdi = clickedButton.Text;
                TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaAdi == masaAdi);


                if (masa.Durumu == "İSTEK" || masa.Durumu == "BOŞ")
                {
                    comboSüreli.Visible = true;
                    comboSüreli.SelectedItem = "15";
                    panelMasaDoluInfo.Visible = false;
                    radioSüresiz.Visible = true;
                    radioSüreli.Visible = true;
                    btnMasaAc.Visible = true;
                    txtMasaID.Text = masa.MasaID.ToString();
                    txtMasaAdı.Text = masa.MasaAdi;
                    txtMasaDurumu.Text = masa.Durumu;
                    txtKullanici.Visible = false;
                    labelKullanici.Visible = false;
                    panelMasaInfo.Visible = true;
                    if (masa.Durumu == "İSTEK")
                    {
                        string kullaniciAdi = netCafeDB.TableKullanicilar
                                    .Where(k => k.KullaniciID == masa.KullaniciID)
                                    .Select(k => k.KullaniciAdi)
                                    .FirstOrDefault();
                        txtKullanici.Text = kullaniciAdi;
                        txtKullanici.Visible = true;
                        labelKullanici.Visible = true;
                    }
                }
                else if (masa.Durumu == "DOLU")
                {
                    panelMasaInfo.Visible = true;
                    panelMasaDoluInfo.Visible = true;
                    int MasaID = masa.MasaID;
                    TableOturumlar oturum = netCafeDB.TableOturumlar.FirstOrDefault(o => o.MasaID == MasaID);
                    string kullaniciAdi = netCafeDB.TableKullanicilar
                              .Where(k => k.KullaniciID == oturum.KullaniciID)
                              .Select(k => k.KullaniciAdi)
                              .FirstOrDefault();
                    txtMasaDoluID.Text = masa.MasaID.ToString();
                    txtDoluMasaAdı.Text = masa.MasaAdi;
                    txtDoluMasaDurumu.Text = masa.Durumu;
                    txtDoluKAdi.Text = kullaniciAdi;
                    txtBaslangicZamani.Text = oturum.BaslangicZamani.ToString();
                    txtKullanilanSüre.Text = oturum.KullanilanSure.ToString();
                    radioSüresiz.Visible = false;
                    radioSüreli.Visible = false;
                    btnMasaAc.Visible = false;
                    comboSüreli.Visible = false;

                }
            }

        }

        
        
        private void Tabs_Click(object sender, EventArgs e)
        {
            panelMasaInfo.Visible = false;
            dataGridViewSatisDoldur();
            
               
        }

        private void dataGridViewKullaniciDoldur()
        {
            var query = from item in netCafeDB.TableKullanicilar
                        select new
                        {
                            item.KullaniciAdi,
                            item.Mail,
                            item.KayitTarihi,
                        };
            dataGridViewKullanici.DataSource = query.ToList();

        }
        private void dataGridViewLogDoldur()
        {
            var query = from hareket in netCafeDB.TableHareketler
                        join kullanici in netCafeDB.TableKullanicilar on hareket.KullaniciID equals kullanici.KullaniciID
                        join masa in netCafeDB.TableMasalar on hareket.MasaID equals masa.MasaID
                        select new
                        {
                            MasaAdi = masa.MasaAdi,
                            KullaniciAdi = kullanici.KullaniciAdi,
                            IslemTuru = hareket.IslemTuru,
                            IslemZamani = hareket.IslemZamani,
                        };

            dataGridView1.DataSource = query.ToList();

        }
        private void dataGridViewSatisDoldur()
        {
            var satisListesi = from satis in netCafeDB.TableSatis
                               join kullanici in netCafeDB.TableKullanicilar
                               on satis.KullaniciID equals kullanici.KullaniciID
                               join masa in netCafeDB.TableMasalar
                               on satis.MasaID equals masa.MasaID
                               select new
                               {
                                   SatısID = satis.SatısID,
                                   KullaniciAdi = kullanici.KullaniciAdi,
                                   MasaAdi = masa.MasaAdi,
                                   BaslangicZamani = satis.BaslangicZamani,
                                   BitisZamani = satis.BitisZamani,
                                   AcilisTuru = satis.AcilisTuru,
                                   KullanilanSure = satis.KullanilanSüre,
                                   Ucret = satis.Ucret
                               };
            dataGridViewSatislar.DataSource = satisListesi.ToList();
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            int masaID = Convert.ToInt32(txtMasaID.Text);
            TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaID == masaID);

            if (masa.Durumu == "BOŞ")
            {

                if (radioSecilen != null)
                {
                    TableOturumlar oturum = new TableOturumlar();
                    if (radioSecilen.Text == "Süreli")
                    {
                        oturum.AcilisTuru = comboSüreli.Text;
                    }
                    else if (radioSecilen.Text == "Süresiz")
                    {
                        oturum.AcilisTuru = "Süresiz";
                    }
                    masa.Durumu = "DOLU";
                    masalar[masaID - 1].BackColor = Color.Red;

                    oturum.MasaID = masaID;
                    oturum.BaslangicZamani = DateTime.Now;
                    oturum.KullaniciID = 1;
                    netCafeDB.TableOturumlar.Add(oturum);
                    netCafeDB.SaveChanges();
                    TableHareketler Hareket = new TableHareketler();
                    Hareket.MasaID = masaID;
                    Hareket.IslemTuru = "MASA AÇMA";
                    Hareket.IslemZamani = DateTime.Now;
                    Hareket.KullaniciID = 1;
                    netCafeDB.TableHareketler.Add(Hareket);
                    netCafeDB.SaveChanges();
                    panelMasaInfo.Visible = false;
                    panelMasaDoluInfo.Visible = false;
                    int MasaID = masa.MasaID;
                    TableOturumlar oturum1 = netCafeDB.TableOturumlar.FirstOrDefault(o => o.MasaID == MasaID);
                    string kullaniciAdi = netCafeDB.TableKullanicilar
                              .Where(k => k.KullaniciID == oturum1.KullaniciID)
                              .Select(k => k.KullaniciAdi)
                              .FirstOrDefault();
                    txtMasaDoluID.Text = masa.MasaID.ToString();
                    txtDoluMasaAdı.Text = masa.MasaAdi;
                    txtDoluMasaDurumu.Text = masa.Durumu;
                    txtDoluKAdi.Text = kullaniciAdi;
                    txtBaslangicZamani.Text = oturum1.BaslangicZamani.ToString();
                    txtKullanilanSüre.Text = oturum1.KullanilanSure.ToString();
                    txtKullanilanSüre.Text = "0";
                    radioSüresiz.Visible = false;
                    radioSüreli.Visible = false;
                    btnMasaAc.Visible = false;
                    comboSüreli.Visible = false;
                    dataGridViewLogDoldur();
                    MessageBox.Show(masa.MasaAdi + " Açıldı. ");
                }
                else
                {
                    MessageBox.Show("Butonlardan birini seçiniz!");
                }



            }
            else if (masa.Durumu == "İSTEK")
            {
                if (radioSecilen != null)
                {
                    masa.Durumu = "DOLU";
                    masalar[masaID - 1].BackColor = Color.Red;

                    TableOturumlar oturum = new TableOturumlar();
                    oturum.MasaID = masaID;
                    oturum.BaslangicZamani = DateTime.Now;
                    if (radioSecilen.Text == "Süreli")
                    {
                        oturum.AcilisTuru = comboSüreli.Text;
                    }
                    else if (radioSecilen.Text == "Süresiz")
                    {
                        oturum.AcilisTuru = "Süresiz";
                    }
                    oturum.KullaniciID = masa.KullaniciID;
                    netCafeDB.TableOturumlar.Add(oturum);
                    netCafeDB.SaveChanges();
                    TableHareketler Hareket = new TableHareketler();
                    Hareket.MasaID = masaID;
                    Hareket.IslemTuru = "MASA AÇMA";
                    Hareket.IslemZamani = DateTime.Now;
                    Hareket.KullaniciID = masa.KullaniciID;
                    netCafeDB.TableHareketler.Add(Hareket);
                    netCafeDB.SaveChanges();
                    dataGridViewLogDoldur();
                    MessageBox.Show(masa.MasaAdi + " Açıldı. ");
                }
                else
                {
                    MessageBox.Show("Butonlardan birinini seçiniz!");

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void SecileneGöre(object sender, EventArgs e)
        {
            radioSecilen = sender as RadioButton;

            if (radioSecilen == radioSüreli)
            {
                comboSüreli.Visible = true;
            }
            else
            {
                comboSüreli.Visible = false;
            }
        }
        private void TimerMasalar_Tick(object sender, EventArgs e)
        {

            foreach (var masaButonu in masalar)
            {
                string masaAdi = masaButonu.Text;
                TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaAdi == masaAdi);
                TableOturumlar oturum = netCafeDB.TableOturumlar.FirstOrDefault(o => o.MasaID == masa.MasaID);

                if (masa != null)
                {
                    // Masa durumu kontrolü ve güncelleme işlemleri burada yapılır
                    if (masa.Durumu == "DOLU")
                    {
                        // Masa doluysa, süre güncelleme işlemleri burada yapılır
                        if (oturum != null)
                        {
                            DateTime baslangic = (DateTime)oturum.BaslangicZamani;
                            DateTime şuan = DateTime.Now;
                            TimeSpan gecenSüre = şuan - baslangic;
                            int yeniKullanilanSure = (int)gecenSüre.TotalMinutes;
                            oturum.KullanilanSure = yeniKullanilanSure;
                            netCafeDB.SaveChanges();
                            double baslangicUcreti = 5.0;
                            
                            // Her 12 dakikada 2 TL artış
                            double dakikaBasiUcretArtisi = 2.0;
                            double ekUcret = Math.Ceiling(gecenSüre.TotalMinutes / 12.0) * dakikaBasiUcretArtisi;

                            // Toplam ücreti hesapla
                            double toplamUcret = baslangicUcreti + ekUcret;
                            oturum.Ucret = Convert.ToDecimal(toplamUcret);

                            netCafeDB.SaveChanges();
                            if (oturum.AcilisTuru == "15" && oturum.KullanilanSure >= 15)
                                OturumBitir(masa.MasaID, oturum);
                            else if (oturum.AcilisTuru == "30" && oturum.KullanilanSure >= 30)
                                OturumBitir(masa.MasaID, oturum);
                            else if (oturum.AcilisTuru == "45" && oturum.KullanilanSure >= 45)
                                OturumBitir(masa.MasaID, oturum);
                            else if (oturum.AcilisTuru == "60" && oturum.KullanilanSure >= 60)
                                OturumBitir(masa.MasaID, oturum);
                            else if (oturum.AcilisTuru == "120" && oturum.KullanilanSure >= 120)
                                OturumBitir(masa.MasaID, oturum);
                            else if (oturum.AcilisTuru == "180" && oturum.KullanilanSure >= 180)
                                OturumBitir(masa.MasaID, oturum);
                        }
                    }
                }
            }
        }
        private void OturumBitir(int masaID, TableOturumlar oturum)
        {
            oturum.BitisZamanı = DateTime.Now;

            // Oturumun süresini hesapla
            DateTime baslangicZamani = (DateTime)oturum.BaslangicZamani;
            TimeSpan gecenSure =(TimeSpan)(oturum.BitisZamanı - baslangicZamani);

            // Kullanılan süreyi ve ücreti güncelle
            int kullanilanSure = (int)gecenSure.TotalMinutes;
            double baslangicUcreti = 5.0;
            double dakikaBasiUcretArtisi = 2.0;
            double ekUcret = Math.Ceiling(gecenSure.TotalMinutes / 12.0) * dakikaBasiUcretArtisi;
            double toplamUcret = baslangicUcreti + ekUcret;

            oturum.KullanilanSure = kullanilanSure;
            oturum.Ucret = Convert.ToDecimal(toplamUcret);

            // Diğer işlemleri buraya ekleyebilirsiniz
            // Örneğin: Satış kaydı oluştur, masanın durumunu güncelle, log ekle, vb.

            // Masanın durumunu güncelle
            TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaID == masaID);
            if (masa != null)
            {
                masa.Durumu = "BOŞ";
                masa.KullaniciID = null;
            }

            // Satış kaydı oluştur
            TableSatis yeniSatis = new TableSatis
            {
                KullaniciID = oturum.KullaniciID,
                MasaID = masaID,
                BaslangicZamani = oturum.BaslangicZamani,
                BitisZamani = oturum.BitisZamanı,
                AcilisTuru = oturum.AcilisTuru,
                KullanilanSüre = oturum.KullanilanSure,
                Ucret = oturum.Ucret
            };
            netCafeDB.TableSatis.Add(yeniSatis);

            // Hareket kaydı oluştur
            TableHareketler hareket = new TableHareketler
            {
                KullaniciID = oturum.KullaniciID,
                MasaID = masaID,
                IslemTuru = "MASA KAPATMA",
                IslemZamani = DateTime.Now
            };
            netCafeDB.TableHareketler.Add(hareket);
            dataGridViewLogDoldur();
            // Oturumu kapat
            oturum.KullaniciID = null;
            oturum.MasaID = null;
            oturum.BaslangicZamani = null;
            oturum.BitisZamanı = null;
            oturum.AcilisTuru = null;
            oturum.KullanilanSure = null;
            oturum.Ucret = null;

            // Değişiklikleri kaydet
            netCafeDB.SaveChanges();

            // Masanın arayüzünü güncelle
            masalar[masaID - 1].BackColor = Color.LightGreen;
            panelMasaDoluInfo.Visible = false;
            panelMasaInfo.Visible= false;
            MessageBox.Show(masa.MasaAdi+"' süresi Doldu , Oturum başarıyla sonlandırıldı.");

            // Veritabanındaki diğer tabloyu güncelleme, loglama, bildirim gönderme gibi işlemleri bu metoda ekleyebilirsiniz.
        }
        private void btnDoluMasaKapat_Click(object sender, EventArgs e)
        {
            int masaID = Convert.ToInt32(txtMasaDoluID.Text);
            TableOturumlar oturum = netCafeDB.TableOturumlar.FirstOrDefault(o => o.MasaID == masaID && o.BitisZamanı == null);
            oturum.BitisZamanı = DateTime.Now;
            if (oturum != null)
            {
                TableSatis yeniSepet = new TableSatis();
                yeniSepet.KullaniciID = oturum.KullaniciID;
                yeniSepet.MasaID = masaID;
                yeniSepet.BaslangicZamani = oturum.BaslangicZamani;
                yeniSepet.BitisZamani = DateTime.Now;
                yeniSepet.AcilisTuru = oturum.AcilisTuru;
                yeniSepet.KullanilanSüre = oturum.KullanilanSure;
                yeniSepet.Ucret = oturum
                    .Ucret;
                // TableSepet tablosuna yeni kaydı ekle
                netCafeDB.TableSatis.Add(yeniSepet);
                // Değişiklikleri kaydet
                netCafeDB.SaveChanges();


                // TableHareketler tablosuna ilgili hareketi ekle
                TableHareketler hareket = new TableHareketler();
                hareket.KullaniciID = oturum.KullaniciID;
                hareket.MasaID = masaID;
                hareket.IslemTuru = "MASA KAPATMA";
                hareket.IslemZamani = DateTime.Now;
                netCafeDB.TableHareketler.Add(hareket);

                oturum.KullaniciID = null;
                oturum.MasaID = null;
                oturum.BaslangicZamani = null;
                oturum.BitisZamanı = null;
                oturum.AcilisTuru = null;
                oturum.KullanilanSure = null;
                oturum.Ucret = null;
                // TableMasalar tablosundaki ilgili masanın durumunu "BOŞ" olarak güncelle
                TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaID == masaID);
                if (masa != null)
                {
                    masa.Durumu = "BOŞ";
                    masa.KullaniciID = null;
                    masalar[masaID - 1].BackColor = Color.LightGreen;
                    panelMasaDoluInfo.Visible = false;
                    panelMasaInfo.Visible = false;
                }
                netCafeDB.SaveChanges();
                MessageBox.Show(masa.MasaAdi + " Başarılı bir şekilde kapatıldı.");
            }
            dataGridViewLogDoldur();
        }
    }
}

