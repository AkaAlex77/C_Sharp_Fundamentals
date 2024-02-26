int n = int.Parse(Console.ReadLine());

byte capacity = 255;
byte sum = 0;

for (int i = 1; i <= n; i++)
{
    short liters = short.Parse(Console.ReadLine());
    if (liters <= capacity - sum)
    {
        sum += (byte)liters;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}

Console.WriteLine(sum);
