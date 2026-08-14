
using System;
public class Program
{
    public static void Main()
    {
      int[] numbers = new int[6];

        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        int size= 5;      //size  = how many elements we have
         int index= 2;    //index = where we want to insert
                          //value = what we want to insert
        int value= 10;   
        
    
        for(int i=size; i>=index; i--)
        {
            numbers[i]=numbers[i-1]; //Start from the last element and move elements one position to the right.
        }
        numbers[index]=value; //Put the new value
        Console.WriteLine("Array after insertion:" + string.Join(", ", numbers));
    }
}