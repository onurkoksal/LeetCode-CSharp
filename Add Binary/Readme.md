Add Binary

Problem Description
Given two binary strings `a` and `b`, return their sum as a binary string. 
The constraints specify that the strings can be up to 10,000 characters long, which prevents parsing them directly into standard integer data types to avoid overflow.

Solution Approach
This problem requires simulating fundamental addition digit-by-digit from right to left, closely mirroring manual arithmetic.
1. We use two pointers, `i` and `j`, starting at the last indices of strings `a` and `b`, respectively, along with a `carry` variable tracking the overflow value.
2. We loop as long as either string has remaining digits, or there is a leftover `carry`. This single `while` loop cleanly handles inputs of unequal lengths and final carry rollovers.
3. In each iteration, we convert the current `char` to an `int` by subtracting the char `'0'`. Missing digits from the shorter string are implicitly treated as `0`.
4. We calculate the sum of the digits plus the `carry`. The current digit to write is `sum % 2`, and the new carry for the next position is `sum / 2`.
5. Since we calculate from right to left, we use a `StringBuilder` to append the calculated digits efficiently, and then reverse the final string before returning it.
6. The time complexity is $O(\max(N, M))$ and space complexity is $O(\max(N, M))$ where $N$ and $M$ are the lengths of the input strings.

Technologies Used
- C# (StringBuilder, ASCII Math)
