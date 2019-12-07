using System;
using obliczenia;

namespace nr5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int c = 4;
            Mathclass x = new Mathclass();
            Console.WriteLine(x.Prostokat(a,b));
            Console.WriteLine(x.Kwadrat(a));
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
