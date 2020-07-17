# SBSCCandidateAssessment

Tools used to solve to the problems

1. Visual Studio 2019
2. .Net Core 3.1
3. Console application


Problem 1
    Given a string of hyphen separated numbers return true where k is the same
    for all numbers otherwise return false. 
    k is the interval between a number and the next.

Solution
    Simple solution will be to sort the array and check if elements are consecutive just by 
    iterative over array.

    Steps
    Find minimum and maximum element in the array.
    Check if max-min+1==n, if elements are consecutive then this condition should meet.
    Create a visited boolean array.
    Iterate over the array and check
    visited [arr[i]-min] is true, then return false as elements are repeated.
    mark the element visited
	
	
	
	
Problem 2
    Given an ordered list of integers you are expected to find the absolute
    difference D, then insert D into the list. Do this until the difference between
    all integers exist in the list then return the Kth integer. If the Kth integer cannot
    be found return -1.
	
    Hint: no integer must exist more than once.
    D is the absolute difference between an integer and the next.
    K is the position of an integer in the list.
	
	
Solution
    An Efficient Solution is based on Binary Search.

    1) Sort the given array a[].
    2) We can easily find the least possible absolute
       difference in O(n) after sorting. The largest
       possible difference will be a[n-1] - a[0] after
       sorting the array. Let low = minimum_difference
       and high = maximum_difference.
    3) while low < high:
    4)     mid = (low + high)/2
    5)     if ((number of pairs with absolute difference
                                <= mid) < k):
    6)        low = mid + 1
    7)     else:
    8)        high = mid
    9) return low	
	
	
	
Problem 3
	Given a string compute how many times a letter occurs in the string and
	return it formatted such that every non-repeated letter in the string is
	followed by its number of occurrences.

Solution
	What we can do is, we keep a frequency array and loop through the array, and every time we find 
	any element we go to the frequency array and add 1 to the previous frequency of that element in the frequency array.
    After the loop ends, we are left with an array where at every index their frequency in the original array is present.
    And also the biggest plus point along with its efficiency is, We don’t necessarily need the array to be sorted.
	
	
	
	