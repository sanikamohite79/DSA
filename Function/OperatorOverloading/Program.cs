using System;

class Number
{
    public int Value;

    // Constructor
    public Number(int value)
    {
        Value = value;
    }

    // Overload + operator
    public static Number operator -(Number n1, Number n2)
    {
        return new Number(n1.Value - n2.Value);
    }

    // Display Method
    public void Display()
    {
        Console.WriteLine("Value = " + Value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Number n1 = new Number(10);
        Number n2 = new Number(20);

        Number n3 = n1 - n2;

        n3.Display();
    }
}