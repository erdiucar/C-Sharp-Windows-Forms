using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class SezarSifreCozucu : Form
    {
        // Kullanıcı tarafından yazılan anahtar sayı ve deşifre edilecek yazı için değişken oluşturuyorum
        private byte anahtar_sayi;
        private string desifre_edilecek_yazi;

        // Program açıldığında ilk burası çalışıyor
        public SezarSifreCozucu()
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
            string desifre_edilen_yazi = "";

            // Eğer textbox'lar boş değilse program başlıyor
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                // anahtar_sayi değişkenine sayı yerine harf girilirse program hata vereceği için programın geri kalanını try içine yazdım
                try
                {
                    // Kullanıcıdan verileri alarak değişkenlere atıyorum. Eğer anahtar_sayi byte'a çevrilirken hata verirse program catch'e atlıyor
                    anahtar_sayi = byte.Parse(txtAnahtarSayi.Text);
                    desifre_edilecek_yazi = txtYaziSifre.Text;

                    // desifre_edilecek_yazi string olduğu için içindeki bütün harfleri tek tek for döngüsüyle kontrol ediyorum
                    for (int i = 0, s = desifre_edilecek_yazi.Length; i < s; i++)
                    {
                        // Eğer karakterler harf ise ve Türkçe karakter değilse Sezar şifreleme formülü uygulanıyor
                        if (char.IsLetter(desifre_edilecek_yazi[i]) && !TurkceMi(desifre_edilecek_yazi[i]))
                        {
                            // Sezar formülü için integer değişken oluşturuyorum
                            int formul;

                            // Karakter büyük harfse formül bu şekilde oluyor
                            if (char.IsUpper(desifre_edilecek_yazi[i]))
                            {
                                formul = ((desifre_edilecek_yazi[i] - 65) - anahtar_sayi) % 26;
                                if (formul < 0)
                                    formul += 26;

                                desifre_edilen_yazi += (char)(formul + 65);
                            }
                            // Karakter küçük harfse formül bu şekilde oluyor
                            else if (char.IsLower(desifre_edilecek_yazi[i]))
                            {
                                formul = ((desifre_edilecek_yazi[i] - 97) - anahtar_sayi) % 26;
                                if (formul < 0)
                                    formul += 26;

                                desifre_edilen_yazi += (char)(formul + 97);
                            }
                        }
                        // Eğer karakterler harf değilse ve Türkçe ise, olduğu gibi desifre_edilen_yazi değişkenine aktarılıyor
                        else
                        {
                            desifre_edilen_yazi += desifre_edilecek_yazi[i];
                        }
                    }

                    // Deşifre gerçekleşti ve bunu ekranda textbox'a yazdırıyorum
                    txtSifrelenenYazi.Text = desifre_edilen_yazi;
                }

                // Eğer girilen değer byte değilse ekrana uyarı mesajı yazdırıyorum
                catch
                {
                    MessageBox.Show("Lütfen şifrelenecek sayıya 0 ile 255 arasında bir değer giriniz.");
                }
            }

            // Eğer kutular boşsa ekrana uyarı mesajı yazdırıyorum
            else
            {
                MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
            }
        }

        // "Temizle" butonuna basılınca tüm textboxların içini temizliyorum
        private void buton2_Click(object sender, EventArgs e)
        {
            txtAnahtarSayi.Clear();
            txtYaziSifre.Clear();
            txtSifrelenenYazi.Clear();
        }

        // Menüde "Şifrele"ye tıklanırsa, bu formu gizleyip 1. formu (Şifrele) gösteriyorum
        private void şifreleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SezarSifreleme form1 = new SezarSifreleme();
            this.Visible = false;
            form1.Show();
        }

        // "Programdan Çık" yazısına tıklanınca program kapanıyor
        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
