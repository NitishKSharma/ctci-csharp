using System;

namespace ctci_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region hashtable
            // HashTable
            // var ht = new NHashTable<string, string>(20);
            // ht.Add("1", "item 1");
            // ht.Add("2", "item 2");
            // ht.Add("ajsd", "jkajdkajs");


            // Console.WriteLine($"one = {ht.Find("1")}");
            // Console.WriteLine($"two = {ht.Find("2")}");
            // ht.Remove("1");
            // Console.WriteLine($"string three = {ht.Find("1")}");
            #endregion

            #region arrayList
            // var al = new AList<int>();

            // al.Add(1);
            // al.Add(2);
            // al.Add(100);
            // al.Add(59);

            // Console.WriteLine("Size is: " + al.Size);

            // Console.WriteLine("Item at 0:" + al.Get(0));
            // Console.WriteLine("Item at 1:" + al.Get(1));

            // al.Add(109);
            // al.RemoveAt(2);

            // Console.WriteLine("Size is: " + al.Size);

            // Console.WriteLine("Item at 2:" + al.Get(2));
            // al.RemoveAt(4);

            // try
            // {
            //     al.RemoveAt(99);
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // try
            // {
            //     al.Get(99);
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            #endregion

            #region  StringBuilder
            var sb = new NStringBuilder();

            sb.Append("Nitish");
            Console.WriteLine("Value in string is" + sb.ToString());

            string[] array = { "Kumar", "Sharma" };
            sb.Append(array);
            Console.WriteLine("Value in string is" + sb.ToString());

            sb.Remove(0, 1);
            Console.WriteLine("Valye in string is" + sb.ToString());

            try
            {
                sb.Remove(4, 1);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception thrown: " + e.Message);
            }

            try
            {
                sb.Remove(0,5);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception thrown: " + e.Message);
            }

            #endregion
        }
    }
}
