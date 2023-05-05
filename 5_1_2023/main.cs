using System;
using System.Collections;

public class HelloWorld
{
    public static int collatz(int n) {
        int steps = 0;
        while (n != 1) {
            if (n % 2 == 0)
                n /= 2;
            else
                n = n * 3 + 1;
            steps++;
        }
        return steps;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(collatz(2));
        Console.WriteLine(collatz(3));
        Console.WriteLine(collatz(10));
    }
}