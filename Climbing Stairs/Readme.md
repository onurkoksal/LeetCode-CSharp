Climbing Stairs

Problem Description
You are climbing a staircase. It takes `n` steps to reach the top. 
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Solution Approach
This problem is mathematically identical to the **Fibonacci Sequence**, 
where the number of ways to reach step `n` is the sum of the ways to reach step `n-1` and step `n-2`. 

To solve this optimally, a **Bottom-Up Dynamic Programming** approach is used with space optimization.
1. Base cases for $n = 1$ and $n = 2$ are explicitly handled, returning 1 and 2 respectively.
2. Instead of an array to store the results of all subproblems (which would require $O(n)$ space), we only maintain the results of the last two steps using two integer variables (`a` and `b`).
3. We iterate from step 3 up to $n$. In each iteration, the current step's ways (`next`) are calculated as the sum of `a` and `b`.
4. We then shift our variables forward: `a` becomes `b`, and `b` becomes the newly calculated `next`.
5. This yields an optimal time complexity of $O(n)$ and a space complexity of $O(1)$.

Technologies Used
- C# (Dynamic Programming)
