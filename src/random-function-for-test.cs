// // // using System;

// // // public class Challenge
// // // {
// // // 	public static string Solution(long[] arr)
// // // 	{
// // // 		if (arr.Length == 0)
// // // 			return "";
// // // 		double left = 0;
// // // 		double right = 0;
// // // 		int level = 1;
// // // 		int i = 1;
// // // 		while (i < arr.Length)
// // // 		{
// // // 			var numberOfElements = Convert.ToInt32(Math.Pow(2, level));
// // // 			var elements = getElements(arr, i, numberOfElements);
// // // 			/* foreach(var item in elements)
// // // 			{
// // // 				Console.WriteLine(item.ToString());
// // // 			} */
// // // 			for (int k = 0; k < elements.Length / 2; k++)
// // // 			{
// // // 				if (elements[k] != -1)
// // // 					left += elements[k];
// // // 			}

// // // 			for (int k = elements.Length / 2; k < elements.Length; k++)
// // // 			{
// // // 				if (elements[k] != -1)
// // // 					right += elements[k];
// // // 			}

// // // 			i += numberOfElements;
// // // 			level++;
// // // 		}

// // // 		Console.WriteLine("left", left);
// // // 		Console.WriteLine("right", right);
// // // 		if (left == right)
// // // 			return "";
// // // 		return left > right ? "Left" : "Right";
// // // 	}

// // // 	private static long[] getElements(long[] arr, int startIndex, int numberOfElements)
// // // 	{
// // // 		long[] a = new long[numberOfElements];
// // // 		int j = 0;
// // // 		for (int i = startIndex; i <= startIndex + numberOfElements - 1; i++, j++)
// // // 		{
// // // 			if (i < arr.Length)
// // // 				a[j] = arr[i];
// // // 		}

// // // 		foreach (var item in a)
// // // 		{
// // // 			Console.WriteLine(item);
// // // 		}

// // // 		return a;
// // // 	}
// // // }


// // // using System;
// // // using System.Collections.Generic;
// // // using System.Linq;
// // // using System.Text.RegularExpressions;

// // // public class Challenge 
// // // {
// // //     public static long Solution(long[] prices) 
// // // 	{
// // //         if(prices.Length == 0)
// // // 			return 0;

// // // 		long profit = 0;
// // // 		for(int i = 0; i < prices.Length; i++)
// // // 		{
// // // 			var cp = prices[i];
// // // 			var leftPrices = new long[prices.Length - i - 1];

// // // 			if(i != prices.Length - 1)
// // // 			{
// // // 				int k = i + 1;
// // // 				for(int j = 0; j < prices.Length - i - 1; j++, k++)
// // // 				{
// // // 					leftPrices[j] = prices[k];
// // // 				}
// // // 			}

// // // 			if(leftPrices.Length > 0)
// // // 				Array.Sort<long>(leftPrices);

// // // 			var sp = leftPrices.Length > 0 ? leftPrices[leftPrices.Length - 1] : 0;
// // // 			var pfit = sp - cp;
// // // 			if(pfit > profit)
// // // 				profit = pfit;
// // // 		}

// // // 		return profit;
// // //     }
// // // }



// // // using System;
// // // using System.Collections.Generic;
// // // using System.Linq;
// // // using System.Text.RegularExpressions;

// // // public class Challenge 
// // // {
// // //     public static long Solution(string s) 
// // // 	{
// // //         if (s.Length == 0)
// // // 			return 0;

// // // 		int maxUniqueLength = 1;
// // // 		for(int i = 0; i < s.Length; i++)
// // // 		{
// // // 			var substring = new string("");
// // // 			substring = String.Concat(substring,s[i]);
// // // 			// substring.Append(s[i]);
// // // 			for(int j = i+1; j < s.Length; j++)
// // // 			{
// // // 				if(!substring.Contains(s[j]))
// // // 				{	
// // // 					substring = String.Concat(substring,s[j]);
// // // 					if(maxUniqueLength < substring.Length)
// // // 						maxUniqueLength += 1;
// // // 				}
// // // 				else
// // // 					break;
// // // 			}
// // // 		}

// // // 		return maxUniqueLength;
// // //     }
// // // }


// // // using System;
// // // using System.Collections.Generic;
// // // using System.Linq;
// // // using System.Text.RegularExpressions;

// // // public class Challenge 
// // // {
// // // 	public static long Solution(long n) 
// // // 	{
// // // 			if (n == 1 || n == 0)  
// // // 				return 1; 
// // // 			else if (n == 2)  
// // // 				return 2; 

// // // 			else
// // // 				return Solution(n - 3) +  
// // // 					Solution(n - 2) + 
// // // 					Solution(n - 1);  
// // // 	}
// // // }

// // // using System.Collections.Generic;

