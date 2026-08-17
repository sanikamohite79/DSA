
using System;
class Program
{
    static void Main()
    {
        int[] numbers ={ 10,20,30,40,50,30,30};
         int search= 30;
         int index= -1;
        
         int count=0;

         for(int i=0; i<numbers.Length; i++)
         {
            if(numbers[i] == search)
            {
                count++;

                index= i;
                break;//if tou find last index then remove break statment.
            }

             Console.WriteLine(search + " occurs :" + count +  " times");
         }
         //Console.WriteLine(search + " occurs :" + count +  " times");
    

    if(index != -1)
    {
        Console.WriteLine(search + " First found at index : " + index);

    }
    else
    {
        Console.WriteLine(search + "not Found in the array");
    }
}
}
