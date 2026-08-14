using System;

public class Person
{
    private static int count = 0;
    private int id;

    public Person()
    {
        count++;
        id = count;
    }

    public void GetId()
    {
        Console.WriteLine("Person ID = " + id);
    }
}

//A static variable is shared by all objects of a class. A static function can access static variables directly