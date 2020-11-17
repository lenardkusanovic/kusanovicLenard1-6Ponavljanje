using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenard1_6ponavljanje_4.zad_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a: ");
            decimal bez = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Unesite istu cijenu sa PDV-om: ");
            decimal sa = Convert.ToDecimal(Console.ReadLine());

            decimal pdv = ((sa / bez) - 1) * 100;

            Console.WriteLine("Pdv je: " + pdv + "%");
            Console.ReadKey();

        }
    }
}
