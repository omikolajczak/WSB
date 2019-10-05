using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imię: ");            //wyświetli "Imię"
            Console.WriteLine("Kasia");

            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");

            Console.WriteLine("\n#\n##\n###\n####");



            /* komentarz
             * w wielu
             * liniach
             *
             */


            /*
             *  #
             *  ##
             *  ###
             *  ####
             */

            string name;
            name = "Jnausz";
            Console.WriteLine("\nMasz na imię: " + name);
            //+ konkaternacja

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imię: {0}, wiek: {1}", name, age);

            sbyte age1 = 127;

            Console.WriteLine("Masz na imię: {0}, wiek1: {1}", name, age1);




            /*
             * użytkownik podaje z klawiatury długość boku
             * Oblicz pole kwadratu
             */

            Console.WriteLine("Podaj bok a:");
            string a = Console.ReadLine();

            //Console.WriteLine("Bok a:{0}",a);

            double result = double.Parse(a) * double.Parse(a);

            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            /*
             * Oblicz pole trójkąta
             * dane podaje uytkownik z klawiatury
             *
             */



            Console.ReadKey();
        }
    }
}
