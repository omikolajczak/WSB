using System;

namespace Macierz
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma elementow powyzej glownej przekatnej jest wieksz niz suma elementow ponizej
            //uzytkownik podaje wymiar macierzy
            //dodac dolne do siebie wyklucz i,i
            //dodac gorne do siebie wyklucz i,i
            //sprawdzic ktore wieksze

            Console.WriteLine("Podaj stopien macierzy");
            int stopien = int.Parse(Console.ReadLine());
            int[][] macierz = new int[stopien][];
            int dolna = 0;
            int gorna = 0;
            for (int i = 0; i < macierz.Length; i++) // utworzenie dlugosci kazdego wiersza w tablicy
            {
                macierz[i] = new int[stopien];
            }
            
            
            for (int i = 0; i < macierz.Length; i++) // przypisanie wartości do tablicy
            {
                for (int j = 0; j < macierz.Length; j++)
                {
                    Console.Write("Podaj wartość [{0}][{1}]: ", i+1,j+1);
                    macierz[i][j] = int.Parse(Console.ReadLine());
                }
            }
            //Console.WriteLine(macierz[2][1]); to jest wartosc w cw [3][2]
            for (int i = 0; i < macierz.Length; i++)//liczenie dolnej macierzy
            {
                for (int j = 0; j < macierz.Length; j++)
                {
                    if (i==j)
                    {
                        break;
                    }
                    else
                    {
                        dolna = dolna + macierz[i][j];
                    }
                }
            }
            Console.WriteLine("Macierz Dolna wynosi: {0}", dolna);

            //gorna zaczne ze i = macierz.length

            for (int i = macierz.Length-1; i >-1 ; i--)//liczenie dolnej macierzy
            {
                for (int j = macierz.Length-1; j > -1; j--)
                {
                    if (i == j)
                    {
                        break;
                    }
                    else
                    {
                        gorna = gorna + macierz[i][j];
                    }
                }
            }

            Console.WriteLine("Macierz górna wynosi {0}", gorna);
            if (dolna>gorna)
            {
                Console.WriteLine("Macierz dolna jest większa od górnej");
            }
            else if (dolna==gorna)
            {
                Console.WriteLine("o kurwa jebać zasady matematyki");
            }
            else
            {
                Console.WriteLine("Macierz górna jest większa od dolnej");
            }


            Console.ReadKey();
        }
    }
}