int n = int.Parse(Console.ReadLine());

string bestModel = "";
double biggestVolume = 0;


for (int i = 1; i <= n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * radius * radius * height;
    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        bestModel = model;
    }
}
Console.WriteLine(bestModel);

