Longest Common Prefix

Problem Description
Write a function to find the longest common prefix string amongst an array of strings. If there is no common prefix, return an empty string `""`.

Solution Approach
This problem is efficiently solved using a **Vertical Scanning** technique. 
1. We iterate through the characters of the first string in the array, using it as our baseline.
2. For each character index, we iterate through the rest of the strings in the array to check if they have the exact same character at that specific index.
3. If we reach the end of any string (meaning it is shorter than the baseline) or if a character mismatch is found, we immediately halt the scan.
4. We then extract and return the substring from the baseline string, from the beginning up to the current index.
5. If the loops complete without any mismatches, it means the entire first string is the common prefix for all strings.
6. The time complexity is $O(S)$, where $S$ is the sum of all characters in all strings, as we only scan characters until a mismatch is found.

Technologies Used
- C#
