namespace NumberOfStepsToReduceANumberToZero;

public class Program
{
    static void Main()
    {
        int input = 14;
        int result = Solution.NumberOfSteps(input);

        Console.WriteLine(result);
    }
}

public class Solution
{
    public static int NumberOfSteps(int num) 
    {
        int steps = 0;

        for (int i = num; i > 0;)
        {
            if ((i & 1) == 0)
                i >>= 1;
            else
                i--;

            steps++;
        }

        return steps;        
    }
}