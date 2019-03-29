﻿using System;

public class FibonacciNumbers
{
    public static void Main()
    {
        int nThNum = int.Parse(Console.ReadLine());

        int fibonacciNum = Fib(nThNum);

        Console.WriteLine(fibonacciNum);
    }

    private static int Fib(int nThNum)
    {
        int f1 = 1;
        int f2 = 1;

        if (nThNum == 1 || nThNum == 0)
        {
            return f1;
        }

        for (int i = 2; i <= nThNum; i++)
        {
            int tempNum = f1 + f2;
            f1 = f2;
            f2 = tempNum;
        }

        return f2;

    }
}