// // // class Solution
// // // {
// // //     public static List<int> plusOne(List<int> A) 
// // // 	{
// // // 		var B = A;
// // // 		for(int i = A.Count - 1; i >= 0; i--)
// // // 		{
// // // 			if(i != 0)
// // // 			{
// // // 				if(A[i] != 9)
// // // 				{
// // // 					B[i] = A[i] + 1;
// // // 					break;
// // // 				}
// // // 				else
// // // 				{
// // // 					B[i] = 0;
// // // 				}
// // // 			}
// // // 			else
// // // 			{
// // // 				if(A[i] != 9)
// // // 				{
// // // 					B[i] = A[i] + 1;
// // // 					break;
// // // 				}
// // // 				else
// // // 				{
// // // 					B[i] = 0;
// // // 					var C = new List<int>();
// // // 					C.Add(1);
// // // 					C.InsertRange(1, B);
// // // 					B = C;
// // // 				}
// // // 			}
// // // 		}

// // // 		var numberOfZeroes = 0;
// // // 		foreach(var item in B)
// // // 		{
// // // 			if(item != 0)
// // // 				break;

// // // 			numberOfZeroes++;
// // // 		}
// // // 		B = B.GetRange(numberOfZeroes, B.Count - numberOfZeroes);
// // // 		return B;
// // //     }
// // // }


// // // using System.Collections.Generic;
// // // using System.Linq;

// // // class Solution 
// // // {
// // //     public static int hotel(List<int> A, List<int> B, int C) 
// // // 	{
// // // 		var calendar = new List<int>(B.Max());
// // // 		var x = A.Min();
// // // 		var y = B.Max();
// // // 		for(int i = 0; i <= y; i++)
// // // 		{
// // // 			calendar.Add(0);
// // // 		}

// // // 		for(int i = 0; i < A.Count; i++)
// // // 		{
// // // 			for(int j = A[i]; j < B[i]; j++)
// // // 			{
// // // 				calendar[j]++;
// // // 			}
// // // 		}

// // // 		return calendar.Max() > C ? 0 : 1;
// // //     }
// // // }

// // // using System;
// // // using System.Collections;
// // // using System.Collections.Generic;
// // // using System.Linq;

// // // class Solution 
// // // {
// // //     public static string largestNumber(List<int> A) 
// // // 	{
// // // 		var comparer = new customComparer();
// // // 		A.Sort(comparer);
// // // 		var numberOfZeroes = 0;
// // //  		foreach(var item in A)
// // //  		{
// // //  			if(item != 0)
// // //  				break;

// // //  			numberOfZeroes++;
// // //  		}
// // //  		A = A.GetRange(numberOfZeroes, A.Count - numberOfZeroes);
// // // 		if (A.Count == 0)
// // // 		return "0";
// // // 		// data.Select(x => x.ToString()).ToArray()
// // // 		return string.Join("",A.Select(x => x.ToString()).ToArray());
// // //     }
// // // }

// // // class customComparer : IComparer<int>
// // // {
// // //     public int Compare(int x, int y)
// // //     {
// // // 		if (x == y)
// // // 			return 0;

// // // 		var r = Convert.ToDouble(String.Concat(x.ToString(), y.ToString())) > Convert.ToDouble(string.Concat(y.ToString(), x.ToString())) ? 
// // // 			-1 : 1;
// // // 		return r;
// // //     }
// // // }

// // // using System.Collections.Generic;

// // // class Solution 
// // // {
// // //     public static List<List<int>> generateMatrix(int A) 
// // // 	{
// // // 		var list = new List<List<int>>(A);
// // // 		for(int i = 0; i < A; i++)
// // // 		{
// // // 			var subList = new List<int>(i+1);
// // // 			list.Add(subList);
// // // 			for(int j = 0; j <= i; j++)
// // // 			{
// // // 				if(i == 0 && j == 0)
// // // 				{
// // // 					subList.Add(1);
// // // 				}
// // // 				else
// // // 				{
// // // 					var p1 = i != 0 && j != i ? list[i-1][j] : 0;
// // // 					var p2 = j != 0 && i != 0 ? list[i-1][j-1] : 0;
// // // 					// list[i][j] = p1+p2;
// // // 					subList.Add(p1+p2);
// // // 				}
// // // 			}
// // // 			// list.Add(subList);
// // // 		}
// // // 		return list;
// // //     }
// // // }

// // // using System.Collections.Generic;
// // // using System;

// // // class Solution 
// // // {
// // //     public static int firstMissingPositive(List<int> A) 
// // // 	{
// // // 		A.Sort();
// // // 		var i = 1;
// // // 		foreach(var item in A)
// // // 		{
// // // 			if(item < 1)
// // // 				continue;

// // // 			if (item != i)
// // // 				break;

// // // 			i++;
// // // 		}
// // // 		return i;
// // //     }
// // // }

// // using System;
// // using System.Collections.Generic;
// // using System.Linq;

// // class Solution 
// // {
// //     public static int maxSpecialProduct(List<int> A) 
// //     {
// //         // if (A.Count == 0)
// // 		// 	return 0;

// // 		// var right = new List<int>(A.Count);
// // 		// var left = new List<int>(A.Count);

