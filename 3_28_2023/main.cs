using System;

public class HelloWorld
{
    public static int CircuitPower(int a, int b) {
        return a * b;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(CircuitPower(230, 10));
        Console.WriteLine(CircuitPower(110, 3));
        Console.WriteLine(CircuitPower(480, 20));    
    }
}