using System;
using MemoryLayoutDemo;

 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started\n");

            //-------------------------------
            // STACK MEMORY
            //-------------------------------

            int x = 10;
            int y = 20;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            //-------------------------------
            // HEAP MEMORY
            //-------------------------------

            Student s1 = new Student(101, "Sanika");
            Student s2 = new Student(102, "Rahul");

            s1.Display();
            s2.Display();

            //-------------------------------
            // STATIC MEMORY
            //-------------------------------

            Student.ShowCount();

            //-------------------------------
            // METHOD CALL
            //-------------------------------

            Calculate();

            //-------------------------------
            // GARBAGE COLLECTION
            //-------------------------------

            s1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nGarbage Collection Executed");

            Console.ReadKey();
        }

        static void Calculate()
        {
            Console.WriteLine("\nInside Calculate Method");

            int sum = 100;

            Console.WriteLine($"Sum = {sum}");
        }
    }
