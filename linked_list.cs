public class ListNode
{
    public int Value;
    public ListNode Next;

    public ListNode(int value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    public ListNode Head;

    public LinkedList()
    {
        Head = null;
    }

    public void AddNode(int value)
    {
        ListNode newNode = new ListNode(value);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            ListNode current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display()
    {
        ListNode current = Head;
        while (current != null)
        {
            Console.Write($"{current.Value} ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

public class LinkedListOperations
{
    public static ListNode ReverseLinkedList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        head = prev;
        return head;
    }
}
