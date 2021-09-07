using System;
using System.Collections.Generic;

namespace learning_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> pancakes = new Stack<string>();

            pancakes.Push("first pancake made");
            pancakes.Push("second pancake made");
            pancakes.Push("third pancake made");
            pancakes.Push("last pancake made");

            // foreach (var pancake in pancakes)
            // {
            //     System.Console.WriteLine(pancake);
            // }

            // removes last item and returns in
            System.Console.WriteLine(pancakes.Pop());

            // return last item but does not remove it
            System.Console.WriteLine(pancakes.Peek());
            System.Console.WriteLine(pancakes.Peek());

    }
    }

}
