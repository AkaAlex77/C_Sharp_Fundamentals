string[] symbols = Console.ReadLine().Split(" ").ToArray();

//for (int i = 0; i < symbols.Length/2; i++)
//{
//    string oldElement = symbols[i];
//    symbols[i] = symbols[symbols.Length - 1 - i];
//    symbols[symbols.Length - 1 - i] = oldElement;
//}
//Console.WriteLine(string.Join(" ", symbols));

symbols = symbols.Reverse().ToArray();

Console.WriteLine(string.Join(" ",symbols));




