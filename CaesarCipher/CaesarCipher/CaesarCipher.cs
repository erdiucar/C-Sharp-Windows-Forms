﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    public class CaesarCipher
    {
        // Kullanıcının yazdığı anahtar sayı
        private byte anahtar_sayi;
        // Kullanıcının yazdığı yazı
        private string kullanici_yazi;
        // Şifrelenen ya da deşifre edilen yazı
        private string sifre_yazi; 

        // Kurucu metod yazdım. Sınıfın nesnesini oluştururken kullanıcıdan anahtar sayı ve şifre-deşifre edilecek yazıyı alıyorum 
        public CaesarCipher(byte anahtar_sayi, string sifre_yazi)
        {
            this.anahtar_sayi = anahtar_sayi;
            this.kullanici_yazi = sifre_yazi;
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

        // "Sifrele" metodunu kullanarak yazının şifrelenmiş halini gönderiyorum
        public string Sifrele()
        {
            // Metod her çalıştırıldığında sifre_yazi değişkenini boş hale getiriyorum
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                // Eğer karakterler harf ise ve Türkçe karakter değilse Sezar şifreleme formülü uygulanıyor
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceMi(kullanici_yazi[i]))
                {
                    // Sezar formülü için integer değişken oluşturuyorum
                    int formul;

                    // Karakter büyük harfse formül bu şekilde oluyor
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + anahtar_sayi) % 26;
                        sifre_yazi += (char)(formul + 65);
                    }
                    // Karakter küçük harfse formül bu şekilde oluyor
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + anahtar_sayi) % 26;
                        sifre_yazi += (char)(formul + 97);
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

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                // Eğer karakterler harf ise ve Türkçe karakter değilse Sezar şifreleme formülü uygulanıyor
                if (char.IsLetter(kullanici_yazi[i]) && !TurkceMi(kullanici_yazi[i]))
                {
                    // Sezar formülü için integer değişken oluşturuyorum
                    int formul;

                    // Karakter büyük harfse formül bu şekilde oluyor
                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 65);
                    }
                    // Karakter küçük harfse formül bu şekilde oluyor
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - anahtar_sayi) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }
                            
                        sifre_yazi += (char)(formul + 97);
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