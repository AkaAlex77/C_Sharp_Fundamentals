public class Program
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        Area(h, y);

    }
    static void Area(int h, int y)
    {
        int sumArea = h * y;
        Console.WriteLine(sumArea);
    }
}

