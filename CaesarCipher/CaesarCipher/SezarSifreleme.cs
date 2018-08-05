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
        // Kullanıcı tarafından yazılan anahtar sayı ve şifrelenecek yazı için değişken oluşturuyorum
        private byte anahtar_sayi;
        private string sifrelenecek_yazi;

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
            // ASCII tablosu kullanarak şifreleme yaptığım için Türkçe karakterleri kontrol etmek adına bool fonksiyon yazıyorum
            bool TurkceMi(char karakter)
            {
                if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Yazdırılacak sonuç için string değişken oluşturuyorum
            string sifrelenen_yazi = "";

            // Eğer textbox'lar boş değilse program başlıyor
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                // anahtar_sayi değişkenine sayı yerine harf girilirse program hata vereceği için programın geri kalanını try içine yazdım
                try
                {
                    // Kullanıcıdan verileri alarak değişkenlere atıyorum. Eğer anahtar_sayi byte'a çevrilirken hata verirse program catch'e atlıyor
                    anahtar_sayi = byte.Parse(txtAnahtarSayi.Text);
                    sifrelenecek_yazi = txtYaziSifre.Text;

                    // sifrelenecek_yazi string olduğu için içindeki bütün harfleri tek tek for döngüsüyle kontrol ediyorum
                    for (int i = 0, s = sifrelenecek_yazi.Length; i < s; i++)
                    {
                        // Eğer karakterler harf ise ve Türkçe karakter değilse Sezar şifreleme formülü uygulanıyor
                        if (char.IsLetter(sifrelenecek_yazi[i]) && !TurkceMi(sifrelenecek_yazi[i]))
                        {
                            // Sezar formülü için integer değişken oluşturuyorum
                            int formul;

                            // Karakter büyük harfse formül bu şekilde oluyor
                            if (char.IsUpper(sifrelenecek_yazi[i]))
                            {
                                formul = ((sifrelenecek_yazi[i] - 65) + anahtar_sayi) % 26;
                                sifrelenen_yazi += (char)(formul + 65);
                            }
                            // Karakter küçük harfse formül bu şekilde oluyor
                            else if (char.IsLower(sifrelenecek_yazi[i]))
                            {
                                formul = ((sifrelenecek_yazi[i] - 97) + anahtar_sayi) % 26;
                                sifrelenen_yazi += (char) (formul + 97);
                            }
                        }
                        // Eğer karakterler harf değilse ve Türkçe ise, olduğu gibi sifrelenen_yazi değişkenine aktarılıyor
                        else
                        {
                            sifrelenen_yazi += sifrelenecek_yazi[i];
                        }
                    }

                    // Şifreleme gerçekleşti ve bunu ekranda textbox'a yazdırıyorum
                    txtSifrelenenYazi.Text = sifrelenen_yazi;
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
