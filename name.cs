using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            add(2, 3);

            int c = 5;
            int d = 10;

            add(c, d);
            add(c, d, 5);
            Console.WriteLine("Wynik pola: {0}", SquareArea(10));
            Console.WriteLine("{0}", Add(1, 2, c = 1, d = 2));

            data("Janusz");


            Console.WriteLine("{0}", CheckEven());


            Console.ReadKey();
        }


        static void add(int a, int b)
        {
            int result = a + b;

            Console.WriteLine("Wynik dodawania: {0}", result);
        }

        static void add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("Wynik dodawania: {0}", result);

        }


        static int SquareArea(int a)
        {
            return a * a;

        }

        static int Add(int c, int d, int a = 5, int b = 10)
        {
            return a + b + c + d;

        }

        static void data(string name, string surname = "Nowak", int age = 30)
        {
            Console.WriteLine("Imię: {0}, nazwisko: {1}, wiek: {2}", name, surname, age);

        }

     

        static string CheckEven(int a)
            {
            while (true)
            {
                
                a mod 10 = b;
            }


            }

    }


}
