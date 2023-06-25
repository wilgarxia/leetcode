namespace FizzBuzz;

class Program
{
    static void Main()
    {
        int input = 3;
        IList<string> result = Solution.FizzBuzz(input);

        Console.WriteLine(string.Join(", ", result));
    }
}

public class Solution
{
    public static IList<string> FizzBuzz(int n) 
    {
        string[] result = new string[n];

        for (int i = 1; i <= n; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            result[i-1] = fizz && buzz ? "FizzBuzz" : 
                fizz ? "Fizz" : 
                buzz ? "Buzz" : 
                i.ToString();
        }

        return result;
    }
}