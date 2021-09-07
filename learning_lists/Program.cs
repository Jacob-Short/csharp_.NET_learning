using System;
using System.Collections.Generic;

namespace learning_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<string>();

            customers.Add("Jacob");
            customers.Add("Raelynn");
            customers.Add("Samantha");

            System.Console.WriteLine(customers.Count);

            // can access raelynn by index
            System.Console.WriteLine(customers[1]);


            foreach (var person in customers)
            {
                System.Console.WriteLine(person);
            } 
        }
    }
}
