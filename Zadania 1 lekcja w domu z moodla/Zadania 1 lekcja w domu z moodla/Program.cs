using System;

namespace Zadania_1_lekcja_w_domu_z_moodla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sprawdzanie przystości liczby zadanie 1.
            Console.Write("Podaj liczbę: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else Console.WriteLine("Liczba nie jest parzysta");
            Console.ReadKey();

            
        }
    }
}
