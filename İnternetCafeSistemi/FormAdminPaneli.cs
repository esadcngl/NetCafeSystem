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
    public partial class FormAdminPaneli : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        private List<Button> masalar = new List<Button>();
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
                if(dbMasa.Durumu == "BOŞ")
                {
                    masaButonu.BackColor = Color.LightGreen;
                }else if(dbMasa.Durumu == "DOLU")
                {
                    masaButonu.BackColor = Color.Red;
                } else if(dbMasa.Durumu == "İSTEK")
                {
                    masaButonu.BackColor= Color.Orange;
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
               
                //TableOturumlar oturum = netCafeDB.TableOturumlar.FirstOrDefault(o => o.MasaID == masaID);
                // panelMasaInfo'yu güncelle ve görünür yap
                if (masa.Durumu=="İSTEK" || masa.Durumu=="BOŞ")
                {
                    txtMasaID.Text = masa.MasaID.ToString();
                    txtMasaAdı.Text = masa.MasaAdi;
                    txtMasaDurumu.Text = masa.Durumu;
                    labelKullaniciID.Visible = false;
                    txtKullaniciID.Visible = false;
                    txtKullanici.Visible = false;
                    labelKullanici.Visible = false;
                    panelMasaInfo.Visible = true;
                    if (masa.Durumu =="İSTEK")
                    {
                        txtKullaniciID.Text = masa.KullaniciID.ToString();
                        string kullaniciAdi = netCafeDB.TableKullanicilar
                                    .Where(k => k.KullaniciID == masa.KullaniciID)
                                    .Select(k => k.KullaniciAdi)
                                    .FirstOrDefault();
                        txtKullanici.Text = kullaniciAdi;
                        labelKullaniciID.Visible = true;
                        txtKullaniciID.Visible = true;
                        txtKullanici.Visible = true;
                        labelKullanici.Visible = true;
                    }
                }
                else
                {
                    int MasaID = masa.MasaID;
                    TableOturumlar oturum = netCafeDB.TableOturumlar.FirstOrDefault(o => o.MasaID == MasaID);
                    string kullaniciAdi = netCafeDB.TableKullanicilar
                              .Where(k => k.KullaniciID == oturum.KullaniciID)
                              .Select(k => k.KullaniciAdi)
                              .FirstOrDefault();
                    txtMasaID.Text = masa.MasaID.ToString();
                    txtMasaAdı.Text = masa.MasaAdi;
                    txtMasaDurumu.Text = masa.Durumu;
                    txtKullaniciID.Text = oturum.KullaniciID.ToString();
                    txtKullanici.Text = kullaniciAdi;
                    radioSüresiz.Visible = false;
                    radioSüreli.Visible = false;
                    btnMasaAc.Visible = false;
                    comboSüreli.Visible = false;
                    panelMasaInfo.Visible = true;
                }
            }
        }

        private void Tabs_Click(object sender, EventArgs e)
        {
            panelMasaInfo.Visible = false;
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
                            IslemZamani = hareket.IslemZamani
                        };

            dataGridView1.DataSource = query.ToList();
            
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            int masaID = Convert.ToInt32(txtMasaID.Text);
            TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaID == masaID);
            masa.Durumu = "DOLU";
            masalar[masaID - 1].BackColor = Color.Red;

            TableOturumlar oturum = new TableOturumlar();
            oturum.KullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            oturum.MasaID = masaID;
            oturum.BaslangicZamani = DateTime.Now;
            netCafeDB.TableOturumlar.Add(oturum);
            netCafeDB.SaveChanges();
            TableHareketler Hareket = new TableHareketler();
            Hareket.KullaniciID = Convert.ToInt32(txtKullaniciID.Text);
            Hareket.MasaID = masaID;
            Hareket.IslemTuru = "MASA AÇMA";
            Hareket.IslemZamani = DateTime.Now;
            netCafeDB.TableHareketler.Add(Hareket);
            netCafeDB.SaveChanges();
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
    }
}

