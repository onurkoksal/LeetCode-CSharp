Same Tree

Problem Description
Given the roots of two binary trees `p` and `q`, write a function to check if they are the same or not. Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

Solution Approach
We can solve this using **Recursion** (Depth-First Search) by traversing both trees simultaneously.
1. **Base Case 1 (Both Null):** If both current nodes `p` and `q` are `null`, it means we have reached the end of a branch safely and they match structurally up to this point. We return `true`.
2. **Base Case 2 (Mismatch):** If only one of the nodes is `null`, or if both nodes exist but their values (`val`) are different, the trees are not identical. We return `false`.
3. **Recursive Step:** If both nodes exist and share the same value, we must verify their children. We recursively call `IsSameTree` on their left children AND their right children. The function will only return `true` if all subtrees evaluate to `true`.
4. The time complexity is $O(n)$, where $n$ is the number of nodes in the smaller tree, because we must visit each node at least once. The space complexity is $O(h)$, where $h$ is the height of the tree, representing the call stack during recursion.

Technologies Used
- C# (Binary Tree, Recursion, Depth-First Search)
