int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int longestIndex = 0;
int longestLenght = 0;

for (int i = 0; i < array.Length; i++)
{
    int currentSequence = i - 1;
    int currentLenght = 1;

    while (i < array.Length && array[i] == array[i - 1])
    {
        currentLenght++;
        i++;
    }

    if (currentLenght > longestLenght)
    {
        longestLenght = currentLenght;
        longestIndex = currentSequence;
    }

}


for (int i = longestIndex; i < longestIndex + longestLenght ; i++)
{
    Console.Write($"{array[i]} ");
}