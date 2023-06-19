using Problem1480;

Console.WriteLine("This is the Solution runner for Problem 1480 in Leetcode.");

int[] input;

if (args.Length == 0)
{
    Console.WriteLine("Please, provide the input array:");

    string inputArray = Console.ReadLine() ?? string.Empty;
    
    if (string.IsNullOrWhiteSpace(inputArray))
    {
        Console.WriteLine("Invalid input. Please provide valid integer values.");
        return;
    }

    input = ArrayParser.ParseArray(inputArray.Split(','));
}
else
{
    input = ArrayParser.ParseArray(args);
}

if (input == Array.Empty<int>())
{
    Console.WriteLine("Invalid input. Please provide valid integer values.");
    return;
}

Solution solution = new();

var result = solution.RunningSum(input);

Console.Write("Here's the result: ");

for (int i = 0; i < result.Length; i++)
{
    Console.Write(i == result.Length -1 ? $"{result[i]}\n" : $"{result[i]}, ");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();