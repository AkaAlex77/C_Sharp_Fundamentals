using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balence = 0m;

            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Start")
                {
                    break;
                }
                decimal coin = decimal.Parse(input);
                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m )
                {
                    balence += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input == "Nuts")
                {
                    if (balence >= 2)
                    {
                        balence -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (balence >= 0.7m)
                    {
                        balence -= 0.7m;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (balence >= 1.5m)
                    {
                        balence -= 1.5m;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (balence >= 0.8m)
                    {
                        balence -= 0.8m;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (balence >= 1)
                    {
                        balence -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {balence:f2}");
        }
    }
}
