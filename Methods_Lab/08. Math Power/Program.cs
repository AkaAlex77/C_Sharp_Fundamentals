public class Program
{
    public static void Main()
    {
        double num = int.Parse(Console.ReadLine());
        double seconNum = int.Parse(Console.ReadLine());

        Sum(num, seconNum);
    }

    static void Sum(double num1, double num2)
    {
        double sum = 0;
        if (num1 == 0 || num2 == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            sum = Math.Pow(num1, num2);
            Console.WriteLine(sum);
        }
    }
}


