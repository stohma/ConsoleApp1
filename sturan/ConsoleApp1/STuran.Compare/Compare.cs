using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STuran.Compare
{
    internal class Compare
    {
        static void Main(string[] args)
        {
            //string str1 = "abc";
            //string str2 = "Abc";

            //if (str1.Equals(str2)==true) //str1 ile str2 yi eşitlik olarak karşılaştırıyoruz. bu str1==str2 ile aynı
            //{
            //    Console.WriteLine("değerler eşit");
            //}

            //if (string.Compare(str1,str2,true)==0) //true yu eklediğimizde küçük büyük harf ayrımı yapmadan algılar ve bu durumda çıktıyı eşit olarak döndürür. buranın varsayılanı string.Compare(str1,str2,false) ve bu yüzden yazmaya gerek yok
            //{
            //    Console.WriteLine("değerler eşit");
            //}

            //if (string.Compare(str1, str2) == 0) 
            //{
            //    Console.WriteLine("değerler eşit");
            //}

            //string str1 = "abc";
            //string str2 = "Abc";
            
            //int sonuc=string.Compare(str1, str2);

            //if (sonuc == 0)
            //{
            //    Console.WriteLine("değerler eşit");
            //}
            //else if (sonuc == 1)
            //{
            //    Console.WriteLine("str2 str1 den alfabetik olarak önde gelir");
            //}
            //else if (sonuc == -1)
            //{
            //    Console.WriteLine("str1 str2 den alfabetik olarak önde gelir");
            //}

            #region örnek

            string _email = "serdartohma@gmail.com";
            string _password = "123456";

            Console.WriteLine("Email giriniz");
            string email = Console.ReadLine();
            
            Console.WriteLine("Parola giriniz");
            string password = Console.ReadLine();

            if (_email.Equals(email) && _password.Equals(password))
            {
                Console.WriteLine("Sisteme giriş yaptınız"); ;
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı ya da parola");
            }

            
            #endregion



            Console.ReadLine();
        }
    }
}
