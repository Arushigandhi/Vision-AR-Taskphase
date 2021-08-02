/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int n = int.Parse(Console.ReadLine());
            int m = n / 2;
            int i;
            int isPrime = 0;
            if (n>=0)
            {
                for (i = 2; i <= m; i++)
                    {
                    if (n % i == 0)
                    {
                        Console.Write("Number is not Prime!");
                        isPrime = 1;
                        break;
                    }
                }
                if (isPrime == 0)
                    Console.Write("Number is Prime!");

            }
            else
            {
                Console.Write("Number is not positive!");
            }

        }
}

