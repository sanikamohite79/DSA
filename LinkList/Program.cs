using System;

public class Node {
    public int Data;
    public Node Next;


public Node(int value){
    Data=value;
    Next=null;
}
}

class Program{
    public static void Main(string [] args)
    {
        Node First=new Node(10);
        Node Second=new Node(20);
         Node Third=new Node(30);
          Node Fourth=new Node(40);
           Node Fifth=new Node(50);


        First.Next=Second;
        Second.Next=Third;
        Third.Next=Fourth;
        Fourth.Next=Fifth;

        Console.WriteLine(First.Data);
        Console.WriteLine(First.Next.Data);
        Console.WriteLine(Second.Next.Data);
        Console.WriteLine(Third.Next.Data);
        Console.WriteLine(Fourth.Next.Data);

    }
}


