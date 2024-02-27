int n = int.Parse(Console.ReadLine());//dulgina na masiva

int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i] + " ");
//}

for (int i = numbers.Length -1; i >= 0; i--) // v obraten red
{
    Console.Write(numbers[i] + " ");
}
