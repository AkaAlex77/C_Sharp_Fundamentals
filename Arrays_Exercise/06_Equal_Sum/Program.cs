int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    int rigtSum = 0;

    for (int j = 0; j < i; j++)
    {
        leftSum += numbers[j];

    }
    for (int j = i + 1; j < numbers.Length; j++)
    {
        rigtSum += numbers[j];
    }
    if (leftSum == rigtSum)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine("no");

