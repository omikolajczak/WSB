using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcin_Lis_3_Rozdział
{
    class Program
    { //metodanai zwracania wyswietlania nadawania
        class Punkt
        {
            int x;
            int y;
            string wynik;
            class Prostokat
            {
                Punkt LewyGorny = new Punkt();
                Punkt LewyDolny = new Punkt();
                Punkt PrawyGorny = new Punkt();
                Punkt PrawyDolny = new Punkt();
                Punkt prawda = new Punkt();
                Punkt falsz = new Punkt();

                int PobierzLewyGornyX()
            {
                return LewyGorny.x;
            }
            int PobierzLewyGornyY()
            {
                return LewyGorny.y;
            }
            int PobierzPrawyGornyX()
            {
                return PrawyGorny.x;
            }
            int PobierzPrawyGornyY()
            {
                return PrawyGorny.y;
            }
            int PobierzLewyDolnyX()
            {
                return LewyDolny.x;
            }
            int PobierzLewyDolnyY()
            {
                return LewyDolny.y;
            }
            int PobierzPrawyDolnyX()
            {
                return PrawyDolny.x;
            }
            int PobierzPrawyDolnyY()
            {
                return PrawyDolny.y;
            }

            bool SprawdzanieProstokata()
                {
                    if ((PobierzLewyGornyX() != PobierzLewyDolnyX()) |
                        (PobierzPrawyGornyX() != PobierzLewyGornyX()) |
                        (PobierzPrawyGornyY() != PobierzPrawyDolnyY()) |
                        (PobierzLewyGornyY() != PobierzLewyGornyY()))
                    {
                        return false;
                    }
                    else return true;
                }
            string ZamianaBoolaWStringa()
                {
                    if (SprawdzanieProstokata() != false)
                    {
                        return prawda.wynik;
                    }
                    else return falsz.wynik;
                }

                
            void WyswietalnieDanych()
            {
                Console.WriteLine("Lewy Gorny x wynosi = " + PobierzLewyGornyX());
                Console.WriteLine("Lewy Gorny y wynosi = " + PobierzLewyGornyY());
                Console.WriteLine("Lewy Dolny x wynosi = " + PobierzLewyDolnyX());
                Console.WriteLine("Lewy Dolny y wynosi = " + PobierzLewyDolnyY());
                Console.WriteLine("Prawy Gorny x wynosi = " + PobierzPrawyGornyX());
                Console.WriteLine("Prawy Gorny y wynosi = " + PobierzPrawyGornyY());
                Console.WriteLine("Prawy Dolny x wynosi = " + PobierzPrawyDolnyX());
                Console.WriteLine("Prawy Dolny y wynosi = " + PobierzLewyGornyY());
                Console.WriteLine("UWAGA UWAGA = {0}", ZamianaBoolaWStringa());

            }
            
            
                public static void Main()
                {
                    Prostokat prostokat = new Prostokat();
                    prostokat.LewyDolny.x = 100;
                    prostokat.LewyDolny.y = 100;
                    prostokat.LewyGorny.x = 100;
                    prostokat.LewyGorny.y = 100;
                    prostokat.PrawyGorny.x = 100;
                    prostokat.PrawyGorny.y = 100;
                    prostokat.PrawyDolny.x = 100;
                    prostokat.PrawyDolny.y = 100;
                    prostokat.prawda.wynik = "Figura jest prostokątem";
                    prostokat.falsz.wynik = "Figura nie jest prostokątem";
                    

                    prostokat.WyswietalnieDanych(); //wywołanie funkcji void odbywa się za pomocą wywołania klasa."void"

                    Console.ReadKey();

                }
            }



        }
    }
}
