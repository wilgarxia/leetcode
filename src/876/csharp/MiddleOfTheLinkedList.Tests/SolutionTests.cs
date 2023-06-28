namespace MiddleOfTheLinkedList.Tests;

public class SolutionTests
{
    [Fact]
    public void MiddleNode_ShouldReturnTheNodeInTheMiddleOfTheLinkedList_WhenGivenALinkedList()
    {
        // Arrange
        ListNode head = new(1);
        ListNode.AddNode(ref head, 2);
        ListNode.AddNode(ref head, 3);
        ListNode.AddNode(ref head, 4);
        ListNode.AddNode(ref head, 5);
        int[] expected = new int[] { 3, 4, 5};

        // Act
        ListNode? result = Solution.MiddleNode(head);
        int[] nodes = new int[3];

        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i] = result!.Value;
            result = result.Next;
        }

        // Assert
        nodes.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void MiddleNode_ShouldReturnTheSecondNodeInTheMiddleOfTheLinkedList_WhenGivenALinkedList()
    {
        // Arrange
        ListNode head = new(1);
        ListNode.AddNode(ref head, 2);
        ListNode.AddNode(ref head, 3);
        ListNode.AddNode(ref head, 4);
        ListNode.AddNode(ref head, 5);
        ListNode.AddNode(ref head, 6);
        int[] expected = new int[] { 4, 5, 6};

        // Act
        ListNode? result = Solution.MiddleNode(head);
        int[] nodes = new int[3];

        for (int i = 0; i < nodes.Length; i++)
        {
            nodes[i] = result!.Value;
            result = result.Next;
        }

        // Assert
        nodes.Should().BeEquivalentTo(expected);
    }    
}