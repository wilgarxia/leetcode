namespace RichestCustomerWealth;

class Program
{
    static void Main()
    {
        int[][] input = { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
        int result = Solution.MaximumWealth(input);

        Console.WriteLine(result);
    }
}

public class Solution 
{
    public static int MaximumWealth(int[][] accounts) 
    {
        int richestCustomerWealth = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int customerWealth = 0;

            for (int j = 0; j < accounts[i].Length; j++)
                customerWealth += accounts[i][j];

            richestCustomerWealth = Math.Max(richestCustomerWealth, customerWealth);
        }        

        return richestCustomerWealth;
    }
}