int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= n; i++)
{
    int character = char.Parse(Console.ReadLine());
    sum += character;
}

Console.WriteLine($"The sum equals: {sum}");
