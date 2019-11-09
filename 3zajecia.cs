using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabilce1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            int[] licz = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("{0}", tab[1]);

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Element {0}: {1}", licz[i],  tab[i]);
            }


            foreach (int item in tab)
            {
                Console.WriteLine("{0} ", item);
            }


            /*
             * uzytkownik wprowadza z klawiatury 3 swoje ulubione kolory
             * przypis je do tablicy i wyswietl na ekranie w formacie
             * kolor 1:...
             * kolor 2:...
             * do przypisania kolorw do tablicy wykorzystaj petle for
             * do wyswietlenia kolorow z taqblicy wykorzystaj petle white
             * 
             */

            string[] colors = new string[3];
            string color;

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Podaj kolor ");
                color = Console.ReadLine();
                colors[i] = color;
            }

            uint index = 0;
            uint count;

            while (index < colors.Length)
            {
                count=index + 1;
                Console.WriteLine("Kolor {0}: {1}", count, colors[index]);
                index++;
            }
           

            




            Console.ReadKey();
        }
    }
}
