int n = int.Parse(Console.ReadLine());

int[] firstArr = new int[n];
int[] secondArr = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (i % 2 == 0)
    {
        firstArr[i] = currInput[0];
        secondArr[i] = currInput[1];
    }
    else
    {
        firstArr[i] = currInput[1];
        secondArr[i] = currInput[0];
    }
}

Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));


