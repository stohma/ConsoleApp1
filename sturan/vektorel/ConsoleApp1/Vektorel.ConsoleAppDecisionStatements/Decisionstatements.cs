using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ConsoleAppDecisionStatements
{
    internal class Decisionstatements
    {
        private static string aramaSaati;

        static void Main(string[] args)
        {
            #region karar yapıları (if/switch)
            /*karar yapıları bool türdedir. yani sonucu true ya da false olabilir.
             * if e ait scope true ise çalıştırılır, false ise scope'u geçip yoluna devam eder
             * bu durumda else scope U oluşturulur ve bu koşul if olmazsa else deki duurmu dikkate al deriz
             */

            /*Kullanıcıdan boy ve kilo isteyerek normal veya zayıf olduğunu tespit ediniz
             
             */
            /*
            Console.WriteLine("Boy Giriniz: "); ;
            double boy = double.Parse(Console.ReadLine());

            Console.WriteLine("Kilo Giriniz: "); ;
            double kilo = double.Parse(Console.ReadLine());

            double kitleEndex =kilo/(boy*boy);

            if (kitleEndex<18)
            {
                Console.WriteLine("Zayıfsınız");
            }
            else
            {
                Console.WriteLine("normalsiniz");
            }
            */


            #endregion

            #region örnek1
            // kullanıcıdan sayı alıp 10'a eşit olup olmadığını sorgulayın
            /*Console.Write("sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi != 10)
	{
                Console.WriteLine("sayı yanlış");
	}
            else
	{
             Console.WriteLine("sayı doğru");
	}

            */
            #endregion

            // kullanıcıdan 2 ürün fiyatı girildiğinde toplam fiyat 200tl'den fazla ise 2. üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı gösterin

            /*
            Console.Write("1.ürün fiyat: ");
            double fiyat1= double.Parse(Console.ReadLine());    
            Console.Write("2.ürün fiyat: ");
            double fiyat2= double.Parse(Console.ReadLine());    

            if (fiyat1>0 && fiyat2>0)
	{
                double toplamTutar=fiyat1+fiyat2;
                 if (fiyat1+fiyat2 >200)
	{
                Console.WriteLine($"ödenecek tutar: {fiyat1+(fiyat2*0.75)}");
	}
            else
	{
             Console.WriteLine($"ödenecek tutar: {toplamTutar}");
	}
	}
            */



            /*3. Beden Kitle İndeksi hesaplamasını c# komutları yazarak hesaplayalım.
   Beden Kitle Endeksi = Kilo / boy*boy
   Beden kitle endeksi 18'e eşit veya düşükse ZAYIF
                       18 ile 25 arası NORMAL
                       25 ile 30 arası FAZLA KİLOLU
                       30 ile 45 arası ŞİŞMAN
                       45 üzeri OBEZ
            */

            /*
            Console.Write("Boy giriniz: ");
            double boy = double.Parse(Console.ReadLine());
            Console.Write("Kilo giriniz: ");
            double kilo = double.Parse(Console.ReadLine());
            double kitleEndex = kilo / (boy * boy);

            if (true)
            {

            }
            */

            #region örnek4
            /*
            4. / Bir otoparkta ücret tarifesi şöyledir;
            0 - 3 saat = 4 tl
           3 - 7 saat = 3 tl
           7 - 12 saat = 2 tl
           12 saat ve üzeri = 1 tl
           Buna göre girilen saate göre otoparka ödenecek
ücreti hesaplayıp ekrana yazan programı oluşturunuz.
            */

            /* todo
            Console.WriteLine("Tarife: ");
            int tarife = int.Parse(Console.ReadLine());

            if (0 <= tarife && tarife <= 3)
            {
                Console.WriteLine($"ödenecek tutar: {tarife*4} TL");
            }
            else if (tarife >= 4 && tarife < 7)
            {
                Console.WriteLine($"ödenecek tutar: {tarife * 3} TL");
            }
            else if (tarife >= 7 && tarife < 12)
            {
                Console.WriteLine($"ödenecek tutar: {tarife * 2} TL");
            }
             else if (tarife >= 12)
            {
                Console.WriteLine($"ödenecek tutar: {tarife} TL");
            }
            */
            #endregion


            #region örnek 7
            /*
             7. Örneğimiz bir şirketteki giriş turnikelerinin simulasyonudur. Kullanıcıdan isim 
    ve şifre isteyeceğiz.Kullanıcı adı ve şifresi doğru ise "tanımlı personel" 
    hatalı giriş yapılıyorsa "tanımsız personel" yazısı almalıyız. 

             Kullanıcı Adı : yazilim
             Şifre         : 1234

              */

            /*
            Console.Write("kullanıcı adı: ");
            string username= Console.ReadLine();

            Console.Write("şifre: ");
            string password= Console.ReadLine();

            if (username=="yazilim" && password=="1234")
	{
                Console.WriteLine("tanımlı personel");
	}
            else
	{
             Console.WriteLine("tanımsız personel");
	}
            */
            #endregion


            #region if 1.örnek
            /* Yapıldı
    1.Bir üniversitede öğrencilerin ortalamaları 50 ve üzerinde ise dersten başarılı sayılmaktadırlar. Öğrencinin vize notu ortalamaya % 40, final notu % 60 etki ettiğine göre öğrencinin ders başarı durumunu hesaplayan programı yazınız.
    */
            /*
            Console.Write("vize: ");
            double vize = double.Parse(Console.ReadLine());

            Console.Write("final: ");
            double final = double.Parse(Console.ReadLine());

            double ort = (vize * 0.4 + final * 0.6);

            if (ort>=50 && ort<=100)
            {
                Console.WriteLine($"{ort} Not ortalaması ile başarılı oldunuz");
            }
            else if (ort>100)
            {
                Console.WriteLine("Hatalı değer girdiniz!!");
            }
            else
            {
                Console.WriteLine($"Not ortalamanız {ort} ile 50 puanın altında kaldığından başarısız oldunuz");
                
            }
            */
            #endregion

            #region if 2.örnek
            /* Yapıldı
            2.Kullanıcıdan girdiği iki sayı ve yapılacak işlem türü(toplama, çıkarma, çarpma, bölme) bilgisi alındıktan sonra gerekli hesaplamayı yapan programı yazınız.
            */

            /*
            Console.Write("sayı1: ");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("sayı2: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Toplama için: + ");
            Console.WriteLine("Çıkarma için: - ");
            Console.WriteLine("Çarpma için: * ");
            Console.WriteLine("Bölme için: / ");
            Console.WriteLine("Seçiminiz: ");


            double sonuc = 0;
            string secim = Console.ReadLine();
            

            if (secim == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (secim == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (secim == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (secim == "/" && sayi2 != 0)
            {

                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sıfıra bölme hatası meydana geldi");

            }
            else
            {
                Console.WriteLine("Hatalı bir işlem tipi seçtiniz.");
            }
           
                Console.WriteLine("İşlem Sonucu: {0} {1} {2} = {3}", sayi1, secim, sayi2, sonuc);
           */
            #endregion

            #region if 3.örnek
            /* Yapıldı
            * 3.Kullanıcının girdiği 3 sayıdan en büyüğünü, en küçüğünü ve ortancasını bulan programı yazınız.

           /*
           Console.Write("1.sayi: ");
           int sayi1 = int.Parse(Console.ReadLine());
           Console.Write("2.sayi: ");
           int sayi2 = int.Parse(Console.ReadLine());
           Console.Write("3.sayi: ");
           int sayi3 = int.Parse(Console.ReadLine());

           if (sayi1 > sayi2 && sayi1 > sayi3 && sayi2 > sayi3)
           {
               Console.WriteLine("1.sayı en büyük, 2.sayı ortanca ve 3.sayı en küçüktür ");
           }
           else if (sayi1 > sayi2 && sayi1 > sayi3 && sayi3 > sayi2)
           {
               Console.WriteLine("1.sayı en büyük, 3.sayı ortanca ve 2.sayı en küçüktür ");
           }
           else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi1 > sayi3)
           {
               Console.WriteLine("2.sayı en büyük, 1.sayı ortanca ve 3.sayı en küçüktür ");
           }
           else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi3 > sayi1)
           {
               Console.WriteLine("2.sayı en büyük, 3.sayı ortanca ve 1.sayı en küçüktür ");
           }

           else if (sayi3 > sayi2 && sayi3 > sayi1 && sayi1 > sayi2)
           {
               Console.WriteLine("3.sayı en büyük, 1.sayı ortanca ve 2.sayı en küçüktür ");
           }
           else if (sayi3 > sayi2 && sayi3 > sayi1 && sayi2 > sayi1)
           {
               Console.WriteLine("3.sayı en büyük, 2.sayı ortanca ve 1.sayı en küçüktür ");
           }
           else
           {
               Console.WriteLine("Hatalı değer girdiniz!!");
           }
           */
            #endregion

            #region if 4.örnek
            /* Yapıldı
                * 4.Eğer girilen 4 sayı sıralı ise(a: 3, b: 5, c: 15, d: 30 gibi); b - a , c - b, d - c nin ortalamasını bulan programı yazınız.*/

            /*
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d: ");
            int d = int.Parse(Console.ReadLine());

            if (a < b && b < c && c < d)
            {
                Console.WriteLine(((b - a) + (c - b) + (d - c)) / 3);
            }
            else
            {
                Console.WriteLine("değerler uygun sıralamada değil");

            }
            */
            #endregion

            #region if 5.örnek
            /* Yapıldı
               5.Kullanıcıya Almanca ya da İngilizce ve ofis programları bilip bilmediğini soran, Almanca ya da İngilizceden birini biliyorsa ve ofis programları biliyorsa “İşe başlayabilirsiniz”, değilse “üzgünüz” mesajı veren programı oluşturunuz.


               Console.WriteLine("Bu dillerden hangisini biliyorsunuz? (Almanca/İngilizce): ");
               string yabanciDil = Console.ReadLine();
               Console.WriteLine("Ofis programlarını biliyor musunuz? E/H> ");
               string ofisProgrami = Console.ReadLine();

               if ((yabanciDil == "Almanca" || yabanciDil == "İngilizce") && ofisProgrami == "Evet")
               {
                   Console.WriteLine("İşe Başlayabilirsiniz");
               }
               else
               {
                   Console.WriteLine("Üzgünüz");
               }
               */

            #endregion

            #region if 6.örnek
            /* 6.Aşağıdaki resimde görülen programı yazınız.
                * 1- Daire
                * 2- Villa
                * 3- Satılık Daire
                * 4- Kiralık Daire
                * 5- Satılık Villa
                * 6- Kiralık Villa
                * 

               Açıklama: Kullanıcıya 2 adet seçenek sunulacak(Daire(1) ve Villa(2)).Örneğin eğer 1 seçerse ekrana Satılık Daire(3), Kiralık Daire(4), 2 seçerse Satılık Villa(5), Kiralık Villa(6) gelecek.Daha sonra örneğin 6 yani Kiralık Villa seçerse bütçesini girmesini isteyecek ve sizin belirlediğiniz bir kiralık villa fiyatına bu bütçe uygunsa ekrana Bu Villayı Kiralayabilirsiniz, değilse Kiralayamazsınız gibi bir mesaj çıkacak. Bu işlem 4 seçenek için uygun şekilde yapılacak
               */

            /*
           Console.WriteLine("Seçenekler");
           // string secim=Console.ReadLine(); 
            Console.WriteLine("1- Daire\n2- Villa\n3- Satılık Daire \n4- Kiralık Daire \n5- Satılık Villa\n6- Kiralık Villa");
            Console.WriteLine("Seçim Yapınız:");
            string secim = Console.ReadLine();
            Console.WriteLine("----------");
            */

            /* string daire=Console.ReadLine();
            Console.WriteLine("2- Villa");
            string villa=Console.ReadLine();
            Console.WriteLine("3- Satılık Daire");
            string satilikDaire=Console.ReadLine();
            Console.WriteLine("4- Kiralık Daire");
            string kiralikDaire=Console.ReadLine();
            Console.WriteLine("5- Satılık Villa");
            string satilikVilla=Console.ReadLine();
            Console.WriteLine("6- Kiralık Villa");
            string kiralikVilla=Console.ReadLine(); 
            */

            /*
            int butceKira =int.Parse(Console.ReadLine());
            
            int butceSatinalma =int.Parse(Console.ReadLine());
            */


            /*
            string secim2= Console.WriteLine();

            if (secim =="daire")
            {
                
                if (secim2=="kiralık")
                {
                    Console.WriteLine("Bütçeniz 7500TL üzeri mi? (E/H)");
                }
                
                if (butceKira>=7500)
                {
                    Console.WriteLine("Kiralayabilirsiniz");
                }
                else
                {
                    Console.WriteLine("Kiralayamazsınız");
                }
               
            }
             if (secim =="daire" && secim=="satılık" && butceKira>=750000)
            {
                Console.WriteLine("Bütçeniz 750000TL üzeri mi?");
                if (butceSatinalma>=750000)
                {
                    Console.WriteLine("Satın alabilirsiniz");
                }
                else
                {
                    Console.WriteLine("Satın alamazsınız!");
                }
               
            }
            */
            #endregion


            /*
            7.Bir cep telefonu firması için, müşterilerinin faturasını hesaplayan ve ekranda gösteren programı yazınız.
             Bu cep telefonu şirketinin iki çeşit servis hizmeti vardır.Standart Hizmet ve Premium Hizmet.Müşterinin faturası kullandığı servis hizmetine göre hesaplanmaktadır.

            Standart Hizmet : 
            İlk 50 dakika beleş, 50 dakikadan sonraki her dakika 0,2 TL. 10 TL sabit ücret.

            Premium Hizmet : 
            25 TL sabit ücret.
             06:00 – 18:00 arası yapılan konuşmalarda ilk 75 dakika beleş, sonraki her dakika 0,1 TL.
            18:00 – 06:00 arası yapılan konuşmalarda ilk 100 dakika beleş, sonraki her dakika 0,05 TL.
            */


            /*
            Console.WriteLine("Alınan hizmet türü==> 1- Standart - 2- Premium ");
            string hizmet = Console.ReadLine();

            if (hizmet == "1")
            {
                Console.WriteLine("arama süresi: ");
                double aramaSuresi = double.Parse(Console.ReadLine());
                if (aramaSuresi <= 50)
                {
                    Console.WriteLine("Ücretsiz kullanım");
                }
                else if (aramaSuresi > 50)
                {
                    Console.WriteLine($"ödenecek tutar: {aramaSuresi * 0.2 + 10} TL");
                }

            }

            if (hizmet == "2")
            {
                Console.Write("Arama saati girin: ");
                int aramaSaati = int.Parse(Console.ReadLine());
                Console.Write("Arama başlangıç saati girin: ");
                TimeSpan baslangicSaati = TimeSpan.Parse(Console.ReadLine());
                Console.Write("Arama bitiş saati girin: ");
                TimeSpan bitisSaati = TimeSpan.Parse(Console.ReadLine());
                TimeSpan totalTime= bitisSaati - baslangicSaati;
                

                //int totalTime = bitisSaati - baslangicSaati;
                // Console.WriteLine($"Arama süresi: {totalTime.TotalMinutes} dakikadır");

                /*
                TimeSpan ts1 = new TimeSpan(06, 00, 00);
                TimeSpan ts2 = new TimeSpan(18, 00, 00);
                var totalTime = ts2 - ts1;
                */
            /*
                if (aramaSaati > 6 && aramaSaati <= 18)
                {
                    Console.WriteLine(totalTime);

                    if (totalTime <= 75)
                    {
                        Console.WriteLine("Ücretsiz kullanım");
                    }
                    else if (totalTime > 75)
                    {
                        Console.WriteLine($"ödeme tutarınız: {totalTime * 0.1 + 25} TL'dir, 25TL sabit ücret dahildir");
                    }
                }
                else
                {
                    if (totalTime <= 100)
                    {
                        Console.WriteLine("Ücretsiz kullanım");
                    }
                    else if (totalTime > 100)
                    {
                        Console.WriteLine($"ödeme tutarınız: {totalTime * 0.05 + 25} TL, 25TL sabit ücret dahildir");
                    }

                }

            }

            */




            #region if 8.örnek
            /* Yapıldı
               8.
                  Kullanıcı Kodu: AA - BB - CC   ADMİN YETKİSİNE SAHİPSİNİZ
                  Kullanıcı Kodu: DD GÜÇLÜ KULLANICI YETKİSİNE SAHİPSİNİZ
                  Kullanıcı Kodu: FF - EE - GG STANDART KULLANICI YETKİSİNE SAHİPSİNİZ
                  FARKLI BİR KULLANICI GİRİŞİ OLURSA "HATALI KULLANICI"
                  Yazmasını yapalım.*/


            /*
            Console.WriteLine("Admin");
            string kullaniciKodu= Console.ReadLine();

            if (kullaniciKodu == "AA - BB - CC") 
            {
                Console.WriteLine("ADMİN YETKİSİNE SAHİPSİNİZ");
            }
            else if (kullaniciKodu == "DD") 
            {
                Console.WriteLine("GÜÇLÜ KULLANICI YETKİSİNE SAHİPSİNİZ");
            }
            else if (kullaniciKodu== "FF - EE - GG")
            {
                Console.WriteLine("STANDART KULLANICI YETKİSİNE SAHİPSİNİZ");
            }
            else
            {
                Console.WriteLine("HATALI KULLANICI");
            }
            */

            #endregion

            #region if 9. örnek
            /* Yapıldı
                9.Not ortalaması sistemine hoş geldiniz
                    Ad Soyad:
                    1.Sınav Notunuz:
                            2.Sınav Notunuz:
                            3.Sınav Notunuz:

                            Kurallar 1.Ortalama 45'den küçük ise ekranda KALDINIZ
                           2.Ortalama değeri 45'e eşit veya 70 değerinden küçük ise ekranda ORTA İLE GEÇTİNİZ
                           3.Ortalama değeri 70 değerine eşit veya 90 değerinden küçük ise İYİ İLE GEÇTİNİZ
                           4.Ortalam değeri 90 ile 100 arasında ise(100 dahil) BAŞARALI TEBRİKLER
                           5.Ortalam değeri 100'den büyük ise GİRİLEN NOT DEĞERLERİNİZİ KONTROL EDİNİZ

                  verilerini makineye yazdıralım.
                            */

            /*
            Console.Write("1. sınav notunuz: ");
            int sinav1 = int.Parse(Console.ReadLine());
            Console.Write("2. sınav notunuz: ");
            int sinav2 = int.Parse(Console.ReadLine());
            Console.Write("3. sınav notunuz: ");
            int sinav3 = int.Parse(Console.ReadLine());

            int ort = (sinav1 + sinav2 + sinav3) / 3;

            if (ort<45)
            {
                Console.WriteLine("Kaldınız");
            }
            else if (ort>=45 && ort<70)
            {
                Console.WriteLine("Orta ile geçtiniz");
            }
            else if (ort>=70 && ort<90)
            {
                Console.WriteLine("İyi ile geçtiniz");
            }
            else if (ort>=90 && ort <=100)
            {
                Console.WriteLine("Başarılı, Tebrikler");
            }
            else
            {
                Console.WriteLine("GİRİLEN NOT DEĞERLERİNİZİ KONTROL EDİNİZ");
            }
            */
            #endregion


            #region switch
            // switch e ait parantezler içerisine, değeri kontrol edilecek olan ifade yazılır. switch scope ları içerisinde, case anahtar kelimesi ile bu ifadeye eşitlik kontrol edilir

            /*
            int sayi = 5;

            switch (sayi)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 5:
                    break;
                default:
                    break;
            }

            Console.WriteLine(sayi);
            */
            
            /*
            string str = "wefefsd";

            switch (str.StartsWith("A"))
            {
             case true:
                    break;
                default:
                    break;
            }
            */

            #endregion














            Console.ReadLine();
        }
    }
}
