public class Program
{
    public static void Main()
    {
        string metodTupe = Console.ReadLine();
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        metod(metodTupe, num1, num2);

    }


    static void metod(string metodType, int num1, int num2)
    {
        int sum = 0;

        if (metodType == "add")
        {
            sum = num1 + num2;
        }
        else if (metodType == "multiply")
        {
            sum = num1 * num2;
        }
        else if (metodType == "subtract")
        {
            sum = num1 - num2;
        }
        else if (metodType == "divide")
        {
            sum = num1 / num2;
        }

        Console.WriteLine(sum);
    }
}


