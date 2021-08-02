/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class arraychanger
{
  static void Main ()
  {
    int r = int.Parse(Console.ReadLine ());
    int c = int.Parse(Console.ReadLine ());
    Console.WriteLine("Enter numkbers for the 1D array : ");
    int n = r * c;
    int[] arr1 = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr1[i] = int.Parse (Console.ReadLine ());
    }
    int pos = 0;
    int[,] arr2 = new int[r, c];
    for (int i = 0; i < r; i++)
    {
	    for (int j = 0; j < c; j++)
	    {
	        arr2[i,j] = arr1[pos];
	        pos++;
	        
	    }
    }
    for (int i = 0; i < r; i++)
    {
	    for (int j = 0; j < c; j++)
	    {
	        Console.Write (arr2[i, j] + " ");
	    }
	    Console.WriteLine (" ");
      }
    } 
}
