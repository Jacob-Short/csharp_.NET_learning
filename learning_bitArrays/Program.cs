using System;
using System.Collections;

namespace learning_bitArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] preload =  new bool[3] { true, false, true};        


            BitArray enemyGrid = new BitArray(preload);

            // enemyGrid[0] = false;
            // enemyGrid[1] = true;
            // enemyGrid[2] = false;

            foreach (var each in enemyGrid)
            {
                System.Console.WriteLine(each);
            }
        }
    }
}
