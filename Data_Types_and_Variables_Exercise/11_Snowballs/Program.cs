using System.Numerics;

int numberOfSnowballs = int.Parse(Console.ReadLine());

BigInteger maxValue = 0;
int bestSnowBall = 0;
int bestTime = 0;
int bestQuality = 0;

for (int i = 0; i < numberOfSnowballs; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());

    int quality = int.Parse(Console.ReadLine());

    BigInteger value = BigInteger.Pow(snow / time, quality);

    if (value > maxValue)
    {
        maxValue = value;
        bestSnowBall = snow;
        bestQuality = quality;
        bestTime = time;
    }

}
Console.WriteLine($"{bestSnowBall} : {bestTime} = {maxValue} ({bestQuality})");


