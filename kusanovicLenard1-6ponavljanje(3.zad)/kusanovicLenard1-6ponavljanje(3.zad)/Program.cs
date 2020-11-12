using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenard1_6ponavljanje_3.zad_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] niz = new string[3];

            Console.WriteLine("Upisite prvi string ");
            niz[0] = Console.ReadLine();

            Console.WriteLine("Upisite drugi string ");
            niz[1] = Console.ReadLine();

            Console.WriteLine("Upisite treci string ");
            niz[2] = Console.ReadLine();


            Array.Sort(niz);
            Array.Reverse(niz);

            Console.WriteLine("Sortirani stringovi po abecedi ");
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine(niz[i]);
            }
            Console.ReadKey();
        }
        
        
    }
}
