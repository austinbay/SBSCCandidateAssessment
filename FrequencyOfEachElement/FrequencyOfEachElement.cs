using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequencyOfEachElementProgram
{
	//Problem
	//Given a string compute how many times a letter occurs in the string and
	//return it formatted such that every non-repeated letter in the string is
	//followed by its number of occurrences.

	//Solution
	//What we can do is, we keep a frequency array and loop through the array, and every time we find 
	//any element we go to the frequency array and add 1 to the previous frequency of that element in the frequency array.
    //After the loop ends, we are left with an array where at every index their frequency in the original array is present.
    //And also the biggest plus point along with its efficiency is, We don’t necessarily need the array to be sorted.

	public class FrequencyOfEachElement
    {
        public static void Main(string[] args)
        {

			var inputString = "occurrence";
			
			Dictionary<char, int> freqDic = SolveIterative(inputString);
			var result = string.Empty;
			foreach (char val in freqDic.Keys)
			{
				result += string.Format("{0}{1}", val, freqDic[val]);						
			}

			Console.WriteLine(result);

		}

		public static Dictionary<char, int> SolveIterative(string inputString)
		{
			Dictionary<char, int> freqDic = new Dictionary<char, int>();
			var arr = inputString.Trim().ToLower().ToArray();
			/* iterate through the array for contributing +1 
			 * as a frequency of that element, every time it is encountered.*/
			foreach (char val in arr)
			{
				if (!freqDic.ContainsKey(val))
				{
					/* if hashmap doesnt contains that element, 
					 * this means this is the first time the element is encountered,
					 * therefor freq of this element will be one for now.*/
					freqDic[val] = 1;
				}
				else
				{
					/* if hashmap contains this element, 
					 * so now its updated frequency will be its past frequency + 1.
					 */
					freqDic[val] = freqDic[val] + 1;
				}
			}
			return freqDic;
		}
	}

}
