﻿using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i.ToString()} ");
                }
                Console.WriteLine();
            }
        }
    }
}
