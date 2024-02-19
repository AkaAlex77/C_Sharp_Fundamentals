int n = int.Parse(Console.ReadLine());
int startIndex = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{n} X {startIndex} = {n * startIndex}");
    startIndex++;

} while (startIndex<=10);

