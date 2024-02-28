int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = int.Parse(Console.ReadLine());

for (int j = 0; j < n; j++)
{
    int firstElement = inputNums[0];
    for (int i = 0; i < inputNums.Length-1; i++)
    {
        inputNums[i] = inputNums[i + 1];
    }
    inputNums[inputNums.Length - 1] = firstElement;
}
Console.WriteLine(string.Join(" ", inputNums));

