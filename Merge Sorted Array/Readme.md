Merge Sorted Array

Problem Description
You are given two integer arrays `nums1` and `nums2`, sorted in non-decreasing order, and two integers `m` and `n`, representing the number of valid elements in `nums1` and `nums2` respectively. `nums1` has a total length of `m + n`, where the last `n` elements are set to `0` and should be ignored. The goal is to merge `nums2` into `nums1` as one sorted array, modified in-place.

Solution Approach
To achieve an $O(m + n)$ time complexity and avoid overwriting the existing elements in `nums1`, we use a **Three-Pointer** technique starting from the end of the arrays.
1. We set pointer `i` at the end of the valid elements in `nums1` (`m - 1`).
2. We set pointer `j` at the end of `nums2` (`n - 1`).
3. We set pointer `k` at the very end of `nums1` (`m + n - 1`), which is the last empty spot (the `0`s).
4. We iterate backwards while `j >= 0`. At each step, we compare `nums1[i]` and `nums2[j]`.
5. We place the larger of the two elements at `nums1[k]` and decrement `k` along with the pointer of the chosen array (`i` or `j`).
6. If `nums1` is exhausted first (`i < 0`), the remaining elements from `nums2` are directly copied over. If `nums2` is exhausted first, the remaining elements in `nums1` are already in their correct sorted positions.
7. Space complexity is $O(1)$ since all modifications are done in-place within `nums1`.

Technologies Used
- C# (In-place Array Manipulation, Reverse Three Pointers)
