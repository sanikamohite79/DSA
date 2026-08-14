using System;
public class Program
{
    static int Square(int n)
    {
        return n+n;
    }
    static void Main()
    {
        int result=Square(6);
        Console.WriteLine(result);
    }
}

//A return function performs a task and returns a value to the calling function using the return keyword.

//Function Used
//Square(int n) → Returns the square of a number.
//Main() → Stores and prints the returned value.