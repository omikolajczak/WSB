using System;


namespace Zadanie_lab1_z_moodle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            string x_, y_;
            
            Console.WriteLine("Podaj pierwszy bok prostokąta");
            x_ = Console.ReadLine();
            Console.WriteLine("Podaj drugi bok prostokąta");
            y_ = Console.ReadLine();
            x = double.Parse(x_);
            y = double.Parse(y_);
            z = x * y;
            Console.WriteLine("Pole twojego prostokąta wynosi\n{0}", z);
            
            Console.Clear();
            double dolar, zloty;
            string strzloty;
            Console.WriteLine("Podaj ilość PLN, którą chcesz przeliczyć na dolary: ");
            strzloty = Console.ReadLine();
            zloty = double.Parse(strzloty);
            dolar = zloty*0.25399;
            Console.WriteLine("Wartość w dolarach: {0}", dolar);
            
            Console.Clear();
            double a, b, c, x1, y;
            string a_, b_, c_, x1_;
            Console.WriteLine("Podaj wartość a");
            a_ = Console.ReadLine();
            Console.WriteLine("Podaj wartość b");
            b_ = Console.ReadLine();
            Console.WriteLine("Podaj wartość c");
            c_ = Console.ReadLine();
            Console.WriteLine("Podaj wartość x");
            x1_ = Console.ReadLine();
            a = double.Parse(a_);
            b = double.Parse(b_);
            c = double.Parse(c_);
            x1 = double.Parse(x1_);
            y = a * (x1 * x1) + (b * x1) + c;
            Console.WriteLine("Wartość y wynosi: " + y);
            // reszta syf/nie potrafię wykonac np. kółko i krzyżyk.
            
           

            Console.ReadKey();
        }
    }
}
