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
    public partial class FormBaslangic : Form
    {
        public FormBaslangic()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            FormAdminGirisi adminGirisi = new FormAdminGirisi();
            adminGirisi.Show();
            this.Hide();

        }

        private void btnKullanıcıGiris_Click(object sender, EventArgs e)
        {
            FormKullaniciGirisi kullaniciGirisi = new FormKullaniciGirisi();
            kullaniciGirisi.Show();
            this.Hide();
        }
    }
}
