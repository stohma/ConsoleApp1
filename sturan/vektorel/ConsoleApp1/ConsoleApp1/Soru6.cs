using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev6
{
    internal class Soru6
    {
        static void Main(string[] args)
        {
            //6.Kullanıcıya 2 adet seçenek sunulacak(Daire(1) ve Villa(2)).Örneğin eğer 1 seçerse ekrana 
            //  Satılık Daire(3), Kiralık Daire(4), 2 seçerse Satılık Villa(5), Kiralık Villa(6) gelecek.
            //  Daha sonra örneğin 6 yani Kiralık Villa seçerse bütçesini girmesini isteyecek ve sizin 
            //  belirlediğiniz bir kiralık villa fiyatına bu bütçe uygunsa ekrana Bu Villayı Kiralayabilirsiniz
            //  değilse Kiralayamazsınız gibi bir mesaj çıkacak. Bu işlem 4 seçenek için uygun şekilde yapılacak
            /*
            #region odev6
            Console.WriteLine("1-Daire");
            Console.WriteLine("2-Villa");
            Console.Write("Seçiminiz <1-2> : ");
            string evturu = Console.ReadLine().Trim();

            if (evturu == "1")
            {
                Console.WriteLine("3-Satılık Daire");
                Console.WriteLine("4-Kiralık Daire");
                Console.Write("Seçiminiz <3-4> : ");
                string daireSecim = Console.ReadLine();
                if (daireSecim == "3")
                {
                    Console.WriteLine("Bütçeniz :");
                    int sdaire = int.Parse(Console.ReadLine());
                    if (sdaire >= 500000)
                    {
                        Console.WriteLine("Bu Daireyi Satın Alabilirsiniz");
                    }
                    else
                    {
                        Console.WriteLine("Bu Daireyi Satın Alamazsınız");
                    }
                }
                else if (daireSecim == "4")
                {
                    Console.WriteLine("Bütçeniz :");
                    int kdaire = int.Parse(Console.ReadLine());
                    if (kdaire >= 1000)
                    {
                        Console.WriteLine("Bu Daireyi Kiralayabilirsiniz");
                    }
                    else
                    {
                        Console.WriteLine("Bu Daireyi Kiralayamazsınız");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                }



            }
            else if (evturu == "2")
            {
                Console.WriteLine("5-Satılık Villa");
                Console.WriteLine("6-Kiralık Villa");
                Console.Write("Seçiminiz <5-6> : ");
                string daireSecim = Console.ReadLine();
                if (daireSecim == "5")
                {
                    Console.WriteLine("Bütçeniz :");
                    int svilla = int.Parse(Console.ReadLine());
                    if (svilla >= 1000000)
                    {
                        Console.WriteLine("Bu Villayı Satın Alabilirsiniz");
                    }
                    else
                    {
                        Console.WriteLine("Bu Villayı Satın Alamazsınız");
                    }
                }
                else if (daireSecim == "6")
                {
                    Console.WriteLine("Bütçeniz :");
                    int kvilla = int.Parse(Console.ReadLine());
                    if (kvilla >= 10000)
                    {
                        Console.WriteLine("Bu Villayı Kiralayabilirsiniz");
                    }
                    else
                    {
                        Console.WriteLine("Bu Villayı Kiralayamazsınız");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                }


            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
            }




            Console.ReadLine();
        }
        #endregion
            */
    }
    }
}
