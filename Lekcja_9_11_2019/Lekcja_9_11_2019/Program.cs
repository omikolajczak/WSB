
using System;


namespace Lekcja_9_11_2019
{
    class Program
    {
        static void Main(string[] args) // jeśli pisze w cw wpierw jest {2} potem {1} potem {0} nie odwrotnie
            //wartości pdoaje się od zera przykład w pętli foreach
        {

            /*
            int[] tab = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

            for (int i=0; i<tab.Length; i++)
            {

                Console.Write("zmienna numer {0}: ", i+1);
                Console.WriteLine("{0}", tab[i]);

            }
            int elem = 1;
            foreach (int item in tab) // zawsze wyswietli całą tablice coś ala tab.lenght
            {
                Console.Write("element {1}: {0} ", item, elem); // wpierw wartość 1 czyli elem póżniej 0 czyli item jakby sie składało powoli 
                elem++;
            }

            //użytkowanik podaje z klawiatury 3 swoje ulubione kolory 
            //przypisz je do tablicy i wyświetl na ekranie w formacie 
            //kolor 1: ...
            //kolor 2: ...
            // do przypisania kolorów do tablicy wykorzystaj pętle for
            // do wyświetlenie kolorów z tablicy wykorzystaj pętle while
            */

            /*
             
            string[] kolory = new string[3];
            for (int i = 0; i < kolory.Length; i++) {


                Console.WriteLine("Nawiń kolory wariacie");
                kolory[i] = Console.ReadLine();

            }
            int j = 0;
            while (j<kolory.Length)
            {
                Console.WriteLine("Kolor {1}: {0}", kolory[j], j + 1);
                j++;
            }

            */

            //tablica prostokatna
            /*
            int[,] tab = new int[,] {
                {1, 2,3,4 },
                {5, 6,7,8 },
                {9, 10,11,12 },
                {13, 14,15,16 },
            };
            //tab.lenght //oznacza ilsoc elementow w tablicy
            //tab.getlength(wymiar tablicy np wiersze) pokazuje ilosc elementow w tym wymiarze
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0}\t ", tab[i,j]);
                }
                Console.WriteLine();
            }
            */
            int[][] tab = new int[3][]
            {
                new int[] {1,2 },
                new int[] {3,4 },
                new int[] {5,6, 7, 8 },
            };

            //wyswietl zawartosc tablicy za pomoca 2 petli for
            int licznik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }






            Console.ReadKey();

        }
    }
}
