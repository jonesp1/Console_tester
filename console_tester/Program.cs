class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine("Solution Testing");
        Console.WriteLine("------------------------");

        // Test Case 1
        Console.WriteLine("Test Case 1:");
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        ListNode result1 = solution.AddTwoNumbers(l1, l2);
        PrintListNode(result1);

        // Add more test cases if needed...

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static void PrintListNode(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " ");
            node = node.next;
        }
        Console.WriteLine();
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode();
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int sum = x + y + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }

        return dummyHead.next;
    }
}