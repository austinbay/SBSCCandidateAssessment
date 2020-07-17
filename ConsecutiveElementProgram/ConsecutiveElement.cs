using System;
using System.Linq;

namespace ConsecutiveElementProgram
{
    //Problem
    // Given a string of hyphen separated numbers return true where k is the same
    // for all numbers otherwise return false. 

    // k is the interval between a number and the next.

    //Solution
    //Simple solution will be to sort the array and check if elements are consecutive just by 
    //iterative over array.

    //Steps
    //Find minimum and maximum element in the array.
    //Check if max-min+1==n, if elements are consecutive then this condition should meet.
    //Create a visited boolean array.
    //Iterate over the array and check
    //visited [arr[i]-min] is true, then return false as elements are repeated.
    //mark the element visited

    public class ConsecutiveElement
    {

        public static void Main(string[] args)
        {
            var cep = new ConsecutiveElement();
            var inputString = "47-43-45-44-46";
            int[] inputValues = inputString.Split('-').Select(int.Parse).ToArray();

            if (cep.ContainsConsecutiveElements(inputValues, inputValues.Length))
                Console.WriteLine("True");

            else
                Console.WriteLine("False");
            return;
        }
        // This method checks if array elements are consecutive
        public bool ContainsConsecutiveElements(int[] inputValues, int n)
        {
            if (n < 1)
                return false;

            int min = GetMinimum(inputValues, n);
            int max = GetMaximum(inputValues, n);

            if (max - min + 1 == n)
            {
                bool[] visited = new bool[inputValues.Length];
                for (int i = 0; i < n; i++)
                {
                    if (visited[inputValues[i] - min] != false)
                        return false;

                    visited[inputValues[i] - min] = true;
                }

                return true;
            }
            return false;
        }
        // Method return minimum value
        private int GetMinimum(int[] inputValues, int n)
        {
            int min = inputValues[0];
            for (int i = 1; i < n; i++)
                if (inputValues[i] < min)
                    min = inputValues[i];
            return min;
        }

        // Method return maximum value
        private int GetMaximum(int[] inputValues, int n)
        {
            int max = inputValues[0];
            for (int i = 1; i < n; i++)
                if (inputValues[i] > max)
                    max = inputValues[i];
            return max;
        }


    }

}
