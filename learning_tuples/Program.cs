using System;

namespace learning_tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, String, bool> firstTuple = new Tuple<int, string, bool>(1, "hello", true);

            var secondTuple = Tuple.Create(2, "good-ye", false);

            System.Console.WriteLine(firstTuple.Item2);

            System.Console.WriteLine(secondTuple.Item3);


        }
    }
}
