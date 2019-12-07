using System;

namespace rozdzial_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch
            int liczba1 = 2;
            int liczba2 = 1;
            switch (liczba1 *5 / (liczba2 + 1))
            {
                case 5 :
                    Console.WriteLine("liczba = 5");
                    break;
                case 15 :
                    Console.WriteLine("liczba = 15");
                    break;
                default:
                    Console.WriteLine("Liczba nie jest równa ani 5 ani 15");
                    break;
            }
            Console.Clear();

            //operator warunkowy
            int liczba = 10;
            int liczba3;
            liczba3 = liczba < 0 ? -1 : 1;
            Console.WriteLine(liczba3);
            Console.Clear();

            //Cwiczenie 9.1

            int liczba4 = 6;
            switch (liczba4)
            {
                case 0:
                    Console.WriteLine("liczba = 0");
                    break;
                case 1:
                    Console.WriteLine("liczba = 1");
                    break;
                case 2:
                    Console.WriteLine("liczba = 2");
                    break;
                case 3:
                    Console.WriteLine("liczba = 3");
                    break;
                case 4:
                    Console.WriteLine("liczba = 4");
                    break;
                case 5:
                    Console.WriteLine("liczba = 5");
                    break;
                case 6:
                    Console.WriteLine("liczba = 6");
                    break;
                case 7:
                    Console.WriteLine("liczba = 7");
                    break;
                default:
                    Console.WriteLine("Liczba nie jest równa 0...7");
                    break;
            }
            Console.Clear();

            //Cwiczenie 9.4

            int x = 10;
            int x1;

            if (x < 0)
            {
                x1 = -1;
                Console.WriteLine(x1);
            }
            else
            {
                x1 = 1;
                Console.WriteLine(x1);
            }
            Console.Clear();

            


        }
    }
}
