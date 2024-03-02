public class Program
{
    public static void Main()
    {
        string nuberAsString = Console.ReadLine();

        int sumOfEven = GetSum(nuberAsString, true);
        int sumOfOdd = GetSum(nuberAsString, false);

        int result = sumOfEven * sumOfOdd;

        Console.WriteLine(result);
    }

    static int GetSum(string numbers, bool isEven)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (char.IsDigit(numbers[i]))
            {
                int currentnumber = int.Parse(numbers[i].ToString());

                if (numbers[i] % 2 == 0 && isEven)
                {
                    sum += currentnumber;
                }
                else if (numbers[i] % 2 != 0 && !isEven)
                {
                    sum += currentnumber;
                }
            }
        }

        return sum;
    }
}


