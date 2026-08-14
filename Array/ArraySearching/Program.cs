
using System;
class Program
{
    static void Main()
    {
        int[]  numbers ={10,20,30,40,50};

        int search = 60;
        bool found=false;

        for(int i=0; i< numbers.Length; i++)
        {
            if(numbers[i] == search)
            {
                Console.WriteLine($"Element found at index :" + i);
                found= true;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Element not found in index");

        }
    }

}