using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal sum = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    sum = 8.45m;
                }
                else if (day =="Saturday")
                {
                    sum = 9.80m;
                }
                else if (day == "Sunday")
                {
                    sum = 10.46m;
                }

                if (numPeople >= 30)
                {
                    sum *= 0.86m;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    sum = 10.9m;
                }
                else if (day == "Saturday")
                {
                    sum = 15.6m;
                }
                else if (day == "Sunday")
                {
                    sum = 16;
                }

                if (numPeople > 100)
                {
                    numPeople -= 10;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    sum = 15m;
                }
                else if (day == "Saturday")
                {
                    sum = 20m;
                }
                else if (day == "Sunday")
                {
                    sum = 22.50m;
                }

                if (numPeople >= 10 && numPeople <= 20)
                {
                    sum *= 0.95m;
                }
            }

            decimal totalsum = sum * numPeople;
            Console.WriteLine($"Total price: {totalsum:f2}");
        }
    }
}
