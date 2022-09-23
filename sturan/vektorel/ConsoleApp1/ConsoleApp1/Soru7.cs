using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    internal class Soru7
    {
        static void Main(string[] args)
        {
            //7.Bir cep telefonu firması için, müşterilerinin faturasını hesaplayan ve ekranda gösteren programı yazınız.
            //  Bu cep telefonu şirketinin iki çeşit servis hizmeti vardır.Standart Hizmet ve Premium Hizmet.Müşterinin
            //  faturası kullandığı servis hizmetine göre hesaplanmaktadır.
            /*
            #region odev7
            Console.WriteLine("Kullandığınız Hizmeti seçiniz < Premium Hizmet - Standart Hizmet >");
            string hizmet = Console.ReadLine().Trim().ToLower();

            if (hizmet == "standarthizmet" || hizmet == "Standart Hizmet" || hizmet == "standart hizmet")
            {
                Console.WriteLine("Konuştuğunuz dakika miktarını giriniz :");
                double dakika = double.Parse(Console.ReadLine());

                if (dakika <= 50)
                {
                    Console.WriteLine($"Ödemeniz gereken tutar : {10} TL");
                }
                else
                {
                    Console.WriteLine($"Ödemeniz gereken tutar : {(10) + ((dakika - 50) * 0.2)} TL");
                }
            }
            else if (hizmet == "premiumhizmet" || hizmet == "Premium Hizmet" || hizmet == "premium hizmet")
            {
                Console.WriteLine("06.00 - 18.00 saaatleri arası kullandığınız dakika miktarını giriniz  ");
                double alti = double.Parse(Console.ReadLine());
                Console.WriteLine("18.00 - 06.00 saaatleri arası kullandığınız dakika miktarını giriniz  ");
                double onsekiz = double.Parse(Console.ReadLine());

                if (alti <= 75)
                {
                    if (onsekiz <= 100)
                    {
                        Console.WriteLine($"Ödemeniz gereken tutar : {25} TL");
                    }
                    else
                    {
                        Console.WriteLine($"Ödemeniz gereken tutar : {(25) + ((onsekiz - 100) * 0.05)} TL");
                    }

                }
                else
                {
                    if (onsekiz <= 100)
                    {
                        Console.WriteLine($"Ödemeniz gereken tutar : {(25) + ((alti - 75) * 0.1)} TL");
                    }
                    else
                    {
                        Console.WriteLine($"Ödemeniz gereken tutar : {(25) + (((alti - 75) * 0.1) + ((onsekiz - 100) * 0.05))} TL");
                    }

                }

            }
            else
            {
                Console.WriteLine("Geçersiz değer girdiniz . Tekrar Deneyiniz");
            }

            Console.ReadLine();
            #endregion
            */
        }
    }
}
