int people = int.Parse(Console.ReadLine());
int elevator = int.Parse(Console.ReadLine());

int numberOfCourses = people / elevator;
if (people % elevator != 0)
{
    numberOfCourses++;
}
Console.WriteLine(numberOfCourses);


