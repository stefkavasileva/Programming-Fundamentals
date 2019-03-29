﻿using System;

public class SpecialNumbers
{
    public static void Main()
    {
        int endNum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= endNum; i++)
        {
            int currentNum = i;

            int firstDigit = (currentNum / 10) % 10;
            int lastDigit = currentNum % 10;
            int sumOfDigits = firstDigit + lastDigit;

            if (sumOfDigits == 5 || sumOfDigits == 11 || sumOfDigits == 7)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
        }
    }
}
