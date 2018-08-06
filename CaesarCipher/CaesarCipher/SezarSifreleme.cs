using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class SezarSifreleme : Form
    {
        // Program açıldığında ilk burası çalışıyor
        public SezarSifreleme()
        {
            InitializeComponent();

            // Program açıldığında hızlıca yazmaya başlamak için en üstteki textbox'ı seçiyorum
            txtAnahtarSayi.Select();
        }

        // "Onayla" butonuna basılınca program çalışıyor
        private void buton1_Click(object sender, EventArgs e)
        {
            // Eğer textbox'lar boş değilse program başlıyor
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                // Anahtar sayı olarak byte girilmediğinde program hata vereceği için, programın geri kalanını try içine yazdım
                try
                {
                    // Yazdığım sınıftan bir nesne oluşturuyorum. Eğer anahtar sayı byte'a çevrilirken hata verirse program catch'e atlıyor
                    Caesar sifre_caesar = new Caesar(byte.Parse(txtAnahtarSayi.Text), txtYaziSifre.Text);

                    // Nesnenin "Sifrele" metodunu kullanarak yazıyı şifreliyorum ve textbox'a yazdırıyorum.
                    txtSifrelenenYazi.Text = sifre_caesar.Sifrele();
                }

                // Eğer girilen değer byte değilse ekrana uyarı mesajı yazdırıyorum
                catch
                {
                    MessageBox.Show("Lütfen anahtar sayıya 0 ile 255 arasında bir değer giriniz.");
                }
            }

            // Eğer kutular boşsa ekrana uyarı mesajı yazdırıyorum
            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        // "Temizle" butonuna basılınca tüm textbox'ların içini temizliyorum
        private void buton2_Click(object sender, EventArgs e)
        {
            txtAnahtarSayi.Clear();
            txtYaziSifre.Clear();
            txtSifrelenenYazi.Clear();
        }

        // Menüde "Şifre Çöz"e tıklanırsa, bu formu gizleyip 2. formu (Şifre Çöz) gösteriyorum
        private void şifreÇözToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SezarSifreCozucu form2 = new SezarSifreCozucu();
            this.Visible = false;
            form2.Show();
        }

        // "Programdan Çık" yazısına tıklanınca program kapanıyor
        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}