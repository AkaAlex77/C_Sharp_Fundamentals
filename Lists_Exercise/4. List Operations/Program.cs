List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "End")
{
    string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string commandType = command[0];

    switch (commandType)
    {
        case "Add":
            numbers.Add(int.Parse(command[1]));
            break;
        case "Insert":
            int index = int.Parse(command[2]);
            if (index <= numbers.Count -1 && index >= 0)
            {
                int number = int.Parse(command[1]);
                numbers.Insert(index, number);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
           
            break;
        case "Remove":
            int indexToRemove = int.Parse(command[1]);

            if (indexToRemove <= numbers.Count - 1 && indexToRemove >= 0)
            {
                numbers.Remove(indexToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }

            break;
        case "Shift":
            int cout = int.Parse(command[2]);
            if (command[1] == "left")
            {
                
                for (int i = 0; i < cout; i++)
                {
                    int firstNum = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(firstNum);
                }
            }
            else//right
            {
                for (int i = 0; i < cout; i++)
                {
                    int lastNumber = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, lastNumber);
                }
                int lastNum = numbers[numbers.Count - 1];
 
            }
            break;
        default:
            break;
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));

