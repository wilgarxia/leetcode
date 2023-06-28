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
            /*
            1 here is a bitmask = 00000001. 
            & is a bitwise logical operation.
            Even numbers have their last bit equal to 0.
            When a number is even, the result will be 1. Then the number will be subtracted in the else block.
            When a number is odd, the result will be 0 (0 AND 1). Then the number will be halved in the if block.
            */
            if ((i & 1) == 0)
                i >>= 1;
            else
                i--;

            steps++;
        }

        return steps;        
    }
}