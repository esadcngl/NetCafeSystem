using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafeSistemi
{
    public partial class FormMail : Form
    {
        string dogrulamaKodu;
        public static string to;
        public FormMail()
        {
            InitializeComponent();
        }

        private void btnGönder_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            dogrulamaKodu = (rand.Next(100000, 1000000)).ToString();
            MailMessage message = new MailMessage();
            to = (txtBoxEposta).Text.ToString();
            from = "yorumcu2015@gmail.com";
            pass = "pryqmyvsabmcizvr";
            messageBody = "Şifreyi yenilemek için doğrulama kodunuz: " + dogrulamaKodu;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Şifremi Unuttum doğrulama Kodu";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Kod Başarılı şekilde gönderildi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            label2.Visible = true;
            txtBoxDogrulama.Visible = true;
            btnDogrula.Visible = true;
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            if (dogrulamaKodu == (txtBoxDogrulama.Text).ToString())
            {
                to = txtBoxEposta.Text;
                //FormSifreGüncelle formSifre = new FormSifreGüncelle();
                this.Close();
                //formSifre.Show();

            }
            else
            {
                MessageBox.Show("Yanlış kod girdiniz.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormKullaniciGirisi formKullaniciGirisi = new FormKullaniciGirisi();
            formKullaniciGirisi.Show();
            this.Close();
        }
    }
}
