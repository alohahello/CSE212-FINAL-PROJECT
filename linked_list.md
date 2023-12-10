# INTRODUCTION TO LINKED LISTS IN DATA STRUCTURES

A linked list is a linear data structure that consists of nodes, where each node contains data and a reference (link) to the next node in the sequence. Unlike arrays, linked lists do not have a fixed size, and elements can be easily inserted or removed. Linked lists come in various forms, with the two main types being singly linked lists and doubly linked lists.

## KEY CONCEPTS OF LINKED LISTS:

* Node: The basic building block containing data and a reference to the next (and optionally, the previous) node.
* Singly Linked List: Each node points to the next node in the sequence.
* Doubly Linked List: Each node points to both the next and previous nodes.

## BASIC OPERATIONS ON LINKED LISTS:

* Insertion: Adding a new node to the list.
* Deletion: Removing a node from the list.
* Traversal: Visiting each node in the list.

# EXAMPLES OF LINKED LISTS IN C#

### 1- CREATE A SINGLY LINKED LIST
``` C#
public class Node<T>
{
    public T Data;
    public Node<T> Next;

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class SinglyLinkedList<T>
{
    public Node<T> Head;

    public SinglyLinkedList()
    {
        Head = null;
    }

    public void AddNode(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }
}
```

### 2- CREATE A DOUBLY LINKED LIST
``` C#
public class DoublyNode<T>
{
    public T Data;
    public DoublyNode<T> Next;
    public DoublyNode<T> Previous;

    public DoublyNode(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

public class DoublyLinkedList<T>
{
    public DoublyNode<T> Head;

    public DoublyLinkedList()
    {
        Head = null;
    }

    public void AddNode(T data)
    {
        DoublyNode<T> newNode = new DoublyNode<T>(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            DoublyNode<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Previous = current;
        }
    }
}
```

### 3- USING LINKED LISTS:
``` c#
// Example of using SinglyLinkedList
SinglyLinkedList<int> singlyList = new SinglyLinkedList<int>();
singlyList.AddNode(1);
singlyList.AddNode(2);
singlyList.AddNode(3);

// Example of using DoublyLinkedList
DoublyLinkedList<string> doublyList = new DoublyLinkedList<string>();
doublyList.AddNode("Node 1");
doublyList.AddNode("Node 2");
doublyList.AddNode("Node 3");
```

# PRACTICE RESOLVING THIS PROBLEM

Reverse a Singly Linked List: Write a function to reverse a singly linked list. Given the head of a singly linked list, reverse the list and return its head.

Click the following link to work on a given problem. 
[Problem Practice](linked_list.cs)

# PROBLEM SOLUTION
Before looking in to the solution make your best effor to complete resolve the problem.

``` C#

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

```