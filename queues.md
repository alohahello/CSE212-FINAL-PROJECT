# INTRODUCTION TO QUEUES IN DATA STRUCTURE 

A queue is a list that can be represented as a real-world line, where the first element in line is the first element to be removed. To comprehend the queue data structure, we need to understand that it is a linear structure, meaning it follows a concept called 'First In, First Out' (FIFO). This implies that the first data or item that goes in is the first data that comes out.

In programming, adding an item to the queue is called "enqueue," and removing one is "dequeue."

## To gain a better understanding of this topic lets learn some basic concepts:

* Enqueue: Add an element to the end of the queue
* Dequeue: Remove an element from the front of the queue
* IsEmpty: Check if the queue is empty
* IsFull: Check if the queue is full
* Peek: Get the value of the front of the queue without removing it

## Queue operations work with two pointers: one at the FRONT (FI) and one at the REAR (FO).

* Queues process each element based on the order it is received.
* Queues are commonly used in task scheduling systems, such as in operating systems.

One limitation of a queue structure is that it doesn't allow taking out elements that are not the first in the queue.
<p>&nbsp;</p>

# Lets have an example to better understand this concepts:

### 1- CREATE A QUEUE
First, create an instance of the Queue class. You can specify the type of elements the queue will hold (e.g., Queue<int> for integers, or Queue<string> for strings).

``` c#
Queue<string> myQueue = new Queue<string>();
```

### 2- ENQUEUE (Add Elements)
Use the Enqueue method to add elements to the end of the queue.

``` c#
myQueue.Enqueue("Element1");
myQueue.Enqueue("Element2");
myQueue.Enqueue("Element3");
```

### 3- DEQUEUE (Remove Element)
Use the Dequeue method to remove and retrieve the element from the front of the queue.

``` c#
string removedElement = myQueue.Dequeue();
Console.WriteLine($"Removed Element: {removedElement}");
```

### 4- PEEK (Retrieve Without Removing):
Use the Peek method to retrieve the element from the front of the queue without removing it.

``` c#
string frontElement = myQueue.Peek();
Console.WriteLine($"Front Element: {frontElement}");
```

### 5- Check if Queue IS EMPTY:
You can check if the queue is empty using the Count property.

``` c#
if (myQueue.Count == 0)
{
    Console.WriteLine("Queue is empty.");
}
```
<p>&nbsp;</p>

# FULL EXAMPLE:
``` c#

using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a queue
        Queue<string> myQueue = new Queue<string>();

        // Enqueue elements
        myQueue.Enqueue("Element1");
        myQueue.Enqueue("Element2");
        myQueue.Enqueue("Element3");

        // Display elements
        Console.WriteLine("Queue elements:");
        foreach (var element in myQueue)
        {
            Console.WriteLine(element);
        }

        // Dequeue an element
        string removedElement = myQueue.Dequeue();
        Console.WriteLine($"Removed Element: {removedElement}");

        // Peek at the front element
        string frontElement = myQueue.Peek();
        Console.WriteLine($"Front Element: {frontElement}");

        // Display updated elements
        Console.WriteLine("Updated Queue elements:");
        foreach (var element in myQueue)
        {
            Console.WriteLine(element);
        }
    }
}
```

This example illustrates the basic operations of enqueueing, dequeueing, peeking, and checking if the queue is empty.
<p>&nbsp;</p>

# REAL-LIFE EXAMPLE

Consider a scenario where a queue is applied in a real-world context. Let's use the analogy of a library's print queue. In this situation, when multiple users request to print documents, the system employs a queue to manage the order in which the print jobs are processed. Here's a basic representation of this scenario in a simplE program:

``` C#
using System;
using System.Collections;

class PrintQueueExample
{
    static void Main()
    {
        // Create a print queue
        Queue<string> printQueue = new Queue<string>();

        // Users submit print jobs
        SubmitPrintJob(printQueue, "Document1");
        SubmitPrintJob(printQueue, "Document2");
        SubmitPrintJob(printQueue, "Document3");

        // Print jobs are processed in the order they are received
        ProcessPrintJobs(printQueue);
    }

    static void SubmitPrintJob(Queue<string> queue, string document)
    {
        // Enqueue the print job
        queue.Enqueue(document);
        Console.WriteLine($"Print job submitted: {document}");
    }

    static void ProcessPrintJobs(Queue<string> queue)
    {
        Console.WriteLine("\nProcessing print jobs:");

        while (queue.Count > 0)
        {
            // Dequeue and process each print job
            string currentJob = queue.Dequeue();
            Console.WriteLine($"Printing: {currentJob}");
        }

        Console.WriteLine("All print jobs processed.");
    }
}
```