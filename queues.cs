using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Creating a new queue
        Queue myQueue = new Queue();

        // Enqueueing (adding) elements to the queue
        myQueue.Enqueue("Alice");
        myQueue.Enqueue("Bob");
        myQueue.Enqueue("Charlie");

        // Displaying the elements in the queue
        Console.WriteLine("Queue elements:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }

        // Dequeueing (removing) an element from the front of the queue
        Console.WriteLine("\nDequeue operation:");
        string removedPerson = (string)myQueue.Dequeue();
        Console.WriteLine($"Removed: {removedPerson}");

        // Displaying the updated queue
        Console.WriteLine("\nUpdated Queue elements:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }
    }
}