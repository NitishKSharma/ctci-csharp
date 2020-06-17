// // // using System;
// // // using System.Collections.Generic;
// // // using System.Linq;

// // // namespace ctci_csharp
// // // {
// // //     class Program
// // //     {
// // //         static void Main(string[] args)
// // //         {
// // //             #region hashtable
// // //             // HashTable
// // //             // var ht = new NHashTable<string, string>(20);
// // //             // ht.Add("1", "item 1");
// // //             // ht.Add("2", "item 2");
// // //             // ht.Add("ajsd", "jkajdkajs");


// // //             // Console.WriteLine($"one = {ht.Find("1")}");
// // //             // Console.WriteLine($"two = {ht.Find("2")}");
// // //             // ht.Remove("1");
// // //             // Console.WriteLine($"string three = {ht.Find("1")}");
// // //             #endregion

// // //             #region arrayList
// // //             // var al = new AList<int>();

// // //             // al.Add(1);
// // //             // al.Add(2);
// // //             // al.Add(100);
// // //             // al.Add(59);

// // //             // Console.WriteLine("Size is: " + al.Size);

// // //             // Console.WriteLine("Item at 0:" + al.Get(0));
// // //             // Console.WriteLine("Item at 1:" + al.Get(1));

// // //             // al.Add(109);
// // //             // al.RemoveAt(2);

// // //             // Console.WriteLine("Size is: " + al.Size);

// // //             // Console.WriteLine("Item at 2:" + al.Get(2));
// // //             // al.RemoveAt(4);

// // //             // try
// // //             // {
// // //             //     al.RemoveAt(99);
// // //             // }
// // //             // catch(Exception e)
// // //             // {
// // //             //     Console.WriteLine(e.Message);
// // //             // }

// // //             // try
// // //             // {
// // //             //     al.Get(99);
// // //             // }
// // //             // catch(Exception e)
// // //             // {
// // //             //     Console.WriteLine(e.Message);
// // //             // }
// // //             #endregion

// // //             #region  StringBuilder
// // //             // var sb = new NStringBuilder();

// // //             // sb.Append("Nitish");
// // //             // Console.WriteLine("Value in string is" + sb.ToString());

// // //             // string[] array = { "Kumar", "Sharma" };
// // //             // sb.Append(array);
// // //             // Console.WriteLine("Value in string is" + sb.ToString());

// // //             // sb.Remove(0, 1);
// // //             // Console.WriteLine("Valye in string is" + sb.ToString());

// // //             // try
// // //             // {
// // //             //     sb.Remove(4, 1);
// // //             // }
// // //             // catch(Exception e)
// // //             // {
// // //             //     Console.WriteLine("Exception thrown: " + e.Message);
// // //             // }

// // //             // try
// // //             // {
// // //             //     sb.Remove(0,5);
// // //             // }
// // //             // catch(Exception e)
// // //             // {
// // //             //     Console.WriteLine("Exception thrown: " + e.Message);
// // //             // }

// // //             #endregion

// // //             #region random test
// // //             // long[] x = new long[]{6,0,-1,10};
// // // 		    //var y = Solution.hotel(new List<int>() {17, 0, 45, 11, 16, 43, 15, 42, 2, 41, 0, 27, 37, 25, 17, 42, 24, 23, 11, 4, 29, 39, 6, 10, 42, 16, 17, 39, 1},
// // //             // new List<int>() {25, 24, 52, 51, 26, 46, 25, 45, 9, 51, 49, 48, 51, 66, 65, 57, 69, 43, 50, 9, 32, 55, 10, 58, 62, 46, 19, 87, 12}, 
// // //             // 2);
// // //             // var y = Solution.hotel(new List<int>() {47, 4, 0, 12, 47, 31, 15, 49, 29, 33, 7, 22, 26, 24, 16},
// // //             // new List<int>() {95, 4, 26, 16, 51, 79, 43, 58, 32, 80, 30, 27, 29, 54, 16}, 
// // //             // 2);
// // //             // var y = Solution.largestNumber(new List<int>{0,0,0,0});
// // //             // var y = Solution.generateMatrix(0);
// // //             // var y = Solution.firstMissingPositive(new List<int>(){0});
// // //             // var y = Solution.maxSpecialProduct(new List<int>(){5, 9, 6, 8, 6, 4, 6, 9, 5, 4, 9});
// // //             // var y = Solution.maxSpecialProduct(new List<int>(){0});
// // // 		    // Console.WriteLine(y);
// // //             // var y = Answer.Exists(new int[]{-9,14,37,102}, 1);
// // //             // Console.WriteLine(y);

// // //             var fruits = new string[]{"apple", "orange", "apricot", "kiwi"};
// // //             // var x = fruits.Max(c => c.Length);
// // //             var x = new[] {"apple", "orange", "apricot", "kiwi"}.Max(c => c.Length);
// // //             Console.WriteLine(x);
// // //             #endregion
// // //         }
// // //     }
// // // }


// // using System;

// // class Shape{}
// // class Square: Shape{}
// // class Circle:Shape{}

// using System;

// class Program{
//     public static void Main(String[] args)
//     {
//         B.Foo();
//     }
// }

// public class A{}

// public class B
// {
//     public static void Foo()
//     {
//         object a = new A();
//         B b = null;
//         try
//         {
//             b = (B)a;
//             Console.Write("1");
//         }
//         catch(Exception){}
//         try
//         {
//             b = a as B;
//             Console.Write("2");
//         }
//         catch(Exception){}
//         if(a is B)
//             Console.Write("3");
//     }
// }

// using System.Collections.Generic;
// using System.Linq;

// class Answer 
// {
//     public IEnumerable<string> Filter(List<string> strings)
//     {
//         // var x = strings.Sort();
//         return strings.Sort().FindAll(t => t.Star)
//     }
// }

// using System;
// using System.Collections.Generic;
// using System.Linq;
					
// public class Program
// {
// 	delegate void Printer();

//     static void Main()
//     {
//             List<Printer> printers = new List<Printer>();
//             int i=0;
//             for(; i < 10; i++)
//             {
//                 printers.Add(delegate { Console.WriteLine(i); });
//             }

//             foreach (var printer in printers)
//             {
//                 printer();
//             }
//     }
// }

using System;
using System.Linq;

class Program
{
    public static void Main(String[] args)
    {
        var str = "foo bar foo $ bar $ foo bar $";
        Console.WriteLine(removedollar(str));
        var y = " Nitish Sharma ".Trim();
        Console.WriteLine(y.Trim());
    }

    private static string removedollar(string str)
    {
        // var newArr = str.Split("$");
        // newArr.
        // var newStr = string.Join()
        // return str.Split("$").Join(t => {
            
        // });
        var newArr = str.Split("$");
        Array.ForEach(newArr, t => {
            t = t.Trim();
        });
        return string.Join(" ", newArr);
    }
}