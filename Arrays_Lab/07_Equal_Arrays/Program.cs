using System;

int[] nums1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] nums2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = 0;

bool arreSame = true;

for (int i = 0; i < nums1.Length; i++)
{
    sum += nums1[i];
    if (nums1[i] != nums2[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
        arreSame = false;
        break;
    }
}

if (arreSame)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");

}

