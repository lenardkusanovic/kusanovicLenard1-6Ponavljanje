using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenard1_6ponavljanje_5.zad_
{
    class Program
    {
        static void Main(string[] args)
        {
            int zb = 0;
            int karta;
            Console.WriteLine("Unesite brojeve karata (1-13): ");

            do
            {
                karta = Convert.ToInt32(Console.ReadLine());
                if (karta > 0 && karta < 14)
                {
                    zb = zb + karta;
                }
                else
                {
                    Console.WriteLine(" x ");
                }
            } while (zb < 31);

            if (zb == 31) { Console.WriteLine("Pobjedili ste!"); } else { Console.WriteLine("Izgubili ste "); }
            Console.ReadKey();
        }
    }
}
