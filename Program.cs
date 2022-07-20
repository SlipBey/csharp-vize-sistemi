using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();

            Random rastgele = new Random();
            int rastgeleturev = rastgele.Next(1000, 8000);


            Console.WriteLine("Merhabalar turtex vize işlemleri LTD. ŞTİ. Hoşgeldiniz ");
            Console.WriteLine("Burada yazdığınız kişisel bilgiler, KVKK kanunlarına uygun bir şekilde saklanmaktadır.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("İsminizi Alabilir Miyim?");
            kisi.Ad = (Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Soyisminizi Alabilir Miyim?");
            kisi.Soyad = (Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Yaşınızı Alabilir Miyim? (Sayı Cinsinden)");
            kisi.Yas = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Bildiğiniz dilleri alabilir miyim?");
            kisi.Diller = (Convert.ToString(Console.ReadLine())).Split(',').ToList();
            
            Console.WriteLine("Mesleğinizi Alabilir Miyim?");
            kisi.Meslek = (Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Gelirinizi Öğrenebilir Miyim?");
            kisi.Butce = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Bilgileriniz alınmıştır, vizenizin durumu en fazla 1 dakika içinde belli olacaktır.");
            System.Threading.Thread.Sleep(rastgeleturev);

            if (kisi.Butce < 2000)
            {
                Console.WriteLine("Vize başvurunuz reddedilmiştir.");
            }
            else
            {
                Console.WriteLine("Vize başvurunuz alınmıştır.");
                System.Threading.Thread.Sleep(rastgeleturev);
                Console.WriteLine("Vize başvurunuz onaylanmıştır.");
                Console.WriteLine("-isiminiz : {0}", kisi.Ad);
                Console.WriteLine("-Soy isiminiz : {0}", kisi.Soyad);
                Console.WriteLine("-Yaşınız : {0}", kisi.Yas);
                Console.Write("-Bildiğiniz Diller : ");
                foreach (string dil in kisi.Diller)
                {
                    string metin = (dil + " ");
                    Console.Write(metin);
                }
                Console.WriteLine("\n-Mesleğiniz : {0}", kisi.Meslek);
                Console.WriteLine("-geliriniz : {0}", kisi.Butce);
                System.Threading.Thread.Sleep(6000);
                Console.Clear();
                Console.WriteLine("Firmamıza giderek size verilen kodu vererek pasaportlarınızı alabilirsiniz.");
                string kods = "";

                for (int i = 0; i < 7; i++)
                {
                    int kod = rastgele.Next(65, 91);
                    char karakter = Convert.ToChar(kod);
                    kods += karakter;
                }

                Console.WriteLine(kods);

                Console.WriteLine("Lütfen sistemden aldığınız kodu giriniz.");

                string dogrulama = (Convert.ToString(Console.ReadLine()));

                if(dogrulama == kods)
                {
                    Console.WriteLine("Doğrulama başarılıdır.");
                }
                else
                {
                    Console.WriteLine("Doğrulama hatalıdır.");
                }
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadKey();

            }
        }
    }
}
