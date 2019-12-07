using System;
namespace Zadanie_domowe_5._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *oblicz pole trójkąta 
            * dane podaje użytkownik z klawiatury
            */
            
            Console.WriteLine("Podaj wysokość trójkąta: ");
            string a = Console.ReadLine();
            Console.WriteLine("Podanie długości boku: ");
            string b = Console.ReadLine();
            double c = 0.5;

            double polowa_wyniku = double.Parse(a) * double.Parse(b);
            double wynik = polowa_wyniku * c;
            Console.WriteLine("Pole twojego trójkąta to: {0}", wynik);

            Console.ReadKey();
            







        }
    }
}
