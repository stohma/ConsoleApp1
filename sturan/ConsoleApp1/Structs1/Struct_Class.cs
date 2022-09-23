using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Class
{
    struct Urun //buradaki struct class olursa 2.sorgulamadaki ürün fiyatı 3750 oluyor yani 2500*1.5'lu halini veriyor
    {
        public string UrunAdi;
        public float Fiyat;
    }
    internal class Struct_Class
    {
        static void Main(string[] args)
        {
            Urun iphone = new Urun();
            iphone.UrunAdi = "Iphone 6S";
            iphone.Fiyat = 2500;

            UrunGetir(iphone);
            UrunGuncelle(iphone);
            UrunGetir(iphone);

            Console.ReadLine();
        }

        static void UrunGetir(Urun urun)
        {
            Console.WriteLine($"urun adı: {urun.UrunAdi} fiyat : {urun.Fiyat}");
        }

        static void UrunGuncelle(Urun urun)
        {
            urun.Fiyat *= 1.5f;
           // Console.WriteLine(urun.Fiyat);
        }

        
    }
}
