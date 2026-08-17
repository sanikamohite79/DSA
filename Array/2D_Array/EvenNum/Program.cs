
using System;
public class Program
{
    public static void Main()
    {
        int [,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        for ( int i=0; i < matrix.GetLength(0); i++)
        {
            int sum =0;

            for(int j=0; j < matrix.GetLength(1); j++)
            {
                sum =sum + matrix[i ,j];
            }
            Console.WriteLine("Sum Of Row " + i + " Sum:" + sum);
        }
    }
}