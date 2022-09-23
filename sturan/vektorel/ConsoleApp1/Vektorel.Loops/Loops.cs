using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {

            #region örnek1
            // ekrandan girilen ifadenin karakterlerini alt alta yazdıralım

            /*
            string str = "hayat ece tohma";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region for örnek2
            // Ekrandan girilen ve küçük harflerden oluşan kelimeyi büyük harfe ascii mantığını kullanarak dönüştüren program
            /* todo
            string ifade = "vektorel";

            string buyukHali = "";

            for (int i = 0; i < ifade.Length; i++)
            {
                buyukHali += Convert.ToChar(Convert.ToInt32(ifade[i]) - 32);
            }

            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[0])-32); //-32 dememizin sebebi char tablosundaki karşılıkları arasındaki farktan ibaret
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[1])-32);
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[2])-32);
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[3])-32);
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[4])-32);
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[5])-32);
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[6])-32);
            //buyukHali += Convert.ToChar(Convert.ToInt32(ifade[7])-32);

            Console.WriteLine(buyukHali);
            */
            #endregion

            #region for örnek3
            /* Ekrandan TC Kimlik nu isteyin. Bu bilgi;
             * 1. 11 haneli olmalı
             * 2. ilk hanesi 0 olmamalı
             * 3. ilk 10 hanesinin toplamının birler basamağı son hanedeki rakama eşit olmalıdır
             * */

            /*
            Console.Write("TC Kimlik numaranızı giriniz: ");

            string tcKimlik = Console.ReadLine();
            

            if (tcKimlik.Length == 11)
            {
                if (tcKimlik[0] != '0') //ilk hane 0 olmamalı
                {
                    int toplam = 0;
                    for (int i = 0; i < tcKimlik.Length-1; i++)
                    {
                        toplam += Convert.ToInt32(tcKimlik[i].ToString());
                    }

                    if (toplam.ToString()[1] == tcKimlik[tcKimlik.Length-1])
                    {
                        Console.WriteLine("Geçerli");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz");
                    }

                }
                else
                {
                    Console.WriteLine("İlk hane 0 olamaz");
                }
            }
            else
            {
                Console.WriteLine("TC Kimlik Nu 11 haneli olmalıdır");
            }
            */

            // veya
            /* todo
            Write("Tc Kimlik Noyu Giriniz:");
            string tcNo = Console.ReadLine();
            int toplam = 0; int toplam2 = 0; int toplam3 = 0;
            if (tcNo.Length == 11)
            {
                if (Convert.ToInt32(tcNo[0].ToString()) != 0) //tc kimlik numaranın ilk hanesi 0 değilse
                {
                    for (int i = 0; i < 10; i++)
                    {
                        toplam = toplam + Convert.ToInt32(tcNo[i].ToString());
                        if (i % 2 == 0)
                        {
                            if (i != 10)
                            {
                                toplam2 = toplam2 + Convert.ToInt32(tcNo[i].ToString()); // 7 ile çarpılacak sayıları topluyoruz
                            }

                        }
                        else
                        {
                            if (i != 9)
                            {
                                toplam3 = toplam3 + Convert.ToInt32(tcNo[i].ToString());
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tc Kimlik Numaranızın ilk hanesi 0 olamaz.");
                }
            }
            else
            {
                Console.WriteLine("Tc Kimlik Numarınız 11 haneli olmak zorunda.Eksik ya da fazla değer girdiniz.");
            }
            if (((toplam2 * 7) - toplam3) % 10 == Convert.ToInt32(tcNo[9].ToString()); toplam % 10 == Convert.ToInt32(tcNo[10].ToString()))
            {
                Console.WriteLine("Tc Kimlik Numarası Doğru.");
            }
            else
            {
                Console.WriteLine("Tc Kimlik Numarası Yanlış!");
            }
            */
            #endregion

            #region for örnek4
            //ekrana girilen cümlenin ilk harifini büyük ve sonucu ekrana yazdırın
            /*
            Console.WriteLine("Lütfen bir cümle giriniz: ");

            string cumle = Console.ReadLine();

            // cumle.ToUpper().Substring(5).Trim().Replace('a', 'b').IndexOf('a')

            cumle = cumle.Trim();
            cumle = cumle.ToLower();
            */

            //Console.Write("Cümle Giriniz: ");
            //string cumle = Console.ReadLine();
            //string ilkHarfBuyuk = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cumle);
            //string[] dizi = cumle.Split(' ');
            //for (int i = 0; i < dizi.Length; i++)
            //    dizi[i] = dizi[i][0].ToString().ToUpper() + dizi[i].Substring(1);
            //string ilkHarfBuyuk2 = string.Join(" ", dizi);
            //Console.WriteLine("Hazır Fonksiyon Kullanarak Yaptığımız Büyütme İşlemi Sonucu: " + ilkHarfBuyuk);
            //Console.WriteLine("Kendi Yazdığımız Fonksiyonun Sonucu: " + ilkHarfBuyuk2);
            #endregion

            #region örnek5
            // Ekrandan girilen ifadeyi aşağıdaki kurallara göre şifreleyen ve ekranda gösteren programı yazınız
            // Örneğin ekrandan "tuğçe" girilsin// tuğçe--> tugce. örnek: ali
            // Not: Girilen ifade içerisinde Türkçe karakter olmamalı
            // İfadeyi oluşturan her karakter için ascii kodu bulunur
            // a: 97 l: 108 i: 105
            // Bulunan ascii kodların başına yeteri kadar 0 eklenerek 4 haneli hale getirilir. Bu 4 haneli kodlar yanyana getirilir.
            // 009701080105
            // yanyana getirilen bu ascii kodlar içerisinden tek seferde 1 karakter baştan 1karakter sondan alınıp birleştirilerek şifre elde edilir
            // 050091700810

            /* TODO: 
            Console.WriteLine("Şifrelenecek kelimeyi giriniz: ");
            string kelime = Console.ReadLine();

            kelime.Replace("ç", "c").Replace("Ç", "C")
                .Replace("ı", "i").Replace("İ", "I")
                .Replace("ğ", "g").Replace("Ğ", "G")
                .Replace("ö", "o").Replace("Ö", "O")
                .Replace("ü", "u").Replace("Ü", "U")
                .Replace("ş", "s").Replace("Ş", "S");

            string asciilerYanyana = "";
            string sifre="";

            for (int i = 0; i < kelime.Length; i++)
            {
                string asciiKodu = Convert.ToInt32(kelime[i]).ToString();

                if (asciiKodu.Length == 2)
                {
                    asciiKodu = asciiKodu.Insert(0, "00");
                }
                else
                {
                    asciiKodu = asciiKodu.Insert(0, "0");
                }
                asciilerYanyana += asciiKodu;
            }

            // 009701080105

            for (int i = 0; i < asciilerYanyana.Length / 2; i++)
            {
                sifre += asciilerYanyana[i];
                sifre += asciilerYanyana[asciilerYanyana.Length - 1 - i];
            }
            Console.WriteLine(sifre);
            */
            #endregion

            #region WHILE
            // while scopu içerisine sonucu bool olacak ifade yazılır. sonuç true ise scope a girilir false ise girilmez. 
            // Not: for ile yapılan while ile, while ile yapılan her şey de for ile bir şekilde yapılabilir. Ancak genelde döngünün kaçtur atacağı belli ise for, belli değil ise while tercih edilir.


            #region örnek1
            // kullanıcıdan -1 yazana kadarsayı isteyin. sonra bu sayıların toplamını yazdırın.

            //int sayi = 0, toplam = 0;

            //while (sayi != -1)
            //{
            //    Console.WriteLine("Sayı giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    if (sayi != -1)
            //    {
            //        toplam += sayi;
            //    }
            //}
            //Console.WriteLine($"Girilen sayıların toplamı: {toplam}");

            // for ile yapalım

            //for (;sayi!=-1;)
            //{
            //    Console.WriteLine("Sayı giriniz: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    if (sayi != -1)
            //    {
            //        toplam += sayi;
            //    }
            //}
            //Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
            #endregion

            #region örnek2
            // 1000 ile 3000 arasındaki 5 ile bölünebilen sayıların toplamını ve adetini bulan program

            //int toplam = 0, adet = 0, i=1000;

            //for (int i = 1000; i <=3000; i++)
            //{

            //}


            //while (i<=3000)
            //{
            //    if (i%5==0)
            //    {
            //        toplam += i;
            //        adet++;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"sonuç");
            #endregion



            #endregion

            #region DO WHILE
            // while a ait scope içerisine sonucu bool olan ifade yazılır, true ise döngü başa döner, false ise dönmez
            // Not: do-while döngüsünde, döngü içine girilip girilmeyeceği kontrolü en sonda yapıldığından her koşul altında do-while döngüsü EN AZ 1 DEFA MUTLAKA ÇALIŞIR. diğer döngülerin böyle bir garantisi yoktur çünkü kontrol en başta yapılmaktadır.
            // Bu yüzden en az 1 defa mutlaka çalışmasını istediğimiz döngülerde do while kullanılır

            //while (true)
            //{

            //}
            //do
            //{

            //} while (true);
            #endregion

            #region Rasgele Değer Üretmek
            // Rasgele değer üretmek için Random sınıfının nesnesi kullanılır

            //Random rnd = new Random();

            //int randomInt = rnd.Next();
            //int randomInt = rnd.Next(25);
            //int randomInt = rnd.Next(10, 25);
            //Console.WriteLine(randomInt);

            //double randomDouble=rnd.NextDouble();
            //Console.WriteLine(randomDouble);

            #region örnek1

            //Random rnd = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(rnd.Next(10,100);
            //}
            //Console.WriteLine(rnd);
            #endregion

            #region örnek2
            // Aşağıdaki ifadeyi kullanarak rasgele 8 karakterli şifre üreten program yazın

            //string strList = "wfdsajfsadlfhsöadhfksdjahf";
            //string sifre = "";

            //Random rnd = new Random();

            //for (int i = 0; i < 8; i++)
            //{
            //    sifre += strList[rnd.Next(strList.Length)];
            //}
            //Console.WriteLine(sifre);

            #endregion

            #endregion






















            Console.ReadLine();
        }
    }
}
