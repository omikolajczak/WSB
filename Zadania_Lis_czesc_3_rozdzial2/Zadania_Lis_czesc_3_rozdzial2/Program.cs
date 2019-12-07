using System;

namespace Zadania_Lis_czesc_3_rozdzial2
{
    class Program
    {
        static void Main(string[] args)
        {

            //problem znajduje sie w 177-187
            //ćwiczenie 11.1
            /*
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0) { }
                else continue;
                Console.WriteLine(i);
                
            }
            */
            /*
            int i = 0; //ćwiczenie 11.2
            while(i<20)
            {
                ++i;
                if (i % 2 != 0) { }
                else continue;
                Console.WriteLine(i);
            }
            */
            //ćwiczenie 11.3
            /*
            int i = 100, j = 100;
            for(;i>1;i--)
            {
                  if (i % 3 != 0) continue;
                   else if (i % 4 != 0) { Console.WriteLine(i); }
            }
           
            while (j>1)
            {
                j--;
                if ((j % 3 != 0) == true) { }
                else if (j % 4 != 0) { Console.WriteLine(j); }
            }
            */
            /*
            int i = -100; //ćwiczenie 11.4
            for (; i <100; i++)
            {
                if (i % 4 != 0) { }
                else if ((i % 8 != 0) == false) continue;
                else if (i % 10 != 0) { Console.WriteLine(i); }
            }
            */
            /* 
            for (int i=1;i<=20;i++) //ćwiczeniee 11.5
            {
                if (i % 2 != 0) { }
                else
                Console.WriteLine("{0}", i);
            }
            */
            //ćwiczenie 11.6
            /*
            int i = 0, k=0; //przykład a
            for (;i<=20;i++)
            {
                Console.WriteLine();
                k++;
                for (int j = 20; j >= k; j--)
                {
                    Console.Write("{0}  ", j);
                    
                }
            }
            */
            /*
            int i = 0;
            int k = 0;
            while (i < 20)
            {
                i++;
                k++;
                Console.WriteLine();
                int j = 21; //wartosc okreslajac dlugosc ciagu

                while (j >= k) 
                {
                    --j;
                    Console.Write(" {0}  ", j);
                    if (j==k)
                    {
                        break;
                    }
                }
                
            }   
            */
            //tablice
            //ćwiczenie 12.1
            /*
            int[] tablica = new int[110];
            for (int i=101; i<tablica.Length;i++)
            {
                tablica[i] = i;
            }
            for (int i=101; i<tablica.Length;i++)
            {
                Console.WriteLine("Tablica [{0}] = {1}", i, tablica[i]);
            }
            */
            //ćwiczenie 12.2
            /*
             int[] tablica = new int[110];
            for (int i=10;i<tablica.Length;i+=10)
            {
                tablica[i] = i;
            }
            for(int i=10;i<tablica.Length;i+=10)
            {
                Console.WriteLine("tab[{0}] = {1}",i/10, tablica[i]);
            }
            */
            /*
             *
             * 
             //ćwiczenie 12.3
            bool[] tablica = new bool[20];
            for (int i=0; i<tablica.Length;i++)
            {
                if (i%2!=0)
                {
                    tablica[i] = false;
                    Console.WriteLine("chuj");
                }
                else
                {
                    tablica[i] = true;
                    Console.WriteLine("git");
                }
            }
            */
            /*
            
            //ćwiczenie 12.4
            int[] tablica = new int[101]; //próba zrobienia pętli nie powiodła się, spróbować w przyszłości
            for (int i = 0; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); } 
            Console.WriteLine();
            for (int i = 1; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 2; i<tablica.Length; i+=10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 3; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 4; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 5; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 6; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 7; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 8; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            Console.WriteLine();
            for (int i = 9; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i]); }
            */

            //ćwiczenie 12.5
            //polecie: Utwórz 26-elementową tablicę typu char, zapisz w kolejnych jej komórkach małe litery alfabetu od a do z
            //pierwsze rozwiazanie minimum wielkosc tablicy 123, czemu? (Zapytać wykładowce)
            /*
            char[] tablica = new char[123];
            for (char a='a'; a<='z'; a++)
            {
                tablica[a] = a; Console.WriteLine(a);
            }
            */

            //ćwiczenie 12.6
            //int[] tablica = new int[10];
            /*
            int i = -1;
                while (i < tablica.Length)
                {
                if (i==tablica.Length-1)
                     {
                    break;
                     }
                else
                    {
                    i++;
                    tablica[i] = i;
                    Console.WriteLine("Tablica [{0}] = {1}", i, tablica[i]);
                    }
                }
            */
            //tablice wielowymiarowe
            //ćwiczenie 13.1 //od 10-1
            /*           
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[2];
            tab[2] = new int[1];
            tab[3] = new int[3];
            int licznik = 10;
            for (int i=0; i<tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;//zmiana wartosci licznika odwaraca zasadę wykonywania działania
                }
            }

            for(int i=0;i<tab.Length; i++)
            {
                Console.Write("tab[{0}] = ", i);
                for(int j=0;j<tab[i].Length;j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }
            */
            //podgląd zad 13.2
            /*
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[3];
            tab[2] = new int[2];
            tab[3] = new int[1];
            int licznik = 1;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j=0; j<tab[i].Length;j++)
                {
                    tab[i][j]=licznik++;                
                }
            }
            for (int i=0;i<tab.Length;i++)
            {
                Console.WriteLine("tab[{0}] ",i);
                for (int j=0;j<tab[i].Length;j++)
                {
                    Console.WriteLine("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }
            */
            //6godzin czasu - zrobione (błąd banalny)
            /*
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[3];
            tab[2] = new int[2];
            tab[3] = new int[1];
            int licznik = 1, ai = 0, bj = 0; //dodanie zmiennych ai,bj
            while(ai<tab.Length)            //żeby zmienne inkrementowane nie przeszły na kolejną pętle
            {                               //dlatego trzeba użyć 4 zmiennych aby całość działała i nie kolidowała ze sobą
                bj = 0;
                while(bj<tab[ai].Length)
                {
                    tab[ai][bj] = licznik++;
                    bj++;
                }
                ai++;
            }
            
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("tab[{0}] ", i);
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }
            */

            //ćwiczenie 13.3
            /*
            int[][] tab = new int[4][];
            tab[0] = new int[1];
            tab[1] = new int[2];
            tab[2] = new int[3];
            tab[3] = new int[4];
            int licznik = 10;
            for (int i=0;i<tab.Length;i++)
            {
                for (int j = 0; j<tab[i].Length;j++)
                {
                    tab[i][j] = licznik--;
                }
            }
            for (int i=0;i<tab.Length;i++)
            {
                Console.Write("tab[{0}]  ", i);
                for(int j=0;j<tab[i].Length;j++)
                {
                    Console.Write("{0}  ", tab[i][j]);
                }
                Console.WriteLine();
            }
            */
            //ćwiczenie 13.4
            /*
             bool[][] tab = new bool[5][];//utworzenie tablicy o dlugosci 5 pozniej do tablicy przypisuje sie 8
             for (int i = 0; i < 5; i++)
             {
                 tab[i] = new bool[8]; //przypisanie do tablicy dlugosci 8 za pomoca petli (kazde z 5 dostanie wartosc 8
             }
             //parzyste indeksy wiersza i kolumny maja byc true
             bool prawda = true, falsz = false;
             for (int i = 0; i < tab.Length; i++)
             {
                 for (int j = 0; j < tab[i].Length; j++)
                 {
                     if (i % 2 != 0) 
                     {
                         if (j%2!=0) { tab[i][j] = falsz; }
                         else { tab[i][j] = prawda; }
                     }
                     else if (j%2!=0) { tab[i][j] = falsz; }
                     else { tab[i][j] = prawda; }
                 }
             }
             for (int i = 0; i < tab.Length; i++)
             {
                 Console.Write("tab[{0}]  ", i);
                 for (int j = 0; j < tab[i].Length; j++)
                 {
                     if (tab[i][j]==true) { Console.Write("1 "); }
                     else { Console.Write("0 "); }
                 }
                 Console.WriteLine();
             }
             */
            //ćwiczenie 13.5
            /*
            int[ , , ] tab = new int[3, 5, 4];
            tab[0, 0, 0] = 1;
            tab[0, 1, 0] = 2;
            tab[0, 2, 0] = 3;
            tab[0, 3, 0] = 4;
            tab[0, 4, 0] = 5;
            tab[1, 1, 1] = 2;
            tab[2, 2, 2] = 3;
            tab[2, 2, 3] = 4;
            for (int i=0; i < tab.GetLength(2);i++)
            {
                for (int j=0; j < tab.GetLength(1); j++)
                {
                    for (int k=0; k<tab.GetLength(0); k++)
                    {
                        Console.Write(tab[k,j,i]);
                    }
                    Console.WriteLine();
                }
            }
            */
            //przykład pomocniczny do 13.5
            /*
            int[ , , ] XD = new int[3, 5, 4];
            XD[0, 0, 0] = 1;
            XD[0, 1, 0] = 2;
            XD[0, 2, 0] = 3;
            XD[0, 3, 0] = 4;
            XD[0, 4, 0] = 5;
            XD[1, 1, 1] = 2;
            XD[2, 2, 2] = 3;
            XD[2, 2, 3] = 4;
            // Loop over each dimension's length.
            for (int i = 0; i < XD.GetLength(2); i++)
            {
                for (int y = 0; y < XD.GetLength(1); y++)
                {
                    for (int x = 0; x < XD.GetLength(0); x++)
                    {
                        Console.Write(XD[x, y, i]);
                    }
                    Console.WriteLine();
                }
            }
            */
            //ćwiczenie 13.6
            //10 wierszy ciagu, kazdy wiersz ma tyle cyfr ile ma liczb w ciagu malejacym ustawic.
            
            int[][] tab = new int[10][];
            tab[0] = new int[1];
            tab[1] = new int[1];
            tab[2] = new int[2];
            tab[3] = new int[3];
            tab[4] = new int[5];
            tab[5] = new int[8];
            tab[6] = new int[13];
            tab[7] = new int[21];
            tab[8] = new int[34];
            tab[9] = new int[55];
            
            for (int i = 0; i < tab.Length; i++)
            {
                int licznik = tab[i].Length;
                for (int j=0; j<tab[i].Length; j++)
                {
                    tab[i][j] = licznik;
                    licznik--;
                }

            }
            for (int i=0; i<tab.Length; i++)
            {
                Console.Write("numer tablicy: {0}  ", i);
                for (int j=0;j<tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }




            Console.ReadKey();
        }
    }
}
