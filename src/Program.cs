using System;

namespace ctci_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new NHashTable<string, string>(20);
            ht.Add("1", "item 1");
            ht.Add("2", "item 2");
            ht.Add("ajsd", "jkajdkajs");

            
            Console.WriteLine($"one = {ht.Find("1")}");
            Console.WriteLine($"two = {ht.Find("2")}");
            ht.Remove("1");
            Console.WriteLine($"string three = {ht.Find("1")}");

        }
    }
}
