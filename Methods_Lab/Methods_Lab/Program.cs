﻿using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        NumCheck(num);

    }

    static void NumCheck(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive. ");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative. ");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero. ");
        }
    }
}

