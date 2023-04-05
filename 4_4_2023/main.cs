using System;

public class HelloWorld
{
    public static int SumPolygon(int n) {
        return (n - 2) * 180;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(SumPolygon(3));
        Console.WriteLine(SumPolygon(4));
        Console.WriteLine(SumPolygon(6));
    }
}