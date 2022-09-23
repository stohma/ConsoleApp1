using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İsimlendirme
            // Pascal Case
            // int studentId;
            // string studentName;

            // Camel Case
            //int ProductId;
            //string StudentName;
            //int ProductCategory;

            // Snake Case
            //int category id;
            //string student_name;
            #endregion

            #region String Formatları
            //Console.WriteLine($"Byte Min.Deger:{byte.MinValue} Byte Max.Deger:{byte.MaxValue}"); //String Policion
            //Console.WriteLine("Sbyte Min.Deger:{0} Sbyte Max.Deger:{1}", sbyte.MinValue, sbyte.MaxValue); //String Format
            //Console.WriteLine("Short Min.Deger:" + short.MinValue + "Short Max.Deger:" + short.MaxValue); // Allians bu format genelde karışık olduğundan tercih edilmiyor

            //Console.ReadLine();
            #endregion

            // ctrl + k + u yorum satırı kaldırma


            #region String2

            //Console.WriteLine($"Byte Min.Deger:{byte.MinValue} Byte Max.Deger:{byte.MaxValue}"); //String Policion
            //Console.WriteLine("Sbyte Min.Deger:{0} Sbyte Max.Deger:{1}", sbyte.MinValue, sbyte.MaxValue); //String Format
            //Console.WriteLine("Short Min.Deger:" + short.MinValue + "Short Max.Deger:" + short.MaxValue); // Allians bu format genelde karışık olduğundan tercih edilmiyor
            //Console.WriteLine($"int Min.Deger:{int.MinValue} int Max.Deger:{int.MaxValue}");
            //Console.WriteLine($"uit Min.Deger:{uint.MinValue} uit Max.Deger:{uint.MaxValue}");
            //Console.WriteLine($"long Min.Deger:{long.MinValue} long Max.Deger:{long.MaxValue}");

            //float deneme = 25.1F;
            //Decimal deneme2 = 60.4m;
            //double deneme3 = 20.9;

            //char w = 'd'

            //Console.ReadLine(); 
            #endregion

            //int a = 10;
            //bool a = false; //default hali false gelir.

            //string e = "15";
            //string f = "11";
            //Console.WriteLine(e + " " + f);
            //Console.ReadLine();

            //Console.WriteLine("Merhaba Senin Adın Ne?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Soyadın Nedir?");

            //Console.WriteLine(name);

            //Console.Writeline("adınız ve soyadınız:");
            //string namelastname = console.readline();
            //console.writeline("doğum yılınız:");
            //int borndate = convert.toınt32(console.readline());
            //int date = 2022;
            // veya in result = date - borndate
            //console.writeline($"adınız ve soyadınız:{namelastname} yaşınız:{result}");
            //console.writeline($"adınız ve soyadınız:{namelastname} yaşınız:{date-borndate}");

            //int a = 20;
            //int b = 23;
            //int c = 112;
            //int result = a + b + c;
            //Console.WriteLine(result);

            //byte a = 50;
            //byte b = 11;
            //var result = a * b;
            //Console.WriteLine(result);

            //string name = "Ali";
            //string lastname = "Er";
            //Console.WriteLine(name+ " "+ lastname);

            //string a = "10";
            //int b = 20;

            ////int z = int.Parse(a); veya Convert.ToInt32() ile int değeri string e çevirebiliriz
            //int z = Convert.ToInt32(a);
            //Console.WriteLine(z + b);


            //kesirli sayılar
            //dynamic d = 112;
            //int a = 220;
            //double b = 100.4; // veya var b = 100.4; 
            //int c = Convert.ToInt32(b);
            //int result = d + (int)b


            //Console.WriteLine(result);

            #region check fonksiyonu

            //kontrol uygulama
            //checked
            //{
            //    byte a = 250;
            //    byte c = 100;
            //    var result = 350;
            //    Console.WriteLine(result);
            //}

            //checked
            //{
            //    byte a = 252;
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //    a++;
            //   Console.WriteLine(a);
            //} //uyarı veriyor 255 son değer olmalı

            byte a = 252;
            a++;
            a++;
            a++;
            a++;
            a++;
            a++;
            a++;
            a++;
            Console.WriteLine(a); // çıktı 5.. sorun var. çünkü veriyi 0'dan başlattığından işlem uygun olmayacak döngü içerisinde kalacaktır. 
            #endregion




            Console.ReadLine(); 




        }
    }
}
