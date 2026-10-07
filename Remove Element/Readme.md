Remove Element

Problem Description
Given an integer array `nums` and an integer `val`, remove all occurrences of `val` in `nums` **in-place**. 
The order of the elements may be changed. The function must return `k`, which represents the number of elements in `nums` that are not equal to `val`. 
The first `k` elements of the array must contain the valid elements.

Solution Approach
This problem is solved optimally using a **Two-Pointer** technique to satisfy the $O(1)$ auxiliary space constraint (in-place modification).
1. We use a write pointer, `k`, initialized to 0. This pointer tracks the index where the next valid element should be placed.
2. A read pointer, `i`, iterates through the entire array.
3. For each element at index `i`, we check if it is not equal to `val`. 
4. If it is a valid element (`nums[i] != val`), we copy it to the position pointed to by `k` (`nums[k] = nums[i]`) and then increment `k`.
5. If the element equals `val`, we simply bypass it.
6. The process completes in a single pass, resulting in an $O(n)$ time complexity and $O(1)$ space complexity.

Technologies Used
- C# (In-place Array Manipulation, Two Pointers)
