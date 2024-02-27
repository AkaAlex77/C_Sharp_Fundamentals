int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (var currentNum in nums)
{
    if (currentNum % 2 ==0)
    {
        evenSum += currentNum;
    }
    else
    {
        oddSum += currentNum;
    }
}

Console.WriteLine(evenSum - oddSum);

