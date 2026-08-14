
using System;

class Program
{
    static void Main()
    {
        fun<int ,int ,int, >Add=(a,b ) => a+b;
        Console.WriteLine(Add(10,20));
    }
}

//A lambda function is a short, anonymous function used for simple operations.

//Function Used
//Add → Lambda expression that returns the sum of two numbers.
//Main() → Calls the lambda function.