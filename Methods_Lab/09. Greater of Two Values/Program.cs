﻿public class Program
{
    public static void Main()
    {
        string type = Console.ReadLine();

        if (type == "int")
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int gratedValue = GetMax(a,b);
            Console.WriteLine(gratedValue);
        }
        else if (type == "char")
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            char greaterValue = GetMax(a, b);
            Console.WriteLine(greaterValue);
        }
        else
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            string greaterValue = GetMax(a, b);
            Console.WriteLine(greaterValue);
        }
    }

    static char GetMax(char a, char b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static string GetMax(string a, string b)
    {
        int result = a.CompareTo(b);

        if (result > 0)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}


