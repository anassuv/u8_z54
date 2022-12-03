using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 4, 7, 2 },
                         { 5, 9, 2, 3 },
                         { 8, 4, 2, 4 } };

            Console.WriteLine();
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write("{0,5}", a[i, j]);
                }
                Console.WriteLine();
            }
            for (int k = 0; k <= a.GetUpperBound(0); k++)
            {
                for (int i = 0; i < a.GetUpperBound(1); i++)
                {
                    for (int j = i + 1; j <= a.GetUpperBound(1); j++)
                    {
                        if (a[k, i] < a[k, j])
                        {
                            int t = a[k, i];
                            a[k, i] = a[k, j];
                            a[k, j] = t;
                        }
                    }                   
                }
            }
            Console.WriteLine();
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write("{0,5}", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
