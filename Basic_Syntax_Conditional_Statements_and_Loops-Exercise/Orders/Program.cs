using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double totalSum = 0;

            for (int i = 1; i <= n; i++)
            {

                double capsulePrice = double.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                sum = day * capsulesCount * capsulePrice;
                totalSum += sum;

                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
