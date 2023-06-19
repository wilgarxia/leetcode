namespace Problem1480;

public class ArrayParser
{
    public static int[] ParseArray(string[] input)
    {
        int[] result = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!int.TryParse(input[i], out int parsedValue))
            {
                return Array.Empty<int>();
            }
            
            result[i] = parsedValue;
        }

        return result;
    }
}