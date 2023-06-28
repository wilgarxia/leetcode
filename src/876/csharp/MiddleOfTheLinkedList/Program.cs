namespace MiddleOfTheLinkedList;

public class Program
{
    public static void Main()
    {
        ListNode head = new(1);
        ListNode.AddNode(ref head, 2);
        ListNode.AddNode(ref head, 3);
        ListNode.AddNode(ref head, 4);
        ListNode.AddNode(ref head, 5);

        ListNode result = Solution.MiddleNode(head);
        ListNode current = result;

        while (current is not null)
        {
            if (current.Next is null)
                Console.Write(current.Value);
            else
                Console.Write($"{current.Value}, ");
        }
    }
}

public class Solution 
{
    public static ListNode MiddleNode(ListNode head) 
    {
        ListNode? slow = head;
        ListNode? fast = head;
        
        while (fast is not null && fast.Next is not null) 
        {
            slow = slow?.Next;
            fast = fast.Next.Next;
        }
        
        return slow!;
    }
}

public class ListNode
{
    public ListNode(int value, ListNode? next = null)
    {
        Value = value;
        Next = next;        
    }

    public int Value { get; set; }
    public ListNode? Next { get; set; }

    public static void AddNode(ref ListNode head, int value)
    {
        ListNode newNode = new(value);

        if (head is null)
            head = newNode;
        else
        {
            ListNode? current = head;

            while (current.Next is not null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
    }    
}