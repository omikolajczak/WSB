using System;

namespace Rozdział_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Clear();

            //Ćwiczenie 5.1
            short liczba = 1, liczba1 = 2;

            Console.WriteLine("liczba = {0} \nliczba1 = {1}", liczba, liczba1);
            Console.WriteLine("\" \\ "); //bez przetwarzania
            Console.WriteLine(@" \n "); //z przetwarzaniem

            string napis = @" \n ";
            Console.WriteLine(napis);
            Console.Clear();

            Console.Write(liczba);
            Console.Write(liczba1);
            Console.Write("liczba = {0} liczba1 = {1}", liczba, liczba1);
            Console.Clear();

            double zmienna1 = 14.5, zmienna2 = 24.45;

            //Ćwiczenie 6.1
            Console.Write("ziemnna1 = {0} \nziemnna2 = {1}", zmienna1, zmienna2);
            Console.Clear();

            //Ćwiczenie 6.2
            Console.WriteLine(" " +
                "/---\\ " +" |----\\ " +"/----\\" +
             "\n|     |" + " |    |" + " |" +
             "\n|     |" + " |    /" + " |" +
             "\n|-----|" + " |----" +  "  |" +
             "\n|     |" + " |    \\" + " |" +
             "\n|     |" + " |    |" + " |" +
             "\n|     |" + " |----/" + " \\----/");
            Console.Clear();

            //Ćwiczenie 6.3
            Console.WriteLine("111\t+\t222\t =\t333\n +\t\t +\t\t +\n333\t+\t444\t =\t777" +
                              "\n =\t\t =\t\t =\n444\t+\t666\t =\t1110");
            Console.Clear();


            int a = 10, b = 20, c;
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            c = b - a;
            Console.WriteLine("b - a = {0}", c);
            c = a / 2;
            Console.WriteLine("a / 2 = {0}", c);
            c = a * b;
            Console.WriteLine("a * b = {0}", c);
            c = a + b;
            Console.WriteLine("a + b = {0}", c);
            c = 10 % 3;
            Console.WriteLine("10 % 3 = {0}", c);
            Console.Clear();

            int x = 5, y;
            Console.WriteLine(x++); //5
            Console.WriteLine(++x); //7
            Console.WriteLine(x);   //7

            y = x++;
            Console.WriteLine(y);   //7
            y = ++x;
            Console.WriteLine(y);   //9
            Console.WriteLine(++y); //10
            Console.Clear();

            int w = 5, s;
            Console.WriteLine(w--); //5
            Console.WriteLine(--w); //3
            Console.WriteLine(w);   //3

            s = w--;
            Console.WriteLine(s);   //3
            s = --w;
            Console.WriteLine(s);   //1
            Console.WriteLine(--s); //0
            Console.Clear();


            int e = 9, f = e
                / 2;
            Console.WriteLine("Wynik działania e / 2 to {0}", f); //zaogrągla w dół bo int, czyli tylko liczby całkowite
            b = 8 / 3;
            Console.WriteLine("Wartośc b to {0}", b); //zaogrągla w dół
            // nie możemy jednak przypisać do int liczby z przecinkiem
            Console.Clear();

            sbyte liczba0 = 127;
            liczba0++;
            Console.WriteLine("Liczba0 = {0}" ,liczba0); //następuje zawijanei liczny, anie blad
            //przy samej deklaracji przy wyjsciu poza zakres wystepuje blad, ale po dobrej deklaracji podczas operacji nie ma bledu

            //a+= b to to samo co a = a + b itd.
            Console.Clear();

            //Cwiczenie 7.1

            int a1 = 8, b1 = 3, c1 = 2, wynik;
            wynik = a % b % c;
            Console.WriteLine("Wynik wynosi {0}", wynik);
            Console.Clear();

            //Cwiczenie 7.2
            int zmienna = 256;
           
            Console.WriteLine("zmienna1 po przesunieciu bitowym o 2 miesjca w prawo {0}", zmienna >> 2);
            Console.WriteLine("zmienna1 po przesunieciu bitowym o 2 miesjca w lewo {0}", zmienna << 2);
            Console.Clear();

            //Cwiczenie 7.3
            int r = 1, t = 0, u , p;
            u = r & t;
            Console.WriteLine(u);
            p = r | t;
            Console.WriteLine(p);
            Console.Clear();

            //Cwiczenie 7.4
            int ax = 1, bx = 0, cx;

            cx = ax ^ bx;
            Console.WriteLine(cx);
            ax ^= bx;
            Console.WriteLine(ax);
            Console.Clear();

            //Cwiczenie 7.5a

            sbyte dx = 1;
            dx -= 127;
            dx -= 126;
            Console.WriteLine(dx);
            Console.Clear();

            //Cwiczenie 7.6

            int sx = 5, wx = 6;

            Console.WriteLine("Przed zmianą: \nsx = {0}\nwx = {1}", sx, wx);

            sx ^= wx;
            wx ^= sx;
            sx ^= wx;



            Console.WriteLine("Po zmianie: \nsx = {0}\nwx = {1}", sx, wx);



            Console.ReadKey();
        }
    }
}
