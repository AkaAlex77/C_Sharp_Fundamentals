int n = int.Parse(Console.ReadLine());

int[] pasagers = new int[n];

int sum = 0;

for (int i = 0; i < pasagers.Length; i++)
{
    pasagers[i] = int.Parse(Console.ReadLine());
    sum += pasagers[i];
}

Console.WriteLine(string.Join(" ", pasagers));// za da printirame s raztoqnie

Console.WriteLine(sum);
