Search Insert Position

Problem Description
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order. 
The algorithm must have $O(\log n)$ runtime complexity.

Solution Approach
To strictly satisfy the $O(\log n)$ runtime complexity requirement, this problem is solved using a standard **Binary Search** algorithm.
1. We initialize two pointers, `left` at the beginning and `right` at the end of the array.
2. In a `while` loop, we calculate the `mid` index. To prevent integer overflow, `mid` is calculated as `left + (right - left) / 2`.
3. If the element at `mid` matches the `target`, we immediately return `mid`.
4. If the element is smaller than the `target`, the search space is halved by moving the `left` pointer to `mid + 1`.
5. If the element is larger, the `right` pointer is moved to `mid - 1`.
6. If the target is not found by the time the loop terminates, the `left` pointer naturally indicates the correct sequential insertion index.

Technologies Used
- C#
