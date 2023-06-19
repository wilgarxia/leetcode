namespace Problem1480;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        return nums;
    }

    // This version defines a new array instead of using the original array.
    public int[] RunningSumAlternative(int[] nums)
    {
        int[] results = new int[nums.Length];
        results[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            results[i] = nums[i] + results[i - 1];
        }

        return results;
    }
}
