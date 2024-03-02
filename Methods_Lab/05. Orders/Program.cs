public class Program
{
    public static void Main()
    {
        string product = Console.ReadLine();
        int quality = int.Parse(Console.ReadLine());

        theMachine(product, quality);
    }

    static void theMachine(string produkta, int broi)
    {
        double sum = 0;

        if (produkta == "coffee")
        {
            sum += broi * 1.50;
        }
        else if (produkta == "water")
        {
            sum += broi * 1;
        }
        else if (produkta == "coke")
        {
            sum += broi * 1.40;
        }
        else if (produkta == "snacks")
        {
            sum += broi * 2;
        }

        Console.WriteLine($"{sum:f2}");
    }
}


