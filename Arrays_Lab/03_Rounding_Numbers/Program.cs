double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();//na edin red pishem celiq masiv

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"{nums[i]} => {Math.Round(nums[i],MidpointRounding.AwayFromZero)}");
}