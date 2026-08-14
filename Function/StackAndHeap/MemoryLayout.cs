
using System;

namespace MemoryLayoutDemo
{
    // Class
    class Student
    {
        // Static Variable (Stored in Static Area)
        public static int Count = 0;

        // Instance Variables (Stored inside Heap Object)
        public int Id;
        public string Name;

        // Constructor
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Count++;
        }

        // Instance Method
        public void Display()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
        }

        // Static Method
        public static void ShowCount()
        {
            Console.WriteLine($"Total Students : {Count}");
        }
    }
}