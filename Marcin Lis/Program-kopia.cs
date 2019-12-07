using System;

namespace Rozdzial_8
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;

            if (x > 0)
            {
                Console.WriteLine("Liczba jest większa od zera");
            }
            else
            {
                Console.WriteLine("Liczba nie jest większa od 0");
            }
            Console.Clear();

            //program wczytuje imie

            Console.WriteLine("Podaj swoje imię ");
            Console.Clear();

            string imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}", imie);
            Console.Clear();

            //obliczanie delty

            int A = 2, B = 3, C = 1;
            Console.WriteLine("Parametry równania :\n");
            Console.WriteLine("A = {0}, B = {1}, C = {2}", A, B, C);

            if (A ==0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe: A = 0");
            }
            else
            {
                //obliczanie delty
                double delta = B * B - 4 * A * C;

                if (delta < 0)
                {
                    Console.WriteLine("Delta < 0");
                    Console.WriteLine("To równanie nie ma rozwiązań w zbiorze liczb rzeczywistych");

                }
                else
                {
                    double wynik;

                    if (delta == 0)
                    {
                        Console.WriteLine("Delta = 0");
                        wynik = -B / 2 * A;
                        Console.WriteLine("Rozwiązanie x = {0}", wynik);
                    }

                    else
                    {
                        Console.WriteLine("Delta większa od 0");
                        wynik = (-B + delta * delta) / 2 * A;
                        Console.WriteLine("Rozwiązanie x1 = {0}", wynik);
                        wynik = (-B - delta * delta) / 2 * A;
                        Console.WriteLine("Rozwiązanie x2 = {0}", wynik);


                    }
                }


            }

            Console.Clear();

            //Cwiczenie 8.1

            int a = 2, b = 1;

            if (a % b == 0)
            {
                Console.WriteLine("Reszta z dzielenia a % b jest równa zero");
            }
            else
            {
                Console.WriteLine("Reszta z dzielenia a % b nie jest równa zero");
            }
            Console.Clear();

            //Cwiczenie 8.3

            int t = -4;

            if (t > 0)
            {
                Console.WriteLine("Wartość bezwzględna t: {0}", t);
            }
            else
            {
                int wb = t - t - t;
                //albo po ptostu -t XD

                Console.WriteLine("Wartość bezwzględna t: {0}", wb);

            }
            Console.Clear();

            //Cwiczenie 8.4

            int x1 = 2, y1 = 3, x2 = 1, y2 = 2;
            Console.WriteLine("Punkt A ma współrzedne:\nx = {0}\ny = {1}\nPunkt B ma współrzedne: \nx = {2}\ny = {3}", x1, y1, x2, y2);

            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("Punkty mają te same współrzedne");

            }
            else if (x1 == x2)
            {
                Console.WriteLine("Linia przechodzaca przez punkt A i B jest prostopadła do osi OX");
            }
            else if (y1 == y2) 
            {
                Console.WriteLine("Linia przechodzaca przez punkt A i B jest prostopadła do osi OY");

            }
            else
            {
                Console.WriteLine("Linia przechodzaca przez punkt A i B nie jest prostopadła do osi");

            }
            Console.Clear();

           







            Console.ReadKey();
        }
    }
}
