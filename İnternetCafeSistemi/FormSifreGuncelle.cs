using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafeSistemi
{
    public partial class FormSifreGuncelle : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        string mail = FormMail.to;
        public FormSifreGuncelle()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            var user = netCafeDB.TableKullanicilar.FirstOrDefault(u => u.Mail== mail);

            if (user != null)
            {
                user.Sifre = confirmpass.Text;
                netCafeDB.SaveChanges();
                MessageBox.Show("Şifre güncellendi");

                // FormGirisEkrani form1 = new FormGirisEkrani(); // Eğer form1'e yeni bir instance oluşturmak yerine, var olanı kullanmak istiyorsanız:
                // form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormKullaniciGirisi formKullaniciGirisi = new FormKullaniciGirisi();
            formKullaniciGirisi.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
