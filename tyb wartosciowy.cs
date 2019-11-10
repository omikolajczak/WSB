using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ wartościowy
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
            tabA[1] = 200;


            Console.WriteLine("tabA");

            foreach (int item in tabA)
            {
                Console.WriteLine("{0} ", item);
            }
            Console.WriteLine("\n\ntabB");

            foreach (int item in tabB)
            {
                Console.WriteLine("{0} ", item);
            }

            

            string text1 = "10";
            string text2 = text1;

            text1 += "Janusz";

            Console.WriteLine(text1); //10Janusz
            Console.WriteLine(text2); //10





            Console.ReadKey();

        }
    }
}
