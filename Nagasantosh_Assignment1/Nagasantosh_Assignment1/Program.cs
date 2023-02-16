//Program to display patterns using for loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagasantosh_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("Enter the value of n:"); //taking input from user for value 'n'
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(A)");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");//printing pattern with "*"
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("(B)");
            for (i = 1; i <= n; i++)
            {
                for (j = i; j <= n; j++)
                {
                    Console.Write("*");
                }
                for (j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("(C)");
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (j = i; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("(D)");
            for (i = 1; i <= n; i++)
            {
                for (j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
