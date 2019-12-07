using System;

namespace lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzytkownik podaje liczbe z klawiatury

            string liczba;
            int liczba_3 = 1;

            uint liczba_uint;
            
            Console.Write("Podaj liczbę całkowitą dodatnią: "); //zrobic
            liczba = Console.ReadLine();
            //liczba = int.Parse(str);


            if (uint.TryParse(liczba, out liczba_uint) == true)
            {
                if (liczba_uint % 2 != 0)
                {
                    Console.WriteLine("Twoja liczba: {0} jest nieparzysta ", liczba_uint);
                }
                else
                {
                    Console.WriteLine("Twoja liczba: {0} jest parzysta", liczba_uint);
                }
            }
            else
            {
                Console.WriteLine("Podałeś błędne dane o wartości : {0}", liczba);

            }
            
            
           byte age2 ;
           string age1;

           Console.WriteLine("Ile masz lat?");
           age1 = Console.ReadLine();
            byte v = age2 = byte.Parse(age1);
            

           if (age2 == 18)
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
           
           
           
            
           
           
           
            
            Console.WriteLine("a- Pole kwadratu\nb- Pole prostokąta");
            Console.WriteLine("Wybierz jedną z opcji:");

            string znak = Console.ReadLine();



            Console.Clear();

            switch (znak) 
            {
                case "a": //poprawne
                    Console.WriteLine("Obliczanie Pola kwadratu");
                    Console.WriteLine("Wpisz długość boku");
                    string strbok = Console.ReadLine();
                    double bok;
                    if (double.TryParse(strbok, out bok) == false)
                    {
                        Console.WriteLine("Podałeś złą wartość");
                    }
                    else
                    {
                        double strrbok = double.Parse(strbok);
                        Console.WriteLine("Pole kwadratu wynosi: " + strrbok * strrbok);
                    }


                    break;

                case "b":
                    Console.WriteLine("Obliczanie pola prostokąta"); //do poprawy
                    Console.WriteLine("Wpisz długość boku a");
                    string bok1 = Console.ReadLine();
                    double bok_1;
                    if (double.TryParse(bok1, out bok_1) == false)
                    {
                        Console.WriteLine("Podałeś złą wartość");
                    }
                    Console.WriteLine("Wpisz długość boku b");
                    string bok2 = Console.ReadLine();
                    double bok_2;
                    if (double.TryParse(bok2, out bok_2) == false)
                    {
                        Console.WriteLine("Podałeś złą wartość");
                    }
                    else
                    {
                        Console.WriteLine("Pole prostokąta wynosi: " + bok_1 * bok_2);
                    }


                    break;

            }

            
            //wyswietl liczby <1.15>
            
            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            /*
             * Uzytkownik podaje z klawiatury dane dwóch boków
             * oblicz pole prostokąta i obwód
             * 
             * Wyświetl w formacie:
             * Pole Prostokąta wynosi:
             * Obwód prostokąta wynosi:
             * 
             * Sprawdź czy dane z klawiatury są poprawne
             * W przypadku błędnych danych wyświetl na ekranie komunikat:
             * "Podałeś błędne dane!"
             */

            string sciana_1, sciana_2; // argumenty na górze algorytmu
            double sciana1, sciana2; 
            Console.WriteLine("Podaj wymiar pierwszego boku");
            sciana_1 = Console.ReadLine(); //czytanie pierwszego boku
            if (double.TryParse(sciana_1, out sciana1) == false) // spróbuj przekształcić string na double
            {
                Console.WriteLine("Podałeś błędne dane!"); // jeśli sie nie da odrzuć
            }
            Console.WriteLine("Podaj wartość drugiego boku");
            sciana_2 = Console.ReadLine();
            if (double.TryParse(sciana_2, out sciana2) == false) 
            {
                Console.WriteLine("Podałeś błędne dane!");
            }
            else //gdy inne odpadną
            { 
                Console.WriteLine("Pole Prostokąta wynosi: " + sciana1*sciana2); //obliczanie pola
                Console.WriteLine("Obwód Prostokąta wynosi: "+ (sciana1 + sciana1 + sciana2 + sciana2)); //jedyne jakie potrafię
            }    


            Console.ReadKey();

        }
    }
}
