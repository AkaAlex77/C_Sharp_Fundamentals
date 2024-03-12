List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] command = input.Split();
    int elementToDelet = int.Parse(command[1]);

    if (command[0] == "Delete")
    {
        numbers.RemoveAll(x => x == elementToDelet);
    }
    else
    {
        int pasition = int.Parse(command[2]);
        numbers.Insert(pasition, elementToDelet);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
