Roman to Integer

Problem Description
Given a roman numeral string `s`, convert it to an integer. 
Roman numerals are represented by seven different symbols: `I`, `V`, `X`, `L`, `C`, `D`, and `M`. 
The conversion generally involves adding the values of the symbols from left to right. 
However, if a smaller symbol appears before a larger symbol, its value is subtracted instead of added.

Solution Approach
This solution maps each Roman numeral character to its corresponding integer value using a **Hash Map (Dictionary)** for $O(1)$ constant time lookups. 
1. We iterate through the given string from left to right.
2. For each character, we compare its integer value with the value of the next character.
3. If the current value is less than the next value, it represents a subtractive combination (e.g., `IV` or `IX`). We subtract the current value from the total sum.
4. Otherwise, we simply add the current value to the total sum.
5. This single-pass iteration evaluates the string in $O(n)$ time complexity, where $n$ is the length of the string.

Technologies Used
- C# (Dictionary / Hash Map)
