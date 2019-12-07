using System;

namespace rozdzial_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1];
            tab[0] = 10;
            Console.WriteLine("Pierwszy element tablcy: {0}", tab[0]);
            Console.Clear();

            int[] tabl = new int[6] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("tabl[{0}] = {1}", i, tabl[i]);
            }
            Console.Clear();

            int[] tabli = new int[10];
            for (int i = 0; i < tabli.Length; i++)
            {
                tabli[i] = i;
            }
            for (int i = 0; i < tabli.Length; i++)
            {
                Console.WriteLine("tabli[{0}] = {1}", i, tabli[i]);
            }
            Console.Clear();

            //Cwiczenie 12.1

            int[] tablic = new int[10];
            int licznik = 0;
            for (int i = 101; i <= 110; i++)
            {
                tablic[licznik++] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tablic[{0}] = {1}", i, tablic[i]);
            }
            Console.Clear();

            //Cwiczenie 12.2

            int[] tablica = new int[10];
            int licznik1 = 0;
            for (int i = 10; i <= 100; i+= 10)
            {
                tablica[licznik1++] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tablicc[{0}] = {1}", i, tablica[i]);
            }
            Console.Clear();

            //Cwiczenie 12.3

            bool[] tablica1 = new bool[20];

            for (int j = 1; j < 20; j++)
            {
                if (j % 2 == 2)
                {
                    tablica1[j] = true;
                }
                else
                {
                    tablica1[j] = false;
                }
                for(int i = 0; j < 10; j++)
                {
                    Console.WriteLine("tablica1[{0}] = {1}", j, tablica1[j]);
                }
            }
            

        }

    }
}
