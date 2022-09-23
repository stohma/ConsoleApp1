using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Arrays
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            //Not: dizi tipindeki işaretçinin Length özelliği ile karakter sayısını öğreniriz


            /* 6 adet rasgele sayı çekip ekrana yazdıralım
           Random rnd = new Random();

           int[] cekilisSonu = new int[6];
           bool varMi = false;

           for (int i = 0; i < 6; i++)
           {
               int rasgele = rnd.Next(1, 7);
               //Bu sayı bu dizinin içinde var mı yok mu? kontrol edelim
               for (int j = 0; j < 6; j++)
               {
                   if (cekilisSonu[j] == rasgele)
                   {
                       varMi = true;
                   }
               }
               if (!varMi)
               {
                   cekilisSonu[i] = rasgele;
               }
               else
               {
                   i++;
               }
               Console.WriteLine();


           }

           */

            //Random rnd = new Random();
            //int[] cekilisSonucu = new int[6];
            //bool varMi = false;

            //for (int i = 0; i < 6; i++)
            //{
            //    int rasgele = rnd.Next(1, 7);
                
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (Array.IndexOf(cekilisSonucu, rasgele) == -1)
            //        {
            //            cekilisSonucu[i] = rasgele;
            //            i++;
            //        }
            //    }
                

            //}
            //Array.Sort(cekilisSonucu); //varsayılanı küçükten büyüğe

            //for (int i = 0; i < cekilisSonucu.Length; i++)
            //{
            //    Console.WriteLine(cekilisSonucu[i]);
            //}



            Console.ReadKey();
        }
    }
}
