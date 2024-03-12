List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> bombDitails = Console.ReadLine().Split().Select(int.Parse).ToList();

int bomb = bombDitails[0];
int bombStrenght = bombDitails[1];

while (numbers.Contains(bomb))
{

    int bombIndex = numbers.IndexOf(bomb);
    int start = bombIndex - bombStrenght;

    if (start < 0)
    {
        start = 0;
    }

    int end = bombIndex + bombStrenght;

    if (end > numbers.Count - 1)
    {
        end = numbers.Count - 1;
    }

    numbers.RemoveRange(start, end - start + 1);

}
int sum = 0;

foreach (var item in numbers)
{
    sum += item;
}


Console.WriteLine(sum);


