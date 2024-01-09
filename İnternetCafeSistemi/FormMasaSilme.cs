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
    public partial class FormMasaSilme : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        public FormMasaSilme()
        {
            
            InitializeComponent();

            var masalar = netCafeDB.TableMasalar.ToList();

            // ComboBox'a masaları ekleyin
            comboMasalar.DataSource = masalar;
            comboMasalar.DisplayMember = "MasaAdi";
            comboMasalar.ValueMember = "MasaID";

        }

        private void btnMasaSil_Click(object sender, EventArgs e)
        {// ComboBox'tan seçili masayı al
            TableMasalar selectedMasa = (TableMasalar)comboMasalar.SelectedItem;

            if (selectedMasa != null)
            {
                // Seçili masanın durumunu kontrol et
                if (selectedMasa.Durumu == "BOŞ")
                {
                    // Seçili masayı veritabanından sil
                    netCafeDB.TableMasalar.Remove(selectedMasa);
                    netCafeDB.SaveChanges();

                    // İşlem başarılı ise kullanıcıya bilgi ver
                    MessageBox.Show($"{selectedMasa.MasaAdi} adlı masa başarıyla silindi.");

                    // ComboBox'ı güncelle
                    var masalar = netCafeDB.TableMasalar.ToList();
                    comboMasalar.DataSource = masalar;
                }
                else
                {
                    MessageBox.Show("Sadece BOŞ masaları silebilirsiniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir masa seçin.");
            }
        }
    }
}
