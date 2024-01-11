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
    public partial class FormAdminGirisi : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        public FormAdminGirisi()
        {
            InitializeComponent();
         
        }

        private void FormAdminGirisi_Load(object sender, EventArgs e)
        {
           
           
            
                
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
          

            // Kullanıcı adı ve şifreye göre admini bul
            TableAdminler admin = netCafeDB.TableAdminler.FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);

            // Eğer admin bulunduysa, girişi başarılı sayabilirsiniz
            if (admin != null)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdminPaneli formAdminPaneli = new FormAdminPaneli();
                formAdminPaneli.Show();
                this.Hide();
                // Diğer işlemleri yapabilirsiniz (örneğin, yeni bir form açma veya ana formu gösterme)
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormBaslangic formBaslangic = new FormBaslangic();

            formBaslangic.Show();
            this.Close(); // Şuanki formu kapat
        }
    }
}
