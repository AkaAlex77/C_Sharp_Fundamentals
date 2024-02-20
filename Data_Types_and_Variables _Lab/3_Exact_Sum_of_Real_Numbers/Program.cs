int n = int.Parse(Console.ReadLine());

decimal titalSum = 0;

for (int i = 0; i < n; i++)
{
    decimal currentInputNum = decimal.Parse(Console.ReadLine());
    titalSum += currentInputNum;
}
Console.WriteLine(titalSum);

