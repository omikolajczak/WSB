using System;

namespace rozdzial_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hej");
            }
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[i = {0}]", i);
            }
            Console.Clear();

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("hej");
                j++;
            }
            Console.Clear();

            int k = 0;
            do
            {
                Console.WriteLine("k = {0}", k);
                // najpierw instukcja potem warunke czyli < 10 to 11 razy, gdyby tu bylo k ++
            } while (k++ < 9);
            Console.Clear();

            int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int wartosc in tab)
            {
                Console.WriteLine(wartosc);
            }
            Console.Clear();

            //Cwiczenie 10.1

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Clear();

            //Cwiczenie 10.2

            int l = -1;
            while (l++ < 9)
            {
                Console.WriteLine("Pętle w C#");
            }
            Console.Clear();

            //Cwiczenie 10.3

            int liczna =1;
            while (liczna++ < 20)
            {
                if (liczna % 3 == 0)
                {
                    Console.WriteLine(liczna);
                }
            }
            Console.Clear();

            //Cwiczenie 10.4

            int m = 0;
            do
            {
                Console.WriteLine("m = {0}", m);
                
            } while (m++ <= 8);





            Console.ReadKey();

        }
    }
}
