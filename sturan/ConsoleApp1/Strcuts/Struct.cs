using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs1
{
    public struct Dikdortgen
    {
        public int kisa;
        public int uzun;
        // değişkenlerden sonra bu değişkenlere ve amaca yönelik hizmet hazırlanır

        public int Alan()
        { return kisa * uzun; }

        public int Cevre ()
        { return 2*(kisa + uzun); }
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            Dikdortgen _dikdortgen = new Dikdortgen();

            _dikdortgen.kisa = 50;
            _dikdortgen.uzun = 70;

            int result = _dikdortgen.Alan();

            Console.WriteLine(result);

            Dikdortgen _kare = new Dikdortgen();
            
            _kare.kisa = 50;
            _kare.uzun = 50;
            Console.WriteLine(_kare.Alan());

            Console.WriteLine("------------");

            Console.WriteLine(_dikdortgen.Cevre());
            Console.WriteLine(_kare.Cevre());
        }
    }
}
