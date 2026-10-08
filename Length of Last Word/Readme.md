Length of Last Word

Problem Description
Given a string `s` consisting of words and spaces, return the length of the last word in the string. 
A word is a maximal substring consisting of non-space characters only. The string may contain trailing spaces.

Solution Approach
This problem is solved optimally by scanning the string backwards (from right to left) to avoid unnecessary processing of the entire string.
1. We initialize a `length` counter to 0.
2. We iterate from the last character of the string down to the first.
3. If we encounter a space (`' '`):
   - If our `length` is still 0, it means we are dealing with trailing spaces at the end of the string. We simply continue scanning.
   - If our `length` is greater than 0, it means we have already processed the characters of the last word and hit the space separating it from the previous word. We immediately break out of the loop.
4. If we encounter a non-space character, we increment the `length` counter.
5. Finally, we return the calculated `length`.
6. This approach guarantees an $O(n)$ time complexity in the worst-case scenario, and often performs much faster (e.g., $O(1)$) if the last word is near the end. Space complexity is $O(1)$.

Technologies Used
- C# (String Manipulation, Backward Iteration)
