using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcin_Lis_csharp_lekcja_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(" /---\\  |----\\  /----\\\n|     | |    |  |\n|     | |    /  |\n|-----| |----   |" +
                "\n|     | |    \\  |\n|     | |    |  |\n|     | |----/  \\----/");
            */
            //Console.WriteLine("111\t+\t222\t=\t333\n +\t\t +\t\t +\n333\t+\t444\t=\t777\n =\t\t =\t\t =\n444\t+\t666\t=\t1110");
            /*int a = 15, b = 4, c = 2, wynik;
            wynik = (a % b) % c;
            Console.WriteLine(wynik);*/
            /*int wartosc = 256;
            Console.WriteLine(wartosc<<2);
            Console.WriteLine(wartosc>>2);
            */
            /*int wartosc1=100, wartosc2=200;
            Console.WriteLine(wartosc1&wartosc2);
            Console.WriteLine(wartosc1|wartosc2);
            */
            /* int wartosc1 = 100, wartosc2 = 200, wartosc3, wartosc4;

            wartosc3 = (wartosc1 ^ wartosc2);
            wartosc3 = (wartosc1 ^ wartosc2);
            Console.WriteLine(wartosc3);
            */
            /*int jeden = 1, dwa = 1, cztery;
            int trzy = 1;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);

            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);

            Console.WriteLine(trzy); //mozna zrobic inaczej/lepiej wrocic do tego
            Console.WriteLine(trzy<<2);
            trzy = trzy << 3;
            Console.WriteLine(--trzy);
            trzy++; trzy++; trzy++;
            Console.WriteLine(trzy);
            
            trzy++;trzy++;trzy++;
            Console.WriteLine(trzy);
            */

            /*int liczba1 =150, liczba2= 100; // ćw 7,6 do poprawy nie um
            liczba1 = liczba2;
            Console.WriteLine(liczba1);
            liczba2 = liczba2 ^ liczba1;
            Console.WriteLine(liczba2);
            */
            //ćwiczenie 8.1 
            /*int a = 5, b= 3;
            if (a % b!=0)
            {
                Console.WriteLine("Reszta z dzielenia nie wynosi 0");
            }
            else
            {
                Console.WriteLine("Reszta z dzielenia wynosi 0");
            }
            */
            //ćwiczenie 8.2 mozna zmodyfikowac aby uztykownik sam wybieral z menu jakie dane posiada i na bazie tego wyliczac rozwiazanie
            /*float x, a=2, b=3, c=4, wynik;
            wynik  = a + b + c;
            x = wynik;
            if (x>=0)
            {
                Console.WriteLine("Rozwiązanie równiania znajduje sie w zbiorze liczb rzeczywistych");
            }
            else
            {
                Console.WriteLine("Rozwiązanie równiania nie znajduję sie w zbiorze liczb rzeczywistych");
            }
            */
            //ćw 8.3, po przerobieniu
            /*
            double zmienna = 10;
            Console.WriteLine("Podaj wartość zmiennej aby użyc na niej wartości bezwzględnej");
            string zmienna_ = Console.ReadLine();
            double.TryParse(zmienna_, out zmienna);
            if  (zmienna<0)
            {
                zmienna = zmienna * -1;
                Console.WriteLine("Wartość zmiennej po przekształceniu wynosi {0}", zmienna);
            }
            else
            {
                Console.WriteLine("Wartosc zmiennej jest dodatnia i wynosi {0}", zmienna);
            }
            */
            //ćwiczenie 8.4
            int a1 = 2, a2 = 2, b1 = 3, b2 = 3;



            
            Console.ReadKey();
        }
    }
}
