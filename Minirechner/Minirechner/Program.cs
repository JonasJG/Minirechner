using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dies ist ein kleiner Rechner!");
            Console.Write("Zahl 1:");
            int ersteZahl = Convert.ToInt16(Console.ReadLine());
            Console.Write("Zahl 2:");
            int zweiteZahl=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n\n");

            Program.Addieren(ersteZahl, zweiteZahl);
            Program.Subtrahieren(ersteZahl, zweiteZahl);
            Program.Multiplikation(ersteZahl, zweiteZahl);
            Console.ReadKey();
        }

        

        static int Subtrahieren(int ersteZahl, int zweiteZahl)
        {
            int Differenz = ersteZahl - zweiteZahl;
            Console.WriteLine("\nDie Differenz beträgt:{0}", Differenz);
            return Differenz;
        }

        static int Addieren(int ersteZahl, int zweiteZahl)
        {
            int Summe = ersteZahl + zweiteZahl;
            Console.WriteLine("Die Summe beträgt:{0}", Summe);
            return Summe;
        }

        static int Multiplikation(int ersteZahl, int zweiteZahl)
        {
            int Produkt = ersteZahl * zweiteZahl;
            Console.WriteLine("\nDas Produkt beträgt:{0}", Produkt);
            return Produkt;
        }
    }

}