// // 		// for(int i = 0; i < A.Count; i++)
// // 		// {
// // 		// 	var rightElement = 0;
// // 		// 	if(i != A.Count - 1)
// // 		// 	{
// // 		// 		var z = A.GetRange(i+1, A.Count - 1 -i);
// // 		// 		for(int j = i+1; j < A.Count; j++)
// // 		// 		{
// // 		// 			if(A[j] > A[i])
// // 		// 			{
// // 		// 				rightElement = j;
// // 		// 				break;
// // 		// 			}
// // 		// 		}
// // 		// 	}
// // 		// 	right.Add(rightElement);
			
// // 		// 	var leftElement = 0;
// // 		// 	if(i != 0)
// // 		// 	{
// // 		// 		for(int j = i-1; j > 0; j--)
// // 		// 		{
// // 		// 			if(A[j]>A[i])
// // 		// 			{
// // 		// 				leftElement = j;
// // 		// 				break;
// // 		// 			}
// // 		// 		}
// // 		// 	}			
// // 		// 	left.Add(leftElement);
// // 		// }

// // 		// var specialProd = new List<int>(A.Count);
// // 		// for(int i = 0; i < A.Count; i++)
// // 		// {
// // 		// 	specialProd.Add(right[i]*left[i]);
// // 		// }
// // 		// return specialProd.Max() % 1000000007;

// // 		var left = nextGreaterInLeft(A); 
      
// //         // for each element storing the index of just 
// //         // greater element in right side 
// //         var right = nextGreaterInRight(A); 
// //         int ans = -1; 
// //         for (int i = 1; i <= A.Count; i++) { 
      
// //             // finding the max index product 
// //             ans = Math.Max(ans, left[i] * right[i]); 
// //         } 
      
// //         return ans; 
// //     }

// // 	static int MAX = 1000; 
      
// //     // function to find just next greater 
// //     // element in left side 
// //     static int[] nextGreaterInLeft(List<int> a) 
// //     { 
// // 		// var left_index = new List<int>(MAX);
// //         int []left_index = new int[MAX]; 
// //         Stack<int> s = new Stack<int>(); 
      
// //         for (int i = a.Count - 1; i >= 0; i--) { 
      
// //             // checking if current element is  
// //             // greater than top 
// //             while (s.Count != 0 && a[i] > a[s.Peek() - 1]) 
// //             { 
// //                 int r = s.Peek(); 
// //                 s.Pop(); 
      
// //                 // on index of top store the current 
// //                 // element index which is just greater 
// //                 // than top element 
// //                 left_index[r - 1] = i; 
// //             } 
      
// //             // else push the current element in stack 
// //             s.Push(i + 1); 
// //         } 
// //         return left_index; 
// //     } 
      
// //     // function to find just next greater element 
// //     // in right side 
// //     static int[] nextGreaterInRight(List<int> a) 
// //     { 
// // 		// var right_index = new List<int>();
// //         int []right_index = new int[MAX]; 
// //         Stack<int> s = new Stack<int>(); 
// //         for (int i = 0; i < a.Count; ++i) { 
      
// //             // checking if current element is 
// //             // greater than top 
// //             while (s.Count != 0 && a[i] > a[s.Peek() - 1])  
// //             { 
// //                 int r = s.Peek(); 
// //                 s.Pop(); 
      
// //                 // on index of top store the current 
// //                 // element index which is just greater 
// //                 // than top element stored index should 
// //                 // be start with 1 
// //                 right_index[r - 1] = i; 
// //             } 
      
// //             // else push the current element in stack 
// //             s.Push(i + 1); 
// //         } 
// //         return right_index; 
// //     } 
      
// //     // Function to find maximum LR product 
// //     // static int LRProduct(int []arr, int n) 
// //     // { 
          
// //     //     // for each element storing the index of just 
// //     //     // greater element in left side 
// //     //     var left = nextGreaterInLeft(arr, n); 
      
// //     //     // for each element storing the index of just 
// //     //     // greater element in right side 
// //     //     var right = nextGreaterInRight(arr, n); 
// //     //     int ans = -1; 
// //     //     for (int i = 1; i <= n; i++) { 
      
// //     //         // finding the max index product 
// //     //         ans = Math.Max(ans, left[i] * right[i]); 
// //     //     } 
      
// //     //     return ans; 
// //     // } 
// // }

// using System;

// public class Answer
// {
// 	public static bool Exists(int[] ints, int k)
// 	{
// 		return Array.Exists(ints, t => t ==k);
// 	}
// }

// class A
// {
// 	public string str;
// }

// class B:A
// {
// 	str = "new";
// }


// using System;
// using System.Collections.Generic;
// using System.Linq;
					
// public class Program
// {
// 	public static void Main()
// 	{
		
// 	}
	
// 	private static int Sum(int[] arr)
// 	{
// 		return arr.Where(t => t%2 == 0).ToArray().Sum();
// 	}
// }