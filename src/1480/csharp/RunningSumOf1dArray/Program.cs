namespace RunningSumOf1dArray;

class Program
{
    static void Main()
    {
        int[] input = new int[] { 1, 2, 3, 4};
        int[] result = Solution.RunningSum(input);

        Console.WriteLine(string.Join(", ", result));
    }
}

public class Solution
{
    public static int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }
}
