using System;

namespace Struktury
{
    class Program
    {
        /*
        public struct Punkt
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt(); // niejawnie przypisał wartpść zero dla y
            Punkt punkt2;
            punkt1.x = 100;
            punkt2.x = 100;



            Console.WriteLine("Punkt x wynosi {0}", punkt1.x);
            Console.WriteLine("Punkt y wynosi {0}", punkt1.y); // brak przypisanie i nadanie wartosci 0
            
            
            Console.WriteLine("Punkt y wynosi {0}", punkt2.x); 
            //Console.WriteLine("Punkt y wynosi {0}", punkt2.y); 

            Console.ReadKey();
        }
        */


            public struct Punkt
        {
            public int x;
            public int y;

            public Punkt(int wspX, int wspY)
            {
                x = wspX;
                y = wspY;
            }
        }

        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt(10, 20);
            Console.WriteLine("punkt 1 x wynosi: {0}", punkt1.x);
            Console.WriteLine("punkt 1 y wynosi: {0}", punkt1.y);

            Console.ReadKey();
            // na kolosie funkcje
        }
    }
}
