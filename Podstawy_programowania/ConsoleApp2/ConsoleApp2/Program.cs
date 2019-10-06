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

             
            

            //użytkownik podaje liczbę z klawiatury


            string str;
            int liczba;

            Console.WriteLine("Podaj liczbę ");
            str = Console.ReadLine();

            //liczba = int.Parse(str);

            if (int.TryParse(str, out liczba) == false)
            {
                Console.WriteLine("Podałeś błędne dane!");
            }

            else
                {
                
                Console.WriteLine("Liczba wynosi {0}", liczba);
            
                }


            Console.Clear();

            /*
             * Sprawdź, czy dane podane z klawiatury są liczbą całkowitą dodatnią
             * Sprawdź, czy liczba jest nieparzysta
             */

            string str1;
            uint liczba1;

            Console.Write("Podaj liczbę całkowitą dodatnią: ");
            str1 = Console.ReadLine();

            if (uint.TryParse(str1, out liczba1) == true)
                {

                if(liczba1 % 2 != 0)
                    {
                    Console.WriteLine("Liczba jest nieparzysta");
                    }
                else
                    {
                    Console.WriteLine("Liczba jest parzysta");

                    }
                }
            else
                {
                 Console.WriteLine("Podałeś błędne dane o wartości: {0}", str1);   
                }


            /*
             * Użytkownik podaje z klawiatury dane dwóch boków
             * Oblicz pole prostokąta i obwód
             * 
             * Wyświetl w formacie:
             * 
             * 
             * 
             * 
             * 
             * 
             */

            Console.Clear();

            byte age2 = 18;

            if(age2 == 18)
                { 
                Console.WriteLine("Masz 18 lat");
                }
            else if (age2 < 18)
                { 
                Console.WriteLine("Jesteś niepełnoletni");
                }
            else
                { 
                Console.WriteLine("Jesteś pełnoletni");
                Console.WriteLine("Masz {0} lat", age2);
                }

            Console.Clear();

            //switch

            liczba = 20;
            switch(liczba)
                {
                    case 10:
                    Console.WriteLine("Liczba równa 10");
                    break;
                    case 20:
                    Console.WriteLine("Liczba równa 20");
                    break;
                    default:
                    case 30:
                    Console.WriteLine("Liczba równa 30");
                    break;
                }

            Console.Clear();

            /*
             * Napisz program, który ma następujące menu
             * 
             * a - Pole kwadratu
             * b - Pole prostokąta
             * 
             * 
             * Wykorzystaj instrukcje switch
             * Zabezpiecz dane przed podaniem błędnych danych do obliczeń
             * 
             * 
             */

            Console.WriteLine("a - Pole kwadratu");
            Console.WriteLine("b - Pole prostokąta");

            Console.WriteLine("Wybierz jedąc z opcji:");

            string znak = Console.ReadLine();

            string bokA = Console.ReadLine();
            
            double x;
            double pole;
          
            Console.Clear();
            switch(znak)
                {
            
                    case "a":
                        Console.WriteLine("Obliczanie pola kwadratu");  
                        
                        Console.WriteLine("Podaj bok a");
                        
                        if(double.TryParse(bokA, out x))

                            {
                                pole = x * x;
                                Console.WriteLine("Podane pole wynosi: {0}", pole);

                            }

                        break;

                    case "b":
                        Console.WriteLine("Oblicznie pola prostokąta");

                        Console.WriteLine("Podaj bok a:");
                        string a2 = Console.ReadLine();

                        Console.WriteLine("Podaj bok b:");
                        string b = Console.ReadLine();

                        if(double.TryParse(bokA, out a2) && double.TryParse(bokB, out b);

                        {
                        pole1 = a2 *b;
                        Console.WriteLine("Podane pole wynosi: {0}", pole1);
                        }

                    else {
                    Console.WriteLine("Podałeś błedne dane");
                        }
                        break;
                                        
                }
                   
            Console.Clear();





            Console.ReadKey();
        }
    }
}
