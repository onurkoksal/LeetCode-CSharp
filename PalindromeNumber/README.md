Palindrome Number

Problem Description
Given an integer `x`, return `true` if `x` is a palindrome, and `false` otherwise. A palindrome is a number that reads the same backward as forward

Solution Approach
While this problem can be easily solved by converting the integer to a string, 
this solution uses a **purely mathematical approach** to avoid unnecessary memory allocation and improve performance.

The algorithm steps are as follows:
1. **Initial Check:** Negative numbers are immediately returned as `false` since the minus sign prevents them from being palindromes.
2. **Reversing the Number:** We extract the last digit using the modulo operator (`% 10`) and mathematically rebuild the reversed number step-by-step (`reversedNumber = (reversedNumber * 10) + digit`).
3. **Comparison:** Finally, we compare the mathematically reversed number with the original stored number to determine if it is a palindrome.


Technologies Used
- C# 
