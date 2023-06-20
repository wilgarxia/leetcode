namespace RichestCustomerWealth.Tests;

public class SolutionTests
{
    [Theory]
    [InlineData(6, new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
    [InlineData(10, new[] { 1, 5 }, new[] { 7, 3}, new[] { 3, 5 })]
    [InlineData(17, new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 })]
    public void MaximumWealth_ShouldReturnTheMaximumWealth_GivenAJaggedArrayWithCustomersAndAccounts(int expected, params int[][] input)
    {
        // Act
        int result = Solution.MaximumWealth(input);

        // Assert
        result.Should().Be(expected);
    }
}