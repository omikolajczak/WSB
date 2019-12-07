using System;

namespace Podstawy_Programowania_24._11._2019
{
    class Program
    {
        /*
        static void Main(string[] args)
        {

            int x;
            Increment(out x);
            Increment(out x);
            Increment(out x);
            Console.WriteLine("zmienna x przed wywolanie funkcji: {0}" , x);

            Console.ReadKey();
        }

        static void Increment(out int x) // przy out funkcja mimo wielkorotnego wywołania zmienia swoje wartości rozpoczynając od zera czyli
            // nie zrobi jak ref ktory bedzie prosił o ponowne przeliczenie
        {
            x = 1;
            x += 10;
            Console.WriteLine("zmienna x wewnatrz funkcji: {0}", x);
        }
        */

        /*
    static void Main(string[] args)
    {
        int[] tab = new int[2];
        tab[0] = 5;
        tab[1] = 10;
        Console.WriteLine("tablica przed wywolanie funkcji: {0} {1}", tab[0], tab[1]);
        Tab(tab);
        Console.WriteLine("wartosci tablicy po wywolaniu funkcji {0} {1}", tab[0], tab[1]);


        Console.ReadKey();
    }

    static void Tab(int[] tab)
    {
        tab[0] = 50;
        tab[1] = 100;

        Console.WriteLine("wartosci wewnetrzne funkcji: {0} {1}", tab[0], tab[1]);
    }
    */
    //funkcje 7
    /*
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("tablica przed wywolanie funkcji: {0} {1}", tab[0], tab[1]);
            Tab(ref tab);
            Console.WriteLine("wartosci tablicy po wywolaniu funkcji {0} {1}", tab[0], tab[1]);
            ShowTab(tab);

            Console.ReadKey();
        }

        static void Tab(ref int[] tab)
        {
            tab = new int[2];
            tab[0] = 50;
            tab[1] = 100;

            Console.WriteLine("wartosci wewnetrzne funkcji: {0} {1}", tab[0], tab[1]);
        }
        

        static void ShowTab( int[] tab)
        {

            for (int i = 0; i <tab.Length; i++)
            {
                Console.WriteLine("wartosc {0} w tablicy {1}", i, tab[i]);
            }

        }
        */


    }
}
