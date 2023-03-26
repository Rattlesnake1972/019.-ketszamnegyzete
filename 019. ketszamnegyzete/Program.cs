using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019.ketszamnegyzete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot és kiírom a négyzetét!");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            double negyzet = szam1 * szam1;
            Console.WriteLine("A szám négyzete: " +negyzet + "." + "\n");

            Console.WriteLine("Kérek még egy számot és kiírom ennek is a négyzetét!");
            double szam2 = Convert.ToDouble(Console.ReadLine());
            double negyzet2 = szam2 * szam2;
            Console.WriteLine("A szám négyzete: " +negyzet2 + "." + "\n");

            Console.ReadKey();
        }
    }
}
