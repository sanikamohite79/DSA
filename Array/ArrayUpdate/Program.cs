
using System;
public class Program
{
    public static void Main()
    {
        int[ ] numbers= {1,2,3,4,5};
        numbers[2]=10;
        Console.WriteLine("Updated array: " + string.Join(", ", numbers));
    }

}