using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Imię:"); //wyswietlanie imienia
            Console.WriteLine(" Gosia");
            Console.WriteLine();
            /*
             * 
             * koment wiele linii
             */

            Console.WriteLine("#"); //1 opcja
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");

            Console.WriteLine("\n#\n##\n###\n####");  //2 opcja szybsza

            string name;
            name = "janusz";

            // + oznacza konkatencje
            Console.WriteLine("\nMasz na imie: " + name);

            Console.WriteLine("Masz na imie: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imie: {0}, wiek {1}", name, age);

            sbyte age1 = 25;
            Console.WriteLine("Masz na imie: {0}, wiek {1}", name, age1);
            /*
             * uzytkownik podaje z klawiatury długość boku oblicz pole kwadratu */


            Console.Write("Podaj bok a: ");
            string a = Console.ReadLine();
            // Console.WriteLine("bok a: {0}", a);

            double result = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            /*
             *oblicz pole trójkąta 
             * dane podaje użytkownik z klawiatury
             */


            Console.ReadKey();
        }
    }
}
