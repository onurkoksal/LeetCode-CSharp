Remove Duplicates from Sorted Array

Problem Description
Given an integer array `nums` sorted in non-decreasing order, remove the duplicates **in-place** such that each unique element appears only once. 
The relative order of the elements should be kept the same. Return `k`, which is the number of unique elements.

Solution Approach
Since the array is already sorted, any duplicate numbers will be adjacent to each other. This allows us to use a **Two-Pointer** technique to solve the problem in $O(n)$ time and $O(1)$ space.
1. We use a write pointer, `k`, initialized to `1`, because the element at index `0` is always strictly the first unique element and doesn't need to be moved.
2. We use a read pointer, `i`, in a `for` loop, also starting from `1` and going to the end of the array.
3. In each iteration, we compare the current element `nums[i]` with the previous element `nums[i - 1]`.
4. If they are different, it means we have discovered a new unique number. We copy this number to the position indicated by the write pointer (`nums[k] = nums[i]`) and then increment `k`.
5. If they are the same, we simply continue scanning (skipping the duplicate).
6. Finally, we return `k`, representing the length of the modified array containing only unique elements.

Technologies Used
- C# (In-place Array Manipulation, Two Pointers)
