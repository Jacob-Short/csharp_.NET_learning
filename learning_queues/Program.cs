using System;
using System.Collections.Generic;

namespace learning_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            foreach (var item in myQueue)
            {
                System.Console.WriteLine(item);
            }

            // similar to popping
            System.Console.WriteLine(myQueue.Dequeue());
            System.Console.WriteLine(myQueue.Peek());
        }
    }
}
