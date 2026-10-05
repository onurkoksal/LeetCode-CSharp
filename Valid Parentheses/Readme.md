Valid Parentheses

Problem Description
Given a string `s` containing just the characters `'('`, `')'`, `'{'`, `'}'`, `'['` and `']'`, determine if the input string is valid. 
An input string is valid if open brackets are closed by the same type of brackets in the correct order, and every close bracket has a corresponding open bracket.

Solution Approach
This problem is classically and optimally solved using a **Stack (LIFO)** data structure.
1. We iterate through the string character by character.
2. If the character is an opening bracket (`(`, `[`, `{`), we push it onto the stack.
3. If the character is a closing bracket, we first check if the stack is empty. If it is, there is no matching opening bracket, so we return `false`.
4. If the stack is not empty, we pop the top element and verify if it matches the correct corresponding opening bracket for the current closing character. If it mismatches, we return `false`.
5. After parsing the entire string, the stack should be perfectly empty if all brackets were matched correctly. We return `true` if `stack.Count == 0`, otherwise `false`.
6. Time complexity is $O(n)$ as we traverse the string exactly once, and space complexity is $O(n)$ in the worst-case scenario.

Technologies Used
- C# (Stack)
