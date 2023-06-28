namespace NumberOfStepsToReduceANumberToZero.Tests;

public class SolutionTests
{
    [Theory]
    [InlineData(14, 6)]
    [InlineData(8, 4)]
    [InlineData(123, 12)]
    public void NumberOfSteps_ShouldReturnTheNumberOfStepsToReduceANumberToZero_WhenAnIntegerIsPassed(
        int input, int expected)
    {
        // Act
        int result = Solution.NumberOfSteps(input);

        // Assert
        result.Should().Be(expected);
    }
}