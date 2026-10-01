Find the Index of the First Occurrence in a String

Problem Description
Given two strings `needle` and `haystack`, 
return the index of the first occurrence of `needle` in `haystack`, or `-1` if `needle` is not part of `haystack`.

Solution Approach
Instead of relying on built-in string functions like `IndexOf()`, this solution manually implements a **Sliding Window / String Matching** algorithm. 
1. The outer loop iterates through the `haystack`. The iteration boundary is strictly set to `haystack.Length - needle.Length` to prevent index out-of-bound errors.
2. For each starting position, an inner loop checks if the subsequent characters match the `needle`.
3. If a mismatch occurs, the inner loop breaks, and the outer loop moves to the next starting character.
4. If the inner loop successfully traverses the entire length of the `needle` without breaking, the current starting index is returned.
5. If the outer loop completes without finding any full match, `-1` is returned.

Technologies Used
- C#
