using System;
using System.Collections;

public class HelloWorld
{
    public static void PrintIntArray(int[] arr) {
        Console.Write("[");
        if (arr.Length == 0) {
            Console.Write("]");
        }
        else {
            for (int i = 0; i < arr.Length - 1; i++) {
                Console.Write("{0}, ", arr[i]);
            }
            Console.Write(arr[arr.Length - 1] + "]");
        }
        Console.WriteLine();
    }

    public static int[] IndexOfCapitals(string s) {
        var capitals = new ArrayList();
        for (int i = 0; i < s.Length; i++) {
            if (Char.IsUpper(s[i]))
                capitals.Add(i);
        }

        return (int[])capitals.ToArray(typeof(int));
    }
    
    public static void Main(string[] args)
    {
        PrintIntArray(IndexOfCapitals("eDaBiT"));
        PrintIntArray(IndexOfCapitals("eQuINoX"));
        PrintIntArray(IndexOfCapitals("determine"));
        PrintIntArray(IndexOfCapitals("STRIKE"));
        PrintIntArray(IndexOfCapitals("sUn"));
    }
}