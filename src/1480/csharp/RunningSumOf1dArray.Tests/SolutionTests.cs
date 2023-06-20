namespace RunningSumOf1dArray.Tests;

public class SolutionTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
    public void RunningSum_ShouldReturnSummedArray_WhenGivenAnArray(int[] input, int[] expected)
    {
        // Act
        int[] result = Solution.RunningSum(input);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}