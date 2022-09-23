using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace STuran.Searching
{
    internal class Searching
    {
        static void Main(string[] args)
        {
            string str = "What does Lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor incididunt ut labore et dolore magna Aliqua?";
            // Aradığımız bir değerin nerede olduğunu öğrenmek için;

            //int index = str.IndexOf("ipsum"); //eğer olmayan değeri sorgularsak çıktı -1 olarak döner
            //int index = str.IndexOf('i');
            //int index = str.LastIndexOf('t'); //sondan başlayarak sorgular
            //Console.WriteLine(index);
            
            int index = str.LastIndexOf('t');
            string str2 = str.Substring(index); //sondan başlayarak ilgili arakteri bul ve ifadenin devamını yaz. eğer int index = str.IndexOf("ipsum"); şeklinde yazsaydık ipsum dan sonrasını yazardı. 
            Console.WriteLine(str2);




            //string site = "www.edurive.com";
            //string email = "serdartohma@gmail.com";

            //if (site.StartsWith("www")==false)
            //{
            //    Console.WriteLine("geçerli bir site adresi giriniz");
            //}
            //else
            //{
            //    Console.WriteLine("site adresi düzgün girildi");
            //}

            // if (site.EndsWith("com")==false)
            //{
            //    Console.WriteLine("geçerli bir site adresi giriniz");
            //}
            //else
            //{
            //    Console.WriteLine("site adresi düzgün girildi");
            //}

            //if (email.Contains("@")) // Contains ile bu şekilde arama/sorgulama/doğrulama işlemi yapabiliyoruz
            //{
            //    Console.WriteLine("eposta adresi doğru girildi");
            //}
            //else
            //{
            //    Console.WriteLine("geçerli bir eposta adresi giriniz" );
            //}


            Console.ReadLine();
        }
    }
}
