using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // zadanie 15.4-15.6 Powinno zostać wykonane za pomoca referencji ale ich nie ogarniam wiec zrobilem po swojemu, imo troche blednie refy do podszkolenia
    class Dzialania
    {
        int x;
        int y;
        int wynik;

       public int Dodawanie()
        {
            wynik = x + y;
            return wynik;
        }
        public int Odejmowanie()
        {
            wynik = x - y;
            return wynik;
        }
        public void Wyswietlanie_Dodawania()
        {
            Console.WriteLine("Wynik Dodawanie to: {0}", Dodawanie());
        }
        public void Wyswietalnie_Odejmowania()
        {
            Console.WriteLine("Wynik Odejmowania to: {0}", Odejmowanie());
        }
        public int ZamianaDodawaniaX_Wynik()
        {
            x = Dodawanie();
            return x;
        }
        public int ZamianaDodawaniaWynik_X()
        {
            wynik = x;
            return wynik;
        }

        public int ZamianaOdejmowaniaX_wynik()
        {
            x = Odejmowanie();
            return x;
        }
        public int ZamianaOdejmowaniaWynik_X()
        {
            wynik = x;
            return wynik;
        }
        public void WyswietlanieDodawania()
        {
            Console.WriteLine("Wynik dodawania to: {0}", Dodawanie());
        }
        public void WyswietlenieOdejmowania()
        {
            Console.WriteLine("Wynik odejmowania to: {0}", Odejmowanie());
        }
        
    

        //niech bedzie wybor czy pierwsze czy drugie czy oba na raz wtedy pokaze zamienione oraz prawdziwy wynik
        static void Main()
        {
            Dzialania dzialania = new Dzialania();
            dzialania.x = 100;
            dzialania.y = 200;

            Console.WriteLine("Ktora opcje wybierasz?");
            Console.WriteLine("1. Zwykle\n2. Zamiana\n3. Oba jednoczesnie");
            int Wybor_glowny = int.Parse(Console.ReadLine());
            if (Wybor_glowny == 1)
            {
                Console.WriteLine("Ktore dzialanie chcesz wykonac?");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                int wybor = int.Parse(Console.ReadLine());

                if (wybor == 1) dzialania.WyswietlanieDodawania();
                else dzialania.WyswietlenieOdejmowania();
            }
            else if (Wybor_glowny == 2)
            {
                Console.WriteLine("Ktore dzialanie chcesz wykonac?");
                Console.WriteLine("1. Dodawanie\n2. Odejmowanie");
                int wybor = int.Parse(Console.ReadLine());
                if (wybor == 1)
                {
                    Console.WriteLine("Wynik : {0}", dzialania.ZamianaDodawaniaWynik_X());
                    Console.WriteLine("Zmienna : {0}", dzialania.ZamianaDodawaniaX_Wynik());
                }
                else
                {
                    Console.WriteLine("Wynik : {0}", dzialania.ZamianaOdejmowaniaWynik_X());
                    Console.WriteLine("Zmienna: {0}", dzialania.ZamianaOdejmowaniaX_wynik());
                }
            }
            else if (Wybor_glowny == 3)
            {
                Console.WriteLine("Ktore dzialanie chcesz wykonac?");
                Console.WriteLine("1.Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                int wybor = int.Parse(Console.ReadLine());

                if (wybor == 1)
                {
                    dzialania.WyswietlanieDodawania();
                    Console.WriteLine("Wynik : {0}", dzialania.ZamianaDodawaniaWynik_X());
                    Console.WriteLine("Zmienna : {0}", dzialania.ZamianaDodawaniaX_Wynik());
                }
                else
                {
                    dzialania.WyswietlenieOdejmowania();
                    Console.WriteLine("Wynik : {0}", dzialania.ZamianaOdejmowaniaWynik_X());
                    Console.WriteLine("Zmienna: {0}", dzialania.ZamianaOdejmowaniaX_wynik());
                    
                }
                
            }

            
            
            Console.ReadKey();
        }


    }


}
