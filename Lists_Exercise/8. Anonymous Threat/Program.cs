List<string> names = Console.ReadLine().Split().ToList();

string input = Console.ReadLine();

while (input != "3:1")
{
    string[] command = input.Split();

    string commandType = command[0];

    if (commandType == "merge")
    {
        int starIndex = int.Parse(command[1]);
        int endIndex = int.Parse(command[1]);
        string concatenatedWords = string.Empty;

        for (int i = starIndex; i <= endIndex; i++)
        {
            concatenatedWords += names[i];
            
        }

        names.RemoveRange(starIndex, starIndex + endIndex);
    }
    else if (commandType == "divide")
    {
        int index = int.Parse(command[1]);
        int partition = int.Parse(command[1]);

    }


    input = Console.ReadLine();
}
