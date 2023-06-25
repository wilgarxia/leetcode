namespace FizzBuzz.Tests;

public class SolutionTests
{
    [Theory]
    [InlineData(3, new string[] { "1", "2", "Fizz" })]
    [InlineData(5, new string[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuzz_ShouldReturnCorrectListOfStrings_WhenGivenAnInteger(int input, IList<string> expected)
    {
        // Act
        IList<string> result = Solution.FizzBuzz(input);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}