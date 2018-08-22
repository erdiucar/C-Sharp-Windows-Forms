using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereCipher
{
    class VigenereCipher
    {
        // Kullanıcının yazdığı anahtar metin
        private string anahtar_kelime;
        // Kullanıcının yazdığı anahtar metnin karakter sayısı
        private int anahtar_kelime_length;
        // Kullanıcının yazdığı anahtar metin için sayaç
        private int anahtar_kelime_sayac;
        // Kullanıcının yazdığı yazı
        private string kullanici_yazi;
        // Şifrelenen ya da deşifre edilen yazı
        private string sifre_yazi;

        // Kurucu metod yazdım. Sınıfın nesnesini oluştururken kullanıcıdan anahtar sayı ve şifre-deşifre edilecek yazıyı alıyorum 
        public VigenereCipher(string anahtar_kelime, string sifre_yazi)
        {
            this.anahtar_kelime = anahtar_kelime;
            this.kullanici_yazi = sifre_yazi;
            this.anahtar_kelime_length = anahtar_kelime.Length;
        }

        // ASCII tablosu kullanarak şifreleme yaptığım için, Türkçe karakterleri kontrol etmek adına bool fonksiyon yazıyorum
        private bool TurkceMi(char karakter)
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

        // Anahtar kelimenin İngilizce karakterler dışında karakter içerip içermediğini kontrol eden fonksiyon
        public bool AnahtarKelimeAlfabetikMi()
        {
            bool sonuc = true;

            for (int i = 0, s = anahtar_kelime_length; i < s; i++)
            {
                if (char.IsLetter(anahtar_kelime[i]) && !TurkceMi(anahtar_kelime[i]))
                {
                    continue;
                }
                else
                {
                    sonuc = false;
                    break;
                }
            }

            return sonuc;
        }

        // "Sifrele" metodunu kullanarak yazının şifrelenmiş halini gönderiyorum
        public string Sifrele()
        {
            // Metod her çalıştırıldığında sifre_yazi değişkenini boş hale getiriyorum
            sifre_yazi = "";
            anahtar_kelime_sayac = 0;

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                // Eğer karakterler harf ise ve Türkçe karakter değilse Vigenere şifreleme formülü uygulanıyor
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceMi(kullanici_yazi[i]))
                {
                    // Vigenere formülü için integer değişken oluşturuyorum
                    int formul;

                    // Karakter büyük harfse formül bu şekilde oluyor
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + (char.ToUpper(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 65)) % 26;
                        sifre_yazi += (char)(formul + 65);
                        anahtar_kelime_sayac++;
                    }
                    // Karakter küçük harfse formül bu şekilde oluyor
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + (char.ToLower(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 97)) % 26;
                        sifre_yazi += (char)(formul + 97);
                        anahtar_kelime_sayac++;
                    }
                }
                // Eğer karakterler harf değilse ve Türkçe ise, olduğu gibi sifre_yazi değişkenine aktarılıyor
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            // Şifrelenmiş yazıyı gönderiyorum
            return sifre_yazi;
        }

        // "DesifreEt" metodu kullanarak yazının deşifre edilmiş halini gönderiyorum
        public string DesifreEt()
        {
            // Metod her çalıştırıldığında sifre_yazi değişkenini boş hale getiriyorum
            sifre_yazi = "";
            anahtar_kelime_sayac = 0;

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                // Eğer karakterler harf ise ve Türkçe karakter değilse Vigenere şifreleme formülü uygulanıyor
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceMi(kullanici_yazi[i]))
                {
                    // Vigenere formülü için integer değişken oluşturuyorum
                    int formul;

                    // Karakter büyük harfse formül bu şekilde oluyor
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - (char.ToUpper(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 65)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 65);
                        anahtar_kelime_sayac++;
                    }
                    // Karakter küçük harfse formül bu şekilde oluyor
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - (char.ToLower(anahtar_kelime[anahtar_kelime_sayac % anahtar_kelime_length]) - 97)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 97);
                        anahtar_kelime_sayac++;
                    }
                }
                // Eğer karakterler harf değilse ve Türkçe ise, olduğu gibi sifre_yazi değişkenine aktarılıyor
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            // Deşifre edilmiş yazıyı gönderiyorum
            return sifre_yazi;
        }
    }
}
