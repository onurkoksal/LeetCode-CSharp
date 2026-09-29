Sqrt(x)

Problem Description
Given a non-negative integer `x`, compute and return the square root of `x` rounded down to the nearest integer. 
The problem restricts the use of any built-in exponent functions or operators.

Solution Approach
This problem is efficiently solved using the Binary Search algorithm with $O(\log n)$ time complexity. 
- The search space starts from `1` to `x`. 
- To prevent `Integer Overflow` issues that usually occur when calculating `mid * mid`, the mathematical condition is re-arranged to use division instead: `mid == x / mid`.
- If a perfect square is not found, the algorithm records the nearest smaller value to return the rounded-down result.

Technologies Used
- C#
