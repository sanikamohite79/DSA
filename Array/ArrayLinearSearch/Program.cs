using System;
public class Program
{
    public static void Main()
    {



int[] numbers = { 10, 20, 30, 40, 50 };

int target = 40;
int index = -1;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == target)
    {
        index = i;
        break;
    }
}

if (index != -1)
{
    Console.WriteLine("Found at index: " + index);
}
else
{
    Console.WriteLine("Not found");
}
}
}