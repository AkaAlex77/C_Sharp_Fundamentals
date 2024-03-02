public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        string operatorType = Console.ReadLine();
        int b = int.Parse(Console.ReadLine());

        int sum = 0;

        if (operatorType == "*")
        {
            sum = a * b;
        }
        else if (operatorType == "+")
        {
            sum = a + b;
        }
        else if (operatorType == "-")
        {
            sum = a - b;
        }
        else if (operatorType == "/")
        {
            sum = a / b;
        }

        Console.WriteLine(sum);
    }
}

