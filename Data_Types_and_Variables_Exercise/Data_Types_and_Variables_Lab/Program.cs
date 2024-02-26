int input = int.Parse(Console.ReadLine());

int sum = 0;

while (input >0)
{
    int digit = input % 10;
    input /= 10;
    sum += digit;
}
Console.WriteLine(sum);
