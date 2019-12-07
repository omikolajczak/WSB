using System;
using second_name;


namespace Lekcja_10._11_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //kopiowanie tablic
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabcopy = new int[7];

            foreach (int item in tabcopy)
            {
                Console.Write("{0} ", item );
            }

            Console.WriteLine();
            //tab.CopyTo(tabcopy, 2); //od drugiego indeksu w tablicy masz wsadzic tą tablice 
            foreach (int item in tabcopy) // przy 2 bedzie 0 0 1 2 3 4 5
            {
                Console.Write("{0} ", item);
            }
            
            //Array.Copy(tab, tabcopy, tab.length)
            Array.Copy(tab, 0, tabcopy, 1 ,5); // skąd ma skopiować, od którego miejsca, do kąd, od kt zaczac, jak duzo znakow
            Console.WriteLine();
            foreach (int item in tabcopy) 
            {
                Console.Write("{0} ", item);
            }

            */
            //typy wartościowe i referencyjne
            //typ wartościowy

            /*
            int a = 10;
            int b = a;

            a--;
            b++;

            Console.WriteLine(a); //9
            Console.WriteLine(b); //11

            //typ referencyjny

            int[] tabA = { 1, 2, 3 };
            int[] tabB = tabA;

            tabA[0] = 100;
            tabB[1] = 200;

         //przez opcje copy to tworzy sie nowe miejsce w pamieci, przez operator wykorzystawana jest ta sama

            Console.WriteLine("\ntabA");
            foreach (int item in tabA)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine("\n\ntabB");
            foreach (int item in tabB)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
            string text1 = "10 ";
            string text2 = text1;

            text1 += "Janusz";

            Console.WriteLine(text1); //10 Janusz
            Console.WriteLine(text2); //10




            */

            /*
             
            //skróty klawiszowe ctrl d duplikacja, z altem przesuwanie
            Console.Title = "Modyfikacja Konsoli"; // zmiana nazwy konsooli u góry
            Console.WriteLine("WSB");
            Console.Clear(); // czyszczenie konsoli
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WSB");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tWSB\t");
            Console.ResetColor();
            Console.WriteLine("WSB");
            */
            /*
            //wyjątki numer 1
            // będzie ciągle powtarzac dopoki nie wyjdzie prawdiłowa liczba
             int Pętla = 2;
            uint Number =0; // jak nie bd dzialac przypisac wartosc 0
            string X;
            while (Pętla == 2) //przy while można używać true
            {
                Console.ResetColor();
                Console.Write("Podaj liczbe całkowita: ");
                X = Console.ReadLine();
                Pętla = 1;
            try
                {
                Number = uint.Parse(X);
                }
            catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError: {0}", e.Message);
                    Pętla = 2;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLiczba całkowita {0}", Number);
            */

            //namespace/ przestrzenie nazw

            //Console.WriteLine("wsb"); //bez using system trzeba dodac .system
            first_name.namespace_1 ob = new first_name.namespace_1();
            ob.Show();

            namespace_2 ob1 = new second_name.namespace_2();
            ob1.Show();

            Console.ReadKey();




        }
    }
}
namespace first_name
{
    class namespace_1
    {
        public void Show()
        {
            Console.WriteLine("Hello world");
        }
    }
}namespace second_name
{
    class namespace_2
    {
        public void Show()
        {
            Console.WriteLine("Hello world 2");
        }
    }
}

