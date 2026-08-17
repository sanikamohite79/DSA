
using System;
class Program
{
    static void Main()
    {
        //int Sum =0;
        //int max = matrix[0,0];
        int [ , ] matrix = 
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int Sum =0;
         int max = matrix[0,0];//=0;
         int min = matrix[0,0];//=0;

         int Search = 5;
         bool Found = false;

        for(int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i ,j] + " ");

                 Sum = Sum + matrix[i ,j];


                 if (matrix[i ,j] > max )
                 {
                    max =matrix[i, j];
                 }

                 if(matrix[i, j] < min)
                 {
                    min = matrix[i, j];
                 }

                 if(matrix[i, j] == Search)
                 {
                    Found = true;
                 }

            }
            Console.WriteLine("Matrix  : " );

            Console.WriteLine("Sum = " + Sum  );

            Console.WriteLine("Max = " + max  );
            Console.WriteLine("Min = " + min  );


            if(!Found)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }
        }
    }
}