List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "end")
{
    string[] command = input.Split();

    if (command.Length == 2)
    {
        int passangers = int.Parse(command[1]);
        wagons.Add(passangers);
    }
    else
    {
        

        int passangers = int.Parse(command[0]);


        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passangers <= maxCapacity)
            {
                wagons[i] += passangers;
                break;
            }
        }
    }


    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", wagons));
