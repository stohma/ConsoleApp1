using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region giriş

            //int a = 20;
            //int b;

            //int c = 20, d = 30;

            //string metin = "Ali",
            //    metin2 = "ece",
            //    metin3 = "hilal";

            //Console.WriteLine(metin);
            //Console.WriteLine(metin2);
            //Console.WriteLine(metin3);
            //(string metin4, int f) z = ("hayat", 9); // sıralama aynı olmalı
            //Console.WriteLine(z);
            //Console.WriteLine(z.f);
            //Console.WriteLine(z.metin4);

            //int a= 10, b= 20, d = 25;
            //Console.WriteLine(a+b+d); 
            #endregion

            #region örnek
            //Console.WriteLine("Yaşınız:");
            //int age = Convert.ToInt32(Console.ReadLine()); //yaş+10
            //Console.WriteLine(age+10);

            //Console.WriteLine("Yaşınız:");
            //string age2 = Console.ReadLine(); //yaş10
            //Console.WriteLine(age2+10); 
            #endregion

            #region ondalıklı toplama

            /*
             * Kullanıcıdan iki adet ondalıklı sayı alınız ve toplayınız             * 
             */

            //Console.WriteLine("sayi1: ");
            //Console.WriteLine("sayi2: ");
            //float sayi1= float.Parse(Console.ReadLine());
            //float sayi2= float.Parse(Console.ReadLine());
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(sayi1 + sayi2); 
            #endregion

            //double a = 10.2;
            //float b = 2.4f;
            //decimal c = 3.4m;

            #region çıkarma
            //int a = 10;
            //int b = 20;
            //Console.WriteLine(a - b);
            #endregion

            #region çarpma
            //byte a = 20;
            //byte b = 30;
            //var result = a * b;
            //Console.WriteLine(result); 

            //double a = 3.3;
            //double b = 2423122.4;
            //var result = a * b;
            //Console.WriteLine(result);

            #endregion

            #region mod alma
            //int a = 500;
            //int b = 250;
            //int result = a % b;
            //Console.WriteLine(result); 
            #endregion

            #region bölme
            //int a = 10;
            //decimal b = 3;
            //var result = a / b;
            //Console.WriteLine(result); 
            #endregion

            #region < > eşitlikler

            //int a = 50;
            //int b = 60;
            //bool result = a > b;
            //Console.WriteLine(result);

            //int z = 80;
            //int m = 199;
            //bool result = m < z;
            //Console.WriteLine(result);

            //int a = 10;
            //int b = 10;
            //bool result = a <= b;
            //Console.WriteLine(result); 
            #endregion

            #region == !=
            //int a = 50;
            //int b = 110;
            //bool result = a == b;
            //Console.WriteLine(result); //true & false

            //int a = 30;
            //int b = 32;
            //bool result = a != b;
            //Console.WriteLine(result); 
            #endregion

            #region Op örnekler
            //string a = "123", b = "metin", c = "123";
            //int d = 911, e = 13, f = 13;
            //Console.WriteLine(a==c);
            //Console.WriteLine(d>e);
            //Console.WriteLine(f==e);
            //Console.WriteLine(f>e);
            //Console.WriteLine(a==b); 
            #endregion

            #region & | işlemleri

            //int a = 10;
            //int b = 10;
            //int c = 5;
            //bool result = (a & b) > c;
            //Console.WriteLine(result); //true

            //int a = 10;
            //int b = 1;
            //int c = 5;
            //bool result = (a & b) > c; // & ve anlamına gelir
            //Console.WriteLine(result); // false

            //int a = 10;
            //int b = 1;
            //int c = 5;
            //bool result = (a | b) > c; // | veya anlamına gelir. çıktı true
            //Console.WriteLine(result);  
            #endregion

            #region ? : Ternary
            //string a = "ece";
            //string b = "hilal";
            //string result = a == b ? "Evet" : "Hayır";
            //Console.WriteLine(result);

            //int a = 20;
            //int b = 10;

            //int result = a < b ? 1 : 0;
            //Console.WriteLine(result);
            #endregion

            #region Op example app
            /* Kullanıcıdan 2 değer alıp büyüklük olarak karşılaştırın
               */
            //Console.WriteLine("sayi1: ");
            //Console.WriteLine("sayi2: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //int sayi2 = int.Parse(Console.ReadLine());
            //var result = sayi1 > sayi2 ? "true" : "false";
            //Console.WriteLine(result);

            // Console'dan gelen her bilgi string olarak geliyor.. veya

            //Console.WriteLine("sayi1: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sayi2: ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"sayi1 sayi den buyuk mu? : {sayi1 > sayi2}"; 
            #endregion

            #region ascii örnek
            /* Kullanıcıdan char türünde değer alıp ascii karşılığını yazdırınız */
            //Console.Write("Ascii koduna çevirme: ");
            //char value = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(value.GetType());
            //int valueasc = (int)value; //veya alttaki satır
            //int valueasc = Convert.ToInt32(value);
            //Console.WriteLine(valueasc); 
            #endregion

            #region gettype örnek
            //Console.WriteLine("yaşınızı giriniz: "); // kullanıcıya istek
            //string age = Console.ReadLine(); // kullanıcıdan gelen cevap
            //int age2 = int.Parse(Console.ReadLine());
            //int age3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(age.GetType());
            //Console.WriteLine(age2.GetType());
            //Console.WriteLine(age3.GetType()); 
            #endregion

            #region boxing-unboxing
            //object ile her değişken tanımlanabilir ama Convert oldukça kısıtlıdır. değerler Boxing olup UnBoxing yapmadan işlem yapılamaz, tüm özelliklere erişilemez
            //object a = "ece";
            //object b = 22;
            //object c = false; 
            #endregion

            #region veri tipleri
            /* Veri Tipleri
              * veri tipleri 2'ye ayrılır;
              *  1. Değer Tipliler
              *  Değer Tipli veriler 
              * 
              * byte
              * sbyte
              * int
              * uint
              * long
              * decimal
              * float
              * char
              * vs...
              * 
              * 2. Referans Tipliler
              * Bu veriler heap'te referans göstergeli stack bölgede tutulur
              * 
              * Heap bölgede referansı kopmuş verileri heap bölgeden temizleyen mekanizmanın adı collectorgarbage dır
              * 
              * string
              * 
              */
            #endregion

            #region Değişken tanımlama kuralları
            /* Değişken tanımlama kuralları
              * 
              * 1. Atayacağımız değer veri tipine uygun olmalıdır
              * int a = 10; gibi
              * 
              * 2. Değişken adı rakam adı veya karakter ile başlayamaz
              * 
              * 3. Değişken adları programatik olmamalı. illa ki kullanılacaksa başına @ eklenir
              * 
              * int static = 10; gibi
              * int @static = 10;
              * 
              * 4. Değişken adları (_ hariç) özel karakter içeremez
              * 
              * 5. Türkçe karakterler kullanılmaz
              */
            #endregion

            #region c# kuralları
            /* c# dilinin kuralları
                 * 
                 * 1. Büyük küçük harfe duyarlıdır
                 * 
                 * 2. Tip güvenlikli bir dildir
                 * 
                 * 
                 */

            //char a = (char)2;
            //Console.WriteLine(a);

            //Console.Write("Ascii koduna çevirme: ");
            //char value = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(value.GetType());
            //int valueasc = (int)value; //veya alttaki satır
            //int valueasc = Convert.ToInt32(value);
            //Console.WriteLine(valueasc); 
            #endregion

            #region bool
            //int a = 5;
            //int b = 5;
            //bool result = a >= b; //bool; true or false değri verir
            //Console.WriteLine(result); 
            #endregion

            #region scope
            // Scope
            //Scope kodların yaşam alanıdır
            //Ece
            //{
            //    int a = 10;
            //    //hilal
            //    {
            //        int a = 10;

            //    }
            //}

            #endregion

            #region object
            // object veri türünde her veri BOXING işlemi görür. tüm özellikleri ile kullanabilmek için UNBOXING yapılmalıdır
            //object a = "ali";
            //object b = 20;
            //object c = true;

            //int z = (int)b; // veya
            //int z = Convert.ToInt32(b); 
            //int d = 10;
            //Console.WriteLine(z+d);

            //string e = "sözlü";

            //Console.WriteLine(a + " " + e);

            #endregion

            #region 4 işlem
            //int a = 10;
            //int b = 20;
            //int c = 30;
            //int d = 40;
            //decimal e = 20.5m;

            // int result = a + b + c + d;
            // int result = (a + b) - (c + d);
            // int result = a - b - c - d;
            // int result = a * b;
            // decimal result = a * e; // ya a değeri decimal'e çevrilir veya sonucu decimal yaparız
            // Console.WriteLine(result);

            //int f = Convert.ToInt32(e);
            //bool result = a <= f;

            //Console.WriteLine(result); 
            #endregion

            #region atama operatörleri
            // Atama Operatörleri
            //int a = 10;
            //int b = 21;
            //int c = 30;
            //int d = 40;
            //decimal e = 20.5m;

            // a += 10;
            //a *= b;
            //b += a;
            //b = -a; // a 'nın - değeri
            //b = a--; // b-a

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            // Kullanıcıdan 2 adet sayı alıp bu iki sayıyı toplayalım

            //Console.WriteLine("sayi1: ");
            //var sayi1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("sayi2: ");
            //var sayi2 = decimal.Parse(Console.ReadLine());

            //decimal result = sayi1 + sayi2;
            // Console.WriteLine($"Toplama İşlemi Sonucu: {result}"); // veya
            //Console.WriteLine("Toplama İşlem Sonucu: "+ result);
            #endregion

            #region mantıksal operatörler (ve veya)
            //int a = 21;
            //int b = 30;
            //int c = 30;
            //int d = 20;

            // bool result = a < b && c > d; //true
            // bool result = a > b && c > d; //false
            //bool result = a > b || c > d; //true
            //Console.WriteLine(result);


            // kullanıcıdan 4 adet sayı alınız || (veya) operatörüne göre 1. ve 2. sayının büyüklük kontrollerini yapınız sonrasında 3. ve 4. sayının büyüklük kontrollerini yapıp sonucu ekrana yazdırınız

            //Console.WriteLine("sayi1: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("sayi2: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("sayi3: ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("sayi4: ");
            //int d = int.Parse(Console.ReadLine());

            //bool result = a > b || c > d;
            //Console.WriteLine($"Sonuç: {result}");

            #endregion

            #region if else örnek3
            // Kullanıcıdan 3adet tam sayı alın. ortalaması 50 ve 50'den büyükse "Başarılı" küçükse "Başarısız yazsın

            /* Console.WriteLine("vize1: ");
             int not1 = int.Parse(Console.ReadLine());

             Console.WriteLine("vize2: ");
             int not2 = int.Parse(Console.ReadLine());

             Console.WriteLine("vize3: ");
             int not3 = int.Parse(Console.ReadLine());

             decimal ortalama = (not1 + not2 + not3) / 3;
             Console.WriteLine($"Derslerin Ortalaması: {ortalama}");

             if (ortalama >= 50)
             {
                 Console.WriteLine("Başarılı");
             }
             else
             {
                 Console.WriteLine("Başarısız");
             }
            */
            #endregion

            #region swtich case

            /* Akış kontrol mekanizmalarında 2. kontrol yöntemiz SWITCH  CASE yapılanmasıdır 
             * 
             * switch (kontrol edilmesini istediğimiz koşul) //burası sayısal ise case de sayısal, burası string ise case de string olmalı
             * {
             *      case (koşul):
             *          Çalışması istenilen kod veya kolar
             *          break;
             *      case (koşul):
             *          Çalışması istenilen kod veya kolar
             *          break;
             *      default:
             *          Çalışması istenilen kod veya kolar
             *          break;
             *  }
             */

            /* Console.WriteLine("Kullanıcı adı giriniz: ");
            string user = Console.ReadLine().Trim().ToLower();

            switch (user)
            {
                case "ali":
                    Console.WriteLine("Hoşgeldin Ali");
                    break;

                case "veli":
                case "mehmet":
                    Console.WriteLine("Hoşgeldin Veli veya Mehmet");
                    break;

                default:
                    Console.WriteLine("Kullanıcı değilsiniz");
                    break;
            }
            */
            #endregion

            #region switch case örnek
            /* Console.WriteLine("Haftanın gününü sayısal olarak giriniz");
             int day = int.Parse(Console.ReadLine());
            */
            /*
            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Haftaiçi çalışmaya devam");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Haftasonu tatili");
                    break;

                default:
                    Console.WriteLine("Hatalı değer girdiniz");
                    break;

            }
            */
            /*
            if (day>= 1 && day<= 5)
                {
                Console.WriteLine("Haftaiçi çalışmaya devam");
            }
            else if (day>= 6 && day<= 7)
            {
                Console.WriteLine("Haftasonu tatili");
            }
            else
            {
                Console.WriteLine("Hatalı değer girdiniz");
            }
            */
            #endregion

            #region switch case ve if örnek
            //Kullanıcıdan tek sayı alıp 10 değerine eşit olup olmadığını yazalım

            /*
            Console.WriteLine("sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 1)
            {
                Console.WriteLine("Sayı tek");
            }
            else if (sayi == 10)
            {
                Console.WriteLine("Sayı 10");
            }
            else
                Console.WriteLine("Sayı tek değil veya 10 a eşit değil");
            */
            /*
            Console.WriteLine("sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi != 10)
                Console.WriteLine("Bildiniz");
            else
                Console.WriteLine("Bilemediniz");
            */
            #endregion

            #region switch if-else if mevsimler örnek

            /* Kış mevsimi: aralık ocak ve şubat
             * ilkbahar: mart nisan mayıs
             * yaz: haziran temmuz ağustos
             * sonbahar: eylül ekim kasım
             * 
             * kullanıcı bir ay girsin ve ilgili mevsimin case bloguna düşsün ve ekrana hangi mevsim olduğu yazsın */
            /*
            Console.WriteLine("ay giriniz: ");
            string ay = Console.ReadLine().Trim().ToLower();
            */
            /*
            switch (ay)
            {
                case "aralık":
                case "ocak":
                case "şubat":
                    Console.WriteLine($"{ay}: Kış mevsimi");
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    Console.WriteLine($"{ay}: ilkbahar mevsimi");
                    break;
                case "haziran":
                case "temmuz":
                case "ağustos":
                    Console.WriteLine($"{ay}: yaz mevsimi"); break;
                case "eylül":
                case "ekim":
                case "kasım":
                    Console.WriteLine($"{ay}: sonbahar mevsimi");
                    break;
                default:
                    Console.WriteLine("Hatalı değer girdiniz. Lütfen kontrol edin");
                    break;
            }
            */
            /*
            if (ay == "aralık" || ay == "ocak" || ay == "şubat")
            {
                Console.WriteLine($"{ay}: Kış mevsimi");
            }
            else if (ay == "mart" || ay == "nisan" || ay == "mayıs")
            {
                Console.WriteLine($"{ay}: ilkbahar mevsimi");
            }

            else if (ay == "haziran" || ay == "temmuz" || ay == "ağustos")
            {
                Console.WriteLine($"{ay}: sonbahar mevsimi");
            }
            else if (ay == "eylül" || ay == "ekim" || ay == "kasım")
            {
                Console.WriteLine($"{ay}: kış mevsimi");
            }
            else
            {
                Console.WriteLine("Hatalı değer girdiniz. Lütfen kontrol edin");
            }
            */
            #endregion

            #region Enum giriş

            //Enum ile kendi yapılarımızı tanımlayabiliriz

            /*
            Gunler gunler = new Gunler();
            Console.WriteLine(Gunler.pazar);

            switch (Gunler.pazartesi)
            {
            case
                */

            // Type t = typeof(Gunler);
            // Console.WriteLine(t.FullName); 
            // Console.WriteLine(t.IsClass); 
            // Console.WriteLine(t.IsEnum); 
            // Console.WriteLine(t.IsPrimitive); 

            /* Type i = typeof(int);
            Console.WriteLine(i.FullName); // Çıktılar: System.Int32
            Console.WriteLine(i.IsPrimitive); // True
            Console.WriteLine(i.IsClass); // False */

            /* Type z = typeof(long);
            Console.WriteLine(z.IsPrimitive); */

            #endregion

            #region Engin Ceylan 10.09.2022

            #endregion



            /* Property:
             * anahtar simgeli görünenler
             * 
             * Methods (fonksiyon):
             * Mor simgeli
             * () olmadan kullanılmazlar
             * 
             * Event: 
             * Şimşek simgeli
             * 
             */

            /*
            Console.WriteLine(" Ad Soyadı Girin: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Doğum yılınız");
            i.nt birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine($"merhaba sayın {fullName} yaşınız {2022 - birthYear}" );
            */

            #region Convert
            /*
            int x= Convert.ToInt32(true);
            Console.WriteLine(x); // true için 1 , false için 0 gelir
            */

            /*
            int result = Convert.ToInt32('3');

            Console.WriteLine(result); // 51.. char karşılığı yani 3 sayısının 10'luk sistemdeki karşılığı gelir
            */

            /*
            int result =Convert.ToInt32(15.5m);
            Console.WriteLine(result); //ondalık kısmını dikkate almadan aşağı ya da yukarı yuvarlar
            */

            /*
            long value = 23112312313123123;
            // implicit Convert
            int result = (int)value;  // mod almaya başlayıp bambaşka değer verdi


            //int result =Convert.ToInt32(value);// dönüşüm olmaz.. büyük değerden küçük değere dönüşü kabul etmiyor veya zorlarsak değer kaybına neden olur

            Console.WriteLine(result);
            */

            // Explicit Convert
            // long value = 100; //değer int olduğundan zorlamadan dönüşüm yapar. dolayısıyla sistem kendisi bu değeri int olarak algılar ve bunu istem dışı yapar. bu nedenle explicit deniliyor

            /*
            byte b = 200, c = 200;
            // var d = b + c;
            byte d = (byte)(b + c);
            Console.WriteLine(d);
            */

            /*
            int a=int.MaxValue, b= int.MaxValue;

            int c = a + b;
            Console.WriteLine(c); // çıktı -2
            */

            #endregion

            #region mantıksal operatörler
            /* Mantıksal operatörlerin operandları bool türde olmalıdır
            */

            /*
            int num1=10, num2=4;
            int num3=15;
            

           //(num1+ num2)%3>4 && (num1/num2)+4==num2*num1||!(num1>5)

           // int result = num1/num2;
           
           // Console.WriteLine(num3/(num2*1.0)); //pratik dönüştürme
            Console.WriteLine(num3/num2);
            */
            #endregion

            #region ++ / -- operatörler

            // ++x == +1;
            // x++ == +1;

            // Not: Bu operatörler bir ifade (expression) içinde kullanılmadığında yani tek başına kullanıldığında o  değişkenin değerini 1 arttırır (ram'de). Bu durumda başına ya da sonuna koymak fark oluşturmaz.
            //Not: Bir ifade içinde kullanıldığında başına ya da sonuna koymak fark etmez

            /*
            int num1 = 10;
            Console.WriteLine(num1);
            Console.WriteLine(num1++);
            Console.WriteLine(++num1);
            */

            /*
            int num1 = 5, num2 = 8;
            int result = num1++ + ++num2 - num1-- + (++num1 + num2--);
            Console.WriteLine($"result: {result}");
            Console.WriteLine($"num1: {num1}");
            Console.WriteLine($"num2: {num2}");

            // result = 23
            // num1= 6
            // num2 = 8
            */

            #endregion

            #region Yığma Op
            /*
            int a = 10;
            a += 5; // veya a = a +5

            a = a + b; // veya a +=b;
            */

            /*
            string firstName = "ece";
            string lastName = "tohma";
            firstName += lastName;
            */


            #endregion

            /*
            char a = 'd', b = '7';

            var c = a + b; // ascii tablosundaki değerleri toplar
            
            Console.WriteLine(c);
            */

            #region 17.9.22 ödevler

            // Girilen iki sayının arasındaki sayıların toplamını bulan programı yazınız

            Console.Write("sayi1: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("sayi2: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sayi1+sayi2);
            #endregion



            Console.ReadLine();


        }


    }
    /* enum Gunler
     {
         pazartesi,
         sali,
         carsamba,
         persembe,
         cuma,
         cumartesi,
         pazar
     }  */
}

