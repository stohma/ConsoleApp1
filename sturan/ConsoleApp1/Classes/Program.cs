using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program //Araba class'ı ile bu sayfa aynı proje altında olduğundan verileri birbirinden alacaktır. yük dağılımı olması bakımından bu şekilde yapılması projenin ağır olmasını önleyecektir.
    {
        static void Main(string[] args)
        {

            Araba opel = new Araba();

            opel.Marka = "Opel";
            opel.Model = "Corsa";
            opel.Renk = "Kırmızı";
            opel.Agirlik = 1250;

            opel.Start();
            opel.Hizlan();
            opel.Yavasla();
            opel.Stop();

            Console.WriteLine("---------------------");

            Araba mazda = new Araba();

            mazda.Marka = "Mazda";
            mazda.Model = "CX 3";
            mazda.Renk = "Beyaz";
            mazda.Agirlik = 1500;

            mazda.Start();
            mazda.Hizlan();
            mazda.Yavasla();
            mazda.Stop();

            Console.WriteLine("---------------------");

            
            int result = Hesaplama.Toplama(10, 20);
            Console.WriteLine(result);
        }
    }
}
