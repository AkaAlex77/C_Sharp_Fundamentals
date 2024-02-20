int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int currentNum = i;
    int sum = 0;

    while (currentNum > 0)
    {
        sum += currentNum % 10;// za da vzmeme poslednoto chislo

        currentNum /= 10;
    }

    if (sum == 5 || sum== 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
}

