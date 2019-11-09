using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice2
{
    class Program
    {
        static void Main(string[] args)
        {

            //tablica prostokatna

            int[,] tab = new int[,] {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
             };


            //Console.WriteLine(tab.Length); //16
            //Console.WriteLine(tab.GetLength(0)); //4 wiersze
            //Console.WriteLine(tab.GetLength(1)); //4 kolumny

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0}\t", tab[i,j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
