using System;

namespace Tabliczka_mnożenia
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiersz=1, kolumna, wynik , n = 10 ;
            do
            {
                kolumna = 1;
                do
                {
                    wynik = wiersz * kolumna;
                    Console.Write("{0}\t", wynik);
                    kolumna++;
                } while (kolumna <= n);
                Console.WriteLine();
                wiersz++;
            } while (wiersz <= n);

            Console.ReadKey();

        }
    }
}
