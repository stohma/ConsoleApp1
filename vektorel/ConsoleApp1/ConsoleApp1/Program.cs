using System;
using System.Collections.Generic;
using System.Linq;
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


#region Ödevler


	#endregion


            Console.ReadLine();
        }
    }
}
