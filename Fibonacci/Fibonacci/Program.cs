using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements (Max 90)");
            string consoleEntry = Console.ReadLine();

            int numElem;
            if (Int32.TryParse(consoleEntry, out numElem) && numElem > 2 && numElem < 91)
            {
                long i = 1;
                long j = 1;
                long k;

                Console.WriteLine(string.Format("{0} --  {1}", 1, i));
                Console.WriteLine(string.Format("{0} --  {1}", 2, j));

                for (int n = 3; n <= numElem; n++)
                {
                    k = i + j;
                    Console.WriteLine(string.Format("{0} --  {1}",n,k));
                    i = j;
                    j = k;
                }
            }
            else
            {
                Console.WriteLine("Why?");
            }

            Console.Read();
        }
    }
}
