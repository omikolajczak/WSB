using System;


namespace Zadanie_domowe_6._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("Pole Prostokąta wynosi: " + sciana1 * sciana2); //obliczanie pola
                Console.WriteLine("Obwód Prostokąta wynosi: " + (sciana1 + sciana1 + sciana2 + sciana2)); //jedyne jakie potrafię
            }


            Console.ReadKey();
        }
    }
}
