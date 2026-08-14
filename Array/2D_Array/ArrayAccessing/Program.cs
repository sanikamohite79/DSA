
using System;
public class Program
{
    public static void Main ()
     {
        int [,] matrix =
        {
            {1,2,3},
            {4,6,7},
            {8,9,10}
        };

        Console.WriteLine("element of index 0,0 is: "+ matrix[0,0]);
        Console.WriteLine("element of index 0,2 is: "+ matrix[0,2]);
     }
}