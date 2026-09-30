Two Sum

Problem Description
Given an array of integers `nums` and an integer `target`, 
return indices of the two numbers such that they add up to `target`. 
You may assume that each input would have exactly one solution, 
and you may not use the same element twice.

Solution Approach
While a brute-force approach using nested loops can solve this problem in $O(n^2)$ time, 
this solution is optimized to run in **$O(n)$ time complexity** using a **Hash Map (Dictionary)**.

The algorithm steps are as follows:
1. Iterate through the array exactly once.
2. For each element, calculate the `complement` needed to reach the `target` (i.e., `target - nums[i]`).
3. Check if this `complement` already exists in the Dictionary.
   - If it exists, we immediately return the indices of the complement and the current element.
   - If it does not exist, we store the current element and its index in the Dictionary for future reference.
4. This ensures a highly efficient, single-pass lookup without unnecessary redundant iterations.

Technologies Used
- C# (Dictionary / Hash Map)
