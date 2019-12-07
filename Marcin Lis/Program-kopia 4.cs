using System;

namespace rozdzial_11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("[i = {0}]", i);
                if (i ==9)
                {
                    break;
                }
            }
            Console.Clear();

            for (int j = 1; j <= 20; j++)
            {
                if (j % 2 != 0) continue;
                {
                    Console.WriteLine("{0} ", j);
                }
            }
            Console.Clear();

            //Cwiczenie 11.1

            for(int k = 1; k <= 20; k++)
            {
                if (k % 2 == 0) continue;
                {
                    Console.WriteLine("{0} ", k);
                }
            }
            Console.Clear();

            //Cwiczenie 11.2

            int l = 1;
            while (l++ < 20) 
            {
                if (l % 2 == 0) continue;
                {
                    Console.WriteLine("{0} ", l);

                }

            }
            Console.Clear();

            //Cwiczenie 11.3

            for (int m = 100; m > 1; m--)
            {
                if (m % 3 == 0 && m % 4 == 0) continue;
                {
                    Console.WriteLine("{0} ", m);
                }
            }




            Console.ReadKey();
        }
    }
}
