﻿using System;
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
    public partial class FormKullaniciGirisi : Form
    {
        NetCafeSystemEntities netCafeDB = new NetCafeSystemEntities();
        public string kullaniciAdi;
        public string sifre;
        public FormKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAdi.Text.Trim();
             sifre = txtSifre.Text.Trim();

            // Kullanıcı adı ve şifreyi kontrol etmek için LINQ sorgusu
            TableKullanicilar kullanici = netCafeDB.TableKullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifre );

            if (kullanici != null)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormKullaniciIstek formKullaniciIstek = new FormKullaniciIstek();
                formKullaniciIstek.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
