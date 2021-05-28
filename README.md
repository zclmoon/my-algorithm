## Brian Kernighan's Algorithm

The expression n & (n-1) can be used to turn off the rightmost set bit of a number n. 
This works as the expression n-1 flips all the bits after the rightmost set bit of n, including the rightmost set bit itself. 
Therefore, n & (n-1) results in the last bit flipped of n.


201. Bitwise AND of Numbers Range: https://leetcode.com/problems/bitwise-and-of-numbers-range/

Given two integers left and right that represent the range [left, right], return the bitwise AND of all numbers in this range, inclusive.

Input: left = 5, right = 7
Output: 4

Input: left = 0, right = 0
Output: 0

Input: left = 1, right = 2147483647
Output: 0

Constraints: 0 <= left <= right <= 2^31 - 1
