using System;
using System.Collections.Generic;

namespace LearningDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> config = new Dictionary<string, string>();

            config.Add("resolution", "3840x2160");
            config.Add("title", "MyWebsite");

            Console.WriteLine(config["title"]);
            Console.WriteLine(config["resolution"]);
        }
    }
}
