List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();


for (int i = 0; i < nums.Count / 2; i++)
{
    int curentSum = nums[i] + nums[nums.Count - 1 - i];
    result.Add(curentSum);
}

if (nums.Count % 2 != 0)
{
    result.Add(nums[nums.Count/2]);
}
Console.WriteLine(string.Join(" ", result));

