Plus One

Problem Description
You are given a large integer represented as an integer array `digits`, where each `digits[i]` is the `i`th digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's. 
Increment the large integer by one and return the resulting array of digits.

Solution Approach
To handle potentially massive numbers (up to 100 digits or more) without integer overflow, we simulate manual addition from right to left using a backwards loop.
1. We iterate from the last element (`digits.Length - 1`) down to the first element (`0`).
2. If the current digit is `9`, we set it to `0`. The loop continues, naturally carrying over the "1" to the next significant digit (to the left).
3. If the current digit is less than `9`, we simply increment it by `1` and immediately return the array, as no further carries are needed.
4. If the loop finishes without returning, it means all digits were `9` (e.g., `[9, 9, 9]`), which have all been turned to `0`s.
5. In this case, we instantiate a new array with a size of `digits.Length + 1`. By default, C# initializes all elements to `0`. We simply set the first element to `1` (e.g., `[1, 0, 0, 0]`) and return the new array.
6. The time complexity is $O(n)$ and space complexity is $O(1)$ in most cases, or $O(n)$ in the worst case where a new array is allocated.

Technologies Used
- C# (Array Manipulation, Right-to-Left Traversal)
