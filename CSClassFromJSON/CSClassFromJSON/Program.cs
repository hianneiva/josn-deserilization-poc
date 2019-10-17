using QuickTypeGetter;
using System;
using System.IO;

namespace CSClassFromJSON
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Root payload = Root.FromJson(File.ReadAllText("..\\..\\..\\payload.json"));
            Console.WriteLine(payload.ToString());
        }
    }
}
