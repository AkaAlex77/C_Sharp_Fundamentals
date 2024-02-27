string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int day = int.Parse(Console.ReadLine());

if (day >=1 && day <=7)
{
    Console.WriteLine(dayOfWeek[day - 1]);
}
else
{
    Console.WriteLine("Invalid ay!");
}


if (day == 1)
{
    Console.WriteLine(dayOfWeek[0]);
}
else if (day == 2)
{
    Console.WriteLine(dayOfWeek[1]);
}
else if (day == 3)
{
    Console.WriteLine(dayOfWeek[2]);
}
else if (day == 4)
{
    Console.WriteLine(dayOfWeek[3]);
}
else if (day == 5)
{
    Console.WriteLine(dayOfWeek[4]);
}
else if (day == 6)
{
    Console.WriteLine(dayOfWeek[5]);
}
else if (day == 7)
{
    Console.WriteLine(dayOfWeek[6]);
}
else
{
    Console.WriteLine("Invalid ay!");
}
