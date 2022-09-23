using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Araba
    {
        public string Marka;
        public string Model;
        public string Renk;
        public int Agirlik;

        public void Start()
        {
            Console.WriteLine("{0} {1} çalıştı", Marka, Model);
        }
        public void Hizlan()
        {
            Console.WriteLine("{0} {1} hızlandı", Marka, Model);
        }
        public void Yavasla()
        {
            Console.WriteLine("{0} {1} yavalıyor", Marka, Model);
        }
        public void Stop()
        {
            Console.WriteLine("{0} {1} durdu", Marka, Model);
        }

    }
    class Program
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


        }
    }
}
