public class Program
{
    public static void Main()
    {
        int end = int.Parse(Console.ReadLine());

        for (int i = 1; i <= end; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
        for (int i = end - 1; i >= 1; i--)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(k + " ");
            }

            Console.WriteLine();
        }
    }
}


