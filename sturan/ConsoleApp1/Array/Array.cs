using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Ogrenci
    {
        public string Ad;
        public int Nu;
    }
    internal class Array
    {
        
        static void Main(string[] args)
        {
            /*
             int[] ogrnu = new int[5];

             ogrnu[0] = 100;
             ogrnu[1] = 110;
             ogrnu[2] = 120;
             ogrnu[3] = 130;
             ogrnu[4] = 140;

             string[] ogrenciler = new string[5];

             ogrenciler[0] = "ece";
             ogrenciler[1] = "hayat";
             ogrenciler[2] = "hilal";
             ogrenciler[3] = "bilge";
             ogrenciler[4] = "gamze";

             //sınıf tanımlayıp ayrı değerleri aynı sınıf içerisinde toplu gösterelim */

            /*
            Ogrenci[] ogrenciler = new Ogrenci[5];

            ogrenciler[0] = new Ogrenci() { Ad="serdar", Nu=100}; //Öğrencier dizisi içerisine bir öğrenci atıyoruz. yeni bir string veya int değeri yerine Class atıyoruz
            ogrenciler[1] = new Ogrenci() { Ad = "orhan", Nu = 200 };
            ogrenciler[2] = new Ogrenci() { Ad = "sureyya", Nu = 300 };
            ogrenciler[3] = new Ogrenci() { Ad = "suheyla", Nu = 400 };
            ogrenciler[4] = new Ogrenci() { Ad = "leyla", Nu = 500 };

            foreach (var ogr in ogrenciler) // foreach döngüsü ile kurgu
            {
                Console.WriteLine("Öğrenci adı: {0} Öğrenci No: {1}",ogr.Ad, ogr.Nu);
            }

            Console.WriteLine("-----------"); //for döngüsü ile yapalım

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine("Öğrenci adı: {0} Öğrenci nu: {1}", ogrenciler[i].Ad, ogrenciler[i].Nu);
            }
            */


            Console.ReadLine();
        }
    }
}
