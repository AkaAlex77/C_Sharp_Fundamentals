﻿
List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> positiveNumbers = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] > 0)
    {
        positiveNumbers.Add(numbers[i]);
    }

}

positiveNumbers.Reverse();

if (positiveNumbers.Count < 1 )
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", positiveNumbers));
}


