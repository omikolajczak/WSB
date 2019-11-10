using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopiowianie_tablic
{
    class Program
    {
        static void Main(string[] args)
        {
            //kopiowanie tablic

            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[7];

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            tab.CopyTo(tabCopy, 0);


            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Array.Copy(tab, tabCopy, tab.Length);

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();


        }
    }
}
