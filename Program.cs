using System;
using System.Collections.Generic;

class Program
{
    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }
            numIndices[nums[i]] = i;
        }
        return null; // If no solution is found
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array of integers separated by commas:");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

        Console.WriteLine("Enter the target integer:");
        int target = int.Parse(Console.ReadLine());

        int[] result = TwoSum(nums, target);
        if (result != null)
        {
            Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
