using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.StringManupulation
{
    internal class StringManupulation
    {
        static void Main(string[] args)
        {
            #region String
            /*
                string str = "Ece Tohma";

               // string ler 1'den fazla char ın yanyana gelmesiye oluşan kararlardır

               // int değişkeninin index numarası yoktur

               // string i oluşturan herbir karakterin 0 dan başlamak üzere INDEX NUMARASI vardır

               Console.WriteLine(str[2]); //çıktı aslında bize char olarak gelecektir
               */

            /*
            string str = "Ece Tohma";
            int karakterSayisi= str.Length;
            Console.WriteLine(str.Length);
            Console.WriteLine(karakterSayisi);
            Console.WriteLine(str[str.Length - 1]); 
            */
            #endregion

            #region string örnek2 ToUpper ToLower
            /*
            // ekrandan girilen 5 karakterli bir ifadenin büyük harf karşılığını bulun ve ekrana yazdırın

            string ifade = "armut"; // ARMUT

            string buyukHali = "";

            buyukHali += Convert.ToChar(Convert.ToInt32(ifade[0]) - 32);
            buyukHali += Convert.ToChar(Convert.ToInt32(ifade[1]) - 32);
            buyukHali += Convert.ToChar(Convert.ToInt32(ifade[2]) - 32);
            buyukHali += Convert.ToChar(Convert.ToInt32(ifade[3]) - 32);
            buyukHali += Convert.ToChar(Convert.ToInt32(ifade[4]) - 32);

            Console.WriteLine(buyukHali);

            //veya
            ifade = ifade.ToUpper();
            Console.WriteLine(ifade);
            ifade = ifade.ToLower();
            Console.WriteLine(ifade);
            */
            #endregion

            #region trim
            /*
            string str = "                  Ece Tohma              ";
            Console.WriteLine(str.TrimStart());
            Console.WriteLine(str.TrimEnd());
            Console.WriteLine(str.Trim());
            */
            #endregion

            #region SubString
            /*
            // belli aralığı döndürür
            string str = "Ece Tohma";
            string sonuc = string.Substring(2, 8);
            Console.WriteLine(sonuc);
            */

            #endregion

#region StartsWith EndsWith

            // string str = "Ece Tohma";
            /*
            if (str.StartsWith("Ec"))
            {
                Console.WriteLine("Evet Ec ile başlıyor");
            }
            else
            {
                Console.WriteLine("Hayır, giriş hatalı");
            }
            */

            /*
            if (str.EndsWith("hma"))
            {
                Console.WriteLine("Evet hma ile bitiyor");
            }
            else
            {
                Console.WriteLine("Hayır, giriş hatalı");
            }
            */

            #endregion

            #region Replace
            // string str = "Ece Tohma";

            /*
            str = str.Replace('e', 'ü');
            Console.WriteLine(str); //Ecü Tohma
            */

            #endregion

            #region Remove
            //string str = "Ece Tohma";

            //str = str.Remove(2);
            //Console.WriteLine(str); //Ec

            //str = str.Remove(2,5);
            //Console.WriteLine(str); //Ecma

            #endregion

            #region Insert
            //string str = "Ece Tohma";

            //str = str.Insert(4, "Hayat ");

            //Console.WriteLine(str); //Ece Hayat Tohma

            #endregion

            #region Indexof
            // string str = "Ece Hayat Tohma";

            // int idx = str.IndexOf('a'); // eğer karakter yoksa -1 çıktısını verir. ilk gördüğü değeri döndürür
            // int idx = str.IndexOf('a',7); // ile kaçıncı dizinden itibaren aramasını istiyorsak oradan itibaren sayıp varsa dizindeki değerini verir
            // int idx = str.IndexOf('a', 3, 9); // sadece bu aralıkta ilgili karakteri ara

            // Console.WriteLine(idx);

            #endregion

            #region LastIndexOf
            // Indexof un tersini yapar. yani aramayı son karakterden başlatır
            //string str = "Ece Hayat Tohma";
            //int idx = str.LastIndexOf('e');
            //Console.WriteLine(idx);
            #endregion

            #region Contains
            // genelde if ile kullanılır

            #endregion

            // string str = "ece tohma";
            // yukarıdaki ifadenin ilk harfini büyütüp sonucu ekrana yazdırın
            //Console.WriteLine(str[0].ToString().ToUpper());
            //Console.WriteLine(str[str.IndexOf(" ") + 1].ToString().ToUpper());
            //Console.WriteLine(str);

            #region 17.9.22 ödevler

            #region ödev1
            // Girilen iki sayının arasındaki sayıların toplamını bulan programı yazınız

            //Console.Write("sayi1: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("sayi2: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"toplam: {sayi1 + sayi2}");
            #endregion

            #region ödev2
            // 1 ile 1000 Arasındaki Sayıların Ortalamasını bulan programı yazınız.

            //int toplam = 0, sayac = 0, ortalama = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    toplam = toplam + i;
            //    sayac++;
            //}
            //ortalama = toplam / sayac;
            //Console.WriteLine($"sayıların toplamı: {toplam}, ortalaması ise: {ortalama}.");

            // tek sayıların toplamı
            //double toplam = 0;
            //for (int i = 1; i <= 50; i += 2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("Tek sayıların toplamı={0}", toplam);

            //veya
            //double toplam = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 1)
            //        toplam = toplam + i;
            //}
            //Console.WriteLine("Tek sayıların toplamı={0}", toplam);

            //veya
            //double toplam = 0;
            //int i = 1;
            //while (i <= 50)
            //{
            //    if (i % 2 == 1)
            //        toplam = toplam + i;
            //    i++;
            //}
            //Console.WriteLine("Tek sayıların toplamı={0}", toplam);

            #endregion

            #region ödev3
            //Tabanı ve kuvveti girilen işlemin sonucunu hesaplayıp ekranda gösteren programı yazınız.

            //int taban, uslusayi, sonuc = 1;
            //Console.Write("Taban sayısı : ");
            //taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Kuvveti : ");
            //uslusayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= uslusayi; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine("{0} üssü {1} olan sayının sonucu = {2}", taban, uslusayi, sonuc);
            #endregion

            #region ödev4
            // Yeni kiraladığımız bir evin kirasının 1000 TL olduğunu varsayalım. Ve her yıl kirayı %5 arttıracağımızı düşünelim. Önümüzdeki klavyeden girilen kadar yıl içinde vereceğimiz kira miktarının ne olacağını hesaplayan programı yazınız.

            //Console.Write("Yıl bilgisi girin:");
            //int yil = Convert.ToInt32(Console.ReadLine());
            //double kiraMiktari = 1000;
            //Console.WriteLine($"ilk yılki kira miktarı: {kiraMiktari} TL'dir ");
            //for (int i = 1; i <= yil; i++)
            //{
            //    kiraMiktari = kiraMiktari+ kiraMiktari * 0.05;
            //    Console.Write($"{i} yıl için ödenecek kira miktarı: {kiraMiktari} TL'dir\n");                     
            //}

            #endregion

            #region ödev5
            // 4. sorudaki sonu 0 olan yıllarda kira artışının olmayacağı durumuna göre yeniden yazınız.
            //Console.Write("Yıl bilgisi girin:");
            //int yil = Convert.ToInt32(Console.ReadLine());
            //double kiraMiktari = 1000;

            //if (yil%10==0)
            //{
            //    Console.WriteLine("Kira 1000TL olup artış yapılmamıştır");
            //}
            //else
            //{
            //    for (int i = 1; i <= yil; i++)
            //    {
            //        Console.WriteLine($"ilk yılki kira miktarı: {kiraMiktari} TL'dir ");
            //        kiraMiktari = kiraMiktari + kiraMiktari * 0.05;
            //        Console.Write($"{i} yıl için ödenecek kira miktarı: {kiraMiktari} TL'dir\n");
            //    }
            //}

            #endregion

            #region ödev6
            // TODO
            //Tersi ile 4 çarpıldığında kendisine eşit olan 4 basamaklı sayılar hangileridir? bulan programı yazınız.

            //Console.Write("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int rakam;
            //Console.Write("Sayinin tersten yazılısı = ");
            //for (int i = 0; i <= sayi; i++)
            //{
            //    rakam = sayi % 10;
            //    Console.Write(rakam*2);
            //    sayi /= 10;
            //}
            //while (sayi > 0)
            //{
            //    rakam = sayi % 10;
            //    Console.Write(rakam);
            //    sayi /= 10;
            //}

            // mükemmel sayı
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for (int i = 1; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        toplam = toplam + i;
            //    }
            //}
            //if (toplam == sayi)
            //{
            //    Console.WriteLine($"{sayi} sayı Mükemmel Sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi} sayı Mükemmel Sayı Değildir");
            //}

            #endregion

            #region ödev7
            // TODO
            //Girilen bir cümleyi kelimelerine ayırarak ekranda alt alta gösteren programı yazınız.

            /*
            string cumle;
            string[] s;
            Console.WriteLine("Cümle giriniz: ");
            cumle = Console.ReadLine();
            s=cumle.Split(' ');

            for (int i = 0; i<cumle.Length; i++)
            {
                Console.WriteLine(i);
            }
            */

            #endregion


            //Girilen bir TC Kimlik numarasının geçerli olup olmadığını kontrol eden programı yazınız
            //TC Kimlik No 11 basamaklı olmalıdır.
            //İlk hanesi 0 olmamalıdır.
            //Bütün karakterler rakam olmalıdır.
            //İlk 10 rakamının toplamının birler basamağı 11.Hanedeki rakama eşit olmalıdır.
            //1. 3. 5. 7.ve 9.hanelerin toplamının 7 katından, 2. 4. 6.ve 8.hanelerin toplamı çıkartıldığında, elde edilen sonucun 10'a bolumunden kalan, yani Mod10'u bize 10.haneyi verir.
            //1. 2. 3. 4. 5. 6. 7. 8. 9.ve 10.hanelerin toplamından elde edilen sonucun 10′a bölümünden kalan, yani Mod10′u bize 11.haneyi verir.

            Console.Write("TC Kimlik nu giriniz: ");
            string tcKimlik= Console.ReadLine();

            if (tcKimlik.Length==11)
	{
                if (tcKimlik[0] != '0')
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





            #endregion




            Console.ReadLine();

        }
    }
}
