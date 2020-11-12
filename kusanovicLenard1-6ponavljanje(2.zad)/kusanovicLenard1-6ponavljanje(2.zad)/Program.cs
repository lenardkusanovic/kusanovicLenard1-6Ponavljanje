using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenard1_6ponavljanje_2.zad_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite nesto! ");

            string niz = Console.ReadLine();



            Console.WriteLine(niz.Replace(" ", "_"));

            Console.ReadKey();
        }
    }
}
