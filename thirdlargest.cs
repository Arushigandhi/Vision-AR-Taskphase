/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;


    class Program
    {
        public static void Main(string[] args)
        {
            int n;
         
            Console.WriteLine("Enter number of elements in array : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(arr[i]);
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine(arr[2]);
      
        }
    }

