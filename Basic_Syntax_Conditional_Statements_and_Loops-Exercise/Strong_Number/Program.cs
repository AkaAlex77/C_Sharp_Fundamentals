using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int sum = 0;

            while (numCopy > 0)
            {
                int digit = numCopy % 10;
                numCopy = numCopy / 10;
                int facturial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    facturial *= i;
                }
                sum += facturial;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
