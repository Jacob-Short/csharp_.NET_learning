using System;
using System.Collections.Generic;

namespace learning_hashkey
{
    class Program
    {
        // hashes out duplicates
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();

            myHash.Add("hello");
            myHash.Add("hello");
            myHash.Add("goodbye");

            // can check if a array has same item as in hashset

            String[] s = new String[] {"hello"};

            System.Console.WriteLine(myHash.Count);
            System.Console.WriteLine(myHash.Overlaps(s));
        }
    }
}
