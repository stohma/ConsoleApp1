using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum OdemeYontemleri : byte // byte isteğe bağlı girdik
    {
        KrediKarti = 1,
        Havale = 2,
        KapidaOdeme = 3
    }
    internal class Enum
    {

        static void Main(string[] args)
        {
            /*
            var kredikarti = OdemeYontemleri.KrediKarti;
            // Console.WriteLine(krediKarti); //eğer int değişkenine çevirirsek çıktı tanımlı olana göre verir
            // Console.WriteLine((int)krediKarti);

            var odemeid = (int)kredikarti; //veritabanına kayıt işlemi: 1
            // ödeme bilgisini getir
            Console.WriteLine(odemeid);
            */

            Console.WriteLine("Ödeme Tipi giriniz (Kredi 1, Havale 2, KapidaOdeme 3)");
            var odemetipi = byte.Parse(Console.ReadLine());

            switch (odemetipi)
            {
                case (byte)OdemeYontemleri.KrediKarti:
                    Console.WriteLine("Yapılan Ödeme {0}", OdemeYontemleri.KrediKarti);
                    break;
                case (byte)OdemeYontemleri.Havale:
                    Console.WriteLine("Yapılan Ödeme {0}", OdemeYontemleri.Havale);
                    break;
                case (byte)OdemeYontemleri.KapidaOdeme:
                    Console.WriteLine("Yapılan Ödeme {0}", OdemeYontemleri.KapidaOdeme);
                    break;
                default:
                    break;

            }


            Console.ReadLine();
        }
    }
}
