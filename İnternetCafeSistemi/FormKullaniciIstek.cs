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
    public partial class FormKullaniciIstek : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        public string kullaniciAdi;
        public int kullaniciID;
        public FormKullaniciIstek()
        {
            InitializeComponent();
            var masalar = netCafeDB.TableMasalar.Where(m => m.Durumu != "DOLU" && m.Durumu != "İSTEK").ToList();

            // ComboBox'a masaları ekleyin
            comboMasalar.DataSource = masalar;
            comboMasalar.DisplayMember = "MasaAdi";
            comboMasalar.ValueMember = "MasaID";
        }

        private void MasaAc(string sure)
        {
            // Kullanıcı adını al
            FormKullaniciGirisi formKullaniciGirisi = new FormKullaniciGirisi();
             kullaniciAdi = formKullaniciGirisi.kullaniciAdi; // Kullanıcı adını buraya yerleştirin veya kullanıcıdan alın

            // Kullanıcı tablosundan kullanıcıyı bul
            TableKullanicilar kullanici = netCafeDB.TableKullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);
            int KullaniciID = kullanici.KullaniciID;
            TableMasalar selectedMasa = (TableMasalar)comboMasalar.SelectedItem;
            if (kullanici != null )
            {
                // Kullanıcının IstekDurum'unu 1 yap
                kullanici.IstekDurum = 1;
                
                // Seçili masa adını al
                string seciliMasaAdi = selectedMasa.MasaAdi; 

                // Masa tablosundan masa ID'sini bul
                TableMasalar masa = netCafeDB.TableMasalar.FirstOrDefault(m => m.MasaAdi == seciliMasaAdi);

                if (masa != null)
                {
                    // Kullanıcının MasaID'sini güncelle
                    kullanici.MasaID = masa.MasaID;

                    // Masanın Durumu'nu "İSTEK" yap
                    masa.Durumu = "İSTEK";

                    // Değişiklikleri veritabanına kaydet
                    netCafeDB.SaveChanges();

                    // TableHareketlere hareket ekle
                    TableHareketler hareket = new TableHareketler
                    {
                         //= kullaniciAdi,
                        MasaID = masa.MasaID,
                        IslemTuru = $"Masa açma isteği yollandı ({sure} dakika)",
                        IslemZamani = DateTime.Now
                    };

                    netCafeDB.TableHareketler.Add(hareket);
                    netCafeDB.SaveChanges();

                    MessageBox.Show("İşlem başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Masa Dolu yada İstek Yollanmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnsüresiz_Click(object sender, EventArgs e)
        {
            MasaAc("Süresiz");
        }
        private void btnSüreli15_Click(object sender, EventArgs e)
        {
            MasaAc("15");
        }

        private void btnSüreli30_Click(object sender, EventArgs e)
        {
            MasaAc("30");
        }

        private void btnSüreli45_Click(object sender, EventArgs e)
        {
            MasaAc("45");
        }

        private void btnSüreli60_Click(object sender, EventArgs e)
        {
            MasaAc("60");
        }

        private void btnSüreli120_Click(object sender, EventArgs e)
        {
            MasaAc("120");
        }

        private void btnSüreli180_Click(object sender, EventArgs e)
        {
            MasaAc("180");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var doluMasalar = netCafeDB.TableMasalar.Where(m => m.Durumu == "DOLU").ToList();
            foreach (var masa in doluMasalar)
            {
                // Kullanıcı adını al
                int KullaniciID =Convert.ToInt32(masa.KullaniciID);

                // TableKullanicilar tablosundan kullanıcıyı bul
                TableKullanicilar kullanici = netCafeDB.TableKullanicilar.FirstOrDefault(k => k.KullaniciID ==KullaniciID);

                if (kullanici != null)
                {
                    // Yeni bir form aç ve kullanıcıyı aktar
                    FormMasaBilgisi yeniForm = new FormMasaBilgisi();
                    yeniForm.Show();
                    this.Close();
                }
            }
        }
    }
}
