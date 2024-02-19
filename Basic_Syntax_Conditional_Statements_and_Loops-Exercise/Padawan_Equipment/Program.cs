using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double balanance = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabers = Math.Ceiling((double)students * 1.10);
            double sumLightsaber = lightsabers * lightsabersPrice;

            double sumRobes = students * robesPrice;

            double belts = students;
            double sumBelt = belts * beltsPrice;

            double sixthBelts = Math.Floor((double)students / 6);
            sumBelt = (students * beltsPrice) - (sixthBelts * beltsPrice);


            double totalSum = sumRobes + sumBelt + sumLightsaber;


            if (balanance >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalSum - balanance:f2}lv more.");
            }
        }
    }
}
