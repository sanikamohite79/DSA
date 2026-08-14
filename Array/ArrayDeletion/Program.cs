using System;
public class Program
{
    public static void Main()
    {
        int[] numbers = {1,2,3,4,5};
        int index = 2;
        for(int i=index; i < numbers.Length-1; i++)
        {
            numbers[i] = numbers[i+1];

        }

        for(int i=0; i<numbers.Length-1; i++)
        {
            Console.WriteLine(numbers[i] + ", ");
        }
    }

}